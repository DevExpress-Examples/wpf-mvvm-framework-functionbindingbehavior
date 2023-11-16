Imports System
Imports System.Linq
Imports DevExpress.Mvvm.POCO
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports FunctionBindingExample.Common

Namespace FunctionBindingExample.ViewModel

    Public Class MainViewModel

        Protected Sub New()
            Points = New ObservableCollection(Of DataItem)() From {DataItem.Create(New DateTime(2015, 02, 18), 3.47, "A"), DataItem.Create(New DateTime(2015, 01, 01), 2.08, "B"), DataItem.Create(New DateTime(2015, 02, 01), 2.42, "C"), DataItem.Create(New DateTime(2015, 03, 01), 2.78, "E"), DataItem.Create(New DateTime(2015, 04, 01), 2.78, "F"), DataItem.Create(New DateTime(2015, 05, 01), 2.57, "G"), DataItem.Create(New DateTime(2015, 06, 01), 2.69, "H"), DataItem.Create(New DateTime(2015, 07, 01), 2.96, "I"), DataItem.Create(New DateTime(2015, 08, 01), 2.36, "J"), DataItem.Create(New DateTime(2015, 09, 01), 1.97, "K"), DataItem.Create(New DateTime(2015, 10, 11), 2.75, "L"), DataItem.Create(New DateTime(2015, 11, 12), 3.45, "M"), DataItem.Create(New DateTime(2015, 12, 13), 4.08, "N"), DataItem.Create(New DateTime(2014, 01, 14), 3.47, "P"), DataItem.Create(New DateTime(2014, 02, 15), 2.64, "Q"), DataItem.Create(New DateTime(2014, 03, 16), 4.59, "R"), DataItem.Create(New DateTime(2014, 04, 17), 1.54, "S"), DataItem.Create(New DateTime(2014, 05, 18), 4.12, "T"), DataItem.Create(New DateTime(2014, 06, 19), 3.47, "U")}
        End Sub

        Public Shared Function Create() As MainViewModel
            Return ViewModelSource.Create(Function() New MainViewModel())
        End Function

        Public Overridable Property Points As ObservableCollection(Of DataItem)

        Public Function GetFilteredItems(ByVal start As Date, ByVal [end] As Date) As IList(Of DataItem)
            Return Points.Where(Function(x) x.Date.Date >= start AndAlso x.Date.Date <= [end]).OrderByDescending(Function(x) x.ValueSummary).ToList()
        End Function
    End Class
End Namespace
