using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class Card : GameObject
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
        public ICardState CardState { get => _cardState; set => _cardState = value; }

        private EnumCardType _cardType;
        public EnumCardType CardType { get => _cardType; set => _cardType = value; }

        public Card(int cardID)
            :base()
        {
            this._cardId = cardID;
            this._components = new List<IObjectComponent>();
            this._cardState = new CardStateDetail(this);
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

        public void AddComponent(IObjectComponent c)
        {
            this._components.Add(c);
        }
    }
}
