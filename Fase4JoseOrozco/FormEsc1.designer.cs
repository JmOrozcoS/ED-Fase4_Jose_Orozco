
namespace Fase4JoseOrozco
{
    partial class FormEsc1
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
            this.lblEsc1 = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.escenario1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.escenario2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postOrdenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEsc1
            // 
            this.lblEsc1.AutoSize = true;
            this.lblEsc1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsc1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEsc1.Location = new System.Drawing.Point(279, 140);
            this.lblEsc1.Name = "lblEsc1";
            this.lblEsc1.Size = new System.Drawing.Size(310, 25);
            this.lblEsc1.TabIndex = 58;
            this.lblEsc1.Text = "BIENVENIDO AL ESCENARIO 1";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbId.Location = new System.Drawing.Point(174, 107);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(80, 15);
            this.lbId.TabIndex = 53;
            this.lbId.Text = "Identificacion";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.escenario1ToolStripMenuItem,
            this.escenario2ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1390, 24);
            this.menuStrip1.TabIndex = 60;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // escenario1ToolStripMenuItem
            // 
            this.escenario1ToolStripMenuItem.Name = "escenario1ToolStripMenuItem";
            this.escenario1ToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.escenario1ToolStripMenuItem.Text = "Gráfica";
            this.escenario1ToolStripMenuItem.Click += new System.EventHandler(this.escenario1ToolStripMenuItem_Click);
            // 
            // escenario2ToolStripMenuItem
            // 
            this.escenario2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preOrdenToolStripMenuItem,
            this.inOrdenToolStripMenuItem,
            this.postOrdenToolStripMenuItem});
            this.escenario2ToolStripMenuItem.Name = "escenario2ToolStripMenuItem";
            this.escenario2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.escenario2ToolStripMenuItem.Text = "Recorridos";
            // 
            // preOrdenToolStripMenuItem
            // 
            this.preOrdenToolStripMenuItem.Name = "preOrdenToolStripMenuItem";
            this.preOrdenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.preOrdenToolStripMenuItem.Text = "PreOrden";
            // 
            // inOrdenToolStripMenuItem
            // 
            this.inOrdenToolStripMenuItem.Name = "inOrdenToolStripMenuItem";
            this.inOrdenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inOrdenToolStripMenuItem.Text = "InOrden";
            // 
            // postOrdenToolStripMenuItem
            // 
            this.postOrdenToolStripMenuItem.Name = "postOrdenToolStripMenuItem";
            this.postOrdenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.postOrdenToolStripMenuItem.Text = "PostOrden";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(1307, 46);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(71, 20);
            this.txtPosX.TabIndex = 61;
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(1307, 72);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(71, 20);
            this.txtPosY.TabIndex = 62;
            // 
            // FormEsc1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 512);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.lblEsc1);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEsc1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblEsc1;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem escenario1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem escenario2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inOrdenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postOrdenToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.TextBox txtPosY;
    }
}