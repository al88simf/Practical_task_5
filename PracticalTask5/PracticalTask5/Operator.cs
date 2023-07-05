using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Инициализатор комманд.
    /// </summary>
    internal class Operator : IOperator
    {
        public void SelectCommand(IReader? reader,
                                  IValidator<string>? brandValidator,
                                  Auto? auto,
                                  Operation? operation,
                                  Invoker? invoker,
                                  Notifier? notifier)
        {
            switch (operation)
            {
                case Operation.CountBrands:
                    {
                        // Инициализация команды CountBrandsCommand.
                        var countBrandsCommand = new CountBrandsCommand(auto);
                        notifier?.Send(countBrandsCommand);
                        invoker?.SetCountBrands(countBrandsCommand);
                        invoker?.StartCountBrands();
                        break;
                    }
                case Operation.CountAll:
                    {
                        // Инициализаци команды CountAllCommand.
                        var countAllCommand = new CountAllCommand(auto);
                        notifier?.Send(countAllCommand);
                        invoker?.SetCountAll(countAllCommand);
                        invoker?.StartCountAll();
                        break;
                    }
                case Operation.GetAveragePrice:
                    {
                        // Инициализаци команды AveragePriceCommand.
                        var averagePriceCommand = new AveragePriceCommand(auto);
                        notifier?.Send(averagePriceCommand);
                        invoker?.SetAveragePrice(averagePriceCommand);
                        invoker?.StartAveragePrice();
                        break;
                    }
                case Operation.GetAveragePriceOf:
                    {
                        // Получение заданной марки автомобиля.
                        var input = reader?.GetBrand();
                        var brand = brandValidator?.Validate(input);

                        // Инициализаци команды AveragePriceOfCommand.
                        var averagePriceOfCommand = 
                            new AveragePriceOfCommand(auto, brand);
                        notifier?.Send(averagePriceOfCommand);
                        invoker?.SetAveragePriceOf(averagePriceOfCommand);
                        invoker?.StartAveragePriceOf();
                        break;
                    }
                default:
                    {
                        // Инициализация команды ExitCommand.
                        var exitCommand = new ExitCommand(auto);
                        notifier?.Send(exitCommand);
                        invoker?.SetExit(exitCommand);
                        invoker?.StartExit();
                        break;
                    }
            }
        }
    }
}
