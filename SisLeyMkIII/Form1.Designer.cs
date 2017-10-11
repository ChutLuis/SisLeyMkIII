namespace SisLeyMkIII
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leyesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.usuario_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ley_crear = new System.Windows.Forms.ToolStripMenuItem();
            this.ley_modificar = new System.Windows.Forms.ToolStripMenuItem();
            this.ley_eliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoLey = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamoStack = new System.Windows.Forms.ToolStripMenuItem();
            this.infoLey = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.leyesToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.informacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuario_crear,
            this.usuario_modificar,
            this.usuario_eliminar});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // leyesToolStripMenuItem
            // 
            this.leyesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ley_crear,
            this.ley_modificar,
            this.ley_eliminar});
            this.leyesToolStripMenuItem.Name = "leyesToolStripMenuItem";
            this.leyesToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.leyesToolStripMenuItem.Text = "Leyes";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prestamoLey,
            this.prestamoStack});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoLey,
            this.infoStack});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // usuario_crear
            // 
            this.usuario_crear.Name = "usuario_crear";
            this.usuario_crear.Size = new System.Drawing.Size(152, 22);
            this.usuario_crear.Text = "Crear";
            this.usuario_crear.Click += new System.EventHandler(this.usuario_crear_Click);
            // 
            // usuario_modificar
            // 
            this.usuario_modificar.Name = "usuario_modificar";
            this.usuario_modificar.Size = new System.Drawing.Size(152, 22);
            this.usuario_modificar.Text = "Modificar";
            this.usuario_modificar.Click += new System.EventHandler(this.usuario_modificar_Click);
            // 
            // usuario_eliminar
            // 
            this.usuario_eliminar.Name = "usuario_eliminar";
            this.usuario_eliminar.Size = new System.Drawing.Size(152, 22);
            this.usuario_eliminar.Text = "Eliminar";
            this.usuario_eliminar.Click += new System.EventHandler(this.usuario_eliminar_Click);
            // 
            // ley_crear
            // 
            this.ley_crear.Name = "ley_crear";
            this.ley_crear.Size = new System.Drawing.Size(152, 22);
            this.ley_crear.Text = "Crear";
            this.ley_crear.Click += new System.EventHandler(this.ley_crear_Click);
            // 
            // ley_modificar
            // 
            this.ley_modificar.Name = "ley_modificar";
            this.ley_modificar.Size = new System.Drawing.Size(152, 22);
            this.ley_modificar.Text = "Modificar";
            this.ley_modificar.Click += new System.EventHandler(this.ley_modificar_Click);
            // 
            // ley_eliminar
            // 
            this.ley_eliminar.Name = "ley_eliminar";
            this.ley_eliminar.Size = new System.Drawing.Size(152, 22);
            this.ley_eliminar.Text = "Eliminar";
            this.ley_eliminar.Click += new System.EventHandler(this.ley_eliminar_Click);
            // 
            // prestamoLey
            // 
            this.prestamoLey.Name = "prestamoLey";
            this.prestamoLey.Size = new System.Drawing.Size(155, 22);
            this.prestamoLey.Text = "Prestamo Ley";
            this.prestamoLey.Click += new System.EventHandler(this.prestamoLey_Click);
            // 
            // prestamoStack
            // 
            this.prestamoStack.Name = "prestamoStack";
            this.prestamoStack.Size = new System.Drawing.Size(155, 22);
            this.prestamoStack.Text = "Prestamo Stack";
            this.prestamoStack.Click += new System.EventHandler(this.prestamoStack_Click);
            // 
            // infoLey
            // 
            this.infoLey.Name = "infoLey";
            this.infoLey.Size = new System.Drawing.Size(152, 22);
            this.infoLey.Text = "Info Ley";
            this.infoLey.Click += new System.EventHandler(this.infoLey_Click);
            // 
            // infoStack
            // 
            this.infoStack.Name = "infoStack";
            this.infoStack.Size = new System.Drawing.Size(152, 22);
            this.infoStack.Text = "Info Stack";
            this.infoStack.Click += new System.EventHandler(this.infoStack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 495);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuario_crear;
        private System.Windows.Forms.ToolStripMenuItem usuario_modificar;
        private System.Windows.Forms.ToolStripMenuItem usuario_eliminar;
        private System.Windows.Forms.ToolStripMenuItem leyesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ley_crear;
        private System.Windows.Forms.ToolStripMenuItem ley_modificar;
        private System.Windows.Forms.ToolStripMenuItem ley_eliminar;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamoLey;
        private System.Windows.Forms.ToolStripMenuItem prestamoStack;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoLey;
        private System.Windows.Forms.ToolStripMenuItem infoStack;
    }
}

