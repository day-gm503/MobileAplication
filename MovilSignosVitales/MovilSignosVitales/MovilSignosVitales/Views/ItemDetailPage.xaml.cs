using MovilSignosVitales.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MovilSignosVitales.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}