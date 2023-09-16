namespace Proje1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textDizin1 = new TextBox();
            textDizin2 = new TextBox();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textMatch = new TextBox();
            textMismatch = new TextBox();
            textGap = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label8 = new Label();
            label9 = new Label();
            textSkor = new TextBox();
            textSon2 = new TextBox();
            textSon1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "1.dizin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 59);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "2.dizin";
            // 
            // textDizin1
            // 
            textDizin1.Location = new Point(106, 23);
            textDizin1.Name = "textDizin1";
            textDizin1.Size = new Size(232, 27);
            textDizin1.TabIndex = 2;
            // 
            // textDizin2
            // 
            textDizin2.Location = new Point(106, 59);
            textDizin2.Name = "textDizin2";
            textDizin2.Size = new Size(232, 27);
            textDizin2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 289);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(921, 343);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 120);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "MATCH:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 7;
            label4.Text = "MİSMATCH:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 194);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 8;
            label5.Text = "GAP:";
            // 
            // textMatch
            // 
            textMatch.Location = new Point(106, 120);
            textMatch.Name = "textMatch";
            textMatch.Size = new Size(232, 27);
            textMatch.TabIndex = 10;
            // 
            // textMismatch
            // 
            textMismatch.Location = new Point(106, 157);
            textMismatch.Name = "textMismatch";
            textMismatch.Size = new Size(232, 27);
            textMismatch.TabIndex = 9;
            // 
            // textGap
            // 
            textGap.Location = new Point(106, 194);
            textGap.Name = "textGap";
            textGap.Size = new Size(232, 27);
            textGap.TabIndex = 11;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(458, 192);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 19;
            button2.Text = "Hesapla";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(576, 196);
            label10.Name = "label10";
            label10.Size = new Size(38, 20);
            label10.TabIndex = 20;
            label10.Text = "Süre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(458, 58);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 12;
            label7.Text = "2.Dizin";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(458, 21);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 13;
            label6.Text = "1.Dizin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(461, 100);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 14;
            label8.Text = "Skor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(620, 196);
            label9.Name = "label9";
            label9.Size = new Size(28, 20);
            label9.TabIndex = 15;
            label9.Text = "ms";
            // 
            // textSkor
            // 
            textSkor.Location = new Point(552, 96);
            textSkor.Name = "textSkor";
            textSkor.Size = new Size(232, 27);
            textSkor.TabIndex = 16;
            // 
            // textSon2
            // 
            textSon2.Location = new Point(552, 58);
            textSon2.Name = "textSon2";
            textSon2.Size = new Size(232, 27);
            textSon2.TabIndex = 17;
            // 
            // textSon1
            // 
            textSon1.Location = new Point(552, 18);
            textSon1.Name = "textSon1";
            textSon1.Size = new Size(232, 27);
            textSon1.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(945, 644);
            Controls.Add(label10);
            Controls.Add(button2);
            Controls.Add(textSon1);
            Controls.Add(textSon2);
            Controls.Add(textSkor);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(textGap);
            Controls.Add(textMatch);
            Controls.Add(textMismatch);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(textDizin2);
            Controls.Add(textDizin1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textDizin1;
        private TextBox textDizin2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textMatch;
        private TextBox textMismatch;
        private TextBox textGap;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
        private TextBox textSkor;
        private TextBox textSon2;
        private TextBox textSon1;
    }
}