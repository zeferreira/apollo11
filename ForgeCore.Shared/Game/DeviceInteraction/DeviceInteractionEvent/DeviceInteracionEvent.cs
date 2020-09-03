using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public abstract class DeviceInteracionEvent
    {
        private Vector2 _position;
        public Vector2 Position { get => _position; set => _position = value; }

        private EnumDeviceInteracionEventType _eventType;
        public EnumDeviceInteracionEventType EventType { get => _eventType; set => _eventType = value; }

    }
}
