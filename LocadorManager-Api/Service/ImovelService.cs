using LocadorManager_Api.Model.Imovel;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http;

namespace LocadorManager_Api.Service
{
    public class ImovelService : IImovelService
    {
        HttpClient _httpClient;
        IConfiguration _configuration;
        private string BasePath = "http://apps.superlogica.net/imobiliaria/api/imoveis";
        string _app_token = string.Empty;
        string _access_token = string.Empty;
        private HttpResponseMessage? httpResponse;
        HttpRequestMessage? request;
        StringContent content = new StringContent(string.Empty);

        public ImovelService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<Imovel> GetImovelById(int id)
        {
            HttpResponseMessage response;
            Imovel? imovel = new Imovel();

            try
            {
                StringContent content = new StringContent(string.Empty);

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                _app_token = _configuration.GetValue<string>("IntegrationTokens:app_token");
                _access_token = _configuration.GetValue<string>("IntegrationTokens:access_token");
                string pathParam = $"?id={id}";
                Uri uri = new Uri(BasePath + pathParam);
                using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, uri))
                {
                    request.Headers.Add("app_token", _app_token);
                    request.Headers.Add("access_token", _access_token);

                    response = await _httpClient.SendAsync(request);
                    var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Root? myDeserializedRootClass = JsonConvert.DeserializeObject<Root>(dataAsString);

                    if (response.IsSuccessStatusCode)
                    {
                        imovel = myDeserializedRootClass.data.FirstOrDefault();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return imovel;
        }
    }
}
