
namespace Fase4JoseOrozco
{
    partial class FormCola
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
            this.btnBack = new System.Windows.Forms.Button();
            this.LbFecha = new System.Windows.Forms.Label();
            this.cbNempresa = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.txtNumViaje = new System.Windows.Forms.TextBox();
            this.lbEmpresa = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.dtFechaPago = new System.Windows.Forms.DateTimePicker();
            this.cbNDestino = new System.Windows.Forms.ComboBox();
            this.lbDestino = new System.Windows.Forms.Label();
            this.txtNcliente = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtTotalR = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgCola = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ItemMenuRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemMenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgCola)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(480, 490);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 35);
            this.btnBack.TabIndex = 51;
            this.btnBack.Text = "VOLVER";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LbFecha
            // 
            this.LbFecha.AutoSize = true;
            this.LbFecha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.LbFecha.ForeColor = System.Drawing.Color.SteelBlue;
            this.LbFecha.Location = new System.Drawing.Point(26, 73);
            this.LbFecha.Name = "LbFecha";
            this.LbFecha.Size = new System.Drawing.Size(41, 15);
            this.LbFecha.TabIndex = 52;
            this.LbFecha.Text = "Fecha";
            // 
            // cbNempresa
            // 
            this.cbNempresa.FormattingEnabled = true;
            this.cbNempresa.Items.AddRange(new object[] {
            "Doble",
            "Especial",
            "Sencilla"});
            this.cbNempresa.Location = new System.Drawing.Point(112, 188);
            this.cbNempresa.Name = "cbNempresa";
            this.cbNempresa.Size = new System.Drawing.Size(100, 21);
            this.cbNempresa.TabIndex = 61;
            this.cbNempresa.Text = "Seleccione";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(112, 149);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 59;
            // 
            // txtNumViaje
            // 
            this.txtNumViaje.Enabled = false;
            this.txtNumViaje.Location = new System.Drawing.Point(112, 109);
            this.txtNumViaje.Name = "txtNumViaje";
            this.txtNumViaje.Size = new System.Drawing.Size(100, 20);
            this.txtNumViaje.TabIndex = 58;
            // 
            // lbEmpresa
            // 
            this.lbEmpresa.AutoSize = true;
            this.lbEmpresa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEmpresa.Location = new System.Drawing.Point(26, 190);
            this.lbEmpresa.Name = "lbEmpresa";
            this.lbEmpresa.Size = new System.Drawing.Size(52, 15);
            this.lbEmpresa.TabIndex = 55;
            this.lbEmpresa.Text = "Empresa";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbName.Location = new System.Drawing.Point(26, 151);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(57, 15);
            this.lbName.TabIndex = 54;
            this.lbName.Text = "ID cliente";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbId.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbId.Location = new System.Drawing.Point(26, 111);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(50, 15);
            this.lbId.TabIndex = 53;
            this.lbId.Text = "N Ticket";
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.Location = new System.Drawing.Point(112, 68);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(100, 20);
            this.dtFechaPago.TabIndex = 66;
            // 
            // cbNDestino
            // 
            this.cbNDestino.FormattingEnabled = true;
            this.cbNDestino.Items.AddRange(new object[] {
            "Doble",
            "Especial",
            "Sencilla"});
            this.cbNDestino.Location = new System.Drawing.Point(480, 233);
            this.cbNDestino.Name = "cbNDestino";
            this.cbNDestino.Size = new System.Drawing.Size(100, 21);
            this.cbNDestino.Sorted = true;
            this.cbNDestino.TabIndex = 70;
            this.cbNDestino.Text = "Seleccione";
            // 
            // lbDestino
            // 
            this.lbDestino.AutoSize = true;
            this.lbDestino.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbDestino.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDestino.Location = new System.Drawing.Point(394, 235);
            this.lbDestino.Name = "lbDestino";
            this.lbDestino.Size = new System.Drawing.Size(47, 15);
            this.lbDestino.TabIndex = 69;
            this.lbDestino.Text = "Destino";
            // 
            // txtNcliente
            // 
            this.txtNcliente.Location = new System.Drawing.Point(480, 112);
            this.txtNcliente.Name = "txtNcliente";
            this.txtNcliente.Size = new System.Drawing.Size(100, 20);
            this.txtNcliente.TabIndex = 72;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(394, 114);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 15);
            this.lbNombre.TabIndex = 71;
            this.lbNombre.Text = "Nombre";
            // 
            // txtTotalR
            // 
            this.txtTotalR.Enabled = false;
            this.txtTotalR.Location = new System.Drawing.Point(480, 450);
            this.txtTotalR.Name = "txtTotalR";
            this.txtTotalR.Size = new System.Drawing.Size(100, 20);
            this.txtTotalR.TabIndex = 76;
            this.txtTotalR.Text = "Registros totales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(394, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "Total registros";
            // 
            // dgCola
            // 
            this.dgCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCola.Location = new System.Drawing.Point(29, 345);
            this.dgCola.Name = "dgCola";
            this.dgCola.Size = new System.Drawing.Size(551, 99);
            this.dgCola.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(399, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Terminal de transportes de Neiva";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemMenuRegistrar,
            this.ItemMenuEliminar,
            this.ItemMenuReporte,
            this.ItemMenuSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(623, 24);
            this.menuStrip1.TabIndex = 79;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ItemMenuRegistrar
            // 
            this.ItemMenuRegistrar.Name = "ItemMenuRegistrar";
            this.ItemMenuRegistrar.Size = new System.Drawing.Size(65, 20);
            this.ItemMenuRegistrar.Text = "Registrar";
            this.ItemMenuRegistrar.Click += new System.EventHandler(this.ItemMenuRegistrar_Click);
            // 
            // ItemMenuEliminar
            // 
            this.ItemMenuEliminar.Name = "ItemMenuEliminar";
            this.ItemMenuEliminar.Size = new System.Drawing.Size(62, 20);
            this.ItemMenuEliminar.Text = "Eliminar";
            this.ItemMenuEliminar.Click += new System.EventHandler(this.ItemMenuEliminar_Click);
            // 
            // ItemMenuReporte
            // 
            this.ItemMenuReporte.Name = "ItemMenuReporte";
            this.ItemMenuReporte.Size = new System.Drawing.Size(60, 20);
            this.ItemMenuReporte.Text = "Reporte";
            this.ItemMenuReporte.Click += new System.EventHandler(this.ItemMenuReporte_Click);
            // 
            // ItemMenuSalir
            // 
            this.ItemMenuSalir.Name = "ItemMenuSalir";
            this.ItemMenuSalir.Size = new System.Drawing.Size(41, 20);
            this.ItemMenuSalir.Text = "Salir";
            this.ItemMenuSalir.Click += new System.EventHandler(this.ItemMenuSalir_Click);
            // 
            // FormCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(623, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgCola);
            this.Controls.Add(this.txtTotalR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNcliente);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbNDestino);
            this.Controls.Add(this.lbDestino);
            this.Controls.Add(this.dtFechaPago);
            this.Controls.Add(this.cbNempresa);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.txtNumViaje);
            this.Controls.Add(this.lbEmpresa);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.LbFecha);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desprendible";
            ((System.ComponentModel.ISupportInitialize)(this.dgCola)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        public System.Windows.Forms.Label LbFecha;
        private System.Windows.Forms.ComboBox cbNempresa;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.TextBox txtNumViaje;
        private System.Windows.Forms.Label lbEmpresa;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DateTimePicker dtFechaPago;
        private System.Windows.Forms.ComboBox cbNDestino;
        private System.Windows.Forms.Label lbDestino;
        private System.Windows.Forms.TextBox txtNcliente;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtTotalR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCola;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuRegistrar;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuEliminar;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuReporte;
        private System.Windows.Forms.ToolStripMenuItem ItemMenuSalir;
    }
}