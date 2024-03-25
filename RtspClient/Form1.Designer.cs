namespace RtspClient
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Setting = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_RtspAddress = new System.Windows.Forms.TextBox();
            this.tabPage_View = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer_ViewRefresh = new System.Windows.Forms.Timer(this.components);
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Setting.SuspendLayout();
            this.tabPage_View.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Setting);
            this.tabControl_Main.Controls.Add(this.tabPage_View);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(553, 535);
            this.tabControl_Main.TabIndex = 0;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.tabControl_Main_SelectedIndexChanged);
            // 
            // tabPage_Setting
            // 
            this.tabPage_Setting.Controls.Add(this.label1);
            this.tabPage_Setting.Controls.Add(this.textBox_RtspAddress);
            this.tabPage_Setting.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Setting.Name = "tabPage_Setting";
            this.tabPage_Setting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Setting.Size = new System.Drawing.Size(545, 509);
            this.tabPage_Setting.TabIndex = 1;
            this.tabPage_Setting.Text = "Setting";
            this.tabPage_Setting.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "RtspAddress  ({id}:{password}@{address})";
            // 
            // textBox_RtspAddress
            // 
            this.textBox_RtspAddress.Location = new System.Drawing.Point(8, 28);
            this.textBox_RtspAddress.Name = "textBox_RtspAddress";
            this.textBox_RtspAddress.Size = new System.Drawing.Size(529, 19);
            this.textBox_RtspAddress.TabIndex = 0;
            // 
            // tabPage_View
            // 
            this.tabPage_View.Controls.Add(this.pictureBox1);
            this.tabPage_View.Location = new System.Drawing.Point(4, 22);
            this.tabPage_View.Name = "tabPage_View";
            this.tabPage_View.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_View.Size = new System.Drawing.Size(545, 509);
            this.tabPage_View.TabIndex = 0;
            this.tabPage_View.Text = "View";
            this.tabPage_View.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 454);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer_ViewRefresh
            // 
            this.timer_ViewRefresh.Interval = 1;
            this.timer_ViewRefresh.Tick += new System.EventHandler(this.timer_ViewRefresh_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 535);
            this.Controls.Add(this.tabControl_Main);
            this.Name = "Form1";
            this.Text = "RtspClient";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Setting.ResumeLayout(false);
            this.tabPage_Setting.PerformLayout();
            this.tabPage_View.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_View;
        private System.Windows.Forms.TabPage tabPage_Setting;
        private System.Windows.Forms.TextBox textBox_RtspAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_ViewRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

