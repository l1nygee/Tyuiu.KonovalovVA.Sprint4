using Tyuiu.KonovalovVA.Sprint4.Task2.V2.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] ar = new int[] { 5, 6, 7, 3, 4, 4, 2, 6, 3, 2, 2 };
            int wait = 315;
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}