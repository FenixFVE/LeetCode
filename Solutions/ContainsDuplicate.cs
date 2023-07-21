
namespace Solutions;

public class Solution 
{
    public bool ContainsDuplicate(int[] nums) {
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
}
