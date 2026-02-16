namespace Otus.Learning
{
    //Рабочий - базовый класс для всех остальных сущностей (абстрактный класс). Имеет один публичный абстрактный метод DoWork().
    public abstract class Worker
    {
        public abstract string EntityDescriptionMessage { get; }
        public abstract void DoWork();
    }
}