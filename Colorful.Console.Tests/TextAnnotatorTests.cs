using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Colorful;
using System.Drawing;

namespace Colorful.Console.Tests
{
    [TestFixture]
    public sealed class TextAnnotatorTests
    {
        private static readonly string dummyMatchingString = "cat";
        private static readonly string dummyNonMatchingString = "dog";
        private static readonly string dummyPattern = "a";
        private static readonly Color dummyDefaultColor = Color.Red;
        private static readonly Color dummyStyledColor = Color.Yellow;

        private StyleSheet GetDummyStyleSheet()
        {
            StyleSheet styleSheet = new StyleSheet(dummyDefaultColor);
            styleSheet.AddStyle(dummyPattern, dummyStyledColor);

            return styleSheet;
        }

        [Test]
        public void GetAnnotationMap_ReturnsInput_WhenInputAndPatternAreNonoverlapping()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyNonMatchingString);

            Assert.AreEqual(annotationMap.Single().Key, dummyNonMatchingString);
        }

        [Test]
        public void GetAnnotationMap_ReturnsThreeMatches_WhenInputAndPatternOverlap()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyMatchingString);

            Assert.AreEqual(annotationMap.Count, 3);
        }

        [Test]
        public void GetAnnotationMap_ReturnsPermutationOfInput()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyMatchingString);
            string mapConcatenated = String.Join("", annotationMap.Select(element => element.Key));

            Assert.AreEqual(mapConcatenated, dummyMatchingString);
        }
    }
}
