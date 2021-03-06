﻿Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace PivotGridEditor
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            Dim data As New DataTable()
            data.Columns.Add("row", GetType(String))
            data.Columns.Add("data", GetType(String))
            data.Rows.Add("1", "aaa")
            data.Rows.Add("2", "bbb")
            data.Rows.Add("3", "ccc")
            data.Rows.Add("4", "ddd")
            pivotGridControl1.DataSource = data.DefaultView
        End Sub

        Private Sub pivotGridControl1_EditValueChanged(ByVal sender As Object, _
                                                       ByVal e As EditValueChangedEventArgs) _
                                                   Handles pivotGridControl1.EditValueChanged
            Dim ds As PivotDrillDownDataSource = e.CreateDrillDownDataSource()
            ds.SetValue(0, "data", e.Editor.EditValue)
        End Sub
    End Class
End Namespace