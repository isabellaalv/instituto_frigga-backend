using System.Collections.Generic;
using System.Threading.Tasks;
using Instituto_Frigga_Backend.Domains;

namespace Instituto_Frigga_Backend.Interfaces
{
    public interface IReceita
    {
        Task<List<Receita>> Listar();

        Task<Receita> BuscarPorId(int id);

        Task<Receita> Salvar(Receita receita);

        Task<Receita> Alterar(Receita receita);

        Task<Receita> Excluir(Receita receita);
    }
}