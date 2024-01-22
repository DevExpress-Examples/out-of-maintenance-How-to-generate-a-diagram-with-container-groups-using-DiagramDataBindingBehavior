using DevExpress.Xpf.Diagram;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace DiagramNestedItemsExample {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        int i = 999;
        private void DiagramDataBindingBehavior_DiagramItemAdding(object sender, DevExpress.Xpf.Diagram.DiagramDiagramItemAddingEventArgs e) {
            if (e.Item is DiagramShape) {
                e.DataItem = new Employee() { EmployeeID = i, EmployeeName = "New Emp: " + i };
                e.Item.SetBinding(DiagramShape.ContentProperty, new Binding("EmployeeName"));
                e.Item.Background = Brushes.Orange;
                i++;
            }
        }
    }
}
