﻿namespace AccountApplicationDemoApp
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtBalance = new TextBox();
            btnCreate = new Button();
            btnSet = new Button();
            btnGet = new Button();
            btnGC = new Button();
            btnDestroy = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(28, 35);
            txtId.Name = "txtId";
            txtId.Size = new Size(157, 23);
            txtId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 17);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 17);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 17);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Balance";
            // 
            // txtName
            // 
            txtName.Location = new Point(190, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(157, 23);
            txtName.TabIndex = 3;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(350, 35);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(157, 23);
            txtBalance.TabIndex = 5;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(55, 78);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(132, 53);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(207, 78);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(132, 53);
            btnSet.TabIndex = 7;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(362, 78);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(132, 53);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // btnGC
            // 
            btnGC.Location = new Point(362, 152);
            btnGC.Name = "btnGC";
            btnGC.Size = new Size(132, 53);
            btnGC.TabIndex = 11;
            btnGC.Text = "GC";
            btnGC.UseVisualStyleBackColor = true;
            btnGC.Click += btnGC_Click;
            // 
            // btnDestroy
            // 
            btnDestroy.Location = new Point(207, 152);
            btnDestroy.Name = "btnDestroy";
            btnDestroy.Size = new Size(132, 53);
            btnDestroy.TabIndex = 10;
            btnDestroy.Text = "Destroy";
            btnDestroy.UseVisualStyleBackColor = true;
            btnDestroy.Click += btnDestroy_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(55, 152);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(132, 53);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 274);
            Controls.Add(btnGC);
            Controls.Add(btnDestroy);
            Controls.Add(btnClear);
            Controls.Add(btnGet);
            Controls.Add(btnSet);
            Controls.Add(btnCreate);
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtId);
            Name = "AccountForm";
            Text = "Account Form";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtBalance;
        private Button btnCreate;
        private Button btnSet;
        private Button btnGet;
        private Button btnGC;
        private Button btnDestroy;
        private Button btnClear;
    }
}
