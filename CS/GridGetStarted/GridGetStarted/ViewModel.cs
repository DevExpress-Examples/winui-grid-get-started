using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace GridGetStarted {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            Source = ProductData.GetProducts();

            var countries = Source.Select(p => p.Country);
            Countries = countries.Distinct().ToList();
        }
        public ObservableCollection<Product> Source { get; }
        public IList<string> Countries { get; }
    }
}
