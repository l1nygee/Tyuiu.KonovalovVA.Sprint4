using Tyuiu.KonovalovVA.Sprint4.Task0.V3.Lib;
namespace Tyuiu.KonovalovVA.Sprint4.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int wait = 945;
            int[] ar = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };
            int res = ds.GetMultOddArrEl(ar);
            Assert.AreEqual(wait, res);
        }
    }
}