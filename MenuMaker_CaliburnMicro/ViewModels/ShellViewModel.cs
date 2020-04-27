using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Text;
using MenuMaker_CaliburnMicro.Models;
using System.Windows.Controls;
using Dapper;

namespace MenuMaker_CaliburnMicro.ViewModels
{
    public class ShellViewModel : Conductor<Object>
    {
        // DISH VARIABLES
        private string _dishName;
        private string _dishDescription;
        private double _dishPrice;

        private BindableCollection<DishModel> _dishes = new BindableCollection<DishModel>();

        private DishModel _selectedDish;
        
        // MENU VARIABLES
        private string _menuName;
        private string _menuDescription;

        private BindableCollection<MenuModel> _ruokalistat = new BindableCollection<MenuModel>();

        private MenuModel _selectedRuokalista;

        private BindableCollection<DishModel> _foodsInMenu = new BindableCollection<DishModel>();

        public ShellViewModel()
        {
            Dishes.Add(new DishModel { DishName = "Lihapullat perunamuusilla", DishDescription = "Mummon reseptillä lihapullat ruskeassa kastikkeessa, perunamuusia ja puolukkahilloa", DishPrice = 5.35 });
            Dishes.Add(new DishModel { DishName = "Kalakukkoa", DishDescription = "Savon perinneherkkua", DishPrice = 4.40 });
            Dishes.Add(new DishModel { DishName = "Chilimakkarapannu", DishDescription = "Mausteista makkaraa ja perunaa", DishPrice = 5.45 });
            Dishes.Add(new DishModel { DishName = "Kesäkeitto", DishDescription = "Kasviksia ja juureksia maitoliemessä", DishPrice = 3.90 });
            Dishes.Add(new DishModel { DishName = "Oopperakellarin silakat", DishDescription = "Paistetut silakat, perunasose", DishPrice = 11.95 });
            Dishes.Add(new DishModel { DishName = "Teriyaki-lohi", DishDescription = "Paistettu lohi, teriyaki-kastike, purjomajoneesi, riisi", DishPrice = 22.45 });

            Ruokalistat.Add(new MenuModel { MenuName = "Aamiaislista" });
            Ruokalistat.Add(new MenuModel { MenuName = "Lounaslista" });
            Ruokalistat.Add(new MenuModel { MenuName = "A la carte -lista" });
            Ruokalistat.Add(new MenuModel { MenuName = "Lastenlista" });
        }

        #region dish Stuff
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
        
        public void InsertDish(string insertName, string insertDescription)
        {
            //decimal strintToDecimal = decimal.Parse(insertPrice);
            Dishes.Add(new DishModel { DishName = insertName, DishDescription = insertDescription, DishPrice = 0});
            //NotifyOfPropertyChange(() => DishName);
            //NotifyOfPropertyChange(() => DishDescription);
        }

        public void RemoveDish()
        {
            //Dishes.Remove(DishName = _selectedDish_DishName);
            NotifyOfPropertyChange(() => SelectedDish);
        }

        #endregion

        #region Menu Stuff

        public string MenuName
        {
            get
            {
                return _menuName;
            }

            set
            {
                _menuName = value;
                NotifyOfPropertyChange(() => MenuName);
            }
        }

        public string MenuDescription
        {
            get
            {
                return _menuDescription;
            }

            set
            {
                _menuDescription = value;
                NotifyOfPropertyChange(() => MenuDescription);
            }
        }

        public BindableCollection<MenuModel> Ruokalistat
        {
            get
            {
                return _ruokalistat;
            }

            set
            {
                _ruokalistat = value;
            }
        }

        public MenuModel SelectedRuokalista
        {
            get
            {
                return _selectedRuokalista;
            }

            set
            {
                _selectedRuokalista = value;
                NotifyOfPropertyChange(() => SelectedRuokalista);
            }
        }

        #endregion

        public void LoadDishView()
        {
            ActivateItemAsync(new DishViewModel(), System.Threading.CancellationToken.None);
        }

        public void LoadMenuView()
        {
            ActivateItemAsync(new MenuViewModel(), System.Threading.CancellationToken.None);
        }
    }
}
