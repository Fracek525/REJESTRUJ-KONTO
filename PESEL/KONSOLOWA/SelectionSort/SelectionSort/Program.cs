using System.Windows;


namespace Konsola
{

    class Tablica
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadź 10 liczb całkowitych oddzielonych spacjami: ");
            int[] array = new int[10];

            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');

            for (int i = 0; i < 10; i++)
            {
                array[i] = int.Parse(inputArray[i]);
            }

            ArrayHandler arrayHandler = new ArrayHandler(array);

            arrayHandler.Sort();

            Console.WriteLine("Posortowana tablica (malejąco):");
            foreach (var num in arrayHandler.GetArray())
            {
                Console.Write(num + " ");
            }
        }
    }

    class ArrayHandler
    {
        private int[] array;

        public ArrayHandler(int[] inputArray)
        {
            array = inputArray;
        }

        public void Sort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = FindMaxIndex(i);

                Swap(i, maxIndex);
            }
        }

        private int FindMaxIndex(int startIndex)
        {
            int maxIndex = startIndex;

            for (int i = startIndex + 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            return maxIndex;
        }

        private void Swap(int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        public int[] GetArray()
        {
            return array;
        }
    }
}
