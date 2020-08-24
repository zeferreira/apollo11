#region Using Statements
using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

#endregion

namespace ForgeCore.Shared
{

    public class GameStatePlaying_ : IGameState
    {
        GameForgeEngine _gameBase;
        
        IDeviceInteractionSubject _deviceInteracionSubject;

        List<GameObject> _gameObjects;

        Battle _battle;

        public GameStatePlaying_(GameForgeEngine gameBase)
        {
            this._gameBase = gameBase;
            this._gameObjects = new List<GameObject>();
            this._battle = new Battle();
        }

        public void LoadContent()
        {
            this._battle = new Battle(TestLoadPlayer.GetPlayerForBattle(), TestLoadPlayer.GetPlayerForBattle());
        }

        public void UnloadContent()
        {
            
        }

        public void Update()
        {
            //controls
            this._gameBase.DeviceController.Update();

            DeviceState inputState = this._gameBase.DeviceController.GetInputState();
            
            if (inputState.Q)
            {
                this._gameBase.GameState = new GameStateQuit(this._gameBase);
            }
            else if (inputState.P)
            {
                IGameState lastGameState = this._gameBase.GameState;
                this._gameBase.GameState = new GameStatePaused(this._gameBase, lastGameState);
            }

            //game state           
            switch (this._battle.BattleState)
            {
                case EnumBattleState.Start:
                    break;
                case EnumBattleState.Playing:
                    break;
                case EnumBattleState.Finished:
                    if (this._battle.Winner.ID == this._battle.PlayerDown.ID)
                    {
                        IGameState lastgame = this._gameBase.GameState;
                        this._gameBase.GameState = new GameStatePlayerWin(_gameBase, lastgame);
                    }
                    else if (this._battle.Winner.ID == this._battle.PlayerTop.ID)
                    {
                        IGameState lastgame = this._gameBase.GameState;
                        this._gameBase.GameState = new GameStatePlayerLose(_gameBase, lastgame);
                    }
                    break;
                case EnumBattleState.Draw:

                    break;
                default:
                    break;
            }

            this._battle.Update();
        }

        public void Draw()
        {
            //? really need?
            //maybe for apply the effects
            this._battle.Draw();
        }

        private void LoadSubSystems()
        {
            //interaction device
#if ANDROID
            this._deviceInteracionSubject = new DeviceInteractionSubjecTouch();
#elif LINUX
            this._deviceInteracionSubject = new DeviceInteractionSubjectMouse();
#endif
        }
    }
}
