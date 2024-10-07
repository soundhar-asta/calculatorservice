using Microsoft.AspNetCore.Mvc;
using CalculatorWebApi.Interfaces; // Ensure correct namespace for ICalculatorService

namespace CalculatorWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<int> _calculatorService;

        public CalculatorController(ICalculatorService<int> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public int Add(int a, int b) => _calculatorService.Add(a, b);

        [HttpGet("subtract")]
        public int Subtract(int a, int b) => _calculatorService.Subtract(a, b);

        [HttpGet("multiply")]
        public int Multiply(int a, int b) => _calculatorService.Multiply(a, b);

        [HttpGet("divide")]
        public int Divide(int a, int b) => _calculatorService.Divide(a, b);
    }
}
