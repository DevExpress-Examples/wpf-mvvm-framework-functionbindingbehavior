using DevExpress.Mvvm.POCO;
using System;

namespace FunctionBindingExample.Common {
    public class DataItem {
        protected DataItem(DateTime date, double valueSummary, string stageName) {
            Date = date;
            ValueSummary = valueSummary;
            StageName = stageName;
        }

        public static DataItem Create(DateTime date, double valueSummary, string stageName) {
            return ViewModelSource.Create(() => new DataItem(date, valueSummary, stageName));
        }

        public DateTime Date { get; set; }
        public double ValueSummary { get; set; }
        public string StageName { get; set; }
    }
}
