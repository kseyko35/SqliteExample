using System;
using System.Collections.Generic;
using System.Linq;
using SqlLiteExample.Helper;
using SqlLiteExample.Models;
using Xamarin.Forms;

namespace SqlLiteExample.Views
{
    public partial class ListPage : ContentPage
    {
        SqlitManager manager= new SqlitManager();
        public ListPage()
        {
            InitializeComponent();
            List<Student> list = new List<Student>();
           
            list = manager.GetAll().ToList();

            lstStudents.BindingContext = list;
        }

        void OnInsertMenu(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new InstertPage());
        }

        void OnRefreshMenu(System.Object sender, System.EventArgs e)
        {
           RefreshData();
        }

        private async void OnMenuDelete(System.Object sender, System.EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudentItem = manager.Get(Convert.ToInt32(selectedMenuItem.CommandParameter.ToString()));
            bool isOk =await DisplayAlert("Alert", selectedStudentItem.Name + " will delete?", "OK", "Cancel");
            if (isOk)
            {
                var isDeleted = manager.Delete(Convert.ToInt32(selectedMenuItem.CommandParameter.ToString()));
                if (isDeleted > 0)
                {
                    DisplayAlert("Success", "Deleted", "OK");
                    RefreshData();
                }
            }
           
        }
        public void RefreshData()
        {
            List<Student> list = new List<Student>();
            list = manager.GetAll().ToList();

            lstStudents.BindingContext = list;
        }

        void OnDetailMenu(System.Object sender, System.EventArgs e)
        {
            var selectedMenuItem = (MenuItem)sender;
            var selectedStudent = manager.Get(Convert.ToInt32(selectedMenuItem.CommandParameter.ToString()) );
            Navigation.PushModalAsync(new DetailPage(selectedStudent));
        }
    }
}
