
namespace WindowsBibleReadingPlan
{
    partial class UserInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInterface));
            this.uxDate = new System.Windows.Forms.Label();
            this.uxTimeLine = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNewReadingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOldReadingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetReadingPlanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxAllowExtraReading = new System.Windows.Forms.ToolStripMenuItem();
            this.setBibleVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allowExtraReadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAtStartUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uxReading = new System.Windows.Forms.Label();
            this.uxRead = new System.Windows.Forms.Button();
            this.uxReadAhead = new System.Windows.Forms.Button();
            this.uxDidntRead = new System.Windows.Forms.Button();
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxGoRead = new System.Windows.Forms.Button();
            this.uxDidntReadAhead = new System.Windows.Forms.Button();
            this.selectNewReadingPlanButton = new System.Windows.Forms.Button();
            this.selectOldReadingPlanButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxDate
            // 
            this.uxDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxDate.AutoSize = true;
            this.uxDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDate.Location = new System.Drawing.Point(257, 53);
            this.uxDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxDate.Name = "uxDate";
            this.uxDate.Size = new System.Drawing.Size(71, 30);
            this.uxDate.TabIndex = 2;
            this.uxDate.Text = "Today";
            this.uxDate.Visible = false;
            // 
            // uxTimeLine
            // 
            this.uxTimeLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxTimeLine.AutoSize = true;
            this.uxTimeLine.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxTimeLine.Location = new System.Drawing.Point(204, 89);
            this.uxTimeLine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxTimeLine.Name = "uxTimeLine";
            this.uxTimeLine.Size = new System.Drawing.Size(155, 35);
            this.uxTimeLine.TabIndex = 3;
            this.uxTimeLine.Text = "On Schedule";
            this.uxTimeLine.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.uxAllowExtraReading});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(578, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectNewReadingPlanToolStripMenuItem,
            this.selectOldReadingPlanToolStripMenuItem,
            this.resetReadingPlanToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectNewReadingPlanToolStripMenuItem
            // 
            this.selectNewReadingPlanToolStripMenuItem.Name = "selectNewReadingPlanToolStripMenuItem";
            this.selectNewReadingPlanToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.selectNewReadingPlanToolStripMenuItem.Text = "Select New Reading Plan";
            this.selectNewReadingPlanToolStripMenuItem.Click += new System.EventHandler(this.selectNewReadingPlanToolStripMenuItem_Click);
            // 
            // selectOldReadingPlanToolStripMenuItem
            // 
            this.selectOldReadingPlanToolStripMenuItem.Name = "selectOldReadingPlanToolStripMenuItem";
            this.selectOldReadingPlanToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.selectOldReadingPlanToolStripMenuItem.Text = "Select Old Reading Plan";
            this.selectOldReadingPlanToolStripMenuItem.Click += new System.EventHandler(this.selectOldReadingPlanToolStripMenuItem_Click);
            // 
            // resetReadingPlanToolStripMenuItem
            // 
            this.resetReadingPlanToolStripMenuItem.Name = "resetReadingPlanToolStripMenuItem";
            this.resetReadingPlanToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.resetReadingPlanToolStripMenuItem.Text = "Reset Reading Plan";
            this.resetReadingPlanToolStripMenuItem.Click += new System.EventHandler(this.resetReadingPlanToolStripMenuItem_Click);
            // 
            // uxAllowExtraReading
            // 
            this.uxAllowExtraReading.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setBibleVersionToolStripMenuItem,
            this.allowExtraReadingToolStripMenuItem,
            this.runAtStartUpToolStripMenuItem});
            this.uxAllowExtraReading.Name = "uxAllowExtraReading";
            this.uxAllowExtraReading.Size = new System.Drawing.Size(76, 24);
            this.uxAllowExtraReading.Text = "Settings";
            // 
            // setBibleVersionToolStripMenuItem
            // 
            this.setBibleVersionToolStripMenuItem.Name = "setBibleVersionToolStripMenuItem";
            this.setBibleVersionToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.setBibleVersionToolStripMenuItem.Text = "Set Bible Version";
            this.setBibleVersionToolStripMenuItem.Click += new System.EventHandler(this.setBibleVersionToolStripMenuItem_Click);
            // 
            // allowExtraReadingToolStripMenuItem
            // 
            this.allowExtraReadingToolStripMenuItem.Name = "allowExtraReadingToolStripMenuItem";
            this.allowExtraReadingToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.allowExtraReadingToolStripMenuItem.Text = "Allow Extra Reading";
            this.allowExtraReadingToolStripMenuItem.Click += new System.EventHandler(this.allowExtraReadingToolStripMenuItem_Click);
            // 
            // runAtStartUpToolStripMenuItem
            // 
            this.runAtStartUpToolStripMenuItem.Name = "runAtStartUpToolStripMenuItem";
            this.runAtStartUpToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.runAtStartUpToolStripMenuItem.Text = "Run at Start Up";
            this.runAtStartUpToolStripMenuItem.Click += new System.EventHandler(this.runAtStartUpToolStripMenuItem_Click);
            // 
            // uxReading
            // 
            this.uxReading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxReading.AutoSize = true;
            this.uxReading.Location = new System.Drawing.Point(242, 136);
            this.uxReading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uxReading.Name = "uxReading";
            this.uxReading.Size = new System.Drawing.Size(80, 28);
            this.uxReading.TabIndex = 6;
            this.uxReading.Text = "Passage";
            this.uxReading.Visible = false;
            // 
            // uxRead
            // 
            this.uxRead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxRead.Enabled = false;
            this.uxRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxRead.Location = new System.Drawing.Point(392, 240);
            this.uxRead.Margin = new System.Windows.Forms.Padding(4);
            this.uxRead.Name = "uxRead";
            this.uxRead.Size = new System.Drawing.Size(186, 41);
            this.uxRead.TabIndex = 8;
            this.uxRead.Text = "Read";
            this.uxRead.UseVisualStyleBackColor = true;
            this.uxRead.Visible = false;
            this.uxRead.Click += new System.EventHandler(this.uxRead_Click);
            // 
            // uxReadAhead
            // 
            this.uxReadAhead.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uxReadAhead.Enabled = false;
            this.uxReadAhead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxReadAhead.Location = new System.Drawing.Point(392, 289);
            this.uxReadAhead.Margin = new System.Windows.Forms.Padding(4);
            this.uxReadAhead.Name = "uxReadAhead";
            this.uxReadAhead.Size = new System.Drawing.Size(186, 41);
            this.uxReadAhead.TabIndex = 9;
            this.uxReadAhead.Text = "Read Ahead";
            this.uxReadAhead.UseVisualStyleBackColor = true;
            this.uxReadAhead.Visible = false;
            this.uxReadAhead.Click += new System.EventHandler(this.uxReadAhead_Click);
            // 
            // uxDidntRead
            // 
            this.uxDidntRead.Enabled = false;
            this.uxDidntRead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDidntRead.Location = new System.Drawing.Point(0, 241);
            this.uxDidntRead.Margin = new System.Windows.Forms.Padding(4);
            this.uxDidntRead.Name = "uxDidntRead";
            this.uxDidntRead.Size = new System.Drawing.Size(186, 41);
            this.uxDidntRead.TabIndex = 10;
            this.uxDidntRead.Text = "Didn\'t Read";
            this.uxDidntRead.UseVisualStyleBackColor = true;
            this.uxDidntRead.Visible = false;
            this.uxDidntRead.Click += new System.EventHandler(this.uxDidntRead_Click);
            // 
            // uxOpenFileDialog
            // 
            this.uxOpenFileDialog.FileName = "openFileDialog1";
            // 
            // uxGoRead
            // 
            this.uxGoRead.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.uxGoRead.Enabled = false;
            this.uxGoRead.Location = new System.Drawing.Point(213, 241);
            this.uxGoRead.Margin = new System.Windows.Forms.Padding(4);
            this.uxGoRead.Name = "uxGoRead";
            this.uxGoRead.Size = new System.Drawing.Size(156, 89);
            this.uxGoRead.TabIndex = 11;
            this.uxGoRead.Text = "Go Read";
            this.uxGoRead.UseVisualStyleBackColor = true;
            this.uxGoRead.Visible = false;
            this.uxGoRead.Click += new System.EventHandler(this.uxGoRead_Click);
            // 
            // uxDidntReadAhead
            // 
            this.uxDidntReadAhead.Enabled = false;
            this.uxDidntReadAhead.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.uxDidntReadAhead.Location = new System.Drawing.Point(0, 289);
            this.uxDidntReadAhead.Name = "uxDidntReadAhead";
            this.uxDidntReadAhead.Size = new System.Drawing.Size(186, 41);
            this.uxDidntReadAhead.TabIndex = 12;
            this.uxDidntReadAhead.Text = "Didn\'t Read Ahead";
            this.uxDidntReadAhead.UseVisualStyleBackColor = true;
            this.uxDidntReadAhead.Visible = false;
            this.uxDidntReadAhead.Click += new System.EventHandler(this.uxDidntReadAhead_Click);
            // 
            // selectNewReadingPlanButton
            // 
            this.selectNewReadingPlanButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectNewReadingPlanButton.Location = new System.Drawing.Point(13, 74);
            this.selectNewReadingPlanButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectNewReadingPlanButton.Name = "selectNewReadingPlanButton";
            this.selectNewReadingPlanButton.Size = new System.Drawing.Size(552, 106);
            this.selectNewReadingPlanButton.TabIndex = 13;
            this.selectNewReadingPlanButton.Text = "Select New Reading Plan";
            this.selectNewReadingPlanButton.UseVisualStyleBackColor = true;
            this.selectNewReadingPlanButton.Click += new System.EventHandler(this.selectNewReadingPlanButton_Click);
            // 
            // selectOldReadingPlanButton
            // 
            this.selectOldReadingPlanButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectOldReadingPlanButton.Location = new System.Drawing.Point(13, 188);
            this.selectOldReadingPlanButton.Margin = new System.Windows.Forms.Padding(4);
            this.selectOldReadingPlanButton.Name = "selectOldReadingPlanButton";
            this.selectOldReadingPlanButton.Size = new System.Drawing.Size(552, 104);
            this.selectOldReadingPlanButton.TabIndex = 14;
            this.selectOldReadingPlanButton.Text = "Select Old Reading Plan";
            this.selectOldReadingPlanButton.UseVisualStyleBackColor = true;
            this.selectOldReadingPlanButton.Click += new System.EventHandler(this.selectOldReadingPlanButton_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 344);
            this.Controls.Add(this.selectOldReadingPlanButton);
            this.Controls.Add(this.selectNewReadingPlanButton);
            this.Controls.Add(this.uxDidntReadAhead);
            this.Controls.Add(this.uxGoRead);
            this.Controls.Add(this.uxDidntRead);
            this.Controls.Add(this.uxReadAhead);
            this.Controls.Add(this.uxRead);
            this.Controls.Add(this.uxReading);
            this.Controls.Add(this.uxTimeLine);
            this.Controls.Add(this.uxDate);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserInterface";
            this.Text = "Bible Reading Plan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxDate;
        private System.Windows.Forms.Label uxTimeLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNewReadingPlanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOldReadingPlanToolStripMenuItem;
        private System.Windows.Forms.Label uxReading;
        private System.Windows.Forms.Button uxRead;
        private System.Windows.Forms.Button uxReadAhead;
        private System.Windows.Forms.Button uxDidntRead;
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Button uxGoRead;
        private System.Windows.Forms.ToolStripMenuItem uxAllowExtraReading;
        private System.Windows.Forms.ToolStripMenuItem setBibleVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetReadingPlanToolStripMenuItem;
        private System.Windows.Forms.Button uxDidntReadAhead;
        private System.Windows.Forms.ToolStripMenuItem allowExtraReadingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAtStartUpToolStripMenuItem;
        private System.Windows.Forms.Button selectNewReadingPlanButton;
        private System.Windows.Forms.Button selectOldReadingPlanButton;
    }
}

