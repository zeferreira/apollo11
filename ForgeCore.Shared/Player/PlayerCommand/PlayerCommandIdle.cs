using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public class PlayerCommandIdle : IPlayerCommand
    {
        private bool _isCanceled = false;
        private bool _isFinished = false;

        public override void Update(GameObject gameObject)
        {
            this._isCanceled = false;
            this._isFinished = true;
        }

        public override void Cancel()
        {

        }

        public override void Draw()
        {

        }

        public override bool HasFinished()
        {
            return _isFinished;
        }
        public override bool HasCanceled()
        {
            return _isCanceled;
        }

        public override bool CanCancel()
        {
            return true;
        }

    }
}