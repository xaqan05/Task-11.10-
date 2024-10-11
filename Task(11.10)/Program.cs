namespace Task_11._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3 };
            InsertArray(ref numbers, 4, 5, 6);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        public static void InsertArray(ref int[] array, params int[] values)
        {
            int newSize = array.Length + values.Length;

            int[] newArray = new int[newSize];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = 0; i < values.Length; i++)
            {
                newArray[array.Length + i] = values[i];
            }

            array = newArray;
        }

    }
}
