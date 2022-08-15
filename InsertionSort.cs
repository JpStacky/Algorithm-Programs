using System;

class InsertionSort
{
	void Sort(string[] word)
	{
		int n = word.Length;
		for (int i = 1; i < n; ++i)
		{
			string key = word[i];
			int j = i - 1;

			while (j >= 0 && word[j].CompareTo(key) > 0)
			{
				word[j + 1] = word[j];
				j = j - 1;
			}
			word[j + 1] = key;
		}
	}

	static void DisplaySorted(string[] word)
	{
		int n = word.Length;
		for (int i = 0; i < n; ++i)
			Console.WriteLine(word[i] + " ");
	}
	public static void Main()
	{
		Console.Write("Enter No. of Words = ");
		int n = Convert.ToInt32(Console.ReadLine());
		string[] word = new string[n];
		for (int i = 0; i < n; i++)
		{
			Console.Write("Enter Word No. "+(i+1)+" = ");
			word[i] = Console.ReadLine();
		}
		InsertionSort insertionSort = new InsertionSort();
		insertionSort.Sort(word);
		DisplaySorted(word);
	}
}