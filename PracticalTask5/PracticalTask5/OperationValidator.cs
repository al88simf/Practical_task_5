using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет операции.
    /// </summary>
    internal class OperationValidator : IValidator<Operation>
    {
        /// <summary>
        /// Метод Validate.
        /// </summary>
        /// <param name="input">Считанное значение.</param>
        /// <returns>Операция соответствующая введенному значению.</returns>
        /// <exception cref="Exception">Исключение Exception.</exception>
        public Operation Validate(string? input)
        {

            if (string.IsNullOrEmpty(input))
                throw new Exception("Введите значение корректно!");

            switch (input)
            {
                case "Количество марок автомобилей": 
                    return Operation.CountBrands;
                case "Общее количество автомобилей":
                    return Operation.CountAll;
                case "Средняя стоимость автомобиля":
                    return Operation.GetAveragePrice;
                case "Средняя стоимость автомобиля определенной марки":
                    return Operation.GetAveragePriceOf;
                case "Выход":
                    return Operation.Exit;
                default:
                    throw new Exception("Введите значение корректно");
            }
        }
    }
}
