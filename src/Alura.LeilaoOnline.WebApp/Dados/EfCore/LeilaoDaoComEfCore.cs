using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDaoComEfCore:ILeilaoDao
    {
        public AppDbContext _context;

        public LeilaoDaoComEfCore(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Leilao> BuscaLeiloes()
        {
            return _context.Leiloes
                .Include(l => l.Categoria)
                .ToList();
        }
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias;
        }
        public Leilao BuscarLeilaoPorId(int id)
        {
            return _context.Leiloes.FirstOrDefault(i => i.Id == id);
        }
        public void Alterar(Leilao model)
        {
            _context.Leiloes.Update(model);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

        public void Adicionar(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }
    }
}
