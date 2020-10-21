namespace Practica1
{
    partial class Nomina
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
            this.txHoras1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.gbHoras = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txHoras6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txHoras5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txHoras4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txHoras3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txHoras2 = new System.Windows.Forms.TextBox();
            this.txSalida = new System.Windows.Forms.TextBox();
            this.gbresultado = new System.Windows.Forms.GroupBox();
            this.btTerminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.rbA = new System.Windows.Forms.RadioButton();
            this.rbB = new System.Windows.Forms.RadioButton();
            this.rbC = new System.Windows.Forms.RadioButton();
            this.rbD = new System.Windows.Forms.RadioButton();
            this.gbHoras.SuspendLayout();
            this.gbresultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nomina Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(279, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de horas dictadas en el mes 1 : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txHoras1
            // 
            this.txHoras1.Location = new System.Drawing.Point(377, 37);
            this.txHoras1.Name = "txHoras1";
            this.txHoras1.Size = new System.Drawing.Size(123, 20);
            this.txHoras1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor a cancelar al profesor : ";
            // 
            // btCalcular
            // 
            this.btCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCalcular.Location = new System.Drawing.Point(425, 194);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 5;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbHoras
            // 
            this.gbHoras.Controls.Add(this.rbD);
            this.gbHoras.Controls.Add(this.rbC);
            this.gbHoras.Controls.Add(this.rbB);
            this.gbHoras.Controls.Add(this.rbA);
            this.gbHoras.Controls.Add(this.label9);
            this.gbHoras.Controls.Add(this.button1);
            this.gbHoras.Controls.Add(this.btCalcular);
            this.gbHoras.Controls.Add(this.label8);
            this.gbHoras.Controls.Add(this.txHoras6);
            this.gbHoras.Controls.Add(this.label7);
            this.gbHoras.Controls.Add(this.txHoras5);
            this.gbHoras.Controls.Add(this.label6);
            this.gbHoras.Controls.Add(this.txHoras4);
            this.gbHoras.Controls.Add(this.label5);
            this.gbHoras.Controls.Add(this.txHoras3);
            this.gbHoras.Controls.Add(this.label4);
            this.gbHoras.Controls.Add(this.txHoras2);
            this.gbHoras.Controls.Add(this.label2);
            this.gbHoras.Controls.Add(this.txHoras1);
            this.gbHoras.Location = new System.Drawing.Point(23, 50);
            this.gbHoras.Name = "gbHoras";
            this.gbHoras.Size = new System.Drawing.Size(567, 252);
            this.gbHoras.TabIndex = 7;
            this.gbHoras.TabStop = false;
            this.gbHoras.Text = "Cantidad de Horas";
            this.gbHoras.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Categoria del Profesor : ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(394, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Nuevo Profesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(279, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cantidad de horas dictadas en el mes 6 : ";
            // 
            // txHoras6
            // 
            this.txHoras6.Location = new System.Drawing.Point(377, 168);
            this.txHoras6.Name = "txHoras6";
            this.txHoras6.Size = new System.Drawing.Size(123, 20);
            this.txHoras6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(279, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "Cantidad de horas dictadas en el mes 5 : ";
            // 
            // txHoras5
            // 
            this.txHoras5.Location = new System.Drawing.Point(377, 142);
            this.txHoras5.Name = "txHoras5";
            this.txHoras5.Size = new System.Drawing.Size(123, 20);
            this.txHoras5.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Cantidad de horas dictadas en el mes 4 : ";
            // 
            // txHoras4
            // 
            this.txHoras4.Location = new System.Drawing.Point(377, 115);
            this.txHoras4.Name = "txHoras4";
            this.txHoras4.Size = new System.Drawing.Size(123, 20);
            this.txHoras4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(279, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad de horas dictadas en el mes 3 : ";
            // 
            // txHoras3
            // 
            this.txHoras3.Location = new System.Drawing.Point(377, 88);
            this.txHoras3.Name = "txHoras3";
            this.txHoras3.Size = new System.Drawing.Size(123, 20);
            this.txHoras3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad de horas dictadas en el mes 2 : ";
            // 
            // txHoras2
            // 
            this.txHoras2.Location = new System.Drawing.Point(377, 63);
            this.txHoras2.Name = "txHoras2";
            this.txHoras2.Size = new System.Drawing.Size(123, 20);
            this.txHoras2.TabIndex = 4;
            // 
            // txSalida
            // 
            this.txSalida.Location = new System.Drawing.Point(29, 37);
            this.txSalida.Multiline = true;
            this.txSalida.Name = "txSalida";
            this.txSalida.Size = new System.Drawing.Size(452, 106);
            this.txSalida.TabIndex = 9;
            this.txSalida.TextChanged += new System.EventHandler(this.txSalida_TextChanged);
            // 
            // gbresultado
            // 
            this.gbresultado.Controls.Add(this.btSalir);
            this.gbresultado.Controls.Add(this.txSalida);
            this.gbresultado.Controls.Add(this.label3);
            this.gbresultado.Location = new System.Drawing.Point(12, 327);
            this.gbresultado.Name = "gbresultado";
            this.gbresultado.Size = new System.Drawing.Size(569, 161);
            this.gbresultado.TabIndex = 9;
            this.gbresultado.TabStop = false;
            this.gbresultado.Text = "Resultado";
            this.gbresultado.Visible = false;
            // 
            // btTerminar
            // 
            this.btTerminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTerminar.Location = new System.Drawing.Point(417, 308);
            this.btTerminar.Name = "btTerminar";
            this.btTerminar.Size = new System.Drawing.Size(157, 23);
            this.btTerminar.TabIndex = 10;
            this.btTerminar.Text = "Terminar proceso";
            this.btTerminar.UseVisualStyleBackColor = true;
            this.btTerminar.Click += new System.EventHandler(this.btTerminar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(487, 68);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // rbA
            // 
            this.rbA.AutoSize = true;
            this.rbA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbA.Location = new System.Drawing.Point(225, 211);
            this.rbA.Name = "rbA";
            this.rbA.Size = new System.Drawing.Size(33, 17);
            this.rbA.TabIndex = 14;
            this.rbA.Text = "A";
            this.rbA.UseVisualStyleBackColor = true;
            this.rbA.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbB
            // 
            this.rbB.AutoSize = true;
            this.rbB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbB.Location = new System.Drawing.Point(264, 211);
            this.rbB.Name = "rbB";
            this.rbB.Size = new System.Drawing.Size(33, 17);
            this.rbB.TabIndex = 15;
            this.rbB.Text = "B";
            this.rbB.UseVisualStyleBackColor = true;
            // 
            // rbC
            // 
            this.rbC.AutoSize = true;
            this.rbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbC.Location = new System.Drawing.Point(303, 211);
            this.rbC.Name = "rbC";
            this.rbC.Size = new System.Drawing.Size(33, 17);
            this.rbC.TabIndex = 16;
            this.rbC.Text = "C";
            this.rbC.UseVisualStyleBackColor = true;
            // 
            // rbD
            // 
            this.rbD.AutoSize = true;
            this.rbD.Checked = true;
            this.rbD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbD.Location = new System.Drawing.Point(342, 210);
            this.rbD.Name = "rbD";
            this.rbD.Size = new System.Drawing.Size(34, 17);
            this.rbD.TabIndex = 17;
            this.rbD.TabStop = true;
            this.rbD.Text = "D";
            this.rbD.UseVisualStyleBackColor = true;
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 500);
            this.Controls.Add(this.btTerminar);
            this.Controls.Add(this.gbresultado);
            this.Controls.Add(this.gbHoras);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.gbHoras.ResumeLayout(false);
            this.gbHoras.PerformLayout();
            this.gbresultado.ResumeLayout(false);
            this.gbresultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txHoras1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btCalcular;
        private System.Windows.Forms.GroupBox gbHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txHoras6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txHoras5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txHoras4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txHoras3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txHoras2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txSalida;
        private System.Windows.Forms.GroupBox gbresultado;
        private System.Windows.Forms.Button btTerminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.RadioButton rbA;
        private System.Windows.Forms.RadioButton rbD;
        private System.Windows.Forms.RadioButton rbC;
        private System.Windows.Forms.RadioButton rbB;
    }
}