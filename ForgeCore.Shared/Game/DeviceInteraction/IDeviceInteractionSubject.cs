using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public abstract class IDeviceInteractionSubject
    {
        protected List<IDeviceInteractionObserver> _observers = new List<IDeviceInteractionObserver>();

        public abstract void Update();
        
        public void Register(IDeviceInteractionObserver observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(IDeviceInteractionObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(IDeviceInteracionEvent e)
        {
            foreach (var item in this._observers)
            {
                item.Update(e);
            }
        }
    }
}
