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
            int[] ar = new int[] { 5, 1, 4, 1, 5, 1, 7, 1, 4, 1, 11 };
            int wait = 1;
            int res = ds.Calculate(ar);
            Assert.AreEqual(wait, res);
        }
    }
}