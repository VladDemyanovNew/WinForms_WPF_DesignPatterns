using System;
using System.Collections.Generic;
using System.Text;

namespace VDemyanov.BankApp.Persistence.CommandPattern
{
    /// <summary>
    /// Инициатор команды
    /// </summary>
    public class Invoker
    {
        private Command _command;
        public Command Command
        {
            set
            {
                _command = value;
            }
        }
        public void Run()
        {
            if (_command != null)
                _command.Excecute();
            else
                throw new Exception("public class Invoker: не инициализирована private Command _command");
        }
        public void Undo()
        {
            _command.Undo();
        }
    }
}
