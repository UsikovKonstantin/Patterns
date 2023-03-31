namespace ClassLibraryPatterns
{
    /* Паттерн "Декоратор" модернизированная реализация */

    #region Класс декорированных мороженых
    /// <summary>
    /// Класс декорированных мороженых.
    /// В общем случае объектов меню в широком смысле этого слова.
    /// </summary>
    public class DecorIceCream
    {
        protected string description;  // описание объекта
        protected double cost;  // цена объекта

        /// <summary>
        /// Конструктор, задающий свойства объектов.
        /// </summary>
        /// <param name="dsc"> описание объекта </param>
        /// <param name="cst"> цена объекта </param>
        public DecorIceCream(string dsc, double cst)
        {
            description = dsc;
            cost = cst;
        }

        /// <summary>
        /// Метод, позволяющий динамически добавлять в заказ новый элемент меню.
        /// </summary>
        /// <param name="decIC"> добавляемый в меню элемент </param>
        /// <returns> новый заказ </returns>
        public DecorIceCream AddDecor(DecorIceCream decIC)
        {
            string descNew = description + ", " + decIC.description;
            double costNew = cost + decIC.cost;
            return new DecorIceCream(descNew, costNew);
        }

        /// <summary>
        /// Описание заказа.
        /// </summary>
        public override string ToString()
        {
            return description + "\n" + "Cost: " + cost;
        }
    }
    #endregion

    #region Конкретные классы мороженых
    /// <summary>
    /// Пломбир.
    /// </summary>
    public class DecorPlombier : DecorIceCream
    {
        public DecorPlombier(string desc = "Мороженое пломбир ", double cost = 20.50) : base(desc, cost)
        { }
    }

    /// <summary>
    /// Сливочное мороженое.
    /// </summary>
    public class DecorSundae : DecorIceCream
    {
        public DecorSundae(string desc = "Мороженое сливочное ", double cost = 15.50) : base(desc, cost)
        { }
    }

    /// <summary>
    /// Сливочное мороженое.
    /// </summary>
    public class DecorMilkIceCream : DecorIceCream
    {
        public DecorMilkIceCream(string desc = "Мороженое молочное ", double cost = 10.50) : base(desc, cost)
        { }
    }
    #endregion

    #region Конкретные классы добавок
    /// <summary>
    /// Шоколадная стружка.
    /// </summary>
    public class DecorChocolateChips : DecorIceCream
    {
        public DecorChocolateChips(string desc = "Шоколадая стружка ", double cost = 5.50) : base(desc, cost)
        { }
    }

    /// <summary>
    /// Орешки.
    /// </summary>
    public class DecorNuts : DecorIceCream
    {
        public DecorNuts(string desc = "Орешки ", double cost = 3.50) : base(desc, cost)
        { }
    }

    /// <summary>
    /// Малиновый сироп.
    /// </summary>
    public class DecorRaspberrySyrup : DecorIceCream
    {
        public DecorRaspberrySyrup(string desc = "Малиновый сироп ", double cost = 6.50) : base(desc, cost)
        { }
    }
    #endregion
}