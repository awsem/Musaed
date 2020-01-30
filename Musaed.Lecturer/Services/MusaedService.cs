using Musaed.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

using System.Threading.Tasks;

namespace Musaed.Lecturer.Services
{
    public class MusaedService
    {
        private HttpClient _httpClient;

        public MusaedService()
        {
            var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback =
            HttpClientHandler.DangerousAcceptAnyServerCertificateValidator;

            _httpClient = new HttpClient(httpClientHandler);
            _httpClient.BaseAddress = new Uri("http://localhost:5000");
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            var responseMessage = await _httpClient.GetAsync("/api/courses/");
            var text = await responseMessage.Content.ReadAsStringAsync();
            var course = JsonConvert.DeserializeObject<IEnumerable<Course>>(text);
            return course;
        }


        public async Task AddCoursesAsync(Course course)
        {
            var json = JsonConvert.SerializeObject(course);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var responseMessage = await _httpClient.PostAsync("/api/courses/", data);
        }
    }
}
