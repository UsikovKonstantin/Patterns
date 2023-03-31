namespace ClassLibraryPatterns
{
    /* Паттерн "Наблюдатель" */

    #region Интерфейс наблюдателя
    public interface IObserver
    {
        /// <summary>
        /// Получение сообщения.
        /// </summary>
        public void Update(Object ob);
    }
    #endregion

    #region Интерфейс наблюдаемого объекта
    public interface IObservable
    {
        /// <summary>
        /// Добавить наблюдателя.
        /// </summary>
        public void RegisterObserver(IObserver o);

        /// <summary>
        /// Удалить наблюдателя.
        /// </summary>
        /// <param name="o"></param>
        public void RemoveObserver(IObserver o);

        /// <summary>
        /// Уведомить наблюдателей.
        /// </summary>
        public void NotifyObservers();
    }
    #endregion

    #region Конкретный класс наблюдаемого объекта
    public class VideoCreator : IObservable
    {
        VideoInfo vInfo;  // информация о видео
        List<IObserver> observers;  // наблюдатели

        /// <summary>
        /// Конструктор.
        /// </summary>
        public VideoCreator()
        {
            observers = new List<IObserver>();
            vInfo = new VideoInfo();
        }

        /// <summary>
        /// Добавить наблюдателя.
        /// </summary>
        /// <param name="o"> наблюдатель </param>
        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        /// <summary>
        /// Удалить наблюдателя.
        /// </summary>
        /// <param name="o"> наблюдатель </param>
        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        /// <summary>
        /// Уведомить наблюдателей.
        /// </summary>
        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update(vInfo);
            }
        }

        /// <summary>
        /// Имитация выпуска нового видео с уведомлением наблюдателей.
        /// </summary>
        public void MakeVideo()
        {
            Random rnd = new Random();

            DateTime start = new DateTime(2023, 3, 1);
            int range = (DateTime.Today - start).Days;
            start = start.AddDays(rnd.Next(range));
            start = start.AddHours(rnd.Next(0, 24)).AddMinutes(rnd.Next(0, 60)).AddSeconds(rnd.Next(0, 60));

            vInfo.UploadTime = start;
            vInfo.Description = descriptions[rnd.Next(0, descriptions.Length)];
            NotifyObservers();
        }

        private string[] descriptions = { "Паттерны проектирования", "Задача Флойда", "Графический редактор",
                "Основы программирования", "Проект \"Полиномы\"", "Программирование и математика",
                "Устройчивость программных проектов", "Декомпозиция данных", "Топологическая сртировка", "Интерпретатор выражений" };
    }
    #endregion

    #region Информация о видео
    class VideoInfo
    {
        /// <summary>
        /// Дата публикации.
        /// </summary>
        public DateTime UploadTime { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }
    }
    #endregion

    #region Конкретный класс наблюдателя
    public class Viewer : IObserver
    {
        public string ChannelName { get; set; }  // имя
        IObservable creator;  // за кем наблюдает

        /// <summary>
        /// Конструктор.
        /// </summary>
        public Viewer(string name, IObservable obs)
        {
            ChannelName = name;
            creator = obs;
            creator.RegisterObserver(this);
        }

        /// <summary>
        /// Действия при получении уведомления.
        /// </summary>
        public void Update(object ob)
        {
            VideoInfo vInfo = (VideoInfo)ob;

            Random gen = new Random();
            int rndint = gen.Next(0, 4);
            if (rndint == 0)
            {
                Console.WriteLine($"{ChannelName} приступит к просмотру  видео \"{vInfo.Description}\" прямо сейчас");
            }
            else if (rndint == 1)
            {
                Console.WriteLine($"{ChannelName} посмотрит видео \"{vInfo.Description}\" сегодня вечером");
            }
            else if (rndint == 2)
            {
                Console.WriteLine($"{ChannelName} посмотрит видео \"{vInfo.Description}\" завтра");
            }
            else if (rndint == 3)
            {
                Console.WriteLine($"{ChannelName} не будет смотреть видео \"{vInfo.Description}\"");
            }
        }

        /// <summary>
        /// Отписаться от наблюдаемого объекта.
        /// </summary>
        public void StopView()
        {
            creator.RemoveObserver(this);
            creator = null;
        }
    }
    #endregion
}
