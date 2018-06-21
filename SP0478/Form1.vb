Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'category_frm.MdiParent = Me
        'category_frm.Show()

        If Me.ActiveMdiChild Is Nothing Then
            category_frm.MdiParent = Me
            'category_frm.Show()
        End If
    End Sub
    Public Sub ShowForm(frm As Form)
        frm.MdiParent = Me
        'frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub Insert_catagory_Click(sender As Object, e As EventArgs) Handles Insert_catagory.Click
        ShowForm(category_frm)
    End Sub
End Class
