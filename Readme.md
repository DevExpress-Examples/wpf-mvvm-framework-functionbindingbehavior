<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658274/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T197048)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF MVVM Framework - FunctionBindingBehavior

The [FunctionBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.FunctionBindingBehavior) allows you to use a ViewModel function to calculate a control property. The example uses this behavior to bind the [ChartControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Charts.ChartControl) to the **GetFilteredItems** function and pass [SelectionRangeStart](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.RangeControl.RangeControl.SelectionRangeStart) and [SelectionRangeEnd](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.RangeControl.RangeControl.SelectionRangeEnd) properties of the [RangeControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.RangeControl.RangeControl) to the function.

![image](https://github.com/DevExpress-Examples/how-to-use-functionbindingbehavior-t197048/assets/65009440/027f5733-cffe-4932-9d8f-8b02e1370764)

```cs
public IList<DataItem> GetFilteredItems(DateTime start, DateTime end) {
    return this.Points.Where(x => x.Date.Date >= start && x.Date.Date <= end).OrderByDescending(x => x.ValueSummary).ToList();
}
```

## Files to Review

* [MainView.xaml](./CS/FunctionBindingExample/View/MainView.xaml)
* [MainViewModel.cs](./CS/FunctionBindingExample/ViewModel/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/FunctionBindingExample/ViewModel/MainViewModel.vb))
* [DataItem.cs](./CS/FunctionBindingExample/Common/DataItem.cs) (VB: [DataItem.vb](./VB/FunctionBindingExample/Common/DataItem.vb))

## Documentation

* [FunctionBindingBehavior](https://docs.devexpress.com/WPF/DevExpress.Mvvm.UI.FunctionBindingBehavior)
* [Behaviors](https://docs.devexpress.com/WPF/17442/mvvm-framework/behaviors)
