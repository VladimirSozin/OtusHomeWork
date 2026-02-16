using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Маляр. Имеет свой разряд (PainterLevel)
    public class Painter : Builder, IMyCloneable, ICloneable
    {
        private int _painterLevel;

        public Painter(int painterLevel)
        {
            _painterLevel = painterLevel;
        }

        public int PainterLevel => _painterLevel;

        public override string EntityDescriptionMessage => "I'm a painter";

        public object Clone()
        {
            return new Painter(this.PainterLevel);
        }

        public object MyClone()
        {
            return new Painter(this.PainterLevel);
        }

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }
    }
}
