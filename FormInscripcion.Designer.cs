namespace Incripciones
{
    partial class FormInscripcion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.comboBoxAlumno = new System.Windows.Forms.ComboBox();
            this.comboBoxTaller = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre alumno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre taller:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha inscripción:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(172, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 22);
            this.textBox3.TabIndex = 5;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(34, 272);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(112, 44);
            this.buttonGuardar.TabIndex = 6;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // comboBoxAlumno
            // 
            this.comboBoxAlumno.FormattingEnabled = true;
            this.comboBoxAlumno.Location = new System.Drawing.Point(172, 63);
            this.comboBoxAlumno.Name = "comboBoxAlumno";
            this.comboBoxAlumno.Size = new System.Drawing.Size(406, 24);
            this.comboBoxAlumno.TabIndex = 7;
            // 
            // comboBoxTaller
            // 
            this.comboBoxTaller.FormattingEnabled = true;
            this.comboBoxTaller.Location = new System.Drawing.Point(172, 147);
            this.comboBoxTaller.Name = "comboBoxTaller";
            this.comboBoxTaller.Size = new System.Drawing.Size(406, 24);
            this.comboBoxTaller.TabIndex = 8;
            // 
            // FormInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.comboBoxTaller);
            this.Controls.Add(this.comboBoxAlumno);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormInscripcion";
            this.Text = "FormInscripcion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.ComboBox comboBoxAlumno;
        private System.Windows.Forms.ComboBox comboBoxTaller;
    }
}