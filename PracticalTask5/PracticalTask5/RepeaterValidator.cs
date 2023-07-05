using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет статус повтора ввода автомобилей.
    /// </summary>
    internal class RepeaterValidator : IValidator<bool>
    {
        /// <summary>
        /// Метод Validate.
        /// </summary>
        /// <remarks>
        /// Проверяет на соответствие введенный символ.
        /// </remarks>
        /// <param name="input">Считанное значение.</param>
        /// <returns>Значение, соответствующее успешности проверки.</returns>
        /// <exception cref="Exception">Исключение Exception.</exception>
        public bool Validate(string? input)
        {
            if (string.IsNullOrEmpty(input) || (input.Length > 2))
                throw new Exception("Введите значение корректно!");
            else if (input == "+") return true;
            else if ((input == "x") || (input == "х"))    // один - кирилический
            {
                return false;
            }
            else throw new Exception("Введите значение корректно!");
        }
    }
}
