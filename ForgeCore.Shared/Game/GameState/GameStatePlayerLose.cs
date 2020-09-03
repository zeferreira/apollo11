#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace ForgeCore.Shared
{
    public class GameStatePlayerLose : IGameState
    {
        GameForgeEngine _gameBase;
        IGameState _lastGamePlaingState;

        SpriteFont _font;

        SpriteBatch _spriteBatch = new SpriteBatch(GameForgeEngine.Instance.GraphicsDevice);

        public GameStatePlayerLose(GameForgeEngine gameBase, IGameState lastGamePlaingState)
        {
            this._gameBase = gameBase;
            this._lastGamePlaingState = lastGamePlaingState;

            _spriteBatch = new SpriteBatch(GameForgeEngine.Instance.GraphicsDevice);
            _font = _gameBase.Content.Load<SpriteFont>("font");

        }

        public void LoadContent()
        {

        }

        public void UnloadContent()
        {

        }

        public void Update()
        {
            this._gameBase.DeviceController.Update();

            DeviceControllerState inputState = this._gameBase.DeviceController.GetInputState();

            if (inputState.Q)
            {
                this._gameBase.GameState = new GameStateQuit(this._gameBase);
            }

        }

        public void Draw()
        {
            _lastGamePlaingState.Draw();

            _spriteBatch.Begin();

            _spriteBatch.DrawString(_font, "You Lose. ", new Vector2(200,200), Color.White);

            _spriteBatch.End();
        }
    }
}
