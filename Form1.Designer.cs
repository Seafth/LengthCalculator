﻿using System.Windows.Forms;

namespace LengthCalculator
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(121, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(339, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "公尺";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(563, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 34);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(563, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 34);
            this.label4.TabIndex = 5;
            this.label4.Text = "英碼";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(339, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "英尺";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(121, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 34);
            this.label6.TabIndex = 3;
            this.label6.Text = "英吋";
            // 
            // txtCM
            // 
            this.txtCM.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtCM.Location = new System.Drawing.Point(108, 181);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(171, 47);
            this.txtCM.TabIndex = 6;
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtM.Location = new System.Drawing.Point(331, 181);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(171, 47);
            this.txtM.TabIndex = 7;
            // 
            // txtKM
            // 
            this.txtKM.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtKM.Location = new System.Drawing.Point(551, 181);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(171, 47);
            this.txtKM.TabIndex = 8;
            // 
            // txtYard
            // 
            this.txtYard.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtYard.Location = new System.Drawing.Point(551, 317);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(171, 47);
            this.txtYard.TabIndex = 11;
            // 
            // txtFt
            // 
            this.txtFt.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtFt.Location = new System.Drawing.Point(331, 317);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(171, 47);
            this.txtFt.TabIndex = 10;
            // 
            // txtIn
            // 
            this.txtIn.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtIn.Location = new System.Drawing.Point(108, 317);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(171, 47);
            this.txtIn.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F);
            this.label7.Location = new System.Drawing.Point(121, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "說明文字";
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("新細明體", 20F);
            this.txtInfo.Location = new System.Drawing.Point(108, 470);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(614, 47);
            this.txtInfo.TabIndex = 13;
            // 
            // btnAllClear
            // 
            this.btnAllClear.Font = new System.Drawing.Font("新細明體", 20F);
            this.btnAllClear.Location = new System.Drawing.Point(108, 33);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(164, 57);
            this.btnAllClear.TabIndex = 14;
            this.btnAllClear.Text = "清除";
            this.btnAllClear.UseVisualStyleBackColor = true;
            this.btnAllClear.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnAllClear_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnAllClear;
        private KeyEventHandler btnAllClear_KeyUp;
    }
}

