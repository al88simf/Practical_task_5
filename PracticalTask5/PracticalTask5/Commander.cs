using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет клиентский код для запуска команд.
    /// </summary>
    internal class Commander
    {
        /// <summary>
        /// Свойство Reader.
        /// </summary>
        IReader? Reader { get; }


        /// <summary>
        /// Свойство OpValidator.
        /// </summary>
        IValidator<Operation>? OpValidator { get; }


        /// <summary>
        /// Свойство BrandValidator.
        /// </summary>
        IValidator<string>? BrandValidator { get; }


        /// <summary>
        /// Свойство Operator.
        /// </summary>
        IOperator? Operator { get; }


        /// <summary>
        /// Свойство Auto.
        /// </summary>
        Auto? Auto { get; }     // объект одиночки


        /// <summary>
        /// Свойство Invoker.
        /// </summary>
        Invoker? Invoker { get; }


        /// <summary>
        /// Свойство Notifier.
        /// </summary>
        Notifier? Notifier { get; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="reader">Считыватель.</param>
        /// <param name="opValidator">Проверка операции.</param>
        /// <param name="brandValidator">Проверка марки.</param>
        /// <param name="operatr">Инициализатор команд.</param>
        /// <param name="auto">Одиночка</param>
        /// <param name="invoker">Отправитель.</param>
        /// <param name="notifier">Уведомитель.</param>
        public Commander(IReader? reader,
                         IValidator<Operation>? opValidator,
                         IValidator<string>? brandValidator,
                         IOperator? operatr,
                         Auto? auto,
                         Invoker? invoker,
                         Notifier? notifier)
        {
            (Reader, 
                OpValidator, 
                BrandValidator, 
                Operator, 
                Auto, 
                Invoker, 
                Notifier) = (reader, 
                                opValidator, 
                                brandValidator, 
                                operatr, 
                                auto, 
                                invoker, 
                                notifier);

        }

        /// <summary>
        /// Метод Choose.
        /// </summary>
        /// <remarks>
        /// Принимает введенное значение команды, отправляет его на проверку, 
        /// получает соответствующую операцию, отправляет на инициализацию.
        /// </remarks>
        public void Choose()
        {            
            var input = Reader?.GetOperation();
            var operation = OpValidator?.Validate(input);
            Operator?.SelectCommand(Reader,
                                    BrandValidator,
                                    Auto,
                                    operation,
                                    Invoker,
                                    Notifier);
        }
    }
}
