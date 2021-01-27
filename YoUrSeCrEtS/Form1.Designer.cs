
namespace YoUrSeCrEtS
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.LeftTextBox = new System.Windows.Forms.TextBox();
            this.RightTextBox = new System.Windows.Forms.TextBox();
            this.LeftToRightButton = new System.Windows.Forms.Button();
            this.RightToLeftButton = new System.Windows.Forms.Button();
            this.LeftComboBox = new System.Windows.Forms.ComboBox();
            this.RightComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LeftTextBox
            // 
            this.LeftTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LeftTextBox.Location = new System.Drawing.Point(12, 41);
            this.LeftTextBox.Multiline = true;
            this.LeftTextBox.Name = "LeftTextBox";
            this.LeftTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LeftTextBox.Size = new System.Drawing.Size(400, 383);
            this.LeftTextBox.TabIndex = 0;
            this.LeftTextBox.Text = "偷偷告诉你，其实我喜欢你已经很久了";
            // 
            // RightTextBox
            // 
            this.RightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RightTextBox.Location = new System.Drawing.Point(518, 41);
            this.RightTextBox.Multiline = true;
            this.RightTextBox.Name = "RightTextBox";
            this.RightTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RightTextBox.Size = new System.Drawing.Size(400, 383);
            this.RightTextBox.TabIndex = 1;
            // 
            // LeftToRightButton
            // 
            this.LeftToRightButton.Location = new System.Drawing.Point(418, 41);
            this.LeftToRightButton.Name = "LeftToRightButton";
            this.LeftToRightButton.Size = new System.Drawing.Size(94, 138);
            this.LeftToRightButton.TabIndex = 4;
            this.LeftToRightButton.Text = "->";
            this.LeftToRightButton.UseVisualStyleBackColor = true;
            this.LeftToRightButton.Click += new System.EventHandler(this.LeftToRightButton_Click);
            // 
            // RightToLeftButton
            // 
            this.RightToLeftButton.Location = new System.Drawing.Point(418, 286);
            this.RightToLeftButton.Name = "RightToLeftButton";
            this.RightToLeftButton.Size = new System.Drawing.Size(94, 138);
            this.RightToLeftButton.TabIndex = 5;
            this.RightToLeftButton.Text = "<-";
            this.RightToLeftButton.UseVisualStyleBackColor = true;
            this.RightToLeftButton.Click += new System.EventHandler(this.RightToLeftButton_Click);
            // 
            // LeftComboBox
            // 
            this.LeftComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LeftComboBox.FormattingEnabled = true;
            this.LeftComboBox.Location = new System.Drawing.Point(12, 12);
            this.LeftComboBox.Name = "LeftComboBox";
            this.LeftComboBox.Size = new System.Drawing.Size(400, 20);
            this.LeftComboBox.TabIndex = 6;
            // 
            // RightComboBox
            // 
            this.RightComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RightComboBox.FormattingEnabled = true;
            this.RightComboBox.Location = new System.Drawing.Point(518, 12);
            this.RightComboBox.Name = "RightComboBox";
            this.RightComboBox.Size = new System.Drawing.Size(400, 20);
            this.RightComboBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 436);
            this.Controls.Add(this.RightComboBox);
            this.Controls.Add(this.LeftComboBox);
            this.Controls.Add(this.RightToLeftButton);
            this.Controls.Add(this.LeftToRightButton);
            this.Controls.Add(this.RightTextBox);
            this.Controls.Add(this.LeftTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "YoUrSeCrEtS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LeftTextBox;
        private System.Windows.Forms.TextBox RightTextBox;
        private System.Windows.Forms.Button LeftToRightButton;
        private System.Windows.Forms.Button RightToLeftButton;
        private System.Windows.Forms.ComboBox LeftComboBox;
        private System.Windows.Forms.ComboBox RightComboBox;
    }
}

