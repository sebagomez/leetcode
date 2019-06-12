namespace LeetCode.Sorting
{
	public class Bubble
	{
		public static int[] Sort(int[] arr)
		{
			int l = arr.Length;
			for (int k = 0; k < l; k++)
			{
				for (int i = 0; i < l- 1; i++)
				{
					if (arr[i] > arr[i + 1])
					{
						int aux = arr[i];
						arr[i] = arr[i + 1];
						arr[i + 1] = aux;
					}
				}
				l--;
			}

			return arr;
		}
	}
}
