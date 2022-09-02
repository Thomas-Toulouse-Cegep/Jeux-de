namespace Jeuxdée
{
    partial class Form1
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
            this.btnBrasser = new System.Windows.Forms.Button();
            this.picBoxDe = new System.Windows.Forms.PictureBox();
            this.TyperPoint = new System.Windows.Forms.Label();
            this.lbPoint = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPoint = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBrasser
            // 
            this.btnBrasser.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrasser.Location = new System.Drawing.Point(295, 537);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(340, 54);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser!";
            this.btnBrasser.UseVisualStyleBackColor = true;
            this.btnBrasser.Click += new System.EventHandler(this.btnBrasser_Click);
            // 
            // picBoxDe
            // 
            this.picBoxDe.Location = new System.Drawing.Point(261, 164);
            this.picBoxDe.Name = "picBoxDe";
            this.picBoxDe.Size = new System.Drawing.Size(419, 363);
            this.picBoxDe.TabIndex = 1;
            this.picBoxDe.TabStop = false;
            // 
            // TyperPoint
            // 
            this.TyperPoint.AutoSize = true;
            this.TyperPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TyperPoint.Location = new System.Drawing.Point(12, 9);
            this.TyperPoint.Name = "TyperPoint";
            this.TyperPoint.Size = new System.Drawing.Size(57, 28);
            this.TyperPoint.TabIndex = 2;
            this.TyperPoint.Text = "Type:";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPoint.Location = new System.Drawing.Point(8, 64);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(61, 28);
            this.lbPoint.TabIndex = 3;
            this.lbPoint.Text = "Point:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(75, 6);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(169, 34);
            this.txtType.TabIndex = 4;
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoint.Location = new System.Drawing.Point(75, 61);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(169, 34);
            this.txtPoint.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 603);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.TyperPoint);
            this.Controls.Add(this.picBoxDe);
            this.Controls.Add(this.btnBrasser);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBrasser;
        private PictureBox picBoxDe;
        private Label TyperPoint;
        private Label lbPoint;
        private TextBox txtType;
        private TextBox txtPoint;
    }
}