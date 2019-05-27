namespace LeetCode.Sorting
{
	public class Quick
	{
		public static int[] Sort(int[] arr)
		{
			if (arr == null || arr.Length == 0)
				return arr;

			return QuickSort(arr, 0, arr.Length - 1);
		}

		static int[] QuickSort(int[] arr, int left, int right)
		{
			if (left == right)
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
					Swap(arr, left, right);

				left++;
				right--;
			}

			if (pivotPos != originalRight)
				QuickSort(arr, originalLeft, pivotPos);
			if (pivotPos != originalLeft)
				QuickSort(arr, pivotPos, originalRight);

			return arr;
		}

		static void Swap(int[] arr, int a, int b)
		{
			int aux = arr[a];
			arr[a] = arr[b];
			arr[b] = aux;
		}
	}
}
