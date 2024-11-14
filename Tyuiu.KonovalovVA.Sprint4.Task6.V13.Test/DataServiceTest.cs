using Tyuiu.KonovalovVA.Sprint4.Task6.V13.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 4;
            string[] ar = { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}