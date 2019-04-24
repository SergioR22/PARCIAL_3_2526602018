namespace Parcial3_2526602018
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datosDelEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionMatematicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operacionMatematicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 232);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(430, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelEstudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datosDelEstudianteToolStripMenuItem
            // 
            this.datosDelEstudianteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionMatematicaToolStripMenuItem,
            this.operacionMatematicasToolStripMenuItem});
            this.datosDelEstudianteToolStripMenuItem.Name = "datosDelEstudianteToolStripMenuItem";
            this.datosDelEstudianteToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.datosDelEstudianteToolStripMenuItem.Text = "Ver 2 Opciones";
            // 
            // operacionMatematicaToolStripMenuItem
            // 
            this.operacionMatematicaToolStripMenuItem.Name = "operacionMatematicaToolStripMenuItem";
            this.operacionMatematicaToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.operacionMatematicaToolStripMenuItem.Text = "Datos del Estudiante";
            this.operacionMatematicaToolStripMenuItem.Click += new System.EventHandler(this.operacionMatematicaToolStripMenuItem_Click);
            // 
            // operacionMatematicasToolStripMenuItem
            // 
            this.operacionMatematicasToolStripMenuItem.Name = "operacionMatematicasToolStripMenuItem";
            this.operacionMatematicasToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.operacionMatematicasToolStripMenuItem.Text = "Calculo Porcentaje";
            this.operacionMatematicasToolStripMenuItem.Click += new System.EventHandler(this.operacionMatematicasToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 254);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MDIParent1";
            this.Text = "Formulario 2";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datosDelEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionMatematicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operacionMatematicasToolStripMenuItem;
    }
}



