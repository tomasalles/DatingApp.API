using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ValuesController : ControllerBase
  {
    private readonly DataContext Context;

    public ValuesController(DataContext context)
    {
      Context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetValues()
    {
      var values = await Context.Values.ToListAsync();

      return Ok(values);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetValue(int id)
    {
      var value = await Context.Values.FirstOrDefaultAsync(x => x.Id == id);

      return Ok(value);
    }

    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
