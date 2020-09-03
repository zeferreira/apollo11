using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;


namespace ForgeCore.Shared
{
    public class GameObjectDeviceInteraction : GameObject, IDeviceInteractionObserver
    {
        private bool _enable;
        //component active for events
        public bool Enable { get => _enable; set => _enable = value; }

        private Rectangle _objectArea;
        public Rectangle ObjectArea { get => _objectArea; set => _objectArea = value; }

        public GameObjectDeviceInteraction(Rectangle objectArea)
            : base()
        {
            this.ObjectArea = objectArea;
        }

        //events from EnumDeviceInteracionEventType.cs
        public bool OnEvent(DeviceInteracionEvent ev)
        {
            //object enabled?
            if (this._enable)
            {
                // Check if the mouse position is inside the object area (rectangle)
                if (ObjectArea.Contains(ev.Position))
                {
                    //throw event handler;
                    ThrowEvent(ev);
                    return true;
                }
            }

            return false;
        }

        //PressQuick, 
        //event occurs when the user press and release the touch over the control
        public delegate void OnPressQuick(GameObject obj, DeviceInteracionEvent ev);

        private OnPressQuick _onPressQuickEventHandler;
        public OnPressQuick OnPressQuickEventHandler { get => _onPressQuickEventHandler; set => _onPressQuickEventHandler = value; }

        //Pressed, 
        //event occurs when the user press the device over the control (and don't release)
        public delegate void OnPressed(GameObject obj, DeviceInteracionEvent ev);

        private OnPressed _onPressedEventHandler;
        public OnPressed OnPressedEventHandler { get => _onPressedEventHandler; set => _onPressedEventHandler = value; }

        //PressUp 
        // event occurs when the user release the device over the control
        public delegate void OnPressUp(GameObject obj, DeviceInteracionEvent ev);

        private OnPressUp _onPressUpEventHandler;
        public OnPressUp OnPressUpEventHandler { get => _onPressUpEventHandler; set => _onPressUpEventHandler = value; }

        public void Update(IDeviceInteracionEvent e)
        {
            throw new NotImplementedException();
        }

        #region Private_methods
        private void ThrowEvent(DeviceInteracionEvent ev)
        {
            switch (ev.EventType)
            {
                case EnumDeviceInteracionEventType.PressQuick:
                    OnPressQuickEventHandler(this, ev);
                    break;
                case EnumDeviceInteracionEventType.Pressed:
                    OnPressedEventHandler(this, ev);
                    break;
                case EnumDeviceInteracionEventType.PressUp:
                    OnPressUpEventHandler(this, ev);
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}
