public class Solution {
    public int RomanToInt(string s) {
        IDictionary<char, int> r = new Dictionary<char, int>() {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M' , 1000 }
        };
        
        int accum = 0;
        int p = r[s[0]]; 
        
        foreach(char c in s) {
            if(p <  r[c]) {
                accum -= p;
                accum += (r[c] - p);
            } else {
                accum += r[c]; 
            }
            
            p = r[c];
        }
        
        return accum;
    }
}