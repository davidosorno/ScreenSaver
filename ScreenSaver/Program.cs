using System;

namespace ScreenSaver
{
    class Program
    {
        static void Main(string[] args)
        {
            Color color = new Color();
            Cursor cursor = new Cursor();
            while (true)
            {
                cursor.SetRandomCursorPosition();
                cursor.SetTextColor(color.getColor());
                cursor.ShowMessage($"Hello World!!! Position({cursor.PositionX}, {cursor.PositionY})");
                System.Threading.Thread.Sleep(400);
            }
        }
    }
}
