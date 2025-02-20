using NUnit.Framework;
using VehicleMaintenanceForm;

namespace VehicleMaintenanceFormTests
{
    [TestFixture]
    public class VehicleTests
    {
        [Test]
        public void TestModel_ValidInput_ReturnsCorrectModel()
        {
            var vehicle = new Vehicle("Toyota Corola", 2022, 42265);
            var result = vehicle.GetModel();
            Assert.That(result, Is.EqualTo("Toyota Corola"));
        }

        [Test]
        public void TestYear_ValidInput_ReturnsCorrectYear()
        {
            var vehicle = new Vehicle("Honda Civic", 2022, 98235);
            var result = vehicle.GetYear();
            Assert.That(result, Is.EqualTo(2022));
        }

        [Test]
        public void TestKilometers_ValidInput_ReturnsCorrectKilometers()
        {
            var vehicle = new Vehicle("Ford Explorer", 2022, 51899);
            var result = vehicle.GetKilometers();
            Assert.That(result, Is.EqualTo(51899));
        }

        [Test]
        public void TestModel_MaxLength_DoesNotExceedLimit()
        {
            var vehicle = new Vehicle("Ford Forunner", 2022, 25025);
            var result = vehicle.GetModel();
            Assert.That(result.Length, Is.LessThanOrEqualTo(15));
        }
    }
}
