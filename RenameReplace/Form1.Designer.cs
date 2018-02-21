namespace RenameReplace
{
    partial class Form1
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
            this.btnSimulate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.dfsLog = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dfsFolder = new System.Windows.Forms.TextBox();
            this.dffOverwrite = new System.Windows.Forms.CheckBox();
            this.dfsDestination = new System.Windows.Forms.TextBox();
            this.dfsSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSimulate
            // 
            this.btnSimulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSimulate.Location = new System.Drawing.Point(521, 141);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(116, 23);
            this.btnSimulate.TabIndex = 0;
            this.btnSimulate.Text = "Simulate Rename";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Match RegEx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Replace RegEx";
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Location = new System.Drawing.Point(521, 248);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(116, 23);
            this.btnRename.TabIndex = 6;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // dfsLog
            // 
            this.dfsLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsLog.Location = new System.Drawing.Point(121, 141);
            this.dfsLog.Multiline = true;
            this.dfsLog.Name = "dfsLog";
            this.dfsLog.Size = new System.Drawing.Size(379, 341);
            this.dfsLog.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Folder";
            // 
            // dfsFolder
            // 
            this.dfsFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenameReplace.Properties.Settings.Default, "dfsFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsFolder.Location = new System.Drawing.Point(121, 25);
            this.dfsFolder.Name = "dfsFolder";
            this.dfsFolder.Size = new System.Drawing.Size(379, 20);
            this.dfsFolder.TabIndex = 8;
            this.dfsFolder.Text = global::RenameReplace.Properties.Settings.Default.dfsFolder;
            // 
            // dffOverwrite
            // 
            this.dffOverwrite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dffOverwrite.AutoSize = true;
            this.dffOverwrite.Checked = global::RenameReplace.Properties.Settings.Default.dffOverwrite;
            this.dffOverwrite.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::RenameReplace.Properties.Settings.Default, "dffOverwrite", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dffOverwrite.Location = new System.Drawing.Point(521, 194);
            this.dffOverwrite.Name = "dffOverwrite";
            this.dffOverwrite.Size = new System.Drawing.Size(124, 17);
            this.dffOverwrite.TabIndex = 3;
            this.dffOverwrite.Text = "Overwrite if file exists";
            this.dffOverwrite.UseVisualStyleBackColor = true;
            // 
            // dfsDestination
            // 
            this.dfsDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsDestination.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenameReplace.Properties.Settings.Default, "dfsDestination", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsDestination.Location = new System.Drawing.Point(121, 103);
            this.dfsDestination.Name = "dfsDestination";
            this.dfsDestination.Size = new System.Drawing.Size(379, 20);
            this.dfsDestination.TabIndex = 2;
            this.dfsDestination.Text = global::RenameReplace.Properties.Settings.Default.dfsDestination;
            // 
            // dfsSource
            // 
            this.dfsSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dfsSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::RenameReplace.Properties.Settings.Default, "dfsSource", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dfsSource.Location = new System.Drawing.Point(121, 68);
            this.dfsSource.Name = "dfsSource";
            this.dfsSource.Size = new System.Drawing.Size(379, 20);
            this.dfsSource.TabIndex = 1;
            this.dfsSource.Text = global::RenameReplace.Properties.Settings.Default.dfsSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 494);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dfsFolder);
            this.Controls.Add(this.dfsLog);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dffOverwrite);
            this.Controls.Add(this.dfsDestination);
            this.Controls.Add(this.dfsSource);
            this.Controls.Add(this.btnSimulate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.TextBox dfsSource;
        private System.Windows.Forms.TextBox dfsDestination;
        private System.Windows.Forms.CheckBox dffOverwrite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox dfsLog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dfsFolder;
    }
}

