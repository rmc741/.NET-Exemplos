using CsvHelper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace UploadArquivoExemplo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {

        [HttpPost]
        public async Task<List<DadosTablet>> TesteUploadArquivoBanco(IFormFile file)
        {
            using (var reader = new StreamReader(file.OpenReadStream()))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<DadosTablet>();
                //Console.WriteLine(records.ToList().ToString());
                return records.ToList();
            }
        }
    }
}
