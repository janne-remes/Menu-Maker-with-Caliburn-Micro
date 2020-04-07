using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MenuMaker_CaliburnMicro.Models;

namespace MenuMaker_CaliburnMicro.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        private string _dishName;
        private string _dishDescription;
        private double _dishPrice;

        private BindableCollection<DishModel> _dishes = new BindableCollection<DishModel>();

        private DishModel _selectedDish;
        
        //private BindableCollection<DishModel> _dishes = new BindableCollection<DishModel>();

        public ShellViewModel()
        {
            Dishes.Add(new DishModel { DishName = "Lihapullat perunamuusilla", DishDescription = "Mummon reseptillä lihapullat ruskeassa kastikkeessa, perunamuusia ja puolukkahilloa", DishPrice = 5.35 });
            Dishes.Add(new DishModel { DishName = "Kalakukkoa", DishDescription = "Savon perinneherkkua", DishPrice = 4.40 });
        }

        public string DishName
        {
            get
            {
                return _dishName;
            }

            set
            {
                _dishName = value;
                NotifyOfPropertyChange(() => DishName);
            }
        }

        public string DishDescription
        {
            get
            {
                return _dishDescription;
            }

            set
            {
                _dishDescription = value;
                NotifyOfPropertyChange(() => DishDescription);
            }
        }

        public double DishPrice
        {
            get
            {
                return _dishPrice;
            }

            set
            {
                _dishPrice = value;
                NotifyOfPropertyChange(() => DishPrice);
            }
        }

        public BindableCollection<DishModel> Dishes
        {
            get
            {
                return _dishes;
            }

            set
            {
                _dishes = value;
            }
        }

        public DishModel SelectedDish
        {
            get
            {
                return _selectedDish;
            }

            set
            {
                _selectedDish = value;
                NotifyOfPropertyChange(() => SelectedDish);
            }
        }

        public void LoadDishView()
        {
            ActivateItemAsync(new DishViewModel(), System.Threading.CancellationToken.None);
        }
    }
}
