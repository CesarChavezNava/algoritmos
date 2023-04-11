public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string prefix = "";
        foreach(char c in strs[0].ToCharArray()) {
            prefix += c;
            for(int i = 1; i < strs.Length; i++) {
                if(!strs[i].StartsWith(prefix)) {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    return prefix;
                }
            }
        }
        
        return prefix;
    }
}