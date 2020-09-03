using Microsoft.Xna.Framework;

namespace ForgeCore.Shared
{
    public interface ICardState
    {
        //interaction state for devices
        Rectangle GetObjectArea();
        bool GetEnable(); 

        void Draw();//really need this?
        void Update();
    }
}