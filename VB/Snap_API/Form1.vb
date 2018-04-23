Imports Microsoft.VisualBasic
#Region "#SystemUsings"
Imports System
Imports System.Data.OleDb
Imports System.Windows.Forms
#End Region ' #SystemUsings

#Region "#DevExpressData"
#End Region ' #DevExpressData

#Region "#SnapApi"
Imports DevExpress.Snap.Core.API
#End Region ' #SnapApi

#Region "#RichEditApi"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #RichEditApi

Imports Snap_API.nwindDataSetTableAdapters
Imports DevExpress.XtraEditors
Imports System.Drawing



Namespace Snap_API
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()

		End Sub
		Public Sub New(ByVal role As String)
			InitializeComponent()
			snapControl1.DataSource = GetDataSource()
			snapControl1.LoadDocumentTemplate("SnapTemplate.snx", SnapDocumentFormat.Snap)

			If role = "Manager" Then
				EditTemplate()
			End If
		End Sub

		Private Function GetDataSource() As BindingSource
			Dim dataSource As New nwindDataSet()
			Dim connection As New OleDbConnection()
			connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\nwind.mdb"

			Dim products As New ProductsTableAdapter()
			products.Connection = connection
			products.Fill(dataSource.Products)

			Dim bindingSource As New BindingSource()
			bindingSource.DataSource = dataSource
			bindingSource.DataMember = "Products"

			Return bindingSource
		End Function

		Private Function FindList() As SnapList
			Dim list As SnapList = Nothing
			For Each field As Field In snapControl1.Document.Fields

				list = TryCast(snapControl1.Document.ParseField(field), SnapList)
				If Object.ReferenceEquals(list, Nothing) Then
					Continue For
				Else
					Exit For
				End If
			Next field
			Return list
		End Function
		Private Sub AddColumn(ByVal list As SnapList, ByVal columnName As String, ByVal caption As String)
			Dim listHeader As SnapDocument = list.ListHeader
			Dim listHeaderTable As Table = listHeader.Tables(0)
			listHeaderTable.TableLayout = TableLayoutType.Fixed
			Dim listHeaderCells As TableCellCollection = listHeaderTable.FirstRow.Cells
			Dim columnHeader As TableCell = listHeaderCells.InsertAfter(listHeaderCells.Count - 1)
			listHeader.InsertText(columnHeader.ContentRange.Start, caption)
			Dim prop As CharacterProperties = listHeader.BeginUpdateCharacters(columnHeader.ContentRange)
			prop.Bold = True
			prop.ForeColor = Color.YellowGreen
			listHeader.EndUpdateCharacters(prop)

			Dim listRow As SnapDocument = list.RowTemplate
			Dim listRowTable As Table = listRow.Tables(0)
			listRowTable.TableLayout = TableLayoutType.Fixed
			Dim listRowTableCells As TableCellCollection = listRowTable.FirstRow.Cells
			Dim column As TableCell = listRowTableCells.InsertAfter(listRowTableCells.Count - 1)
			listRow.CreateSnText(column.ContentRange.Start, columnName)
		End Sub
		Private Sub EditTemplate()
			Dim list As SnapList = FindList()

			list.BeginUpdate()

			AddColumn(list, "Discontinued", "Discontinued")
			AddColumn(list, "UnitsInStock", "Units In Stock")
			AddColumn(list, "QuantityPerUnit", "Quantity Per Unit")

			list.EndUpdate()
			list.Field.Update()
		End Sub

	End Class
End Namespace
