namespace NeetcodeTraining.Solutions;

public static class ValidAnagram
{
    public static bool IsAnagram(string s, string t)
    {
        var sLen = s.Length;
        var tLen = t.Length;

        if (sLen != tLen)
        {
            return false;
        }

        Dictionary<char, int> sValues = new();
        Dictionary<char, int> tValues = new();

        for (int i = 0; i < s.Length; i++)
        {
            sValues[s[i]] = sValues.GetValueOrDefault(s[i]) + 1;

            tValues[t[i]] = tValues.GetValueOrDefault(t[i]) + 1;

           
        }

        if (sValues.Count != tValues.Count)
        {
            return false;
        }

        for (int i = 0; i < sValues.Count; i++)
        {
            if (tValues.ContainsKey(s[i]))
            {
                if ((sValues[s[i]] == tValues[s[i]]) == false)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            
        }

        return true;
    }
}
