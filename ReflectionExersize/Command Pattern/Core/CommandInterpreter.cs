
using System;
using System.Linq;
using System.Reflection;
using CommandPattern.Commands;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core
{
    public class CommandInterpreter : ICommandInterpreter
    {
        public string Read(string args)
        {
            string[] inpuArray = args
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string commandType = inpuArray[0];
            var commandArg = inpuArray
            .Skip(1)//scipva parviq element
            .ToArray();

            string result = string.Empty;

            ICommand command = default;
            Type type = Assembly.GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == $"{commandType}Command".ToLower());

            ICommand instActivator = (ICommand) Activator.CreateInstance(type);

            result = instActivator.Execute(commandArg);

            return result;
        }
    }
}
