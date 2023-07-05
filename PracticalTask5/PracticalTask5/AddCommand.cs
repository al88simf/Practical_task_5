using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду Add.
    /// </summary>
    /// <remarks>
    /// Команда, помимо делегирования задачи добавления автомобилей получателю 
    /// (одиночке), также проводит валидацию данных путем инициализации класса 
    /// Car.
    /// </remarks>
    internal class AddCommand : ICommand
    {
        Auto? auto;     // одиночка
        Car? car;

        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        /// <param name="args">Массив введенных данных.</param>
        public AddCommand(Auto? auto, string?[] args)
        {
            this.auto = auto;
            car = new(args[0], args[1], args[2], args[3]);
        }

        public void Execute()
        {
            auto?.Add(car);


            Notify?.Invoke(this, new($"Автомобиль {car?.Brand} {car?.Model} "
                                     + $"успешно добавлен в коллекцию."));
        }
    }
}
