namespace traning1
{
    partial class form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.ansewrbox = new System.Windows.Forms.TextBox();
            this.action_button = new System.Windows.Forms.Button();
            this.questionNo = new System.Windows.Forms.Label();
            this.question = new System.Windows.Forms.Label();
            this.beyond = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.Ansewr = new System.Windows.Forms.Label();
            this.ansewr_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ansewrbox
            // 
            this.ansewrbox.Font = new System.Drawing.Font("MS UI Gothic", 45F);
            this.ansewrbox.Location = new System.Drawing.Point(317, 104);
            this.ansewrbox.Name = "ansewrbox";
            this.ansewrbox.Size = new System.Drawing.Size(437, 67);
            this.ansewrbox.TabIndex = 0;
            this.ansewrbox.TextChanged += new System.EventHandler(this.ansewrbox_TextChanged);
            // 
            // action_button
            // 
            this.action_button.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.action_button.Location = new System.Drawing.Point(152, 210);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(91, 50);
            this.action_button.TabIndex = 1;
            this.action_button.Text = "答え";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // questionNo
            // 
            this.questionNo.AutoSize = true;
            this.questionNo.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.questionNo.Location = new System.Drawing.Point(21, 41);
            this.questionNo.Name = "questionNo";
            this.questionNo.Size = new System.Drawing.Size(94, 29);
            this.questionNo.TabIndex = 2;
            this.questionNo.Text = "第１問";
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold);
            this.question.Location = new System.Drawing.Point(62, 104);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(173, 67);
            this.question.TabIndex = 3;
            this.question.Text = "リンゴ";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // beyond
            // 
            this.beyond.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.beyond.Location = new System.Drawing.Point(17, 333);
            this.beyond.Name = "beyond";
            this.beyond.Size = new System.Drawing.Size(215, 74);
            this.beyond.TabIndex = 4;
            this.beyond.Text = "前の問題へ";
            this.beyond.UseVisualStyleBackColor = true;
            this.beyond.Click += new System.EventHandler(this.beyond_Click);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Bold);
            this.next.Location = new System.Drawing.Point(539, 333);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(215, 74);
            this.next.TabIndex = 5;
            this.next.Text = "次の問題へ";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Ansewr
            // 
            this.Ansewr.AutoSize = true;
            this.Ansewr.Font = new System.Drawing.Font("MS UI Gothic", 50F, System.Drawing.FontStyle.Bold);
            this.Ansewr.Location = new System.Drawing.Point(305, 193);
            this.Ansewr.Name = "Ansewr";
            this.Ansewr.Size = new System.Drawing.Size(180, 67);
            this.Ansewr.TabIndex = 7;
            this.Ansewr.Text = "apple";
            this.Ansewr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ansewr_result
            // 
            this.ansewr_result.AutoSize = true;
            this.ansewr_result.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.ansewr_result.ForeColor = System.Drawing.Color.Blue;
            this.ansewr_result.Location = new System.Drawing.Point(640, 193);
            this.ansewr_result.Name = "ansewr_result";
            this.ansewr_result.Size = new System.Drawing.Size(114, 80);
            this.ansewr_result.TabIndex = 8;
            this.ansewr_result.Text = "〇";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ansewr_result);
            this.Controls.Add(this.Ansewr);
            this.Controls.Add(this.next);
            this.Controls.Add(this.beyond);
            this.Controls.Add(this.question);
            this.Controls.Add(this.questionNo);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.ansewrbox);
            this.Name = "form";
            this.Text = "英単語テスト";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ansewrbox;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Label questionNo;
        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Button beyond;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label Ansewr;
        private System.Windows.Forms.Label ansewr_result;
    }
}

