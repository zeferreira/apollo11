using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class FactoryDeviceInteraction
    {
        private static volatile FactoryDeviceInteraction _instance;
        private static readonly object _padLock = new object();

        public static FactoryDeviceInteraction Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                            _instance = new FactoryDeviceInteraction();
                    }
                }

                return _instance;
            }
        }

        private FactoryDeviceInteraction()
        { }


        public IDeviceInteraction GetDeviceInteraction()
        {
            lock (_padLock)
            {
#if ANDROID
                return new DeviceInteractionTouch();
#elif LINUX
                return new DeviceInteractionMouse();
#endif
            }

        }


    }
}
