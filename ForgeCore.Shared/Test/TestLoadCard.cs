using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class TestLoaderCard
    {
        public static Card GetCard()
        {
            Card theFirstDraft = new Card(0);

            theFirstDraft.Background = GameForgeEngine.Instance.Content.Load<Texture2D>(@"Images\card");

            Viewport viewport = GameForgeEngine.Instance.Graphics.GraphicsDevice.Viewport;

            Vector2 screenCenter = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            //Vector2 imageCenter = new Vector2(theFirstDraft.Background.Width / 2f, theFirstDraft.Background.Height / 2f);

            theFirstDraft.Position = screenCenter;

            return theFirstDraft;
        }
    }
}