using System;
using System.IO;
using PI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PI.Controllers
{
    class CardFileController
    {
        public void AddCard(Card card)
        {
            string path = Directory.GetCurrentDirectory() + "\\config";

            Console.WriteLine("Checking directory exists...");
            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory not found. Attempt  to create directory: " + path);
                try
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Directory created.");
                }
                catch (UnauthorizedAccessException e)
                {
                    UnauthorizedAccessException accessException = 
                        new UnauthorizedAccessException("Fail to create directory. " + e.ToString(), e);
                    throw accessException;
                }
            }
            Console.WriteLine("Directory found.");

            try
            {
                Console.WriteLine("Trying to save card object.");
                File.AppendAllText(path + "\\JSONTest.json", JsonConvert.SerializeObject(card) + "\n\r");
                Console.WriteLine("Operation successful.");
            }
            catch (UnauthorizedAccessException e)
            {
                UnauthorizedAccessException accessException =
                    new UnauthorizedAccessException("Fail to save card object in config file. " + e.ToString(), e);
                throw accessException;
            }
        }

        public Card ReadCard(int id)
        {
            string path = Directory.GetCurrentDirectory() + "\\config";

            Console.WriteLine("Checking file exists...");
            if (File.Exists(path + "\\JSONTest.json"))
            {
                Console.WriteLine("File found.\n\rTrying to read file");
                string cardsJson = File.ReadAllText(path + "\\JSONTest.json");
                Console.WriteLine("File readed.");

                Console.WriteLine("Trying to retrive a especific object");

                if (cardsJson != null)
                {
                    while (cardsJson.IndexOf('}') != -1)
                    {
                        int startIndex = cardsJson.IndexOf('{');
                        int length = cardsJson.IndexOf('}') - startIndex + 1;
                        string card = cardsJson.Substring(startIndex, length);
                        cardsJson = cardsJson.Remove(startIndex, length);

                        if (card.Contains("\"Id\":" + id.ToString()))
                        {
                            Console.WriteLine("Card found");
                            return JsonConvert.DeserializeObject<Card>(card);
                        }
                        Console.WriteLine("Searching...");
                    }
                    Console.WriteLine("Card not found");
                    return null;
                }
                Console.WriteLine("File not found.");
            }
            return null;
        }

        public Card Test2()
        {
            try
            {
                Random rnd = new Random();

                List<Card> cardsInput = new List<Card>();
                Console.WriteLine("List of cards created");
                for (var i = 0; i < 20; i++)
                {
                    cardsInput.Add(new Card
                    {
                        Id = i + 1,
                        CardValue = rnd.Next(1, 4),
                        Question = "QUESTION",
                        Answers = new string[] { "CORRECT", "FAIL", "FAIL", "FAIL" },
                        CorrectAnswer = "CORRECT"
                    });
                    Console.WriteLine("Card added");
                }

                string path = Directory.GetCurrentDirectory() + "\\Test2";

                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Directory not  found, creating...");
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Directory Created, Success");
                }

                Console.WriteLine("Trying to save cards in file.");
                File.WriteAllText(path + "\\JSONTest.json", JsonConvert.SerializeObject(cardsInput));
                Console.WriteLine("Process success");

                Console.WriteLine("\n\r\n\r");

                Console.WriteLine("Checking file exist ...");
                if (File.Exists(path + "\\\\JSONTest.json"))
                {
                    Console.WriteLine("File found.\n\rTrying to read file");
                    string cardsJson = File.ReadAllText(path + "\\JSONTest.json");
                    Console.WriteLine("File readed.");

                    Console.WriteLine("Trying to retrive a especific object");
                    Console.WriteLine(cardsJson);
                    
                    if (cardsJson != null)
                    {
                        while (cardsJson.IndexOf('}') != -1)
                        {
                            int startIndex = cardsJson.IndexOf('{');
                            int length = cardsJson.IndexOf('}') - startIndex + 1;
                            string s = cardsJson.Substring(startIndex, length);
                            cardsJson = cardsJson.Remove(startIndex, length);
                            Console.WriteLine("Object retrived: " + s);
                            Console.WriteLine("Rest objects" + cardsJson);

                            if (s.Contains("\"Id\":17"))
                            {
                                Console.WriteLine("Card found");
                                return JsonConvert.DeserializeObject<Card>(s);
                            }
                        }
                        Console.WriteLine("Card not found");
                        return null;
                    }
                    Console.WriteLine("File content error, empty JSON");
                }


            } catch (Exception e) { Console.WriteLine(e.ToString()); }
            return null; 
        }

        public void Test1_Read()
        {
            try
            {
                string path = Directory.GetCurrentDirectory() + "\\Test\\JSONTest.json";
                if (File.Exists(path))
                {
                    List<Card> cards = JsonConvert.DeserializeObject<List<Card>>(
                        File.ReadAllText(path));

                    foreach (Card card in cards)
                        Console.WriteLine(card.ToString());
                }
            } catch (Exception e) { Console.WriteLine(e.ToString()); }
        }

        public void Test1_Write()
        {
            Random rnd = new Random();

            List<Card> cards = new List<Card>();
            for (var i = 0; i < 20; i++)
            {
                cards.Add(new Card
                {
                    Id = rnd.Next(1, 21),
                    CardValue = rnd.Next(1, 4),
                    Question = "QUESTION",
                    Answers = new string[] { "CORRECT", "FAIL", "FAIL", "FAIL" },
                    CorrectAnswer = "CORRECT"
                });
            }

            try
            {
                string path = Directory.GetCurrentDirectory() + "\\Test";

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Directory Created, Success");
                }

                File.WriteAllText(path + "\\JSONTest.json", JsonConvert.SerializeObject(cards));

            } catch (Exception) { }
        }

        public void Test()
        {
            Card card = new Card
            {
                Id = 1,
                CardValue = 1,
                Question = "Are you ready?",
                Answers = new string[] { "Yes", "No", "Maybe", "What?" },
                CorrectAnswer = "Yes"
            };

            Card card2 = new Card
            {
                Id = 2,
                CardValue = 2,
                Question = "Are you ready?",
                Answers = new string[] { "Yes", "No", "Maybe", "What?" },
                CorrectAnswer = "Yes"
            };
            
            string path = Directory.GetCurrentDirectory() + "\\Test";

            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Directory Created, Success");
                }

                File.AppendAllText(path + "\\JSONTest.js", JsonConvert.SerializeObject(card));
                Console.WriteLine("Text append: " + JsonConvert.SerializeObject(card));
                File.AppendAllText(path + "\\JSONTest.js", JsonConvert.SerializeObject(card2));
                Console.WriteLine("Text append");

            } catch (Exception) { }
        }
    }
}
