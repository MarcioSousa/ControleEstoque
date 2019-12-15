Public Class frm_Entrada
    Dim vProduto As New cls_Produto
    Public vPassou As Boolean = False
    Dim vEscolha As String = ""
    Dim vcancela As Boolean = False

    Private Sub carrega_grid()
        dgvEntrada.DataSource = cls_Produto.readEntrada

        dgvEntrada.ColumnHeadersVisible = True
        dgvEntrada.Columns(0).Visible = False
        dgvEntrada.Columns(1).Width = 40
        dgvEntrada.Columns(2).Width = 90
        dgvEntrada.Columns(3).Width = 50
        dgvEntrada.Columns(4).Width = 80
        dgvEntrada.Columns(5).Width = 80
        dgvEntrada.Columns(6).Width = 170
        dgvEntrada.Columns(7).Width = 170
        dgvEntrada.Columns(8).Width = 80

        dgvEntrada.Columns(0).HeaderText = "COD"
        dgvEntrada.Columns(1).HeaderText = "COD"
        dgvEntrada.Columns(2).HeaderText = "DATA"
        dgvEntrada.Columns(3).HeaderText = "QTDE"
        dgvEntrada.Columns(4).HeaderText = "VALOR"
        dgvEntrada.Columns(5).HeaderText = "TOTAL"
        dgvEntrada.Columns(6).HeaderText = "FORNECEDOR"
        dgvEntrada.Columns(7).HeaderText = "PRODUTO"
        dgvEntrada.Columns(8).HeaderText = "UNIDADE"

        dgvEntrada.Columns(4).DefaultCellStyle.Format = "c"
        dgvEntrada.Columns(5).DefaultCellStyle.Format = "c"

        If dgvEntrada.Rows.Count <> 0 Then
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        Else
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        End If

        frm_Principal.lblTotalEntProd.Text = cls_Produto.totalProdutosEntrada
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
        If dgvEntrada.Rows.Count <> 0 Then
            txtCod.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(1).Value
            dtpMovimentacao.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(2).Value
            txtQtde.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(3).Value
            txtValor.Text = String.Format("{0:C}", dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(4).Value)
            txtTotal.Text = String.Format("{0:C}", dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(5).Value)
            txtFornec.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(6).Value
            txtProduto.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(7).Value
            txtUnidade.Text = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(8).Value
        Else
            limpa_campos()
        End If
    End Sub

    Private Sub habilita_campos()
        txtCod.Enabled = True
        dtpMovimentacao.Enabled = True
        txtQtde.Enabled = True
        txtValor.Enabled = True

        dgvEntrada.Enabled = False

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

        dgvEntrada.Enabled = True

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

    Private Sub dgvEntrada_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvEntrada.SelectionChanged
        carrega_campos()
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

    Private Sub txtCod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCod.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtValor.KeyPress
        If e.KeyChar = "," Then
            e.Handled = False
            Exit Sub
        End If
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtQtde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtde.TextChanged
        If txtValor.Text <> "" And btnConfirmar.Enabled = True And txtQtde.Text <> "" Then
            txtTotal.Text = String.Format("{0:C}", CDec(txtValor.Text) * txtQtde.Text)
        ElseIf txtQtde.Text = "" Then
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub txtValor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValor.TextChanged
        If txtQtde.Text <> "" And btnConfirmar.Enabled = True And txtValor.Text <> "" Then
            txtTotal.Text = String.Format("{0:C}", CDec(txtValor.Text) * txtQtde.Text)
        ElseIf txtValor.Text = "" Then
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Deseja excluir permanentemente a Entrada do Produto " & txtProduto.Text & " sua lista?", "Deletando Entrada", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
            Dim codentrada As Integer = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(0).Value
            vProduto.cudProduto(codentrada, 6)
            dgvEntrada.Columns.Clear()
            carrega_grid()
            MessageBox.Show("Entrada deletado com sucesso!!!", "Entrada Deletado", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        vProduto.cudProduto(txtCod.Text, 4)
                    Else
                        vProduto.acodentsai = dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(0).Value
                        vProduto.cudProduto(txtCod.Text, 5)
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
            MessageBox.Show("Campo Valor incorreto!" & ex.Message, "Erro")
            txtValor.Text = ""
            txtValor.Focus()
        End Try
        vcancela = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        desabilita_campos()
        carrega_campos()
        If dgvEntrada.Rows.Count = 0 Then
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Else
            btnEditar.Enabled = True
            btnExcluir.Enabled = True
        End If
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        limpa_campos()
        habilita_campos()
        vEscolha = "A"
        txtCod.Focus()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        habilita_campos()
        txtValor.Text = String.Format("{0:F2}", dgvEntrada.Rows(dgvEntrada.CurrentRow.Index).Cells(4).Value)
        vEscolha = "E"
    End Sub

End Class