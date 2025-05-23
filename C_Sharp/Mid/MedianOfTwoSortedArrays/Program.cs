public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        int[] sorted = new int[nums1.Length + nums2.Length];
        int indexOne = 0, indexTwo = 0, indexSorted = 0;

        while (indexOne < nums1.Length && indexTwo < nums2.Length)
        {
            if (nums1[indexOne] <= nums2[indexTwo])
            {
                sorted[indexSorted++] = nums1[indexOne++];
            }
            else
            {
                sorted[indexSorted++] = nums2[indexTwo++];
            }
        }

        while (indexOne < nums1.Length)
        {
            sorted[indexSorted++] = nums1[indexOne++];
        }

        while (indexTwo < nums2.Length)
        {
            sorted[indexSorted++] = nums2[indexTwo++];
        }

        int totalLength = sorted.Length;
        if (totalLength % 2 == 0)
        {
            return (sorted[totalLength / 2 - 1] + sorted[totalLength / 2]) / 2.0;
        }

        return sorted[totalLength / 2];
    }
}

class Program
{
    static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.FindMedianSortedArrays([1, 2, 5], [3, 4, 17]));
    }
}