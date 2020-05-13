using System;
using System.Collections.Generic;
using SqlLiteExample.Helper;
using SqlLiteExample.Models;
using Xamarin.Forms;

namespace SqlLiteExample.Views
{
    public partial class InstertPage : ContentPage
    {
        public InstertPage()
        {
            InitializeComponent();
        }

        private async void OnInsert(System.Object sender, System.EventArgs e)
        {
            SqlitManager manager = new SqlitManager();
            Student student = new Student();
            student.Name = txtName.Text;
            student.Surname = txtSurname.Text;
            student.RegisterDate = DateTime.Now;

            int isInserted = manager.Insert(student);
            if (isInserted > 0)
            {
                var res= await DisplayAlert("Suscess", student.Name + " is added.", "OK", "Cancel");
                if (res) {
                    await Navigation.PopAsync();
                    ListPage listPage = new ListPage();
                    listPage.RefreshData();
                   
                };
            }
            else await DisplayAlert("Failed", "There is a problem","Ok");

            
        }
    }
}
