Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace Snap_API
	Partial Public Class CategoryForm
		Inherits DevExpress.XtraEditors.XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Public ReadOnly Property Role() As String
			Get
				Return cbCategory.EditValue.ToString()
			End Get

		End Property
	End Class
End Namespace