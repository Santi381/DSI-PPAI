namespace DSI
{
    partial class PantallaRegistrarReservaVisita
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEscuelas = new System.Windows.Forms.ComboBox();
            this.bt_Escuela = new System.Windows.Forms.Button();
            this.lbl_Cantidad = new System.Windows.Forms.Label();
            this.txt_Cantidad = new System.Windows.Forms.TextBox();
            this.bt_Cantidad = new System.Windows.Forms.Button();
            this.bt_Sedes = new System.Windows.Forms.Button();
            this.cmbSedes = new System.Windows.Forms.ComboBox();
            this.lbl_Sede = new System.Windows.Forms.Label();
            this.bt_Tipo = new System.Windows.Forms.Button();
            this.cmb_Tipos = new System.Windows.Forms.ComboBox();
            this.lbl_Tipos = new System.Windows.Forms.Label();
            this.bt_Expo = new System.Windows.Forms.Button();
            this.cmb_Expos = new System.Windows.Forms.ComboBox();
            this.lbl_Expo = new System.Windows.Forms.Label();
            this.gdrExpo = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Grilla = new System.Windows.Forms.Button();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_Date = new System.Windows.Forms.MaskedTextBox();
            this.txt_Guias = new System.Windows.Forms.TextBox();
            this.lbl_CantGuias = new System.Windows.Forms.Label();
            this.gdr_Guias = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_Guias = new System.Windows.Forms.Button();
            this.cmb_Guias = new System.Windows.Forms.ComboBox();
            this.lbl_Guias = new System.Windows.Forms.Label();
            this.bt_NuevaReserva = new System.Windows.Forms.Button();
            this.bt_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdrExpo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Guias)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registrar Reserva de Visita Guiada";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escuela:";
            // 
            // cmbEscuelas
            // 
            this.cmbEscuelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEscuelas.FormattingEnabled = true;
            this.cmbEscuelas.Location = new System.Drawing.Point(74, 54);
            this.cmbEscuelas.Name = "cmbEscuelas";
            this.cmbEscuelas.Size = new System.Drawing.Size(286, 21);
            this.cmbEscuelas.TabIndex = 3;
            // 
            // bt_Escuela
            // 
            this.bt_Escuela.Location = new System.Drawing.Point(380, 51);
            this.bt_Escuela.Name = "bt_Escuela";
            this.bt_Escuela.Size = new System.Drawing.Size(87, 23);
            this.bt_Escuela.TabIndex = 4;
            this.bt_Escuela.Text = "Confirmar";
            this.bt_Escuela.UseVisualStyleBackColor = true;
            this.bt_Escuela.Click += new System.EventHandler(this.bt_Escuela_Click);
            // 
            // lbl_Cantidad
            // 
            this.lbl_Cantidad.AutoSize = true;
            this.lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cantidad.Location = new System.Drawing.Point(14, 96);
            this.lbl_Cantidad.Name = "lbl_Cantidad";
            this.lbl_Cantidad.Size = new System.Drawing.Size(131, 15);
            this.lbl_Cantidad.TabIndex = 5;
            this.lbl_Cantidad.Text = "Cantidad de Visitantes:";
            this.lbl_Cantidad.Visible = false;
            // 
            // txt_Cantidad
            // 
            this.txt_Cantidad.Location = new System.Drawing.Point(151, 95);
            this.txt_Cantidad.Name = "txt_Cantidad";
            this.txt_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txt_Cantidad.TabIndex = 6;
            this.txt_Cantidad.Visible = false;
            // 
            // bt_Cantidad
            // 
            this.bt_Cantidad.Location = new System.Drawing.Point(380, 93);
            this.bt_Cantidad.Name = "bt_Cantidad";
            this.bt_Cantidad.Size = new System.Drawing.Size(87, 23);
            this.bt_Cantidad.TabIndex = 7;
            this.bt_Cantidad.Text = "Confirmar";
            this.bt_Cantidad.UseVisualStyleBackColor = true;
            this.bt_Cantidad.Visible = false;
            this.bt_Cantidad.Click += new System.EventHandler(this.bt_Cantidad_Click);
            // 
            // bt_Sedes
            // 
            this.bt_Sedes.Location = new System.Drawing.Point(380, 136);
            this.bt_Sedes.Name = "bt_Sedes";
            this.bt_Sedes.Size = new System.Drawing.Size(87, 23);
            this.bt_Sedes.TabIndex = 10;
            this.bt_Sedes.Text = "Confirmar";
            this.bt_Sedes.UseVisualStyleBackColor = true;
            this.bt_Sedes.Visible = false;
            this.bt_Sedes.Click += new System.EventHandler(this.bt_Sedes_Click);
            // 
            // cmbSedes
            // 
            this.cmbSedes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSedes.FormattingEnabled = true;
            this.cmbSedes.Location = new System.Drawing.Point(74, 139);
            this.cmbSedes.Name = "cmbSedes";
            this.cmbSedes.Size = new System.Drawing.Size(286, 21);
            this.cmbSedes.TabIndex = 9;
            this.cmbSedes.Visible = false;
            // 
            // lbl_Sede
            // 
            this.lbl_Sede.AutoSize = true;
            this.lbl_Sede.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sede.Location = new System.Drawing.Point(14, 140);
            this.lbl_Sede.Name = "lbl_Sede";
            this.lbl_Sede.Size = new System.Drawing.Size(39, 15);
            this.lbl_Sede.TabIndex = 8;
            this.lbl_Sede.Text = "Sede:";
            this.lbl_Sede.Visible = false;
            // 
            // bt_Tipo
            // 
            this.bt_Tipo.Location = new System.Drawing.Point(380, 182);
            this.bt_Tipo.Name = "bt_Tipo";
            this.bt_Tipo.Size = new System.Drawing.Size(87, 23);
            this.bt_Tipo.TabIndex = 13;
            this.bt_Tipo.Text = "Confirmar";
            this.bt_Tipo.UseVisualStyleBackColor = true;
            this.bt_Tipo.Visible = false;
            this.bt_Tipo.Click += new System.EventHandler(this.bt_Tipo_Click);
            // 
            // cmb_Tipos
            // 
            this.cmb_Tipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Tipos.FormattingEnabled = true;
            this.cmb_Tipos.Location = new System.Drawing.Point(103, 185);
            this.cmb_Tipos.Name = "cmb_Tipos";
            this.cmb_Tipos.Size = new System.Drawing.Size(257, 21);
            this.cmb_Tipos.TabIndex = 12;
            this.cmb_Tipos.Visible = false;
            // 
            // lbl_Tipos
            // 
            this.lbl_Tipos.AutoSize = true;
            this.lbl_Tipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tipos.Location = new System.Drawing.Point(14, 186);
            this.lbl_Tipos.Name = "lbl_Tipos";
            this.lbl_Tipos.Size = new System.Drawing.Size(83, 15);
            this.lbl_Tipos.TabIndex = 11;
            this.lbl_Tipos.Text = "Tipo de Visita:";
            this.lbl_Tipos.Visible = false;
            // 
            // bt_Expo
            // 
            this.bt_Expo.Location = new System.Drawing.Point(380, 230);
            this.bt_Expo.Name = "bt_Expo";
            this.bt_Expo.Size = new System.Drawing.Size(87, 23);
            this.bt_Expo.TabIndex = 16;
            this.bt_Expo.Text = "Agregar";
            this.bt_Expo.UseVisualStyleBackColor = true;
            this.bt_Expo.Visible = false;
            this.bt_Expo.Click += new System.EventHandler(this.bt_Expo_Click);
            // 
            // cmb_Expos
            // 
            this.cmb_Expos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Expos.FormattingEnabled = true;
            this.cmb_Expos.Location = new System.Drawing.Point(103, 233);
            this.cmb_Expos.Name = "cmb_Expos";
            this.cmb_Expos.Size = new System.Drawing.Size(257, 21);
            this.cmb_Expos.TabIndex = 15;
            this.cmb_Expos.Visible = false;
            // 
            // lbl_Expo
            // 
            this.lbl_Expo.AutoSize = true;
            this.lbl_Expo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Expo.Location = new System.Drawing.Point(14, 234);
            this.lbl_Expo.Name = "lbl_Expo";
            this.lbl_Expo.Size = new System.Drawing.Size(83, 15);
            this.lbl_Expo.TabIndex = 14;
            this.lbl_Expo.Text = "Exposiciones:";
            this.lbl_Expo.Visible = false;
            // 
            // gdrExpo
            // 
            this.gdrExpo.AllowUserToAddRows = false;
            this.gdrExpo.AllowUserToDeleteRows = false;
            this.gdrExpo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdrExpo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre});
            this.gdrExpo.Location = new System.Drawing.Point(17, 278);
            this.gdrExpo.Name = "gdrExpo";
            this.gdrExpo.ReadOnly = true;
            this.gdrExpo.Size = new System.Drawing.Size(450, 182);
            this.gdrExpo.TabIndex = 17;
            this.gdrExpo.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Exposicion";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // bt_Grilla
            // 
            this.bt_Grilla.Location = new System.Drawing.Point(380, 466);
            this.bt_Grilla.Name = "bt_Grilla";
            this.bt_Grilla.Size = new System.Drawing.Size(87, 23);
            this.bt_Grilla.TabIndex = 18;
            this.bt_Grilla.Text = "Confirmar";
            this.bt_Grilla.UseVisualStyleBackColor = true;
            this.bt_Grilla.Visible = false;
            this.bt_Grilla.Click += new System.EventHandler(this.bt_Grilla_Click);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(14, 469);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(44, 15);
            this.lbl_date.TabIndex = 21;
            this.lbl_date.Text = "Fecha:";
            this.lbl_date.Visible = false;
            // 
            // txt_Date
            // 
            this.txt_Date.Location = new System.Drawing.Point(64, 468);
            this.txt_Date.Mask = "00/00/0000 90:00";
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(296, 20);
            this.txt_Date.TabIndex = 22;
            this.txt_Date.ValidatingType = typeof(System.DateTime);
            this.txt_Date.Visible = false;
            // 
            // txt_Guias
            // 
            this.txt_Guias.Enabled = false;
            this.txt_Guias.Location = new System.Drawing.Point(151, 503);
            this.txt_Guias.Name = "txt_Guias";
            this.txt_Guias.Size = new System.Drawing.Size(100, 20);
            this.txt_Guias.TabIndex = 24;
            this.txt_Guias.Visible = false;
            // 
            // lbl_CantGuias
            // 
            this.lbl_CantGuias.AutoSize = true;
            this.lbl_CantGuias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CantGuias.Location = new System.Drawing.Point(14, 504);
            this.lbl_CantGuias.Name = "lbl_CantGuias";
            this.lbl_CantGuias.Size = new System.Drawing.Size(111, 15);
            this.lbl_CantGuias.TabIndex = 23;
            this.lbl_CantGuias.Text = "Cantidad de Guias:";
            this.lbl_CantGuias.Visible = false;
            // 
            // gdr_Guias
            // 
            this.gdr_Guias.AllowUserToAddRows = false;
            this.gdr_Guias.AllowUserToDeleteRows = false;
            this.gdr_Guias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdr_Guias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gdr_Guias.Location = new System.Drawing.Point(17, 587);
            this.gdr_Guias.Name = "gdr_Guias";
            this.gdr_Guias.ReadOnly = true;
            this.gdr_Guias.Size = new System.Drawing.Size(450, 126);
            this.gdr_Guias.TabIndex = 28;
            this.gdr_Guias.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Guia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bt_Guias
            // 
            this.bt_Guias.Location = new System.Drawing.Point(380, 539);
            this.bt_Guias.Name = "bt_Guias";
            this.bt_Guias.Size = new System.Drawing.Size(87, 23);
            this.bt_Guias.TabIndex = 27;
            this.bt_Guias.Text = "Agregar";
            this.bt_Guias.UseVisualStyleBackColor = true;
            this.bt_Guias.Visible = false;
            this.bt_Guias.Click += new System.EventHandler(this.bt_Guias_Click);
            // 
            // cmb_Guias
            // 
            this.cmb_Guias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Guias.FormattingEnabled = true;
            this.cmb_Guias.Location = new System.Drawing.Point(103, 542);
            this.cmb_Guias.Name = "cmb_Guias";
            this.cmb_Guias.Size = new System.Drawing.Size(257, 21);
            this.cmb_Guias.TabIndex = 26;
            this.cmb_Guias.Visible = false;
            // 
            // lbl_Guias
            // 
            this.lbl_Guias.AutoSize = true;
            this.lbl_Guias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Guias.Location = new System.Drawing.Point(14, 543);
            this.lbl_Guias.Name = "lbl_Guias";
            this.lbl_Guias.Size = new System.Drawing.Size(42, 15);
            this.lbl_Guias.TabIndex = 25;
            this.lbl_Guias.Text = "Guias:";
            this.lbl_Guias.Visible = false;
            // 
            // bt_NuevaReserva
            // 
            this.bt_NuevaReserva.Location = new System.Drawing.Point(380, 733);
            this.bt_NuevaReserva.Name = "bt_NuevaReserva";
            this.bt_NuevaReserva.Size = new System.Drawing.Size(87, 23);
            this.bt_NuevaReserva.TabIndex = 29;
            this.bt_NuevaReserva.Text = "Confirmar";
            this.bt_NuevaReserva.UseVisualStyleBackColor = true;
            this.bt_NuevaReserva.Visible = false;
            this.bt_NuevaReserva.Click += new System.EventHandler(this.bt_NuevaReserva_Click);
            // 
            // bt_Cancelar
            // 
            this.bt_Cancelar.Location = new System.Drawing.Point(17, 733);
            this.bt_Cancelar.Name = "bt_Cancelar";
            this.bt_Cancelar.Size = new System.Drawing.Size(87, 23);
            this.bt_Cancelar.TabIndex = 30;
            this.bt_Cancelar.Text = "Cancelar";
            this.bt_Cancelar.UseVisualStyleBackColor = true;
            this.bt_Cancelar.Click += new System.EventHandler(this.bt_Cancelar_Click);
            // 
            // PantallaRegistrarReservaVisita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 767);
            this.Controls.Add(this.bt_Cancelar);
            this.Controls.Add(this.bt_NuevaReserva);
            this.Controls.Add(this.gdr_Guias);
            this.Controls.Add(this.bt_Guias);
            this.Controls.Add(this.cmb_Guias);
            this.Controls.Add(this.lbl_Guias);
            this.Controls.Add(this.txt_Guias);
            this.Controls.Add(this.lbl_CantGuias);
            this.Controls.Add(this.txt_Date);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.bt_Grilla);
            this.Controls.Add(this.gdrExpo);
            this.Controls.Add(this.bt_Expo);
            this.Controls.Add(this.cmb_Expos);
            this.Controls.Add(this.lbl_Expo);
            this.Controls.Add(this.bt_Tipo);
            this.Controls.Add(this.cmb_Tipos);
            this.Controls.Add(this.lbl_Tipos);
            this.Controls.Add(this.bt_Sedes);
            this.Controls.Add(this.cmbSedes);
            this.Controls.Add(this.lbl_Sede);
            this.Controls.Add(this.bt_Cantidad);
            this.Controls.Add(this.txt_Cantidad);
            this.Controls.Add(this.lbl_Cantidad);
            this.Controls.Add(this.bt_Escuela);
            this.Controls.Add(this.cmbEscuelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "PantallaRegistrarReservaVisita";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaRegistrarReservaVisita";
            ((System.ComponentModel.ISupportInitialize)(this.gdrExpo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdr_Guias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEscuelas;
        private System.Windows.Forms.Button bt_Escuela;
        private System.Windows.Forms.Label lbl_Cantidad;
        private System.Windows.Forms.TextBox txt_Cantidad;
        private System.Windows.Forms.Button bt_Cantidad;
        private System.Windows.Forms.Button bt_Sedes;
        private System.Windows.Forms.ComboBox cmbSedes;
        private System.Windows.Forms.Label lbl_Sede;
        private System.Windows.Forms.Button bt_Tipo;
        private System.Windows.Forms.ComboBox cmb_Tipos;
        private System.Windows.Forms.Label lbl_Tipos;
        private System.Windows.Forms.Button bt_Expo;
        private System.Windows.Forms.ComboBox cmb_Expos;
        private System.Windows.Forms.Label lbl_Expo;
        private System.Windows.Forms.DataGridView gdrExpo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Button bt_Grilla;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.MaskedTextBox txt_Date;
        private System.Windows.Forms.TextBox txt_Guias;
        private System.Windows.Forms.Label lbl_CantGuias;
        private System.Windows.Forms.DataGridView gdr_Guias;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button bt_Guias;
        private System.Windows.Forms.ComboBox cmb_Guias;
        private System.Windows.Forms.Label lbl_Guias;
        private System.Windows.Forms.Button bt_NuevaReserva;
        private System.Windows.Forms.Button bt_Cancelar;
    }
}