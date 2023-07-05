using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Интерфейс представляет команды для управления коллекцией автомобилей.
    /// </summary>
    internal interface ICommand
    {
        /// <summary>
        /// Событие для оповещения о действиях совершенных командами.
        /// </summary>
        event Action<ICommand, CommandEventArgs>? Notify;


        /// <summary>
        /// Метод Execute.
        /// </summary>
        /// <remarks>
        /// Делегирует основную задачу команды получателю (Одиночке).
        /// </remarks>
        void Execute();
    }
}
