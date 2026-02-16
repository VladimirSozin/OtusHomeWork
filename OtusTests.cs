using NUnit.Framework;
using Otus.Learning;

namespace Tests
{
    internal class OtusTests
    {
        [Test]
        public void CreateDifferentInstancesOfCraneOperators()
        {
            //Arrange
            //Act
            var firstCraneOperator = new CraneOperator(1);
            var secondCraneOperator = (CraneOperator)firstCraneOperator.Clone();

            //Assert
            Assert.That(firstCraneOperator.GetType() == secondCraneOperator.GetType());
            Assert.That(firstCraneOperator.GetHashCode() != secondCraneOperator.GetHashCode());
            Assert.That(firstCraneOperator.EntityDescriptionMessage, Is.EqualTo(secondCraneOperator.EntityDescriptionMessage));
        }

        [Test]
        public void CreateDifferentInstancesOfElectrician()
        {
            //Arrange
            //Act
            var firstElectrician = new Electrician(1);
            var secondElectrician = (Electrician)firstElectrician.Clone();

            //Assert
            Assert.That(firstElectrician.GetType() == secondElectrician.GetType());
            Assert.That(firstElectrician.GetHashCode() != secondElectrician.GetHashCode());
            Assert.That(secondElectrician.EntityDescriptionMessage, Is.EqualTo(firstElectrician.EntityDescriptionMessage));
        }

        [Test]
        public void CreateDifferentInstancesOfPainter()
        {
            //Arrange
            //Act
            var firstPainter = new Painter(1);
            var secondPainter = (Painter)firstPainter.Clone();

            //Assert
            Assert.That(firstPainter.GetType() == secondPainter.GetType());
            Assert.That(firstPainter.GetHashCode() != secondPainter.GetHashCode());
            Assert.That(firstPainter.EntityDescriptionMessage, Is.EqualTo(secondPainter.EntityDescriptionMessage));
        }

        [Test]
        public void CreateDifferentInstancesOfPlumber()
        {
            //Arrange
            //Act
            var firstPlumber = new Plumber(1);
            var secondPlumber = (Plumber)firstPlumber.Clone();

            //Assert
            Assert.That(firstPlumber.GetType() == secondPlumber.GetType());
            Assert.That(firstPlumber.GetHashCode() != secondPlumber.GetHashCode());
            Assert.That(firstPlumber.EntityDescriptionMessage, Is.EqualTo(secondPlumber.EntityDescriptionMessage));
        }

        [Test]
        public void CreateDifferentInstancesOfTiler()
        {
            //Arrange
            //Act
            var firstTiler = new Tiler(1);
            var secondTiler = (Tiler)firstTiler.Clone();

            //Assert
            Assert.That(firstTiler.GetType() == secondTiler.GetType());
            Assert.That(firstTiler.GetHashCode() != secondTiler.GetHashCode());
            Assert.That(firstTiler.EntityDescriptionMessage, Is.EqualTo(secondTiler.EntityDescriptionMessage));
        }

        [Test]
        public void CreateDifferentInstancesOfTractorDriver()
        {
            //Arrange
            //Act
            var firstTractorDriver = new TractorDriver("E");
            var secondTractorDriver = (TractorDriver)firstTractorDriver.Clone();

            //Assert
            Assert.That(firstTractorDriver.GetType() == secondTractorDriver.GetType());
            Assert.That(firstTractorDriver.GetHashCode() != secondTractorDriver.GetHashCode());
            Assert.That(firstTractorDriver.EntityDescriptionMessage, Is.EqualTo(secondTractorDriver.EntityDescriptionMessage));
        }
    }
}
