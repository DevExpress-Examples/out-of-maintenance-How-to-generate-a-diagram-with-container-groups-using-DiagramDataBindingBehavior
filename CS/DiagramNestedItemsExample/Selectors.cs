using DevExpress.Diagram.Core;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace DiagramNestedItemsExample {

    public class ItemsSelector : IChildrenSelector {
        public IEnumerable<object> GetChildren(object parent) {
            if (parent is Department)
                return ((Department)parent).Sections;
            else if (parent is Section)
                return ((Section)parent).Employees;
            return null;
        }
    }
    public class KeySelector : IKeySelector {
        object IKeySelector.GetKey(object obj) {
            if (obj is Department)
                return ((Department)obj).DepartmentID;
            else if (obj is Section)
                return ((Section)obj).SectionID;
            else if (obj is Employee)
                return ((Employee)obj).EmployeeID;
            return obj;
        }
    }

    public class DiagramItemTemplateSelector : DataTemplateSelector {
        public DataTemplate DepartmentTemplate {
            get;
            set;
        }
        public DataTemplate SectionTemplate
        {
            get;
            set;
        }
        public DataTemplate EmployeeTemplate {
            get;
            set;
        }
        public override DataTemplate SelectTemplate(object item, DependencyObject container) {
            if (item is Department)
                return DepartmentTemplate;
            else if (item is Section)
                return SectionTemplate;
            else if (item is Employee)
                return EmployeeTemplate;
            return base.SelectTemplate(item, container);
        }
    }
}
