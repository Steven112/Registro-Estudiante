namespace RegistroEstudiante4_9
{
    partial class MainFrom
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
            this.components = new System.ComponentModel.Container();
            this.MyerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MymenuStrip = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Aviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).BeginInit();
            this.MymenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyerrorProvider
            // 
            this.MyerrorProvider.ContainerControl = this;
            // 
            // MymenuStrip
            // 
            this.MymenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.consultaToolStripMenuItem});
            this.MymenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MymenuStrip.Name = "MymenuStrip";
            this.MymenuStrip.Size = new System.Drawing.Size(615, 24);
            this.MymenuStrip.TabIndex = 0;
            this.MymenuStrip.Text = "MymenuStrip";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroEstudianteToolStripMenuItem});
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // registroEstudianteToolStripMenuItem
            // 
            this.registroEstudianteToolStripMenuItem.Name = "registroEstudianteToolStripMenuItem";
            this.registroEstudianteToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.registroEstudianteToolStripMenuItem.Text = "Registro Estudiante";
            this.registroEstudianteToolStripMenuItem.Click += new System.EventHandler(this.RegistroEstudianteToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // Aviso
            // 
            this.Aviso.AutoSize = true;
            this.Aviso.Location = new System.Drawing.Point(71, 177);
            this.Aviso.Name = "Aviso";
            this.Aviso.Size = new System.Drawing.Size(460, 13);
            this.Aviso.TabIndex = 1;
            this.Aviso.Text = "Saludos Profesor, este es mi registro estudiante hay agregados desde el ID 3 hast" +
    "a el 7, gracias.";
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 379);
            this.Controls.Add(this.Aviso);
            this.Controls.Add(this.MymenuStrip);
            this.MainMenuStrip = this.MymenuStrip;
            this.Name = "MainFrom";
            this.Text = "MaiForm";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MyerrorProvider)).EndInit();
            this.MymenuStrip.ResumeLayout(false);
            this.MymenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider MyerrorProvider;
        private System.Windows.Forms.MenuStrip MymenuStrip;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.Label Aviso;
    }
}

