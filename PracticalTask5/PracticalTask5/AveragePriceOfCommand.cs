using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду AveragePriceOfCommand.
    /// </summary>
    internal class AveragePriceOfCommand : ICommand
    {
        Auto? auto;
        string? brand;      // аргумент метода получателя

        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Коструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        /// <param name="brand">Марка автомобиля.</param>
        public AveragePriceOfCommand(Auto? auto, string? brand)
        {
            this.auto = auto; this.brand = brand;
        }

        public void Execute()
        {
            var result = auto?.GetAveragePriceOf(brand);


            Notify?.Invoke(this, new($"Средняя цена автомобилей марки "
                                     + $"{brand}: {result}."));
        }
    }
}
