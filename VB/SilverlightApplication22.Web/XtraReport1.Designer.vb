Imports Microsoft.VisualBasic
Imports System
Namespace SilverlightApplication22.Web
	Partial Public Class XtraReport1
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

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
			Me.formattingRule1 = New DevExpress.XtraReports.UI.FormattingRule()
			Me.dataSet11 = New SilverlightApplication22.Web.DataSet1()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.parameter1 = New DevExpress.XtraReports.Parameters.Parameter()
			Me.productsTableAdapter = New SilverlightApplication22.Web.DataSet1TableAdapters.ProductsTableAdapter()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPageBreak1, Me.xrLabel1})
			Me.Detail.HeightF = 46.875F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPageBreak1
			' 
			Me.xrPageBreak1.FormattingRules.Add(Me.formattingRule1)
			Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPageBreak1.Name = "xrPageBreak1"
			Me.xrPageBreak1.Visible = False
			' 
			' formattingRule1
			' 
			Me.formattingRule1.Condition = "([DataSource.CurrentRowIndex] % [Parameters.parameter1] == 0) And ([DataSource.Cu" & "rrentRowIndex] != 0)"
			Me.formattingRule1.DataMember = "Products"
			Me.formattingRule1.DataSource = Me.dataSet11
			' 
			' 
			' 
			Me.formattingRule1.Formatting.Visible = DevExpress.Utils.DefaultBoolean.True
			Me.formattingRule1.Name = "formattingRule1"
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' xrLabel1
			' 
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(433.3333F, 23F)
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 48F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' parameter1
			' 
			Me.parameter1.Description = "Rows Per Page:"
			Me.parameter1.Name = "parameter1"
			Me.parameter1.Type = GetType(Integer)
			Me.parameter1.Value = 5
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.dataSet11
			Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() { Me.formattingRule1})
			Me.Margins = New System.Drawing.Printing.Margins(49, 100, 48, 100)
			Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.parameter1})
			Me.RequestParameters = False
			Me.Version = "10.2"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Public parameter1 As DevExpress.XtraReports.Parameters.Parameter
		Private xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
		Private dataSet11 As DataSet1
		Private productsTableAdapter As DataSet1TableAdapters.ProductsTableAdapter
		Public formattingRule1 As DevExpress.XtraReports.UI.FormattingRule
	End Class
End Namespace
