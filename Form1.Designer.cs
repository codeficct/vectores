namespace Vectores
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countPrimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMaxNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getMinNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.descargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ordenarVectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(304, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(430, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "n1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "b";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuVectorToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(753, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuVectorToolStripMenuItem
            // 
            this.menuVectorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.mostrarDatosToolStripMenuItem,
            this.countPrimeToolStripMenuItem,
            this.getMaxNumberToolStripMenuItem,
            this.getMinNumberToolStripMenuItem});
            this.menuVectorToolStripMenuItem.Name = "menuVectorToolStripMenuItem";
            this.menuVectorToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.menuVectorToolStripMenuItem.Text = "Menu vector";
            // 
            // cargarToolStripMenuItem
            // 
            this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
            this.cargarToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cargarToolStripMenuItem.Text = "cargar";
            this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
            // 
            // mostrarDatosToolStripMenuItem
            // 
            this.mostrarDatosToolStripMenuItem.Name = "mostrarDatosToolStripMenuItem";
            this.mostrarDatosToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.mostrarDatosToolStripMenuItem.Text = "mostrar datos";
            this.mostrarDatosToolStripMenuItem.Click += new System.EventHandler(this.mostrarDatosToolStripMenuItem_Click);
            // 
            // countPrimeToolStripMenuItem
            // 
            this.countPrimeToolStripMenuItem.Name = "countPrimeToolStripMenuItem";
            this.countPrimeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.countPrimeToolStripMenuItem.Text = "Count Prime";
            this.countPrimeToolStripMenuItem.Click += new System.EventHandler(this.countPrimeToolStripMenuItem_Click);
            // 
            // getMaxNumberToolStripMenuItem
            // 
            this.getMaxNumberToolStripMenuItem.Name = "getMaxNumberToolStripMenuItem";
            this.getMaxNumberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.getMaxNumberToolStripMenuItem.Text = "Get Max Number";
            this.getMaxNumberToolStripMenuItem.Click += new System.EventHandler(this.getMaxNumberToolStripMenuItem_Click);
            // 
            // getMinNumberToolStripMenuItem
            // 
            this.getMinNumberToolStripMenuItem.Name = "getMinNumberToolStripMenuItem";
            this.getMinNumberToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.getMinNumberToolStripMenuItem.Text = "Get Min Number";
            this.getMinNumberToolStripMenuItem.Click += new System.EventHandler(this.getMinNumberToolStripMenuItem_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem1,
            this.descargarToolStripMenuItem,
            this.ordenarVectorToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.menu2ToolStripMenuItem.Text = "Menu 2";
            // 
            // cargarToolStripMenuItem1
            // 
            this.cargarToolStripMenuItem1.Name = "cargarToolStripMenuItem1";
            this.cargarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cargarToolStripMenuItem1.Text = "cargar";
            // 
            // descargarToolStripMenuItem
            // 
            this.descargarToolStripMenuItem.Name = "descargarToolStripMenuItem";
            this.descargarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.descargarToolStripMenuItem.Text = "Descargar";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(197, 237);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(292, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "resultado";
            // 
            // ordenarVectorToolStripMenuItem
            // 
            this.ordenarVectorToolStripMenuItem.Name = "ordenarVectorToolStripMenuItem";
            this.ordenarVectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenarVectorToolStripMenuItem.Text = "Ordenar Vector";
            this.ordenarVectorToolStripMenuItem.Click += new System.EventHandler(this.ordenarVectorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 387);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuVectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarDatosToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem countPrimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMaxNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getMinNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem descargarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenarVectorToolStripMenuItem;
    }
}

