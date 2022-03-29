namespace Ejercicio255
{
    partial class Simulacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_distribucion_tiempo_produccion = new System.Windows.Forms.TextBox();
            this.txt_distribucion_tiempo_produccion_B = new System.Windows.Forms.TextBox();
            this.txt_distribucion_tiempo_produccion_A = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_distribucion_llegada_pedido = new System.Windows.Forms.TextBox();
            this.txt_distribucion_llegada_pedido_B = new System.Windows.Forms.TextBox();
            this.txt_distribucion_llegada_pedido_A = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_tiempo_fin_empaque = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_cantidad_pedida = new System.Windows.Forms.DataGridView();
            this.cCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cProbabilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRandMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cRandMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_grilla = new System.Windows.Forms.DataGridView();
            this.btn_simular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cantidad_pedida)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_distribucion_tiempo_produccion);
            this.groupBox1.Controls.Add(this.txt_distribucion_tiempo_produccion_B);
            this.groupBox1.Controls.Add(this.txt_distribucion_tiempo_produccion_A);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempo Produccion por item";
            // 
            // txt_distribucion_tiempo_produccion
            // 
            this.txt_distribucion_tiempo_produccion.Enabled = false;
            this.txt_distribucion_tiempo_produccion.Location = new System.Drawing.Point(95, 22);
            this.txt_distribucion_tiempo_produccion.Name = "txt_distribucion_tiempo_produccion";
            this.txt_distribucion_tiempo_produccion.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_tiempo_produccion.TabIndex = 6;
            this.txt_distribucion_tiempo_produccion.Text = "UNIFORME";
            // 
            // txt_distribucion_tiempo_produccion_B
            // 
            this.txt_distribucion_tiempo_produccion_B.Location = new System.Drawing.Point(95, 74);
            this.txt_distribucion_tiempo_produccion_B.Name = "txt_distribucion_tiempo_produccion_B";
            this.txt_distribucion_tiempo_produccion_B.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_tiempo_produccion_B.TabIndex = 5;
            // 
            // txt_distribucion_tiempo_produccion_A
            // 
            this.txt_distribucion_tiempo_produccion_A.Location = new System.Drawing.Point(95, 48);
            this.txt_distribucion_tiempo_produccion_A.Name = "txt_distribucion_tiempo_produccion_A";
            this.txt_distribucion_tiempo_produccion_A.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_tiempo_produccion_A.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "A:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distribucion:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_distribucion_llegada_pedido);
            this.groupBox2.Controls.Add(this.txt_distribucion_llegada_pedido_B);
            this.groupBox2.Controls.Add(this.txt_distribucion_llegada_pedido_A);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(204, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 103);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Llegada Pedido";
            // 
            // txt_distribucion_llegada_pedido
            // 
            this.txt_distribucion_llegada_pedido.Enabled = false;
            this.txt_distribucion_llegada_pedido.Location = new System.Drawing.Point(95, 22);
            this.txt_distribucion_llegada_pedido.Name = "txt_distribucion_llegada_pedido";
            this.txt_distribucion_llegada_pedido.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_llegada_pedido.TabIndex = 6;
            this.txt_distribucion_llegada_pedido.Text = "UNIFORME";
            // 
            // txt_distribucion_llegada_pedido_B
            // 
            this.txt_distribucion_llegada_pedido_B.Location = new System.Drawing.Point(95, 74);
            this.txt_distribucion_llegada_pedido_B.Name = "txt_distribucion_llegada_pedido_B";
            this.txt_distribucion_llegada_pedido_B.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_llegada_pedido_B.TabIndex = 5;
            // 
            // txt_distribucion_llegada_pedido_A
            // 
            this.txt_distribucion_llegada_pedido_A.Location = new System.Drawing.Point(95, 48);
            this.txt_distribucion_llegada_pedido_A.Name = "txt_distribucion_llegada_pedido_A";
            this.txt_distribucion_llegada_pedido_A.Size = new System.Drawing.Size(71, 20);
            this.txt_distribucion_llegada_pedido_A.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "B:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "A:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Distribucion:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_tiempo_fin_empaque);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(396, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 55);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tiempo Fin Empaque";
            // 
            // txt_tiempo_fin_empaque
            // 
            this.txt_tiempo_fin_empaque.Enabled = false;
            this.txt_tiempo_fin_empaque.Location = new System.Drawing.Point(95, 22);
            this.txt_tiempo_fin_empaque.Name = "txt_tiempo_fin_empaque";
            this.txt_tiempo_fin_empaque.Size = new System.Drawing.Size(151, 20);
            this.txt_tiempo_fin_empaque.TabIndex = 6;
            this.txt_tiempo_fin_empaque.Text = "90\" + (Cantidad_Pedido * 50\")";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Formula:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_cantidad_pedida);
            this.groupBox4.Location = new System.Drawing.Point(678, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(545, 146);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cantidad Pedida";
            // 
            // dgv_cantidad_pedida
            // 
            this.dgv_cantidad_pedida.AllowUserToAddRows = false;
            this.dgv_cantidad_pedida.AllowUserToDeleteRows = false;
            this.dgv_cantidad_pedida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cantidad_pedida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCantidad,
            this.cProbabilidad,
            this.cAcumulada,
            this.cRandMin,
            this.cRandMax});
            this.dgv_cantidad_pedida.Location = new System.Drawing.Point(20, 23);
            this.dgv_cantidad_pedida.Name = "dgv_cantidad_pedida";
            this.dgv_cantidad_pedida.ReadOnly = true;
            this.dgv_cantidad_pedida.RowHeadersVisible = false;
            this.dgv_cantidad_pedida.Size = new System.Drawing.Size(511, 111);
            this.dgv_cantidad_pedida.TabIndex = 0;
            // 
            // cCantidad
            // 
            this.cCantidad.HeaderText = "Cantidad";
            this.cCantidad.Name = "cCantidad";
            this.cCantidad.ReadOnly = true;
            // 
            // cProbabilidad
            // 
            this.cProbabilidad.HeaderText = "Probabilidad";
            this.cProbabilidad.Name = "cProbabilidad";
            this.cProbabilidad.ReadOnly = true;
            // 
            // cAcumulada
            // 
            this.cAcumulada.HeaderText = "Acumulada";
            this.cAcumulada.Name = "cAcumulada";
            this.cAcumulada.ReadOnly = true;
            // 
            // cRandMin
            // 
            this.cRandMin.HeaderText = "Rand Min";
            this.cRandMin.Name = "cRandMin";
            this.cRandMin.ReadOnly = true;
            // 
            // cRandMax
            // 
            this.cRandMax.HeaderText = "Rand Max";
            this.cRandMax.Name = "cRandMax";
            this.cRandMax.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_grilla);
            this.panel1.Location = new System.Drawing.Point(12, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 314);
            this.panel1.TabIndex = 9;
            // 
            // dgv_grilla
            // 
            this.dgv_grilla.AllowUserToAddRows = false;
            this.dgv_grilla.AllowUserToDeleteRows = false;
            this.dgv_grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_grilla.Location = new System.Drawing.Point(0, 0);
            this.dgv_grilla.Name = "dgv_grilla";
            this.dgv_grilla.ReadOnly = true;
            this.dgv_grilla.Size = new System.Drawing.Size(1211, 314);
            this.dgv_grilla.TabIndex = 0;
            // 
            // btn_simular
            // 
            this.btn_simular.Location = new System.Drawing.Point(12, 144);
            this.btn_simular.Name = "btn_simular";
            this.btn_simular.Size = new System.Drawing.Size(75, 23);
            this.btn_simular.TabIndex = 1;
            this.btn_simular.Text = "Simular";
            this.btn_simular.UseVisualStyleBackColor = true;
            this.btn_simular.Click += new System.EventHandler(this.Btn_simular_Click);
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 532);
            this.Controls.Add(this.btn_simular);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simulacion";
            this.Text = "Ejercicio 255";
            this.Load += new System.EventHandler(this.Simulacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cantidad_pedida)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_grilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_distribucion_tiempo_produccion;
        private System.Windows.Forms.TextBox txt_distribucion_tiempo_produccion_B;
        private System.Windows.Forms.TextBox txt_distribucion_tiempo_produccion_A;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_distribucion_llegada_pedido;
        private System.Windows.Forms.TextBox txt_distribucion_llegada_pedido_B;
        private System.Windows.Forms.TextBox txt_distribucion_llegada_pedido_A;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_tiempo_fin_empaque;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_cantidad_pedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cProbabilidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRandMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn cRandMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_grilla;
        private System.Windows.Forms.Button btn_simular;
    }
}

