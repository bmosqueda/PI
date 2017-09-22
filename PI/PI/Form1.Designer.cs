namespace PI
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
            this.bttnA = new System.Windows.Forms.Button();
            this.bttnB = new System.Windows.Forms.Button();
            this.bttnC = new System.Windows.Forms.Button();
            this.bttnD = new System.Windows.Forms.Button();
            this.lblNumPregunta = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.bttnIniciar = new System.Windows.Forms.Button();
            this.bttnSigPregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttnA
            // 
            this.bttnA.Location = new System.Drawing.Point(74, 227);
            this.bttnA.Name = "bttnA";
            this.bttnA.Size = new System.Drawing.Size(75, 75);
            this.bttnA.TabIndex = 0;
            this.bttnA.Text = "A";
            this.bttnA.UseVisualStyleBackColor = true;
            this.bttnA.Click += new System.EventHandler(this.bttnA_Click);
            // 
            // bttnB
            // 
            this.bttnB.Location = new System.Drawing.Point(200, 227);
            this.bttnB.Name = "bttnB";
            this.bttnB.Size = new System.Drawing.Size(75, 75);
            this.bttnB.TabIndex = 0;
            this.bttnB.Text = "B";
            this.bttnB.UseVisualStyleBackColor = true;
            this.bttnB.Click += new System.EventHandler(this.bttnB_Click);
            // 
            // bttnC
            // 
            this.bttnC.Location = new System.Drawing.Point(320, 227);
            this.bttnC.Name = "bttnC";
            this.bttnC.Size = new System.Drawing.Size(75, 75);
            this.bttnC.TabIndex = 0;
            this.bttnC.Text = "C";
            this.bttnC.UseVisualStyleBackColor = true;
            this.bttnC.Click += new System.EventHandler(this.bttnC_Click);
            // 
            // bttnD
            // 
            this.bttnD.Location = new System.Drawing.Point(441, 227);
            this.bttnD.Name = "bttnD";
            this.bttnD.Size = new System.Drawing.Size(75, 75);
            this.bttnD.TabIndex = 0;
            this.bttnD.Text = "D";
            this.bttnD.UseVisualStyleBackColor = true;
            this.bttnD.Click += new System.EventHandler(this.bttnD_Click);
            // 
            // lblNumPregunta
            // 
            this.lblNumPregunta.AutoSize = true;
            this.lblNumPregunta.Location = new System.Drawing.Point(71, 23);
            this.lblNumPregunta.Name = "lblNumPregunta";
            this.lblNumPregunta.Size = new System.Drawing.Size(137, 17);
            this.lblNumPregunta.TabIndex = 1;
            this.lblNumPregunta.Text = "numero de pregunta";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.Location = new System.Drawing.Point(71, 109);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(66, 17);
            this.lblPregunta.TabIndex = 2;
            this.lblPregunta.Text = "Pregunta";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(255, 109);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(67, 17);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "resultado";
            // 
            // bttnIniciar
            // 
            this.bttnIniciar.Location = new System.Drawing.Point(74, 227);
            this.bttnIniciar.Name = "bttnIniciar";
            this.bttnIniciar.Size = new System.Drawing.Size(442, 75);
            this.bttnIniciar.TabIndex = 4;
            this.bttnIniciar.Text = "Iniciar";
            this.bttnIniciar.UseVisualStyleBackColor = true;
            this.bttnIniciar.Click += new System.EventHandler(this.bttnIniciar_Click);
            // 
            // bttnSigPregunta
            // 
            this.bttnSigPregunta.Location = new System.Drawing.Point(74, 227);
            this.bttnSigPregunta.Name = "bttnSigPregunta";
            this.bttnSigPregunta.Size = new System.Drawing.Size(442, 75);
            this.bttnSigPregunta.TabIndex = 5;
            this.bttnSigPregunta.Text = "Siguiente Pregunta";
            this.bttnSigPregunta.UseVisualStyleBackColor = true;
            this.bttnSigPregunta.Click += new System.EventHandler(this.bttnSigPregunta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 447);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblNumPregunta);
            this.Controls.Add(this.bttnD);
            this.Controls.Add(this.bttnC);
            this.Controls.Add(this.bttnB);
            this.Controls.Add(this.bttnA);
            this.Controls.Add(this.bttnSigPregunta);
            this.Controls.Add(this.bttnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnA;
        private System.Windows.Forms.Button bttnB;
        private System.Windows.Forms.Button bttnC;
        private System.Windows.Forms.Button bttnD;
        private System.Windows.Forms.Label lblNumPregunta;
        private System.Windows.Forms.Label lblPregunta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button bttnIniciar;
        private System.Windows.Forms.Button bttnSigPregunta;
    }
}

