using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Отделочник. Имеет свой разряд (PlumberLevel)
    public class Plumber : Builder, IMyCloneable, ICloneable
    {
        private int _plumberLevel;

        public Plumber(int plumberLevel)
        {
            _plumberLevel = plumberLevel;
        }

        public int PlumberLevel => _plumberLevel;

        public override string EntityDescriptionMessage => "I'm a plumber";

        public object MyClone()
        {
            return new Plumber(this.PlumberLevel);
        }

        public object Clone()
        {
            return new Plumber(this.PlumberLevel);
        }

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }
    }
}
