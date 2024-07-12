using LocadorManager_Api.Model.Proprietarios;
using Microsoft.AspNetCore.Mvc;

namespace LocadorManager_Api.Service
{
    public interface IProprietarioService
    {
        public Task<List<Proprietario>> GetAllProprietariosAsync();

        public Task<Proprietario> GetProprietarioByCpfCnpjAsync(string cpfCnpj);

        public Task<Proprietario> GetProprietarioByIdAsync(int cpfCnpj);
    }
}
