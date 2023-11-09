using WpfLab2.Lab3;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMagazineCalculatePrice()
        {
            Magazine magazine = new Magazine("Magazine Name",1000,2.5);

            double expectedPrice = 1000 * 2.5;
            Assert.AreEqual(expectedPrice, magazine.CalculatePrice());
        }

        [TestMethod]
        public void TestNewspaperCalculatePrice()
        {
            Newspaper newspaper = new Newspaper("Newspaper Name", 20, 0.1, 5000);

            double expectedPrice = 20 * 0.1 * 5000;
            Assert.AreEqual(expectedPrice, newspaper.CalculatePrice());
        }

        [TestMethod]
        public void CreateNewspaperNegativeData()
        {
            Assert.ThrowsException<Exception>(() => new Newspaper("Newspaper Name", 20, -2, 5000));
            Assert.ThrowsException<Exception>(() => new Newspaper("Newspaper Name", -20, 2, 5000));
            Assert.ThrowsException<Exception>(() => new Newspaper("Newspaper Name", 20, 2, -5000));
        }



        [TestMethod]
        public void CreateMagazineNegativeData()
        {
            Assert.ThrowsException<Exception>(() => new Magazine("Magazine Name", -1000, -2.5));
            Assert.ThrowsException<Exception>(() => new Magazine("Magazine Name", -1000, 2.5));
            Assert.ThrowsException<Exception>(() => new Magazine("Magazine Name", 1000, -2.5));
        }
    }
}