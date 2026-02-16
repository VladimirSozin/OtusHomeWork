using Otus.Learning.Interfaces;

namespace Otus.Learning
{
    //Тракторист. Имеет категорию ТС, которыми он может управлять (DriveLicenseCategory)
    public class TractorDriver : TechnicalSpecialist, IMyCloneable, ICloneable
    {
        private string _driverLicenseCategory;

        public TractorDriver(string driverLicenseCategory)
        {
            _driverLicenseCategory = driverLicenseCategory;
        }

        public string DriverLicenseCategory => _driverLicenseCategory;

        public override string EntityDescriptionMessage => "I'm a tractor driver";

        public object MyClone()
        {
            return new TractorDriver(this.DriverLicenseCategory);
        }

        public object Clone()
        {
            return new TractorDriver(this.DriverLicenseCategory);
        }

        public override void DoWork()
        {
            //Do some specific work
            Console.WriteLine(this.EntityDescriptionMessage);
        }
    }
}
