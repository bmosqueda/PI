using System;
using System.IO;
using PI.Models;

namespace PI.Controllers
{
    class CardController
    {
        private FileStream cardConf;

        private static CardController cardCtrlInstance;

        private CardController()
        {
            cardConf = new FileStream("/configs/cards_config.brnw", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
        }

        public static CardController CardCtrlInstance
        {
            get
            {
                if (cardCtrlInstance == null) cardCtrlInstance = new CardController();
                return cardCtrlInstance;
            }
        }

        public bool CreateCard(Card card)
        {
            cardConf.Seek(cardConf.Length,SeekOrigin.Current);

            return false;
        }

    }
}
