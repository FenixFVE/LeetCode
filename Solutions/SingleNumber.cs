
namespace Solutions;

public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        var memory = 0;
        foreach (var num in nums)
            memory ^= num;
        return memory;
   }

    public static bool TestSingleNumber() 
    {
        // Arrange
        var name = "Single Number";
        var solution = new Solution();
        var nums1 = new int[] { 2, 2, 1 };
        var nums2 = new int[] { 4, 1, 2, 1, 2 };
        var nmus3 = new int[] { 1 };
        var expected1 = 1;
        var expected2 = 4;
        var expected3 = 1;
        // Act
        var actual1 = solution.SingleNumber(nums1);
        var actual2 = solution.SingleNumber(nums2);
        var actual3 = solution.SingleNumber(nmus3);
        // Assert
        if (expected1 == actual1 && expected2 == actual2 && expected3 == actual3) 
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