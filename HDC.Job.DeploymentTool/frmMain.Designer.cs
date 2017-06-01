namespace HDC.Job.DeploymentTool
{
    partial class frmMain
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnChooseInstancePath = new System.Windows.Forms.Button();
            this.txtInstancePath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbContextPanel = new System.Windows.Forms.GroupBox();
            this.gvContext = new System.Windows.Forms.DataGridView();
            this.ContextName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContextValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBase = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.txtInstanceNamespace = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDeployment = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbContextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvContext)).BeginInit();
            this.gbBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择JOB实例文件夹：";
            // 
            // btnChooseInstancePath
            // 
            this.btnChooseInstancePath.Location = new System.Drawing.Point(445, 29);
            this.btnChooseInstancePath.Name = "btnChooseInstancePath";
            this.btnChooseInstancePath.Size = new System.Drawing.Size(75, 23);
            this.btnChooseInstancePath.TabIndex = 1;
            this.btnChooseInstancePath.Text = "选 择";
            this.btnChooseInstancePath.UseVisualStyleBackColor = true;
            this.btnChooseInstancePath.Click += new System.EventHandler(this.btnChooseInstancePath_Click);
            // 
            // txtInstancePath
            // 
            this.txtInstancePath.Location = new System.Drawing.Point(138, 31);
            this.txtInstancePath.Name = "txtInstancePath";
            this.txtInstancePath.Size = new System.Drawing.Size(301, 21);
            this.txtInstancePath.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtInstancePath);
            this.groupBox1.Controls.Add(this.btnChooseInstancePath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "选择JOB实例目录：";
            // 
            // gbContextPanel
            // 
            this.gbContextPanel.Controls.Add(this.gvContext);
            this.gbContextPanel.Enabled = false;
            this.gbContextPanel.Location = new System.Drawing.Point(29, 285);
            this.gbContextPanel.Name = "gbContextPanel";
            this.gbContextPanel.Size = new System.Drawing.Size(553, 155);
            this.gbContextPanel.TabIndex = 4;
            this.gbContextPanel.TabStop = false;
            this.gbContextPanel.Text = "配置上下文信息：";
            // 
            // gvContext
            // 
            this.gvContext.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvContext.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ContextName,
            this.ContextValue});
            this.gvContext.Location = new System.Drawing.Point(15, 21);
            this.gvContext.Name = "gvContext";
            this.gvContext.RowTemplate.Height = 23;
            this.gvContext.Size = new System.Drawing.Size(521, 128);
            this.gvContext.TabIndex = 0;
            // 
            // ContextName
            // 
            this.ContextName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContextName.HeaderText = "键";
            this.ContextName.Name = "ContextName";
            // 
            // ContextValue
            // 
            this.ContextValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ContextValue.HeaderText = "值";
            this.ContextValue.Name = "ContextValue";
            // 
            // gbBase
            // 
            this.gbBase.Controls.Add(this.txtDescription);
            this.gbBase.Controls.Add(this.txtInstanceNamespace);
            this.gbBase.Controls.Add(this.txtDisplayName);
            this.gbBase.Controls.Add(this.txtServiceName);
            this.gbBase.Controls.Add(this.label5);
            this.gbBase.Controls.Add(this.label4);
            this.gbBase.Controls.Add(this.label3);
            this.gbBase.Controls.Add(this.label2);
            this.gbBase.Enabled = false;
            this.gbBase.Location = new System.Drawing.Point(29, 105);
            this.gbBase.Name = "gbBase";
            this.gbBase.Size = new System.Drawing.Size(553, 168);
            this.gbBase.TabIndex = 5;
            this.gbBase.TabStop = false;
            this.gbBase.Text = "基础信息配置：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "SerivceName：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "DisplayName：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Description：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "InstanceNamespace：";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(178, 15);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(342, 21);
            this.txtServiceName.TabIndex = 1;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(178, 47);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(342, 21);
            this.txtDisplayName.TabIndex = 1;
            // 
            // txtInstanceNamespace
            // 
            this.txtInstanceNamespace.Location = new System.Drawing.Point(178, 74);
            this.txtInstanceNamespace.Name = "txtInstanceNamespace";
            this.txtInstanceNamespace.Size = new System.Drawing.Size(342, 21);
            this.txtInstanceNamespace.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(178, 102);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 53);
            this.txtDescription.TabIndex = 1;
            // 
            // btnDeployment
            // 
            this.btnDeployment.Enabled = false;
            this.btnDeployment.Location = new System.Drawing.Point(405, 457);
            this.btnDeployment.Name = "btnDeployment";
            this.btnDeployment.Size = new System.Drawing.Size(144, 43);
            this.btnDeployment.TabIndex = 6;
            this.btnDeployment.Text = "部 署";
            this.btnDeployment.UseVisualStyleBackColor = true;
            this.btnDeployment.Click += new System.EventHandler(this.btnDeployment_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 522);
            this.Controls.Add(this.btnDeployment);
            this.Controls.Add(this.gbBase);
            this.Controls.Add(this.gbContextPanel);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job 部署工具";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbContextPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvContext)).EndInit();
            this.gbBase.ResumeLayout(false);
            this.gbBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChooseInstancePath;
        private System.Windows.Forms.TextBox txtInstancePath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbContextPanel;
        private System.Windows.Forms.DataGridView gvContext;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContextName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContextValue;
        private System.Windows.Forms.GroupBox gbBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtInstanceNamespace;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Button btnDeployment;
    }
}

