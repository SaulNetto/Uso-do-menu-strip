﻿namespace AppExemploMenu
{
    partial class FrmAzul
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormRosa = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.ExibirFormVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExibirFormRosa,
            this.ExibirFormAzul,
            this.ExibirFormVerde});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.exibirToolStripMenuItem.Text = "Exibir";
           
            // 
            // ExibirFormRosa
            // 
            this.ExibirFormRosa.Name = "ExibirFormRosa";
            this.ExibirFormRosa.Size = new System.Drawing.Size(134, 22);
            this.ExibirFormRosa.Text = "Form Rosa";
            this.ExibirFormRosa.Click += new System.EventHandler(this.formAmareloToolStripMenuItem_Click);
            // 
            // ExibirFormAzul
            // 
            this.ExibirFormAzul.Name = "ExibirFormAzul";
            this.ExibirFormAzul.Size = new System.Drawing.Size(134, 22);
            this.ExibirFormAzul.Text = "Form Azul";
            this.ExibirFormAzul.Click += new System.EventHandler(this.ExibirFormAzul_Click);
            // 
            // ExibirFormVerde
            // 
            this.ExibirFormVerde.Name = "ExibirFormVerde";
            this.ExibirFormVerde.Size = new System.Drawing.Size(134, 22);
            this.ExibirFormVerde.Text = "Form Verde";
            this.ExibirFormVerde.Click += new System.EventHandler(this.ExibirFormVerde_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmAzul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmAzul";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormRosa;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormAzul;
        private System.Windows.Forms.ToolStripMenuItem ExibirFormVerde;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

