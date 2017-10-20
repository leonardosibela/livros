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
using System.Windows.Shapes;

namespace Livros
{
    /// <summary>
    /// Interaction logic for CadastroDeLivros.xaml
    /// </summary>
    public partial class CadastroDeLivros : Window
    {
        private List<Livro> listaDeLivros;

        public CadastroDeLivros(List<Livro> livros)
        {
            listaDeLivros = livros;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            Livro livro = new Livro();
            livro.nome = txtNome.Text;
            livro.autor = txtAutor.Text;
            livro.valor = Convert.ToDouble(txtValor.Text);
            listaDeLivros.Add(livro);

            txtNome.Clear();
            txtAutor.Clear();
            txtValor.Clear();
        }
    }
}
