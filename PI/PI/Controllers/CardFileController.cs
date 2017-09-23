using System;
using System.IO;
using PI.Models;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace PI.Controllers
{
    class CardFileController
    {
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
