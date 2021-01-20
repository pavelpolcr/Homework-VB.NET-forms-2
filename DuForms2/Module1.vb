Module Module1

    Sub Main()
        Dim F1 As New MainForm
        Dim tempN As Integer

        F1.Text = InputBox("Tento dialog byl spusten z konzole jako dukaz pro ucely vyuky, muzete ho ale vyuzit k nastaveni titulku hlavniho okna aplikace...", "Z konzole", "Objednavka Nabytku",,)
        While Integer.TryParse(InputBox("Zadejte cas instalace jako cele cislo"), tempN) = False

        End While
        F1.cekat = tempN



        F1.ShowDialog()

    End Sub

End Module
