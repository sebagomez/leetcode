namespace LeetCode.Sorting
{
	public class Selection
	{
		public static int[] Sort(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				int min = arr[i];
				int minIndex = i;
				for (int j = i+1; j < arr.Length; j++)
				{
					if (arr[j] < min)
					{
						min = arr[j];
						minIndex = j;
					}
				}
				int aux = arr[i];
				arr[i] = arr[minIndex];
				arr[minIndex] = aux;

			}
			return arr;
		}
	}
}
