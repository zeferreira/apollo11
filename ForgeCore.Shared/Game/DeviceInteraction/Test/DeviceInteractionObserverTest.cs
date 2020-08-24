using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceInteractionObserverTest :IDeviceInteractionObserver
    {
        SpriteFont _font;

        public void Update(IDeviceInteracionEvent e)
        {
            GameForgeEngine _gamebase = GameForgeEngine.Instance;

            SpriteBatch _spriteBatch = new SpriteBatch(GameForgeEngine.Instance.GraphicsDevice);

            Point position = Point.Zero;
            bool button = false;
            if (e is DeviceInteracionEventMouse)
            {
                position = ((DeviceInteracionEventMouse)e).Position;
                button = ((DeviceInteracionEventMouse)e).LeftButtonPressed;
            }

            if (e is DeviceInteracionEventTouch)
            {
                position = ((DeviceInteracionEventTouch)e).Position;
                button = ((DeviceInteracionEventTouch)e).Pressed;
            }

            //  Load our spritefont file
            _font = _gamebase.Content.Load<SpriteFont>("font");

            if (button)
            {
                _spriteBatch.Begin();

                _spriteBatch.DrawString(_font, "Coordinates: ", position.ToVector2(), Color.White);

                _spriteBatch.End();
            }
        }
    }
}
