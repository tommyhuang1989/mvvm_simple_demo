using MVVM_Demo_20171229.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.ObjectModel;

namespace MVVM_Demo_20171229.ViewModels
{
    public class MainWindowViewModel:NotificationObject
    {
        public DelegateCommand ClickCommand { get; set; }
        
        private Driver driver;

        public Driver Driver
        {
            get { return driver; }
            set
            {
                driver = value;
                this.RaisePropertyChanged("Driver");
            }
        }

        private ObservableCollection<Driver> driverList;

        public ObservableCollection<Driver> DriverList
        {
            get { return driverList; }
            set
            {
                driverList = value;
                this.RaisePropertyChanged("DriverList");
            }
        }
        
        
        

        public MainWindowViewModel()
        {
            ClickCommand = new DelegateCommand();
            ClickCommand.ExecuteAction = new Action<object>(Click);

            Driver = new Driver();
            Driver.Name = "显卡驱动";
            Driver.Mfg = "戴尔";
            Driver.Date = "2017-12-29";
            Driver.Version = "v1.0";

            InitData();
        }

        private void InitData()
        {
            DriverList = new ObservableCollection<Driver>() { 
                new Driver("HP driver", "HP", "2018-01-06", "22.33.45"),
                new Driver("ASUS video driver", "ASUS", "2018-01-06", "22.33.45"),
                new Driver("HP driver", "HP", "Lenovo", "22.33.45"),
                new Driver("HP driver", "HP", "NVIDA", "22.33.45"),
                new Driver("HP driver", "HP", "AMD", "22.33.45"),
                new Driver("HP driver", "HP", "Gigabyte", "22.33.45"),
            };
        }

        private void Click(object obj)
        {
            MessageBox.Show("test just for mvvm");
        } 
    }
}
