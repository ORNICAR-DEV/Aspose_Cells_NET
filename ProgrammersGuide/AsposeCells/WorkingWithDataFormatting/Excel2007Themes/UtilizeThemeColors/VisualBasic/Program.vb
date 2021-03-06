'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Cells. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Cells

Namespace UtilizeThemeColors
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			' Create directory if it is not already present.
			Dim IsExists As Boolean = System.IO.Directory.Exists(dataDir)
			If (Not IsExists) Then
				System.IO.Directory.CreateDirectory(dataDir)
			End If

			'Instantiate a Workbook.
			Dim workbook As New Workbook()

			'Get cells collection in the first (default) worksheet.
			Dim cells As Cells = workbook.Worksheets(0).Cells

			'Get the D3 cell.
			Dim c As Aspose.Cells.Cell = cells("D3")

			'Get the style of the cell.
			Dim s As Style = c.GetStyle()

			'Set foreground color for the cell from the default theme Accent2 color.
			s.ForegroundThemeColor = New ThemeColor(ThemeColorType.Accent2, 0.5)

			'Set the pattern type.
			s.Pattern = BackgroundType.Solid

			'Get the font for the style.
			Dim f As Aspose.Cells.Font = s.Font

			'Set the theme color.
			f.ThemeColor = New ThemeColor(ThemeColorType.Accent4, 0.1)

			'Apply style.
			c.SetStyle(s)

			'Put a value.
			c.PutValue("Testing1")

			'Save the excel file.
			workbook.Save(dataDir & "output.xlsx")

		End Sub
	End Class
End Namespace