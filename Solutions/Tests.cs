
namespace Solutions;

using S = Solutions.Solution;

public partial class Solution
{
    public static bool TestAll() 
        =>  S.TestFindDisappearedNumbers() 
        && S.TestMissingNumber() 
        && S.TestContainsDuplicate()
        && S.TestSingleNumber();

}