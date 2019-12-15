<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Principal))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvProduto = New System.Windows.Forms.DataGridView()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.dtpCadastro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFornec = New System.Windows.Forms.TextBox()
        Me.txtMin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSaldoIni = New System.Windows.Forms.TextBox()
        Me.txtUnid = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnEditar = New System.Windows.Forms.Button()
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnEntrada = New System.Windows.Forms.Button()
        Me.btnSaida = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbxLogo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalProdCad = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalEntProd = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTotalSaiProd = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(663, -1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Médias"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(483, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Estoques"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 70
        Me.Label8.Text = "Cod"
        '
        'dgvProduto
        '
        Me.dgvProduto.AllowUserToAddRows = False
        Me.dgvProduto.AllowUserToDeleteRows = False
        Me.dgvProduto.AllowUserToResizeColumns = False
        Me.dgvProduto.AllowUserToResizeRows = False
        Me.dgvProduto.BackgroundColor = System.Drawing.Color.White
        Me.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduto.Location = New System.Drawing.Point(6, 16)
        Me.dgvProduto.MultiSelect = False
        Me.dgvProduto.Name = "dgvProduto"
        Me.dgvProduto.ReadOnly = True
        Me.dgvProduto.RowHeadersVisible = False
        Me.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduto.Size = New System.Drawing.Size(800, 296)
        Me.dgvProduto.TabIndex = 63
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.White
        Me.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNome.Enabled = False
        Me.txtNome.Location = New System.Drawing.Point(214, 25)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(426, 14)
        Me.txtNome.TabIndex = 55
        '
        'dtpCadastro
        '
        Me.dtpCadastro.Enabled = False
        Me.dtpCadastro.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCadastro.Location = New System.Drawing.Point(704, 56)
        Me.dtpCadastro.Name = "dtpCadastro"
        Me.dtpCadastro.Size = New System.Drawing.Size(93, 22)
        Me.dtpCadastro.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(165, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(642, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Cadastro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Fornecedor"
        '
        'txtFornec
        '
        Me.txtFornec.BackColor = System.Drawing.Color.White
        Me.txtFornec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFornec.Enabled = False
        Me.txtFornec.Location = New System.Drawing.Point(90, 62)
        Me.txtFornec.MaxLength = 40
        Me.txtFornec.Name = "txtFornec"
        Me.txtFornec.Size = New System.Drawing.Size(270, 14)
        Me.txtFornec.TabIndex = 57
        '
        'txtMin
        '
        Me.txtMin.BackColor = System.Drawing.Color.White
        Me.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMin.Enabled = False
        Me.txtMin.Location = New System.Drawing.Point(435, 62)
        Me.txtMin.MaxLength = 5
        Me.txtMin.Name = "txtMin"
        Me.txtMin.Size = New System.Drawing.Size(45, 14)
        Me.txtMin.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Saldo Inicial"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Mínimo"
        '
        'txtSaldoIni
        '
        Me.txtSaldoIni.BackColor = System.Drawing.Color.White
        Me.txtSaldoIni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldoIni.Enabled = False
        Me.txtSaldoIni.Location = New System.Drawing.Point(583, 62)
        Me.txtSaldoIni.MaxLength = 5
        Me.txtSaldoIni.Name = "txtSaldoIni"
        Me.txtSaldoIni.Size = New System.Drawing.Size(45, 14)
        Me.txtSaldoIni.TabIndex = 59
        '
        'txtUnid
        '
        Me.txtUnid.BackColor = System.Drawing.Color.White
        Me.txtUnid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnid.Enabled = False
        Me.txtUnid.Location = New System.Drawing.Point(723, 25)
        Me.txtUnid.MaxLength = 10
        Me.txtUnid.Name = "txtUnid"
        Me.txtUnid.Size = New System.Drawing.Size(67, 14)
        Me.txtUnid.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(656, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Unidade"
        '
        'btnCancelar
        '
        Me.btnCancelar.Enabled = False
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(378, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 65)
        Me.btnCancelar.TabIndex = 62
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmar.Image = CType(resources.GetObject("btnConfirmar.Image"), System.Drawing.Image)
        Me.btnConfirmar.Location = New System.Drawing.Point(307, 12)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(65, 65)
        Me.btnConfirmar.TabIndex = 61
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtCod
        '
        Me.txtCod.BackColor = System.Drawing.Color.White
        Me.txtCod.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCod.Enabled = False
        Me.txtCod.Location = New System.Drawing.Point(90, 25)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(48, 14)
        Me.txtCod.TabIndex = 54
        Me.txtCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExcluir
        '
        Me.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.Location = New System.Drawing.Point(154, 12)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(65, 65)
        Me.btnExcluir.TabIndex = 53
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnEditar
        '
        Me.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Location = New System.Drawing.Point(83, 12)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(65, 65)
        Me.btnEditar.TabIndex = 52
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.Location = New System.Drawing.Point(12, 12)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(65, 65)
        Me.btnAdicionar.TabIndex = 51
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnEntrada
        '
        Me.btnEntrada.AutoSize = True
        Me.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntrada.Image = CType(resources.GetObject("btnEntrada.Image"), System.Drawing.Image)
        Me.btnEntrada.Location = New System.Drawing.Point(543, 12)
        Me.btnEntrada.Name = "btnEntrada"
        Me.btnEntrada.Size = New System.Drawing.Size(65, 65)
        Me.btnEntrada.TabIndex = 102
        Me.btnEntrada.Text = "Entrada"
        Me.btnEntrada.UseVisualStyleBackColor = True
        '
        'btnSaida
        '
        Me.btnSaida.AutoSize = True
        Me.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaida.Image = CType(resources.GetObject("btnSaida.Image"), System.Drawing.Image)
        Me.btnSaida.Location = New System.Drawing.Point(614, 12)
        Me.btnSaida.Name = "btnSaida"
        Me.btnSaida.Size = New System.Drawing.Size(65, 66)
        Me.btnSaida.TabIndex = 103
        Me.btnSaida.Text = "Saída"
        Me.btnSaida.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Controls.Add(Me.dtpCadastro)
        Me.GroupBox1.Controls.Add(Me.txtSaldoIni)
        Me.GroupBox1.Controls.Add(Me.PictureBox6)
        Me.GroupBox1.Controls.Add(Me.txtMin)
        Me.GroupBox1.Controls.Add(Me.PictureBox5)
        Me.GroupBox1.Controls.Add(Me.txtFornec)
        Me.GroupBox1.Controls.Add(Me.PictureBox4)
        Me.GroupBox1.Controls.Add(Me.txtUnid)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.txtNome)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.txtCod)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(813, 99)
        Me.GroupBox1.TabIndex = 104
        Me.GroupBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(575, 55)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(61, 28)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox6.TabIndex = 111
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(427, 55)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(61, 28)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 110
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(83, 55)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(284, 28)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 109
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(715, 17)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(82, 28)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 108
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(208, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(438, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 107
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(83, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvProduto)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 189)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(813, 323)
        Me.GroupBox2.TabIndex = 105
        Me.GroupBox2.TabStop = False
        '
        'pbxLogo
        '
        Me.pbxLogo.Image = CType(resources.GetObject("pbxLogo.Image"), System.Drawing.Image)
        Me.pbxLogo.Location = New System.Drawing.Point(758, 12)
        Me.pbxLogo.Name = "pbxLogo"
        Me.pbxLogo.Size = New System.Drawing.Size(65, 65)
        Me.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbxLogo.TabIndex = 111
        Me.pbxLogo.TabStop = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblTotalProdCad, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblTotalEntProd, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel6, Me.lblTotalSaiProd})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 526)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(835, 22)
        Me.StatusStrip1.TabIndex = 112
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(129, 17)
        Me.ToolStripStatusLabel1.Text = "Produtos Cadastrados :"
        '
        'lblTotalProdCad
        '
        Me.lblTotalProdCad.Name = "lblTotalProdCad"
        Me.lblTotalProdCad.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalProdCad.Text = "0"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(120, 17)
        Me.ToolStripStatusLabel3.Text = "Entrada de Produtos :"
        '
        'lblTotalEntProd
        '
        Me.lblTotalEntProd.Name = "lblTotalEntProd"
        Me.lblTotalEntProd.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalEntProd.Text = "0"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(108, 17)
        Me.ToolStripStatusLabel6.Text = "Saída de Produtos :"
        '
        'lblTotalSaiProd
        '
        Me.lblTotalSaiProd.Name = "lblTotalSaiProd"
        Me.lblTotalSaiProd.Size = New System.Drawing.Size(13, 17)
        Me.lblTotalSaiProd.Text = "0"
        '
        'frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(835, 548)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.pbxLogo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnSaida)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.btnEntrada)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CADFácil Sistemas - Controle de Estoque"
        CType(Me.dgvProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents dgvProduto As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents dtpCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFornec As System.Windows.Forms.TextBox
    Friend WithEvents txtMin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoIni As System.Windows.Forms.TextBox
    Friend WithEvents txtUnid As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnEntrada As System.Windows.Forms.Button
    Friend WithEvents btnSaida As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalProdCad As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalEntProd As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTotalSaiProd As System.Windows.Forms.ToolStripStatusLabel
End Class
