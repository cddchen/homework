using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum Operation { Null, Add, Sub, Mul, Div };
    public class Calculate
    {
        private bool isMemory;
        private Ans ansMemory;
        private Ans ans;
        public Calculate()
        {
            isMemory = false;
            ans = new Ans();
            ansMemory = new Ans();
        }
        public static bool checkInput(string str)
        {
            int cnt = 0;
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '-')
                {
                    if (i == 0) continue;
                    else return false;
                }
                if (str[i] == '.')
                {
                    cnt++;
                    if (cnt > 1) return false;
                    else continue;
                }
                if (str[i] >= '0' && str[i] <= '9') continue;
                return false;
            }
            return true;
        }
        public void MemoryClear()
        {
            isMemory = false;
            ansMemory.Clear();
        }
        public void MemoryAdd(string str)
        {
            Ans res = new Ans(str);
            ansMemory = ansMemory + res;
            if (!isMemory) isMemory = true;
        }
        public void MemorySub(string str)
        {
            Ans res = new Ans(str);
            ansMemory = ansMemory - res;
            if (!isMemory) isMemory = false;
        }
        public string MemoryRead()
        {
            return ansMemory.ans;
        }
        public void AllClear()
        {
            ans.Clear();
        }
        public string PosOrNeg()
        {
            ans = ans * new Ans("-1");
            return ans.ans;
        }
        public string Cal(Operation op, string str)
        {
            if (op == Operation.Null)
            {
                ans.Clear();
                ans = ans + new Ans(str);
            }
            else if (op == Operation.Add) ans = ans + new Ans(str);
            else if (op == Operation.Sub) ans = ans - new Ans(str);
            else if (op == Operation.Mul) ans = ans * new Ans(str);
            else ans = ans / new Ans(str);
            return ans.ans;
        }
    }
}
