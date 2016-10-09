namespace WindowsFormsApplication3
{
    partial class BreachOneQuestion
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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxLineNumber = new System.Windows.Forms.TextBox();
            this.labelCode = new System.Windows.Forms.Label();
            this.lineNoSelect = new System.Windows.Forms.ComboBox();
            this.labelOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatAppearance.BorderSize = 0;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.ForeColor = System.Drawing.Color.DarkBlue;
            this.buttonSubmit.Location = new System.Drawing.Point(743, 512);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(187, 60);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxLineNumber
            // 
            this.textBoxLineNumber.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBoxLineNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLineNumber.Location = new System.Drawing.Point(717, 459);
            this.textBoxLineNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLineNumber.Name = "textBoxLineNumber";
            this.textBoxLineNumber.Size = new System.Drawing.Size(241, 19);
            this.textBoxLineNumber.TabIndex = 1;
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.BackColor = System.Drawing.Color.Transparent;
            this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCode.Location = new System.Drawing.Point(29, 46);
            this.labelCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(69, 16);
            this.labelCode.TabIndex = 2;
            this.labelCode.Text = "Question";
            this.labelCode.Click += new System.EventHandler(this.labelCode_Click);
            // 
            // lineNoSelect
            // 
            this.lineNoSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lineNoSelect.BackColor = System.Drawing.Color.RoyalBlue;
            this.lineNoSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineNoSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineNoSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineNoSelect.FormattingEnabled = true;
            this.lineNoSelect.Location = new System.Drawing.Point(789, 389);
            this.lineNoSelect.Margin = new System.Windows.Forms.Padding(2);
            this.lineNoSelect.Name = "lineNoSelect";
            this.lineNoSelect.Size = new System.Drawing.Size(92, 21);
            this.lineNoSelect.TabIndex = 3;
            this.lineNoSelect.SelectedIndexChanged += new System.EventHandler(this.lineNoSelect_SelectedIndexChanged);
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.BackColor = System.Drawing.Color.Transparent;
            this.labelOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOutput.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOutput.Location = new System.Drawing.Point(701, 76);
            this.labelOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(52, 16);
            this.labelOutput.TabIndex = 4;
            this.labelOutput.Text = "Output";
            this.labelOutput.Click += new System.EventHandler(this.labelOutput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(701, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Expected Output:";
            // 
            // BreachOneQuestion
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Resources.Images.ImageResuorce.graphic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.lineNoSelect);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.textBoxLineNumber);
            this.Controls.Add(this.buttonSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BreachOneQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxLineNumber;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.ComboBox lineNoSelect;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label label1;
    }
}

