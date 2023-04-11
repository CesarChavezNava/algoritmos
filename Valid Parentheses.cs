public class Solution {
    public bool IsValid(string s) {
        if(s.Length <= 1)
            return false;
        
        char[] a = new char[] { '(', '[', '{' };
        Stack<char> stack = new Stack<char>();
        for(int i = 0; i < s.Length; i++) {   
            if(a.Contains(s[i])) {
                stack.Push(s[i]);
            } else {
                if(stack.Count == 0)
                    return false;
                
                if(s[i] == ')' && stack.Peek() != '(')
                    return false;
                if(s[i] == ']' && stack.Peek() != '[')
                    return false;
                if(s[i] == '}' && stack.Peek() != '{')
                    return false;
                
                stack.Pop();
            }
        }
        
        if(stack.Any())
            return false;
        
        return true;
    }
}