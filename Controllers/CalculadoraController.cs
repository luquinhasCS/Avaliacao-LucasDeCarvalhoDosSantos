using Avaliacao_Lucas.Services;
using Microsoft.AspNetCore.Mvc;

namespace Avaliacao_Lucas.Controllers
{
    public class CalculadoraController : Controller
    {
        private readonly CalculadoraService _calculadoraService;

        public CalculadoraController()
        {
            _calculadoraService = new CalculadoraService();
        }

        [HttpGet]
        public IActionResult RealizarSoma(int a, int b)
        {
            int resultado = _calculadoraService.Somar(a, b);
            return Content($"<h1>O resultado da soma é: {resultado}</h1>", "text/html; charset=utf-8");
        }

        [HttpGet]
        public IActionResult RealizarSubtracao(int a, int b)
        {
            int resultado = _calculadoraService.Subtrair(a, b);
            return Content($"<h1>O resultado da subtração é: {resultado}</h1>", "text/html; charset=utf-8");
        }

        [HttpGet]
        public IActionResult RealizaMultiplicacao(int a, int b)
        {
            int resultado = _calculadoraService.Multiplicar(a, b);
            return Content($"<h1>O resultado da multiplicação é: {resultado}</h1>", "text/html; charset=utf-8");
        }

        [HttpGet]
        public IActionResult RealizaDivisao(int a, int b)
        {
            try
            {
                double resultado = _calculadoraService.Dividir(a, b);
                return Content($"<h1>O resultado da divisão é: {resultado}</h1>", "text/html; charset=utf-8");
            }
            catch (DivideByZeroException)
            {
                return Content("<h1>Erro: Divisão por zero não é permitida!</h1>", "text/html; charset=utf-8");
            }
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}