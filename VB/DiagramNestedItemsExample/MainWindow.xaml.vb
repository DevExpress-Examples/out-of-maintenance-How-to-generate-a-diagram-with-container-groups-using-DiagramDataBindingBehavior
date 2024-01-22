Imports DevExpress.Xpf.Diagram
Imports System.Windows
Imports System.Windows.Data
Imports System.Windows.Media

Namespace DiagramNestedItemsExample

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private i As Integer = 999

        Private Sub DiagramDataBindingBehavior_DiagramItemAdding(ByVal sender As Object, ByVal e As DiagramDiagramItemAddingEventArgs)
            If TypeOf e.Item Is DiagramShape Then
                e.DataItem = New Employee() With {.EmployeeID = i, .EmployeeName = "New Emp: " & i}
                e.Item.SetBinding(DiagramShape.ContentProperty, New Binding("EmployeeName"))
                e.Item.Background = Brushes.Orange
                i += 1
            End If
        End Sub
    End Class
End Namespace
