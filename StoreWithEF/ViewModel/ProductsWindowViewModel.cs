using StoreWithEF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StoreWithEF.ViewModel
{
    public class ProductsWindowViewModel : BaseViewModel
    {
        StoreWithEFDBEntities context = new StoreWithEFDBEntities();

        public ProductsWindowViewModel()
        {
            _observableProducts = new ObservableCollection<Products>();
            context.Products.Load();

            foreach (var item in context.Products)
            {
                _observableProducts.Add(item);
            }

            OpenFormAddProductWindowCommand = new OpenFormAddProductWindowCommand();
        }

        private ObservableCollection<Products> _observableProducts;

        public ObservableCollection<Products> ObservableProducts
        {
            get
            {
                return _observableProducts;
            }
            set
            {
                _observableProducts = value;
                OnPropertyChanged(nameof(ObservableProducts));
            }
        }

        public ICommand OpenFormAddProductWindowCommand { get; set; }

        public ICommand AddProductCommand { get; set; }
    }
}
