using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorHomework.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CalculatorController : ControllerBase
{
    [HttpGet("GetNumberSum")]
    public IActionResult GetNumberSum(int a, int b)
    {
        int sum = a + b;
        return Ok(sum);
    }

    [HttpGet("GetNumberMinus")]
    public IActionResult GetNumberMinus(int a, int b)
    {
        int difference = a - b;
        return Ok(difference);
    }

    [HttpGet("GetNumberMultiply")]
    public IActionResult GetNumberMultiply(int a, int b)
    {
        int product = a * b;
        return Ok(product);
    }
    [HttpGet("GetNumberDivide")]
    public IActionResult GetNumberDivide(int a, int b)
    {
        if (b == 0)
        {
            return BadRequest("Ar Sheidzleba nulze gayofa...");
        }
        double quotient = (double)a / b;
        return Ok(quotient);
    }

    [HttpGet("GetNumberModulo")]
    public IActionResult GetNumberModulo(int a, int b)
    {
        if (b == 0)
        {
            return BadRequest("Ar sheidzleba nulze gayofa...");
        }

        int remainder = a % b;
        return Ok(remainder);
    }
}
