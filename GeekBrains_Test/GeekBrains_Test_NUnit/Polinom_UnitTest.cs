using GeekBrains_Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Test_NUnit
{
    internal class Polinom_UnitTest
    {
        [Test]
        [TestCase(new int[] { -1, 1 }, new int[] { 2, 1 }, new int[] { -2, 1, 1 })]
        public void MultiplyPolinom_Success(int[] firstArray, int[] secondArray, int[] answerArray)
        {         
            var multipliedPolynom = Polinom.MultiplyPolinom(firstArray, secondArray);

            CollectionAssert.AreEqual(answerArray, multipliedPolynom);
        }
    }
}
