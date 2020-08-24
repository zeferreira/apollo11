using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class CardStateInHand : ICardState
    {
        private Card _card;
        private SpriteBatch _spriteBatch;

        public CardStateInHand(Card card)
        {
            this._card = card;
            this._spriteBatch = new SpriteBatch(GameForgeEngine.Instance.GraphicsDevice);
        }

        public void Draw()
        {
            Vector2 imageCenter = new Vector2(_card.Background.Width / 2f, _card.Background.Height / 2f);

            this._spriteBatch.Begin();
            this._spriteBatch.Draw(_card.Background, _card.Position, null, Color.White, 0f, imageCenter, 0.8f, SpriteEffects.None, 0f);
            this._spriteBatch.End();
        }

        public void Update()
        {

        }
    }
}