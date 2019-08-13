using System.Collections.Generic;

namespace LeetCode
{
    public class MicrosoftLongestPalindrome
    {
        public static string LongestPalindrome(string text)
        {
            Dictionary<int, int> p = new Dictionary<int, int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (i == 0 || i == text.Length - 1)
                {
                    p[i] = 1;
                    continue;
                }

                int k = 0;
                for (int j = 1; j <= i; j++)
                {
                    k++;
                    int left = i - j;
                    int right = i + k;
                    if (left < 0 || right > text.Length - 1)
                        break;

                    char a = text[left];
                    char b = text[right];
                    if (a != b)
                    {
                        if (text[i] == b)
                            j--;
                        else
                            break;
                    }
                    else
                    {
                        p[left] = (right - left) + 1;

                    }
                }
            }


            int max = 0;
            int index = -1;
            foreach (int k in p.Keys)
            {
                if (p[k] > max)
                {
                    max = p[k];
                    index = k;
                }
            }

            return text.Substring(index, max);
        }

        public static bool IsPalindrome(string text)
        {
            int m = 0;
            int n = text.Length - 1;
            while (m < n)
            {
                if (text[m] != text[n])
                    return false;
                m++;
                n--;
            }
            return true;
        }
    }
}
