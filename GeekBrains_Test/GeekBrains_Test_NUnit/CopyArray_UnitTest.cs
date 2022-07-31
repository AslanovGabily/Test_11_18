using GeekBrains_Test;
using System.Threading.Tasks;

namespace GeekBrains_Test_NUnit
{
    public class CopyArray_UnitTest
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 2, 4, 6, 45, 456, 234, 13 })]
        public void RewriteArray_Success(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(new char[] { 'q', 'w', 'e', 'r', 't', 'y' })]
        public void RewriteArray_Success(char[] arr)
        {
            // ARRANGE
            char[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(new double[] { 2.5, 4.04, 6.6, 4.95, 45.06, 2.034, 1.3 })]
        public void RewriteArray_Success(double[] arr)
        {
            // ARRANGE
            double[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(null)]
        public void RewriteArray_Failure(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;

            // ASSERT
            Assert.Throws<NullReferenceException>(() =>
            {
                CopyArray.RewriteArray(arr);
            });
        }

        [Test]        
        [TestCase(new int[] { 2, 4, 6, 45, 456, 234, 13 })]
        public void UsingBaseImplementation_Success(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(new double[] { 2.5, 4.04, 6.6, 4.95, 45.06, 2.034, 1.3 })]
        public void UsingBaseImplementation_Success(double[] arr)
        {
            // ARRANGE
            double[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

        [Test]
        [TestCase(new char[] { 'q', 'w', 'e', 'r', 't', 'y' })]
        public void UsingBaseImplementation_Success(char[] arr)
        {
            // ARRANGE
            char[] copiedArr;


            // ACT
            copiedArr = CopyArray.RewriteArray(arr);


            // ASSERT
            Assert.IsTrue(copiedArr.SequenceEqual(arr));
        }

       

        [Test]
        [TestCase(null)]
        public void UsingBaseImplementation_Failure(int[] arr)
        {
            // ARRANGE
            int[] copiedArr;

            // ASSERT
            Assert.Throws<NullReferenceException>(() =>
            {
                CopyArray.UsingBaseImplementation(arr);
            });
        }
    }
}