
using System;
using DIContainer.Attributes;
using SnakeGame.IO.Contracts;

namespace SnakeGame.Engine
{
    public class Engine
    {
        private IWriter writer;
        private IReader reader;
        [Inject]
        public Engine(IReader reader,IWriter writer)
        {
            this.writer = writer;
            this.reader = reader;
           
        }

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("asdas");
            }
        }
    }
}
