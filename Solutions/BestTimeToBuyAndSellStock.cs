
namespace Solutions;

public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        var n = prices.Length;
        var mins = new int[n];
        mins[0] = prices[0];
        for (var i = 1; i < n; i++) {
            if (prices[i] < mins[i-1]) {
                mins[i] = prices[i];
            }
            else {
                mins[i] = mins[i - 1];
            }
        }
        return Math.Max(prices.Zip(mins, (max, min) => max - min).Max(), 0);
    }

    public static bool TestMaxProfit() 
    {
        // Arrrange
        var name = "121. Best time to buy and sell Stock";
        var solution = new Solution();
        var nums1 = new int[] {7,1,5,3,6,4};
        var nums2 = new int[] {7,6,4,3,2,1};
        var expected1 = 5;
        var expected2 = 0;
        // Act
        var actual1 = solution.MaxProfit(nums1);
        var actual2 = solution.MaxProfit(nums2);
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