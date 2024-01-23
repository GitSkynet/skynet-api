using System.Net.Http.Headers;

namespace DataAccess.Factories
{
    public static class HttpClientFactory
    {
        private static readonly HttpClient client = new HttpClient();

        public static HttpClient ConfigClient()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.ConnectionClose = true;
            // client.DefaultRequestHeaders.Authorization = GetGoogleApiAuth();
            return client;
        }

        public static HttpClient ConfigClientGoogle()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.ConnectionClose = true;
            client.DefaultRequestHeaders.Authorization = GetGoogleApiAuth();
            return client;
        }

        // Private functions: Authenticate on Google Books API (TESTING)
        private static AuthenticationHeaderValue GetGoogleApiAuth()
        {
            var authenticationString = "admin:admin";
            var base64EncodedAuthenticationString = Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(authenticationString));
            return new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
        }
    }
}