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
            var vehicle = new Vehicle("Toyota Corola", 2022, 50000);
            var result = vehicle.GetModel();
            Assert.That(result, Is.EqualTo("Toyota Corola"));
        }

        [Test]
        public void TestYear_ValidInput_ReturnsCorrectYear()
        {
            var vehicle = new Vehicle("Honda Civic", 2022, 30000);
            var result = vehicle.GetYear();
            Assert.That(result, Is.EqualTo(2022));
        }

        [Test]
        public void TestKilometers_ValidInput_ReturnsCorrectKilometers()
        {
            var vehicle = new Vehicle("Ford Explorer", 2022, 75000);
            var result = vehicle.GetKilometers();
            Assert.That(result, Is.EqualTo(75000));
        }

        [Test]
        public void TestModel_MaxLength_DoesNotExceedLimit()
        {
            var vehicle = new Vehicle("Ford Forunner", 2022, 10000);
            var result = vehicle.GetModel();
            Assert.That(result.Length, Is.LessThanOrEqualTo(15));
        }

        [Test]
        public void TestYear_ValidRange_IsWithinBounds()
        {
            var vehicle = new Vehicle("Hundai Elantra", 2022, 5000);
            var result = vehicle.GetYear();
            Assert.That(result, Is.InRange(1990, 2025));
        }

        
    }
}
