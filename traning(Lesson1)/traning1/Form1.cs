using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace traning1
{

    public partial class form : Form
    {
        //問題と解答の配列を作成
        string[] arr_question = { "リンゴ", "学校", "鉛筆", "机", "鞄", "本", "部屋", "コップ", "椅子", "頭" };
        string[] arr_answer = { "apple", "school", "pencil", "desk", "bag", "book", "room", "cup", "chair", "head"  };

        public void before_after(int QuestionNo)
        {
            questionNo.Text = $"第{QuestionNo} 問";
            question.Text = arr_question[QuestionNo-1];
            ansewrbox.Clear();
            Ansewr.Text = arr_answer[QuestionNo-1];
            ansewr_result.Text = string.Empty;

            Ansewr.Visible = false;
            ansewr_result.Visible = false;

            //前の問題への設定
            if (QuestionNo == 1)
            {
                beyond.Enabled = false;
            }
            else
            {
                beyond.Enabled = true;
            }

            //次の問題への設定
            if (QuestionNo== 10)
            {
                next.Enabled = false;
            }
            else
            {
                next.Enabled = true;
            }

        }

        public form()
        {
            InitializeComponent();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            if (ansewrbox.Text == Ansewr.Text) 
            {
                Ansewr.Visible =true;
                ansewr_result.Visible = true;
                ansewr_result.Text = "〇";
                ansewr_result.ForeColor = Color.Blue;
            }
            else
            {
                Ansewr.Visible = true;
                ansewr_result.Visible = true;
                ansewr_result.Text = "×";
                ansewr_result.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int question_count = 1;

            form QS = new traning1.form();
            before_after(question_count);
        }

        private void ansewrbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void beyond_Click(object sender, EventArgs e)
        {
            int count = Array.IndexOf(arr_question, question.Text, 0)+1;

            form QS = new traning1.form();
            before_after(count - 1);


        }

        private void next_Click(object sender, EventArgs e)
        {
            int count = Array.IndexOf(arr_question, question.Text, 0)+1;

            form QS = new traning1.form();
            before_after(count + 1);
        }
    }
}
