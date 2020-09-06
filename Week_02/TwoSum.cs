 using System;
 using System.Collections.Generic;

 class Solution{
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> dic =new Dictionary<int, int>();
        for(int i=0;i<nums.Length;i++){
            int theOther=target-nums[i];
            if(dic.ContainsKey(theOther)){
                return new int[2]{i,dic[theOther]};
            }
            if(dic.ContainsKey(nums[i])){
                 dic[nums[i]]=i;
            }else{
                 dic.Add(nums[i],i);
            }
        }

        return new int[0];
    }
 }
