#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace ForgeCore.Shared
{
    public class GameStateQuit : IGameState
    {
        Game _gameBase;

        public GameStateQuit(Game gameBase)
        {
            this._gameBase = gameBase;
        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update()
        {
//            // For Mobile devices, this logic will close the Game when the Back button is pressed
//            // Exit() is obsolete on iOS
//#if !__IOS__ && !__TVOS__
//            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
//                Keyboard.GetState().IsKeyDown(Keys.Escape))
//            {
                _gameBase.Exit();
//            }
//#endif
        }

        public void Draw()
        {

        }
    }
}
