<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/205897262/19.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828518)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to generate a diagram with container groups using DiagramDataBindingBehavior

Bind [DiagramDataBindingBehavior.ItemsSource](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsSource.property) to a collection with root items and specify the child collection name using the [ItemsPath](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsPath.property) property. To select different keys for parent and child items, use [KeySelector](https://documentation.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.KeySelector.property). 
Note that [DiagramContainers](https://documentation.devexpress.com/WPF/117205/Controls-and-Libraries/Diagram-Control/Diagram-Items/Containers) don't automatically arrange their children, so it's necessary to implement this functionality on your own. In this example, child items are arranged in the *StackLayoutDiagramContainerBehavior* class.
