Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel

Namespace DiagramNestedItemsExample

    Public Class ViewModel

        Public Property Departments As ObservableCollection(Of Department)

        Public Property Relations As ObservableCollection(Of Relation)

        Public Sub New()
            Departments = New ObservableCollection(Of Department)()
            Dim dep1 = New Department() With {.DepartmentID = 1, .DepartmentName = "Provision", .Sections = New ObservableCollection(Of Section)()}
            Dim dep2 = New Department() With {.DepartmentID = 2, .DepartmentName = "Security", .Sections = New ObservableCollection(Of Section)()}
            Dim dep3 = New Department() With {.DepartmentID = 3, .DepartmentName = "HR", .Sections = New ObservableCollection(Of Section)()}
            Dim section1 = New Section() With {.SectionID = 11, .SectionName = "Local", .Employees = New ObservableCollection(Of Employee)()}
            Dim section2 = New Section() With {.SectionID = 12, .SectionName = "Foreign Hubs", .Employees = New ObservableCollection(Of Employee)()}
            Dim section3 = New Section() With {.SectionID = 13, .SectionName = "Technical security", .Employees = New ObservableCollection(Of Employee)()}
            Dim section4 = New Section() With {.SectionID = 14, .SectionName = "Staff", .Employees = New ObservableCollection(Of Employee)()}
            Dim section5 = New Section() With {.SectionID = 15, .SectionName = "Managers", .Employees = New ObservableCollection(Of Employee)()}
            Dim section6 = New Section() With {.SectionID = 16, .SectionName = "Interviewers", .Employees = New ObservableCollection(Of Employee)()}
            section1.Employees.Add(New Employee() With {.EmployeeID = 101, .EmployeeName = "Mark"})
            section1.Employees.Add(New Employee() With {.EmployeeID = 102, .EmployeeName = "Jim"})
            section2.Employees.Add(New Employee() With {.EmployeeID = 103, .EmployeeName = "Andrew"})
            section2.Employees.Add(New Employee() With {.EmployeeID = 104, .EmployeeName = "Alex"})
            section3.Employees.Add(New Employee() With {.EmployeeID = 105, .EmployeeName = "Simon"})
            section3.Employees.Add(New Employee() With {.EmployeeID = 106, .EmployeeName = "Lily"})
            section4.Employees.Add(New Employee() With {.EmployeeID = 107, .EmployeeName = "Kim"})
            section4.Employees.Add(New Employee() With {.EmployeeID = 108, .EmployeeName = "Adam"})
            section5.Employees.Add(New Employee() With {.EmployeeID = 109, .EmployeeName = "Jack"})
            section5.Employees.Add(New Employee() With {.EmployeeID = 110, .EmployeeName = "Miriam"})
            section6.Employees.Add(New Employee() With {.EmployeeID = 111, .EmployeeName = "Justin"})
            section6.Employees.Add(New Employee() With {.EmployeeID = 112, .EmployeeName = "Alexa"})
            dep1.Sections.Add(section1)
            dep1.Sections.Add(section2)
            dep2.Sections.Add(section3)
            dep2.Sections.Add(section4)
            dep3.Sections.Add(section5)
            dep3.Sections.Add(section6)
            Departments.Add(dep1)
            Departments.Add(dep2)
            Departments.Add(dep3)
            Relations = New ObservableCollection(Of Relation)()
            Relations.Add(New Relation() With {.FromEmployeeID = 106, .ToEmployeeID = 101})
            Relations.Add(New Relation() With {.FromEmployeeID = 102, .ToEmployeeID = 109})
            Relations.Add(New Relation() With {.FromEmployeeID = 103, .ToEmployeeID = 108})
        End Sub
    End Class

    Public Class Department
        Inherits BindableBase

        Public Property DepartmentID As Integer
            Get
                Return GetProperty(Function() Me.DepartmentID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() DepartmentID, value)
            End Set
        End Property

        Public Property DepartmentName As String
            Get
                Return GetProperty(Function() Me.DepartmentName)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() DepartmentName, value)
            End Set
        End Property

        Public Property Sections As ObservableCollection(Of Section)
            Get
                Return GetProperty(Function() Me.Sections)
            End Get

            Set(ByVal value As ObservableCollection(Of Section))
                SetProperty(Function() Sections, value)
            End Set
        End Property
    End Class

    Public Class Section
        Inherits BindableBase

        Public Property SectionID As Integer
            Get
                Return GetProperty(Function() Me.SectionID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() SectionID, value)
            End Set
        End Property

        Public Property SectionName As String
            Get
                Return GetProperty(Function() Me.SectionName)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() SectionName, value)
            End Set
        End Property

        Public Property Employees As ObservableCollection(Of Employee)
            Get
                Return GetProperty(Function() Me.Employees)
            End Get

            Set(ByVal value As ObservableCollection(Of Employee))
                SetProperty(Function() Employees, value)
            End Set
        End Property
    End Class

    Public Class Employee
        Inherits BindableBase

        Public Property EmployeeID As Integer
            Get
                Return GetProperty(Function() Me.EmployeeID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() EmployeeID, value)
            End Set
        End Property

        Public Property EmployeeName As String
            Get
                Return GetProperty(Function() Me.EmployeeName)
            End Get

            Set(ByVal value As String)
                SetProperty(Function() EmployeeName, value)
            End Set
        End Property
    End Class

    Public Class Relation
        Inherits BindableBase

        Public Property FromEmployeeID As Integer
            Get
                Return GetProperty(Function() Me.FromEmployeeID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() FromEmployeeID, value)
            End Set
        End Property

        Public Property ToEmployeeID As Integer
            Get
                Return GetProperty(Function() Me.ToEmployeeID)
            End Get

            Set(ByVal value As Integer)
                SetProperty(Function() ToEmployeeID, value)
            End Set
        End Property
    End Class
End Namespace
