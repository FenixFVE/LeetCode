
namespace Solutions;

public partial class Solution
{
    public int MissingNumber(int[] nums)
    {
        var n = nums.Length;
        return n * (n + 1) / 2 - nums.Sum();
    }

    public static bool TestMissingNumber()
    {
        // Arrange
        var name = "Missing number";
        var solution = new Solution();
        var nums1 = new int[] { 3, 0, 1 };
        var nums2 = new int[] { 9, 6, 4, 2 , 3, 5, 7, 0, 1 };
        var expected1 = 2;
        var expected2 = 8;
        // Act
        var actual1 = solution.MissingNumber(nums1);
        var actual2 = solution.MissingNumber(nums2);
        // Assert
        if (actual1 == expected1 && actual2 == expected2)
        {
            Console.WriteLine(name + ": OK");
            return true;
        }
        else
        {
            Console.WriteLine(name + ": Err");
            return false;
        }
    }
}