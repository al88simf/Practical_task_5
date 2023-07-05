using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет команду CountBrandsCommand.
    /// </summary>
    internal class CountBrandsCommand : ICommand
    {
        Auto? auto;

        public event Action<ICommand, CommandEventArgs>? Notify;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Получатель команды.</param>
        public CountBrandsCommand(Auto? auto) => this.auto = auto;


        public void Execute()
        {
            var result = auto?.CountBrands();


            Notify?.Invoke(this, new($"Количество марок автомобилей в "
                                     + $"коллекции: {result}."));
        }
    }
}
