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

        var sChar = s.ToCharArray();
        var tChar = t.ToCharArray();
        Array.Sort(sChar);
        Array.Sort(tChar);

        for (int i = 0; i < sLen; i++)
        {
            if ((sChar[i] == tChar[i]) == false)
            {
                return false;
            }
        }

        return true;



    }
}
