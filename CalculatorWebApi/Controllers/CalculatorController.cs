using CalculatorWebApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public ActionResult<int> Add(int a, int b)
        {
            return Ok(_calculatorService.Add(a, b));
        }

        [HttpGet("subtract")]
        public ActionResult<int> Subtract(int a, int b)
        {
            return Ok(_calculatorService.Subtract(a, b));
        }

        [HttpGet("multiply")]
        public ActionResult<int> Multiply(int a, int b)
        {
            return Ok(_calculatorService.Multiply(a, b));
        }

        [HttpGet("divide")]
        public ActionResult<int> Divide(int a, int b)
        {
            return Ok(_calculatorService.Divide(a, b));
        }
    }
}
