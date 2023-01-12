Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Status

Public Class Form1
    'FORM LOAD
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(600, 500)

        DGB_gbConcesionario.Left = 15
        DGB_gbConcesionario.Top = 50
        DGB_gbConcesionario.Visible = False

        DGB_gbColores.Left = 15
        DGB_gbColores.Top = 50
        DGB_gbColores.Visible = False

        DGB_gbProbarLabel.Left = 15
        DGB_gbProbarLabel.Top = 50
        DGB_gbProbarLabel.Visible = False

        DGB_gbAnuncio.Left = 15
        DGB_gbAnuncio.Top = 50
        DGB_gbAnuncio.Visible = False
    End Sub
    'MENU
    Private Sub ConcesionarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConcesionarioToolStripMenuItem.Click
        DGB_gbAnuncio.Visible = False
        DGB_gbProbarLabel.Visible = False
        DGB_gbColores.Visible = False
        DGB_gbConcesionario.Visible = True
        DGB_ejercicio.Text = "Concesionario"
    End Sub
    Private Sub ColoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColoresToolStripMenuItem.Click
        DGB_gbAnuncio.Visible = False
        DGB_gbProbarLabel.Visible = False
        DGB_gbConcesionario.Visible = False
        DGB_gbColores.Visible = True
        DGB_ejercicio.Text = "Colores"
    End Sub
    Private Sub ProbarLabelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProbarLabelToolStripMenuItem.Click
        DGB_gbAnuncio.Visible = False
        DGB_gbConcesionario.Visible = False
        DGB_gbColores.Visible = False
        DGB_gbProbarLabel.Visible = True
        DGB_ejercicio.Text = "Probar Label"
    End Sub
    Private Sub AnuncioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnuncioToolStripMenuItem.Click
        DGB_gbProbarLabel.Visible = False
        DGB_gbColores.Visible = False
        DGB_gbConcesionario.Visible = False
        DGB_gbAnuncio.Visible = True
        DGB_ejercicio.Text = "Anuncio"
    End Sub
    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Dim info As New DGB_FormInfo
        info.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim respuesta As Integer
        respuesta = MsgBox("¿Seguro que desea salir?", vbYesNo, "Salir")
        If (respuesta = vbYes) Then
            Me.Close()
        Else
        End If
    End Sub
    'TOOLSTRIP
    Private Sub DGB_tsConcesionario_Click(sender As Object, e As EventArgs) Handles DGB_tsConcesionario.Click
        ConcesionarioToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub DGB_tsColores_Click(sender As Object, e As EventArgs) Handles DGB_tsColores.Click
        ColoresToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub DGB_tsProbarLabel_Click(sender As Object, e As EventArgs) Handles DGB_tsProbarLabel.Click
        ProbarLabelToolStripMenuItem_Click(sender, e)
    End Sub
    'CONCESIONARIO:
    Private Sub DGB_rbGasolina_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbGasolina.CheckedChanged
        DGB_lbTipoCoche.Text = DGB_rbGasolina.Text
    End Sub
    Private Sub DGB_rbDiesel_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbDiesel.CheckedChanged
        DGB_lbTipoCoche.Text = DGB_rbDiesel.Text
    End Sub
    Private Sub DGB_rbElectrico_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbElectrico.CheckedChanged
        DGB_lbTipoCoche.Text = DGB_rbElectrico.Text
    End Sub
    Private Sub DGB_rbAmarillo_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbAmarillo.CheckedChanged
        DGB_lbColorCoche.Text = DGB_rbAmarillo.Text
    End Sub
    Private Sub DGB_rbRojo_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbRojo.CheckedChanged
        DGB_lbColorCoche.Text = DGB_rbRojo.Text
    End Sub
    Private Sub DGB_rbAzul_CheckedChanged(sender As Object, e As EventArgs) Handles DGB_rbAzul.CheckedChanged
        DGB_lbColorCoche.Text = DGB_rbAzul.Text
    End Sub
    'COLORES
    Private Sub DGB_btAnadir_Click(sender As Object, e As EventArgs) Handles DGB_btAnadir.Click
        DGB_lbxColores.Items.Add(DGB_tbColor.Text)
    End Sub
    Private Sub DGB_lbxColores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DGB_lbxColores.SelectedIndexChanged
        DGB_lbColorSelec.Text = DGB_lbxColores.SelectedItem
    End Sub
    'PROBAR LABEL
    Private Sub DGB_btForeground_Click(sender As Object, e As EventArgs) Handles DGB_btForeground.Click
        DGB_cuadroColor.ShowDialog()
        DGB_lbHolaMundo.ForeColor = DGB_cuadroColor.Color
    End Sub
    Private Sub DGB_btBackground_Click(sender As Object, e As EventArgs) Handles DGB_btBackground.Click
        DGB_cuadroColor.ShowDialog()
        DGB_lbHolaMundo.BackColor = DGB_cuadroColor.Color
    End Sub
    'ANUNCIO
    Dim contador As Integer
    Private Sub DGB_btInicio_Click(sender As Object, e As EventArgs) Handles DGB_btInicio.Click
        DGB_tmCoches.Interval = 1000
        DGB_tmCoches.Start()
    End Sub
    Private Sub DGB_btParada_Click(sender As Object, e As EventArgs) Handles DGB_btParada.Click
        DGB_tmCoches.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles DGB_tmCoches.Tick
        contador = contador + 1
        DGB_pbImagen.Image = DGB_ilCoches.Images(contador)
        If (contador = 3) Then
            contador = 0
        End If
    End Sub
End Class
