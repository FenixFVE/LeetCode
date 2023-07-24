
namespace Solutions;

public partial class Solution
{
    public int[] CountBits(int n) 
    {
        var ans = new int[n + 1];
        for (var i = 1; i <= n; i *= 2)
        {
            for (int j = i, p = 0; j < 2 * i && j <= n; j++, p++)
            {
                ans[j] = ans[p] + 1;
            }
        }
        return ans;
    }

    public static bool TestCountBits() 
    {
        // Arrange
        var name = "338. Counting Bits";
        var solution = new Solution();
        var num1 = 2;
        var num2 = 5;
        var expected1 = new int[] {0,1,1};
        var expected2 = new int[] {0,1,1,2,1,2};
        // Act
        var actual1 = solution.CountBits(num1);
        var actual2 = solution.CountBits(num2);
        // Assert
        if (actual1.SequenceEqual(expected1) && actual2.SequenceEqual(expected2)) 
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