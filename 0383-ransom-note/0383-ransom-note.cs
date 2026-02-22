    public class Solution
    {
        public  bool CanConstruct(string ransomNote, string magazine)
        {
            bool successflag = true;
            for (int i = 0; i < ransomNote.Length; i++)
            {
                //if magazine is finished then return false
                if (magazine.Length == 0)
                    return false;

                //loop on each letter in magazine, if found clear and continue
                for (int j = 0; j < magazine.Length; j++)
                {
                    if (ransomNote[i] == magazine[j])
                    {
                        magazine = magazine.Remove(j, 1);
                        successflag = true;
                        break;
                    }
                    else
                        successflag = false;
                }
                if (successflag == false)
                    return successflag;
            }
            return successflag;
        }
    }