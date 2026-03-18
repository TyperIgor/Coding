
namespace TuringCodeChallenge
{
    internal static class MergeSortImplementation
    {


        public static void Execute(int[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(int[] array, int firstIndex, int lastIndex)
        {
            if (ValidateSortParameters(array, firstIndex, lastIndex))
            {
                int middle = ((firstIndex + lastIndex) / 2);

                Sort(array, firstIndex, middle); // array divido para esquerda
                Sort(array, middle + 1, lastIndex); // array divido para direita
                Merge(array, firstIndex, middle, lastIndex);
            }

        }

        private static bool ValidateSortParameters(int[] array, int firstIndex, int lastIndex)
        {
            return array is not null && firstIndex < lastIndex && firstIndex >= 0
                 && lastIndex < array.Length && array.Length != 0;
        }

        private static void Merge(int[] array, int firstIndex, int middle, int lastIndex)
        {
            int[] aux = new int[array.Length];
            Array.Copy(array, aux, array.Length);

            int i = firstIndex;
            int j = middle + 1;
            int k = firstIndex;

            while (i <= middle && j <= lastIndex)
            {
                if (aux[i] < aux[j])
                {
                    array[k] = aux[i];
                    i++;
                }
                else
                {
                    array[k] = aux[j];
                    j++;
                }
                k++;
            }


            while (i <= middle)
            {
                array[k] = aux[i];
                i++;
                k++;
            }


            while (j <= lastIndex)
            {
                array[k] = aux[j];
                j++;
                k++;
            }
        }
    }
}
