using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет аргументы для события Notify.
    /// </summary>
    internal class CommandEventArgs
    {
        /// <summary>
        /// Свойство Message.
        /// </summary>
        public string? Message { get; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="message">Сообщение.</param>
        public CommandEventArgs(string? message) => Message = message;
    }
}
