using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду AveragePriceCommand.
    /// </summary>
    internal class AveragePriceCommand : ICommand
    {
        Auto? auto;

        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        public AveragePriceCommand(Auto? auto) => this.auto = auto;

        
        public void Execute()
        {
            var result = auto?.GetAveragePrice();


            Notify?.Invoke(this, new($"Средняя цена автомобиля в "
                                     + $"коллекции: {result}."));
        }
    }
}
