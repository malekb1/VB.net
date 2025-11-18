Imports System.Numerics

Public Class Form1
    Public Sub New()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles rbpates.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chkformage.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim commande As String
        Dim prix As Integer
        If rbpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rbburger.Checked Then
            commande = " borguer"
            prix = 8
        Else
            commande = "pates"
            prix = 15
        End If
        For Each ctrl In gr.Controls
            If ctrl.Checked Then
                commande = commande + ctrl.text
                If ctrl.text = "formage " Then
                    prix = prix + 2
                ElseIf ctrl.text = "frites" Then
                    prix = prix + 2
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4
                End If
            End If

        Next
        btn1.Text = commande & "Total : " & prix

    End Sub

    Private Sub commande_Enter(sender As Object, e As EventArgs) Handles gr.Enter

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBoissons.Items.Add("cofé")
        lstBoissons.Items.Add("Jus d'orange")
        lstBoissons.Items.Add("Eau minérale")
        lstssssBoissons.Items.Add("citronnade")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
