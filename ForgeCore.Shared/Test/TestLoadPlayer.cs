using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class TestLoadPlayer
    {
        /// <summary>
        /// Buid a player instance for static deck version (don't use a deck instance)
        /// </summary>
        /// <returns></returns>
        public static Player GetPlayerForBattle()
        {
            Player player = new Player();

            player.Life = 30;
            player.CardsOnTheStack = GetStackCards();
            
            return player;
        }

        private static List<Card> GetStackCards()
        {
            int deckSize = 30;

            List<Card> cards = new List<Card>(); 

            for (int i = 0; i < deckSize; i++)
            {
                cards.Add(TestLoaderCard.GetCard());
            }

            return cards;
        }
    }
}