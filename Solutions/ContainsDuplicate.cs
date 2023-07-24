
namespace Solutions;

public partial class Solution 
{
    public bool ContainsDuplicate(int[] nums) 
    {
        var memory = new HashSet<int>();

        foreach (var num in nums) 
        {
            if (memory.Contains(num)) 
            {
                return true;
            }
            else
            {
                memory.Add(num);
            }
        }

        return false;
    }

    public static bool TestContainsDuplicate() 
    {
        // Arrange
        var name = "Contais duplicate";
        var solution = new Solution();
        var numbers1 = new int[] { 1, 2, 3 };
        var numbers2 = new int[] { 1, 2, 3, 1 };
        var expected1 = false;
        var expected2 = true;
        // Act
        var actual1 = solution.ContainsDuplicate(numbers1);
        var actual2 = solution.ContainsDuplicate(numbers2);
        // Assert
        if (expected1 == actual1 && expected2 == actual2) 
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
