' Developer Express Code Central Example:
' How to generate a document layout in code via the Snap application programming interface (API)
' 
' This example illustrates the Snap API
' (https://documentation.devexpress.com/#WindowsForms/CustomDocument14525) that is
' used to generate a document from scratch and connect it to data completely in
' code.
' The following code generates a tabular report layout. For a sample code
' that creates a mail-merge report (in the context of SnapDocumentServer
' (https://documentation.devexpress.com/#DocumentServer/clsDevExpressSnapSnapDocumentServertopic)),
' refer to the following example: How to automatically create mail-merge documents
' using the Snap Document Server
' (https://www.devexpress.com/Support/Center/CodeCentral/ViewExample.aspx?exampleId=E5078).
' SnapControl
' (https://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapSnapControltopic)
' extends the RichEditControl
' (https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraRichEditRichEditControltopic)'s
' API and introduces the SnapList
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapListtopic)
' class that is used to insert dynamic data elements into a document.
' To generate
' a data-aware Snap document, do the following:
' - Create a Snap application and
' connect it to a data source
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument16043).
' - Add
' a SnapList to the SnapDocument
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapDocumenttopic).
' -
' To generate the SnapList layout, define the ListHeader, ListFooter, and
' RowTemplate
' (http://documentation.devexpress.com/#WindowsForms/DevExpressSnapCoreAPISnapList_RowTemplatetopic).
' - Inject data fields
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15559) into the
' document (e.g., by using SnapText to display text data).
' - Format the document
' content (see the FormatList method implementation in the Form1.cs file of the
' sample solution).
' - If required, apply grouping, sorting, and/or filtering to
' the SnapList content.
' A SnapEntity
' (http://documentation.devexpress.com/#WindowsForms/clsDevExpressSnapCoreAPISnapEntitytopic)
' is open to customization only after calling its BeginUpdate method and not after
' the EndUpdate method is called to apply the new settings (see the GenerateLayout
' method in the Form1.cs file of the sample solution).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E4781


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace Snap_API
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Dim fLogin As New CategoryForm()
			If fLogin.ShowDialog() = DialogResult.OK Then
				Application.Run(New Form1(fLogin.Role))
			Else
				Application.Exit()
			End If

		End Sub
	End Class
End Namespace
