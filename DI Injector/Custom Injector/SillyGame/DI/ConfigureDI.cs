﻿
using System;
using DIContainer.Modules;
using SillyGame.IO;
using SnakeGame.IO.Contracts;

namespace SillyGame.DI
{
    public class ConfigureDI:AbstractModule
    {
        public override void Configure()
        {
           CreateMapping<IReader,ConsoleReader>();
           CreateMapping<IWriter,ConsoleWriter>();
        }
    }
}
