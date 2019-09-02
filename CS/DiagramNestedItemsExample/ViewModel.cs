using System.Collections.ObjectModel;

namespace DiagramNestedItemsExample {
    public class ViewModel {
        public ObservableCollection<Department> Departments {
            get;
            set;
        }
        public ObservableCollection<Relation> Relations {
            get;
            set;
        }
        public ViewModel() {
            Departments = new ObservableCollection<Department>();
            Department dep1 = new Department() { DepartmentID = 1, DepartmentName = "Provision" };
            Department dep2 = new Department() { DepartmentID = 2, DepartmentName = "Security" };
            Department dep3 = new Department() { DepartmentID = 3, DepartmentName = "HR" };
            dep1.Employees = new ObservableCollection<Employee>();
            dep1.Employees.Add(new Employee() { EmployeeID = 101, EmployeeName = "Mark" });
            dep1.Employees.Add(new Employee() { EmployeeID = 102, EmployeeName = "Jim" });
            dep1.Employees.Add(new Employee() { EmployeeID = 103, EmployeeName = "Andrew" });

            dep2.Employees = new ObservableCollection<Employee>();
            dep2.Employees.Add(new Employee() { EmployeeID = 104, EmployeeName = "Alex" });
            dep2.Employees.Add(new Employee() { EmployeeID = 105, EmployeeName = "Simon" });
            dep2.Employees.Add(new Employee() { EmployeeID = 106, EmployeeName = "Ahmed" });

            dep3.Employees = new ObservableCollection<Employee>();
            dep3.Employees.Add(new Employee() { EmployeeID = 107, EmployeeName = "Kim" });
            dep3.Employees.Add(new Employee() { EmployeeID = 108, EmployeeName = "Adam" });

            Departments.Add(dep1);
            Departments.Add(dep2);
            Departments.Add(dep3);

            Relations = new ObservableCollection<Relation>();
            Relations.Add(new Relation() { FromEmployeeID = 101, ToEmployeeID = 105 });
            Relations.Add(new Relation() { FromEmployeeID = 103, ToEmployeeID = 106 });
            Relations.Add(new Relation() { FromEmployeeID = 107, ToEmployeeID = 104 });
        }
    }

    public class Department {
        public int DepartmentID {
            get;
            set;
        }
        public string DepartmentName {
            get;
            set;
        }
        public ObservableCollection<Employee> Employees {
            get;
            set;
        }
    }

    public class Employee {
        public int EmployeeID {
            get;
            set;
        }
        public string EmployeeName {
            get;
            set;
        }
    }
    public class Relation {
        public int FromEmployeeID {
            get;
            set;
        }
        public int ToEmployeeID {
            get;
            set;
        }
    }
}
