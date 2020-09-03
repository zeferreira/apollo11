using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class Player
    {
        private long _id;
        public long ID { get => _id; set => _id = value; }

        private byte _life;
        public byte Life { get => _life; set => _life = value; }

        private List<Card> _handOfCards;
        public List<Card> HandOfCards { get => _handOfCards; set => _handOfCards = value; }

        private List<Card> _cardsOnTheboard;
        public List<Card> CardsOnTheboard { get => _cardsOnTheboard; set => _cardsOnTheboard = value; }

        private List<Card> _cemiteryOfCards;
        public List<Card> CemiteryOfCards { get => _cemiteryOfCards; set => _cemiteryOfCards = value; }

        private List<Card> _cardsOnTheStack;
        public List<Card> CardsOnTheStack { get => _cardsOnTheStack; set => _cardsOnTheStack = value; }


        public Player()
        {
            this._handOfCards = new List<Card>();
            this._cardsOnTheboard = new List<Card>();
            this._cardsOnTheStack = new List<Card>();
        }

        public bool HasFinishedCommands()
        {
            return false;
        }

        public void Update()
        {
            //throw new NotImplementedException();
        }

        public void Draw()
        {
            DrawHand();
        }

        #region private_methods

        private void DrawHand()
        {
            foreach (var item in this._handOfCards)
            {
                item.Draw();
            }
        }

        #endregion private_methods
    }
}