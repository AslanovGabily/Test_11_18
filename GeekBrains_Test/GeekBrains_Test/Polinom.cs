using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Test
{
    public class Polinom
    {
        /// <summary>
        /// Метод для операции "произведение массивов". Сама операция определяется так, что элементы массива - это коэффициенты полинома. 
        ///  Соответственно, произведение массивов - дает новый массив, коэффициенты которого соответсвуют нужному полиному.
        /// </summary>
        /// <param name="firstArray">Целоцисленный массив первый множитель</param>
        /// <param name="secondArray">Целоцисленный массив последний множитель</param>
        /// <returns>произведение массивов</returns>
        public static int[] MultiplyPolinom(int[] firstArray, int[] secondArray)
        {
            int[] answerArray = new int[firstArray.Length + secondArray.Length - 1];
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    int indexRecordOfAnswerArray = i + j;
                    answerArray[indexRecordOfAnswerArray] += firstArray[i] * secondArray[j];
                }
            }
            return answerArray;
        }
    }
}
