namespace PerceptronSimple
{
    partial class form1
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
            this.gboxCompuerta = new System.Windows.Forms.GroupBox();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.rbtnOr = new System.Windows.Forms.RadioButton();
            this.rbtnAnd = new System.Windows.Forms.RadioButton();
            this.dGValores = new System.Windows.Forms.DataGridView();
            this.columnaX1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaX2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtEntradaFactor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntradaUmbral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntradaEpocas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEntradaW2 = new System.Windows.Forms.TextBox();
            this.txtEntradaW1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtEpocasNecesarias = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSalidaW2 = new System.Windows.Forms.TextBox();
            this.txtSalidaW1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gboxCompuerta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGValores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCompuerta
            // 
            this.gboxCompuerta.Controls.Add(this.rbtnOtro);
            this.gboxCompuerta.Controls.Add(this.rbtnOr);
            this.gboxCompuerta.Controls.Add(this.rbtnAnd);
            this.gboxCompuerta.Location = new System.Drawing.Point(12, 30);
            this.gboxCompuerta.Name = "gboxCompuerta";
            this.gboxCompuerta.Size = new System.Drawing.Size(104, 85);
            this.gboxCompuerta.TabIndex = 0;
            this.gboxCompuerta.TabStop = false;
            this.gboxCompuerta.Text = "Compuerta";
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Location = new System.Drawing.Point(29, 55);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(45, 17);
            this.rbtnOtro.TabIndex = 2;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "Otro";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // rbtnOr
            // 
            this.rbtnOr.AutoSize = true;
            this.rbtnOr.Location = new System.Drawing.Point(60, 19);
            this.rbtnOr.Name = "rbtnOr";
            this.rbtnOr.Size = new System.Drawing.Size(41, 17);
            this.rbtnOr.TabIndex = 1;
            this.rbtnOr.TabStop = true;
            this.rbtnOr.Text = "OR";
            this.rbtnOr.UseVisualStyleBackColor = true;
            this.rbtnOr.CheckedChanged += new System.EventHandler(this.Compuerta_CheckedChanged);
            // 
            // rbtnAnd
            // 
            this.rbtnAnd.AutoSize = true;
            this.rbtnAnd.Location = new System.Drawing.Point(6, 19);
            this.rbtnAnd.Name = "rbtnAnd";
            this.rbtnAnd.Size = new System.Drawing.Size(48, 17);
            this.rbtnAnd.TabIndex = 0;
            this.rbtnAnd.TabStop = true;
            this.rbtnAnd.Text = "AND";
            this.rbtnAnd.UseVisualStyleBackColor = true;
            this.rbtnAnd.CheckedChanged += new System.EventHandler(this.Compuerta_CheckedChanged);
            // 
            // dGValores
            // 
            this.dGValores.AllowUserToAddRows = false;
            this.dGValores.AllowUserToDeleteRows = false;
            this.dGValores.AllowUserToResizeColumns = false;
            this.dGValores.AllowUserToResizeRows = false;
            this.dGValores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGValores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGValores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaX1,
            this.columnaX2,
            this.columnaDX});
            this.dGValores.Location = new System.Drawing.Point(12, 121);
            this.dGValores.MultiSelect = false;
            this.dGValores.Name = "dGValores";
            this.dGValores.ReadOnly = true;
            this.dGValores.RowHeadersVisible = false;
            this.dGValores.Size = new System.Drawing.Size(104, 158);
            this.dGValores.TabIndex = 1;
            // 
            // columnaX1
            // 
            this.columnaX1.Frozen = true;
            this.columnaX1.HeaderText = "X1";
            this.columnaX1.Name = "columnaX1";
            this.columnaX1.ReadOnly = true;
            this.columnaX1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaX1.Width = 30;
            // 
            // columnaX2
            // 
            this.columnaX2.Frozen = true;
            this.columnaX2.HeaderText = "X2";
            this.columnaX2.Name = "columnaX2";
            this.columnaX2.ReadOnly = true;
            this.columnaX2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaX2.Width = 30;
            // 
            // columnaDX
            // 
            this.columnaDX.Frozen = true;
            this.columnaDX.HeaderText = "DX";
            this.columnaDX.Name = "columnaDX";
            this.columnaDX.ReadOnly = true;
            this.columnaDX.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.columnaDX.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.txtEntradaFactor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEntradaUmbral);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtEntradaEpocas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEntradaW2);
            this.groupBox1.Controls.Add(this.txtEntradaW1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(122, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 85);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores de entrada";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 26);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(123, 50);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(86, 26);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtEntradaFactor
            // 
            this.txtEntradaFactor.Location = new System.Drawing.Point(268, 18);
            this.txtEntradaFactor.Name = "txtEntradaFactor";
            this.txtEntradaFactor.Size = new System.Drawing.Size(42, 20);
            this.txtEntradaFactor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(225, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Factor";
            // 
            // txtEntradaUmbral
            // 
            this.txtEntradaUmbral.Location = new System.Drawing.Point(69, 59);
            this.txtEntradaUmbral.Name = "txtEntradaUmbral";
            this.txtEntradaUmbral.Size = new System.Drawing.Size(40, 20);
            this.txtEntradaUmbral.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Umbral";
            // 
            // txtEntradaEpocas
            // 
            this.txtEntradaEpocas.Location = new System.Drawing.Point(69, 37);
            this.txtEntradaEpocas.Name = "txtEntradaEpocas";
            this.txtEntradaEpocas.Size = new System.Drawing.Size(40, 20);
            this.txtEntradaEpocas.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Epocas";
            // 
            // txtEntradaW2
            // 
            this.txtEntradaW2.Location = new System.Drawing.Point(169, 18);
            this.txtEntradaW2.Name = "txtEntradaW2";
            this.txtEntradaW2.Size = new System.Drawing.Size(40, 20);
            this.txtEntradaW2.TabIndex = 3;
            // 
            // txtEntradaW1
            // 
            this.txtEntradaW1.Location = new System.Drawing.Point(69, 16);
            this.txtEntradaW1.Name = "txtEntradaW1";
            this.txtEntradaW1.Size = new System.Drawing.Size(40, 20);
            this.txtEntradaW1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peso w2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso w1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEpocasNecesarias);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSalidaW2);
            this.groupBox2.Controls.Add(this.txtSalidaW1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(122, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 74);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Valores de salida";
            // 
            // txtEpocasNecesarias
            // 
            this.txtEpocasNecesarias.Location = new System.Drawing.Point(158, 51);
            this.txtEpocasNecesarias.Name = "txtEpocasNecesarias";
            this.txtEpocasNecesarias.Size = new System.Drawing.Size(40, 20);
            this.txtEpocasNecesarias.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Epocas necesarias";
            // 
            // txtSalidaW2
            // 
            this.txtSalidaW2.Location = new System.Drawing.Point(257, 19);
            this.txtSalidaW2.Name = "txtSalidaW2";
            this.txtSalidaW2.Size = new System.Drawing.Size(40, 20);
            this.txtSalidaW2.TabIndex = 3;
            // 
            // txtSalidaW1
            // 
            this.txtSalidaW1.Location = new System.Drawing.Point(104, 19);
            this.txtSalidaW1.Name = "txtSalidaW1";
            this.txtSalidaW1.Size = new System.Drawing.Size(40, 20);
            this.txtSalidaW1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Peso w2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Peso w1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(454, 291);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGValores);
            this.Controls.Add(this.gboxCompuerta);
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "Perceptrón";
            this.gboxCompuerta.ResumeLayout(false);
            this.gboxCompuerta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGValores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCompuerta;
        private System.Windows.Forms.RadioButton rbtnOr;
        private System.Windows.Forms.RadioButton rbtnAnd;
        private System.Windows.Forms.DataGridView dGValores;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaX2;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDX;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEntradaFactor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntradaUmbral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntradaEpocas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEntradaW2;
        private System.Windows.Forms.TextBox txtEntradaW1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtEpocasNecesarias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSalidaW2;
        private System.Windows.Forms.TextBox txtSalidaW1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.Button button1;
    }
}

