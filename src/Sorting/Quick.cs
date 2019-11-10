using System;

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
			if (right < left)
				return arr;

			int pivot = FindPivot(arr, left, right); //<-- I'm choosing the last item

			QuickSort(arr, left, pivot - 1);
			QuickSort(arr, pivot + 1, right);


			return arr;
		}

		private static int FindPivot(int[] arr, int left, int right)
		{
			int last = left;
			for (int i = left; i < right; i++)
			{
				if (arr[i] <= arr[right])
				{
					Swap(arr, i, last);
					last++;
				}
			}

			Swap(arr, right, last);

			return last;
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
			if (a == b)
				return;

			int aux = arr[a];
			arr[a] = arr[b];
			arr[b] = aux;
		}
	}
}
