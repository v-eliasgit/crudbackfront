using Crudtst.Models;


namespace Crudtst.Repositorio
{
    public interface IFornecedoresRepositorio
    {
        Fornecedores ListarPorId(int id);
        List<Fornecedores> BuscarTodos();
        Fornecedores Adicionar(Fornecedores fornecedores);
        Fornecedores Atualizar(Fornecedores fornecedores);
        bool Apagar(int id);
    }
}
