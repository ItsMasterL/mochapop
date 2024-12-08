using Microsoft.Xna.Framework;
using MonoGame.Extended;
namespace Engine
{
    internal class ColorModifiers
    {
        public static Color Rainbow(Color color, GameTime gameTime)
        {
            HslColor color1 = color.ToHsl();
            float hue;
            float saturation;
            float lightness;
            color1.Destructure(out hue, out saturation, out lightness);
            hue += 30 * (float)gameTime.ElapsedGameTime.TotalSeconds;
            //if (hue > 1) hue = 0;
            Color color2 = new HslColor(hue, saturation, lightness).ToRgb();
            return color2;
        }
    }
}
