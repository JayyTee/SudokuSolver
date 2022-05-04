
namespace SudokuSolver
{
    partial class frmMain
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
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.lblOutputLocation = new System.Windows.Forms.Label();
            this.txtOutputDirectory = new System.Windows.Forms.TextBox();
            this.btnOutputBrowser = new System.Windows.Forms.Button();
            this.btnInputBrowser = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFileLocation.Location = new System.Drawing.Point(21, 37);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(198, 27);
            this.lblFileLocation.TabIndex = 0;
            this.lblFileLocation.Text = "Sudoku File Location";
            // 
            // txtInputPath
            // 
            this.txtInputPath.Enabled = false;
            this.txtInputPath.Location = new System.Drawing.Point(240, 33);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.ReadOnly = true;
            this.txtInputPath.Size = new System.Drawing.Size(430, 31);
            this.txtInputPath.TabIndex = 1;
            // 
            // lblOutputLocation
            // 
            this.lblOutputLocation.AutoSize = true;
            this.lblOutputLocation.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutputLocation.Location = new System.Drawing.Point(21, 119);
            this.lblOutputLocation.Name = "lblOutputLocation";
            this.lblOutputLocation.Size = new System.Drawing.Size(159, 27);
            this.lblOutputLocation.TabIndex = 2;
            this.lblOutputLocation.Text = "Output Location";
            // 
            // txtOutputDirectory
            // 
            this.txtOutputDirectory.Enabled = false;
            this.txtOutputDirectory.Location = new System.Drawing.Point(240, 115);
            this.txtOutputDirectory.Name = "txtOutputDirectory";
            this.txtOutputDirectory.ReadOnly = true;
            this.txtOutputDirectory.Size = new System.Drawing.Size(430, 31);
            this.txtOutputDirectory.TabIndex = 3;
            // 
            // btnOutputBrowser
            // 
            this.btnOutputBrowser.Location = new System.Drawing.Point(704, 115);
            this.btnOutputBrowser.Name = "btnOutputBrowser";
            this.btnOutputBrowser.Size = new System.Drawing.Size(112, 34);
            this.btnOutputBrowser.TabIndex = 4;
            this.btnOutputBrowser.Text = "Browse";
            this.btnOutputBrowser.UseVisualStyleBackColor = true;
            this.btnOutputBrowser.Click += new System.EventHandler(this.btnOutputBrowser_Click);
            // 
            // btnInputBrowser
            // 
            this.btnInputBrowser.Location = new System.Drawing.Point(704, 31);
            this.btnInputBrowser.Name = "btnInputBrowser";
            this.btnInputBrowser.Size = new System.Drawing.Size(112, 34);
            this.btnInputBrowser.TabIndex = 5;
            this.btnInputBrowser.Text = "Browse";
            this.btnInputBrowser.UseVisualStyleBackColor = true;
            this.btnInputBrowser.Click += new System.EventHandler(this.btnInputBrowser_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(347, 185);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(180, 34);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Let\'s Play!";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 240);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnInputBrowser);
            this.Controls.Add(this.btnOutputBrowser);
            this.Controls.Add(this.txtOutputDirectory);
            this.Controls.Add(this.lblOutputLocation);
            this.Controls.Add(this.txtInputPath);
            this.Controls.Add(this.lblFileLocation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "Let\'s Play Sudoku!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Label lblOutputLocation;
        private System.Windows.Forms.TextBox txtOutputDirectory;
        private System.Windows.Forms.Button btnOutputBrowser;
        private System.Windows.Forms.Button btnInputBrowser;
        private System.Windows.Forms.Button btnPlay;
    }
}

