
namespace Solutions;

public partial class Solution
{

    public int ClimbStairs(int n) {

        if (n == 0 || n == 1) 
            return 1;

        var prev1 = 1;
        var prev2 = 1;
        var result = 0;

        for (var i = 2; i <= n; i++) 
        {
            result = prev1 + prev2;
            prev1 = prev2;
            prev2 = result;
        }

        return result;
    }

    public static bool TestClimbStairs() {
        // Arrange
        var name = "Climb Stairs";
        var solution = new Solution();
        var n1 = 2;
        var n2 = 3;
        var expected1 = 2;
        var expected2 = 3;
        // Act
        var actual1 = solution.ClimbStairs(n1);
        var actual2 = solution.ClimbStairs(n2);
        // Accert
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