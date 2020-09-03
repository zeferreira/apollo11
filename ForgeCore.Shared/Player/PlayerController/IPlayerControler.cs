using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public interface IPlayerControler
    {
        void Update();
        IPlayerCommand GetCommand(GameObject obj);
    }
}

