namespace Artigos
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnCadastrarArtigo = new System.Windows.Forms.Button();
            this.btnRevisarArtigo = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "login.png");
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.Image = global::Artigos.Properties.Resources.iconUser;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(42, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cadastrar \r\nUsuário";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCadastrarArtigo
            // 
            this.btnCadastrarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrarArtigo.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarArtigo.Image")));
            this.btnCadastrarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrarArtigo.Location = new System.Drawing.Point(158, 41);
            this.btnCadastrarArtigo.Name = "btnCadastrarArtigo";
            this.btnCadastrarArtigo.Size = new System.Drawing.Size(93, 81);
            this.btnCadastrarArtigo.TabIndex = 1;
            this.btnCadastrarArtigo.Text = "Cadastrar \r\nArtigo";
            this.btnCadastrarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrarArtigo.UseVisualStyleBackColor = true;
            this.btnCadastrarArtigo.Click += new System.EventHandler(this.btnCadastrarArtigo_Click);
            // 
            // btnRevisarArtigo
            // 
            this.btnRevisarArtigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRevisarArtigo.Image = ((System.Drawing.Image)(resources.GetObject("btnRevisarArtigo.Image")));
            this.btnRevisarArtigo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRevisarArtigo.Location = new System.Drawing.Point(274, 41);
            this.btnRevisarArtigo.Name = "btnRevisarArtigo";
            this.btnRevisarArtigo.Size = new System.Drawing.Size(93, 81);
            this.btnRevisarArtigo.TabIndex = 2;
            this.btnRevisarArtigo.Text = "Revisar\r\nArtigo\r\n";
            this.btnRevisarArtigo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRevisarArtigo.UseVisualStyleBackColor = true;
            this.btnRevisarArtigo.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desconectarToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 467);
            this.Controls.Add(this.btnRevisarArtigo);
            this.Controls.Add(this.btnCadastrarArtigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Cadastrar artigos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnCadastrarArtigo;
        private System.Windows.Forms.Button btnRevisarArtigo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
    }
}

