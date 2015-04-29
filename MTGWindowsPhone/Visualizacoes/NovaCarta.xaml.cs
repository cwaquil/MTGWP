using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MTGWindowsPhone.ModelView;

namespace MTGWindowsPhone.Visualizacoes
{
    public partial class NovaCarta : PhoneApplicationPage
    {

        private CardModelView CardMV;

        public NovaCarta()
        {
            InitializeComponent();

            this.CardMV = new CardModelView();
        }

        private void Salvar_Click(object sender, RoutedEventArgs e)
        {
            if (txtNome.Text == "" || txtTipo.Text == "" || txtSubtipo.Text == "" || txtCor.Text == "")
                MessageBox.Show("Preencha todos os campos!");

            this.CardMV.Save(txtNome.Text, txtTipo.Text, txtSubtipo.Text, txtCor.Text);

            NavigationService.Navigate(new Uri("/Visualizacoes/Wishlist.xaml?titulo=",
                UriKind.RelativeOrAbsolute));
        }



    }
}