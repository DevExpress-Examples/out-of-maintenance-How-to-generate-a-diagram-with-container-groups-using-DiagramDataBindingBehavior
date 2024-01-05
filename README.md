<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/205897262/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828518)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Diagram Control - How to generate diagrams with grouped items

This example demonstrates how to use [DiagramDataBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior) to generate diagrams with grouped items.

The DiagramDataBindingBehavior allows you to generate diagram with several levels of grouped items. You can specify the child collection name using the [ItemsPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsPath) property. If you use different collections for different levels, use [ItemsSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsSelector). To select keys for parent and child items, use [KeySelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.KeySelector).

**Note** that the Item Template Designer doesn't allow you to select artbitrary containers and [DiagramLists](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramList). You need to explicitly define corresponding items in the [Template Diagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.TemplateDiagram) or use [ItemTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemTemplateSelector). This example demonstrates the second option.

## Files to Review

- [MainWindow.xaml](./CS/DiagramNestedItemsExample/MainWindow.xaml)
- [MainWindow.cs](./CS/DiagramNestedItemsExample/MainWindow.xaml.cs) (VB: [Form1.vb](./VB/DiagramNestedItemsExample/MainWindow.xaml.vb))
