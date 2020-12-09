<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FichaExpediente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidoLabel As System.Windows.Forms.Label
        Dim IdedadLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim IdalergiaLabel As System.Windows.Forms.Label
        Dim IdDatosLabel As System.Windows.Forms.Label
        Dim IdfamiliarLabel As System.Windows.Forms.Label
        Dim FechaReLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FichaExpediente))
        Me.DBClinicaDataSet = New holaMundo.DBClinicaDataSet()
        Me.ExpedienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ExpedienteTableAdapter = New holaMundo.DBClinicaDataSetTableAdapters.expedienteTableAdapter()
        Me.TableAdapterManager = New holaMundo.DBClinicaDataSetTableAdapters.TableAdapterManager()
        Me.ExpedienteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExpedienteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidoTextBox = New System.Windows.Forms.TextBox()
        Me.IdedadComboBox = New System.Windows.Forms.ComboBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.IdalergiaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdDatosComboBox = New System.Windows.Forms.ComboBox()
        Me.IdfamiliarComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaReTextBox = New System.Windows.Forms.TextBox()
        Me.DetallesEnfermedadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetallesEnfermedadTableAdapter = New holaMundo.DBClinicaDataSetTableAdapters.DetallesEnfermedadTableAdapter()
        Me.DetallesEnfermedadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidoLabel = New System.Windows.Forms.Label()
        IdedadLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        IdalergiaLabel = New System.Windows.Forms.Label()
        IdDatosLabel = New System.Windows.Forms.Label()
        IdfamiliarLabel = New System.Windows.Forms.Label()
        FechaReLabel = New System.Windows.Forms.Label()
        CType(Me.DBClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExpedienteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ExpedienteBindingNavigator.SuspendLayout()
        CType(Me.DetallesEnfermedadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallesEnfermedadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(12, 51)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(67, 20)
        NombreLabel.TabIndex = 3
        NombreLabel.Text = "nombre:"
        '
        'ApellidoLabel
        '
        ApellidoLabel.AutoSize = True
        ApellidoLabel.Location = New System.Drawing.Point(12, 83)
        ApellidoLabel.Name = "ApellidoLabel"
        ApellidoLabel.Size = New System.Drawing.Size(67, 20)
        ApellidoLabel.TabIndex = 5
        ApellidoLabel.Text = "apellido:"
        '
        'IdedadLabel
        '
        IdedadLabel.AutoSize = True
        IdedadLabel.Location = New System.Drawing.Point(12, 115)
        IdedadLabel.Name = "IdedadLabel"
        IdedadLabel.Size = New System.Drawing.Size(63, 20)
        IdedadLabel.TabIndex = 7
        IdedadLabel.Text = "Idedad:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Location = New System.Drawing.Point(261, 54)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(48, 20)
        PesoLabel.TabIndex = 9
        PesoLabel.Text = "peso:"
        '
        'IdalergiaLabel
        '
        IdalergiaLabel.AutoSize = True
        IdalergiaLabel.Location = New System.Drawing.Point(261, 86)
        IdalergiaLabel.Name = "IdalergiaLabel"
        IdalergiaLabel.Size = New System.Drawing.Size(74, 20)
        IdalergiaLabel.TabIndex = 11
        IdalergiaLabel.Text = "Idalergia:"
        '
        'IdDatosLabel
        '
        IdDatosLabel.AutoSize = True
        IdDatosLabel.Location = New System.Drawing.Point(261, 118)
        IdDatosLabel.Name = "IdDatosLabel"
        IdDatosLabel.Size = New System.Drawing.Size(143, 20)
        IdDatosLabel.TabIndex = 13
        IdDatosLabel.Text = " Datos Personales:"
        '
        'IdfamiliarLabel
        '
        IdfamiliarLabel.AutoSize = True
        IdfamiliarLabel.Location = New System.Drawing.Point(610, 49)
        IdfamiliarLabel.Name = "IdfamiliarLabel"
        IdfamiliarLabel.Size = New System.Drawing.Size(77, 20)
        IdfamiliarLabel.TabIndex = 15
        IdfamiliarLabel.Text = "Idfamiliar:"
        '
        'FechaReLabel
        '
        FechaReLabel.AutoSize = True
        FechaReLabel.Location = New System.Drawing.Point(610, 83)
        FechaReLabel.Name = "FechaReLabel"
        FechaReLabel.Size = New System.Drawing.Size(78, 20)
        FechaReLabel.TabIndex = 17
        FechaReLabel.Text = "fecha Re:"
        '
        'DBClinicaDataSet
        '
        Me.DBClinicaDataSet.DataSetName = "DBClinicaDataSet"
        Me.DBClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ExpedienteBindingSource
        '
        Me.ExpedienteBindingSource.DataMember = "expediente"
        Me.ExpedienteBindingSource.DataSource = Me.DBClinicaDataSet
        '
        'ExpedienteTableAdapter
        '
        Me.ExpedienteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.alergiaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CargoPersonalTableAdapter = Nothing
        Me.TableAdapterManager.DatosPersonalesTableAdapter = Nothing
        Me.TableAdapterManager.DExpedienteTableAdapter = Nothing
        Me.TableAdapterManager.DfamiliaTableAdapter = Nothing
        Me.TableAdapterManager.diagnosticoTableAdapter = Nothing
        Me.TableAdapterManager.enfermedadesTableAdapter = Nothing
        Me.TableAdapterManager.especialistaTableAdapter = Nothing
        Me.TableAdapterManager.expedienteTableAdapter = Me.ExpedienteTableAdapter
        Me.TableAdapterManager.generoTableAdapter = Nothing
        Me.TableAdapterManager.horarioTableAdapter = Nothing
        Me.TableAdapterManager.medicinaTableAdapter = Nothing
        Me.TableAdapterManager.personalTableAdapter = Nothing
        Me.TableAdapterManager.proveedorTableAdapter = Nothing
        Me.TableAdapterManager.recetaTableAdapter = Nothing
        Me.TableAdapterManager.tipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.trasladoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = holaMundo.DBClinicaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'ExpedienteBindingNavigator
        '
        Me.ExpedienteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ExpedienteBindingNavigator.BindingSource = Me.ExpedienteBindingSource
        Me.ExpedienteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ExpedienteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ExpedienteBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ExpedienteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ExpedienteBindingNavigatorSaveItem})
        Me.ExpedienteBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ExpedienteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ExpedienteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ExpedienteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ExpedienteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ExpedienteBindingNavigator.Name = "ExpedienteBindingNavigator"
        Me.ExpedienteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ExpedienteBindingNavigator.Size = New System.Drawing.Size(1239, 33)
        Me.ExpedienteBindingNavigator.TabIndex = 0
        Me.ExpedienteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(57, 28)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'ExpedienteBindingNavigatorSaveItem
        '
        Me.ExpedienteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExpedienteBindingNavigatorSaveItem.Image = CType(resources.GetObject("ExpedienteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ExpedienteBindingNavigatorSaveItem.Name = "ExpedienteBindingNavigatorSaveItem"
        Me.ExpedienteBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.ExpedienteBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "nombre", True))
        Me.NombreTextBox.Location = New System.Drawing.Point(129, 48)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(121, 26)
        Me.NombreTextBox.TabIndex = 4
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "apellido", True))
        Me.ApellidoTextBox.Location = New System.Drawing.Point(129, 80)
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.ApellidoTextBox.TabIndex = 6
        '
        'IdedadComboBox
        '
        Me.IdedadComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "Idedad", True))
        Me.IdedadComboBox.FormattingEnabled = True
        Me.IdedadComboBox.Location = New System.Drawing.Point(129, 112)
        Me.IdedadComboBox.Name = "IdedadComboBox"
        Me.IdedadComboBox.Size = New System.Drawing.Size(121, 28)
        Me.IdedadComboBox.TabIndex = 8
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(410, 45)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(121, 26)
        Me.PesoTextBox.TabIndex = 10
        '
        'IdalergiaComboBox
        '
        Me.IdalergiaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "Idalergia", True))
        Me.IdalergiaComboBox.FormattingEnabled = True
        Me.IdalergiaComboBox.Location = New System.Drawing.Point(410, 80)
        Me.IdalergiaComboBox.Name = "IdalergiaComboBox"
        Me.IdalergiaComboBox.Size = New System.Drawing.Size(121, 28)
        Me.IdalergiaComboBox.TabIndex = 12
        '
        'IdDatosComboBox
        '
        Me.IdDatosComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "IdDatos", True))
        Me.IdDatosComboBox.FormattingEnabled = True
        Me.IdDatosComboBox.Location = New System.Drawing.Point(410, 114)
        Me.IdDatosComboBox.Name = "IdDatosComboBox"
        Me.IdDatosComboBox.Size = New System.Drawing.Size(121, 28)
        Me.IdDatosComboBox.TabIndex = 14
        '
        'IdfamiliarComboBox
        '
        Me.IdfamiliarComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "Idfamiliar", True))
        Me.IdfamiliarComboBox.FormattingEnabled = True
        Me.IdfamiliarComboBox.Location = New System.Drawing.Point(727, 46)
        Me.IdfamiliarComboBox.Name = "IdfamiliarComboBox"
        Me.IdfamiliarComboBox.Size = New System.Drawing.Size(121, 28)
        Me.IdfamiliarComboBox.TabIndex = 16
        '
        'FechaReTextBox
        '
        Me.FechaReTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ExpedienteBindingSource, "fechaRe", True))
        Me.FechaReTextBox.Location = New System.Drawing.Point(727, 80)
        Me.FechaReTextBox.Name = "FechaReTextBox"
        Me.FechaReTextBox.Size = New System.Drawing.Size(121, 26)
        Me.FechaReTextBox.TabIndex = 18
        '
        'DetallesEnfermedadBindingSource
        '
        Me.DetallesEnfermedadBindingSource.DataMember = "FK_DExpediente_expediente1"
        Me.DetallesEnfermedadBindingSource.DataSource = Me.ExpedienteBindingSource
        '
        'DetallesEnfermedadTableAdapter
        '
        Me.DetallesEnfermedadTableAdapter.ClearBeforeFill = True
        '
        'DetallesEnfermedadDataGridView
        '
        Me.DetallesEnfermedadDataGridView.AllowUserToAddRows = False
        Me.DetallesEnfermedadDataGridView.AllowUserToDeleteRows = False
        Me.DetallesEnfermedadDataGridView.AutoGenerateColumns = False
        Me.DetallesEnfermedadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetallesEnfermedadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.DetallesEnfermedadDataGridView.DataSource = Me.DetallesEnfermedadBindingSource
        Me.DetallesEnfermedadDataGridView.Location = New System.Drawing.Point(16, 165)
        Me.DetallesEnfermedadDataGridView.Name = "DetallesEnfermedadDataGridView"
        Me.DetallesEnfermedadDataGridView.ReadOnly = True
        Me.DetallesEnfermedadDataGridView.RowHeadersWidth = 62
        Me.DetallesEnfermedadDataGridView.RowTemplate.Height = 28
        Me.DetallesEnfermedadDataGridView.Size = New System.Drawing.Size(818, 469)
        Me.DetallesEnfermedadDataGridView.TabIndex = 18
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdDetalleD"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdDetalleD"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdExpediente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdExpediente"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEnfermedad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdEnfermedad"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn4.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn5.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'FichaExpediente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1239, 676)
        Me.Controls.Add(Me.DetallesEnfermedadDataGridView)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(ApellidoLabel)
        Me.Controls.Add(Me.ApellidoTextBox)
        Me.Controls.Add(IdedadLabel)
        Me.Controls.Add(Me.IdedadComboBox)
        Me.Controls.Add(PesoLabel)
        Me.Controls.Add(Me.PesoTextBox)
        Me.Controls.Add(IdalergiaLabel)
        Me.Controls.Add(Me.IdalergiaComboBox)
        Me.Controls.Add(IdDatosLabel)
        Me.Controls.Add(Me.IdDatosComboBox)
        Me.Controls.Add(IdfamiliarLabel)
        Me.Controls.Add(Me.IdfamiliarComboBox)
        Me.Controls.Add(FechaReLabel)
        Me.Controls.Add(Me.FechaReTextBox)
        Me.Controls.Add(Me.ExpedienteBindingNavigator)
        Me.Name = "FichaExpediente"
        Me.Text = "FichaExpediente"
        CType(Me.DBClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExpedienteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ExpedienteBindingNavigator.ResumeLayout(False)
        Me.ExpedienteBindingNavigator.PerformLayout()
        CType(Me.DetallesEnfermedadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallesEnfermedadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DBClinicaDataSet As DBClinicaDataSet
    Friend WithEvents ExpedienteBindingSource As BindingSource
    Friend WithEvents ExpedienteTableAdapter As DBClinicaDataSetTableAdapters.expedienteTableAdapter
    Friend WithEvents TableAdapterManager As DBClinicaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ExpedienteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ExpedienteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidoTextBox As TextBox
    Friend WithEvents IdedadComboBox As ComboBox
    Friend WithEvents PesoTextBox As TextBox
    Friend WithEvents IdalergiaComboBox As ComboBox
    Friend WithEvents IdDatosComboBox As ComboBox
    Friend WithEvents IdfamiliarComboBox As ComboBox
    Friend WithEvents FechaReTextBox As TextBox
    Friend WithEvents DetallesEnfermedadBindingSource As BindingSource
    Friend WithEvents DetallesEnfermedadTableAdapter As DBClinicaDataSetTableAdapters.DetallesEnfermedadTableAdapter
    Friend WithEvents DetallesEnfermedadDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
End Class
