using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestASPNET.Controllers {
    [ApiController]
    [Route("[controller]")]
public class CalculatorController : ControllerBase
{
    

    private readonly ILogger<CalculatorController> _logger;

        

        public CalculatorController(ILogger<CalculatorController> logger)
    {
        _logger = logger;
    }

    [HttpGet("sum/{firstNumber}/{secondNumber}")]
    public IActionResult Get(string firstNumber,string secondNumber)
    {
            if (IsNumeric(firstNumber)&& IsNumeric(secondNumber))  
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return Ok(sum.ToString());
            }
            return BadRequest("invalid input");
    }
    private bool IsNumeric(string firstNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber,System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo,out number);
            return isNumber;
                       

        }
    private int ConvertToDecimal(string firstNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue)) { 
                return (int)decimalValue;
            }
            return 0;
        }

    
  

}
}