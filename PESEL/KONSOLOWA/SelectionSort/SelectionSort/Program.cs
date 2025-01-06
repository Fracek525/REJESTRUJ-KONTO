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

        /********************************************************
         * nazwa funkcji:       Sort
         * parametry wejściowe: brak
         * wartość zwracana:    brak 
         * autor:               PESEL
         * ****************************************************/

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

        /********************************************************
         * nazwa funkcji:       FindMaxIndex
         * parametry wejściowe: startIndex - indeks początkowy, od którego ma rozpocząć się poszukiwanie
         * wartość zwracana:    int - indeks największego elementu w pozostałej części tablicy
         * autor:               PESEL
         * ****************************************************/

        private void Swap(int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }

        /********************************************************
         * nazwa funkcji:       Swap
         * parametry wejściowe: index1 - pierwszy indeks, index2 - drugi indeks
         * wartość zwracana:    brak
         * autor:               PESEL
         * ****************************************************/

        public int[] GetArray()
        {
            return array;
        }

        /********************************************************
         * nazwa funkcji:       GetArray
         * parametry wejściowe: brak
         * wartość zwracana:    int[] - tablica zawierająca posortowane liczby
         * autor:               PESEL
         * ****************************************************/
    }
}
