public class Solution {
    public int CountBinarySubstrings(string s) {
        int Count1 = 0, Count0 = 0, sum = 0;
       int IncrementFlag = 0;
       //initial element
       if (s[0] == '1') { Count1++; IncrementFlag = 1; }
       else { Count0++; IncrementFlag = 0; };

       for (int i = 1; i < s.Length; i++)
       {
           if (s[i] == '1') { Count1++; IncrementFlag = 1; }
           else { Count0++; IncrementFlag = 0; }

           if (s[i] == s[i - 1])
           {
               // if the new element is the same as prev and count of it is less than or equal the other count then also increment
               if (IncrementFlag == 0) // means i incremented 0
               {
                   if (Count0 <= Count1) sum++;
               }
               else
                   if (Count1 <= Count0) sum++;
           }
           else
           {   // if the no is diff start counting it from start
               sum++;
               if (s[i] == '1' ) Count1 = 1;
               else Count0 = 1;
           }

       }
       return sum;
}
}