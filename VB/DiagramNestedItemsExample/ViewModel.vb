Imports Microsoft.VisualBasic
Imports System.Collections.ObjectModel

Namespace DiagramNestedItemsExample
	Public Class ViewModel
		Private privateDepartments As ObservableCollection(Of Department)
		Public Property Departments() As ObservableCollection(Of Department)
			Get
				Return privateDepartments
			End Get
			Set(ByVal value As ObservableCollection(Of Department))
				privateDepartments = value
			End Set
		End Property
		Private privateRelations As ObservableCollection(Of Relation)
		Public Property Relations() As ObservableCollection(Of Relation)
			Get
				Return privateRelations
			End Get
			Set(ByVal value As ObservableCollection(Of Relation))
				privateRelations = value
			End Set
		End Property
		Public Sub New()
			Departments = New ObservableCollection(Of Department)()
			Dim dep1 As New Department() With {.DepartmentID = 1, .DepartmentName = "Provision"}
			Dim dep2 As New Department() With {.DepartmentID = 2, .DepartmentName = "Security"}
			Dim dep3 As New Department() With {.DepartmentID = 3, .DepartmentName = "HR"}
			dep1.Employees = New ObservableCollection(Of Employee)()
			dep1.Employees.Add(New Employee() With {.EmployeeID = 101, .EmployeeName = "Mark"})
			dep1.Employees.Add(New Employee() With {.EmployeeID = 102, .EmployeeName = "Jim"})
			dep1.Employees.Add(New Employee() With {.EmployeeID = 103, .EmployeeName = "Andrew"})

			dep2.Employees = New ObservableCollection(Of Employee)()
			dep2.Employees.Add(New Employee() With {.EmployeeID = 104, .EmployeeName = "Alex"})
			dep2.Employees.Add(New Employee() With {.EmployeeID = 105, .EmployeeName = "Simon"})
			dep2.Employees.Add(New Employee() With {.EmployeeID = 106, .EmployeeName = "Ahmed"})

			dep3.Employees = New ObservableCollection(Of Employee)()
			dep3.Employees.Add(New Employee() With {.EmployeeID = 107, .EmployeeName = "Kim"})
			dep3.Employees.Add(New Employee() With {.EmployeeID = 108, .EmployeeName = "Adam"})

			Departments.Add(dep1)
			Departments.Add(dep2)
			Departments.Add(dep3)

			Relations = New ObservableCollection(Of Relation)()
			Relations.Add(New Relation() With {.FromEmployeeID = 101, .ToEmployeeID = 105})
			Relations.Add(New Relation() With {.FromEmployeeID = 103, .ToEmployeeID = 106})
			Relations.Add(New Relation() With {.FromEmployeeID = 107, .ToEmployeeID = 104})
		End Sub
	End Class

	Public Class Department
		Private privateDepartmentID As Integer
		Public Property DepartmentID() As Integer
			Get
				Return privateDepartmentID
			End Get
			Set(ByVal value As Integer)
				privateDepartmentID = value
			End Set
		End Property
		Private privateDepartmentName As String
		Public Property DepartmentName() As String
			Get
				Return privateDepartmentName
			End Get
			Set(ByVal value As String)
				privateDepartmentName = value
			End Set
		End Property
		Private privateEmployees As ObservableCollection(Of Employee)
		Public Property Employees() As ObservableCollection(Of Employee)
			Get
				Return privateEmployees
			End Get
			Set(ByVal value As ObservableCollection(Of Employee))
				privateEmployees = value
			End Set
		End Property
	End Class

	Public Class Employee
		Private privateEmployeeID As Integer
		Public Property EmployeeID() As Integer
			Get
				Return privateEmployeeID
			End Get
			Set(ByVal value As Integer)
				privateEmployeeID = value
			End Set
		End Property
		Private privateEmployeeName As String
		Public Property EmployeeName() As String
			Get
				Return privateEmployeeName
			End Get
			Set(ByVal value As String)
				privateEmployeeName = value
			End Set
		End Property
	End Class
	Public Class Relation
		Private privateFromEmployeeID As Integer
		Public Property FromEmployeeID() As Integer
			Get
				Return privateFromEmployeeID
			End Get
			Set(ByVal value As Integer)
				privateFromEmployeeID = value
			End Set
		End Property
		Private privateToEmployeeID As Integer
		Public Property ToEmployeeID() As Integer
			Get
				Return privateToEmployeeID
			End Get
			Set(ByVal value As Integer)
				privateToEmployeeID = value
			End Set
		End Property
	End Class
End Namespace
