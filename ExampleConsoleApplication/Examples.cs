using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Colorful;
using Console = Colorful.Console;
using System.Reflection;
using System.Resources;
using System.Collections;
using System.IO;

namespace TestConsole
{
    class Examples
    {
        static void Main(string[] args)
        {
            // NOTE: Running all of the following examples at once will result in unexpected 
            //       coloring behavior, as more than 16 different colors are used!

            // Uses default ASCII Figlet font.
            Console.WriteAscii("Hello World");
            Console.WriteAsciiAlternating("Hello World", new FrequencyBasedColorAlternator(2, Color.Green, Color.White));

            // Print out Hello World in all example fonts.
            var assembly = Assembly.GetExecutingAssembly();
            foreach (var resourceName in assembly.GetManifestResourceNames())
            {
                foreach (DictionaryEntry resource in new ResourceReader(assembly.GetManifestResourceStream(resourceName)))
                {
                    var font = FigletFont.Load((Stream)resource.Value);
                    Figlet figlet = new Figlet(font);
                    string asciiArt = figlet.ToAscii("Hello World");
                    Console.WriteLine(asciiArt);
                    Console.WriteLine();
                }
            }

            //string[] storyFragments = new string[]
            //{
            //    "John went to the store.",
            //    "He wanted to buy fruit.",
            //    "The security guard wouldn't let him buy fruit.",
            //    "John didn't like being harrassed about buying fruit.",
            //    "He went to another fruit store.",
            //    "At the other fruit store, he selected a ripe piece of fruit.",
            //    "A security guard came by and deselected the piece of fruit.",
            //    "John selected it again.",
            //    "He was determined to buy fruit.",
            //    "Until 7 PM, when the store closed."
            //};

            //int r = 225;
            //int g = 255;
            //int b = 250;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(storyFragments[i], Color.FromArgb(r, g, b));

            //    r -= 18;
            //    b -= 9;
            //}

            //string dream = " a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
            ////string[] fruits = new string[]
            ////{
            ////    "bananas",
            ////    "strawberries",
            ////    "mangoes",
            ////    "pineapples",
            ////    "cherries",
            ////    "oranges",
            ////    "apples",
            ////    "peaches",
            ////    "plums",
            ////    "melons"
            ////};
            //Formatter[] fruits = new Formatter[]
            //{
            //    new Formatter("bananas", Color.LightGoldenrodYellow),
            //    new Formatter("strawberries", Color.Pink),
            //    new Formatter("mangoes", Color.PeachPuff),
            //    new Formatter("pineapples", Color.Yellow),
            //    new Formatter("cherries", Color.Red),
            //    new Formatter("oranges", Color.Orange),
            //    new Formatter("apples", Color.LawnGreen),
            //    new Formatter("peaches", Color.MistyRose),
            //    new Formatter("plums", Color.Indigo),
            //    new Formatter("melons", Color.LightGreen),
            //};

            ////Console.WriteLineFormatted(dream, Color.LightGoldenrodYellow, Color.Gray, fruits);
            //Console.WriteLineFormatted(dream, Color.Gray, fruits);

            //int meowCounter = 0;
            //string[] meowVariant = new string[]
            //{
            //    " merrrowwww",
            //    " meow",
            //    " mew",
            //    " meeeowww",
            //    " meow"
            //};

            //ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            //ColorAlternator alternator = alternatorFactory.GetAlternator(new[] { "hiss", "m[a-z]+w" }, Color.Plum, Color.PaleVioletRed);

            //for (int i = 0; i < 15; i++)
            //{
            //    string catMessage = " cats";

            //    if (i % 3 == 0)
            //    {
            //        catMessage = meowVariant[meowCounter++];
            //    }
            //    else if (i % 10 == 0)
            //    {
            //        catMessage = " hiss";
            //    }

            //    Console.WriteLineAlternating(catMessage, alternator);
            //}

            //ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            //ColorAlternator alternator = alternatorFactory.GetAlternator(2, Color.Plum, Color.PaleVioletRed);

            //for (int i = 0; i < 15; i++)
            //{
            //    Console.WriteLineAlternating(" cats", alternator);
            //}

            //string storyAboutRain = " i like rain.  it is nice when it rains, because it means that things  get wet.";

            //StyleSheet styleSheet = new StyleSheet(Color.White);
            //styleSheet.AddStyle("rain[a-z]*", Color.MediumSlateBlue,
            //    (unstyledInput, matchLocation, match) =>
            //    {
            //        if (unstyledInput[matchLocation.End] == '.')
            //        {
            //            return "marshmallows";
            //        }
            //        else
            //        {
            //            return "s'mores";
            //        }
            //    });

            //Console.WriteLineStyled(storyAboutRain, styleSheet);

            //ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
            //ColorAlternator alternator = alternatorFactory.GetAlternator(2, Color.PaleTurquoise, Color.PaleGreen);
            ////alternator = alternatorFactory.GetAlternator(new[] { "[0-9]", "a" }, Color.LightYellow, Color.PaleGreen);
            //StyleSheet styleSheet = new StyleSheet(Color.White);
            //styleSheet.AddStyle("h", Color.Red);
            //styleSheet.AddStyle("y", Color.Orange);
            //styleSheet.AddStyle("b", Color.Yellow);
            //styleSheet.AddStyle("[0-9]", Color.Lime);

            //Console.WriteFormatted("hi {0} and {1}", Color.DeepSkyBlue, new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple));
            //Console.WriteFormatted("hi {0}", new Formatter("mike", Color.MediumOrchid), Color.White);
            //Console.WriteFormatted("hi {0} and {1}", Color.OrangeRed, Color.Orange, "john", "gary");
            //Console.WriteFormatted("hi {0} and {1}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), Color.OldLace);
            //Console.WriteFormatted("hi {0}", "mike", Color.MediumOrchid, Color.White);
            //Console.WriteFormatted("hi {0}, {1}, and {2}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), new Formatter("brian", Color.MediumBlue), Color.WhiteSmoke);
            //Console.WriteFormatted("hi {0} and {1}", "jerry", "larry", Color.Orange, Color.White);
            //Console.WriteFormatted("hi {0}, {1}, {2}, and {3}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), new Formatter("brian", Color.MediumBlue), new Formatter("jones", Color.DeepSkyBlue), Color.WhiteSmoke);
            //Console.WriteFormatted("hi {0}, {1}, and {2}", "jerry", "larry", "bob smith", Color.Orange, Color.White);
            //Console.WriteFormatted("hi {0}, {1}, {2}, and {3}", "jerry", "larry", "bob smith", "david", Color.MediumOrchid, Color.White);

            //Console.WriteAlternating(true, alternator);
            //Console.WriteAlternating('c', alternator);
            //Console.WriteAlternating(new[] { 'c', 'a', 't' }, alternator);
            //Console.WriteAlternating(5m, alternator);
            //Console.WriteAlternating(5d, alternator);
            //Console.WriteAlternating(5f, alternator);
            //Console.WriteAlternating(5, alternator);
            //Console.WriteAlternating(5L, alternator);
            //Console.WriteAlternating((object)5, alternator);
            //Console.WriteAlternating("cats stalk you" , alternator);
            //Console.WriteAlternating(5U, alternator);
            //Console.WriteAlternating(5UL, alternator);
            //Console.WriteAlternating("hi {0}", alternator, "bill");
            //Console.WriteAlternating("hi {0}", "bill", alternator);
            //Console.WriteAlternating(new[] { 'c', 'a', 't' }, 1, 2, alternator);
            //Console.WriteAlternating("hi {0} and {1}", "bill", "mitch", alternator);
            //Console.WriteAlternating("hi {0}, {1}, and {2}", "bill", "mitch", "gary", alternator);
            //Console.WriteAlternating("hi {0}, {1}, {2}, and {3}", "bill", "mitch", "gary", "gladys", alternator);

            //Console.WriteStyled(true, styleSheet);
            //Console.WriteStyled('c', styleSheet);
            //Console.WriteStyled(new[] { 'c', 'a', 't' }, styleSheet);
            //Console.WriteStyled(5m, styleSheet);
            //Console.WriteStyled(5d, styleSheet);
            //Console.WriteStyled(5f, styleSheet);
            //Console.WriteStyled(5, styleSheet);
            //Console.WriteStyled(5L, styleSheet);
            //Console.WriteStyled((object)5, styleSheet);
            //Console.WriteStyled("cats stalk you", styleSheet);
            //Console.WriteStyled(5U, styleSheet);
            //Console.WriteStyled(5UL, styleSheet);
            //Console.WriteStyled("hi {0}", "bill", styleSheet);
            //Console.WriteStyled("hi {0}", "bill", styleSheet);
            //Console.WriteStyled(new[] { 'c', 'a', 't' }, 1, 2, styleSheet);
            //Console.WriteStyled("hi {0} and {1}", "bill", "mitch", styleSheet);
            //Console.WriteStyled("hi {0}, {1}, and {2}", "bill", "mitch", "gary", styleSheet);
            //Console.WriteStyled("hi {0}, {1}, {2}, and {3}", "bill", "mitch", "gary", "gladys", styleSheet);

            //Console.WriteLineFormatted("hi {0} and {1}", Color.DeepSkyBlue, new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple));
            //Console.WriteLineFormatted("hi {0}", new Formatter("mike", Color.MediumOrchid), Color.White);
            //Console.WriteLineFormatted("hi {0} and {1}", Color.OrangeRed, Color.Orange, "john", "gary");
            //Console.WriteLineFormatted("hi {0} and {1}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), Color.OldLace);
            //Console.WriteLineFormatted("hi {0}", "mike", Color.MediumOrchid, Color.White);
            //Console.WriteLineFormatted("hi {0}, {1}, and {2}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), new Formatter("brian", Color.MediumBlue), Color.WhiteSmoke);
            //Console.WriteLineFormatted("hi {0} and {1}", "jerry", "larry", Color.Orange, Color.White);
            //Console.WriteLineFormatted("hi {0}, {1}, {2}, and {3}", new Formatter("billy", Color.MediumAquamarine), new Formatter("steve", Color.MediumPurple), new Formatter("brian", Color.MediumBlue), new Formatter("jones", Color.DeepSkyBlue), Color.WhiteSmoke);
            //Console.WriteLineFormatted("hi {0}, {1}, and {2}", "jerry", "larry", "bob smith", Color.Orange, Color.White);
            //Console.WriteLineFormatted("hi {0}, {1}, {2}, and {3}", "jerry", "larry", "bob smith", "david", Color.MediumOrchid, Color.White);

            //Console.WriteLineAlternating(true, alternator);
            //Console.WriteLineAlternating('c', alternator);
            //Console.WriteLineAlternating(new[] { 'c', 'a', 't' }, alternator);
            //Console.WriteLineAlternating(5m, alternator);
            //Console.WriteLineAlternating(5d, alternator);
            //Console.WriteLineAlternating(5f, alternator);
            //Console.WriteLineAlternating(5, alternator);
            //Console.WriteLineAlternating(5L, alternator);
            //Console.WriteLineAlternating((object)5, alternator);
            //Console.WriteLineAlternating("cats stalk you", alternator);
            //Console.WriteLineAlternating(5U, alternator);
            //Console.WriteLineAlternating(5UL, alternator);
            //Console.WriteLineAlternating("hi {0}", alternator, "bill");
            //Console.WriteLineAlternating("hi {0}", "bill", alternator);
            //Console.WriteLineAlternating(new[] { 'c', 'a', 't' }, 1, 2, alternator);
            //Console.WriteLineAlternating("hi {0} and {1}", "bill", "mitch", alternator);
            //Console.WriteLineAlternating("hi {0}, {1}, and {2}", "bill", "mitch", "gary", alternator);
            //Console.WriteLineAlternating("hi {0}, {1}, {2}, and {3}", "bill", "mitch", "gary", "gladys", alternator);

            //Console.WriteLineStyled(true, styleSheet);
            //Console.WriteLineStyled('c', styleSheet);
            //Console.WriteLineStyled(new[] { 'c', 'a', 't' }, styleSheet);
            //Console.WriteLineStyled(5m, styleSheet);
            //Console.WriteLineStyled(5d, styleSheet);
            //Console.WriteLineStyled(5f, styleSheet);
            //Console.WriteLineStyled(5, styleSheet);
            //Console.WriteLineStyled(5L, styleSheet);
            //Console.WriteLineStyled((object)5, styleSheet);
            //Console.WriteLineStyled("cats stalk you", styleSheet);
            //Console.WriteLineStyled(5U, styleSheet);
            //Console.WriteLineStyled(5UL, styleSheet);
            //Console.WriteLineStyled("hi {0}", "bill", styleSheet);
            //Console.WriteLineStyled("hi {0}", "bill", styleSheet);
            //Console.WriteLineStyled(new[] { 'c', 'a', 't' }, 1, 2, styleSheet);
            //Console.WriteLineStyled("hi {0} and {1}", "bill", "mitch", styleSheet);
            //Console.WriteLineStyled("hi {0}, {1}, and {2}", "bill", "mitch", "gary", styleSheet);
            //Console.WriteLineStyled("hi {0}, {1}, {2}, and {3}", "bill", "mitch", "gary", "gladys", styleSheet);

            Console.ReadKey();
        }
    }
}
