using DevExpress.Xpf.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DiagramNestedItemsExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        int i = 999;
        private void DiagramDataBindingBehavior_DiagramItemAdding(object sender, DevExpress.Xpf.Diagram.DiagramDiagramItemAddingEventArgs e) {
            if (e.Item is DiagramShape shape) {
                e.DataItem = new Employee() { EmployeeID = i, EmployeeName = "New Emp: " + i };
                e.Item.SetBinding(DiagramShape.ContentProperty, new Binding("EmployeeName"));
                e.Item.Background = Brushes.Orange;
                i++;
            }
        }
    }
}
