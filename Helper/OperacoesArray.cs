using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_LINQ_Fundamentals_DIO.Helper
{
    internal class OperacoesArray
    {
        public void DoBubbleSort(ref int[] array) 
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }

            }
        }

        public string[] ConvertIntoStringArray(int[] array) 
        {
           return Array.ConvertAll(array, element => element.ToString());
        }

        public void ResizeArray(ref int[] array, int NewSize) 
        {
            Array.Resize(ref array, NewSize);
        }

        public int GetIndexOf(int[] array, int valor) 
        {
            return Array.IndexOf(array, valor);
        }

        public int GetIndex(int[] array, int valor)
        {
            return Array.FindIndex(array, elemento => elemento < valor);
        }

        public int GetValue(int[] array, int valor) 
        {
            return Array.Find(array, elemento => elemento == valor);
        }

        public bool DoesItExist(int[] array, int valor) 
        {
            return Array.Exists(array, elemento => elemento == valor);
        }

        public bool AllGreaterThan(int[] array, int valor)
        {
            //return Array.Exists(array, elemento => elemento == valor);
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public void ToCopyArray(ref int[] SourceArray, ref int[] DestinationArray) 
        {
            Array.Copy(SourceArray,DestinationArray, SourceArray.Length);
        }

        public void Ordernar(ref int[] array) 
        {
            Array.Sort(array);
        }
        public void ImprimirArray(int[] array) 
        {
            var row = "[" + string.Join("]-[", array) + "]";
            Console.WriteLine(row);
            //for (int i = 0; i < array.Length; i++)
            //{
                
            //}
        
        }

        
    }
}
