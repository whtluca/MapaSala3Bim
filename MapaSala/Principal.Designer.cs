
namespace MapaSala
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compartilharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faltasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salasLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosProfessoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosXDisciplinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Lavender;
            this.menuStrip1.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem,
            this.arquivoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.disciplinasToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.cursosXDisciplinasToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(83, 25);
            this.toolStripMenuItem1.Text = "Cadastros";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cadastrosToolStripMenuItem.Text = "Salas";
            this.cadastrosToolStripMenuItem.Click += new System.EventHandler(this.cadastrosToolStripMenuItem_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.relatoriosToolStripMenuItem.Text = "Professores";
            this.relatoriosToolStripMenuItem.Click += new System.EventHandler(this.relatoriosToolStripMenuItem_Click);
            // 
            // disciplinasToolStripMenuItem
            // 
            this.disciplinasToolStripMenuItem.Name = "disciplinasToolStripMenuItem";
            this.disciplinasToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.disciplinasToolStripMenuItem.Text = "Disciplinas";
            this.disciplinasToolStripMenuItem.Click += new System.EventHandler(this.disciplinasToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.opçõesToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.compartilharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(71, 25);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            // 
            // compartilharToolStripMenuItem
            // 
            this.compartilharToolStripMenuItem.Name = "compartilharToolStripMenuItem";
            this.compartilharToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.compartilharToolStripMenuItem.Text = "Compartilhar";
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.faltasToolStripMenuItem,
            this.salasLivresToolStripMenuItem,
            this.todosProfessoresToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(84, 25);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // faltasToolStripMenuItem
            // 
            this.faltasToolStripMenuItem.Name = "faltasToolStripMenuItem";
            this.faltasToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.faltasToolStripMenuItem.Text = "Faltas";
            // 
            // salasLivresToolStripMenuItem
            // 
            this.salasLivresToolStripMenuItem.Name = "salasLivresToolStripMenuItem";
            this.salasLivresToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.salasLivresToolStripMenuItem.Text = "Salas livres";
            // 
            // todosProfessoresToolStripMenuItem
            // 
            this.todosProfessoresToolStripMenuItem.Name = "todosProfessoresToolStripMenuItem";
            this.todosProfessoresToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.todosProfessoresToolStripMenuItem.Text = "Todos Professores";
            // 
            // cursosXDisciplinasToolStripMenuItem
            // 
            this.cursosXDisciplinasToolStripMenuItem.Name = "cursosXDisciplinasToolStripMenuItem";
            this.cursosXDisciplinasToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cursosXDisciplinasToolStripMenuItem.Text = "Curso_Disciplinas";
            this.cursosXDisciplinasToolStripMenuItem.Click += new System.EventHandler(this.cursosXDisciplinasToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compartilharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faltasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salasLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosProfessoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosXDisciplinasToolStripMenuItem;
    }
}