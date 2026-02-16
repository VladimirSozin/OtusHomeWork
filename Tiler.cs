using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Плиточник. Имеет свой разряд (TilerLevel)
    public class Tiler : Builder, IMyCloneable, ICloneable
    {
        private int _tilerLevel;

        public Tiler(int tilerLevel)
        {
            _tilerLevel = tilerLevel;
        }

        public int TilerLevel => _tilerLevel;

        public override string EntityDescriptionMessage => "I'm a tiler";

        public object MyClone()
        {
            return new Tiler(this.TilerLevel);
        }

        public object Clone()
        {
            return new Tiler(this.TilerLevel);
        }

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }
    }
}
