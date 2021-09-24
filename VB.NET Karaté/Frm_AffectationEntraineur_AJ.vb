Imports System.Data.OleDb

Public Class Frm_AffectationEntraineur_AJ
    Private Sub Frm_AffectationEntraineur_AJ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connexion("bdKarate.accdb")
        Grid_Competition.ColumnCount = 2
        Grid_Competition.Columns(0).Width = 200
        Grid_Competition.Columns(1).Width = 200
        Grid_Competition.Columns(0).Name = "Numéro de la Compétition"
        Grid_Competition.Columns(1).Name = "Date de la Compétition"
        '** Evite d'avoir une ligne blanche en fin, destinée à la 
        '** saisie d'une nouvelle ligne 
        Grid_Competition.AllowUserToAddRows = False
        Dim req As String
        req = "select * from COMPETITION"

        'On déclare une variable de type objet "Command" qui exécute une commande (requête SQL) sur la base de données
        Dim cmdRech As New OleDbCommand(req, maConnexion)

        'On déclare une variable de type objet "DataReader" qui récupère les enregistrements de la requête de type SELECT
        Dim rdrRech As OleDbDataReader = cmdRech.ExecuteReader()
        Dim numLigne As Integer
        While (rdrRech.Read())
            Grid_Competition.Rows.Add()
            numLigne = Grid_Competition.RowCount - 1
            Grid_Competition.Item(0, numLigne).Value = rdrRech.Item("NUM_COMPETITION")
            Grid_Competition.Item(1, numLigne).Value = rdrRech.Item("DATE_COMPETITION")
        End While

    End Sub
End Class