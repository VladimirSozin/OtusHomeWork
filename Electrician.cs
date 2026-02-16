using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Электрик. Имеет свой разряд (ElectricianLevel)
    public class Electrician : Builder, IMyCloneable, ICloneable
    {
        private int _electricianLevel;

        public Electrician(int electricianLevel)
        {
            _electricianLevel = electricianLevel;
        }

        public int ElectricianLevel => _electricianLevel;

        public override string EntityDescriptionMessage => "I'm an electrician";

        public object MyClone()
        {
            return new Electrician(this.ElectricianLevel);
        }

        public object Clone()
        {
            return new Electrician(this.ElectricianLevel);
        }

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }
    }
}
