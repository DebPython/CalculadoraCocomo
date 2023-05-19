namespace CalculadoraCocomo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLineasCod = new System.Windows.Forms.TextBox();
            this.txtEntradaFlu = new System.Windows.Forms.TextBox();
            this.txtSalidasFlu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataCocomo = new System.Windows.Forms.DataGridView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtchm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estimado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCocomo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLineasCod
            // 
            this.txtLineasCod.Location = new System.Drawing.Point(212, 49);
            this.txtLineasCod.Name = "txtLineasCod";
            this.txtLineasCod.Size = new System.Drawing.Size(100, 20);
            this.txtLineasCod.TabIndex = 0;
            // 
            // txtEntradaFlu
            // 
            this.txtEntradaFlu.Location = new System.Drawing.Point(212, 100);
            this.txtEntradaFlu.Name = "txtEntradaFlu";
            this.txtEntradaFlu.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaFlu.TabIndex = 1;
            // 
            // txtSalidasFlu
            // 
            this.txtSalidasFlu.Location = new System.Drawing.Point(479, 103);
            this.txtSalidasFlu.Name = "txtSalidasFlu";
            this.txtSalidasFlu.Size = new System.Drawing.Size(100, 20);
            this.txtSalidasFlu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lineas de Código L";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Flujos de Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flujos de Salida";
            // 
            // dataCocomo
            // 
            this.dataCocomo.AllowUserToAddRows = false;
            this.dataCocomo.AllowUserToDeleteRows = false;
            this.dataCocomo.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dataCocomo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCocomo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCocomo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Formula,
            this.Calculo,
            this.Estimado});
            this.dataCocomo.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataCocomo.Location = new System.Drawing.Point(29, 180);
            this.dataCocomo.Name = "dataCocomo";
            this.dataCocomo.ReadOnly = true;
            this.dataCocomo.Size = new System.Drawing.Size(643, 197);
            this.dataCocomo.TabIndex = 6;
            this.dataCocomo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(237, 424);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(375, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpir";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // txtchm
            // 
            this.txtchm.Location = new System.Drawing.Point(479, 48);
            this.txtchm.Name = "txtchm";
            this.txtchm.Size = new System.Drawing.Size(100, 20);
            this.txtchm.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Costo Hombre Maquina";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 200;
            // 
            // Formula
            // 
            this.Formula.HeaderText = "Formula";
            this.Formula.Name = "Formula";
            this.Formula.ReadOnly = true;
            this.Formula.Width = 140;
            // 
            // Calculo
            // 
            this.Calculo.HeaderText = "Calculo";
            this.Calculo.Name = "Calculo";
            this.Calculo.ReadOnly = true;
            this.Calculo.Width = 70;
            // 
            // Estimado
            // 
            this.Estimado.HeaderText = "Estimado";
            this.Estimado.Name = "Estimado";
            this.Estimado.ReadOnly = true;
            this.Estimado.Width = 190;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 514);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtchm);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.dataCocomo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSalidasFlu);
            this.Controls.Add(this.txtEntradaFlu);
            this.Controls.Add(this.txtLineasCod);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataCocomo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLineasCod;
        private System.Windows.Forms.TextBox txtEntradaFlu;
        private System.Windows.Forms.TextBox txtSalidasFlu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataCocomo;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtchm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimado;
    }
}

