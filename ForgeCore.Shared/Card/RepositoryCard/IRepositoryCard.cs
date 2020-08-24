using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public interface IRepositoryCard
    {
        //Card GetCard(int id);
        List<Card> GetDeckCards(int playerID, Deck deck);
    }
}
