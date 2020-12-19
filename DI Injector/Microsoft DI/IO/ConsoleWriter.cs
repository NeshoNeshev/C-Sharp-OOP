

using System;
using SnakeGame.IO.Contracts;

namespace SillyGame.IO
{
    public class ConsoleWriter:IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}
