Public Class Form1

#Region "Public Variables"
    Public SendData As String = Nothing
#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    'Warframe Info Panel Buttons
    Private Sub AshPictureBox_Click(sender As Object, e As EventArgs) Handles AshPictureBox.Click
        SendData = "Ash"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub AshPrimePicutreBox_Click(sender As Object, e As EventArgs) Handles AshPrimePicutreBox.Click
        SendData = "Ash Prime"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox594_Click(sender As Object, e As EventArgs) Handles PictureBox594.Click
        SendData = "Atlas"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox595_Click(sender As Object, e As EventArgs) Handles PictureBox595.Click
        SendData = "Banshee"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox596_Click(sender As Object, e As EventArgs) Handles PictureBox596.Click
        SendData = "Banshee Prime"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox597_Click(sender As Object, e As EventArgs) Handles PictureBox597.Click
        SendData = "Chroma"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox598_Click(sender As Object, e As EventArgs) Handles PictureBox598.Click
        SendData = "Ember"
        WarframeInformationPanel.Show()
    End Sub

    Private Sub PictureBox599_Click(sender As Object, e As EventArgs) Handles PictureBox599.Click
        SendData = "Ember Prime"
        WarframeInformationPanel.Show()
    End Sub
End Class
