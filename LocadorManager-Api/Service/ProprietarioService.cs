using LocadorManager_Api.Model.Proprietarios;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace LocadorManager_Api.Service
{
    public class ProprietarioService : IProprietarioService
    {
        HttpClient _httpClient;
        IConfiguration _configuration;
        private string BasePath = "http://apps.superlogica.net/imobiliaria/api/proprietarios";
        string _app_token = string.Empty;
        string _access_token = string.Empty;
        private HttpResponseMessage? httpResponse;
        HttpRequestMessage? request;
        StringContent content = new StringContent(string.Empty);

        public ProprietarioService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
            string _add = null;
        }
        public async Task<List<Proprietario>> GetAllProprietariosAsync()
        {
            int counter = 1;
            HttpResponseMessage response;
            List<Proprietario> proprietarios = new List<Proprietario>();

            while (true)
            {
                try
                {
                    request = new HttpRequestMessage(HttpMethod.Get, BasePath);
                    _app_token = _configuration.GetValue<string>("IntegrationTokens:app_token");
                    _access_token = _configuration.GetValue<string>("IntegrationTokens:access_token");

                    request.Headers.Add("app_token", _app_token);
                    request.Headers.Add("access_token", _access_token);
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    request.Content = content;

                    request.RequestUri = new Uri(BasePath + "?pagina=" + counter);
                    response = await _httpClient.SendAsync(request);
                    var dataAsString = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    Model.Proprietarios.Root? myDeserializedRootClass = JsonConvert.DeserializeObject<Model.Proprietarios.Root>(dataAsString);

                    if (response.IsSuccessStatusCode)
                    { 
                        if (myDeserializedRootClass == null || myDeserializedRootClass.data.Count <= 0)
                        {
                            break;
                        }
                        foreach (var item in myDeserializedRootClass.data)
                        {
                            proprietarios.Add(item);
                        }
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            List<Proprietario> lista = proprietarios.OrderBy(p => p.st_nome_pes).ToList();

            return lista;
        }

        public async Task<Proprietario> GetProprietarioByCpfCnpjAsync(string cpfCnpj)
        {
            HttpResponseMessage response;
            Proprietario? proprietario = new Proprietario();

            try
            {
                StringContent content = new StringContent(string.Empty);

                content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");
                _app_token = _configuration.GetValue<string>("IntegrationTokens:app_token");
                _access_token = _configuration.GetValue<string>("IntegrationTokens:access_token");
                string pathParam = $"?cpfCnpj={cpfCnpj}";
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
                        proprietario = myDeserializedRootClass.data.FirstOrDefault();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return proprietario;
        }

        public async Task<Proprietario> GetProprietarioByIdAsync(int id)
        {
            HttpResponseMessage response;
            Proprietario? proprietario = new Proprietario();

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
                        proprietario = myDeserializedRootClass.data.FirstOrDefault();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return proprietario;
        }
    }
}