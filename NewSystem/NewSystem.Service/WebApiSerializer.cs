using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;

namespace NewSystem.Service
{
    public static class WebApiSerializer
    {

        private static string usuarioApi = "afb4ef2a22772683154310e66baf3080";
        private static string senhaApi = "d52a3229fb63845bb63b7f55acb981c4";

        public static object HttpPost<T>(T objeto, string uri, string metodo)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{usuarioApi}:{senhaApi}")));
                    client.Timeout = new TimeSpan(0, 30, 0);

                    HttpResponseMessage result = client.PostAsJsonAsync(metodo, objeto).Result;
                    if (result.IsSuccessStatusCode)
                        return result.Content.ReadAsStringAsync().Result;
                    else
                        return null;
                }
            }
            catch
            {
                return default(T);
            }
        }

        public static U HttpPost<T, U>(T objeto, string uri, string metodo)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{usuarioApi}:{senhaApi}")));
                    client.Timeout = new TimeSpan(0, 30, 0);

                    HttpResponseMessage result = client.PostAsJsonAsync(metodo, objeto).Result;
                    if (result.IsSuccessStatusCode)
                        return result.Content.ReadFromJsonAsync<U>().Result;
                    else
                        return default(U);
                }
            }
            catch
            {
                return default(U);
            }
        }

        public static T HttpGet<T>(string uri, string metodo)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(uri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    client.DefaultRequestHeaders.Add("Authorization", "Basic " + Convert.ToBase64String(Encoding.UTF8.GetBytes($"{usuarioApi}:{senhaApi}")));
                    client.Timeout = new TimeSpan(0, 30, 0);

                    HttpResponseMessage response = client.GetAsync(metodo).Result;
                    if (response.IsSuccessStatusCode)
                        return response.Content.ReadFromJsonAsync<T>().Result;
                    else
                        return default(T);
                }
            }
            catch (Exception ex)
            {
                var mensagem = ex.Message;
                return default(T);

            }
        }

    }

}

