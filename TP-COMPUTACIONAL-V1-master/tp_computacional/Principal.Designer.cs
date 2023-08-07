namespace MamiQueTuQuiere
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelIniciarSubMenu = new System.Windows.Forms.Panel();
            this.btnTeoria = new System.Windows.Forms.Button();
            this.btnIntegrante = new System.Windows.Forms.Button();
            this.btnPrograma = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.paneLogoGrande = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelIniciarSubMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.btnSalir);
            this.panelSideMenu.Controls.Add(this.panelIniciarSubMenu);
            this.panelSideMenu.Controls.Add(this.btnIniciar);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(184, 715);
            this.panelSideMenu.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 580);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 95);
            this.panel1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(0, 675);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(184, 40);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelIniciarSubMenu
            // 
            this.panelIniciarSubMenu.Controls.Add(this.btnTeoria);
            this.panelIniciarSubMenu.Controls.Add(this.btnIntegrante);
            this.panelIniciarSubMenu.Controls.Add(this.btnPrograma);
            this.panelIniciarSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIniciarSubMenu.Location = new System.Drawing.Point(0, 259);
            this.panelIniciarSubMenu.Name = "panelIniciarSubMenu";
            this.panelIniciarSubMenu.Size = new System.Drawing.Size(184, 227);
            this.panelIniciarSubMenu.TabIndex = 2;
            // 
            // btnTeoria
            // 
            this.btnTeoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeoria.FlatAppearance.BorderSize = 0;
            this.btnTeoria.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btnTeoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeoria.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeoria.ForeColor = System.Drawing.Color.White;
            this.btnTeoria.Location = new System.Drawing.Point(0, 80);
            this.btnTeoria.Name = "btnTeoria";
            this.btnTeoria.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnTeoria.Size = new System.Drawing.Size(184, 40);
            this.btnTeoria.TabIndex = 2;
            this.btnTeoria.Text = "TEORIA";
            this.btnTeoria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeoria.UseVisualStyleBackColor = true;
            this.btnTeoria.Click += new System.EventHandler(this.btnTeoria_Click);
            this.btnTeoria.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTeoria_MouseClick);
            // 
            // btnIntegrante
            // 
            this.btnIntegrante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIntegrante.FlatAppearance.BorderSize = 0;
            this.btnIntegrante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btnIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntegrante.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntegrante.ForeColor = System.Drawing.Color.White;
            this.btnIntegrante.Location = new System.Drawing.Point(0, 40);
            this.btnIntegrante.Name = "btnIntegrante";
            this.btnIntegrante.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIntegrante.Size = new System.Drawing.Size(184, 40);
            this.btnIntegrante.TabIndex = 1;
            this.btnIntegrante.Text = "INTEGRANTES";
            this.btnIntegrante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIntegrante.UseVisualStyleBackColor = true;
            this.btnIntegrante.Click += new System.EventHandler(this.btnIntegrante_Click);
            this.btnIntegrante.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnIntegrante_MouseClick);
            // 
            // btnPrograma
            // 
            this.btnPrograma.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrograma.FlatAppearance.BorderSize = 0;
            this.btnPrograma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btnPrograma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrograma.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrograma.ForeColor = System.Drawing.Color.White;
            this.btnPrograma.Location = new System.Drawing.Point(0, 0);
            this.btnPrograma.Name = "btnPrograma";
            this.btnPrograma.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPrograma.Size = new System.Drawing.Size(184, 40);
            this.btnPrograma.TabIndex = 0;
            this.btnPrograma.Text = "PROGRAMA";
            this.btnPrograma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrograma.UseVisualStyleBackColor = true;
            this.btnPrograma.Click += new System.EventHandler(this.btnPrograma_Click);
            this.btnPrograma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPrograma_MouseClick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(205)))), ((int)(((byte)(185)))));
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.White;
            this.btnIniciar.Location = new System.Drawing.Point(0, 124);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIniciar.Size = new System.Drawing.Size(184, 135);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "INICIAR";
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(184, 124);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // paneLogoGrande
            // 
            this.paneLogoGrande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.paneLogoGrande.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paneLogoGrande.BackgroundImage")));
            this.paneLogoGrande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.paneLogoGrande.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneLogoGrande.Location = new System.Drawing.Point(184, 0);
            this.paneLogoGrande.Name = "paneLogoGrande";
            this.paneLogoGrande.Size = new System.Drawing.Size(1170, 715);
            this.paneLogoGrande.TabIndex = 6;
            this.paneLogoGrande.Paint += new System.Windows.Forms.PaintEventHandler(this.paneLogoGrande_Paint);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1354, 715);
            this.Controls.Add(this.paneLogoGrande);
            this.Controls.Add(this.panelSideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelSideMenu.ResumeLayout(false);
            this.panelIniciarSubMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelIniciarSubMenu;
        private System.Windows.Forms.Button btnTeoria;
        private System.Windows.Forms.Button btnIntegrante;
        private System.Windows.Forms.Button btnPrograma;
        private System.Windows.Forms.Panel paneLogoGrande;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
    }
}

