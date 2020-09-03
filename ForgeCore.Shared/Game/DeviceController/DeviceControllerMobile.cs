using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceControllerMobile : IDeviceController
    {
        private DeviceControllerState _deviceState;

        public void Update()
        {
            this._deviceState = new DeviceControllerState();

            if (GamePad.GetState(0).Buttons.Back == ButtonState.Pressed) 
            {
                _deviceState.Q = true;
            }
        }

        public DeviceControllerState GetInputState()
        {
            return this._deviceState;
        }
    }
}
