public class Solution {
    public bool IsValid(string s) {
        //loop on every element
        // if opening bracket add to stack if closing pop
        // if diff kind of bracket return false
        Stack<char> myStack = new Stack<char>();
        myStack.Push('T'); //push initial character to avoid stack empty exception
        for(int i =0;i<s.Length;i++)
        {
            if(s[i] == '(' || s[i] == '{' || s[i] == '[' )
                myStack.Push(s[i]);//push to stack
            else if(s[i] == ')' && myStack.Peek() == '(')
                myStack.Pop();
            else if(s[i] == '}' && myStack.Peek() == '{')
                myStack.Pop();
            else if(s[i] == ']' && myStack.Peek() == '[')
                myStack.Pop();
            else
                return false;
        }

        if(myStack.Count == 1)
            return true;
            else
            return false;
    }
}