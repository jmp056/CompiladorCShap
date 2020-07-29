namespace CompiladorCShap
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CodigoTextBox = new System.Windows.Forms.TextBox();
            this.ResultadoTextBox = new System.Windows.Forms.TextBox();
            this.CompilarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CodigoTextBox
            // 
            this.CodigoTextBox.Location = new System.Drawing.Point(10, 10);
            this.CodigoTextBox.Multiline = true;
            this.CodigoTextBox.Name = "CodigoTextBox";
            this.CodigoTextBox.Size = new System.Drawing.Size(600, 350);
            this.CodigoTextBox.TabIndex = 0;
            this.CodigoTextBox.TextChanged += new System.EventHandler(this.CodigoTextBox_TextChanged);
            // 
            // ResultadoTextBox
            // 
            this.ResultadoTextBox.Location = new System.Drawing.Point(60, 370);
            this.ResultadoTextBox.Multiline = true;
            this.ResultadoTextBox.Name = "ResultadoTextBox";
            this.ResultadoTextBox.ReadOnly = true;
            this.ResultadoTextBox.Size = new System.Drawing.Size(550, 40);
            this.ResultadoTextBox.TabIndex = 1;
            // 
            // CompilarButton
            // 
            this.CompilarButton.Image = ((System.Drawing.Image)(resources.GetObject("CompilarButton.Image")));
            this.CompilarButton.Location = new System.Drawing.Point(10, 369);
            this.CompilarButton.Name = "CompilarButton";
            this.CompilarButton.Size = new System.Drawing.Size(40, 40);
            this.CompilarButton.TabIndex = 2;
            this.CompilarButton.UseVisualStyleBackColor = true;
            this.CompilarButton.Click += new System.EventHandler(this.CompilarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 423);
            this.Controls.Add(this.CompilarButton);
            this.Controls.Add(this.ResultadoTextBox);
            this.Controls.Add(this.CodigoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Comilador de CSharp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodigoTextBox;
        private System.Windows.Forms.TextBox ResultadoTextBox;
        private System.Windows.Forms.Button CompilarButton;
    }
}

