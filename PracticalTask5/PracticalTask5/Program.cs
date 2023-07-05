using PraciticalTask2Lib;
using PracticalTask4;

namespace PracticalTask5
{
    /// <summary>
    /// Класс обеспечивает прием информации о легковых автомобилях и команд 
    /// для получения информации.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Список агрументов для командной строки.</param>
        static void Main(string[] args)
        {
            var auto = Auto.GetAuto();      // одиночка
            var invoker = new Invoker();
            var notifier = new Notifier();


            Console.WriteLine("Добавьте новый автомобиль в коллекцию.");
            
            // Повтор цикла добавления в коллекцию.
            while (true)
            {
                try
                {
                    var acceptor = new Acceptor(new Reader(),
                                                new BrandValidator(auto),
                                                new RepeaterValidator(),
                                                new Operator(),
                                                auto,
                                                invoker,
                                                notifier);

                    // Принимает, проверяет и добавляет в коллекцию.
                    acceptor.Process();

                    // Статус для повторения цикла.
                    if (acceptor.IsRepeater) continue;
                    else break;
                }
                catch (InitializationException ex)
                {
                    Console.WriteLine($"Неверное значение {ex.WrongInput}");
                    Console.WriteLine(ex.Message);
                }
                catch (AddException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            // Повтор цикла до завершения программы.
            while (true)
            {
                try
                {
                    var commander = new Commander(new Reader(),
                                                  new OperationValidator(),
                                                  new BrandValidator(auto),
                                                  new Operator(),
                                                  auto,
                                                  invoker,
                                                  notifier);
                    commander.Choose();         // выбирает команду

                    if (auto.IsFinish) break;   // завершение программы
                }
                catch (InitializationException ex)
                {
                    Console.WriteLine($"Неверное значение {ex.WrongInput}");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}