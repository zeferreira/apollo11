using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class Deck
    {
        private int? _playerID;
        public int? PlayerID { get => _playerID; set => _playerID = value; }

        private int? _id;
        public int? Id { get => _id; set => _id = value; }

        private List<int> _cardsIds;
        public List<int> CardsIds { get => _cardsIds; set => _cardsIds = value; }

        public Stack<Card> GetCardsForStack()
        {
            IRepositoryCard _repositoryCard = new RepositoryCardTest();

            List<Card> cardset = _repositoryCard.GetDeckCards(this._playerID.Value, this);

            Util.Shuffle<Card>(cardset);

            Stack<Card> _result = new Stack<Card>();

            foreach (var item in cardset)
            {
                _result.Push(item);
            }

            return _result;
        }
    }
}
