using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022330150;

namespace tpmodul10_NIM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>
        {
            new Mahasiswa("Muhammad Ihsan Romdhon", "103022330150"),
            new Mahasiswa("Muhammad Endihan Alfatah Nasution", "103022300064"),
            new Mahasiswa("Mohammad Ilham Firdaus", "103022300043"),
            new Mahasiswa("Muthi'ah Az Zahra", "103022330117"),
            new Mahasiswa("Triana Julianingsih", "103022300053"),
            new Mahasiswa("Syahdan Mansiz Kurniawan", "103022300079")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{index}")]
        public Mahasiswa Get(int index)
        {
            return mahasiswaList[index];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            mahasiswaList.Add(mhs);
        }

        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            mahasiswaList.RemoveAt(index);
        }
    }
}
