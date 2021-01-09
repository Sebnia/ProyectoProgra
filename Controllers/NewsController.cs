using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProyectoProgra.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace ProyectoProgra.Controllers
{
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private const string URL_API_NEWS = "https://newslit-news-search.p.rapidapi.com/news";
        private const string ACCESS_TOKEN = "8fd18d7b43msh9ab7057845cfc03p1286adjsna1138b29338f";

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        

    }
}