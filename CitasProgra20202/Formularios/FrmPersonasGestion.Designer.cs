namespace CitasProgra20202.Formularios
{
    partial class FrmPersonasGestion
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
            this.DgvLista = new System.Windows.Forms.DataGridView();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.TxtIDPersona = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.TxtContrasennia = new System.Windows.Forms.TextBox();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtCedula = new System.Windows.Forms.TextBox();
            this.TxtDireccion = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.CbActivo = new System.Windows.Forms.CheckBox();
            this.CboxRol = new System.Windows.Forms.ComboBox();
            this.CboxPersonaTipo = new System.Windows.Forms.ComboBox();
            this.CboxPasienteTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.CIDPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDPersonaTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDPacienteTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CContrasennia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvLista
            // 
            this.DgvLista.AllowUserToAddRows = false;
            this.DgvLista.AllowUserToDeleteRows = false;
            this.DgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIDPersona,
            this.CCedula,
            this.CNombre,
            this.CEmail,
            this.CTelefono,
            this.CDireccion,
            this.CIDPersonaTipo,
            this.CIDPacienteTipo,
            this.CIDRol,
            this.CActivo,
            this.CContrasennia});
            this.DgvLista.Location = new System.Drawing.Point(97, 32);
            this.DgvLista.MultiSelect = false;
            this.DgvLista.Name = "DgvLista";
            this.DgvLista.ReadOnly = true;
            this.DgvLista.RowHeadersVisible = false;
            this.DgvLista.RowHeadersWidth = 51;
            this.DgvLista.RowTemplate.Height = 24;
            this.DgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvLista.Size = new System.Drawing.Size(1086, 155);
            this.DgvLista.TabIndex = 0;
            this.DgvLista.VirtualMode = true;
            this.DgvLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnAgregar.ForeColor = System.Drawing.Color.White;
            this.BtnAgregar.Location = new System.Drawing.Point(62, 512);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(122, 49);
            this.BtnAgregar.TabIndex = 2;
            this.BtnAgregar.Text = "AGREGAR";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.Peru;
            this.BtnModificar.ForeColor = System.Drawing.Color.Black;
            this.BtnModificar.Location = new System.Drawing.Point(215, 512);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(115, 49);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = false;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.Red;
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(375, 512);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(107, 49);
            this.BtnEliminar.TabIndex = 4;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.BtnLimpiar.Location = new System.Drawing.Point(720, 512);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(231, 52);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar Formulario";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.BtnCancelar.Location = new System.Drawing.Point(990, 512);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(130, 49);
            this.BtnCancelar.TabIndex = 6;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            // 
            // TxtIDPersona
            // 
            this.TxtIDPersona.Location = new System.Drawing.Point(166, 64);
            this.TxtIDPersona.Name = "TxtIDPersona";
            this.TxtIDPersona.ReadOnly = true;
            this.TxtIDPersona.Size = new System.Drawing.Size(224, 22);
            this.TxtIDPersona.TabIndex = 0;
            this.TxtIDPersona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Location = new System.Drawing.Point(166, 227);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(224, 22);
            this.TxtTelefono.TabIndex = 1;
            // 
            // TxtContrasennia
            // 
            this.TxtContrasennia.Location = new System.Drawing.Point(145, 195);
            this.TxtContrasennia.Name = "TxtContrasennia";
            this.TxtContrasennia.Size = new System.Drawing.Size(198, 22);
            this.TxtContrasennia.TabIndex = 2;
            this.TxtContrasennia.UseSystemPasswordChar = true;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(166, 189);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(224, 22);
            this.TxtEmail.TabIndex = 3;
            // 
            // TxtCedula
            // 
            this.TxtCedula.Location = new System.Drawing.Point(166, 112);
            this.TxtCedula.Name = "TxtCedula";
            this.TxtCedula.Size = new System.Drawing.Size(224, 22);
            this.TxtCedula.TabIndex = 4;
            // 
            // TxtDireccion
            // 
            this.TxtDireccion.Location = new System.Drawing.Point(558, 71);
            this.TxtDireccion.MaxLength = 1500;
            this.TxtDireccion.Multiline = true;
            this.TxtDireccion.Name = "TxtDireccion";
            this.TxtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtDireccion.Size = new System.Drawing.Size(441, 178);
            this.TxtDireccion.TabIndex = 5;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(166, 151);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(224, 22);
            this.TxtNombre.TabIndex = 6;
            // 
            // CbActivo
            // 
            this.CbActivo.AutoSize = true;
            this.CbActivo.Location = new System.Drawing.Point(931, 23);
            this.CbActivo.Name = "CbActivo";
            this.CbActivo.Size = new System.Drawing.Size(68, 21);
            this.CbActivo.TabIndex = 7;
            this.CbActivo.Text = "Activo";
            this.CbActivo.UseVisualStyleBackColor = true;
            // 
            // CboxRol
            // 
            this.CboxRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxRol.FormattingEnabled = true;
            this.CboxRol.Location = new System.Drawing.Point(145, 138);
            this.CboxRol.Name = "CboxRol";
            this.CboxRol.Size = new System.Drawing.Size(198, 24);
            this.CboxRol.TabIndex = 8;
            // 
            // CboxPersonaTipo
            // 
            this.CboxPersonaTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxPersonaTipo.FormattingEnabled = true;
            this.CboxPersonaTipo.Location = new System.Drawing.Point(145, 76);
            this.CboxPersonaTipo.Name = "CboxPersonaTipo";
            this.CboxPersonaTipo.Size = new System.Drawing.Size(198, 24);
            this.CboxPersonaTipo.TabIndex = 9;
            // 
            // CboxPasienteTipo
            // 
            this.CboxPasienteTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboxPasienteTipo.FormattingEnabled = true;
            this.CboxPasienteTipo.Location = new System.Drawing.Point(210, 117);
            this.CboxPasienteTipo.Name = "CboxPasienteTipo";
            this.CboxPasienteTipo.Size = new System.Drawing.Size(198, 24);
            this.CboxPasienteTipo.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Tipo Paciente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tipo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Rol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(343, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "Buscar";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(460, 9);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(300, 22);
            this.TxtBuscar.TabIndex = 8;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(93, 202);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1139, 304);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TxtTelefono);
            this.tabPage1.Controls.Add(this.TxtIDPersona);
            this.tabPage1.Controls.Add(this.TxtEmail);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.TxtNombre);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.CbActivo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.TxtDireccion);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.TxtCedula);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1131, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "INFORMACION GENERAL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.TxtContrasennia);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.CboxRol);
            this.tabPage2.Controls.Add(this.CboxPersonaTipo);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1131, 275);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EMPLEADO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.CboxPasienteTipo);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1131, 275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PACIENTE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // CIDPersona
            // 
            this.CIDPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDPersona.DataPropertyName = "IDPersona";
            this.CIDPersona.HeaderText = "Codigo";
            this.CIDPersona.MinimumWidth = 6;
            this.CIDPersona.Name = "CIDPersona";
            this.CIDPersona.ReadOnly = true;
            this.CIDPersona.Width = 60;
            // 
            // CCedula
            // 
            this.CCedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CCedula.DataPropertyName = "Cedula";
            this.CCedula.HeaderText = "Cedula";
            this.CCedula.MinimumWidth = 6;
            this.CCedula.Name = "CCedula";
            this.CCedula.ReadOnly = true;
            this.CCedula.Width = 80;
            // 
            // CNombre
            // 
            this.CNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CNombre.DataPropertyName = "Nombre";
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.MinimumWidth = 6;
            this.CNombre.Name = "CNombre";
            this.CNombre.ReadOnly = true;
            // 
            // CEmail
            // 
            this.CEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CEmail.DataPropertyName = "Email";
            this.CEmail.HeaderText = "Email";
            this.CEmail.MinimumWidth = 6;
            this.CEmail.Name = "CEmail";
            this.CEmail.ReadOnly = true;
            this.CEmail.Width = 120;
            // 
            // CTelefono
            // 
            this.CTelefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CTelefono.DataPropertyName = "Telefono";
            this.CTelefono.HeaderText = "Telefono";
            this.CTelefono.MinimumWidth = 6;
            this.CTelefono.Name = "CTelefono";
            this.CTelefono.ReadOnly = true;
            this.CTelefono.Width = 125;
            // 
            // CDireccion
            // 
            this.CDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CDireccion.DataPropertyName = "Direccion";
            this.CDireccion.HeaderText = "Direccion";
            this.CDireccion.MinimumWidth = 6;
            this.CDireccion.Name = "CDireccion";
            this.CDireccion.ReadOnly = true;
            this.CDireccion.Width = 125;
            // 
            // CIDPersonaTipo
            // 
            this.CIDPersonaTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDPersonaTipo.DataPropertyName = "IDPersonaTipo";
            this.CIDPersonaTipo.HeaderText = "Tipo Persona";
            this.CIDPersonaTipo.MinimumWidth = 6;
            this.CIDPersonaTipo.Name = "CIDPersonaTipo";
            this.CIDPersonaTipo.ReadOnly = true;
            this.CIDPersonaTipo.Width = 6;
            // 
            // CIDPacienteTipo
            // 
            this.CIDPacienteTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDPacienteTipo.DataPropertyName = "IDPacienteTipo";
            this.CIDPacienteTipo.HeaderText = "Paciente";
            this.CIDPacienteTipo.MinimumWidth = 6;
            this.CIDPacienteTipo.Name = "CIDPacienteTipo";
            this.CIDPacienteTipo.ReadOnly = true;
            this.CIDPacienteTipo.Width = 6;
            // 
            // CIDRol
            // 
            this.CIDRol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CIDRol.DataPropertyName = "IDRol";
            this.CIDRol.HeaderText = "Rol";
            this.CIDRol.MinimumWidth = 6;
            this.CIDRol.Name = "CIDRol";
            this.CIDRol.ReadOnly = true;
            this.CIDRol.Width = 6;
            // 
            // CActivo
            // 
            this.CActivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CActivo.DataPropertyName = "Activo";
            this.CActivo.HeaderText = "Activo";
            this.CActivo.MinimumWidth = 6;
            this.CActivo.Name = "CActivo";
            this.CActivo.ReadOnly = true;
            this.CActivo.Width = 125;
            // 
            // CContrasennia
            // 
            this.CContrasennia.DataPropertyName = "Contrasennia";
            this.CContrasennia.HeaderText = "Password";
            this.CContrasennia.MinimumWidth = 6;
            this.CContrasennia.Name = "CContrasennia";
            this.CContrasennia.ReadOnly = true;
            this.CContrasennia.Visible = false;
            this.CContrasennia.Width = 125;
            // 
            // FrmPersonasGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1283, 594);
            this.Controls.Add(this.DgvLista);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnAgregar);
            this.MinimizeBox = false;
            this.Name = "FrmPersonasGestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión De Personas";
            this.Load += new System.EventHandler(this.FrmPersonasGestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLista)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLista;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboxPasienteTipo;
        private System.Windows.Forms.ComboBox CboxPersonaTipo;
        private System.Windows.Forms.ComboBox CboxRol;
        private System.Windows.Forms.CheckBox CbActivo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDireccion;
        private System.Windows.Forms.TextBox TxtCedula;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.TextBox TxtContrasennia;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.TextBox TxtIDPersona;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPersonaTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDPacienteTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDRol;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CActivo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CContrasennia;
    }
}