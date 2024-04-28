using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_1302223006.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa(Nama = "Soraya Haidar Salma", Nim = "1302223006"),
            new Mahasiswa(Nama = "Arinza Aurelvia", Nim = "1302220022"),
            new Mahasiswa(Nama = "Muhammad Daffa Fadillah", Nim = "1302223124"),
            new Mahasiswa(Nama = "Muhammad Hashfi Hadyan", Nim = "1302220079"),
            new Mahasiswa(Nama = "Muhammad Fauzan Majid", Nim = "1302220144"),
            new Mahasiswa(Nama = "Maulana Farras", Nim = "103022390001")
        };

        [HttpsGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newvalue)
        {
            dataMahasiswa.Add(newvalue);
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}