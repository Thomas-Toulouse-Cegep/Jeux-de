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
            this.btnBrasser.Location = new System.Drawing.Point(228, 401);
            this.btnBrasser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrasser.Name = "btnBrasser";
            this.btnBrasser.Size = new System.Drawing.Size(298, 40);
            this.btnBrasser.TabIndex = 0;
            this.btnBrasser.Text = "Brasser!";
            this.btnBrasser.UseVisualStyleBackColor = true;
            this.btnBrasser.Click += new System.EventHandler(this.btnBrasser_Click);
            // 
            // picBoxDe
            // 
            this.picBoxDe.Location = new System.Drawing.Point(182, 89);
            this.picBoxDe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBoxDe.Name = "picBoxDe";
            this.picBoxDe.Size = new System.Drawing.Size(374, 287);
            this.picBoxDe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxDe.TabIndex = 1;
            this.picBoxDe.TabStop = false;
            // 
            // TyperPoint
            // 
            this.TyperPoint.AutoSize = true;
            this.TyperPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TyperPoint.Location = new System.Drawing.Point(10, 7);
            this.TyperPoint.Name = "TyperPoint";
            this.TyperPoint.Size = new System.Drawing.Size(45, 21);
            this.TyperPoint.TabIndex = 2;
            this.TyperPoint.Text = "Type:";
            // 
            // lbPoint
            // 
            this.lbPoint.AutoSize = true;
            this.lbPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPoint.Location = new System.Drawing.Point(228, 7);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.Size = new System.Drawing.Size(48, 21);
            this.lbPoint.TabIndex = 3;
            this.lbPoint.Text = "Point:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(66, 4);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(148, 29);
            this.txtType.TabIndex = 4;
            // 
            // txtPoint
            // 
            this.txtPoint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPoint.Location = new System.Drawing.Point(282, 7);
            this.txtPoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.Size = new System.Drawing.Size(148, 29);
            this.txtPoint.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 452);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.TyperPoint);
            this.Controls.Add(this.picBoxDe);
            this.Controls.Add(this.btnBrasser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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