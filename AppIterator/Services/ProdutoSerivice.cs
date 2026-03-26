using AppIterator.Models;

namespace AppIterator.Services
{
    public class ProdutoService
    {
        private List<Produto> produtos;

        public ProdutoService()
        {
            produtos = new List<Produto>
            {
                new Produto { Nome = "Mouse", Preco = 50 },
                new Produto { Nome = "Teclado", Preco = 120 },
                new Produto { Nome = "Monitor", Preco = 900 },
                new Produto { Nome = "fone", Preco = 25},
                new Produto { Nome = "pendrive", Preco = 75 },
                new Produto { Nome = "roteador", Preco = 150 }
            };
        }

        //Iterator (yield return)
        public IEnumerable<Produto> ObterProdutos()
        {
            foreach (var produto in produtos)
            {
                yield return produto; //AQUI ESTÁ O ITERATOR
            }
        }

        //Iterator com filtro
        public IEnumerable<Produto> ObterProdutosCaros(double minimo)
        {
            foreach (var produto in produtos)
            {
                if (produto.Preco >= minimo)
                    yield return produto; //ITERATOR + REGRA
            }
        }
    }
}