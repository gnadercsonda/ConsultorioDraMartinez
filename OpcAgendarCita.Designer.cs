namespace ConsultorioDraMartinez
{
    partial class OpcAgendarCita
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
            this.mtCalend = new System.Windows.Forms.MonthCalendar();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.dtpHour = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLasNa = new System.Windows.Forms.TextBox();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grCita = new System.Windows.Forms.GroupBox();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.cmbEspec = new System.Windows.Forms.ComboBox();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.btnBuscId = new System.Windows.Forms.Button();
            this.grCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtCalend
            // 
            this.mtCalend.Location = new System.Drawing.Point(507, 82);
            this.mtCalend.Name = "mtCalend";
            this.mtCalend.TabIndex = 0;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(98, 28);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(130, 20);
            this.dtpDate.TabIndex = 1;
            // 
            // dtpHour
            // 
            this.dtpHour.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHour.Location = new System.Drawing.Point(98, 64);
            this.dtpHour.Name = "dtpHour";
            this.dtpHour.Size = new System.Drawing.Size(130, 20);
            this.dtpHour.TabIndex = 2;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 105);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(258, 20);
            this.txtId.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(319, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtLasNa
            // 
            this.txtLasNa.Location = new System.Drawing.Point(98, 183);
            this.txtLasNa.Name = "txtLasNa";
            this.txtLasNa.Size = new System.Drawing.Size(319, 20);
            this.txtLasNa.TabIndex = 5;
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(156, 360);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(149, 36);
            this.btnAgendar.TabIndex = 6;
            this.btnAgendar.Text = "Agendar Cita";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Documento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellidos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Categoría:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Profesional:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Especialidad:";
            // 
            // grCita
            // 
            this.grCita.Controls.Add(this.btnBuscId);
            this.grCita.Controls.Add(this.cmbProf);
            this.grCita.Controls.Add(this.cmbEspec);
            this.grCita.Controls.Add(this.cmbCateg);
            this.grCita.Controls.Add(this.label8);
            this.grCita.Controls.Add(this.dtpDate);
            this.grCita.Controls.Add(this.label7);
            this.grCita.Controls.Add(this.dtpHour);
            this.grCita.Controls.Add(this.label6);
            this.grCita.Controls.Add(this.txtId);
            this.grCita.Controls.Add(this.label5);
            this.grCita.Controls.Add(this.txtName);
            this.grCita.Controls.Add(this.label4);
            this.grCita.Controls.Add(this.txtLasNa);
            this.grCita.Controls.Add(this.label3);
            this.grCita.Controls.Add(this.label2);
            this.grCita.Controls.Add(this.label1);
            this.grCita.Location = new System.Drawing.Point(12, 12);
            this.grCita.Name = "grCita";
            this.grCita.Size = new System.Drawing.Size(430, 342);
            this.grCita.TabIndex = 18;
            this.grCita.TabStop = false;
            this.grCita.Text = "Información de la cita";
            // 
            // cmbCateg
            // 
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(98, 221);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(319, 21);
            this.cmbCateg.TabIndex = 18;
            // 
            // cmbEspec
            // 
            this.cmbEspec.FormattingEnabled = true;
            this.cmbEspec.Location = new System.Drawing.Point(98, 258);
            this.cmbEspec.Name = "cmbEspec";
            this.cmbEspec.Size = new System.Drawing.Size(319, 21);
            this.cmbEspec.TabIndex = 19;
            // 
            // cmbProf
            // 
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(98, 296);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(319, 21);
            this.cmbProf.TabIndex = 20;
            // 
            // btnBuscId
            // 
            this.btnBuscId.Location = new System.Drawing.Point(362, 105);
            this.btnBuscId.Name = "btnBuscId";
            this.btnBuscId.Size = new System.Drawing.Size(54, 23);
            this.btnBuscId.TabIndex = 21;
            this.btnBuscId.Text = "Buscar";
            this.btnBuscId.UseVisualStyleBackColor = true;
            // 
            // OpcAgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgendar);
            this.Controls.Add(this.mtCalend);
            this.Controls.Add(this.grCita);
            this.Name = "OpcAgendarCita";
            this.Text = "Agendar Cita";
            this.grCita.ResumeLayout(false);
            this.grCita.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mtCalend;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpHour;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLasNa;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grCita;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.ComboBox cmbEspec;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.Button btnBuscId;
    }
}