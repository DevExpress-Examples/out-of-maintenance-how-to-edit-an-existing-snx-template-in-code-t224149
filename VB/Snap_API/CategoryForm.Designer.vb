Imports Microsoft.VisualBasic
Imports System
Namespace Snap_API
	Partial Public Class CategoryForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.cbCategory = New DevExpress.XtraEditors.ComboBoxEdit()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.cbCategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' cbCategory
			' 
			Me.cbCategory.EditValue = "Shop Assistant"
			Me.cbCategory.Location = New System.Drawing.Point(43, 66)
			Me.cbCategory.Name = "cbCategory"
			Me.cbCategory.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.cbCategory.Properties.Appearance.Options.UseFont = True
			Me.cbCategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.cbCategory.Properties.Items.AddRange(New Object() { "Shop Assistant", "Manager"})
			Me.cbCategory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
			Me.cbCategory.Size = New System.Drawing.Size(145, 22)
			Me.cbCategory.TabIndex = 0
			' 
			' labelControl1
			' 
			Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.labelControl1.Location = New System.Drawing.Point(43, 25)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(124, 16)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Choose your category"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.DialogResult = System.Windows.Forms.DialogResult.OK
			Me.simpleButton1.Location = New System.Drawing.Point(57, 130)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(100, 23)
			Me.simpleButton1.TabIndex = 2
			Me.simpleButton1.Text = "Open the invoice"
			' 
			' CategoryForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(235, 227)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.cbCategory)
			Me.Name = "CategoryForm"
			Me.Text = "CategoryForm"
			CType(Me.cbCategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private cbCategory As DevExpress.XtraEditors.ComboBoxEdit
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
		Private simpleButton1 As DevExpress.XtraEditors.SimpleButton
	End Class
End Namespace