using System;
using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class FactoryDeviceController
    {
        private static volatile FactoryDeviceController _instance;
        private static readonly object _padLock = new object();

        public static FactoryDeviceController Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_padLock)
                    {
                        if (_instance == null)
                            _instance = new FactoryDeviceController();
                    }
                }

                return _instance;
            }
        }

        private FactoryDeviceController()
        { }


        public IDeviceController GetDeviceController()
        {
            lock (_padLock)
            {
#if ANDROID
                return new DeviceControllerMobile();
#elif LINUX
                return new DeviceControllerKeyBoard();
#endif
            }

        }


    }
}
