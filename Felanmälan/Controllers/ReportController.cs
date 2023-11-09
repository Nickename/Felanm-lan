using ErrorReport.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ErrorReport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly FelanmälanWebApiContext _context;

        public ReportController(FelanmälanWebApiContext context)
        {
            _context = context;
        }

        // GET: api/<FelanmälanController>
        [HttpGet]
        public IEnumerable<Report> GetAll()
        {      
            return _context.Felanmälningar.ToList();
        }

        // GET api/<FelanmälanController>/5
        [HttpGet("{id}")]
        public Report Get(int id)
        {
            var felanmälan = _context.Felanmälningar.Find(id);
            return felanmälan;
        }

        // POST api/<FelanmälanController>
        [HttpPost]
        public void Post([FromBody] Report report)
        {
            _context.Felanmälningar.Add(report);
            _context.SaveChanges();
        }

        // PUT api/<FelanmälanController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FelanmälanController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var felanmälan = _context.Felanmälningar.Find(id);
            _context.Felanmälningar.Remove(felanmälan);
            _context.SaveChanges();
        }
    }
}
