using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains_Test
{
    /// <summary>
    /// Класс для копирование массивов в новый массив
    /// </summary>
    public static class CopyArray
    {
        /// <summary>
        /// В этом методе мы переписываем данные старого массива ,
        /// в новый массив путем создания нового массива и переписывания данный проходясь по принятому массиву
        /// </summary>
        /// <typeparam name="T">Тип принятого и возвращаемого массива</typeparam>
        /// <param name="oldArray">Массив любого типа , который мы должны переписать</param>
        /// <returns>массив с новым адрессом и данными из принятого массива</returns>
        public static T[] RewriteArray<T>(T[] oldArray)
        {
            var arr = new T[oldArray.Length];

            for (var i = 0; i < oldArray.Length; i++)
            {
                arr[i] = oldArray[i];
            }

            return arr;
        }

        /// <summary>
        /// В этом методе мы переписываем данные старого массива ,
        /// в новый массив путем создания нового массива и  использовния базовой реализации
        /// </summary>
        /// <typeparam name="T">Тип принятого и возвращаемого массива</typeparam>
        /// <param name="originalArray">Массив любого типа , который мы должны переписать</param>
        /// <returns>массив с новым адрессом и данными из принятого массива </returns>
        public static T[] UsingBaseImplementation<T>(T[] oldArray)
        {
            var arr = new T[oldArray.Length];

            Array.Copy(oldArray, 0, arr, 0, oldArray.Length);

            return arr;
        }
    }
}
