namespace Vysor_Pro_Patcher
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.begin = new System.Windows.Forms.Button();
            this.offline = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.youtubeChannel = new System.Windows.Forms.LinkLabel();
            this.source = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 77);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(263, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(23, 17);
            this.status.Text = "OK";
            // 
            // begin
            // 
            this.begin.BackColor = System.Drawing.Color.PaleGreen;
            this.begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.begin.Location = new System.Drawing.Point(13, 13);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(238, 35);
            this.begin.TabIndex = 1;
            this.begin.Text = "Patch Vysor Pro";
            this.begin.UseVisualStyleBackColor = false;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // offline
            // 
            this.offline.AutoSize = true;
            this.offline.Location = new System.Drawing.Point(41, 54);
            this.offline.Name = "offline";
            this.offline.Size = new System.Drawing.Size(56, 17);
            this.offline.TabIndex = 2;
            this.offline.Text = "Offline";
            this.offline.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // youtubeChannel
            // 
            this.youtubeChannel.AutoSize = true;
            this.youtubeChannel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.youtubeChannel.Location = new System.Drawing.Point(155, 81);
            this.youtubeChannel.Name = "youtubeChannel";
            this.youtubeChannel.Size = new System.Drawing.Size(93, 13);
            this.youtubeChannel.TabIndex = 3;
            this.youtubeChannel.TabStop = true;
            this.youtubeChannel.Text = "YouTube Channel";
            this.youtubeChannel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // source
            // 
            this.source.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.source.FormattingEnabled = true;
            this.source.Items.AddRange(new object[] {
            "Default",
            "ChromeDefaultData"});
            this.source.Location = new System.Drawing.Point(103, 52);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(120, 21);
            this.source.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 99);
            this.Controls.Add(this.source);
            this.Controls.Add(this.youtubeChannel);
            this.Controls.Add(this.offline);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.Text = "Vysor Pro Patcher";
            this.Shown += new System.EventHandler(this.Principal_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.CheckBox offline;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel youtubeChannel;
        private System.Windows.Forms.ComboBox source;
    }
}

