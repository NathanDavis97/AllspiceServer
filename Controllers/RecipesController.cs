using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Allspice.Models;
using Allspice.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Allspice.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class RecipesController : ControllerBase
  {
    private readonly RecipesService _rs;
    private readonly IngredientsService _ingredientsService;

    public RecipesController(RecipesService rs, IngredientsService ins)
    {
      _rs = rs;
      _ingredientsService = ins;
    }

    [HttpGet]
    public ActionResult<Recipe> Get()
    {
      try
      {
        return Ok(_rs.GetAll());
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}")]
    public ActionResult<Recipe> Get(int id)
    {
      try
      {
        return Ok(_rs.GetById(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet("{id}/ingredients")]
    public ActionResult<IEnumerable<Ingredient>> GetIngredients(int id)
    {
      try
      {
        IEnumerable<Ingredient> data = _ingredientsService.GetByRecipeId(id);
        return Ok(data);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPost]
    public ActionResult<Recipe> Create([FromBody] Recipe newRec)
    {
      try
      {
        return Ok(_rs.Create(newRec));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpPut("{id}")]
    public ActionResult<Recipe> Edit([FromBody] Recipe updated, int id)
    {
      try
      {
        updated.Id = id;
        return Ok(_rs.Edit(updated));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpDelete("{id}")]
    public ActionResult<Recipe> Delete(int id)
    {
      try
      {
        return Ok(_rs.Delete(id));
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }

  }
}