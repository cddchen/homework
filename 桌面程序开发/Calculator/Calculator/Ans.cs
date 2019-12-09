using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Ans
    {
        //分母，分子
        private int Denominator, Numerator;
        public Ans()
        {
            this.Denominator = 1;
            this.Numerator = 0;
        }
        public Ans(int Num, int Den)
        {
            this.Denominator = Den;
            this.Numerator = Num;
        }
        public Ans(string str)
        {
            int _Den = 1, _Num = 0, Flag = 1;
            bool isFloat = false;
            for (int i = 0; i < str.Length; ++i)
            {
                if (i == 0 && str[i] == '-')
                {
                    Flag = -1;
                    continue;
                }
                if (str[i] == '.')
                {
                    isFloat = true;
                    continue;
                }
                _Num = _Num * 10 + str[i] - '0';
                if (isFloat) _Den = _Den * 10;
            }
            this.Denominator = _Den;
            this.Numerator = _Num * Flag;
        }
        public void Clear()
        {
            this.Denominator = 1;
            this.Numerator = 0;
        }
        public string ans
        {
            get
            {
                string res = null;
                if (this.Denominator == 1)
                {
                    res = this.Numerator.ToString();
                }
                else
                {
                    res = ((double)this.Numerator / (double)this.Denominator).ToString();
                }
                return res;
            }
        }
        public static int gcd(int a, int b)
        {
            if (a < 0) a = -a; if (b < 0) b = -b;
            if (a < b) { int t = a; a = b; b = t; }
            if (b == 0) return a;
            return gcd(b, a % b);
        }
        public static Ans operator +(Ans a, Ans b)
        {
            int _Den = a.Denominator * b.Denominator;
            int _Num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int GCD = gcd(_Den, _Num);
            return new Ans(_Num / GCD, _Den / GCD);
        }
        public static Ans operator -(Ans a, Ans b)
        {
            int _Den = a.Denominator * b.Denominator;
            int _Num = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int GCD = gcd(_Den, _Num);
            return new Ans(_Num / GCD, _Den / GCD);
        }
        public static Ans operator *(Ans a, Ans b)
        {
            int _Den = a.Denominator * b.Denominator;
            int _Num = a.Numerator * b.Numerator;
            int GCD = gcd(_Den, _Num);
            return new Ans(_Num / GCD, _Den / GCD);
        }
        public static Ans operator /(Ans a, Ans b)
        {
            int _Den = a.Denominator * b.Numerator;
            int _Num = a.Numerator * b.Denominator;
            if (_Den == 0) _Den = 1;
            int GCD = gcd(_Den, _Num);
            return new Ans(_Num / GCD, _Den / GCD);
        }
    }
}
