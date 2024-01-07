namespace AccountApplicationDemoApp
{
    partial class AccountForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(144, 133);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(157, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(214, 115);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(366, 115);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 115);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Balance";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(466, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(157, 23);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(171, 176);
            button1.Name = "button1";
            button1.Size = new Size(132, 53);
            button1.TabIndex = 6;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(323, 176);
            button2.Name = "button2";
            button2.Size = new Size(132, 53);
            button2.TabIndex = 7;
            button2.Text = "Set";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(478, 176);
            button3.Name = "button3";
            button3.Size = new Size(132, 53);
            button3.TabIndex = 8;
            button3.Text = "Get";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(478, 250);
            button4.Name = "button4";
            button4.Size = new Size(132, 53);
            button4.TabIndex = 11;
            button4.Text = "GC";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(323, 250);
            button5.Name = "button5";
            button5.Size = new Size(132, 53);
            button5.TabIndex = 10;
            button5.Text = "Destroy";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(171, 250);
            button6.Name = "button6";
            button6.Size = new Size(132, 53);
            button6.TabIndex = 9;
            button6.Text = "Clear";
            button6.UseVisualStyleBackColor = true;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "AccountForm";
            Text = "Account Form";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
