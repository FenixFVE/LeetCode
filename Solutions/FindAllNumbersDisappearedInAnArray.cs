
namespace Solutions;

public partial class Solution
{
    public IList<int> FindDisappearedNumbers(int[] nums)
    {
        var memory = new HashSet<int>(nums);
        var result = new List<int>(nums.Length);
        for (int i = 1; i <= nums.Length; i++)
        {
            if (!memory.Contains(i))
            {
                result.Add(i);
            }
        }
        return result;
    }

    public static bool TestFindDisappearedNumbers() 
    {
        // Arrange
        var name = "Find Disappeared Numbers";
        var solution = new Solution();
        var nums1 = new int[] {4,3,2,7,8,2,3,1};
        var nums2 = new int[] {1,1};
        var expected1 = new List<int> {5,6};
        var expected2 = new List<int> {2};
        // Act
        var actual1 = solution.FindDisappearedNumbers(nums1);
        var actual2 = solution.FindDisappearedNumbers(nums2);
        // Assert
        if (expected1.SequenceEqual(actual1) && expected2.SequenceEqual(actual2))
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