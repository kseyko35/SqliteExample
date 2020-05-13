using System;
using System.Collections.Generic;
using SqlLiteExample.Models;
using Xamarin.Forms;

namespace SqlLiteExample.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Student student)
        {

            InitializeComponent();
           
            lblName.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)); // Cihaza gore large size aliyor
            lblSurname.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));

            lblName.Text = student.Name;
            lblSurname.Text = student.Surname;
         }
    }
}
