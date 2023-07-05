using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс обеспечивает добавление автомобилей в коллекцию.
    /// </summary>
    /// <remarks>
    /// Принимает введенные данные и вызывает команду добавления в коллекцию. 
    /// Также обеспечивает статус для повторения процедуры.
    /// </remarks>
    internal class Acceptor
    {
        /// <summary>
        /// Свойство Reader.
        /// </summary>
        IReader? Reader { get; }

        /// <summary>
        /// Свойство BrandValidatior.
        /// </summary>
        IValidator<string>? BrandValidator { get; }

        /// <summary>
        /// Свойство RepeaterValidator.
        /// </summary>
        IValidator<bool> RepeaterValidator { get; }

        /// <summary>
        /// Свойство Operator.
        /// </summary>
        IOperator? Operator { get; }

        /// <summary>
        /// Свойство Auto.
        /// </summary>
        /// <remarks>
        /// Является объектом "Одиночки".
        /// </remarks>
        Auto? Auto { get; }

        /// <summary>
        /// Свойство Invoker.
        /// </summary>
        Invoker? Invoker { get; }

        /// <summary>
        /// Свойство Notifier.
        /// </summary>
        Notifier? Notifier { get; }

        /// <summary>
        /// Свойство IsRepeater.
        /// </summary>
        public bool IsRepeater      // статус повтора
        {
            get
            {
                var sign = Reader?.GetSign();

                return RepeaterValidator.Validate(sign);
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="reader">Считыватель.</param>
        /// <param name="brandValidator">Проверка марки.</param>
        /// <param name="operatr">Инициализатор команд.</param>
        /// <param name="auto">Одиночка.</param>
        /// <param name="invoker">Отправитель.</param>
        /// <param name="notifier">Уведомитель.</param>
        public Acceptor(IReader? reader,
                        IValidator<string> brandValidator,
                        IValidator<bool> repeaterValidator,
                        IOperator? operatr,
                        Auto? auto,
                        Invoker? invoker,
                        Notifier? notifier)
        {
            (Reader, 
                BrandValidator, 
                RepeaterValidator, 
                Operator, 
                Auto, 
                Invoker, 
                Notifier) = (reader, 
                                brandValidator, 
                                repeaterValidator, 
                                operatr, 
                                auto, 
                                invoker, 
                                notifier);

        }

        /// <summary>
        /// Метод Process.
        /// </summary>
        /// <remarks>
        /// Получает введенные данные и отправляет их команде Add. Также 
        /// запускает команду CountAll для подсчета добавленных элементов.
        /// </remarks>
        public void Process()
        {
            var inputs = Reader?.GetInputArgs();    // введенные данные

            if (inputs is not null)
            {
                // Инициализация команды Add.
                var addCommand = new AddCommand(Auto, inputs);
                Notifier?.Send(addCommand);
                Invoker?.SetAdd(addCommand);
                Invoker?.StartAdd();
            }

            Operator?.SelectCommand(Reader,         // подсчет автомобилей
                                    BrandValidator,
                                    Auto,
                                    Operation.CountAll,
                                    Invoker,
                                    Notifier);
        }
    }
}
