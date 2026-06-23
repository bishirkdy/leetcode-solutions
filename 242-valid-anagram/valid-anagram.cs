public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length != t.Length){
        return false;
       }
       
       Dictionary<char , int> count = new Dictionary<char , int>();
        foreach(char ch in s)
        {
            count[ch] = count.GetValueOrDefault(ch , 0 ) + 1;
        }
        foreach(char ch in t)
        {
            if(!count.ContainsKey(ch) || count[ch] == 0){
                return false;
            }
           

            count[ch]--;
        }
        return true;
    }
}