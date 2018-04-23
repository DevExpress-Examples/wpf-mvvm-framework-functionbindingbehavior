
using System;
using System.Linq;
using DevExpress.Mvvm.POCO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FunctionBindingExample.Common;

namespace FunctionBindingExample.ViewModel {
    public class MainViewModel {
        protected MainViewModel() {
            Points = new ObservableCollection<DataItem>(){
                DataItem.Create(new DateTime(2015, 02, 18), 3.47, "A"),
                DataItem.Create(new DateTime(2015, 01, 01), 2.08, "B"),
                DataItem.Create(new DateTime(2015, 02, 01), 2.42, "C"),
                DataItem.Create(new DateTime(2015, 03, 01), 2.78, "E"),
                DataItem.Create(new DateTime(2015, 04, 01), 2.78, "F"),
                DataItem.Create(new DateTime(2015, 05, 01), 2.57, "G"),
                DataItem.Create(new DateTime(2015, 06, 01), 2.69, "H"),
                DataItem.Create(new DateTime(2015, 07, 01), 2.96, "I"),
                DataItem.Create(new DateTime(2015, 08, 01), 2.36, "J"),
                DataItem.Create(new DateTime(2015, 09, 01), 1.97, "K"),
                DataItem.Create(new DateTime(2015, 10, 11), 2.75, "L"),
                DataItem.Create(new DateTime(2015, 11, 12), 3.45, "M"),
                DataItem.Create(new DateTime(2015, 12, 13), 4.08, "N"),
                DataItem.Create(new DateTime(2014, 01, 14), 3.47, "P"),
                DataItem.Create(new DateTime(2014, 02, 15), 2.64, "Q"),
                DataItem.Create(new DateTime(2014, 03, 16), 4.59, "R"),
                DataItem.Create(new DateTime(2014, 04, 17), 1.54, "S"),
                DataItem.Create(new DateTime(2014, 05, 18), 4.12, "T"),
                DataItem.Create(new DateTime(2014, 06, 19), 3.47, "U"),
            };
        }

        public static MainViewModel Create() {
            return ViewModelSource.Create(()=>new MainViewModel());
        }

        public virtual ObservableCollection<DataItem> Points { get; set; }

        public IList<DataItem> GetFilteredItems(DateTime start, DateTime end) {
            return this.Points.Where(x => x.Date.Date >= start && x.Date.Date <= end).ToList();
        }
    }
}
