using PracticalTask4;
using PraciticalTask2Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTask5
{
    /// <summary>
    /// Класс представляет конкретный легковой автомобиль.
    /// </summary>
    internal class Car
    {
        /// <summary>
        /// Хранилище свойства Brand.
        /// </summary>
        string? brand;

        /// <summary>
        /// Хранилище свойства Model.
        /// </summary>
        string? model;

        /// <summary>
        /// Хранилище свойства Number.
        /// </summary>
        int number;

        /// <summary>
        /// Хранилище свойства Cost.
        /// </summary>
        int cost;

        /// <summary>
        /// Свойство Brand.
        /// </summary>
        public string? Brand
        {
            get => brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AddException("Название не должно быть пустым.");
                else brand = value;
            }
        }

        /// <summary>
        /// Свойство Model.
        /// </summary>
        public string? Model
        {
            get => model;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AddException("Название не должно быть пустым.");
                else model = value;
            }
        }

        /// <summary>
        /// Свойство Number.
        /// </summary>
        public int Number
        {
            get => number;
            set
            {
                if (value == 0)
                    throw new AddException("Количество не должно равняться " +
                        "нулю");
                else number = value;
            }
        }

        /// <summary>
        /// Свойство Cost.
        /// </summary>
        public int Cost
        {
            get => cost;
            set
            {
                if (value == 0)
                    throw new AddException("Цена не должна равняться нулю.");
                else cost = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="brand">Торговая марка.</param>
        /// <param name="model">Модель.</param>
        /// <param name="cost">Стоимость единицы.</param>
        public Car(string? brand,
                   string? model,
                   string? number,
                   string? cost)
        {
            if (!int.TryParse(cost, out var resultCost))
            {
                throw new InitializationException("Введите значение "
                                                  + "корректно!", cost);
            }
            else if (!int.TryParse(number, out var resultNumber))
            {
                throw new InitializationException("Введите значение "
                                                  + "корректно", number);
            }    
            else
            {
                (Brand, Model, Number, Cost) = 
                    (brand, model, resultNumber, resultCost);
            }
        }
    }
}
