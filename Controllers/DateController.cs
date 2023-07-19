using System.Globalization;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using TimeMicroservice.Models;

namespace TimeMicroservice.Controllers;
    [ApiController]
    [Route("[controller]")]
    public class DateController:ControllerBase{
        public DateController(){}

        [HttpGet]
        public ActionResult<DateTime> GetNewDateFormat(string? date){
            /*.NET interpreta los parámetros del controlador como requeridos
                para poder específicar que un parámetro es opcional debes indicar
                al compilador que puede aceptar valores nulos, esto se puede
                hacer agregando un signo ? al tipo de la primitiva*/
                DateModel dateModel = new DateModel("DateTime.Now","1204203421");
                string nuevaFecha;
                string newUnixDate;
            if(date is null){
                nuevaFecha = DateTime.Now.ToUniversalTime().Date.ToString();
                newUnixDate =  DateTime.Parse(nuevaFecha).Subtract(new DateTime(1970, 1, 1)).TotalMilliseconds.ToString();
                dateModel= new DateModel(nuevaFecha,newUnixDate);
                return Ok(dateModel);
            }
                 nuevaFecha = DateTime.ParseExact(date.Trim(),"yyyy-dd-mm",null).ToUniversalTime().Date.ToString();
                 newUnixDate = DateTime.Parse(nuevaFecha).Subtract(new DateTime(1970, 1,1)).TotalMilliseconds.ToString();
                dateModel= new DateModel(nuevaFecha,newUnixDate);
                return Ok(dateModel);
            }

       
            
        }
        
