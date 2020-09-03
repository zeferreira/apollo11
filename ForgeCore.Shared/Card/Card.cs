using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class Card : GameObjectDeviceInteraction
    {
        //cost, attack, resistence, text notes
        //nature, effect 

        int? _cardId;
        public int? CardId { get => _cardId; set => _cardId = value; }

        //
        int? _cost;
        public int? Cost { get => _cost; set => _cost = value; }

        int? _attack;
        public int? Attack { get => _attack; set => _attack = value; }

        int? _resistence;
        public int? Resistence { get => _resistence; set => _resistence = value; }

        string _textNote;
        public string TextNote { get => _textNote; set => _textNote = value; }

        private Vector2 _position;
        public Vector2 Position { get => _position; set => _position = value; }

        private Texture2D _background;
        public Texture2D Background { get => _background; set => _background = value; }

        //
        private ICardState _cardState;
        public ICardState CardState { get => _cardState;  }

        private EnumCardType _cardType;
        public EnumCardType CardType { get => _cardType; set => _cardType = value; }

        public Card(int cardID)
            :base(new Rectangle())
        {
            //initial state don't have permisson to interact with the user
            this.Enable = false;

            this._cardId = cardID;
            this._components = new List<IObjectComponent>();
        }

        public override void Update()
        {
            this._cardState.Update();
            base.Update();
        }

        public void Draw()
        {
            this._cardState.Draw();
        }

        //colocar a logica da mudança de estado aqui
        public void SetCardState(ICardState newCardState)
        {
            this._cardState = newCardState;
        }

        private void ChangeCardState(ICardState newCardState)
        {
            this.ObjectArea = newCardState.GetObjectArea();
            this.Enable = newCardState.GetEnable();

            if (newCardState is CardStateStack)
            {
                
            }
            else if (newCardState is CardStateHand)
            {
                
            }
            else if (newCardState is CardStateBoard)
            {
                
            }
            else if (newCardState is CardStateCemetery)
            {
                
            }
        }





    }
}
