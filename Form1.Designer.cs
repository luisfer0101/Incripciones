namespace Incripciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonInscripciones = new System.Windows.Forms.Button();
            this.buttonReporte = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonInscripciones
            // 
            this.buttonInscripciones.Location = new System.Drawing.Point(134, 108);
            this.buttonInscripciones.Name = "buttonInscripciones";
            this.buttonInscripciones.Size = new System.Drawing.Size(143, 66);
            this.buttonInscripciones.TabIndex = 0;
            this.buttonInscripciones.Text = "Inscripciones";
            this.buttonInscripciones.UseVisualStyleBackColor = true;
            this.buttonInscripciones.Click += new System.EventHandler(this.buttonInscripciones_Click);
            // 
            // buttonReporte
            // 
            this.buttonReporte.Location = new System.Drawing.Point(134, 213);
            this.buttonReporte.Name = "buttonReporte";
            this.buttonReporte.Size = new System.Drawing.Size(143, 66);
            this.buttonReporte.TabIndex = 1;
            this.buttonReporte.Text = "Reporte";
            this.buttonReporte.UseVisualStyleBackColor = true;
            this.buttonReporte.Click += new System.EventHandler(this.buttonReporte_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(134, 314);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(143, 66);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Registro de inscripciones.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonReporte);
            this.Controls.Add(this.buttonInscripciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInscripciones;
        private System.Windows.Forms.Button buttonReporte;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Label label1;
    }
}

