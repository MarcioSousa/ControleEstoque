Public Class frm_Saida
    Dim vProduto As New cls_Produto
    Public vPassou As Boolean = False
    Dim vEscolha As String = ""
    Dim vcancela As Boolean = False

    Private Sub carrega_grid()
        dgvSaida.DataSource = cls_Produto.readSaida

        dgvSaida.ColumnHeadersVisible = True
        dgvSaida.Columns(0).Visible = False
        dgvSaida.Columns(1).Width = 40
        dgvSaida.Columns(2).Width = 90
        dgvSaida.Columns(3).Width = 50
        dgvSaida.Columns(4).Width = 80
        dgvSaida.Columns(5).Width = 80
        dgvSaida.Columns(6).Width = 170
        dgvSaida.Columns(7).Width = 170
        dgvSaida.Columns(8).Width = 80

        dgvSaida.Columns(0).HeaderText = "COD"
        dgvSaida.Columns(1).HeaderText = "COD"
        dgvSaida.Columns(2).HeaderText = "DATA"
        dgvSaida.Columns(3).HeaderText = "QTDE"
        dgvSaida.Columns(4).HeaderText = "VALOR"
        dgvSaida.Columns(5).HeaderText = "TOTAL"
        dgvSaida.Columns(6).HeaderText = "FORNECEDOR"
        dgvSaida.Columns(7).HeaderText = "PRODUTO"
        dgvSaida.Columns(8).HeaderText = "UNIDADE"

        dgvSaida.Columns(4).DefaultCellStyle.Format = "c"
        dgvSaida.Columns(5).DefaultCellStyle.Format = "c"

        If dgvSaida.Rows.Count <> 0 Then
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        Else
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If

        frm_Principal.lblTotalSaiProd.Text = cls_Produto.totalProdutosSaida
    End Sub

    Private Sub limpa_campos()
        txtCod.Text = ""
        dtpMovimentacao.Text = Today.Date
        txtQtde.Text = ""
        txtValor.Text = ""
        txtTotal.Text = ""
        txtFornec.Text = ""
        txtProduto.Text = ""
        txtUnidade.Text = ""
    End Sub

    Private Sub carrega_campos()
        If dgvSaida.Rows.Count <> 0 Then
            txtCod.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(1).Value
            dtpMovimentacao.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(2).Value
            txtQtde.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(3).Value
            txtValor.Text = String.Format("{0:C}", dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(4).Value)
            txtTotal.Text = String.Format("{0:C}", dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(5).Value)
            txtFornec.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(6).Value
            txtProduto.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(7).Value
            txtUnidade.Text = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(8).Value()
        Else
            limpa_campos()
        End If
    End Sub

    Private Sub habilita_campos()
        txtCod.Enabled = True
        dtpMovimentacao.Enabled = True
        txtQtde.Enabled = True
        txtValor.Enabled = True

        dgvSaida.Enabled = False

        btnAdicionar.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False

        btnConfirmar.Enabled = True
        btnCancelar.Enabled = True
    End Sub

    Private Sub desabilita_campos()
        txtCod.Enabled = False
        dtpMovimentacao.Enabled = False
        txtQtde.Enabled = False
        txtValor.Enabled = False

        dgvSaida.Enabled = True

        btnAdicionar.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True

        btnConfirmar.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub verifica_campos()
        If txtCod.Text = "" Then
            vcancela = True
            txtCod.Focus()
        ElseIf txtQtde.Text = "" Then
            vcancela = True
            txtQtde.Focus()
        ElseIf txtValor.Text = "" Then
            vcancela = True
            txtValor.Focus()
        End If
    End Sub

    Private Sub frm_Entrada_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        frm_Principal.Enabled = True
    End Sub

    Private Sub frm_Entrada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carrega_grid()
    End Sub

    Private Sub dgvEntrada_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSaida.SelectionChanged
        carrega_campos()
    End Sub

    Private Sub txtCod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        habilita_campos()
        txtValor.Text = String.Format("{0:F2}", dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(4).Value)
        vEscolha = "E"
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        habilita_campos()
        limpa_campos()
        vEscolha = "A"
        txtCod.Focus()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        desabilita_campos()
        carrega_campos()
        If dgvSaida.Rows.Count = 0 Then
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Else
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        End If
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Try
            verifica_campos()
            If vcancela = False Then
                If txtFornec.Text = "" Then
                    MessageBox.Show("O produto com esse código não existe no Banco de Dados, digite um código válido!!", "Produto Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpa_campos()
                    txtCod.Focus()
                Else
                    vProduto.acodprod = txtCod.Text
                    vProduto.adataentsai = dtpMovimentacao.Text
                    vProduto.aqtde = txtQtde.Text
                    vProduto.avalor = txtValor.Text
                    If vEscolha = "A" Then
                        vProduto.cudProduto(txtCod.Text, 7)
                    Else
                        vProduto.acodentsai = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(0).Value
                        vProduto.cudProduto(txtCod.Text, 8)
                    End If
                    frm_Principal.dgvProduto.Columns.Clear()
                    frm_Principal.carrega_grids()
                    carrega_grid()
                    desabilita_campos()
                    vEscolha = ""
                End If
            Else
                MessageBox.Show("Verifique os campos se foram todos preenchidos!!!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            txtValor.Text = ""
            txtValor.Focus()
        End Try
        vcancela = False
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir permanentemente a Entrada do Produto " & txtProduto.Text & " sua lista?", "Deletando Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Dim codsaida As Integer = dgvSaida.Rows(dgvSaida.CurrentRow.Index).Cells(0).Value
            vProduto.cudProduto(codsaida, 9)
            dgvSaida.Columns.Clear()
            carrega_grid()
            MessageBox.Show("Saída deletado com sucesso!!!", "Saída Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txtValor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged
        If txtQtde.Text <> "" And btnConfirmar.Enabled = True And txtValor.Text <> "" Then
            txtTotal.Text = String.Format("{0:C}", CDec(txtValor.Text) * txtQtde.Text)
        ElseIf txtValor.Text = "" Then
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        If txtValor.Text <> "" And btnConfirmar.Enabled = True And txtQtde.Text <> "" Then
            txtTotal.Text = String.Format("{0:C}", CDec(txtValor.Text) * txtQtde.Text)
        ElseIf txtQtde.Text = "" Then
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub txtCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod.TextChanged
        If txtCod.Text <> "" Then
            vProduto.preencheCamposProduto(txtCod.Text)
            If vPassou = True Then
                txtFornec.Text = ""
                txtProduto.Text = ""
                txtUnidade.Text = ""
            Else
                txtFornec.Text = vProduto.afornecprod
                txtProduto.Text = vProduto.anomeprod
                txtUnidade.Text = vProduto.aunidadeprod
            End If
        Else
            txtFornec.Text = ""
            txtProduto.Text = ""
            txtUnidade.Text = ""
            txtCod.Focus()
        End If
        vPassou = False
    End Sub

End Class
