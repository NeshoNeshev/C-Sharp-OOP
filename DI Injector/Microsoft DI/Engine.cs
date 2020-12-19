
using System;
using SnakeGame.IO.Contracts;

namespace SnakeGame.Engine
{
    public class Engine
    {
        private IWriter writer;
        private IReader reader;
      
        public Engine(IReader reader,IWriter writer)
        {
            this.writer = writer;
            this.reader = reader;
           
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("working");
            }
        }
    }
}
