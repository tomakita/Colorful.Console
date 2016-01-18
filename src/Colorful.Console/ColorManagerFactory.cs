using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Colorful
{
    public sealed class ColorManagerFactory
    {
        public ColorManagerFactory()
        {
        }

        public ColorManager GetManager(ColorStore colorStore, int maxColorChanges, int initialColorChangeCountValue)
        {
            return new ColorManager(colorStore, GetColorMapper(), maxColorChanges, initialColorChangeCountValue);
        }

        public ColorManager GetManager(Dictionary<Color, ConsoleColor> colorMap, Dictionary<ConsoleColor, Color> consoleColorMap, int maxColorChanges, int initialColorChangeCountValue)
        {
            ColorStore colorStore = GetColorStore(colorMap, consoleColorMap);
            ColorMapper colorMapper = GetColorMapper();

            return new ColorManager(colorStore, colorMapper, maxColorChanges, initialColorChangeCountValue);
        }

        private ColorStore GetColorStore(Dictionary<Color, ConsoleColor> colorMap, Dictionary<ConsoleColor, Color> consoleColorMap)
        {
            return new ColorStore(colorMap, consoleColorMap);
        }

        private ColorMapper GetColorMapper()
        {
            return new ColorMapper();
        }
    }
}
