using LocadorManager_Api.Model.Imovel;

namespace LocadorManager_Api.Service
{
    public interface IImovelService
    {
        public Task<Imovel> GetImovelById(int id);
    }
}
