using PraciticalTask2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет марку автомобиля для команды 
    /// AveragePriceOfBrandCommand.
    /// </summary>
    internal class BrandValidator : IValidator<string>
    {
        Auto? auto;

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="auto">Одиночка.</param>
        public BrandValidator(Auto? auto) => this.auto = auto;

        /// <summary>
        /// Метод Validate.
        /// </summary>
        /// <param name="input">Считанное значение.</param>
        /// <returns>Марка автомобиля, в соответствии с введенным значением.
        /// </returns>
        /// <exception cref="Exception">Исключение Exception.</exception>
        /// <exception cref="InitializationException">Исключение 
        /// InitializationException.</exception>
        public string Validate(string? input)
        {
            string brand;
            
            if (string.IsNullOrEmpty(input))
                throw new Exception("Введите значение корректно!");

            if (auto is not null)
            {
                foreach (var car in auto.cars)
                {
                    if (auto.cars.Exists(p => input == car.Brand))
                    {
                        brand = input;
                        return brand;
                    }
                }
            }
            throw new InitializationException("Данной марки авто в "
                                              + "коллекции нет", input);
        }
    }
}
