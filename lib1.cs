using System;

namespace Library
{
    public class lib1
    {
        static public string stpow(string pow1, int pow2)
        {
            string a = pow1;
            for (int i = 0; i < pow2 - 1; i++)
            {
                pow1 = pow1 + a1;
            }
            return pow1;
        }
        static public string rev(string rev)
        {
            string b = "";
            for (int i = rev.Length - 1; i > -1; i--) 
            {
                b = b + a[i] + "";
            }
            return b;
        }
        static public string remov(string re)
        {
            for (int i = 0; i < re.Length; i++)
            {
               re = re.Replace(s, "");
            }
            return re;
        }
        static public int leng(string leng)
        {
            int n = leng.Length;
            return n;
        }
    }
}

