namespace LeetCode.Searching
{
	public class Binary
	{
		public static int Search(int[] arr, int search)
		{
			return BinarySearch(arr, search, 0, arr.Length - 1);
		}

		static int BinarySearch(int[] arr, int search, int left, int right)
		{
			if (left > right)
				return -1;

			while (right >= left)
			{
				int mid = (left + right) / 2;
				if (arr[mid] == search)
					return mid;

				if (arr[mid] > search)
					right = mid - 1;
				else
					left = mid + 1;
			}

			return -1;
		}

		public static int SearchRecursive(int[] arr, int search)
		{
			return BinarySearchRecursive(arr, search, 0, arr.Length - 1);
		}

		static int BinarySearchRecursive(int[] arr, int search, int left, int right)
		{
			if (left > right)
				return -1;

			int mid = (left + right) / 2;
			if (arr[mid] == search)
				return mid;

			if (arr[mid] > search)
				return BinarySearchRecursive(arr, search, left, mid - 1);
			else
				return BinarySearchRecursive(arr, search, mid + 1, right);
		}
	}
}
