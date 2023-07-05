using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Интерфейс обеспечивает проверку введенных значений.
    /// </summary>
    /// <typeparam name="T">Возвращаемый тип.</typeparam>
    internal interface IValidator<out T>
    {
        /// <summary>
        /// Метод Vallidate.
        /// </summary>
        /// <remarks>
        /// Метод имеет три реализации, каждая возвращает разный тип данных.
        /// </remarks>
        /// <param name="input">Считанное значение.</param>
        /// <returns>Результат проверки.</returns>
        T Validate(string? input);
    }
}
