Option Explicit On

Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm
    Public actOrder As New Order
    Public materials As New List(Of String)
    Dim radiobuttons As New List(Of RadioButton)
    Dim radiobuttonBeingEdited As RadioButton
    Public itemTypes As New List(Of String)
    Dim itemBeingEdited As String
    Dim calcVal1 As Integer
    Dim calcVal2 As Integer
    Dim i As Integer
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click, ToolStripButton2.Click, ToolStripButton3.Click
        EscButton.BackgroundImage = sender.image
    End Sub
    Public Sub RefreshMaterialChoices()
        radiobuttons.Clear()
        FlowLayoutPanel1.Controls.Clear()
        Dim e As New EventArgs
        For i = 0 To materials.Count - 1
            radiobuttons.Add(New RadioButton)
            radiobuttons(i).Text = materials(i)
            radiobuttons(i).Parent = FlowLayoutPanel1
            radiobuttons(i).ContextMenuStrip = ContextMenuStripRemoveMaterial
            ToolTip1.SetToolTip(radiobuttons(i), "Pravým tlačítkem myši můžete materiál odebrat z nabídky")
            AddHandler radiobuttons(i).CheckedChanged, AddressOf RefreshOrderChoices
        Next
    End Sub
    Public Sub RefreshITemTypeChoices()
        ItemTypeCombobox.Items.Clear()
        ItemTypeCombobox.Items.AddRange(itemTypes.ToArray)

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        materials.AddRange({"KOV", "DREVO", "PLAST"})
        itemTypes.AddRange({"zidle", "Stul", "Postel"})
        AddHandler ShinyCheckbox.CheckedChanged, AddressOf RefreshOrderChoices
        AddHandler ItemTypeCombobox.TextChanged, AddressOf RefreshOrderChoices
        AddHandler OrderedAmmntNumericUpDown.ValueChanged, AddressOf RefreshOrderChoices
        actOrder.Ammount = OrderedAmmntNumericUpDown.Value
        ActOrderLabel.Text = actOrder.ToString
        ToolStripStatusLabel1.Text = TrackBar.Value
        RefreshMaterialChoices()
        RefreshITemTypeChoices()

    End Sub

    Private Sub PridejMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PridejMaterialToolStripMenuItem.Click
        materials.Add(InputBox("Zadejte material", "Pridani Materialu"))
        RefreshMaterialChoices()
    End Sub
    Private Sub RemoveMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveMaterialToolStripMenuItem.Click
        materials.Remove(radiobuttonBeingEdited.Text)
        RefreshMaterialChoices()
    End Sub

    Private Sub ContextMenuStripRemoveMaterial_Opening(sender As ContextMenuStrip, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripRemoveMaterial.Opening
        radiobuttonBeingEdited = sender.SourceControl
    End Sub

    Private Sub ManipulateItems_Opening(sender As ContextMenuStrip, e As System.ComponentModel.CancelEventArgs) Handles ManipulateItems.Opening
        Dim selectedItem As String
        selectedItem = CType(sender.SourceControl, ComboBox).Text
        If (itemTypes.Contains(selectedItem) Or selectedItem = "") Then
            sender.Items.Item("AddItemPermanently").Enabled = False
        Else
            sender.Items.Item("AddItemPermanently").Enabled = True
        End If
        If (itemTypes.Contains(selectedItem)) Then
            sender.Items.Item("OdebratZMoznostiToolStripMenuItem").Enabled = True
        Else
            sender.Items.Item("OdebratZMoznostiToolStripMenuItem").Enabled = False
        End If
    End Sub

    Private Sub RefreshOrderChoices(sender As Object, e As EventArgs)
        Select Case sender.GetType()
            Case GetType(RadioButton)
                actOrder.Material = CType(sender, RadioButton).Text
            Case GetType(ComboBox)
                actOrder.Type = CType(sender, ComboBox).Text
            Case GetType(CheckBox)
                actOrder.Shiny = CType(sender, CheckBox).Checked
            Case GetType(NumericUpDown)
                actOrder.Ammount = CType(sender, NumericUpDown).Value
            Case Else
        End Select
        ActOrderLabel.Text = actOrder.ToString
    End Sub

    Private Sub ActOrderLabel_DoubleClick(sender As Label, e As EventArgs) Handles ActOrderLabel.DoubleClick
        TextBoxMain.Text += sender.Text
    End Sub

    Private Sub ConfirmCalcButton_Click(sender As Object, e As EventArgs) Handles ConfirmCalcButton.Click
        Dim res As Integer
        Dim font1 As New Font(CalsResultLabel.Font, FontStyle.Bold)
        Dim font2 As New Font(CalsResultLabel.Font, FontStyle.Regular)
        res = calcVal1 + calcVal2
        If res > 0 Then
            CalsResultLabel.Font = font1
        Else
            CalsResultLabel.Font = font2
        End If
        CalsResultLabel.Text = res.ToString
    End Sub
    Public Function ValidateTextBoxForIntWithSign(ByRef tb As TextBox) As Integer
        Dim Result As Integer
        If (Integer.TryParse(tb.Text, Result)) Then
            Return Result
        Else

            If Not tb.Text.Equals("-") Then
                Dim temp As String
                If (tb.Text.Length > 0) Then
                    temp = tb.Text.Substring(0, tb.Text.Length - 1)
                    tb.Text = temp
                End If

            End If
            Return Result
        End If
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        calcVal1 = ValidateTextBoxForIntWithSign(sender)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        calcVal2 = ValidateTextBoxForIntWithSign(sender)
    End Sub

    Private Sub TrackBar_Scroll(sender As TrackBar, e As EventArgs) Handles TrackBar.Scroll
        ToolStripStatusLabel1.Text = sender.Value.ToString
        ToolTip1.SetToolTip(sender, "Nastaveno: " + sender.Value.ToString)
    End Sub
End Class
Public Class Order
    Public Type As String
    Public Material As String
    Public Ammount As Integer
    Public Shiny As Boolean
    Public Overrides Function ToString() As String
        Dim out As String
        out = ""
        out += Me.Ammount.ToString() + " ks :" + Me.Type + ", " + Me.Material
        If Shiny Then
            out += ", v lesklém provedení"
        End If
        Return out
    End Function
End Class