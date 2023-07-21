
namespace Solutions;

using S = Solutions.Solution;

public partial class Solution
{
    public static bool TestAll() 
        =>  S.TestFindDisappearedNumbers() 
        && S.TestMissingNumber() 
        && S.TestContainsDuplicate();

    public static bool Equals<T>(IList<T> list1, IList<T> list2) 
    {
        if (list1 is null || list2 is null)
            return list1 == list2;

        if (list1.Count != list2.Count)
            return false;

        for (int i = 0; i < list1.Count; i++)
        {
            if (!(list1[i]?.Equals(list2[i]) ?? false))
                return false;
        }

        return true;
    }

}