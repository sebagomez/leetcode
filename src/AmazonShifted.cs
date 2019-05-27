namespace LeetCode
{
	public class AmazonShifted
	{
		public static int SiftedN(int[] arr)
		{
			if (arr == null || arr.Length == 0)
				return -1;

			for (int i = 1; i < arr.Length; i++)
			{
				if (arr[i] < arr[i-1])
					return i;
			}
			return 0;
		}

		public static int SiftedLogN(int[] arr)
		{
			if (arr == null || arr.Length == 0)
				return -1;

			return BinarySearchMin(arr, 0, arr.Length - 1);
		}

		static int BinarySearchMin(int[] arr, int left, int right)
		{
			if (arr[left] < arr[right])
				return left;

			while (left < right)
			{
				int mid = (left + right) / 2;
				if (arr[mid] <= arr[left])
					right = mid;
				if (arr[mid] > arr[right])
					left = mid;
			}

			return left + 1;
		}

	}
}
