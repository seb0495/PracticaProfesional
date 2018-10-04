namespace WindowsFormsApplication1
{
    partial class FrmMantenEstud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMantenEstud));
            this.lblExpedCed = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.lblCed = new System.Windows.Forms.Label();
            this.lblExpirCed = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrimerAp = new System.Windows.Forms.Label();
            this.lblSegAp = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCédula = new System.Windows.Forms.TextBox();
            this.txtPriAp = new System.Windows.Forms.TextBox();
            this.txtCedBusqueda = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbInsertar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMod = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbElim = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblExpCed = new System.Windows.Forms.Label();
            this.txtEXP = new System.Windows.Forms.TextBox();
            this.lblCedu = new System.Windows.Forms.Label();
            this.txtExpedCed = new System.Windows.Forms.MaskedTextBox();
            this.txtExpCed = new System.Windows.Forms.MaskedTextBox();
            this.txtExpirCed = new System.Windows.Forms.MaskedTextBox();
            this.txtSegAp = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlGen = new System.Windows.Forms.Panel();
            this.rdbFem = new System.Windows.Forms.RadioButton();
            this.rdbMasc = new System.Windows.Forms.RadioButton();
            this.lblNac = new System.Windows.Forms.Label();
            this.cboNac = new System.Windows.Forms.ComboBox();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.txtFechNac = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.pnlGen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExpedCed
            // 
            this.lblExpedCed.AutoSize = true;
            this.lblExpedCed.ForeColor = System.Drawing.Color.Blue;
            this.lblExpedCed.Location = new System.Drawing.Point(186, 133);
            this.lblExpedCed.Name = "lblExpedCed";
            this.lblExpedCed.Size = new System.Drawing.Size(92, 13);
            this.lblExpedCed.TabIndex = 0;
            this.lblExpedCed.Text = "Fecha Expedición";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.ForeColor = System.Drawing.Color.Blue;
            this.lblBusqueda.Location = new System.Drawing.Point(12, 69);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(150, 13);
            this.lblBusqueda.TabIndex = 1;
            this.lblBusqueda.Text = "Digite la cédula del Estudiante";
            // 
            // lblCed
            // 
            this.lblCed.AutoSize = true;
            this.lblCed.ForeColor = System.Drawing.Color.Blue;
            this.lblCed.Location = new System.Drawing.Point(12, 129);
            this.lblCed.Name = "lblCed";
            this.lblCed.Size = new System.Drawing.Size(40, 13);
            this.lblCed.TabIndex = 2;
            this.lblCed.Text = "Cédula";
            this.lblCed.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblExpirCed
            // 
            this.lblExpirCed.AutoSize = true;
            this.lblExpirCed.ForeColor = System.Drawing.Color.Blue;
            this.lblExpirCed.Location = new System.Drawing.Point(440, 133);
            this.lblExpirCed.Name = "lblExpirCed";
            this.lblExpirCed.Size = new System.Drawing.Size(89, 13);
            this.lblExpirCed.TabIndex = 3;
            this.lblExpirCed.Text = "Fecha Expiración";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.ForeColor = System.Drawing.Color.Blue;
            this.lblGenero.Location = new System.Drawing.Point(12, 224);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Genero";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Blue;
            this.lblNombre.Location = new System.Drawing.Point(12, 178);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPrimerAp
            // 
            this.lblPrimerAp.AutoSize = true;
            this.lblPrimerAp.ForeColor = System.Drawing.Color.Blue;
            this.lblPrimerAp.Location = new System.Drawing.Point(186, 178);
            this.lblPrimerAp.Name = "lblPrimerAp";
            this.lblPrimerAp.Size = new System.Drawing.Size(76, 13);
            this.lblPrimerAp.TabIndex = 6;
            this.lblPrimerAp.Text = "Primer Apellido";
            // 
            // lblSegAp
            // 
            this.lblSegAp.AutoSize = true;
            this.lblSegAp.ForeColor = System.Drawing.Color.Blue;
            this.lblSegAp.Location = new System.Drawing.Point(440, 178);
            this.lblSegAp.Name = "lblSegAp";
            this.lblSegAp.Size = new System.Drawing.Size(90, 13);
            this.lblSegAp.TabIndex = 7;
            this.lblSegAp.Text = "Segundo Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(62, 171);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.txtNombre_Validating);
            // 
            // txtCédula
            // 
            this.txtCédula.ForeColor = System.Drawing.Color.Black;
            this.txtCédula.Location = new System.Drawing.Point(62, 126);
            this.txtCédula.Name = "txtCédula";
            this.txtCédula.Size = new System.Drawing.Size(100, 20);
            this.txtCédula.TabIndex = 9;
            this.txtCédula.Validating += new System.ComponentModel.CancelEventHandler(this.txtCédula_Validating);
            // 
            // txtPriAp
            // 
            this.txtPriAp.Location = new System.Drawing.Point(292, 175);
            this.txtPriAp.Name = "txtPriAp";
            this.txtPriAp.Size = new System.Drawing.Size(100, 20);
            this.txtPriAp.TabIndex = 13;
            // 
            // txtCedBusqueda
            // 
            this.txtCedBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedBusqueda.Location = new System.Drawing.Point(180, 66);
            this.txtCedBusqueda.Name = "txtCedBusqueda";
            this.txtCedBusqueda.Size = new System.Drawing.Size(100, 22);
            this.txtCedBusqueda.TabIndex = 14;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbInsertar,
            this.toolStripSeparator1,
            this.tsbMod,
            this.toolStripSeparator2,
            this.tsbElim,
            this.toolStripSeparator3,
            this.tsbCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(668, 44);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // tsbInsertar
            // 
            this.tsbInsertar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tsbInsertar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbInsertar.Image = ((System.Drawing.Image)(resources.GetObject("tsbInsertar.Image")));
            this.tsbInsertar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInsertar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertar.Name = "tsbInsertar";
            this.tsbInsertar.Size = new System.Drawing.Size(70, 41);
            this.tsbInsertar.Text = "Insertar";
            this.tsbInsertar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsbInsertar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbInsertar.Click += new System.EventHandler(this.tsbInsertar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbMod
            // 
            this.tsbMod.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbMod.Image = ((System.Drawing.Image)(resources.GetObject("tsbMod.Image")));
            this.tsbMod.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMod.Name = "tsbMod";
            this.tsbMod.Size = new System.Drawing.Size(85, 41);
            this.tsbMod.Text = "Modificar";
            this.tsbMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMod.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbElim
            // 
            this.tsbElim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbElim.Image = ((System.Drawing.Image)(resources.GetObject("tsbElim.Image")));
            this.tsbElim.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElim.Name = "tsbElim";
            this.tsbElim.Size = new System.Drawing.Size(71, 41);
            this.tsbElim.Text = "Eliminar";
            this.tsbElim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbElim.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 44);
            // 
            // tsbCancelar
            // 
            this.tsbCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelar.Image")));
            this.tsbCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelar.Name = "tsbCancelar";
            this.tsbCancelar.Size = new System.Drawing.Size(45, 41);
            this.tsbCancelar.Text = "Salir";
            this.tsbCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelar.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // lblExpCed
            // 
            this.lblExpCed.AutoSize = true;
            this.lblExpCed.Location = new System.Drawing.Point(186, 133);
            this.lblExpCed.Name = "lblExpCed";
            this.lblExpCed.Size = new System.Drawing.Size(35, 13);
            this.lblExpCed.TabIndex = 0;
            this.lblExpCed.Text = "Expiración";
            // 
            // txtEXP
            // 
            this.txtEXP.Location = new System.Drawing.Point(298, 126);
            this.txtEXP.Name = "txtEXP";
            this.txtEXP.Size = new System.Drawing.Size(100, 20);
            this.txtEXP.TabIndex = 12;
            // 
            // lblCedu
            // 
            this.lblCedu.AutoSize = true;
            this.lblCedu.Location = new System.Drawing.Point(12, 129);
            this.lblCedu.Name = "lblCedu";
            this.lblCedu.Size = new System.Drawing.Size(40, 13);
            this.lblCedu.TabIndex = 2;
            this.lblCedu.Text = "Cédula";
            this.lblCedu.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtExpedCed
            // 
            this.txtExpedCed.Location = new System.Drawing.Point(292, 126);
            this.txtExpedCed.Mask = "00/00/0000";
            this.txtExpedCed.Name = "txtExpedCed";
            this.txtExpedCed.Size = new System.Drawing.Size(83, 20);
            this.txtExpedCed.TabIndex = 21;
            this.txtExpedCed.ValidatingType = typeof(System.DateTime);
            this.txtExpedCed.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtExpCed_MaskInputRejected);
            // 
            // txtExpCed
            // 
            this.txtExpCed.Location = new System.Drawing.Point(292, 126);
            this.txtExpCed.Mask = "00/00/0000";
            this.txtExpCed.Name = "txtExpCed";
            this.txtExpCed.Size = new System.Drawing.Size(83, 20);
            this.txtExpCed.TabIndex = 21;
            this.txtExpCed.ValidatingType = typeof(System.DateTime);
            this.txtExpCed.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtExpCed_MaskInputRejected);
            // 
            // txtExpirCed
            // 
            this.txtExpirCed.Location = new System.Drawing.Point(544, 126);
            this.txtExpirCed.Mask = "00/00/0000";
            this.txtExpirCed.Name = "txtExpirCed";
            this.txtExpirCed.Size = new System.Drawing.Size(83, 20);
            this.txtExpirCed.TabIndex = 22;
            this.txtExpirCed.ValidatingType = typeof(System.DateTime);
            // 
            // txtSegAp
            // 
            this.txtSegAp.Location = new System.Drawing.Point(544, 175);
            this.txtSegAp.Name = "txtSegAp";
            this.txtSegAp.Size = new System.Drawing.Size(100, 20);
            this.txtSegAp.TabIndex = 23;
            // 
            // pnlGen
            // 
            this.pnlGen.Controls.Add(this.rdbFem);
            this.pnlGen.Controls.Add(this.rdbMasc);
            this.pnlGen.Location = new System.Drawing.Point(60, 213);
            this.pnlGen.Name = "pnlGen";
            this.pnlGen.Size = new System.Drawing.Size(102, 63);
            this.pnlGen.TabIndex = 24;
            // 
            // rdbFem
            // 
            this.rdbFem.AutoSize = true;
            this.rdbFem.ForeColor = System.Drawing.Color.Blue;
            this.rdbFem.Location = new System.Drawing.Point(20, 38);
            this.rdbFem.Name = "rdbFem";
            this.rdbFem.Size = new System.Drawing.Size(31, 17);
            this.rdbFem.TabIndex = 1;
            this.rdbFem.TabStop = true;
            this.rdbFem.Text = "F";
            this.rdbFem.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbFem.UseVisualStyleBackColor = true;
            // 
            // rdbMasc
            // 
            this.rdbMasc.AutoSize = true;
            this.rdbMasc.ForeColor = System.Drawing.Color.Blue;
            this.rdbMasc.Location = new System.Drawing.Point(20, 4);
            this.rdbMasc.Name = "rdbMasc";
            this.rdbMasc.Size = new System.Drawing.Size(34, 17);
            this.rdbMasc.TabIndex = 0;
            this.rdbMasc.TabStop = true;
            this.rdbMasc.Text = "M";
            this.rdbMasc.UseVisualStyleBackColor = true;
            // 
            // lblNac
            // 
            this.lblNac.AutoSize = true;
            this.lblNac.ForeColor = System.Drawing.Color.Blue;
            this.lblNac.Location = new System.Drawing.Point(186, 224);
            this.lblNac.Name = "lblNac";
            this.lblNac.Size = new System.Drawing.Size(69, 13);
            this.lblNac.TabIndex = 25;
            this.lblNac.Text = "Nacionalidad";
            // 
            // cboNac
            // 
            this.cboNac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNac.FormattingEnabled = true;
            this.cboNac.Location = new System.Drawing.Point(292, 224);
            this.cboNac.Name = "cboNac";
            this.cboNac.Size = new System.Drawing.Size(121, 21);
            this.cboNac.Sorted = true;
            this.cboNac.TabIndex = 26;
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.ForeColor = System.Drawing.Color.Blue;
            this.lblFechNac.Location = new System.Drawing.Point(440, 232);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(93, 13);
            this.lblFechNac.TabIndex = 27;
            this.lblFechNac.Text = "Fecha Nacimiento";
            // 
            // txtFechNac
            // 
            this.txtFechNac.Location = new System.Drawing.Point(544, 225);
            this.txtFechNac.Mask = "00/00/0000";
            this.txtFechNac.Name = "txtFechNac";
            this.txtFechNac.Size = new System.Drawing.Size(83, 20);
            this.txtFechNac.TabIndex = 28;
            this.txtFechNac.ValidatingType = typeof(System.DateTime);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Blue;
            this.btnBuscar.Location = new System.Drawing.Point(300, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 33);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btnGuardar.Location = new System.Drawing.Point(271, 265);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(142, 31);
            this.btnGuardar.TabIndex = 30;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(443, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 31);
            this.button1.TabIndex = 31;
            this.button1.Text = "Descartar Cambios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMantenEstud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(668, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtFechNac);
            this.Controls.Add(this.lblFechNac);
            this.Controls.Add(this.cboNac);
            this.Controls.Add(this.lblNac);
            this.Controls.Add(this.pnlGen);
            this.Controls.Add(this.txtSegAp);
            this.Controls.Add(this.txtExpirCed);
            this.Controls.Add(this.txtExpedCed);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtCedBusqueda);
            this.Controls.Add(this.txtPriAp);
            this.Controls.Add(this.txtCédula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblSegAp);
            this.Controls.Add(this.lblPrimerAp);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblExpirCed);
            this.Controls.Add(this.lblCed);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblExpedCed);
            this.Name = "FrmMantenEstud";
            this.ShowIcon = false;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.FrmMantenEstud_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnlGen.ResumeLayout(false);
            this.pnlGen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpedCed;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.Label lblCed;
        private System.Windows.Forms.Label lblExpirCed;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrimerAp;
        private System.Windows.Forms.Label lblSegAp;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCédula;
        private System.Windows.Forms.TextBox txtPriAp;
        private System.Windows.Forms.TextBox txtCedBusqueda;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbInsertar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbMod;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbElim;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbCancelar;
        private System.Windows.Forms.Label lblExpCed;
        private System.Windows.Forms.TextBox txtEXP;
        private System.Windows.Forms.Label lblCedu;
        private System.Windows.Forms.MaskedTextBox txtExpedCed;
        private System.Windows.Forms.MaskedTextBox txtExpCed;
        private System.Windows.Forms.MaskedTextBox txtExpirCed;
        private System.Windows.Forms.TextBox txtSegAp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlGen;
        private System.Windows.Forms.RadioButton rdbFem;
        private System.Windows.Forms.RadioButton rdbMasc;
        private System.Windows.Forms.Label lblNac;
        private System.Windows.Forms.ComboBox cboNac;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.MaskedTextBox txtFechNac;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}