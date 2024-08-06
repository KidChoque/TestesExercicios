using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros
{
    public static class Livros
    {
        public static List<string> Listalivros = new List<string>();


        public static int ContarLivros()
        {
            return Listalivros.Count;
        }
        public static List<string> AdicionarLivro(string livro)
        {

            if (string.IsNullOrWhiteSpace(livro))
            {
                return null;
            }

            Listalivros.Add(livro);

            return Listalivros;

     

        }
    }
}
