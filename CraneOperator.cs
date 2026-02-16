using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Крановщик (оператор крана)
    public class CraneOperator : TechnicalSpecialist, IMyCloneable, ICloneable
    {
        private int _experienceYears;

        public CraneOperator(int experienceYears)
        {
            _experienceYears = experienceYears;
        }

        public int ExperienceYears => _experienceYears;

        public override string EntityDescriptionMessage => "I'm a crane operator";

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }

        public object MyClone()
        {
            return new CraneOperator(this.ExperienceYears);
        }

        public object Clone()
        {
            return new CraneOperator(this.ExperienceYears);
        }
    }
}
