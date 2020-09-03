using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public class DeviceInteractionSubjecTouch : IDeviceInteractionSubject
    {

        public DeviceInteractionSubjecTouch()
        {
            this._observers = new List<IDeviceInteractionObserver>();
        }

        public override void Update()
        {
            DeviceInteracionEventTouch e = new DeviceInteracionEventTouch();

            TouchCollection touchCollection = TouchPanel.GetState();

            foreach (var item in touchCollection)
            {
                if (item.State == TouchLocationState.Pressed)
                {
                    //do what you want here when users tap the screen
                    e.Pressed = true;
                    e.Position = item.Position;
                }
            }

            //Notify(e);
        }
    }
}
