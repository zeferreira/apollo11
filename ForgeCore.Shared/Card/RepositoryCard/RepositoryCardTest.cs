using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class RepositoryCardTest : IRepositoryCard
    {
        //Card GetCard(int id);
        public List<Card> GetDeckCards(int playerID, Deck deck)
        {
            List<Card> result = new List<Card>();

            for (int i = 0; i < 10; i++)
            {
                result.Add(TestLoaderCard.GetCard());
            }

            return result;
        }
    }
}
