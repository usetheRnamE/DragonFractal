using System.Drawing;

namespace Fractals
{
    class ColorSwitch
    {
        private readonly RandomNumGenerator randomNum = new RandomNumGenerator();

        private const int colorRandomRange = 100000;
        public Color ColorSwitcher()
        {
            return Color.FromArgb(randomNum.NumGenerate(colorRandomRange));
        }
    }
}
