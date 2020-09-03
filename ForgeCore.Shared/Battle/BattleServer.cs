using System;

namespace ForgeCore.Shared
{
    public class BattleServer
    {
        private int _initialCardHandNumber;

        private EnumBattleState _battleState;
        public EnumBattleState BattleState { get => _battleState; set => _battleState = value; }
        
        Player _playerTop;
        public Player PlayerTop { get => _playerTop; set => _playerTop = value; }

        Player _playerDown;
        public Player PlayerDown { get => _playerDown; set => _playerDown = value; }

        Player _actualPlayerTurn;
        Player _nextPlayerTurn;

        Player _winner;
        public Player Winner { get => _winner; set => _winner = value; }
        
        //turn
        bool _firstTurn;
        bool _turnFinished;
        bool _turnTimeIsOver;

        float currentTime = 0f;

        public BattleServer()
        {
            currentTime = 0f;
            this._firstTurn = true;
            _initialCardHandNumber = 3;
        }

        public BattleServer(Player topPlayer, Player downPlayer)
        {
            this._turnFinished = false;
            this._firstTurn = true;
            this._battleState = EnumBattleState.Start;
            this.PlayerDown = downPlayer;
            this.PlayerTop = topPlayer;
        }

        public void Update()
        {
            //firstTurn
            if (this._firstTurn)
            {
                SelectFirstTurn();

                this._firstTurn = false;
            }

            if (!BattleIsFinished())
            {
                if (this._actualPlayerTurn.HasFinishedCommands() || TurnTimeIsFinished())
                {
                    this._actualPlayerTurn = this._nextPlayerTurn;

                    GetNextCardFromStack(this.PlayerDown);
                    GetNextCardFromStack(this.PlayerTop);
                }

            }
            this.PlayerTop.Update();
            this.PlayerDown.Update();
        }

        public void Draw()
        {
            this.PlayerTop.Draw();
            this.PlayerDown.Draw();
        }

        public bool BattleIsFinished()
        {
            if (this.PlayerTop.Life <= 0 && this.PlayerDown.Life <= 0)
            {
                this._battleState = EnumBattleState.Draw;
                return true;
            }

            if ((this.PlayerTop.Life <= 0) )
            {
                this._battleState = EnumBattleState.Finished;
                this.Winner = this.PlayerDown;
                return true;
            }

            if ((this.PlayerDown.Life <= 0) )
            {
                this._battleState = EnumBattleState.Finished;
                this.Winner = this.PlayerTop;
                return true;
            }

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

        private void SelectFirstTurn()
        {
            //RNG base
            //https://docs.microsoft.com/pt-br/dotnet/api/system.random?view=netcore-3.1
            Random rnd = new Random();

            int coin = rnd.Next(0, 1);

            if (coin == 0)
            {
                _actualPlayerTurn = PlayerTop;
                _nextPlayerTurn = PlayerDown;
            }
            else
            {
                _actualPlayerTurn = PlayerDown;
                _nextPlayerTurn = PlayerTop;
            }
        }

        private void GetNextCardFromStack(Player player)
        {
            if (player.CardsOnTheStack.Count > 0)
            {
                player.HandOfCards.Add(player.CardsOnTheStack[0]);

                player.CardsOnTheStack.RemoveAt(0);
            }
            else
                player.Life--;
        }

        private void GetInitialCardHandFromStack(Player player)
        {
            if (player.CardsOnTheStack.Count > 0)
            {
                player.HandOfCards.Add(player.CardsOnTheStack[0]);

                player.CardsOnTheStack.RemoveAt(0);
            }
            else
                player.Life--;
        }

    }
}