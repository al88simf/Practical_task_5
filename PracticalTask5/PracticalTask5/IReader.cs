using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Интерфейс обеспечивает считывание информации с консоли.
    /// </summary>
    internal interface IReader
    {
        /// <summary>
        /// Метод GetInputArgs.
        /// </summary>
        /// <remarks>
        /// Считывает введенные значения.
        /// </remarks>
        /// <returns>Массив введенных значений.</returns>
        string?[] GetInputArgs();


        /// <summary>
        /// Метод GetSign.
        /// </summary>
        /// <remarks>
        /// Считывает символ для установки статуса повтора.
        /// </remarks>
        /// <returns>Символ повтора.</returns>
        string? GetSign();


        /// <summary>
        /// Метод GetOperation.
        /// </summary>
        /// <remarks>
        /// Считывает имя операции для вызова команды.
        /// </remarks>
        /// <returns>Значение операции.</returns>
        string? GetOperation();


        /// <summary>
        /// Метод GetBrand.
        /// </summary>
        /// <remarks>
        /// Считывает название бренда для команды вычисления средней стоимости 
        /// автомобилей определенной марки.
        /// </remarks>
        /// <returns>Название бренда.</returns>
        string? GetBrand();
    }
}
