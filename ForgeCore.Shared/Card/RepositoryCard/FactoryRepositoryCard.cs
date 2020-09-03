using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class FactoryRepositoryCard
    {
        private static volatile FactoryRepositoryCard _instance;
        private static readonly object _padLock = new object();

        public static FactoryRepositoryCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                            _instance = new FactoryRepositoryCard();
                    }
                }

                return _instance;
            }
        }

        private FactoryRepositoryCard()
        { }


        public IRepositoryCard GetRepositoryCard()
        {
            lock (_padLock)
            {
                return new RepositoryCardTest();
            }
            
        }


    }
}
