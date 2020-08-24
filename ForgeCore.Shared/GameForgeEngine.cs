#region Using Statements
using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace ForgeCore.Shared
{
    public class GameForgeEngine : Game
    {
        private static volatile GameForgeEngine _instance;
        private static readonly object _padLock = new object();

        public static GameForgeEngine Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                            _instance = new GameForgeEngine();
                    }
                }

                return _instance;
            }
        }

        GraphicsDeviceManager _graphics;
        public GraphicsDeviceManager Graphics { get => _graphics; }
        
        //game state
        private IGameState _gameState;
        public IGameState GameState { get => _gameState; set => _gameState = value; }

        private IDeviceController _deviceController;
        public IDeviceController DeviceController { get => _deviceController; set => _deviceController = value; }

        private GameForgeEngine()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
#if ANDROID
            _graphics.IsFullScreen = true;
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 480;
            _graphics.SupportedOrientations = DisplayOrientation.LandscapeLeft | DisplayOrientation.LandscapeRight;
            this.DeviceController = new DeviceControllerMobile();
#elif LINUX
            _graphics.IsFullScreen = false;
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            this.DeviceController = new DeviceControllerKeyBoard();
#endif
            this.GameState = new GameStatePlaying(this);
            //this.GameState = new GameStatePlayerWin(this,new GameStatePlaying(this));

        }

        protected override void Initialize()
        {
            IsFixedTimeStep = true;  //Force the game to update at fixed time intervals
            TargetElapsedTime = TimeSpan.FromSeconds(1 / 60.0f);  //Set the time interval to 1/30th of a second

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.GameState.LoadContent();
        }

        protected override void Update(GameTime gameTime)
        {

            this.GameState.Update();

            // TODO: Add your update logic here			
            base.Update(gameTime);

            //            // For Mobile devices, this logic will close the Game when the Back button is pressed
            //            // Exit() is obsolete on iOS
            //#if !__IOS__ && !__TVOS__
            //            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
            //                Keyboard.GetState().IsKeyDown(Keys.Escape))
            //            {
            //_gameBase.Exit();
            //            }
            //#endif
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            //"gameTime" is of type GameTime
            double fps = 1f / gameTime.ElapsedGameTime.TotalSeconds;

            //            spriteBatch.Begin();
            //#if ANDROID
            //            spriteBatch.DrawString(font, "Hello World! This is the Android project: " + fps.ToString(), new Vector2(100, 100), Color.White);
            //#elif LINUX
            //            spriteBatch.DrawString(font, "Hello World! This is the OpenGL project: " + fps.ToString(), new Vector2(100, 100), Color.White);
            //#endif
            //            spriteBatch.End();

            this.GameState.Draw();
            base.Draw(gameTime);
        }

    }
}
