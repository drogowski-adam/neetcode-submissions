public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> stack = new();

        foreach(char c in s){
            if(c == '{' || c == '(' || c == '['){
                stack.Push(c);
            }
            else{
                if(stack.Count == 0) return false;

                if(c == ')' && stack.Pop() == '(') continue;
                else if(c == '}' && stack.Pop() == '{') continue;
                else if(c == ']' && stack.Pop() == '[') continue;
                else{
                    return false;
                }
            }
        }
        if(stack.Count != 0) return false;
        return true;
    }
}
