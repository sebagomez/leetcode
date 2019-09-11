namespace LeetCode.Sorting
{
	public class Quick
	{
		public static int[] Sort(int[] arr)
		{
			if (arr == null || arr.Length == 0)
				return arr;

			return QuickSort(arr, 0, arr.Length - 1);
			//return Lomuto(arr, 0, arr.Length - 1);
			//return Hoare(arr, 0, arr.Length - 1);
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

		static int[] Lomuto(int[] arr, int left, int right)
		{
			if (left >= right)
				return arr;

			int p = PartitionLomuto(arr, left, right);
			Lomuto(arr, left, p - 1);
			Lomuto(arr, p + 1, right);

			return arr;
		}

		static int PartitionLomuto(int[] arr, int left, int right)
		{
			int pivot = arr[right];
			int i = left;
			for (int j = left; j <= right; j++)
			{
				if (arr[j] < pivot)
				{
					Swap(arr, i, j);
					i++;
				}
			}
			Swap(arr, i, right);
			return i;
		}

		static int[] Hoare(int[] arr, int left, int right)
		{
			if (left >= right)
				return arr;

			int p = PartitionHoare(arr, left, right);
			Hoare(arr, left, p);
			Hoare(arr, p + 1, right);

			return arr;
		}

		static int PartitionHoare(int[] arr, int left, int right)
		{
			int pivot = arr[left + (right - left) / 2];
			int i = left - 1;
			int j = right + 1;
			while (true)
			{
				do
				{
					i++;
				} while (arr[i] < pivot);

				do
				{
					j--;
				} while (arr[j] > pivot);

				if (i >= j)
					return j;

				Swap(arr, i, j);
			}
		}


		static void Swap(int[] arr, int a, int b)
		{
			int aux = arr[a];
			arr[a] = arr[b];
			arr[b] = aux;
		}
	}
}
