using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.UI;
using static Terraria.ModLoader.ModContent;

namespace Elementaria.UI
{
    class ResourceBar : UIState
    {
        private UIElement screenPos;
        private UIImage barFrame;
        private Color gradientA;
        private Color gradientB;

        public override void OnInitialize()
        {
            screenPos = new UIElement();
            screenPos.Width.Set(178, 0);
            screenPos.Height.Set(50f, 0);

            barFrame = new UIImage(GetTexture("Elementaria/UI/UltimateBar"));
            barFrame.Width.Set(162f, 0);
            barFrame.Height.Set(46f, 0);

            gradientA = new Color(67, 57, 0);
            gradientB = new Color(246, 218, 79);

            screenPos.Append(barFrame);
            Append(screenPos);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            /*if (!Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ClassMageEquipped)
            if (!Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ClassWarriorEquipped)
            if (!Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ClassSummonerEquipped)
            if (!Main.LocalPlayer.GetModPlayer<ElementariaPlayer>().ClassRangerEquipped)
                return;*/

            base.Draw(spriteBatch);
        }

        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);
            var modPlayer = Main.LocalPlayer.GetModPlayer<ElementariaPlayer>();

            // Calculate current progress in the resource bar
            decimal currentProgress = (decimal)modPlayer.ResourceBarCurrent / (decimal)modPlayer.ResourceBarMax;
            currentProgress = Utils.Clamp(currentProgress, 0, 1);

            // Get screen dimensions of our resource bar frame and adjust the rectangle position to match the inside of the resource bar frame
            Rectangle barFrameHitbox = barFrame.GetInnerDimensions().ToRectangle();
            barFrameHitbox.X += 32;
            barFrameHitbox.Width -= 24;
            barFrameHitbox.Y += 16;
            barFrameHitbox.Height -= 16;

            // Draw vertical lines while interpolating both colors
            int left = barFrameHitbox.Left;
            int right = barFrameHitbox.Right;
            int steps = (int)((right - left) * currentProgress);
            for (int i = 0; i < steps; i += 1)
            {
                float percent = (float)i / (right - left);
                spriteBatch.Draw(Main.magicPixel, new Rectangle(left + i, barFrameHitbox.Y, 1, barFrameHitbox.Height), Color.Lerp(gradientA, gradientB, percent));
            }
        }

        public override void Update(GameTime gameTime)
        {
            // Updating the Resource Bar position based on screen size
            screenPos.Left.Set(Main.screenWidth - 190f, 0);
            screenPos.Top.Set(Main.screenHeight - 66f, 0);

            base.Update(gameTime);
        }
    }
}
