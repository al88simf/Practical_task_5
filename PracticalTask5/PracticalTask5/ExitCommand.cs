using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду ExitCommand.
    /// </summary>
    internal class ExitCommand : ICommand
    {
        Auto? auto;
        
        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        public ExitCommand(Auto? auto) => this.auto = auto;


        public void Execute()
        {
            if (auto is not null) auto.IsFinish = true;


            Notify?.Invoke(this, new("Программа завершена."));
        }
    }
}
