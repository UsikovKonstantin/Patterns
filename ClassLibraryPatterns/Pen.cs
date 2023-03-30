namespace ClassLibraryPatterns
{
    /* Паттерн "Стратегия" */

    #region Абстрактный класс
    /// <summary>
    /// Абстрактный класс, прародитель различных классов ручек.
    /// </summary>
    public abstract class Pen
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Pen()
        { }

        /// <summary>
        /// Объект класса, определяющего поведение письма.
        /// </summary>
        public IWriteBehavior iWriteBehavior;

        /// <summary>
        /// Полиморфный метод, отображающий объект.
        /// Каждый конкретный класс ручек должен задавать реализацию метода.
        /// </summary>
        public abstract string Display();

        /// <summary>
        /// Объект iWriteBehavior должен иметь метод Write(),
        /// позволяющий писать определенным образом.
        /// Делегирование операции соответствующему классу поведения.
        /// </summary>
        public string PerformWrite()
        {
            return iWriteBehavior.Write();
        }

        /// <summary>
        /// Метод, позволяющий динамически изменять поведение письма.
        /// </summary>
        /// <param name="crb"> новое поведение </param>
        public void SetIWriteBehavior(IWriteBehavior crb)
        {
            iWriteBehavior = crb;
        }
    }
    #endregion

    #region Конкретные классы
    /// <summary>
    /// Конкретный класс - шариковая ручка.
    /// </summary>
    public class BallPointPen : Pen
    {
        public BallPointPen()
        {
            iWriteBehavior = new WriteWithBallPoint();
        }

        public override string Display()
        {
            return "Я шариковая ручка";
        }
    }

    /// <summary>
    /// Конкретный класс - гелевая ручка.
    /// </summary>
    public class GelPen : Pen
    {
        public GelPen()
        {
            iWriteBehavior = new WriteWithGel();
        }

        public override string Display()
        {
            return "Я гелевая ручка";
        }
    }

    /// <summary>
    /// Конкретный класс - перьевая ручка.
    /// </summary>
    public class FountainPen : Pen
    {
        public FountainPen()
        {
            iWriteBehavior = new WriteWithFountain();
        }

        public override string Display()
        {
            return "Я перьевая ручка";
        }
    }

    /// <summary>
    /// Конкретный класс - перьевая ручка.
    /// </summary>
    public class CapillaryPen : Pen
    {
        public CapillaryPen()
        {
            iWriteBehavior = new WriteWithСapillary();
        }

        public override string Display()
        {
            return "Я капиллярная ручка";
        }
    }
    #endregion

    #region Интерфейсы
    /// <summary>
    /// Интерфейсный класс - родитель классов поведения для свойства "писать".
    /// </summary>
    public interface IWriteBehavior
    {
        string Write();
    }

    /// <summary>
    /// Класс поведения.
    /// Задает способ письма.
    /// </summary>
    public class WriteWithBallPoint : IWriteBehavior
    {
        const string MESSAGE_WRITE = "Я пишу металлическим шариком!";

        /// <summary>
        /// Способ письма - металлическим шариком.
        /// </summary>
        /// <returns> сообщение о результате операции </returns>
        public string Write()
        {
            return MESSAGE_WRITE;
        }
    }

    /// <summary>
    /// Класс поведения.
    /// Задает способ письма.
    /// </summary>
    public class WriteWithGel : IWriteBehavior
    {
        const string MESSAGE_WRITE = "Я пишу гелевыми чернилами!";

        /// <summary>
        /// Способ письма - гелевыми чернилами.
        /// </summary>
        /// <returns> сообщение о результате операции </returns>
        public string Write()
        {
            return MESSAGE_WRITE;
        }
    }

    /// <summary>
    /// Класс поведения.
    /// Задает способ письма.
    /// </summary>
    public class WriteWithFountain : IWriteBehavior
    {
        const string MESSAGE_WRITE = "Я пишу металлическим пером!";

        /// <summary>
        /// Способ письма - металлическим пером.
        /// </summary>
        /// <returns> сообщение о результате операции </returns>
        public string Write()
        {
            return MESSAGE_WRITE;
        }
    }

    /// <summary>
    /// Класс поведения.
    /// Задает способ письма.
    /// </summary>
    public class WriteWithСapillary : IWriteBehavior
    {
        const string MESSAGE_WRITE = "Я пишу синтетическим стержнем!";

        /// <summary>
        /// Способ письма - синтетическим стержнем.
        /// </summary>
        /// <returns> сообщение о результате операции </returns>
        public string Write()
        {
            return MESSAGE_WRITE;
        }
    }
    #endregion
}