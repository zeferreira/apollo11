using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public interface IDeviceInteractionObserver
    {
        void Update(IDeviceInteracionEvent e);
    }
}
