namespace ConsultorioDraMartinez
{
    partial class MenuPrincipal
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
            this.btnGestCitas = new System.Windows.Forms.Button();
            this.btnGestPacie = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestCitas
            // 
            this.btnGestCitas.Location = new System.Drawing.Point(297, 79);
            this.btnGestCitas.Name = "btnGestCitas";
            this.btnGestCitas.Size = new System.Drawing.Size(227, 43);
            this.btnGestCitas.TabIndex = 0;
            this.btnGestCitas.Text = "Gestionar Citas";
            this.btnGestCitas.UseVisualStyleBackColor = true;
            this.btnGestCitas.Click += new System.EventHandler(this.btnGestCitas_Click);
            // 
            // btnGestPacie
            // 
            this.btnGestPacie.Location = new System.Drawing.Point(297, 166);
            this.btnGestPacie.Name = "btnGestPacie";
            this.btnGestPacie.Size = new System.Drawing.Size(227, 43);
            this.btnGestPacie.TabIndex = 1;
            this.btnGestPacie.Text = "Gestionar Pacientes";
            this.btnGestPacie.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(227, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Administración";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnGestPacie);
            this.Controls.Add(this.btnGestCitas);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestCitas;
        private System.Windows.Forms.Button btnGestPacie;
        private System.Windows.Forms.Button button3;
    }
}