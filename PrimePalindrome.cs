namespace AlgorithmProblems
{
    public class PrimePalindrome
    {
        public static void Main()
        {
            Console.WriteLine("Prime Numbers Between 1 to 1000 are : ");
            for (int i = 2; i <= 1000; i++)
            {
                int count = 0;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 0)
                {
                    Console.WriteLine(i);
                    CheckPalindrome(i);
                }
            }
        }
        static void CheckPalindrome(int num)
        {
            int temp = num;
            int revNum = 0;
            while (temp != 0)
            {
                int digit = temp % 10;
                revNum = (revNum * 10) + digit;
            }
            if (revNum == num)
                Console.WriteLine("Number "+num+" is also Palindrome");
        }
    }
}
