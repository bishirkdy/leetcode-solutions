public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int , int> map = new Dictionary<int , int>();
        for(int i = 0 ; i < nums.Length ; i++)
        {
           int exiting = target - nums[i];
           if(map.ContainsKey(exiting))
           {
            return new int[] {map[exiting] , i};
           }
           map[nums[i]] = i;
        }
        return new int[] {};
    }
}