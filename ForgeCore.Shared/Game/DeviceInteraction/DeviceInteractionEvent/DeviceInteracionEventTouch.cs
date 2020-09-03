using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class DeviceInteracionEventTouch : DeviceInteracionEvent
    {
        private bool _pressed;
        public bool Pressed { get => _pressed; set => _pressed = value; }
    }
}
