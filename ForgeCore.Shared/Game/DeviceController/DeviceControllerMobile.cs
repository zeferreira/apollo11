using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceControllerMobile : IDeviceController
    {
        private DeviceState _deviceState;

        public void Update()
        {
            this._deviceState = new DeviceState();

            if (GamePad.GetState(0).Buttons.Back == ButtonState.Pressed) 
            {
                _deviceState.Q = true;
            }
        }

        public DeviceState GetInputState()
        {
            return this._deviceState;
        }
    }
}
