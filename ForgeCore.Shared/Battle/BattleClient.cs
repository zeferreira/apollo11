using System;

namespace ForgeCore.Shared
{
    public class BattleClient : GameObject
    {
        private EnumBattleState _battleState;
        public EnumBattleState BattleState { get => _battleState; set => _battleState = value; }
        
        Player _opponent;
        public Player Opponent { get => _opponent; set => _opponent = value; }

        Player _player;
        public Player Player { get => _player; set => _player = value; }

        Player _actualPlayerTurn;
        Player _nextPlayerTurn;

        Player _winner;
        public Player Winner { get => _winner; set => _winner = value; }
        
        //turn
        bool _firstTurn;
        bool _turnFinished;
        bool _turnTimeIsOver;

        float currentTime = 0f;

        public BattleClient()
        {
            currentTime = 0f;
            this._firstTurn = true;
        }

        public BattleClient(Player topPlayer, Player downPlayer)
        {
            this._turnFinished = false;
            this._firstTurn = true;
            this._battleState = EnumBattleState.Start;
            this.Player = downPlayer;
            this.Opponent = topPlayer;
        }

        public void Update()
        {
            if (!BattleIsFinished())
            {
                if (TurnTimeIsFinished())
                {
                    this._actualPlayerTurn.HasFinishedCommands();

                    this._actualPlayerTurn = this._nextPlayerTurn;

                }
            }
            this.Opponent.Update();
            this.Player.Update();
        }

        public void Draw()
        {
            this.Opponent.Draw();
            this.Player.Draw();
        }

        public bool BattleIsFinished()
        {
            
            return false;
        }

        private bool TurnTimeIsFinished()
        {
            int counter = 1;
            int limit = 50;
            float countDuration = 2f; //every  2s.
            //float currentTime = 0f;

            currentTime += (float)GameForgeEngine.Instance.MaxElapsedTime.TotalSeconds; //Time passed since last Update() 

            if (currentTime >= countDuration)
            {
                counter++;
                currentTime -= countDuration; // "use up" the time
                                              //any actions to perform
                this._turnTimeIsOver = true;
            }
            else
            {
                this._turnTimeIsOver = false;
            }

            if (counter >= limit)
            {
                counter = 0;//Reset the counter;
                            //any actions to perform
            }

            return this._turnTimeIsOver;
        }
    }
}