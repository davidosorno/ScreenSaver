using System;

namespace ScreenSaver
{
    interface IColor
    {
        void SetTextColor(ConsoleColor color);
        void SetBackroundColor(ConsoleColor color);
    }
}
