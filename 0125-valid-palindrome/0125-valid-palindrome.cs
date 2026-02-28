    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            //condition the string
            s = s.ToLower();
            List<char> Conditioned = new();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] >= 97 && s[i] <= 122) || (s[i] >= 48 && s[i] <= 57))
                    Conditioned.Add(s[i]);
            }


            for (int i = 0, j = Conditioned.Count - 1; i < j; i++, j--)
            {
                if (Conditioned[i] != Conditioned[j])
                    return false;
            }

            return true;
        }
    }