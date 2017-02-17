namespace Use_Case_Helper
{
    partial class ActorNaam
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
            this.labelActorNaam = new System.Windows.Forms.Label();
            this.textBoxActorNaam = new System.Windows.Forms.TextBox();
            this.buttonGebruikNaam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelActorNaam
            // 
            this.labelActorNaam.AutoSize = true;
            this.labelActorNaam.Location = new System.Drawing.Point(33, 41);
            this.labelActorNaam.Name = "labelActorNaam";
            this.labelActorNaam.Size = new System.Drawing.Size(145, 17);
            this.labelActorNaam.TabIndex = 0;
            this.labelActorNaam.Text = "Vul naam van actor in";
            // 
            // textBoxActorNaam
            // 
            this.textBoxActorNaam.Location = new System.Drawing.Point(36, 81);
            this.textBoxActorNaam.Name = "textBoxActorNaam";
            this.textBoxActorNaam.Size = new System.Drawing.Size(142, 22);
            this.textBoxActorNaam.TabIndex = 1;
            // 
            // buttonGebruikNaam
            // 
            this.buttonGebruikNaam.Location = new System.Drawing.Point(203, 75);
            this.buttonGebruikNaam.Name = "buttonGebruikNaam";
            this.buttonGebruikNaam.Size = new System.Drawing.Size(113, 35);
            this.buttonGebruikNaam.TabIndex = 2;
            this.buttonGebruikNaam.Text = "Gebruik naam";
            this.buttonGebruikNaam.UseVisualStyleBackColor = true;
            this.buttonGebruikNaam.Click += new System.EventHandler(this.buttonGebruikNaam_Click);
            // 
            // ActorNaam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 170);
            this.Controls.Add(this.buttonGebruikNaam);
            this.Controls.Add(this.textBoxActorNaam);
            this.Controls.Add(this.labelActorNaam);
            this.Name = "ActorNaam";
            this.Text = "ActorNaam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActorNaam;
        private System.Windows.Forms.TextBox textBoxActorNaam;
        private System.Windows.Forms.Button buttonGebruikNaam;
    }
}