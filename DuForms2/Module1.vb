Module Module1

    Sub Main()
        Dim F1 As New MainForm
        F1.Text = InputBox("Tento dialog byl spusten z konzole jako dukaz pro ucely vyuky, muzete ho ale vyuzit k nastaveni titulku hlavniho okna aplikace...", "Z konzole", "Objednavka Nabytku",,)
        F1.ShowDialog()

    End Sub

End Module
