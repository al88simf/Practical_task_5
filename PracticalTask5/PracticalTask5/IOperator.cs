using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Интерфейс представляет инициализатор команд.
    /// </summary>
    internal interface IOperator
    {
        /// <summary>
        /// Метод SelectCommad.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду, соответствующую операции.
        /// </remarks>
        /// <param name="reader">Считывателью</param>
        /// <param name="brandValidator">Проверка марки.</param>
        /// <param name="auto">Получатель команды.</param>
        /// <param name="operation">Операция.</param>
        /// <param name="invoker">Отправитель команды.</param>
        /// <param name="notifier">Уведомитель.</param>
        void SelectCommand(IReader? reader,
                           IValidator<string>? brandValidator,
                           Auto? auto,
                           Operation? operation,
                           Invoker? invoker,
                           Notifier? notifier);
    }
}
