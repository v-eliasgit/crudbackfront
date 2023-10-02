using Crudtst.Models;
using Crudtst.Database;


namespace Crudtst.Repositorio
{
    public class FornecedoresRepositorio : IFornecedoresRepositorio
    {
        private readonly FornecedoresContext _fornecedoresContext;

        public FornecedoresRepositorio(FornecedoresContext fornecedoresContext)
        {
            this._fornecedoresContext = fornecedoresContext;
        }

        public Fornecedores ListarPorId(int id)
        {
            return _fornecedoresContext.Fornecedores.FirstOrDefault(x => x.Id == id);
        }

        public List<Fornecedores> BuscarTodos()
        {
            return _fornecedoresContext.Fornecedores.ToList();
        }

        public Fornecedores Adicionar(Fornecedores fornecedores)
        {
            _fornecedoresContext.Add(fornecedores);
            _fornecedoresContext.SaveChanges();

            return fornecedores;
        }

        public Fornecedores Atualizar(Fornecedores fornecedores)
        {
            Fornecedores fornecedoresDB = ListarPorId(fornecedores.Id);

            if (fornecedoresDB == null) throw new System.Exception("Houve um erro na atualização do contato");

            fornecedoresDB.Nome = fornecedores.Nome;
            fornecedoresDB.Cnpj = fornecedores.Cnpj;
            fornecedoresDB.Especialidade = fornecedores.Especialidade;

            _fornecedoresContext.Fornecedores.Update(fornecedoresDB);
            _fornecedoresContext.SaveChanges();

            return fornecedoresDB;
        }

        public bool Apagar(int id)
        {
            Fornecedores fornecedoresDB = ListarPorId(id);

            if (fornecedoresDB == null) throw new System.Exception("Houve um erro ao apagar o contato!");

            _fornecedoresContext.Fornecedores.Remove(fornecedoresDB);
            _fornecedoresContext.SaveChanges(true);

            return true;
        }
    }
}
