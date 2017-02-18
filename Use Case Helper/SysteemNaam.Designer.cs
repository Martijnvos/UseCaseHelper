namespace Use_Case_Helper
{
    partial class SysteemNaam
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
            this.labelSysteemnaam = new System.Windows.Forms.Label();
            this.buttonGebruikNaam = new System.Windows.Forms.Button();
            this.textBoxSysteemnaam = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSysteemnaam
            // 
            this.labelSysteemnaam.AutoSize = true;
            this.labelSysteemnaam.Location = new System.Drawing.Point(33, 38);
            this.labelSysteemnaam.Name = "labelSysteemnaam";
            this.labelSysteemnaam.Size = new System.Drawing.Size(134, 17);
            this.labelSysteemnaam.TabIndex = 0;
            this.labelSysteemnaam.Text = "Vul systeemnaam in";
            // 
            // buttonGebruikNaam
            // 
            this.buttonGebruikNaam.Location = new System.Drawing.Point(186, 71);
            this.buttonGebruikNaam.Name = "buttonGebruikNaam";
            this.buttonGebruikNaam.Size = new System.Drawing.Size(149, 31);
            this.buttonGebruikNaam.TabIndex = 1;
            this.buttonGebruikNaam.Text = "Gebruik naam";
            this.buttonGebruikNaam.UseVisualStyleBackColor = true;
            this.buttonGebruikNaam.Click += new System.EventHandler(this.buttonGebruikNaam_Click);
            // 
            // textBoxSysteemnaam
            // 
            this.textBoxSysteemnaam.Location = new System.Drawing.Point(36, 75);
            this.textBoxSysteemnaam.Name = "textBoxSysteemnaam";
            this.textBoxSysteemnaam.Size = new System.Drawing.Size(100, 22);
            this.textBoxSysteemnaam.TabIndex = 2;
            // 
            // SysteemNaam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 156);
            this.Controls.Add(this.textBoxSysteemnaam);
            this.Controls.Add(this.buttonGebruikNaam);
            this.Controls.Add(this.labelSysteemnaam);
            this.Name = "SysteemNaam";
            this.Text = "Systeemnaam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSysteemnaam;
        private System.Windows.Forms.Button buttonGebruikNaam;
        private System.Windows.Forms.TextBox textBoxSysteemnaam;
    }
}