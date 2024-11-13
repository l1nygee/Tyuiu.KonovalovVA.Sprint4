using Tyuiu.KonovalovVA.Sprint4.Task1.V17.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ar = { 1, 7, 6, 3, 2, 5, 7, 6, 7, 6, 5, 4, 7, 6 };
            int wait = 35;
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}