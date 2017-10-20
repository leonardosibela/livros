using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Livros
{
    public partial class MainWindow : Window
    {
        private List<Livro> livros = new List<Livro>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnuVisualizar_Click(object sender, RoutedEventArgs e)
        {
            ListagemDeLivros listagem = new ListagemDeLivros(livros);
            listagem.Show();
        }

        private void mnuAdicionar_Click(object sender, RoutedEventArgs e)
        {
            CadastroDeLivros cadastro = new CadastroDeLivros(livros);
            cadastro.Show();
        }
    }
}
