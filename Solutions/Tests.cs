
namespace Solutions;

using S = Solutions.Solution;

public partial class Solution
{
    public static bool TestAll() 
        =>  S.TestFindDisappearedNumbers() 
        && S.TestMissingNumber() 
        && S.TestContainsDuplicate()
        && S.TestSingleNumber()
        && S.TestClimbStairs()
        && S.TestMaxProfit()
        && S.TestNumArray()
        && S.TestCountBits();

    public static void PrintList<T>(IEnumerable<T> list) {
        foreach (T item in list) {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}