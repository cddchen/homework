using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Word
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
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
            Word word = new Word();
            word.Get();
            label1.Text = word.Question;
            label2.Text = word.Ans1;
            label3.Text = word.Ans2;
            label4.Text = word.Ans3; 
        }
    }
    public static class PublicElement
    {
        private static DataTable dt = null;
        private static int dtSize = 15000;
        public static DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
        public static int DtSize
        {
            get { return dtSize; }
            set { dtSize = value; }
        }
    }
    public class Word
    {
        private string questionStr;
        private Random rdm, rd;
        private string[] ans = {"", "", "", ""};
        private int correctId;
        public Word() { rdm = new Random(); rd = new Random(rdm.Next() * rdm.Next()); }
        public String Question {
            get { return questionStr; }
        }
        public String Ans1 {
            get { return ans[1]; }
        }
        public String Ans2 {
            get { return ans[2]; }
        }
        public String Ans3 {
            get { return ans[3]; }
        }
        public int CorrectId {
            get { return correctId; }
        }
        public void Get()
        {
            int tmp = rd.Next();
            if ((tmp & 1) == 1) GetEnglish();
            else GetChinese();
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
