using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceInteracionEventTouch_old : IDeviceInteracionEvent
    {
        Point _position;
        public Point Position { get => _position; set => _position = value; }

        private bool _pressed;
        public bool Pressed { get => _pressed; set => _pressed = value; }

        //private bool _rightButtonPressed;
        //public bool RightButtonPressed { get => _rightButtonPressed; set => _rightButtonPressed = value; }

        //private bool _leftButtonPressed;
        //public bool LeftButtonPressed { get => _leftButtonPressed; set => _leftButtonPressed = value; }

    }
}
