using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет обработчик события Notify.
    /// </summary>
    internal class Notifier
    {
        /// <summary>
        /// Метод Send.
        /// </summary>
        /// <remarks>
        /// Подписывает обработчик на событие Notify.
        /// </remarks>
        /// <param name="command">Команда отправитель.</param>
        public void Send(ICommand command)
        {
            command.Notify += (sender, e) => Console.WriteLine(e.Message);
        }
    }
}
