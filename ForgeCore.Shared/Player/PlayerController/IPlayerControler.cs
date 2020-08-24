using System.Collections.Generic;

namespace ForgeCore.Shared
{
    public interface PlayerControler
    {
        //void Update();
        IPlayerCommand GetCommand(Player player);
    }
}