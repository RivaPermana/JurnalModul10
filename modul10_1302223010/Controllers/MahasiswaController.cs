using Microsoft.AspNetCore.Mvc;

namespace modul10_1302223010.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController
    {

        private static List<string> Course = new()
        {
            "KPL", "BD", "PBO"
        };
        private static List<Mahasiswa> mhs = new List<Mahasiswa>()
        {
            new Mahasiswa("Riva Dwi Fadhillah Fajri Permana", "1302223010", Course, 2022),
            new Mahasiswa("Cokorda Arturito Revan Putra Diarta", "1302223057", Course, 2022),
            new Mahasiswa("Rd. M. Faisal Ramadhan Junaidi", "1302220093", Course, 2022)
        };

        private readonly ILogger<WeatherForecastController> _logger;

        [HttpGet(Name = "GetMahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mhs;
        }

        [HttpPost]
        public void post([FromBody] Mahasiswa mahasiswa)
        {
            mhs.Add(mahasiswa);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mhs[id];
        }

        [HttpDelete("{id}")]
        public void delete(int id)
        {
            mhs.RemoveAt(id);
        }
    }
}
