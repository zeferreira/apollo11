using System;
using System.Collections.Generic;
using System.Text;

namespace ForgeCore.Shared
{
    public interface IGameState
    {
        void LoadContent();

        void UnloadContent();

        void Update();

        void Draw();
    }
}
