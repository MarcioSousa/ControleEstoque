Imports System.Data.SqlServerCe

Public Class cls_Produto
    Private codigoprod As Integer
    Private nomeproduto As String
    Private unidadeproduto As String
    Private fornecedorproduto As String
    Private minimoproduto As Integer
    Private saldoiniproduto As Integer
    Private estoqueatualproduto As Integer
    Private datacadastro As String

    Private codentsai As Integer

    Private dataentsai As String
    Private qtde As Integer
    Private valor As Double

    Public Property acodprod
        Get
            Return codigoprod
        End Get
        Set(ByVal value)
            codigoprod = value
        End Set
    End Property
    Public Property anomeprod
        Get
            Return nomeproduto
        End Get
        Set(ByVal value)
            nomeproduto = value
        End Set
    End Property
    Public Property aunidadeprod
        Get
            Return unidadeproduto
        End Get
        Set(ByVal value)
            unidadeproduto = value
        End Set
    End Property
    Public Property afornecprod
        Get
            Return fornecedorproduto
        End Get
        Set(ByVal value)
            fornecedorproduto = value
        End Set
    End Property
    Public Property aminimoprod()
        Get
            Return minimoproduto
        End Get
        Set(ByVal value)
            minimoproduto = value
        End Set
    End Property
    Public Property asaldoiniprod
        Get
            Return saldoiniproduto
        End Get
        Set(ByVal value)
            saldoiniproduto = value
        End Set
    End Property
    Public Property aestoqueatualprod
        Get
            Return estoqueatualproduto
        End Get
        Set(ByVal value)
            estoqueatualproduto = value
        End Set
    End Property
    Public Property adatacadastro
        Get
            Return datacadastro
        End Get
        Set(ByVal value)
            datacadastro = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property

    Public Property acodentsai
        Get
            Return codentsai
        End Get
        Set(ByVal value)
            codentsai = value
        End Set
    End Property


    Public Property adataentsai
        Get
            Return dataentsai
        End Get
        Set(ByVal value)
            dataentsai = Convert.ToDateTime(value).ToString("MM/dd/yyyy")
        End Set
    End Property
    Public Property aqtde
        Get
            Return qtde
        End Get
        Set(ByVal value)
            qtde = value
        End Set
    End Property
    Public Property avalor
        Get
            Return valor
        End Get
        Set(ByVal value)
            valor = value
        End Set
    End Property

    '//CONECTANDO AO BANCO DE DADOS
    Private Shared Function abrindoConexaoBanco() As SqlCeConnection
        Try
            Dim conString As String = "Data Source=C:\Users\marci\Documents\Visual Studio 2010\Projects\ControleEstoque\ControleEstoque\ControleEstoque.sdf"
            'Dim conString As String = "Data Source= " & Application.StartupPath & "\ControleEstoque.sdf;Persist Security Info=False"
            Dim connection As SqlCeConnection = New SqlCeConnection(conString)
            connection.Open()
            Return connection
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '//STRINGS DE ATUALIZAÇÃO DO BANCO DE DADOS
    Public Function stringBanco(ByVal acodprod As Integer, ByVal CUD As Integer)
        Try
            If CUD = 1 Then
                Return "INSERT INTO Produto (cod_prod, nome_prod, fornec_prod, unid_prod, minimo_prod, saldoini_prod, datacad_prod) VALUES (" & acodprod & ",'" & anomeprod & "','" & afornecprod & "','" & aunidadeprod & "'," & aminimoprod & "," & asaldoiniprod & ",'" & adatacadastro & "')"
            ElseIf CUD = 2 Then
                Return "UPDATE Produto SET nome_prod = '" & anomeprod & "', unid_prod = '" & aunidadeprod & "', fornec_prod = '" & afornecprod & "', minimo_prod = '" & aminimoprod & "', saldoini_prod = '" & asaldoiniprod & "', datacad_prod = '" & adatacadastro & "' WHERE cod_prod = " & acodprod
            ElseIf CUD = 3 Then
                Return "DELETE FROM Produto WHERE cod_prod = " & acodprod
            ElseIf CUD = 4 Then
                Return "INSERT INTO Entrada (codprod_ent, data_ent, qtde_ent, valor_ent) VALUES (" & acodprod & ",'" & adataentsai & "'," & aqtde & ",'" & avalor & "')"
            ElseIf CUD = 5 Then
                Return "UPDATE Entrada SET codprod_ent = " & acodprod & ", data_ent = '" & adataentsai & "', qtde_ent = " & aqtde & ", valor_ent = '" & avalor & "' WHERE cod_ent = " & acodentsai
            ElseIf CUD = 6 Then
                Return "DELETE FROM Entrada WHERE cod_ent = " & acodprod
            ElseIf CUD = 7 Then
                Return "INSERT INTO Saida (codprod_sai, data_sai, qtde_sai, valor_sai) VALUES (" & acodprod & ",'" & adataentsai & "'," & aqtde & ",'" & avalor & "')"
            ElseIf CUD = 8 Then
                Return "UPDATE Saida SET codprod_sai = " & acodprod & ", data_sai = '" & adataentsai & "', qtde_sai = " & aqtde & ", valor_sai = '" & avalor & "' WHERE cod_sai = " & acodentsai
            ElseIf CUD = 9 Then
                Return "DELETE FROM Saida WHERE cod_sai = " & acodprod
            ElseIf CUD = 10 Then
                Return "DELETE FROM Entrada WHERE codprod_ent = " & acodprod
            Else
                Return "DELETE FROM Saida WHERE codprod_sai = " & acodprod
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    '//ADICIONAR, EDITAR, EXCLUIR PRODUTO DO BANCO DE DADOS
    Public Sub cudProduto(ByVal acodprod As Integer, ByVal CUD As Integer)
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand(stringBanco(acodprod, CUD), connection)
                    Command.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Sub

    '//FAZ UM SELECT DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function readProduto() As DataTable
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT cod_prod, nome_prod, unid_prod, fornec_prod, minimo_prod, saldoini_prod FROM Produto ORDER BY cod_prod", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DA TABELA ENTRADA DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function readEntrada() As DataTable
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT A.cod_ent, A.codprod_ent, A.data_ent, A.qtde_ent, A.valor_ent, A.qtde_ent * A.valor_ent, B.fornec_prod, B.nome_prod, B.unid_prod FROM Entrada A INNER JOIN Produto B ON A.codprod_ent = B.cod_prod ORDER BY cod_ent", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DA TABELA SAIDA DOS PRODUTOS E CARREGA NO DATAGRID
    Public Shared Function readSaida() As DataTable
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dt As New DataTable
                Using Command As New SqlCeCommand("SELECT A.cod_sai, A.codprod_sai, A.data_sai, A.qtde_sai, A.valor_sai, A.qtde_sai * A.valor_sai, B.fornec_prod, B.nome_prod, B.unid_prod FROM Saida A INNER JOIN Produto B ON A.codprod_sai = B.cod_prod ORDER BY cod_sai", connection)
                    dt.Load(Command.ExecuteReader())
                    Return dt
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//FAZ UMA VARREDURA NO BANCO SOMANDO A QUANTIDADE TOTAL DE PRODUTOS CADASTRADOS
    Public Shared Function novo_Codigo() As String
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT MAX(cod_prod) FROM Produto", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 1
            End Try
        End Using
    End Function

    '//RETORNA A DATA DE CADASTRO DO CLIENTE
    Public Shared Function cadastro(ByVal codigo As Integer) As String
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT datacad_prod FROM Produto WHERE cod_prod = " & codigo, connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA O CODIGO DO PRODUTO DE ENTRADA COM MAIOR VALOR
    Private Function novo_Codigo_Entrada() As String
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT MAX(cod_ent) FROM Entrada", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                Return 1
            End Try
        End Using
    End Function

    '//FAZ UM SELECT DOS PRODUTOS E RETORNA APENAS O PRODUTO DIGITADO NO CAMPO CODPROD
    Public Function preencheCamposProduto(ByVal vcodprod As Integer) As cls_Produto
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dr As SqlCeDataReader = Nothing
                Using Command As New SqlCeCommand("SELECT nome_prod, unid_prod, fornec_prod FROM Produto WHERE cod_prod = " & vcodprod, connection)
                    dr = Command.ExecuteReader
                    dr.Read()
                    Try
                        anomeprod = dr("nome_prod")
                        aunidadeprod = dr("unid_prod")
                        afornecprod = dr("fornec_prod")
                    Catch ex As Exception
                        anomeprod = ""
                        aunidadeprod = ""
                        afornecprod = ""
                        frm_Entrada.vPassou = True
                    End Try
                End Using
            Catch ex As Exception
                Throw
            End Try
        End Using
        Return Me
    End Function

    '//ME RETORNA A SOMA DE UM PRODUTO DA TABELA ENTRADA
    Public Function somaProdutoEntrada(ByVal codigoproduto As Integer) As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT SUM(qtde_ent) FROM Entrada WHERE codprod_ent = " & codigoproduto, connection)
                    Try
                        Return Command.ExecuteScalar
                    Catch ex As Exception
                        Return 0
                    End Try
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA A SOMA DE UM PRODUTO NA TABELA SAIDA
    Public Function somaProdutoSaida(ByVal codigoproduto As Integer) As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT SUM(qtde_sai) FROM Saida WHERE codprod_sai = " & codigoproduto, connection)
                    Try
                        Return Command.ExecuteScalar
                    Catch ex As Exception
                        Return 0
                    End Try
                End Using
            Catch ex As Exception
                Return ex.Message
            End Try
        End Using
    End Function

    '//ME RETORNA A SOMA DE DO VALOR DO PRODUTO NA TABELA ENTRADA   
    Public Function somaValorEntrada(ByVal codigoproduto As Integer, ByVal qtdetotal As Integer) As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dr As SqlCeDataReader
                Dim somafinal As Integer = 0
                Using Command As New SqlCeCommand("SELECT qtde_ent, valor_ent FROM Entrada WHERE codprod_ent = " & codigoproduto, connection)
                    dr = Command.ExecuteReader
                    Do While dr.Read
                        somafinal = somafinal + (dr("qtde_ent") * dr("valor_ent"))
                    Loop
                    Return somafinal
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA A SOMA DE DO VALOR DO PRODUTO NA TABELA SAIDA  
    Public Function somaValorSaida(ByVal codigoproduto As Integer, ByVal qtdetotal As Integer) As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Dim dr As SqlCeDataReader
                Dim somafinal As Integer = 0
                Using Command As New SqlCeCommand("SELECT qtde_sai, valor_sai FROM Saida WHERE codprod_sai = " & codigoproduto, connection)
                    dr = Command.ExecuteReader
                    Do While dr.Read
                        somafinal = somafinal + (dr("qtde_sai") * dr("valor_sai"))
                    Loop
                    Return somafinal
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA O TOTAL DE PRODUTOS DE ENTRADA
    Public Shared Function totalProdutosEntrada() As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT COUNT(cod_ent) FROM Entrada", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function

    '//ME RETORNA O TOTAL DE PRODUTOS DE SAÌDA
    Public Shared Function totalProdutosSaida() As Integer
        Using connection As SqlCeConnection = abrindoConexaoBanco()
            Try
                Using Command As New SqlCeCommand("SELECT COUNT(cod_sai) FROM Saida", connection)
                    Return Command.ExecuteScalar
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Throw
            End Try
        End Using
    End Function


End Class

