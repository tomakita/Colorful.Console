using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Colorful;
using System.Drawing;

namespace Colorful.Console.Tests
{
    
    public sealed class TextAnnotatorTests
    {
        private static readonly string dummyMatchingString = "cat";
        private static readonly string dummyNonMatchingString = "dog";
        private static readonly string dummyPattern = "a";
        private static readonly string dummyOverlappingPatternOne = "ca";
        private static readonly string dummyOverlappingPatternTwo = "at";
        private static readonly Color dummyDefaultColor = Color.Red;
        private static readonly Color dummyStyledColor = Color.Yellow;
        private static readonly Color dummyStyledColorTwo = Color.Green;

        private StyleSheet GetDummyStyleSheet()
        {
            StyleSheet styleSheet = new StyleSheet(dummyDefaultColor);
            styleSheet.AddStyle(dummyPattern, dummyStyledColor);

            return styleSheet;
        }

        private StyleSheet GetDummyOverlappingStyleSheet()
        {
            StyleSheet styleSheet = new StyleSheet(dummyDefaultColor);
            styleSheet.AddStyle(dummyOverlappingPatternOne, dummyStyledColor);
            styleSheet.AddStyle(dummyOverlappingPatternTwo, dummyStyledColorTwo);

            return styleSheet;
        }

        [Fact]
        public void GetAnnotationMap_ReturnsInput_WhenInputAndPatternAreNonoverlapping()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyNonMatchingString);

            Assert.Equal(annotationMap.Single().Key, dummyNonMatchingString);
        }

        [Fact]
        public void GetAnnotationMap_ReturnsThreeMatches_WhenInputAndPatternOverlap()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyMatchingString);

            Assert.Equal(annotationMap.Count, 3);
        }

        [Fact]
        public void GetAnnotationMap_CoversOverlappingMatchesWithLeftmostOnTop_WhenMatchedBlocksOverlap()
        {
            StyleSheet styleSheet = GetDummyOverlappingStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyMatchingString);

            Assert.Equal(2, annotationMap.Count);
            Assert.Equal(new KeyValuePair<string, Color>("ca", Color.Yellow), annotationMap[0]);
            Assert.Equal(new KeyValuePair<string, Color>("t", Color.Green), annotationMap[1]);
        }

        [Fact]
        public void GetAnnotationMap_ReturnsPermutationOfInput()
        {
            StyleSheet styleSheet = GetDummyStyleSheet();
            TextAnnotator annotator = new TextAnnotator(styleSheet);

            List<KeyValuePair<string, Color>> annotationMap = annotator.GetAnnotationMap(dummyMatchingString);
            string mapConcatenated = String.Join("", annotationMap.Select(element => element.Key));

            Assert.Equal(mapConcatenated, dummyMatchingString);
        }
    }
}
