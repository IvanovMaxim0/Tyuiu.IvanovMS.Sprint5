using Tyuiu.IvanovMS.Sprint5.Task5.V17.Lib;

namespace Tyuiu.IvanovMS.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\colla\source\repos\Tyuiu.IvanovMS.Sprint5\Tyuiu.IvanovMS.Sprint5.Task5.V17\bin\Debug\net8.0\InPutFileTask5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
