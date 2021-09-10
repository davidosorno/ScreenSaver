using System;
using System.Collections.Generic;

namespace ScreenSaver
{
    class Color
    {
        private List<ConsoleColor> listColors = new List<ConsoleColor>();

        public Color()
        {
            fillListColors();
        }   

        //Methods
        private void fillListColors()
        {
            listColors.Add(ConsoleColor.Red);
            listColors.Add(ConsoleColor.Blue);
            listColors.Add(ConsoleColor.Yellow);
            listColors.Add(ConsoleColor.DarkGray);
            listColors.Add(ConsoleColor.DarkBlue);
            listColors.Add(ConsoleColor.Cyan);
            listColors.Add(ConsoleColor.White);
            listColors.Add(ConsoleColor.Green);
            listColors.Add(ConsoleColor.Magenta);
            listColors.Add(ConsoleColor.DarkGreen);
        }


        public ConsoleColor getColor()
        {
            Random rnd = new Random();
            int listSize = listColors.Count - 1;
            int index = rnd.Next(listSize);
            return listColors[index];
        }
    }
}
