using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        IEnumerable<Leilao> BuscaLeiloes();
        IEnumerable<Categoria> BuscarCategorias();
        Leilao BuscarLeilaoPorId(int id);
        void Alterar(Leilao model);

        void Excluir(Leilao leilao);

        void Adicionar(Leilao leilao);
    }
}
