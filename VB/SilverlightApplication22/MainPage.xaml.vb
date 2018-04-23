Imports Microsoft.VisualBasic
Imports System.Windows.Controls
' ...

Namespace SilverlightApplication22
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
			documentPreview1.Model.CreateDocument()
		End Sub
	End Class
End Namespace
