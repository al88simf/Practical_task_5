using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет получателя команд.
    /// </summary>
    /// <remarks>
    /// Класс построен в соответствии с паттерном "Одиночка".
    /// </remarks>
    internal class Auto
    {
        // Ленивая инициализация.
        static readonly Lazy<Auto> auto = new(() => new());

        public List<Car> cars = new();      // коллекция автомобилей

        /// <summary>
        /// Свойство IsFinish.
        /// </summary>
        /// <remarks>
        /// Статус для завершения программы.
        /// </remarks>
        public bool IsFinish { get; set; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <remarks>
        /// Скрытый пустой конструктор, который задействуется только при 
        /// необходимости.
        /// </remarks>
        Auto() { }


        /// <summary>
        /// Метод GetAuto.
        /// </summary>
        /// <remarks>
        /// Метод обеспечивет получение объекта одиночки.
        /// </remarks>
        /// <returns>Объект одиночки.</returns>
        public static Auto GetAuto() => auto.Value;


        /// <summary>
        /// Метод Add.
        /// </summary>
        /// <remarks>
        /// Добавляет введенные и проверенные параметры автомобиля в коллекцию.
        /// </remarks>
        /// <param name="car"></param>
        public void Add(Car? car)
        {
            if (car is not null) cars.Add(car);
        }

        /// <summary>
        /// Метод CountBrands.
        /// </summary>
        /// <remarks>
        /// Подсчитывает количество марок автомобилей в коллекции.
        /// </remarks>
        /// <returns>Количества марок автомобилей.</returns>
        public int CountBrands()
        {
            int match = 0;

            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = i + 1; j < cars.Count; j++)
                {
                    // если совпадает значение бренда текущего и последующего 
                    // автомобиля - указывает совпадение.
                    var result = cars.Find(p => cars[i].Brand == cars[j].Brand);
                    if (result is not null) match++;
                }
            }

            return cars.Count - match;
        }

        /// <summary>
        /// Метод CountAll.
        /// </summary>
        /// <returns>Общее количество автомобилей.</returns>
        public int CountAll() => cars.Count;


        /// <summary>
        /// Метод GetAveragePrice.
        /// </summary>
        /// <remarks>
        /// Вычисляет среднюю стоимость автомобиля по формуле вычисления 
        /// среднего арифметического.
        /// </remarks>
        /// <returns>Средняя стоимость автомобиля.</returns>
        public int GetAveragePrice()
        {
            int priceSum = 0;
            
            foreach (var car in cars) priceSum += car.Cost;

            return priceSum / cars.Count;
        }

        /// <summary>
        /// Метод GetAveragePriceOf.
        /// </summary>
        /// <remarks>
        /// Вычисляет по формуле среднего арифметического среднюю стоимость 
        /// автомобиля определенной марки.
        /// </remarks>
        /// <param name="brand">Заданная марка.</param>
        /// <returns>Средняя стоимость автомобиля конкретной марки.</returns>
        public int GetAveragePriceOf(string? brand)
        {
            int priceSum = 0;
            int brandNum = 0;
            
            foreach (var car in cars)
            {
                // Подсчитывает общую стоимость автомобилей конкретной марки, 
                // а также количество таких автомобилей.
                var result = cars.Find(p => brand == car.Brand);
                if (result is not null)
                {
                    priceSum += car.Cost;
                    brandNum++;
                }
            }

            return priceSum / brandNum;
        }
    }
}
