namespace Use_Case_Helper
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
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.groupBoxElementen = new System.Windows.Forms.GroupBox();
            this.groupBoxModes = new System.Windows.Forms.GroupBox();
            this.radioButtonActor = new System.Windows.Forms.RadioButton();
            this.radioButtonUseCase = new System.Windows.Forms.RadioButton();
            this.radioButtonLine = new System.Windows.Forms.RadioButton();
            this.radioButtonCreate = new System.Windows.Forms.RadioButton();
            this.radioButtonSelect = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxElementen.SuspendLayout();
            this.groupBoxModes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(484, 39);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(91, 34);
            this.buttonClearAll.TabIndex = 0;
            this.buttonClearAll.Text = "Clear all";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(484, 102);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(91, 33);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // groupBoxElementen
            // 
            this.groupBoxElementen.Controls.Add(this.radioButtonLine);
            this.groupBoxElementen.Controls.Add(this.radioButtonUseCase);
            this.groupBoxElementen.Controls.Add(this.radioButtonActor);
            this.groupBoxElementen.Location = new System.Drawing.Point(12, 12);
            this.groupBoxElementen.Name = "groupBoxElementen";
            this.groupBoxElementen.Size = new System.Drawing.Size(152, 149);
            this.groupBoxElementen.TabIndex = 2;
            this.groupBoxElementen.TabStop = false;
            this.groupBoxElementen.Text = "Elementen";
            // 
            // groupBoxModes
            // 
            this.groupBoxModes.Controls.Add(this.radioButtonSelect);
            this.groupBoxModes.Controls.Add(this.radioButtonCreate);
            this.groupBoxModes.Location = new System.Drawing.Point(190, 12);
            this.groupBoxModes.Name = "groupBoxModes";
            this.groupBoxModes.Size = new System.Drawing.Size(157, 149);
            this.groupBoxModes.TabIndex = 3;
            this.groupBoxModes.TabStop = false;
            this.groupBoxModes.Text = "Modes";
            // 
            // radioButtonActor
            // 
            this.radioButtonActor.AutoSize = true;
            this.radioButtonActor.Location = new System.Drawing.Point(19, 27);
            this.radioButtonActor.Name = "radioButtonActor";
            this.radioButtonActor.Size = new System.Drawing.Size(62, 21);
            this.radioButtonActor.TabIndex = 0;
            this.radioButtonActor.TabStop = true;
            this.radioButtonActor.Text = "Actor";
            this.radioButtonActor.UseVisualStyleBackColor = true;
            // 
            // radioButtonUseCase
            // 
            this.radioButtonUseCase.AutoSize = true;
            this.radioButtonUseCase.Location = new System.Drawing.Point(19, 65);
            this.radioButtonUseCase.Name = "radioButtonUseCase";
            this.radioButtonUseCase.Size = new System.Drawing.Size(90, 21);
            this.radioButtonUseCase.TabIndex = 1;
            this.radioButtonUseCase.TabStop = true;
            this.radioButtonUseCase.Text = "Use Case";
            this.radioButtonUseCase.UseVisualStyleBackColor = true;
            // 
            // radioButtonLine
            // 
            this.radioButtonLine.AutoSize = true;
            this.radioButtonLine.Location = new System.Drawing.Point(19, 102);
            this.radioButtonLine.Name = "radioButtonLine";
            this.radioButtonLine.Size = new System.Drawing.Size(56, 21);
            this.radioButtonLine.TabIndex = 2;
            this.radioButtonLine.TabStop = true;
            this.radioButtonLine.Text = "Line";
            this.radioButtonLine.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreate
            // 
            this.radioButtonCreate.AutoSize = true;
            this.radioButtonCreate.Location = new System.Drawing.Point(21, 27);
            this.radioButtonCreate.Name = "radioButtonCreate";
            this.radioButtonCreate.Size = new System.Drawing.Size(71, 21);
            this.radioButtonCreate.TabIndex = 0;
            this.radioButtonCreate.TabStop = true;
            this.radioButtonCreate.Text = "Create";
            this.radioButtonCreate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSelect
            // 
            this.radioButtonSelect.AutoSize = true;
            this.radioButtonSelect.Location = new System.Drawing.Point(21, 66);
            this.radioButtonSelect.Name = "radioButtonSelect";
            this.radioButtonSelect.Size = new System.Drawing.Size(68, 21);
            this.radioButtonSelect.TabIndex = 1;
            this.radioButtonSelect.TabStop = true;
            this.radioButtonSelect.Text = "Select";
            this.radioButtonSelect.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(12, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 277);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxModes);
            this.Controls.Add(this.groupBoxElementen);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonClearAll);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.groupBoxElementen.ResumeLayout(false);
            this.groupBoxElementen.PerformLayout();
            this.groupBoxModes.ResumeLayout(false);
            this.groupBoxModes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.GroupBox groupBoxElementen;
        private System.Windows.Forms.RadioButton radioButtonLine;
        private System.Windows.Forms.RadioButton radioButtonUseCase;
        private System.Windows.Forms.RadioButton radioButtonActor;
        private System.Windows.Forms.GroupBox groupBoxModes;
        private System.Windows.Forms.RadioButton radioButtonSelect;
        private System.Windows.Forms.RadioButton radioButtonCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

