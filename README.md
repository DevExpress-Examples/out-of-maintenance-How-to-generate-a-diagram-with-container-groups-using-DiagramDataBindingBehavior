<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T828518)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Diagram Control - Generate Diagrams with Grouped Items

This example demonstrates how to use [DiagramDataBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior) to generate diagrams with grouped items.

![image](https://github.com/DevExpress-Examples/wpf-generate-diagram-with-grouped-items/assets/65009440/177712fa-3b7f-40ab-ac5e-3415e35744c3)

The `DiagramDataBindingBehavior` allows you to generate a diagram with multiple group levels. You can use the [ItemsPath](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsPath) property to specify the child collection name. If you use different collections for different group levels, use [ItemsSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemsSelector). To select keys for parent and child items, use [KeySelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.KeySelector).

> **Note**
> 
> The [Item Template Designer](https://docs.devexpress.com/WPF/117615/controls-and-libraries/diagram-control/data-binding/item-template-designer) does not allow you to select arbitrary containers and [Diagram Lists](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramList). You should explicitly define corresponding items in the [Template Diagram](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.TemplateDiagram) or use the [ItemTemplateSelector](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehaviorBase.ItemTemplateSelector) property as demonstrated in this example.

## Files to Review

- [MainWindow.xaml](./CS/DiagramNestedItemsExample/MainWindow.xaml)
- [MainWindow.cs](./CS/DiagramNestedItemsExample/MainWindow.xaml.cs) (VB: [Form1.vb](./VB/DiagramNestedItemsExample/MainWindow.xaml.vb))

## Documentation

* [Generate Diagrams from a Data Source](https://docs.devexpress.com/WPF/118578/controls-and-libraries/diagram-control/data-binding/generating-diagrams-from-a-data-source)
* [DiagramDataBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramDataBindingBehavior)

## More Examples

* [WPF Diagram - Use the DiagramDataBindingBehavior to Generate a Diagram from a Collection](https://github.com/DevExpress-Examples/wpf-diagram-use-diagramdatabindingbehavior-to-generate-diagram-from-collection)
