namespace Practica1
{
    partial class Principal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nóminaProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maquinaBancariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bibliotecaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresaDeViajesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del realizador :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jorge Eduardo Alvarez Castaño";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nóminaProfesoresToolStripMenuItem,
            this.maquinaBancariaToolStripMenuItem,
            this.bibliotecaToolStripMenuItem,
            this.empresaDeViajesToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programasToolStripMenuItem.Text = "Programas";
            // 
            // nóminaProfesoresToolStripMenuItem
            // 
            this.nóminaProfesoresToolStripMenuItem.Image = global::Practica1.Properties.Resources.Ingresar;
            this.nóminaProfesoresToolStripMenuItem.Name = "nóminaProfesoresToolStripMenuItem";
            this.nóminaProfesoresToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D1)));
            this.nóminaProfesoresToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.nóminaProfesoresToolStripMenuItem.Text = "Nómina Profesores";
            this.nóminaProfesoresToolStripMenuItem.Click += new System.EventHandler(this.nóminaProfesoresToolStripMenuItem_Click);
            // 
            // maquinaBancariaToolStripMenuItem
            // 
            this.maquinaBancariaToolStripMenuItem.Name = "maquinaBancariaToolStripMenuItem";
            this.maquinaBancariaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D2)));
            this.maquinaBancariaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.maquinaBancariaToolStripMenuItem.Text = "Maquina Bancaria";
            this.maquinaBancariaToolStripMenuItem.Click += new System.EventHandler(this.maquinaBancariaToolStripMenuItem_Click);
            // 
            // bibliotecaToolStripMenuItem
            // 
            this.bibliotecaToolStripMenuItem.Name = "bibliotecaToolStripMenuItem";
            this.bibliotecaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bibliotecaToolStripMenuItem.Text = "Biblioteca";
            this.bibliotecaToolStripMenuItem.Click += new System.EventHandler(this.bibliotecaToolStripMenuItem_Click);
            // 
            // empresaDeViajesToolStripMenuItem
            // 
            this.empresaDeViajesToolStripMenuItem.Name = "empresaDeViajesToolStripMenuItem";
            this.empresaDeViajesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.empresaDeViajesToolStripMenuItem.Text = "Empresa De Viajes";
            this.empresaDeViajesToolStripMenuItem.Click += new System.EventHandler(this.empresaDeViajesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(598, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Practica1.Properties.Resources._238870;
            this.ClientSize = new System.Drawing.Size(839, 653);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nóminaProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maquinaBancariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bibliotecaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresaDeViajesToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

