 using System;
 using System.Collections.Generic;
 class Solution{
    public boolean Isanagram(string s,string t){
        if(s.Length!=t.Length){
            return false;
        }
        int[] count=new int[26];
        for(int i=0;i<s.Length;i++){
            count[s.Substring(i,1).ToCharArray()[0]-'a']++;
            count[t.Substring(i,1).ToCharArray()[0]-'a']--;
        }
        foreach(int item in count){
            if(item!=0) return false;
        }

        return true;
    }
}