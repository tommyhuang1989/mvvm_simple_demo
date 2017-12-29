using MVVM_Demo_20171229.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

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
        

        public MainWindowViewModel()
        {
            ClickCommand = new DelegateCommand();
            ClickCommand.ExecuteAction = new Action<object>(Click);

            Driver = new Driver();
            Driver.Name = "显卡驱动";
            Driver.Mfg = "戴尔";
            Driver.Date = "2017-12-29";
            Driver.Version = "v1.0";
        }

        private void Click(object obj)
        {
            MessageBox.Show("test just for mvvm");
        } 
    }
}
