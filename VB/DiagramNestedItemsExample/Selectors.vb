Imports DevExpress.Diagram.Core
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Controls

Namespace DiagramNestedItemsExample

    Public Class ItemsSelector
        Implements IChildrenSelector

        Public Function GetChildren(ByVal parent As Object) As IEnumerable(Of Object) Implements IChildrenSelector.GetChildren
            If TypeOf parent Is Department Then
                Return CType(parent, Department).Sections
            ElseIf TypeOf parent Is Section Then
                Return CType(parent, Section).Employees
            End If

            Return Nothing
        End Function
    End Class

    Public Class KeySelector
        Implements IKeySelector

        Private Function GetKey(ByVal obj As Object) As Object Implements IKeySelector.GetKey
            If TypeOf obj Is Department Then
                Return CType(obj, Department).DepartmentID
            ElseIf TypeOf obj Is Section Then
                Return CType(obj, Section).SectionID
            ElseIf TypeOf obj Is Employee Then
                Return CType(obj, Employee).EmployeeID
            End If

            Return obj
        End Function
    End Class

    Public Class DiagramItemTemplateSelector
        Inherits DataTemplateSelector

        Public Property DepartmentTemplate As DataTemplate

        Public Property SectionTemplate As DataTemplate

        Public Property EmployeeTemplate As DataTemplate

        Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
            If TypeOf item Is Department Then
                Return DepartmentTemplate
            ElseIf TypeOf item Is Section Then
                Return SectionTemplate
            ElseIf TypeOf item Is Employee Then
                Return EmployeeTemplate
            End If

            Return MyBase.SelectTemplate(item, container)
        End Function
    End Class
End Namespace
