using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ForgeCore.Shared
{
    public class TestLoaderCard
    {
        public static Card GetCardStack()
        {
            Card theFirstDraftCard = new Card(0);

            theFirstDraftCard.Background = GameForgeEngine.Instance.Content.Load<Texture2D>(@"Images\card");

            Viewport viewport = GameForgeEngine.Instance.Graphics.GraphicsDevice.Viewport;

            Vector2 screenCenter = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            //Vector2 imageCenter = new Vector2(theFirstDraft.Background.Width / 2f, theFirstDraft.Background.Height / 2f);

            theFirstDraftCard.Position = screenCenter;
            theFirstDraftCard.SetCardState(new CardStateStack(theFirstDraftCard));

            return theFirstDraftCard;
        }

        public static Card GetCardDetail()
        {
            Card theFirstDraftCard = new Card(0);

            theFirstDraftCard.Background = GameForgeEngine.Instance.Content.Load<Texture2D>(@"Images\card");

            Viewport viewport = GameForgeEngine.Instance.Graphics.GraphicsDevice.Viewport;

            Vector2 screenCenter = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            //Vector2 imageCenter = new Vector2(theFirstDraft.Background.Width / 2f, theFirstDraft.Background.Height / 2f);

            theFirstDraftCard.Position = screenCenter;
            theFirstDraftCard.SetCardState(new CardStateDetail(theFirstDraftCard));

            return theFirstDraftCard;
        }

        public static Card GetCardHand()
        {
            Card theFirstDraftCard = new Card(0);

            theFirstDraftCard.Background = GameForgeEngine.Instance.Content.Load<Texture2D>(@"Images\card");

            Viewport viewport = GameForgeEngine.Instance.Graphics.GraphicsDevice.Viewport;

            Vector2 screenCenter = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            //Vector2 imageCenter = new Vector2(theFirstDraft.Background.Width / 2f, theFirstDraft.Background.Height / 2f);

            theFirstDraftCard.Position = screenCenter;
            theFirstDraftCard.SetCardState(new CardStateHand(theFirstDraftCard));

            return theFirstDraftCard;
        }

        public static Card GetCardBoard()
        {
            Card theFirstDraftCard = new Card(0);

            theFirstDraftCard.Background = GameForgeEngine.Instance.Content.Load<Texture2D>(@"Images\card");

            Viewport viewport = GameForgeEngine.Instance.Graphics.GraphicsDevice.Viewport;

            Vector2 screenCenter = new Vector2(viewport.Width / 2f, viewport.Height / 2f);
            //Vector2 imageCenter = new Vector2(theFirstDraft.Background.Width / 2f, theFirstDraft.Background.Height / 2f);

            theFirstDraftCard.Position = screenCenter;
            theFirstDraftCard.SetCardState(new CardStateBoard(theFirstDraftCard));

            return theFirstDraftCard;
        }

    }
}