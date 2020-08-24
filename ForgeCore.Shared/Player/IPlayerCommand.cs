using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public abstract class IPlayerCommand
    {
        private bool _isCanceled = false;
        private bool _isFinished = false;

        public abstract void Update(GameObject gameObject);
        public abstract void Cancel();

        public abstract void Draw();

        public virtual bool HasFinished()
        {
            return _isFinished;
        }
        public virtual bool HasCanceled()
        {
            return _isCanceled;
        }

        public virtual bool CanCancel()
        {
            return false;
        }

    }
}