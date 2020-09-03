using System.Collections.Generic;


namespace ForgeCore.Shared
{
    public class PlayerControlerClient : IPlayerControler
    {
        private IDeviceInteraction _deviceInteraction;

        private Player _owner;
        private IGameState _gameState;

        private IPlayerCommand _actualCommand;

        public PlayerControlerClient(Player owner, IGameState gameState)
        {
            this._owner = owner;
            this._actualCommand = null;
            this._deviceInteraction = FactoryDeviceInteraction.Instance.GetDeviceInteraction();
        }

        public void Update()
        {
            this._deviceInteraction.Update();

            DeviceInteracionEvent ev = this._deviceInteraction.GetLastEvent();

            //percorrer a lista de objetos do player para saber o que fazer.
            //cards in hand 
            //board cards on the board
            //não vai interagir com os objetos do oponente.
            //preciso de acesso a batalha?  ou melhor simplificar o motor?
        }

        public IPlayerCommand GetCommand(GameObject obj)
        {
            return null;
        }
        
    }
}