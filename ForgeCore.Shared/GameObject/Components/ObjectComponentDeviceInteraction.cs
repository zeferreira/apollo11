using System;

namespace ForgeCore.Shared
{
    public class ObjectComponentDeviceInteraction : IObjectComponent
    {
        public void Update(GameObject sender)
        {
            
        }

        //events from EnumDeviceInteracionEventType.cs

        //PressQuick, 
        //event occurs when the user press and release the touch over the control
        public delegate void OnPressQuick(GameObject obj, DeviceInteracionEvent ev);

        //Pressed, 
        //event occurs when the user press the device over the control (and don't release)
        public delegate void OnPressed(GameObject obj, DeviceInteracionEvent ev);

        //PressUp 
        // event occurs when the user release the device over the control
        public delegate void OnPressUp(GameObject obj, DeviceInteracionEvent ev);

    }
}
