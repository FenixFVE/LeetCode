
namespace Solutions;

internal class NumArray
{
    private readonly int[] Sums;
    public NumArray(int[] nums) {
        Sums = new int[nums.Length];
        Sums[0] = nums[0];
        for (var i = 1; i < nums.Length; i++)
            Sums[i] = Sums[i - 1] + nums[i];
    }

    public int SumRange(int left, int right) {
        return Sums[right] - (left == 0 ? 0 : Sums[left - 1]);
    }
}

public partial class Solution
{
    public static bool TestNumArray() 
    {
        // Arrange
        var name = "303. Rang sum query-immutable";
        var obj = new NumArray(new int[]{-2,0,3,-5,2,-1});
        var expected1 = 1;
        var expected2 = -1;
        var expected3 = -3;
        // Act
        var actual1 = obj.SumRange(0, 2);
        var actual2 = obj.SumRange(2, 5);
        var actual3 = obj.SumRange(0, 5);
        // Assert
        if (actual1 == expected1 && actual2 == expected2 && actual3 == expected3)
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