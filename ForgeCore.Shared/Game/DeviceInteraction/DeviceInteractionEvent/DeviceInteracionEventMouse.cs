using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class DeviceInteracionEventMouse : DeviceInteracionEvent
    {
        private bool _rightButtonPressed;
        public bool RightButtonPressed { get => _rightButtonPressed; set => _rightButtonPressed = value; }

        private bool _leftButtonPressed;
        public bool LeftButtonPressed { get => _leftButtonPressed; set => _leftButtonPressed = value; }
    }
}
