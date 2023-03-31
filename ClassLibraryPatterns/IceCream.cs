namespace ClassLibraryPatterns
{
    /* Паттерн "Декоратор" стандартная реализация */

    #region Абстрактный класс того, что будем декорировать
    /// <summary>
    /// Абстракный класс "Мороженое".
    /// </summary>
    public abstract class IceCream
    {
        protected string description = "";
        /// <summary>
        /// Описание.
        /// </summary>
        public string Description
        {
            get { return description; }
        }

        /// <summary>
        /// Реализуется каждым потомком.
        /// </summary>
        /// <returns> стоимость мороженого </returns>
        public abstract double Cost();

        public override string ToString()
        {
            return description + "\n" + "cost: " + Cost();
        }
    }
    #endregion

    #region Абстрактный класс декоратор
    /// <summary>
    /// Родитель декораторов, задающих добавки к мороженому.
    /// </summary>
    public abstract class CondimentDecorator : IceCream
    {
        /// <summary>
        /// Реализуется потомками.
        /// </summary>
        /// <returns> возвращает описание напитка со всеми добавками </returns>
        public abstract string GetDescription();

        /// <summary>
        /// Вложенный декорируемый объект.
        /// </summary>
        protected IceCream complex;
    }
    #endregion

    #region Конкретные классы того, что будем декорировать
    /// <summary>
    /// Пломбир.
    /// </summary>
    public class Plombier : IceCream
    {
        public Plombier()
        {
            description += "Мороженое пломбир ";
        }

        public override double Cost()
        {
            return 20.50;
        }
    }

    /// <summary>
    /// Сливочное мороженое.
    /// </summary>
    public class Sundae : IceCream
    {
        public Sundae()
        {
            description += "Мороженое сливочное ";
        }

        public override double Cost()
        {
            return 15.50;
        }
    }

    /// <summary>
    /// Молочное мороженое.
    /// </summary>
    public class MilkIceCream : IceCream
    {
        public MilkIceCream()
        {
            description += "Мороженое молочное ";
        }

        public override double Cost()
        {
            return 10.50;
        }
    }
    #endregion

    #region Конкретные классы декораторы
    /// <summary>
    /// Шоколадная стружка.
    /// </summary>
    public class ChocolateChips : CondimentDecorator
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="ic"> встроенный объект, декорируется шоколадной стружкой </param>
        public ChocolateChips(IceCream ic)
        {
            complex = ic;
            description = ic.Description + " Шоколадная стружка ";
        }

        public override string GetDescription()
        {
            return complex.Description + " Шоколадная стружка ";
        }

        public override double Cost()
        {
            return complex.Cost() + 5.50;
        }
    }

    /// <summary>
    /// Орешки.
    /// </summary>
    public class Nuts : CondimentDecorator
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="ic"> встроенный объект, декорируется орешками </param>
        public Nuts(IceCream ic)
        {
            complex = ic;
            description = ic.Description + " Орешки ";
        }

        public override string GetDescription()
        {
            return complex.Description + " Орешки ";
        }

        public override double Cost()
        {
            return complex.Cost() + 3.50;
        }
    }

    /// <summary>
    /// Малиновый сироп.
    /// </summary>
    public class RaspberrySyrup : CondimentDecorator
    {
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="ic"> встроенный объект, декорируется малиновым сиропом </param>
        public RaspberrySyrup(IceCream ic)
        {
            complex = ic;
            description = ic.Description + " Малиновый сироп ";
        }

        public override string GetDescription()
        {
            return complex.Description + " Малиновый сироп ";
        }

        public override double Cost()
        {
            return complex.Cost() + 6.50;
        }
    }
    #endregion
}