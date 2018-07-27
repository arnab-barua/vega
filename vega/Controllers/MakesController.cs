using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistance;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext db;
        private readonly IMapper mapper;

        public MakesController(VegaDbContext context, IMapper mapper)
        {
            this.db = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/make")]
        public async Task<ICollection<MakeResource>> GetMakesAsync()
        {
            var makes = await db.Makes.Include(m => m.Model).ToListAsync();
            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}