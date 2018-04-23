Imports System
Imports System.Linq
Imports System.Collections.Generic
Imports DevExpress.Mvvm.POCO

Namespace FunctionBindingExample.Common
    Public Class DataItem
        Protected Sub New(ByVal [date] As Date, ByVal valueSummary As Double, ByVal stageName As String)
            Me.Date = [date]
            Me.ValueSummary = valueSummary
            Me.StageName = stageName
        End Sub

        Public Shared Function Create(ByVal [date] As Date, ByVal valueSummary As Double, ByVal stageName As String) As DataItem
            Return ViewModelSource.Create(Function() New DataItem([date], valueSummary, stageName))
        End Function

        Public Property [Date]() As Date
        Public Property ValueSummary() As Double
        Public Property StageName() As String
    End Class
End Namespace
