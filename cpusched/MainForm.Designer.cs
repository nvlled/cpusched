namespace cpusched
{
    partial class celltooltip
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(celltooltip));
            this.gridPs = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGantt = new System.Windows.Forms.Panel();
            this.chkSJF = new System.Windows.Forms.CheckBox();
            this.chkFCFS = new System.Windows.Forms.CheckBox();
            this.wah = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelBack = new System.Windows.Forms.Panel();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridPs)).BeginInit();
            this.panelBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridPs
            // 
            resources.ApplyResources(this.gridPs, "gridPs");
            this.gridPs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPs.Name = "gridPs";
            this.gridPs.RowTemplate.Height = 24;
            this.toolTip1.SetToolTip(this.gridPs, resources.GetString("gridPs.ToolTip"));
            this.gridPs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.gridPs.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridPs_CellValidating);
            this.gridPs.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridPs_DataError);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.runScheduler);
            // 
            // panelGantt
            // 
            resources.ApplyResources(this.panelGantt, "panelGantt");
            this.panelGantt.Name = "panelGantt";
            this.panelGantt.Resize += new System.EventHandler(this.panelGantt_Resize);
            // 
            // chkSJF
            // 
            resources.ApplyResources(this.chkSJF, "chkSJF");
            this.chkSJF.Name = "chkSJF";
            this.toolTip1.SetToolTip(this.chkSJF, resources.GetString("chkSJF.ToolTip"));
            this.chkSJF.UseVisualStyleBackColor = true;
            // 
            // chkFCFS
            // 
            resources.ApplyResources(this.chkFCFS, "chkFCFS");
            this.chkFCFS.Checked = true;
            this.chkFCFS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFCFS.Name = "chkFCFS";
            this.toolTip1.SetToolTip(this.chkFCFS, resources.GetString("chkFCFS.ToolTip"));
            this.chkFCFS.UseVisualStyleBackColor = true;
            // 
            // wah
            // 
            resources.ApplyResources(this.wah, "wah");
            this.wah.Name = "wah";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 1;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 1;
            this.toolTip1.ReshowDelay = 0;
            // 
            // panelBack
            // 
            resources.ApplyResources(this.panelBack, "panelBack");
            this.panelBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelBack.Controls.Add(this.panelGantt);
            this.panelBack.Name = "panelBack";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.toolTip2.ToolTipTitle = "Cell value";
            // 
            // celltooltip
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.wah);
            this.Controls.Add(this.chkFCFS);
            this.Controls.Add(this.chkSJF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridPs);
            this.Name = "celltooltip";
            this.Load += new System.EventHandler(this.celltooltip_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.gridPs)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelGantt;
        private System.Windows.Forms.CheckBox chkSJF;
        private System.Windows.Forms.CheckBox chkFCFS;
        private System.Windows.Forms.Label wah;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

