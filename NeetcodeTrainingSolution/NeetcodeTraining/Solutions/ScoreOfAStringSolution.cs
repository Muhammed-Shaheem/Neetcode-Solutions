namespace NeetcodeTraining.Solutions;

public static class ScoreOfAStringSolution
{
    public static int ScoreOfString(string s)
    {
        int sum = 0;
        int length = s.Length;
        for (int i = 0; i < length; i++)
        {

            if (i+1 != length)
            {
                sum = Math.Abs((int)s[i] - (int)s[i + 1]) + sum; 
            }
        
            

        }

        return sum;
    }

}
