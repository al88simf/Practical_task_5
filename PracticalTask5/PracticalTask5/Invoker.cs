using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет отправителя команд.
    /// </summary>
    internal class Invoker
    {
        // Ссылки на команды.
        ICommand? add;
        ICommand? countBrands;
        ICommand? countAll;
        ICommand? averagePrice;
        ICommand? averagePriceOf;
        ICommand? exit;


        /// <summary>
        /// Метод SetAdd.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду AddCommand.
        /// </remarks>
        /// <param name="add">Ссылка на команду AddCommand.</param>
        public void SetAdd(ICommand? add) => this.add = add;


        /// <summary>
        /// Метод SetCountBrands.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду CountBrandsCommand.
        /// </remarks>
        /// <param name="countBrands">Ссылка на команду CountBrandsCommand.
        /// </param>
        public void SetCountBrands(ICommand? countBrands)
        {
            this.countBrands = countBrands;
        }


        /// <summary>
        /// Метод SetCountAll.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду CountAllCommand.
        /// </remarks>
        /// <param name="countAll">Ссылка на команду CountAllCommand.</param>
        public void SetCountAll(ICommand? countAll)
        {
            this.countAll = countAll;
        }

        /// <summary>
        /// Метод SetAveragePrice.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду AveragePriceCommand.
        /// </remarks>
        /// <param name="averagePrice">Ссылка на команду AveragePriceCommand
        /// </param>
        public void SetAveragePrice(ICommand? averagePrice)
        {
            this.averagePrice = averagePrice;
        }

        /// <summary>
        /// Метод SetAveragePriceOf.
        /// </summary>
        /// <remarks>
        /// Инициализирует команду AveragePriceOfCommand.
        /// </remarks>
        /// <param name="averagePriceOf">Ссылка на команду 
        /// AveragePriceOfBrandCommand.</param>
        public void SetAveragePriceOf(ICommand? averagePriceOf)
        {
            this.averagePriceOf = averagePriceOf;
        }

        /// <summary>
        /// Метод SetExit.
        /// </summary>
        /// <param name="exit">Ссылка на команду ExitCommand.</param>
        public void SetExit(ICommand? exit) => this.exit = exit;
        

        /// <summary>
        /// Метод StartAdd.
        /// </summary>
        /// <remarks>
        /// Запускает команду AddCommand.
        /// </remarks>
        public void StartAdd()
        {
            if (add is ICommand) add.Execute();
        }

        /// <summary>
        /// Метод StartCountBrands.
        /// </summary>
        /// <remarks>
        /// Запускает команду CountBrandsCommand.
        /// </remarks>
        public void StartCountBrands()
        {
            if (countBrands is ICommand) countBrands.Execute();
        }

        /// <summary>
        /// Метод StartCountAll.
        /// </summary>
        /// <remarks>
        /// Запускает команду CountAllCommand.
        /// </remarks>
        public void StartCountAll()
        {
            if (countAll is ICommand) countAll.Execute();
        }

        /// <summary>
        /// Метод StartAveragePrice.
        /// </summary>
        /// <remarks>
        /// Запускает команду AveragePriceCommand.
        /// </remarks>
        public void StartAveragePrice()
        {
            if (averagePrice is ICommand) averagePrice.Execute();
        }

        /// <summary>
        /// Метод StartAveragePriceOf.
        /// </summary>
        /// <remarks>
        /// Запускает команду AveragePriceOfCommand.
        /// </remarks>
        public void StartAveragePriceOf()
        {
            if (averagePriceOf is ICommand) averagePriceOf.Execute();
        }

        /// <summary>
        /// Метод StartExit.
        /// </summary>
        public void StartExit()
        {
            if (exit is ICommand) exit.Execute();
        }
    }
}
