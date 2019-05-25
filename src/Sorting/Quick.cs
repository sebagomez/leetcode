namespace LeetCode.Sorting
{
	public class Quick
	{
		public static int[] Sort(int[] arr)
		{
			return QuickSort(arr, 0, arr.Length - 1);
		}

		static int[] QuickSort(int[] arr, int left, int right)
		{
			if (right < left)
				return arr;

			int originalLeft = left;
			int originalRight = right;
			int pivotPos = (left + right) / 2;
			int pivot = arr[pivotPos];
			while (left <= right)
			{
				while (arr[left] < pivot)
					left++;

				while (arr[right] > pivot)
					right--;

				if (left <= right)
				{
					int aux = arr[right];
					arr[right] = arr[left];
					arr[left] = aux;
					left++;
					right--;
				}

			}

			QuickSort(arr, originalLeft, pivotPos);
			QuickSort(arr, pivotPos + 1, originalRight);

			return arr;
		}
	}
}
