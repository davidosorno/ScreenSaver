using System;

namespace ScreenSaver
{
    class Cursor : IColor, IMessage
    {

        private int _x;
        public int PositionX
        {
            get { return _x; }
            set
            {
                if (value < 100)
                {
                    _x = value;
                }
            }
        }

        private int _y;
        public int PositionY
        {
            get { return _y; }
            set
            {
                if (value < 100)
                {
                    _y = value;
                }
            }
        }
        
        //Methods
        public void SetTextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public void SetBackroundColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void SetCursorPosition(int x, int y)
        {
            try
            {
                PositionX = x;
                PositionY = y;
                Console.SetCursorPosition(x, y);
            }
            catch (Exception ex)
            {
                Console.WriteLine("");
            }
        }

        public void SetRandomCursorPosition()
        {
            Random rnd = new Random();
            int x = rnd.Next(150);
            int y = rnd.Next(150);
            SetCursorPosition(x, y);
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
