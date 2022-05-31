
namespace Perceptron
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
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLR = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEpocas = new System.Windows.Forms.Label();
            this.numericUpDownEpocas = new System.Windows.Forms.NumericUpDown();
            this.buttonIniciar = new System.Windows.Forms.Button();
            this.buttonPesos = new System.Windows.Forms.Button();
            this.labelW0 = new System.Windows.Forms.Label();
            this.labelW1 = new System.Windows.Forms.Label();
            this.labelW2 = new System.Windows.Forms.Label();
            this.buttonEvaluar = new System.Windows.Forms.Button();
            this.listBoxEntradas = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(500, 500);
            this.pictureBoxCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCanvas.TabIndex = 0;
            this.pictureBoxCanvas.TabStop = false;
            this.pictureBoxCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCanvas_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownLR);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.labelEpocas);
            this.groupBox2.Controls.Add(this.numericUpDownEpocas);
            this.groupBox2.Controls.Add(this.buttonIniciar);
            this.groupBox2.Controls.Add(this.buttonPesos);
            this.groupBox2.Location = new System.Drawing.Point(544, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 154);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // numericUpDownLR
            // 
            this.numericUpDownLR.DecimalPlaces = 2;
            this.numericUpDownLR.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownLR.Location = new System.Drawing.Point(117, 116);
            this.numericUpDownLR.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLR.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownLR.Name = "numericUpDownLR";
            this.numericUpDownLR.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownLR.TabIndex = 5;
            this.numericUpDownLR.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "LR";
            // 
            // labelEpocas
            // 
            this.labelEpocas.AutoSize = true;
            this.labelEpocas.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEpocas.Location = new System.Drawing.Point(23, 81);
            this.labelEpocas.Name = "labelEpocas";
            this.labelEpocas.Size = new System.Drawing.Size(68, 15);
            this.labelEpocas.TabIndex = 3;
            this.labelEpocas.Text = "No. Epocas";
            // 
            // numericUpDownEpocas
            // 
            this.numericUpDownEpocas.Location = new System.Drawing.Point(117, 80);
            this.numericUpDownEpocas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEpocas.Name = "numericUpDownEpocas";
            this.numericUpDownEpocas.Size = new System.Drawing.Size(70, 20);
            this.numericUpDownEpocas.TabIndex = 2;
            this.numericUpDownEpocas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonIniciar
            // 
            this.buttonIniciar.Location = new System.Drawing.Point(117, 29);
            this.buttonIniciar.Name = "buttonIniciar";
            this.buttonIniciar.Size = new System.Drawing.Size(75, 23);
            this.buttonIniciar.TabIndex = 1;
            this.buttonIniciar.Text = "Iniciar";
            this.buttonIniciar.UseVisualStyleBackColor = true;
            this.buttonIniciar.Click += new System.EventHandler(this.buttonIniciar_Click);
            // 
            // buttonPesos
            // 
            this.buttonPesos.Location = new System.Drawing.Point(16, 29);
            this.buttonPesos.Name = "buttonPesos";
            this.buttonPesos.Size = new System.Drawing.Size(75, 23);
            this.buttonPesos.TabIndex = 0;
            this.buttonPesos.Text = "Pesos";
            this.buttonPesos.UseVisualStyleBackColor = true;
            this.buttonPesos.Click += new System.EventHandler(this.buttonPesos_Click);
            // 
            // labelW0
            // 
            this.labelW0.AutoSize = true;
            this.labelW0.Location = new System.Drawing.Point(541, 196);
            this.labelW0.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW0.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW0.Name = "labelW0";
            this.labelW0.Size = new System.Drawing.Size(50, 13);
            this.labelW0.TabIndex = 5;
            this.labelW0.Text = "W0";
            // 
            // labelW1
            // 
            this.labelW1.AutoSize = true;
            this.labelW1.Location = new System.Drawing.Point(623, 196);
            this.labelW1.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW1.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW1.Name = "labelW1";
            this.labelW1.Size = new System.Drawing.Size(50, 13);
            this.labelW1.TabIndex = 6;
            this.labelW1.Text = "W1";
            // 
            // labelW2
            // 
            this.labelW2.AutoSize = true;
            this.labelW2.Location = new System.Drawing.Point(703, 196);
            this.labelW2.MaximumSize = new System.Drawing.Size(50, 13);
            this.labelW2.MinimumSize = new System.Drawing.Size(50, 13);
            this.labelW2.Name = "labelW2";
            this.labelW2.Size = new System.Drawing.Size(50, 13);
            this.labelW2.TabIndex = 7;
            this.labelW2.Text = "W2";
            // 
            // buttonEvaluar
            // 
            this.buttonEvaluar.Location = new System.Drawing.Point(608, 234);
            this.buttonEvaluar.Name = "buttonEvaluar";
            this.buttonEvaluar.Size = new System.Drawing.Size(75, 23);
            this.buttonEvaluar.TabIndex = 8;
            this.buttonEvaluar.Text = "Evaluar";
            this.buttonEvaluar.UseVisualStyleBackColor = true;
            this.buttonEvaluar.Visible = false;
            this.buttonEvaluar.Click += new System.EventHandler(this.buttonEvaluar_Click);
            // 
            // listBoxEntradas
            // 
            this.listBoxEntradas.FormattingEnabled = true;
            this.listBoxEntradas.Location = new System.Drawing.Point(544, 280);
            this.listBoxEntradas.Name = "listBoxEntradas";
            this.listBoxEntradas.Size = new System.Drawing.Size(209, 225);
            this.listBoxEntradas.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 525);
            this.Controls.Add(this.listBoxEntradas);
            this.Controls.Add(this.buttonEvaluar);
            this.Controls.Add(this.labelW2);
            this.Controls.Add(this.labelW1);
            this.Controls.Add(this.labelW0);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Name = "Form1";
            this.Text = "Perceptron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpocas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEpocas;
        private System.Windows.Forms.NumericUpDown numericUpDownEpocas;
        private System.Windows.Forms.Button buttonIniciar;
        private System.Windows.Forms.Button buttonPesos;
        private System.Windows.Forms.NumericUpDown numericUpDownLR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelW0;
        private System.Windows.Forms.Label labelW1;
        private System.Windows.Forms.Label labelW2;
        private System.Windows.Forms.Button buttonEvaluar;
        private System.Windows.Forms.ListBox listBoxEntradas;
    }
}

