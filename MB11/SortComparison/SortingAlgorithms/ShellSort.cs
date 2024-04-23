namespace MB11.SortComparison.SortingAlgorithms
{
    public class ShellSort : SortAlgorithm
    {
        public override string Name => "Shell Sort";

        public override void Sort(IList<int> arrayToSort)
        {
            int arraySize = arrayToSort.Count(); // Größe des Arrays
            int gap = 1; // Anfangsabstand für den Shell-Sort

            // Berechnung der Abstandsfolge
            while (gap < arraySize / 3)
            {
                gap = gap * 3 + 1;
            }

            // Shell-Sort Algorithmus
            while (gap > 0)
            {
                for (int i = gap; i < arraySize; i++)
                {
                    int temp = arrayToSort[i]; // Aktuelles Element speichern
                    int j = i;

                    // Verschiebe Elemente um den Abstand 'gap', falls sie größer sind als 'temp'
                    while (j >= gap && arrayToSort[j - gap] > temp)
                    {
                        arrayToSort[j] = arrayToSort[j - gap];
                        j -= gap;
                    }

                    arrayToSort[j] = temp; // Speichere 'temp' an der richtigen Position
                }

                gap /= 3; // Reduziere den Abstand
            }
        }

    }
}
