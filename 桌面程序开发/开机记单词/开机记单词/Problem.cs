using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 开机记单词
{
    public class Problem
    {
        private string questionStr;
        private Random rdm, rd;
        private string[] ans = { "", "", "", "" };
        private int correctId;
        private bool isEnglish;
        public Problem() { rdm = new Random(); rd = new Random(rdm.Next() * rdm.Next()); }
        public String Question
        {
            get => questionStr;
        }
        public String Ans1
        {
            get => ans[1];
        }
        public String Ans2
        {
            get => ans[2];
        }
        public String Ans3
        {
            get => ans[3];
        }
        public int CorrectId
        {
            get => correctId;
        }
        public bool IsEnglish
        {
            get => isEnglish;
        }
        public void Get()
        {
            if (PublicElement.Dt == null)
            {
                string constr = Properties.Settings.Default._15000个英语单词数据库access版ConnectionString;
                OleDbConnection conn = new OleDbConnection(constr);
                string sql = "SELECT ID, words, meaning, tyc, fyc, xj, yj, lx FROM cetsix";
                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                PublicElement.Dt = new DataTable();
                da.Fill(PublicElement.Dt);
                conn.Close();
            }
            //随机生成英文选中文题或中文选英文题
            int tmp = rd.Next();
            if ((tmp & 1) == 1) { GetEnglish(); isEnglish = true; }
            else { GetChinese(); isEnglish = false; }
        }
        private void GetEnglish()
        {
            int id = (rd.Next()) % PublicElement.DtSize + 1;
            correctId = (rd.Next() % 3) + 1;
            questionStr = PublicElement.Dt.Rows[id]["words"].ToString();
            ans[correctId] = PublicElement.Dt.Rows[id]["meaning"].ToString();
            for (int i = 1; i <= 3; ++i)
            {
                if (i == correctId) continue;
                id = (rd.Next()) % PublicElement.DtSize + 1;
                ans[i] = PublicElement.Dt.Rows[id]["meaning"].ToString();
            }
        }
        private void GetChinese()
        {
            int id = (rd.Next()) % PublicElement.DtSize + 1;
            correctId = (rd.Next() % 3) + 1;
            questionStr = PublicElement.Dt.Rows[id]["meaning"].ToString();
            ans[correctId] = PublicElement.Dt.Rows[id]["words"].ToString();
            for (int i = 1; i <= 3; ++i)
            {
                if (i == correctId) continue;
                id = (rd.Next()) % PublicElement.DtSize + 1;
                ans[i] = PublicElement.Dt.Rows[id]["words"].ToString();
            }
        }
    }
}
