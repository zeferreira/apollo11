using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceControllerKeyBoard : IDeviceController
    {
        private DeviceState _deviceState;

        KeyboardState _keysCurrent;
        KeyboardState _keysLast;

        public void Update()
        {
            this._deviceState = new DeviceState();

            _keysLast = _keysCurrent;
            _keysCurrent = Keyboard.GetState();

            if (_keysCurrent.IsKeyDown(Keys.Q) && _keysLast.IsKeyUp(Keys.Q))
            {
                _deviceState.Q = true;
            }

            if (_keysCurrent.IsKeyDown(Keys.Escape) && _keysLast.IsKeyUp(Keys.Escape))
            {
                _deviceState.Q = true;
            }

            if (_keysCurrent.IsKeyDown(Keys.P) && _keysLast.IsKeyUp(Keys.P))
            {
                _deviceState.P = true;
            }
        }

        public DeviceState GetInputState()
        {
            return this._deviceState;
        }
    }
}
