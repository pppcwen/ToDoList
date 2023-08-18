namespace f74114087_practice_7_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顯示完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隱藏完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.尋找ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.完成事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.刪除事項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.TextBox();
            this.findresult = new System.Windows.Forms.TextBox();
            this.CF = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(834, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "新增事項";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(-3, 54);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(961, 548);
            this.textBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.編輯ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(954, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟ToolStripMenuItem,
            this.儲存ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem,
            this.離開ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.開啟ToolStripMenuItem.Text = "開啟";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.儲存ToolStripMenuItem.Text = "儲存";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.離開ToolStripMenuItem.Text = "離開";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字型大小ToolStripMenuItem,
            this.顯示完成事項ToolStripMenuItem,
            this.隱藏完成事項ToolStripMenuItem});
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 字型大小ToolStripMenuItem
            // 
            this.字型大小ToolStripMenuItem.Name = "字型大小ToolStripMenuItem";
            this.字型大小ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.字型大小ToolStripMenuItem.Text = "字型大小";
            this.字型大小ToolStripMenuItem.Click += new System.EventHandler(this.字型大小ToolStripMenuItem_Click);
            // 
            // 顯示完成事項ToolStripMenuItem
            // 
            this.顯示完成事項ToolStripMenuItem.Name = "顯示完成事項ToolStripMenuItem";
            this.顯示完成事項ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.顯示完成事項ToolStripMenuItem.Text = "顯示完成事項";
            this.顯示完成事項ToolStripMenuItem.Click += new System.EventHandler(this.顯示完成事項ToolStripMenuItem_Click);
            // 
            // 隱藏完成事項ToolStripMenuItem
            // 
            this.隱藏完成事項ToolStripMenuItem.Name = "隱藏完成事項ToolStripMenuItem";
            this.隱藏完成事項ToolStripMenuItem.Size = new System.Drawing.Size(210, 30);
            this.隱藏完成事項ToolStripMenuItem.Text = "隱藏完成事項";
            this.隱藏完成事項ToolStripMenuItem.Click += new System.EventHandler(this.隱藏完成事項ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.尋找ToolStripMenuItem,
            this.新增事項ToolStripMenuItem,
            this.完成事項ToolStripMenuItem,
            this.刪除事項ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 尋找ToolStripMenuItem
            // 
            this.尋找ToolStripMenuItem.Name = "尋找ToolStripMenuItem";
            this.尋找ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.尋找ToolStripMenuItem.Text = "尋找";
            this.尋找ToolStripMenuItem.Click += new System.EventHandler(this.尋找ToolStripMenuItem_Click);
            // 
            // 新增事項ToolStripMenuItem
            // 
            this.新增事項ToolStripMenuItem.Name = "新增事項ToolStripMenuItem";
            this.新增事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.新增事項ToolStripMenuItem.Text = "新增事項";
            this.新增事項ToolStripMenuItem.Click += new System.EventHandler(this.新增事項ToolStripMenuItem_Click);
            // 
            // 完成事項ToolStripMenuItem
            // 
            this.完成事項ToolStripMenuItem.Name = "完成事項ToolStripMenuItem";
            this.完成事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.完成事項ToolStripMenuItem.Text = "完成事項";
            this.完成事項ToolStripMenuItem.Click += new System.EventHandler(this.完成事項ToolStripMenuItem_Click);
            // 
            // 刪除事項ToolStripMenuItem
            // 
            this.刪除事項ToolStripMenuItem.Name = "刪除事項ToolStripMenuItem";
            this.刪除事項ToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.刪除事項ToolStripMenuItem.Text = "刪除事項";
            this.刪除事項ToolStripMenuItem.Click += new System.EventHandler(this.刪除事項ToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(717, 619);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "完成事項";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hide
            // 
            this.hide.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.hide.Location = new System.Drawing.Point(-3, 62);
            this.hide.Multiline = true;
            this.hide.Name = "hide";
            this.hide.ReadOnly = true;
            this.hide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hide.Size = new System.Drawing.Size(961, 548);
            this.hide.TabIndex = 7;
            this.hide.Visible = false;
            // 
            // findresult
            // 
            this.findresult.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.findresult.Location = new System.Drawing.Point(5, 70);
            this.findresult.Multiline = true;
            this.findresult.Name = "findresult";
            this.findresult.ReadOnly = true;
            this.findresult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.findresult.Size = new System.Drawing.Size(961, 548);
            this.findresult.TabIndex = 8;
            this.findresult.Visible = false;
            // 
            // CF
            // 
            this.CF.Location = new System.Drawing.Point(599, 624);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(97, 41);
            this.CF.TabIndex = 9;
            this.CF.Text = "關閉搜尋";
            this.CF.UseVisualStyleBackColor = true;
            this.CF.Visible = false;
            this.CF.Click += new System.EventHandler(this.CF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 672);
            this.Controls.Add(this.CF);
            this.Controls.Add(this.findresult);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型大小ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 顯示完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隱藏完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 尋找ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 完成事項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 刪除事項ToolStripMenuItem;
        private System.Windows.Forms.TextBox hide;
        private System.Windows.Forms.TextBox findresult;
        private System.Windows.Forms.Button CF;
    }
}

