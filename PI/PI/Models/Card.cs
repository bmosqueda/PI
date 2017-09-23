
namespace PI.Models
{
    class Card
    {
        private int id;
        private int cardValue;
        private string question;
        private string[] answers;
        private string correctAnswer;

        public int Id
        {
            get { return id; }
            set { if (value > 0) id = value; }
        }

        public int CardValue
        {
            get { return cardValue; }
            set { if (value > 0) cardValue = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }

        public string[] Answers
        {
            get { return answers; }
            set { if (value.Length == 4) answers = value; }
        }

        public string CorrectAnswer
        {
            get { return correctAnswer; }
            set { correctAnswer = value; }
        }
    }
}