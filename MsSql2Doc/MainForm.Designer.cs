namespace MsSql2Doc
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            this.btnGeneratDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textConnectionString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTemplate = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGeneratDoc
            // 
            this.btnGeneratDoc.Location = new System.Drawing.Point(545, 138);
            this.btnGeneratDoc.Margin = new System.Windows.Forms.Padding(4);
            this.btnGeneratDoc.Name = "btnGeneratDoc";
            this.btnGeneratDoc.Size = new System.Drawing.Size(94, 34);
            this.btnGeneratDoc.TabIndex = 0;
            this.btnGeneratDoc.Text = "產生";
            this.btnGeneratDoc.UseVisualStyleBackColor = true;
            this.btnGeneratDoc.Click += new System.EventHandler(this.btnGeneratDoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "連接字串：";
            // 
            // textConnectionString
            // 
            this.textConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textConnectionString.Location = new System.Drawing.Point(338, 33);
            this.textConnectionString.Name = "textConnectionString";
            this.textConnectionString.Size = new System.Drawing.Size(301, 30);
            this.textConnectionString.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "文件樣版：";
            // 
            // listTemplate
            // 
            this.listTemplate.FormattingEnabled = true;
            this.listTemplate.ItemHeight = 22;
            this.listTemplate.Location = new System.Drawing.Point(12, 36);
            this.listTemplate.Name = "listTemplate";
            this.listTemplate.Size = new System.Drawing.Size(218, 136);
            this.listTemplate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "輸出檔名：";
            // 
            // textFileName
            // 
            this.textFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFileName.Location = new System.Drawing.Point(338, 69);
            this.textFileName.Name = "textFileName";
            this.textFileName.Size = new System.Drawing.Size(301, 30);
            this.textFileName.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 180);
            this.Controls.Add(this.textFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listTemplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textConnectionString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeneratDoc);
            this.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MsSql2Doc";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeneratDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textConnectionString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listTemplate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFileName;
    }
}

