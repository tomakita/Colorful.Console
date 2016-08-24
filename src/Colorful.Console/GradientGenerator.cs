using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace Colorful
{
    public sealed class GradientGenerator
    {
        public List<StyleClass<T>> GenerateGradient<T>(IEnumerable<T> input, Color startColor, Color endColor, int maxColorsInGradient)
        {
            List<T> inputAsList = input.ToList();
            int numberOfGrades = inputAsList.Count / maxColorsInGradient;
            int numberOfGradesRemainder = inputAsList.Count % maxColorsInGradient;

            List<StyleClass<T>> gradients = new List<StyleClass<T>>();
            Color previousColor = Color.Empty;
            T previousItem = default(T);
            Func<int, int> setProgressSymmetrically = remainder => remainder > 1 ? -1 : 0; // An attempt to make the gradient symmetric in the event that maxColorsInGradient does not divide input.Count evenly.
            Func<int, int> resetProgressSymmetrically = progress => progress == 0 ? -1 : 0; // An attempt to make the gradient symmetric in the event that maxColorsInGradient does not divide input.Count evenly.
            int colorChangeProgress = setProgressSymmetrically(numberOfGradesRemainder);
            int colorChangeCount = 0;

            Func<int, bool> isFirstRun = index => index == 0;
            Func<int, int, T, T, bool> shouldChangeColor = (index, progress, current, previous) => (progress > numberOfGrades - 1 && !current.Equals(previous) || isFirstRun(index));
            Func<int, bool> canChangeColor = changeCount => changeCount < maxColorsInGradient;

            for (int i = 0; i < inputAsList.Count; i++)
            {
                T currentItem = inputAsList[i];
                colorChangeProgress++;

                if (shouldChangeColor(i, colorChangeProgress, currentItem, previousItem) && canChangeColor(colorChangeCount))
                {
                    previousColor = GetGradientColor(i, startColor, endColor, inputAsList.Count);
                    previousItem = currentItem;
                    colorChangeProgress = resetProgressSymmetrically(colorChangeProgress);
                    colorChangeCount++;
                }

                gradients.Add(new StyleClass<T>(currentItem, previousColor));
            }

            return gradients;
        }

        private Color GetGradientColor(int index, Color startColor, Color endColor, int numberOfGrades)
        {
            int numberOfGradesAdjusted = numberOfGrades - 1;

            int rDistance = startColor.R - endColor.R;
            int gDistance = startColor.G - endColor.G;
            int bDistance = startColor.B - endColor.B;

            double r = startColor.R + (-rDistance * ((double)index / numberOfGradesAdjusted));
            double g = startColor.G + (-gDistance * ((double)index / numberOfGradesAdjusted));
            double b = startColor.B + (-bDistance * ((double)index / numberOfGradesAdjusted));

            Color graded = Color.FromArgb((int)r, (int)g, (int)b);
            return graded;
        }
    }
}
