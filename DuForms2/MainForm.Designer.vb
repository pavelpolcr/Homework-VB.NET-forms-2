<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.EndLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SouborToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtevřítToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UložitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NápovědaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZobrazitNápověduToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscButton = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MaterialChoiceGroupbox = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ContextMenuStripAddMaterial = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PridejMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStripRemoveMaterial = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveMaterialToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemTypeCombobox = New System.Windows.Forms.ComboBox()
        Me.ManipulateItems = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AddItemPermanently = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdebratZMoznostiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ActOrderLabel = New System.Windows.Forms.Label()
        Me.ShinyCheckbox = New System.Windows.Forms.CheckBox()
        Me.TextBoxMain = New System.Windows.Forms.TextBox()
        Me.OrderedAmmntNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.OperandLabel = New System.Windows.Forms.Label()
        Me.ConfirmCalcButton = New System.Windows.Forms.Button()
        Me.CalsResultLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TrackBar = New System.Windows.Forms.TrackBar()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.InstallLabel = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialChoiceGroupbox.SuspendLayout()
        Me.ContextMenuStripAddMaterial.SuspendLayout()
        Me.ContextMenuStripRemoveMaterial.SuspendLayout()
        Me.ManipulateItems.SuspendLayout()
        CType(Me.OrderedAmmntNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EndLabel
        '
        Me.EndLabel.AutoSize = True
        Me.EndLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.EndLabel.Location = New System.Drawing.Point(9, 123)
        Me.EndLabel.Name = "EndLabel"
        Me.EndLabel.Size = New System.Drawing.Size(143, 9)
        Me.EndLabel.TabIndex = 9
        Me.EndLabel.Text = "Tlačítko pro ukončení (nebo stiskni ESC)"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        Me.ToolTip1.SetToolTip(Me.ToolStrip1, "Kliknněte na obrázek ke změně ikony tlačítka níže.")
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.DuForms2.My.Resources.Resources.run
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Klikni pro výběr tohoto obrázku pro tlačítko."
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.DuForms2.My.Resources.Resources.fish_escape
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "ToolStripButton2"
        Me.ToolStripButton2.ToolTipText = "Klikni pro výběr tohoto obrázku pro tlačítko."
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.DuForms2.My.Resources.Resources.exit_door
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        Me.ToolStripButton3.ToolTipText = "Klikni pro výběr tohoto obrázku pro tlačítko."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SouborToolStripMenuItem, Me.NápovědaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SouborToolStripMenuItem
        '
        Me.SouborToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OtevřítToolStripMenuItem, Me.UložitToolStripMenuItem})
        Me.SouborToolStripMenuItem.Name = "SouborToolStripMenuItem"
        Me.SouborToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.SouborToolStripMenuItem.Text = "Soubor"
        '
        'OtevřítToolStripMenuItem
        '
        Me.OtevřítToolStripMenuItem.Name = "OtevřítToolStripMenuItem"
        Me.OtevřítToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OtevřítToolStripMenuItem.Text = "Otevřít"
        '
        'UložitToolStripMenuItem
        '
        Me.UložitToolStripMenuItem.Name = "UložitToolStripMenuItem"
        Me.UložitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UložitToolStripMenuItem.Text = "Uložit"
        '
        'NápovědaToolStripMenuItem
        '
        Me.NápovědaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZobrazitNápověduToolStripMenuItem})
        Me.NápovědaToolStripMenuItem.Name = "NápovědaToolStripMenuItem"
        Me.NápovědaToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.NápovědaToolStripMenuItem.Text = "Nápověda"
        '
        'ZobrazitNápověduToolStripMenuItem
        '
        Me.ZobrazitNápověduToolStripMenuItem.Name = "ZobrazitNápověduToolStripMenuItem"
        Me.ZobrazitNápověduToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ZobrazitNápověduToolStripMenuItem.Text = "Zobrazit nápovědu"
        '
        'EscButton
        '
        Me.EscButton.BackgroundImage = Global.DuForms2.My.Resources.Resources.run
        Me.EscButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.EscButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.EscButton.Location = New System.Drawing.Point(50, 61)
        Me.EscButton.Name = "EscButton"
        Me.EscButton.Size = New System.Drawing.Size(43, 41)
        Me.EscButton.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.EscButton, "Stisněte tlačítko nebo ESC pro ukončení")
        Me.EscButton.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(70, -4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(23, 29)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(41, -4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(23, 29)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(23, 29)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'MaterialChoiceGroupbox
        '
        Me.MaterialChoiceGroupbox.Controls.Add(Me.FlowLayoutPanel1)
        Me.MaterialChoiceGroupbox.Location = New System.Drawing.Point(174, 24)
        Me.MaterialChoiceGroupbox.Name = "MaterialChoiceGroupbox"
        Me.MaterialChoiceGroupbox.Size = New System.Drawing.Size(151, 195)
        Me.MaterialChoiceGroupbox.TabIndex = 4
        Me.MaterialChoiceGroupbox.TabStop = False
        Me.MaterialChoiceGroupbox.Text = "Zvolte material"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.ContextMenuStrip = Me.ContextMenuStripAddMaterial
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(5, 19)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(140, 138)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.FlowLayoutPanel1, "Stiskněte pravé tlačítko myši k přidání materiálu")
        '
        'ContextMenuStripAddMaterial
        '
        Me.ContextMenuStripAddMaterial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PridejMaterialToolStripMenuItem})
        Me.ContextMenuStripAddMaterial.Name = "ContextMenuStripAddMaterial"
        Me.ContextMenuStripAddMaterial.Size = New System.Drawing.Size(151, 26)
        '
        'PridejMaterialToolStripMenuItem
        '
        Me.PridejMaterialToolStripMenuItem.Name = "PridejMaterialToolStripMenuItem"
        Me.PridejMaterialToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.PridejMaterialToolStripMenuItem.Text = "Pridej material"
        '
        'ContextMenuStripRemoveMaterial
        '
        Me.ContextMenuStripRemoveMaterial.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveMaterialToolStripMenuItem})
        Me.ContextMenuStripRemoveMaterial.Name = "ContextMenuStripRemoveMaterial"
        Me.ContextMenuStripRemoveMaterial.Size = New System.Drawing.Size(114, 26)
        '
        'RemoveMaterialToolStripMenuItem
        '
        Me.RemoveMaterialToolStripMenuItem.Name = "RemoveMaterialToolStripMenuItem"
        Me.RemoveMaterialToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.RemoveMaterialToolStripMenuItem.Text = "Odeber"
        '
        'ItemTypeCombobox
        '
        Me.ItemTypeCombobox.ContextMenuStrip = Me.ManipulateItems
        Me.ItemTypeCombobox.FormattingEnabled = True
        Me.ItemTypeCombobox.Location = New System.Drawing.Point(12, 160)
        Me.ItemTypeCombobox.Name = "ItemTypeCombobox"
        Me.ItemTypeCombobox.Size = New System.Drawing.Size(140, 21)
        Me.ItemTypeCombobox.TabIndex = 3
        '
        'ManipulateItems
        '
        Me.ManipulateItems.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemPermanently, Me.OdebratZMoznostiToolStripMenuItem})
        Me.ManipulateItems.Name = "RemoveItemTypeStrip"
        Me.ManipulateItems.Size = New System.Drawing.Size(207, 48)
        '
        'AddItemPermanently
        '
        Me.AddItemPermanently.Name = "AddItemPermanently"
        Me.AddItemPermanently.Size = New System.Drawing.Size(206, 22)
        Me.AddItemPermanently.Text = "Pridat trvale do moznosti"
        '
        'OdebratZMoznostiToolStripMenuItem
        '
        Me.OdebratZMoznostiToolStripMenuItem.Name = "OdebratZMoznostiToolStripMenuItem"
        Me.OdebratZMoznostiToolStripMenuItem.Size = New System.Drawing.Size(206, 22)
        Me.OdebratZMoznostiToolStripMenuItem.Text = "Odebrat z moznosti"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zvolte typ vyrobku"
        '
        'ActOrderLabel
        '
        Me.ActOrderLabel.AutoSize = True
        Me.ActOrderLabel.Location = New System.Drawing.Point(9, 347)
        Me.ActOrderLabel.Name = "ActOrderLabel"
        Me.ActOrderLabel.Size = New System.Drawing.Size(0, 13)
        Me.ActOrderLabel.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.ActOrderLabel, "Aktuální volba objednávky. Pro rychlé přenesení do okna editace text můžete použí" &
        "t dvojklik tlačítka myši")
        '
        'ShinyCheckbox
        '
        Me.ShinyCheckbox.AutoSize = True
        Me.ShinyCheckbox.Location = New System.Drawing.Point(331, 85)
        Me.ShinyCheckbox.Name = "ShinyCheckbox"
        Me.ShinyCheckbox.Size = New System.Drawing.Size(129, 17)
        Me.ShinyCheckbox.TabIndex = 5
        Me.ShinyCheckbox.Text = "V lesklém provedení?"
        Me.ShinyCheckbox.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ShinyCheckbox.UseVisualStyleBackColor = True
        '
        'TextBoxMain
        '
        Me.TextBoxMain.Location = New System.Drawing.Point(12, 199)
        Me.TextBoxMain.Multiline = True
        Me.TextBoxMain.Name = "TextBoxMain"
        Me.TextBoxMain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxMain.Size = New System.Drawing.Size(448, 139)
        Me.TextBoxMain.TabIndex = 7
        '
        'OrderedAmmntNumericUpDown
        '
        Me.OrderedAmmntNumericUpDown.Location = New System.Drawing.Point(331, 112)
        Me.OrderedAmmntNumericUpDown.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.OrderedAmmntNumericUpDown.Name = "OrderedAmmntNumericUpDown"
        Me.OrderedAmmntNumericUpDown.Size = New System.Drawing.Size(37, 20)
        Me.OrderedAmmntNumericUpDown.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.OrderedAmmntNumericUpDown, "Počet položek v objednávce(max 3)")
        Me.OrderedAmmntNumericUpDown.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 2000
        Me.ToolTip1.InitialDelay = 500
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 1000
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(536, 43)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(38, 20)
        Me.TextBox1.TabIndex = 11
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(599, 43)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(38, 20)
        Me.TextBox2.TabIndex = 12
        '
        'OperandLabel
        '
        Me.OperandLabel.AutoSize = True
        Me.OperandLabel.Location = New System.Drawing.Point(580, 47)
        Me.OperandLabel.Name = "OperandLabel"
        Me.OperandLabel.Size = New System.Drawing.Size(13, 13)
        Me.OperandLabel.TabIndex = 13
        Me.OperandLabel.Text = "+"
        '
        'ConfirmCalcButton
        '
        Me.ConfirmCalcButton.Location = New System.Drawing.Point(643, 43)
        Me.ConfirmCalcButton.Name = "ConfirmCalcButton"
        Me.ConfirmCalcButton.Size = New System.Drawing.Size(21, 20)
        Me.ConfirmCalcButton.TabIndex = 14
        Me.ConfirmCalcButton.Text = "="
        Me.ConfirmCalcButton.UseVisualStyleBackColor = True
        '
        'CalsResultLabel
        '
        Me.CalsResultLabel.AutoSize = True
        Me.CalsResultLabel.Location = New System.Drawing.Point(670, 47)
        Me.CalsResultLabel.Name = "CalsResultLabel"
        Me.CalsResultLabel.Size = New System.Drawing.Size(0, 13)
        Me.CalsResultLabel.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(374, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Kolik kusu? (max 3)"
        '
        'TrackBar
        '
        Me.TrackBar.LargeChange = 1
        Me.TrackBar.Location = New System.Drawing.Point(536, 123)
        Me.TrackBar.Minimum = 1
        Me.TrackBar.Name = "TrackBar"
        Me.TrackBar.Size = New System.Drawing.Size(104, 45)
        Me.TrackBar.TabIndex = 17
        Me.TrackBar.Value = 1
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 18
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(12, 400)
        Me.ProgressBar.Maximum = 10
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(286, 11)
        Me.ProgressBar.Step = 1
        Me.ProgressBar.TabIndex = 19
        '
        'InstallLabel
        '
        Me.InstallLabel.AutoSize = True
        Me.InstallLabel.Location = New System.Drawing.Point(328, 400)
        Me.InstallLabel.Name = "InstallLabel"
        Me.InstallLabel.Size = New System.Drawing.Size(39, 13)
        Me.InstallLabel.TabIndex = 20
        Me.InstallLabel.Text = "Label3"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "txt|*.txt|Vsechny Soubory|*.*"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "txt"
        Me.SaveFileDialog1.Filter = "txt | *.txt|vsechny soubory|*.*"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.EscButton
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.InstallLabel)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TrackBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CalsResultLabel)
        Me.Controls.Add(Me.ConfirmCalcButton)
        Me.Controls.Add(Me.OperandLabel)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.OrderedAmmntNumericUpDown)
        Me.Controls.Add(Me.TextBoxMain)
        Me.Controls.Add(Me.ShinyCheckbox)
        Me.Controls.Add(Me.ActOrderLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ItemTypeCombobox)
        Me.Controls.Add(Me.MaterialChoiceGroupbox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.EndLabel)
        Me.Controls.Add(Me.EscButton)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Objednávka Nábytku"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialChoiceGroupbox.ResumeLayout(False)
        Me.ContextMenuStripAddMaterial.ResumeLayout(False)
        Me.ContextMenuStripRemoveMaterial.ResumeLayout(False)
        Me.ManipulateItems.ResumeLayout(False)
        CType(Me.OrderedAmmntNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As Windows.Forms.PictureBox
    Friend WithEvents EscButton As Windows.Forms.Button
    Friend WithEvents EndLabel As Windows.Forms.Label
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents NápovědaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZobrazitNápověduToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SouborToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OtevřítToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UložitToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MaterialChoiceGroupbox As Windows.Forms.GroupBox
    Friend WithEvents FlowLayoutPanel1 As Windows.Forms.FlowLayoutPanel
    Friend WithEvents ContextMenuStripAddMaterial As Windows.Forms.ContextMenuStrip
    Friend WithEvents PridejMaterialToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStripRemoveMaterial As Windows.Forms.ContextMenuStrip
    Friend WithEvents RemoveMaterialToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemTypeCombobox As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents ManipulateItems As Windows.Forms.ContextMenuStrip
    Friend WithEvents AddItemPermanently As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OdebratZMoznostiToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActOrderLabel As Windows.Forms.Label
    Friend WithEvents ShinyCheckbox As Windows.Forms.CheckBox
    Friend WithEvents TextBoxMain As Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents OrderedAmmntNumericUpDown As Windows.Forms.NumericUpDown
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents OperandLabel As Windows.Forms.Label
    Friend WithEvents ConfirmCalcButton As Windows.Forms.Button
    Friend WithEvents CalsResultLabel As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents TrackBar As Windows.Forms.TrackBar
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel2 As Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ProgressBar As Windows.Forms.ProgressBar
    Friend WithEvents InstallLabel As Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As Windows.Forms.SaveFileDialog
End Class
