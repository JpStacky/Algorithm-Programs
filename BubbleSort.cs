using System;
namespace BubbleSort
{
    class BubbleSort
    {
        public static void Main()
        {
            List<int> list = new List<int>();
            Console.Write("Enter No. of Values to sort = ");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i<num; i++)
                list.Add(Convert.ToInt32(Console.ReadLine()));
            int temp;
            for (int j = 0; j <= num - 2; j++)
            {
                for (int i = 0; i <= num - 2; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        temp = list[i + 1];
                        list[i + 1] = list[i];
                        list[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted:");
            foreach (int ele in list)
                Console.Write(ele + " ");
        }
    }
}