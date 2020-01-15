namespace JSConsoleTemplate
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
            this.lblInst = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.Location = new System.Drawing.Point(35, 28);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(322, 17);
            this.lblInst.TabIndex = 0;
            this.lblInst.Text = "Push Button to Clear/Create JS Console Template";
            // 
            // btnMain
            // 
            this.btnMain.Location = new System.Drawing.Point(121, 77);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(132, 32);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Run";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 136);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.lblInst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInst;
        private System.Windows.Forms.Button btnMain;
    }
}

