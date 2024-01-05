Imports Microsoft.VisualBasic
Imports DevExpress.Diagram.Core
Imports System.Windows
Imports System.Windows.Controls

Namespace DiagramNestedItemsExample
	Public Class MyKeySelector
		Implements IKeySelector
		Private Function GetKey(ByVal obj As Object) As Object Implements IKeySelector.GetKey
			If TypeOf obj Is Department Then
				Return (CType(obj, Department)).DepartmentID
			ElseIf TypeOf obj Is Employee Then
				Return (CType(obj, Employee)).EmployeeID
			End If
			Return obj
		End Function
	End Class

	Public Class DiagramItemTemplateSelector
		Inherits DataTemplateSelector
		Private privateDepartmentTemplate As DataTemplate
		Public Property DepartmentTemplate() As DataTemplate
			Get
				Return privateDepartmentTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateDepartmentTemplate = value
			End Set
		End Property
		Private privateEmployeeTemplate As DataTemplate
		Public Property EmployeeTemplate() As DataTemplate
			Get
				Return privateEmployeeTemplate
			End Get
			Set(ByVal value As DataTemplate)
				privateEmployeeTemplate = value
			End Set
		End Property
		Public Overrides Function SelectTemplate(ByVal item As Object, ByVal container As DependencyObject) As DataTemplate
			If TypeOf item Is Department Then
				Return DepartmentTemplate
			ElseIf TypeOf item Is Employee Then
				Return EmployeeTemplate
			End If
			Return MyBase.SelectTemplate(item, container)
		End Function
	End Class
End Namespace
