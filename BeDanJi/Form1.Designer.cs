
namespace BeDanJi
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
            this.richTextBoxQ = new System.Windows.Forms.RichTextBox();
            this.richTextBoxA = new System.Windows.Forms.RichTextBox();
            this.buttonManageQList = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonYes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonWrong = new System.Windows.Forms.Button();
            this.richTextBoxInfo = new System.Windows.Forms.RichTextBox();
            this.richTextBoxT = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxQ
            // 
            this.richTextBoxQ.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxQ.Name = "richTextBoxQ";
            this.richTextBoxQ.Size = new System.Drawing.Size(401, 187);
            this.richTextBoxQ.TabIndex = 0;
            this.richTextBoxQ.Text = "";
            // 
            // richTextBoxA
            // 
            this.richTextBoxA.Location = new System.Drawing.Point(12, 205);
            this.richTextBoxA.Name = "richTextBoxA";
            this.richTextBoxA.Size = new System.Drawing.Size(401, 95);
            this.richTextBoxA.TabIndex = 1;
            this.richTextBoxA.Text = "";
            // 
            // buttonManageQList
            // 
            this.buttonManageQList.Location = new System.Drawing.Point(419, 12);
            this.buttonManageQList.Name = "buttonManageQList";
            this.buttonManageQList.Size = new System.Drawing.Size(96, 48);
            this.buttonManageQList.TabIndex = 2;
            this.buttonManageQList.Text = "管理字庫";
            this.buttonManageQList.UseVisualStyleBackColor = true;
            // 
            // buttonUser
            // 
            this.buttonUser.Location = new System.Drawing.Point(420, 67);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(95, 51);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "管理使用者";
            this.buttonUser.UseVisualStyleBackColor = true;
            // 
            // buttonYes
            // 
            this.buttonYes.Location = new System.Drawing.Point(6, 21);
            this.buttonYes.Name = "buttonYes";
            this.buttonYes.Size = new System.Drawing.Size(120, 57);
            this.buttonYes.TabIndex = 4;
            this.buttonYes.Text = "對";
            this.buttonYes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWrong);
            this.groupBox1.Controls.Add(this.buttonYes);
            this.groupBox1.Location = new System.Drawing.Point(13, 354);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 84);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自評";
            // 
            // buttonWrong
            // 
            this.buttonWrong.Location = new System.Drawing.Point(132, 21);
            this.buttonWrong.Name = "buttonWrong";
            this.buttonWrong.Size = new System.Drawing.Size(120, 57);
            this.buttonWrong.TabIndex = 5;
            this.buttonWrong.Text = "錯、忘了";
            this.buttonWrong.UseVisualStyleBackColor = true;
            // 
            // richTextBoxInfo
            // 
            this.richTextBoxInfo.Location = new System.Drawing.Point(420, 124);
            this.richTextBoxInfo.Name = "richTextBoxInfo";
            this.richTextBoxInfo.ReadOnly = true;
            this.richTextBoxInfo.Size = new System.Drawing.Size(153, 308);
            this.richTextBoxInfo.TabIndex = 6;
            this.richTextBoxInfo.Text = "";
            // 
            // richTextBoxT
            // 
            this.richTextBoxT.Location = new System.Drawing.Point(13, 304);
            this.richTextBoxT.Name = "richTextBoxT";
            this.richTextBoxT.Size = new System.Drawing.Size(400, 44);
            this.richTextBoxT.TabIndex = 7;
            this.richTextBoxT.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxT);
            this.Controls.Add(this.richTextBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonManageQList);
            this.Controls.Add(this.richTextBoxA);
            this.Controls.Add(this.richTextBoxQ);
            this.Name = "Form1";
            this.Text = "SelfTestDanJi";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxQ;
        private System.Windows.Forms.RichTextBox richTextBoxA;
        private System.Windows.Forms.Button buttonManageQList;
        private System.Windows.Forms.Button buttonUser;
        private System.Windows.Forms.Button buttonYes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonWrong;
        private System.Windows.Forms.RichTextBox richTextBoxInfo;
        private System.Windows.Forms.RichTextBox richTextBoxT;
    }
}

