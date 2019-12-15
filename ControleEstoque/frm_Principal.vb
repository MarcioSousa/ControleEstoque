Public Class frm_Principal
    Dim edicao As Boolean = False
    Dim vProduto As New cls_Produto
    Dim vAba As String = ""

    Private Sub carrega_campos_adicionais()
        Dim vvalor As Decimal

        For t = 0 To dgvProduto.Rows.Count - 1
            dgvProduto.Rows(t).Cells(6).Value = (vProduto.somaProdutoEntrada(dgvProduto.Rows(t).Cells(0).Value) - vProduto.somaProdutoSaida(dgvProduto.Rows(t).Cells(0).Value)) + dgvProduto.Rows(t).Cells(5).Value

            Try
                vvalor = (vProduto.somaValorEntrada(dgvProduto.Rows(t).Cells(0).Value, vProduto.somaProdutoEntrada(dgvProduto.Rows(t).Cells(0).Value))) / vProduto.somaProdutoEntrada(dgvProduto.Rows(t).Cells(0).Value)
                dgvProduto.Rows(t).Cells(7).Value = String.Format("{0:C}", vvalor)
            Catch ex As Exception
                dgvProduto.Rows(t).Cells(7).Value = "R$ 0,00"
            End Try

            Try
                vvalor = (vProduto.somaValorSaida(dgvProduto.Rows(t).Cells(0).Value, vProduto.somaProdutoSaida(dgvProduto.Rows(t).Cells(0).Value))) / vProduto.somaProdutoSaida(dgvProduto.Rows(t).Cells(0).Value)
                dgvProduto.Rows(t).Cells(8).Value = String.Format("{0:C}", vvalor)
            Catch ex As Exception
                dgvProduto.Rows(t).Cells(8).Value = "R$ 0,00"
            End Try

            If dgvProduto.Rows(t).Cells(6).Value = dgvProduto.Rows(t).Cells(4).Value Then
                dgvProduto.Rows(t).DefaultCellStyle.BackColor = Color.Yellow
            ElseIf dgvProduto.Rows(t).Cells(6).Value <= dgvProduto.Rows(t).Cells(4).Value Then
                dgvProduto.Rows(t).DefaultCellStyle.BackColor = Color.Red
            End If
        Next

    End Sub

    Public Sub carrega_grids()
        dgvProduto.DataSource = cls_Produto.readProduto

        If dgvProduto.Rows.Count = 0 Then
            btnEntrada.Enabled = False
            btnSaida.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
            limpa_campos()
            dgvProduto.ColumnHeadersVisible = False
        Else
            dgvProduto.ColumnHeadersVisible = True
            dgvProduto.Columns(0).Width = 40
            dgvProduto.Columns(1).Width = 150
            dgvProduto.Columns(2).Width = 80
            dgvProduto.Columns(3).Width = 150
            dgvProduto.Columns(4).Width = 60
            dgvProduto.Columns(5).Width = 60

            dgvProduto.Columns(0).HeaderText = "COD"
            dgvProduto.Columns(1).HeaderText = "PRODUTOS"
            dgvProduto.Columns(2).HeaderText = "UNIDADE"
            dgvProduto.Columns(3).HeaderText = "FORNECEDOR"
            dgvProduto.Columns(4).HeaderText = "MINIMO"
            dgvProduto.Columns(5).HeaderText = "INICIAL"

            btnEditar.Enabled = True
            btnExcluir.Enabled = True
            btnEntrada.Enabled = True
            btnSaida.Enabled = True

            dgvProduto.Columns.Add("ESTOQUE", "ATUAL")
            dgvProduto.Columns.Add("ENTRADA", "ENTRADA")
            dgvProduto.Columns.Add("SAIDA", "SAIDA")

            dgvProduto.Columns(6).Width = 60
            dgvProduto.Columns(7).Width = 85
            dgvProduto.Columns(8).Width = 85

            carrega_campos_adicionais()
        End If
        lblTotalProdCad.Text = dgvProduto.Rows.Count
        lblTotalEntProd.Text = cls_Produto.totalProdutosEntrada
        lblTotalSaiProd.Text = cls_Produto.totalProdutosSaida
    End Sub

    Private Sub habilita_campos()
        txtNome.Enabled = True
        txtUnid.Enabled = True
        txtFornec.Enabled = True
        txtMin.Enabled = True
        txtSaldoIni.Enabled = True
        dtpCadastro.Enabled = True

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        btnEntrada.Enabled = False
        btnSaida.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True

        dgvProduto.Enabled = False
    End Sub
    
    Private Sub limpa_campos()
        txtCod.Text = ""
        txtNome.Text = ""
        txtUnid.Text = ""
        txtFornec.Text = ""
        txtMin.Text = ""
        txtSaldoIni.Text = ""
        dtpCadastro.Text = ""
    End Sub
    
    Private Sub desabilita_campos()
        txtNome.Enabled = False
        txtUnid.Enabled = False
        txtFornec.Enabled = False
        txtMin.Enabled = False
        txtSaldoIni.Enabled = False
        dtpCadastro.Enabled = False

        btnAdicionar.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
        btnEntrada.Enabled = True
        btnSaida.Enabled = True

        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False

        dgvProduto.Enabled = True
    End Sub

    Private Sub carrega_campos()
        If dgvProduto.Rows.Count <> 0 Then
            txtCod.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(0).Value
            txtNome.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(1).Value
            txtUnid.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(2).Value
            txtFornec.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(3).Value
            txtMin.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(4).Value
            txtSaldoIni.Text = dgvProduto.Rows(dgvProduto.CurrentRow.Index).Cells(5).Value
            dtpCadastro.Text = cls_Produto.cadastro(txtCod.Text)
        Else
            limpa_campos()
        End If
    End Sub
    
    Private Sub frm_Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grids()
        carrega_campos()
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        habilita_campos()
        limpa_campos()

        If dgvProduto.Rows.Count <> 0 Then
            txtCod.Text = cls_Produto.novo_Codigo() + 1
        Else
            txtCod.Text = 1
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        desabilita_campos()
        carrega_campos()
        If dgvProduto.Rows.Count = 0 Then
            btnEntrada.Enabled = False
            btnSaida.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If
        edicao = False
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        habilita_campos()
        edicao = True
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir permanentemente o Produto " & txtNome.Text & " sua lista?", "Deletando Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            vProduto.cudProduto(txtCod.Text, 3)
            vProduto.cudProduto(txtCod.Text, 10)
            vProduto.cudProduto(txtCod.Text, 11)
            dgvProduto.Columns.Clear()
            carrega_grids()
            MessageBox.Show("Produto deletado com sucesso!!!", "Produto Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Try
            vProduto.anomeprod = txtNome.Text
            vProduto.aunidadeprod = txtUnid.Text
            vProduto.afornecprod = txtFornec.Text
            vProduto.aminimoprod = txtMin.Text
            vProduto.asaldoiniprod = txtSaldoIni.Text
            vProduto.adatacadastro = dtpCadastro.Text

            If edicao = True Then
                vProduto.cudProduto(txtCod.Text, 2)
            Else
                vProduto.cudProduto(txtCod.Text, 1)
            End If

            dgvProduto.Columns.Clear()
            carrega_grids()
            desabilita_campos()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        edicao = False
    End Sub

    Private Sub dgvProduto_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvProduto.ColumnHeaderMouseClick
        carrega_campos_adicionais()
    End Sub

    Private Sub btnEntrada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntrada.Click
        frm_Entrada.Show()
        Me.Enabled = False
    End Sub

    Private Sub btnSaida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaida.Click
        frm_Saida.Show()
        Me.Enabled = False
    End Sub

    Private Sub dgvProduto_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvProduto.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub txtCod_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtMin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMin.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSaldoIni_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSaldoIni.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub pbxLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxLogo.Click
        MessageBox.Show("Entre em contato e peça o sistema para sua empresa!" & vbCrLf & vbCrLf & "Contatos:" & vbCrLf & "(11)9 9797.3185 tim watts" & vbCrLf & "(11)9 5052.7217 vivo" & vbCrLf & "Facebook: facebook.com/marciosousaitu", "CADFácil Sistemas - Marcio Sousa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class