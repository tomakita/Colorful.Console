# [Colorful.Console](http://colorfulconsole.com/)

**Colorful.Console** is a C# library that wraps around the `System.Console` class, exposing enhanced styling functionality. See http://colorfulconsole.com/ for a more colorful tutorial!

![Colorful.Console icon](http://colorfulconsole.com/images/colorful_icon_ngsize.png)

# How to Get It

- Download [Colorful.Console](https://www.nuget.org/packages/Colorful.Console) from NuGet.
- Perform a Git Clone
> git Clone https://github.com/tomakita/Colorful.Console.git

# Basic Usage
```
using System;
using System.Drawing;
using Console = Colorful.Console;
...
...
Console.WriteLine("console in pink", Color.Pink);
Console.WriteLine("console in default");
```
![Basic Example](http://colorfulconsole.com/images/basic_x.png)


# Write With Full System.Drawing.Color Support
```
int r = 225;
int g = 255;
int b = 250;
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(storyFragments[i], Color.FromArgb(r, g, b));

    r -= 18;
    b -= 9;
}
```
![Write With Full System.Drawing.Color Support](http://colorfulconsole.com/images/rgb_x.png)


# Format Text Using Two Colors
```
string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
string[] fruits = new string[]
{
    "bananas",
    "strawberries",
    "mangoes",
    "pineapples",
    "cherries",
    "oranges",
    "apples",
    "peaches",
    "plums",
    "melons"
};

Console.WriteLineFormatted(dream, Color.LightGoldenrodYellow, Color.Gray, fruits);
```
![Format Text Using Two Colors](http://colorfulconsole.com/images/formatter_x1.png)


# Format Text Using Several Colors
```
string dream = "a dream of {0} and {1} and {2} and {3} and {4} and {5} and {6} and {7} and {8} and {9}...";
Formatter[] fruits = new Formatter[]
{
    new Formatter("bananas", Color.LightGoldenrodYellow),
    new Formatter("strawberries", Color.Pink),
    new Formatter("mangoes", Color.PeachPuff),
    new Formatter("pineapples", Color.Yellow),
    new Formatter("cherries", Color.Red),
    new Formatter("oranges", Color.Orange),
    new Formatter("apples", Color.LawnGreen),
    new Formatter("peaches", Color.MistyRose),
    new Formatter("plums", Color.Indigo),
    new Formatter("melons", Color.LightGreen),
};

Console.WriteLineFormatted(dream, Color.Gray, fruits);
```
![Format Text Using Several Colors](http://colorfulconsole.com/images/formatter_x2.png)


# Alternate Between 2 or More Colors Based on Number of Console Writes
```
ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
ColorAlternator alternator = alternatorFactory.GetAlternator(2, Color.Plum, Color.PaleVioletRed);

for (int i = 0; i < 15; i++)
{
    Console.WriteLineAlternating("cats", alternator);
}
```
![Alternate Between 2 or More Colors Based on Number of Console Writes](http://colorfulconsole.com/images/alternator_x2.png)


# Alternate Between 2 or More Colors Based on 1 or More Regular Expressions
```
ColorAlternatorFactory alternatorFactory = new ColorAlternatorFactory();
ColorAlternator alternator = alternatorFactory.GetAlternator(new[] { "hiss", "m[a-z]+w" }, Color.Plum, Color.PaleVioletRed);

for (int i = 0; i < 15; i++)
{
    string catMessage = "cats";

    if (i % 3 == 0)
    {
        catMessage = meowVariant[meowCounter++];
    }
    else if (i % 10 == 0)
    {
        catMessage = "hiss";
    }

    Console.WriteLineAlternating(catMessage, alternator);
}
```
![Alternate Between 2 or More Colors Based on 1 or More Regular Expressions](http://colorfulconsole.com/images/alternator_x1.png)


# Style Ppecific Regions of Text
```
StyleSheet styleSheet = new StyleSheet(Color.White);
styleSheet.AddStyle("rain[a-z]*", Color.MediumSlateBlue);

Console.WriteLineStyled(storyAboutRain, styleSheet);
```
![Alternate Between 2 or More Colors Based on 1 or More Regular Expressions](http://colorfulconsole.com/images/styler_x1.png)


# Style Specific Regions of Text, Performing a Simple Transformation
```
StyleSheet styleSheet = new StyleSheet(Color.White);
styleSheet.AddStyle("rain[a-z]*", Color.MediumSlateBlue, match => match.ToUpper());

Console.WriteLineStyled(storyAboutRain, styleSheet);
```
![Style Specific Regions of Text, Performing a Simple Transformation](http://colorfulconsole.com/images/styler_x2.png)


# Style Specific Regions of Text, Performing a Transformation Based on Surrounding Text
```
StyleSheet styleSheet = new StyleSheet(Color.White);
styleSheet.AddStyle("rain[a-z]*", Color.MediumSlateBlue,
    (unstyledInput, matchLocation, match) =>
    {
        if (unstyledInput[matchLocation.End] == '.')
        {
            return "marshmallows";
        }
        else
        {
            return "s'mores";
        }
    });

Console.WriteLineStyled(storyAboutRain, styleSheet);
```
![Style Specific Regions of Text, Performing a Simple Transformation](http://colorfulconsole.com/images/styler_x3.png)


# Convert Text to ASCII Art Using a Default Font
```
int DA = 244;
int V = 212;
int ID = 255;
for (int i = 0; i < 3; i++)
{
    Console.WriteAscii("HASSELHOFF", Color.FromArgb(DA, V, ID));

    DA -= 18;
    V -= 36;
}
```
![Convert Text to ASCII Art Using a Default Font](http://colorfulconsole.com/images/ascii_x1.png)


# Convert Text to ASCII Art Using [FIGlet](http://www.figlet.org/) Fonts
```
FigletFont font = FigletFont.Load("chunky.flf");
Figlet figlet = new Figlet(font);

Console.WriteLine(figlet.ToAscii("Belvedere"), ColorTranslator.FromHtml("#8AFFEF"));
Console.WriteLine(figlet.ToAscii("ice"), ColorTranslator.FromHtml("#FAD6FF"));
Console.WriteLine(figlet.ToAscii("cream."), ColorTranslator.FromHtml("#B8DBFF"));
```
![Convert Text to ASCII Art Using a Default Font](http://colorfulconsole.com/images/ascii_x2.png)


# Usage Notes

**Colorful.Console** can only write to the console in 16 different colors (including the black that's used as the console's background, by default!) in a single console session. This is a limitation of the Windows console itself, and it's one that I wasn't able to work my way around.  If you know of a workaround, let me know!
