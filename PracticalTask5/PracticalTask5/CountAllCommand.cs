using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду CountAllCommand.
    /// </summary>
    internal class CountAllCommand : ICommand
    {
        Auto? auto;

        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        public CountAllCommand(Auto? auto) => this.auto = auto;


        public void Execute()
        {
            var result = auto?.CountAll();


            Notify?.Invoke(this, new($"Общее количество автомобилей в "
                                     + $"коллекции: {result}."));
        }
    }
}
