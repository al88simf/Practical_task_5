using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет считыватель данных с консоли.
    /// </summary>
    internal class Reader : IReader
    {
        public string?[] GetInputArgs()
        {
            Console.Write("Введите марку автомобиля: ");
            var inputBrand = Console.ReadLine();
            Console.Write("Введите модель автомобиля: ");
            var inputModel = Console.ReadLine();
            Console.Write("Введите количество автомобилей данной модели: ");
            var inputNumber = Console.ReadLine();
            Console.Write("Введите стоимость одной единицы: ");
            var inputPrice = Console.ReadLine();

            return new string?[]
            {
                inputBrand,
                inputModel,
                inputNumber,
                inputPrice
            };
        }

        public string? GetSign()
        {
            Console.Write("Чтобы добавить еще автомобиль, нажмите \"+\", "
                          + "чтобы завершить добавление автомобилей, "
                          + "нажмите \"х\": ");

            return Console.ReadLine();      // считанное значение
        }

        public string? GetOperation()
        {
            Console.WriteLine("Введите команду:");
            Console.Write("\tКоличество марок автомобилей;"
                          + "\n\tОбщее количество автомобилей;"
                          + "\n\tСредняя стоимость автомобиля;"
                          + "\n\tСредняя стоимость автомобиля определенной "
                          + "марки;"
                          + "\n\tВыход"
                          + "\n\n\t");

            return Console.ReadLine();
        }

        public string? GetBrand()
        {
            Console.Write("Введите название марки автомобиля: ");

            return Console.ReadLine();
        }
    }
}
