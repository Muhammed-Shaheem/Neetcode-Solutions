using System.Text;

namespace NeetcodeTraining.Solutions;

public class SubSequenceSolution
{
    public static bool IsSubsequence(string s, string t)
    {
        int slength = s.Length;
        int tlength = t.Length;
        StringBuilder temp = new();

        for (int i = 0; i < slength; i++)
        {
            for (int j = 0; j < tlength; j++)
            {

                if (s[i] == t[j])
                {
                  temp = temp.Append(s[i]);
                    break;
                }
            }
        }
        if (temp.ToString() == s)
        {
            return true;
        }
        else
        {
            return false;
        }
  
    }

}
