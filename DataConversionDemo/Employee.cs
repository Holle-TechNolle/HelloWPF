using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataConversionDemo
{
    public class Employee : INotifyPropertyChanged 
    {
        private DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                startDate = value;
                OnPropertyChanged();
            }
        }
        public static ObservableCollection<Employee> GetEmoloyees()
        {
            var employees = new ObservableCollection<Employee>();
            employees.Add(new Employee() { Name = "Wahington", Title = "President 1" });
            employees.Add(new Employee() { Name = "Adams", Title = "President 2" });
            employees.Add(new Employee() { Name = "Jefferson", Title = "President 3" });
            employees.Add(new Employee() { Name = "Madison", Title = "President 4" });
            employees.Add(new Employee() { Name = "Monroe", Title = "President 5" });
            return employees;
        }

        private string name;
        public string Name {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        public static Employee GetEmployee()
        {
            var emp = new Employee() { Name = "Tom", Title = "Developer" };
            return emp;
        }
    }
}
