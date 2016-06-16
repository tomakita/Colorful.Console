#if NETSTANDARD1_5
namespace System.Drawing
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Globalization;
    using System.Runtime.InteropServices;
    using System.Text;

    public enum KnownColor
    {
        ActiveBorder = 1,
        ActiveCaption = 2,
        ActiveCaptionText = 3,
        AliceBlue = 0x1c,
        AntiqueWhite = 0x1d,
        AppWorkspace = 4,
        Aqua = 30,
        Aquamarine = 0x1f,
        Azure = 0x20,
        Beige = 0x21,
        Bisque = 0x22,
        Black = 0x23,
        BlanchedAlmond = 0x24,
        Blue = 0x25,
        BlueViolet = 0x26,
        Brown = 0x27,
        BurlyWood = 40,
        ButtonFace = 0xa8,
        ButtonHighlight = 0xa9,
        ButtonShadow = 170,
        CadetBlue = 0x29,
        Chartreuse = 0x2a,
        Chocolate = 0x2b,
        Control = 5,
        ControlDark = 6,
        ControlDarkDark = 7,
        ControlLight = 8,
        ControlLightLight = 9,
        ControlText = 10,
        Coral = 0x2c,
        CornflowerBlue = 0x2d,
        Cornsilk = 0x2e,
        Crimson = 0x2f,
        Cyan = 0x30,
        DarkBlue = 0x31,
        DarkCyan = 50,
        DarkGoldenrod = 0x33,
        DarkGray = 0x34,
        DarkGreen = 0x35,
        DarkKhaki = 0x36,
        DarkMagenta = 0x37,
        DarkOliveGreen = 0x38,
        DarkOrange = 0x39,
        DarkOrchid = 0x3a,
        DarkRed = 0x3b,
        DarkSalmon = 60,
        DarkSeaGreen = 0x3d,
        DarkSlateBlue = 0x3e,
        DarkSlateGray = 0x3f,
        DarkTurquoise = 0x40,
        DarkViolet = 0x41,
        DeepPink = 0x42,
        DeepSkyBlue = 0x43,
        Desktop = 11,
        DimGray = 0x44,
        DodgerBlue = 0x45,
        Firebrick = 70,
        FloralWhite = 0x47,
        ForestGreen = 0x48,
        Fuchsia = 0x49,
        Gainsboro = 0x4a,
        GhostWhite = 0x4b,
        Gold = 0x4c,
        Goldenrod = 0x4d,
        GradientActiveCaption = 0xab,
        GradientInactiveCaption = 0xac,
        Gray = 0x4e,
        GrayText = 12,
        Green = 0x4f,
        GreenYellow = 80,
        Highlight = 13,
        HighlightText = 14,
        Honeydew = 0x51,
        HotPink = 0x52,
        HotTrack = 15,
        InactiveBorder = 0x10,
        InactiveCaption = 0x11,
        InactiveCaptionText = 0x12,
        IndianRed = 0x53,
        Indigo = 0x54,
        Info = 0x13,
        InfoText = 20,
        Ivory = 0x55,
        Khaki = 0x56,
        Lavender = 0x57,
        LavenderBlush = 0x58,
        LawnGreen = 0x59,
        LemonChiffon = 90,
        LightBlue = 0x5b,
        LightCoral = 0x5c,
        LightCyan = 0x5d,
        LightGoldenrodYellow = 0x5e,
        LightGray = 0x5f,
        LightGreen = 0x60,
        LightPink = 0x61,
        LightSalmon = 0x62,
        LightSeaGreen = 0x63,
        LightSkyBlue = 100,
        LightSlateGray = 0x65,
        LightSteelBlue = 0x66,
        LightYellow = 0x67,
        Lime = 0x68,
        LimeGreen = 0x69,
        Linen = 0x6a,
        Magenta = 0x6b,
        Maroon = 0x6c,
        MediumAquamarine = 0x6d,
        MediumBlue = 110,
        MediumOrchid = 0x6f,
        MediumPurple = 0x70,
        MediumSeaGreen = 0x71,
        MediumSlateBlue = 0x72,
        MediumSpringGreen = 0x73,
        MediumTurquoise = 0x74,
        MediumVioletRed = 0x75,
        Menu = 0x15,
        MenuBar = 0xad,
        MenuHighlight = 0xae,
        MenuText = 0x16,
        MidnightBlue = 0x76,
        MintCream = 0x77,
        MistyRose = 120,
        Moccasin = 0x79,
        NavajoWhite = 0x7a,
        Navy = 0x7b,
        OldLace = 0x7c,
        Olive = 0x7d,
        OliveDrab = 0x7e,
        Orange = 0x7f,
        OrangeRed = 0x80,
        Orchid = 0x81,
        PaleGoldenrod = 130,
        PaleGreen = 0x83,
        PaleTurquoise = 0x84,
        PaleVioletRed = 0x85,
        PapayaWhip = 0x86,
        PeachPuff = 0x87,
        Peru = 0x88,
        Pink = 0x89,
        Plum = 0x8a,
        PowderBlue = 0x8b,
        Purple = 140,
        Red = 0x8d,
        RosyBrown = 0x8e,
        RoyalBlue = 0x8f,
        SaddleBrown = 0x90,
        Salmon = 0x91,
        SandyBrown = 0x92,
        ScrollBar = 0x17,
        SeaGreen = 0x93,
        SeaShell = 0x94,
        Sienna = 0x95,
        Silver = 150,
        SkyBlue = 0x97,
        SlateBlue = 0x98,
        SlateGray = 0x99,
        Snow = 0x9a,
        SpringGreen = 0x9b,
        SteelBlue = 0x9c,
        Tan = 0x9d,
        Teal = 0x9e,
        Thistle = 0x9f,
        Tomato = 160,
        Transparent = 0x1b,
        Turquoise = 0xa1,
        Violet = 0xa2,
        Wheat = 0xa3,
        White = 0xa4,
        WhiteSmoke = 0xa5,
        Window = 0x18,
        WindowFrame = 0x19,
        WindowText = 0x1a,
        Yellow = 0xa6,
        YellowGreen = 0xa7
    }

    internal static class KnownColorTable
    {
        private const int AlphaShift = 0x18;
        private const int BlueShift = 0;
        private static string[] colorNameTable;
        private static int[] colorTable;
        private const int GreenShift = 8;
        private const int RedShift = 0x10;
        private const int Win32BlueShift = 0x10;
        private const int Win32GreenShift = 8;
        private const int Win32RedShift = 0;

        private static int Encode(int alpha, int red, int green, int blue) =>
            ((((red << 0x10) | (green << 8)) | blue) | (alpha << 0x18));

        private static void EnsureColorNameTable()
        {
            if (colorNameTable == null)
            {
                InitColorNameTable();
            }
        }

        private static void EnsureColorTable()
        {
            if (colorTable == null)
            {
                InitColorTable();
            }
        }

        private static void InitColorNameTable()
        {
            string[] textArray1 = new string[0xaf];
            textArray1[1] = "ActiveBorder";
            textArray1[2] = "ActiveCaption";
            textArray1[3] = "ActiveCaptionText";
            textArray1[4] = "AppWorkspace";
            textArray1[0xa8] = "ButtonFace";
            textArray1[0xa9] = "ButtonHighlight";
            textArray1[170] = "ButtonShadow";
            textArray1[5] = "Control";
            textArray1[6] = "ControlDark";
            textArray1[7] = "ControlDarkDark";
            textArray1[8] = "ControlLight";
            textArray1[9] = "ControlLightLight";
            textArray1[10] = "ControlText";
            textArray1[11] = "Desktop";
            textArray1[0xab] = "GradientActiveCaption";
            textArray1[0xac] = "GradientInactiveCaption";
            textArray1[12] = "GrayText";
            textArray1[13] = "Highlight";
            textArray1[14] = "HighlightText";
            textArray1[15] = "HotTrack";
            textArray1[0x10] = "InactiveBorder";
            textArray1[0x11] = "InactiveCaption";
            textArray1[0x12] = "InactiveCaptionText";
            textArray1[0x13] = "Info";
            textArray1[20] = "InfoText";
            textArray1[0x15] = "Menu";
            textArray1[0xad] = "MenuBar";
            textArray1[0xae] = "MenuHighlight";
            textArray1[0x16] = "MenuText";
            textArray1[0x17] = "ScrollBar";
            textArray1[0x18] = "Window";
            textArray1[0x19] = "WindowFrame";
            textArray1[0x1a] = "WindowText";
            textArray1[0x1b] = "Transparent";
            textArray1[0x1c] = "AliceBlue";
            textArray1[0x1d] = "AntiqueWhite";
            textArray1[30] = "Aqua";
            textArray1[0x1f] = "Aquamarine";
            textArray1[0x20] = "Azure";
            textArray1[0x21] = "Beige";
            textArray1[0x22] = "Bisque";
            textArray1[0x23] = "Black";
            textArray1[0x24] = "BlanchedAlmond";
            textArray1[0x25] = "Blue";
            textArray1[0x26] = "BlueViolet";
            textArray1[0x27] = "Brown";
            textArray1[40] = "BurlyWood";
            textArray1[0x29] = "CadetBlue";
            textArray1[0x2a] = "Chartreuse";
            textArray1[0x2b] = "Chocolate";
            textArray1[0x2c] = "Coral";
            textArray1[0x2d] = "CornflowerBlue";
            textArray1[0x2e] = "Cornsilk";
            textArray1[0x2f] = "Crimson";
            textArray1[0x30] = "Cyan";
            textArray1[0x31] = "DarkBlue";
            textArray1[50] = "DarkCyan";
            textArray1[0x33] = "DarkGoldenrod";
            textArray1[0x34] = "DarkGray";
            textArray1[0x35] = "DarkGreen";
            textArray1[0x36] = "DarkKhaki";
            textArray1[0x37] = "DarkMagenta";
            textArray1[0x38] = "DarkOliveGreen";
            textArray1[0x39] = "DarkOrange";
            textArray1[0x3a] = "DarkOrchid";
            textArray1[0x3b] = "DarkRed";
            textArray1[60] = "DarkSalmon";
            textArray1[0x3d] = "DarkSeaGreen";
            textArray1[0x3e] = "DarkSlateBlue";
            textArray1[0x3f] = "DarkSlateGray";
            textArray1[0x40] = "DarkTurquoise";
            textArray1[0x41] = "DarkViolet";
            textArray1[0x42] = "DeepPink";
            textArray1[0x43] = "DeepSkyBlue";
            textArray1[0x44] = "DimGray";
            textArray1[0x45] = "DodgerBlue";
            textArray1[70] = "Firebrick";
            textArray1[0x47] = "FloralWhite";
            textArray1[0x48] = "ForestGreen";
            textArray1[0x49] = "Fuchsia";
            textArray1[0x4a] = "Gainsboro";
            textArray1[0x4b] = "GhostWhite";
            textArray1[0x4c] = "Gold";
            textArray1[0x4d] = "Goldenrod";
            textArray1[0x4e] = "Gray";
            textArray1[0x4f] = "Green";
            textArray1[80] = "GreenYellow";
            textArray1[0x51] = "Honeydew";
            textArray1[0x52] = "HotPink";
            textArray1[0x53] = "IndianRed";
            textArray1[0x54] = "Indigo";
            textArray1[0x55] = "Ivory";
            textArray1[0x56] = "Khaki";
            textArray1[0x57] = "Lavender";
            textArray1[0x58] = "LavenderBlush";
            textArray1[0x59] = "LawnGreen";
            textArray1[90] = "LemonChiffon";
            textArray1[0x5b] = "LightBlue";
            textArray1[0x5c] = "LightCoral";
            textArray1[0x5d] = "LightCyan";
            textArray1[0x5e] = "LightGoldenrodYellow";
            textArray1[0x5f] = "LightGray";
            textArray1[0x60] = "LightGreen";
            textArray1[0x61] = "LightPink";
            textArray1[0x62] = "LightSalmon";
            textArray1[0x63] = "LightSeaGreen";
            textArray1[100] = "LightSkyBlue";
            textArray1[0x65] = "LightSlateGray";
            textArray1[0x66] = "LightSteelBlue";
            textArray1[0x67] = "LightYellow";
            textArray1[0x68] = "Lime";
            textArray1[0x69] = "LimeGreen";
            textArray1[0x6a] = "Linen";
            textArray1[0x6b] = "Magenta";
            textArray1[0x6c] = "Maroon";
            textArray1[0x6d] = "MediumAquamarine";
            textArray1[110] = "MediumBlue";
            textArray1[0x6f] = "MediumOrchid";
            textArray1[0x70] = "MediumPurple";
            textArray1[0x71] = "MediumSeaGreen";
            textArray1[0x72] = "MediumSlateBlue";
            textArray1[0x73] = "MediumSpringGreen";
            textArray1[0x74] = "MediumTurquoise";
            textArray1[0x75] = "MediumVioletRed";
            textArray1[0x76] = "MidnightBlue";
            textArray1[0x77] = "MintCream";
            textArray1[120] = "MistyRose";
            textArray1[0x79] = "Moccasin";
            textArray1[0x7a] = "NavajoWhite";
            textArray1[0x7b] = "Navy";
            textArray1[0x7c] = "OldLace";
            textArray1[0x7d] = "Olive";
            textArray1[0x7e] = "OliveDrab";
            textArray1[0x7f] = "Orange";
            textArray1[0x80] = "OrangeRed";
            textArray1[0x81] = "Orchid";
            textArray1[130] = "PaleGoldenrod";
            textArray1[0x83] = "PaleGreen";
            textArray1[0x84] = "PaleTurquoise";
            textArray1[0x85] = "PaleVioletRed";
            textArray1[0x86] = "PapayaWhip";
            textArray1[0x87] = "PeachPuff";
            textArray1[0x88] = "Peru";
            textArray1[0x89] = "Pink";
            textArray1[0x8a] = "Plum";
            textArray1[0x8b] = "PowderBlue";
            textArray1[140] = "Purple";
            textArray1[0x8d] = "Red";
            textArray1[0x8e] = "RosyBrown";
            textArray1[0x8f] = "RoyalBlue";
            textArray1[0x90] = "SaddleBrown";
            textArray1[0x91] = "Salmon";
            textArray1[0x92] = "SandyBrown";
            textArray1[0x93] = "SeaGreen";
            textArray1[0x94] = "SeaShell";
            textArray1[0x95] = "Sienna";
            textArray1[150] = "Silver";
            textArray1[0x97] = "SkyBlue";
            textArray1[0x98] = "SlateBlue";
            textArray1[0x99] = "SlateGray";
            textArray1[0x9a] = "Snow";
            textArray1[0x9b] = "SpringGreen";
            textArray1[0x9c] = "SteelBlue";
            textArray1[0x9d] = "Tan";
            textArray1[0x9e] = "Teal";
            textArray1[0x9f] = "Thistle";
            textArray1[160] = "Tomato";
            textArray1[0xa1] = "Turquoise";
            textArray1[0xa2] = "Violet";
            textArray1[0xa3] = "Wheat";
            textArray1[0xa4] = "White";
            textArray1[0xa5] = "WhiteSmoke";
            textArray1[0xa6] = "Yellow";
            textArray1[0xa7] = "YellowGreen";
            colorNameTable = textArray1;
        }

        private static void InitColorTable()
        {
            int[] colorTable = new int[0xaf];
            UpdateSystemColors(colorTable);
            colorTable[0x1b] = 0xffffff;
            colorTable[0x1c] = -984833;
            colorTable[0x1d] = -332841;
            colorTable[30] = -16711681;
            colorTable[0x1f] = -8388652;
            colorTable[0x20] = -983041;
            colorTable[0x21] = -657956;
            colorTable[0x22] = -6972;
            colorTable[0x23] = -16777216;
            colorTable[0x24] = -5171;
            colorTable[0x25] = -16776961;
            colorTable[0x26] = -7722014;
            colorTable[0x27] = -5952982;
            colorTable[40] = -2180985;
            colorTable[0x29] = -10510688;
            colorTable[0x2a] = -8388864;
            colorTable[0x2b] = -2987746;
            colorTable[0x2c] = -32944;
            colorTable[0x2d] = -10185235;
            colorTable[0x2e] = -1828;
            colorTable[0x2f] = -2354116;
            colorTable[0x30] = -16711681;
            colorTable[0x31] = -16777077;
            colorTable[50] = -16741493;
            colorTable[0x33] = -4684277;
            colorTable[0x34] = -5658199;
            colorTable[0x35] = -16751616;
            colorTable[0x36] = -4343957;
            colorTable[0x37] = -7667573;
            colorTable[0x38] = -11179217;
            colorTable[0x39] = -29696;
            colorTable[0x3a] = -6737204;
            colorTable[0x3b] = -7667712;
            colorTable[60] = -1468806;
            colorTable[0x3d] = -7357301;
            colorTable[0x3e] = -12042869;
            colorTable[0x3f] = -13676721;
            colorTable[0x40] = -16724271;
            colorTable[0x41] = -7077677;
            colorTable[0x42] = -60269;
            colorTable[0x43] = -16728065;
            colorTable[0x44] = -9868951;
            colorTable[0x45] = -14774017;
            colorTable[70] = -5103070;
            colorTable[0x47] = -1296;
            colorTable[0x48] = -14513374;
            colorTable[0x49] = -65281;
            colorTable[0x4a] = -2302756;
            colorTable[0x4b] = -460545;
            colorTable[0x4c] = -10496;
            colorTable[0x4d] = -2448096;
            colorTable[0x4e] = -8355712;
            colorTable[0x4f] = -16744448;
            colorTable[80] = -5374161;
            colorTable[0x51] = -983056;
            colorTable[0x52] = -38476;
            colorTable[0x53] = -3318692;
            colorTable[0x54] = -11861886;
            colorTable[0x55] = -16;
            colorTable[0x56] = -989556;
            colorTable[0x57] = -1644806;
            colorTable[0x58] = -3851;
            colorTable[0x59] = -8586240;
            colorTable[90] = -1331;
            colorTable[0x5b] = -5383962;
            colorTable[0x5c] = -1015680;
            colorTable[0x5d] = -2031617;
            colorTable[0x5e] = -329006;
            colorTable[0x5f] = -2894893;
            colorTable[0x60] = -7278960;
            colorTable[0x61] = -18751;
            colorTable[0x62] = -24454;
            colorTable[0x63] = -14634326;
            colorTable[100] = -7876870;
            colorTable[0x65] = -8943463;
            colorTable[0x66] = -5192482;
            colorTable[0x67] = -32;
            colorTable[0x68] = -16711936;
            colorTable[0x69] = -13447886;
            colorTable[0x6a] = -331546;
            colorTable[0x6b] = -65281;
            colorTable[0x6c] = -8388608;
            colorTable[0x6d] = -10039894;
            colorTable[110] = -16777011;
            colorTable[0x6f] = -4565549;
            colorTable[0x70] = -7114533;
            colorTable[0x71] = -12799119;
            colorTable[0x72] = -8689426;
            colorTable[0x73] = -16713062;
            colorTable[0x74] = -12004916;
            colorTable[0x75] = -3730043;
            colorTable[0x76] = -15132304;
            colorTable[0x77] = -655366;
            colorTable[120] = -6943;
            colorTable[0x79] = -6987;
            colorTable[0x7a] = -8531;
            colorTable[0x7b] = -16777088;
            colorTable[0x7c] = -133658;
            colorTable[0x7d] = -8355840;
            colorTable[0x7e] = -9728477;
            colorTable[0x7f] = -23296;
            colorTable[0x80] = -47872;
            colorTable[0x81] = -2461482;
            colorTable[130] = -1120086;
            colorTable[0x83] = -6751336;
            colorTable[0x84] = -5247250;
            colorTable[0x85] = -2396013;
            colorTable[0x86] = -4139;
            colorTable[0x87] = -9543;
            colorTable[0x88] = -3308225;
            colorTable[0x89] = -16181;
            colorTable[0x8a] = -2252579;
            colorTable[0x8b] = -5185306;
            colorTable[140] = -8388480;
            colorTable[0x8d] = -65536;
            colorTable[0x8e] = -4419697;
            colorTable[0x8f] = -12490271;
            colorTable[0x90] = -7650029;
            colorTable[0x91] = -360334;
            colorTable[0x92] = -744352;
            colorTable[0x93] = -13726889;
            colorTable[0x94] = -2578;
            colorTable[0x95] = -6270419;
            colorTable[150] = -4144960;
            colorTable[0x97] = -7876885;
            colorTable[0x98] = -9807155;
            colorTable[0x99] = -9404272;
            colorTable[0x9a] = -1286;
            colorTable[0x9b] = -16711809;
            colorTable[0x9c] = -12156236;
            colorTable[0x9d] = -2968436;
            colorTable[0x9e] = -16744320;
            colorTable[0x9f] = -2572328;
            colorTable[160] = -40121;
            colorTable[0xa1] = -12525360;
            colorTable[0xa2] = -1146130;
            colorTable[0xa3] = -663885;
            colorTable[0xa4] = -1;
            colorTable[0xa5] = -657931;
            colorTable[0xa6] = -256;
            colorTable[0xa7] = -6632142;
            KnownColorTable.colorTable = colorTable;
        }

        public static int KnownColorToArgb(KnownColor color)
        {
            EnsureColorTable();
            if (color <= KnownColor.MenuHighlight)
            {
                return colorTable[(int)color];
            }
            return 0;
        }

        public static string KnownColorToName(KnownColor color)
        {
            EnsureColorNameTable();
            if (color <= KnownColor.MenuHighlight)
            {
                return colorNameTable[(int)color];
            }
            return null;
        }

        private static void UpdateSystemColors(int[] colorTable)
        {
            // TODO: FILL THIS IN WITH THE KNOWN COLOURS.
            //colorTable[1] = SystemColorToArgb(10);
            //colorTable[2] = SystemColorToArgb(2);
            //colorTable[3] = SystemColorToArgb(9);
            //colorTable[4] = SystemColorToArgb(12);
            //colorTable[0xa8] = SystemColorToArgb(15);
            //colorTable[0xa9] = SystemColorToArgb(20);
            //colorTable[170] = SystemColorToArgb(0x10);
            //colorTable[5] = SystemColorToArgb(15);
            //colorTable[6] = SystemColorToArgb(0x10);
            //colorTable[7] = SystemColorToArgb(0x15);
            //colorTable[8] = SystemColorToArgb(0x16);
            //colorTable[9] = SystemColorToArgb(20);
            //colorTable[10] = SystemColorToArgb(0x12);
            //colorTable[11] = SystemColorToArgb(1);
            //colorTable[0xab] = SystemColorToArgb(0x1b);
            //colorTable[0xac] = SystemColorToArgb(0x1c);
            //colorTable[12] = SystemColorToArgb(0x11);
            //colorTable[13] = SystemColorToArgb(13);
            //colorTable[14] = SystemColorToArgb(14);
            //colorTable[15] = SystemColorToArgb(0x1a);
            //colorTable[0x10] = SystemColorToArgb(11);
            //colorTable[0x11] = SystemColorToArgb(3);
            //colorTable[0x12] = SystemColorToArgb(0x13);
            //colorTable[0x13] = SystemColorToArgb(0x18);
            //colorTable[20] = SystemColorToArgb(0x17);
            //colorTable[0x15] = SystemColorToArgb(4);
            //colorTable[0xad] = SystemColorToArgb(30);
            //colorTable[0xae] = SystemColorToArgb(0x1d);
            //colorTable[0x16] = SystemColorToArgb(7);
            //colorTable[0x17] = SystemColorToArgb(0);
            //colorTable[0x18] = SystemColorToArgb(5);
            //colorTable[0x19] = SystemColorToArgb(6);
            //colorTable[0x1a] = SystemColorToArgb(8);
        }
    }

    [StructLayout(LayoutKind.Sequential), DebuggerDisplay("{NameAndARGBValue}")]
    public struct Color
    {
        public static readonly Color Empty;
        private static short StateKnownColorValid;
        private static short StateARGBValueValid;
        private static short StateValueMask;
        private static short StateNameValid;
        private static long NotDefinedValue;
        private const int ARGBAlphaShift = 0x18;
        private const int ARGBRedShift = 0x10;
        private const int ARGBGreenShift = 8;
        private const int ARGBBlueShift = 0;
        private readonly string name;
        private readonly long value;
        private readonly short knownColor;
        private readonly short state;
        public static Color Transparent =>
            new Color(KnownColor.Transparent);
        public static Color AliceBlue =>
            new Color(KnownColor.AliceBlue);
        public static Color AntiqueWhite =>
            new Color(KnownColor.AntiqueWhite);
        public static Color Aqua =>
            new Color(KnownColor.Aqua);
        public static Color Aquamarine =>
            new Color(KnownColor.Aquamarine);
        public static Color Azure =>
            new Color(KnownColor.Azure);
        public static Color Beige =>
            new Color(KnownColor.Beige);
        public static Color Bisque =>
            new Color(KnownColor.Bisque);
        public static Color Black =>
            new Color(KnownColor.Black);
        public static Color BlanchedAlmond =>
            new Color(KnownColor.BlanchedAlmond);
        public static Color Blue =>
            new Color(KnownColor.Blue);
        public static Color BlueViolet =>
            new Color(KnownColor.BlueViolet);
        public static Color Brown =>
            new Color(KnownColor.Brown);
        public static Color BurlyWood =>
            new Color(KnownColor.BurlyWood);
        public static Color CadetBlue =>
            new Color(KnownColor.CadetBlue);
        public static Color Chartreuse =>
            new Color(KnownColor.Chartreuse);
        public static Color Chocolate =>
            new Color(KnownColor.Chocolate);
        public static Color Coral =>
            new Color(KnownColor.Coral);
        public static Color CornflowerBlue =>
            new Color(KnownColor.CornflowerBlue);
        public static Color Cornsilk =>
            new Color(KnownColor.Cornsilk);
        public static Color Crimson =>
            new Color(KnownColor.Crimson);
        public static Color Cyan =>
            new Color(KnownColor.Cyan);
        public static Color DarkBlue =>
            new Color(KnownColor.DarkBlue);
        public static Color DarkCyan =>
            new Color(KnownColor.DarkCyan);
        public static Color DarkGoldenrod =>
            new Color(KnownColor.DarkGoldenrod);
        public static Color DarkGray =>
            new Color(KnownColor.DarkGray);
        public static Color DarkGreen =>
            new Color(KnownColor.DarkGreen);
        public static Color DarkKhaki =>
            new Color(KnownColor.DarkKhaki);
        public static Color DarkMagenta =>
            new Color(KnownColor.DarkMagenta);
        public static Color DarkOliveGreen =>
            new Color(KnownColor.DarkOliveGreen);
        public static Color DarkOrange =>
            new Color(KnownColor.DarkOrange);
        public static Color DarkOrchid =>
            new Color(KnownColor.DarkOrchid);
        public static Color DarkRed =>
            new Color(KnownColor.DarkRed);
        public static Color DarkSalmon =>
            new Color(KnownColor.DarkSalmon);
        public static Color DarkSeaGreen =>
            new Color(KnownColor.DarkSeaGreen);
        public static Color DarkSlateBlue =>
            new Color(KnownColor.DarkSlateBlue);
        public static Color DarkSlateGray =>
            new Color(KnownColor.DarkSlateGray);
        public static Color DarkTurquoise =>
            new Color(KnownColor.DarkTurquoise);
        public static Color DarkViolet =>
            new Color(KnownColor.DarkViolet);
        public static Color DeepPink =>
            new Color(KnownColor.DeepPink);
        public static Color DeepSkyBlue =>
            new Color(KnownColor.DeepSkyBlue);
        public static Color DimGray =>
            new Color(KnownColor.DimGray);
        public static Color DodgerBlue =>
            new Color(KnownColor.DodgerBlue);
        public static Color Firebrick =>
            new Color(KnownColor.Firebrick);
        public static Color FloralWhite =>
            new Color(KnownColor.FloralWhite);
        public static Color ForestGreen =>
            new Color(KnownColor.ForestGreen);
        public static Color Fuchsia =>
            new Color(KnownColor.Fuchsia);
        public static Color Gainsboro =>
            new Color(KnownColor.Gainsboro);
        public static Color GhostWhite =>
            new Color(KnownColor.GhostWhite);
        public static Color Gold =>
            new Color(KnownColor.Gold);
        public static Color Goldenrod =>
            new Color(KnownColor.Goldenrod);
        public static Color Gray =>
            new Color(KnownColor.Gray);
        public static Color Green =>
            new Color(KnownColor.Green);
        public static Color GreenYellow =>
            new Color(KnownColor.GreenYellow);
        public static Color Honeydew =>
            new Color(KnownColor.Honeydew);
        public static Color HotPink =>
            new Color(KnownColor.HotPink);
        public static Color IndianRed =>
            new Color(KnownColor.IndianRed);
        public static Color Indigo =>
            new Color(KnownColor.Indigo);
        public static Color Ivory =>
            new Color(KnownColor.Ivory);
        public static Color Khaki =>
            new Color(KnownColor.Khaki);
        public static Color Lavender =>
            new Color(KnownColor.Lavender);
        public static Color LavenderBlush =>
            new Color(KnownColor.LavenderBlush);
        public static Color LawnGreen =>
            new Color(KnownColor.LawnGreen);
        public static Color LemonChiffon =>
            new Color(KnownColor.LemonChiffon);
        public static Color LightBlue =>
            new Color(KnownColor.LightBlue);
        public static Color LightCoral =>
            new Color(KnownColor.LightCoral);
        public static Color LightCyan =>
            new Color(KnownColor.LightCyan);
        public static Color LightGoldenrodYellow =>
            new Color(KnownColor.LightGoldenrodYellow);
        public static Color LightGreen =>
            new Color(KnownColor.LightGreen);
        public static Color LightGray =>
            new Color(KnownColor.LightGray);
        public static Color LightPink =>
            new Color(KnownColor.LightPink);
        public static Color LightSalmon =>
            new Color(KnownColor.LightSalmon);
        public static Color LightSeaGreen =>
            new Color(KnownColor.LightSeaGreen);
        public static Color LightSkyBlue =>
            new Color(KnownColor.LightSkyBlue);
        public static Color LightSlateGray =>
            new Color(KnownColor.LightSlateGray);
        public static Color LightSteelBlue =>
            new Color(KnownColor.LightSteelBlue);
        public static Color LightYellow =>
            new Color(KnownColor.LightYellow);
        public static Color Lime =>
            new Color(KnownColor.Lime);
        public static Color LimeGreen =>
            new Color(KnownColor.LimeGreen);
        public static Color Linen =>
            new Color(KnownColor.Linen);
        public static Color Magenta =>
            new Color(KnownColor.Magenta);
        public static Color Maroon =>
            new Color(KnownColor.Maroon);
        public static Color MediumAquamarine =>
            new Color(KnownColor.MediumAquamarine);
        public static Color MediumBlue =>
            new Color(KnownColor.MediumBlue);
        public static Color MediumOrchid =>
            new Color(KnownColor.MediumOrchid);
        public static Color MediumPurple =>
            new Color(KnownColor.MediumPurple);
        public static Color MediumSeaGreen =>
            new Color(KnownColor.MediumSeaGreen);
        public static Color MediumSlateBlue =>
            new Color(KnownColor.MediumSlateBlue);
        public static Color MediumSpringGreen =>
            new Color(KnownColor.MediumSpringGreen);
        public static Color MediumTurquoise =>
            new Color(KnownColor.MediumTurquoise);
        public static Color MediumVioletRed =>
            new Color(KnownColor.MediumVioletRed);
        public static Color MidnightBlue =>
            new Color(KnownColor.MidnightBlue);
        public static Color MintCream =>
            new Color(KnownColor.MintCream);
        public static Color MistyRose =>
            new Color(KnownColor.MistyRose);
        public static Color Moccasin =>
            new Color(KnownColor.Moccasin);
        public static Color NavajoWhite =>
            new Color(KnownColor.NavajoWhite);
        public static Color Navy =>
            new Color(KnownColor.Navy);
        public static Color OldLace =>
            new Color(KnownColor.OldLace);
        public static Color Olive =>
            new Color(KnownColor.Olive);
        public static Color OliveDrab =>
            new Color(KnownColor.OliveDrab);
        public static Color Orange =>
            new Color(KnownColor.Orange);
        public static Color OrangeRed =>
            new Color(KnownColor.OrangeRed);
        public static Color Orchid =>
            new Color(KnownColor.Orchid);
        public static Color PaleGoldenrod =>
            new Color(KnownColor.PaleGoldenrod);
        public static Color PaleGreen =>
            new Color(KnownColor.PaleGreen);
        public static Color PaleTurquoise =>
            new Color(KnownColor.PaleTurquoise);
        public static Color PaleVioletRed =>
            new Color(KnownColor.PaleVioletRed);
        public static Color PapayaWhip =>
            new Color(KnownColor.PapayaWhip);
        public static Color PeachPuff =>
            new Color(KnownColor.PeachPuff);
        public static Color Peru =>
            new Color(KnownColor.Peru);
        public static Color Pink =>
            new Color(KnownColor.Pink);
        public static Color Plum =>
            new Color(KnownColor.Plum);
        public static Color PowderBlue =>
            new Color(KnownColor.PowderBlue);
        public static Color Purple =>
            new Color(KnownColor.Purple);
        public static Color Red =>
            new Color(KnownColor.Red);
        public static Color RosyBrown =>
            new Color(KnownColor.RosyBrown);
        public static Color RoyalBlue =>
            new Color(KnownColor.RoyalBlue);
        public static Color SaddleBrown =>
            new Color(KnownColor.SaddleBrown);
        public static Color Salmon =>
            new Color(KnownColor.Salmon);
        public static Color SandyBrown =>
            new Color(KnownColor.SandyBrown);
        public static Color SeaGreen =>
            new Color(KnownColor.SeaGreen);
        public static Color SeaShell =>
            new Color(KnownColor.SeaShell);
        public static Color Sienna =>
            new Color(KnownColor.Sienna);
        public static Color Silver =>
            new Color(KnownColor.Silver);
        public static Color SkyBlue =>
            new Color(KnownColor.SkyBlue);
        public static Color SlateBlue =>
            new Color(KnownColor.SlateBlue);
        public static Color SlateGray =>
            new Color(KnownColor.SlateGray);
        public static Color Snow =>
            new Color(KnownColor.Snow);
        public static Color SpringGreen =>
            new Color(KnownColor.SpringGreen);
        public static Color SteelBlue =>
            new Color(KnownColor.SteelBlue);
        public static Color Tan =>
            new Color(KnownColor.Tan);
        public static Color Teal =>
            new Color(KnownColor.Teal);
        public static Color Thistle =>
            new Color(KnownColor.Thistle);
        public static Color Tomato =>
            new Color(KnownColor.Tomato);
        public static Color Turquoise =>
            new Color(KnownColor.Turquoise);
        public static Color Violet =>
            new Color(KnownColor.Violet);
        public static Color Wheat =>
            new Color(KnownColor.Wheat);
        public static Color White =>
            new Color(KnownColor.White);
        public static Color WhiteSmoke =>
            new Color(KnownColor.WhiteSmoke);
        public static Color Yellow =>
            new Color(KnownColor.Yellow);
        public static Color YellowGreen =>
            new Color(KnownColor.YellowGreen);
        internal Color(KnownColor knownColor)
        {
            this.value = 0L;
            this.state = StateKnownColorValid;
            this.name = null;
            this.knownColor = (short)knownColor;
        }

        private Color(long value, short state, string name, KnownColor knownColor)
        {
            this.value = value;
            this.state = state;
            this.name = name;
            this.knownColor = (short)knownColor;
        }

        public byte R =>
            ((byte)((this.Value >> 0x10) & 0xffL));
        public byte G =>
            ((byte)((this.Value >> 8) & 0xffL));
        public byte B =>
            ((byte)(this.Value & 0xffL));
        public byte A =>
            ((byte)((this.Value >> 0x18) & 0xffL));
        public bool IsKnownColor =>
            ((this.state & StateKnownColorValid) > 0);
        public bool IsEmpty =>
            (this.state == 0);
        public bool IsNamedColor
        {
            get
            {
                if ((this.state & StateNameValid) == 0)
                {
                    return this.IsKnownColor;
                }
                return true;
            }
        }
        public bool IsSystemColor
        {
            get
            {
                if (!this.IsKnownColor)
                {
                    return false;
                }
                if (this.knownColor > 0x1a)
                {
                    return (this.knownColor > 0xa7);
                }
                return true;
            }
        }
        private string NameAndARGBValue
        {
            get
            {
                object[] args = new object[] { this.Name, this.A, this.R, this.G, this.B };
                return string.Format(CultureInfo.CurrentCulture, "{{Name={0}, ARGB=({1}, {2}, {3}, {4})}}", args);
            }
        }
        public string Name
        {
            get
            {
                if ((this.state & StateNameValid) != 0)
                {
                    return this.name;
                }
                if (!this.IsKnownColor)
                {
                    return Convert.ToString(this.value, 0x10);
                }
                string str = KnownColorTable.KnownColorToName((KnownColor)this.knownColor);
                if (str != null)
                {
                    return str;
                }
                return this.knownColor.ToString();
            }
        }
        private long Value
        {
            get
            {
                if ((this.state & StateValueMask) != 0)
                {
                    return this.value;
                }
                if (this.IsKnownColor)
                {
                    return (long)KnownColorTable.KnownColorToArgb((KnownColor)this.knownColor);
                }
                return NotDefinedValue;
            }
        }
        private static void CheckByte(int value, string name)
        {
            if ((value < 0) || (value > 0xff))
            {
                object[] args = new object[] { name, value, 0, 0xff };
                throw new ArgumentException("InvalidEx2BoundArgument");
            }
        }

        private static long MakeArgb(byte alpha, byte red, byte green, byte blue) =>
            ((long)(((ulong)((((red << 0x10) | (green << 8)) | blue) | (alpha << 0x18))) & 0xffffffffL));

        public static Color FromArgb(int argb) =>
            new Color(argb & ((long)0xffffffffL), StateARGBValueValid, null, (KnownColor)0);

        public static Color FromArgb(int alpha, int red, int green, int blue)
        {
            CheckByte(alpha, "alpha");
            CheckByte(red, "red");
            CheckByte(green, "green");
            CheckByte(blue, "blue");
            return new Color(MakeArgb((byte)alpha, (byte)red, (byte)green, (byte)blue), StateARGBValueValid, null, (KnownColor)0);
        }

        public static Color FromArgb(int alpha, Color baseColor)
        {
            CheckByte(alpha, "alpha");
            return new Color(MakeArgb((byte)alpha, baseColor.R, baseColor.G, baseColor.B), StateARGBValueValid, null, (KnownColor)0);
        }

        public static Color FromArgb(int red, int green, int blue) =>
            FromArgb(0xff, red, green, blue);

        public float GetBrightness()
        {
            float num3;
            float num = ((float)this.G) / 255f;
            float num2 = ((float)this.B) / 255f;
            float num4 = num3 = ((float)this.R) / 255f;
            if (num > num3)
            {
                num3 = num;
            }
            if (num2 > num3)
            {
                num3 = num2;
            }
            if (num < num4)
            {
                num4 = num;
            }
            if (num2 < num4)
            {
                num4 = num2;
            }
            return ((num3 + num4) / 2f);
        }

        public float GetHue()
        {
            if ((this.R == this.G) && (this.G == this.B))
            {
                return 0f;
            }
            float num = ((float)this.R) / 255f;
            float num2 = ((float)this.G) / 255f;
            float num3 = ((float)this.B) / 255f;
            float num7 = 0f;
            float num4 = num;
            float num5 = num;
            if (num2 > num4)
            {
                num4 = num2;
            }
            if (num3 > num4)
            {
                num4 = num3;
            }
            if (num2 < num5)
            {
                num5 = num2;
            }
            if (num3 < num5)
            {
                num5 = num3;
            }
            float num6 = num4 - num5;
            if (num == num4)
            {
                num7 = (num2 - num3) / num6;
            }
            else if (num2 == num4)
            {
                num7 = 2f + ((num3 - num) / num6);
            }
            else if (num3 == num4)
            {
                num7 = 4f + ((num - num2) / num6);
            }
            num7 *= 60f;
            if (num7 < 0f)
            {
                num7 += 360f;
            }
            return num7;
        }

        public float GetSaturation()
        {
            float num3;
            float num = ((float)this.G) / 255f;
            float num2 = ((float)this.B) / 255f;
            float num5 = 0f;
            float num4 = num3 = ((float)this.R) / 255f;
            if (num > num3)
            {
                num3 = num;
            }
            if (num2 > num3)
            {
                num3 = num2;
            }
            if (num < num4)
            {
                num4 = num;
            }
            if (num2 < num4)
            {
                num4 = num2;
            }
            if (num3 == num4)
            {
                return num5;
            }
            if (((num3 + num4) / 2f) <= 0.5)
            {
                return ((num3 - num4) / (num3 + num4));
            }
            return ((num3 - num4) / ((2f - num3) - num4));
        }

        public int ToArgb() =>
            ((int)this.Value);

        public KnownColor ToKnownColor() =>
            ((KnownColor)this.knownColor);

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder(0x20);
            builder.Append(base.GetType().Name);
            builder.Append(" [");
            if ((this.state & StateNameValid) != 0)
            {
                builder.Append(this.Name);
            }
            else if ((this.state & StateKnownColorValid) != 0)
            {
                builder.Append(this.Name);
            }
            else if ((this.state & StateValueMask) != 0)
            {
                builder.Append("A=");
                builder.Append(this.A);
                builder.Append(", R=");
                builder.Append(this.R);
                builder.Append(", G=");
                builder.Append(this.G);
                builder.Append(", B=");
                builder.Append(this.B);
            }
            else
            {
                builder.Append("Empty");
            }
            builder.Append("]");
            return builder.ToString();
        }

        public static bool operator ==(Color left, Color right)
        {
            if (((left.value != right.value) || (left.state != right.state)) || (left.knownColor != right.knownColor))
            {
                return false;
            }
            return ((left.name == right.name) || (((left.name != null) && (right.name != null)) && left.name.Equals(right.name)));
        }

        public static bool operator !=(Color left, Color right) =>
            !(left == right);

        public override bool Equals(object obj)
        {
            if (obj is Color)
            {
                Color color = (Color)obj;
                if (((this.value == color.value) && (this.state == color.state)) && (this.knownColor == color.knownColor))
                {
                    return ((this.name == color.name) || (((this.name != null) && (color.name != null)) && this.name.Equals(this.name)));
                }
            }
            return false;
        }

        public override int GetHashCode() =>
            ((this.value.GetHashCode() ^ this.state.GetHashCode()) ^ this.knownColor.GetHashCode());

        static Color()
        {
            Empty = new Color();
            StateKnownColorValid = 1;
            StateARGBValueValid = 2;
            StateValueMask = StateARGBValueValid;
            StateNameValid = 8;
            NotDefinedValue = 0L;
        }
    }
}
#endif