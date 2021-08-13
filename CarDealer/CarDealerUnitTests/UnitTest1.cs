using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealer;

namespace CarDealerUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddCarTest()
        {
            //Arrange
            CarManagment Car = new CarManagment();
            Car addedCar = new Car(4, "FGR45G", "German", "Mercedes", 2008, 11000, "fgjh");


            //Act
            Car.AddCar(addedCar);
            Car[] Cars = Car.GetCars();

            //Assert

            Assert.AreEqual(Cars[4].bay, addedCar.bay);

        }
        [TestMethod]
        public void RemoveCarTest()
        {
            //Arrange
            CarManagment Car = new CarManagment();
            Car removeCar = new Car(17, "FGR45G", "German", "Mercedes", 2008, 11000, "fgjh");
            Car.AddCar(removeCar);
            Car[] Cars = Car.GetCars();

            //Act

            Car.RemoveCar(removeCar);

            //Assert
            Assert.AreEqual(null, Cars[removeCar.bay]);


        }
        [TestMethod]
        public void SequentialSearchTest()
        {
            //Arrange
            CarManagment Car = new CarManagment();     
            Car findCar = new Car(18, "FGR45G", "German", "Mercedes", 2008, 11000, "fgjh");
            Car.AddCar(findCar);
            Car[] Cars = Car.GetCars();
            int x = 11000;

            //Act
            
            int result = Car.FindCar(Car.GetCars(), x);

            //Assert
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void BinarySearchTest()
        {
            //Arrange
            CarManagment Car = new CarManagment();
            int[] ArrayForSearch = new int[5] {10000, 20000, 30000, 40000, 50000};
            int x = 40000;
            int n = ArrayForSearch.Length;
            
            
            Array.Sort(ArrayForSearch);

            //Act
            int result = Car.BinarySearch(ArrayForSearch, 0, n - 1, x);

            //Assert
            Assert.AreEqual(3, result);
        }
       


    }
}
