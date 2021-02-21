using System;
using System.Collections.Generic;
using Allspice.Models;
using Allspice.Repositories;

namespace Allspice.Services
{
  public class IngredientsService
  {
    private readonly IngredientsRepository _repo;

    public IngredientsService(IngredientsRepository repo)
    {
      _repo = repo;
    }

    internal Ingredient GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return data;
    }

    internal IEnumerable<Ingredient> GetByRecipeId(int id)
    {
      IEnumerable<Ingredient> data = _repo.GetByRecipeId(id);
      return data;
    }


    internal Ingredient Create(Ingredient newIng)
    {
      return _repo.Create(newIng);
    }

    internal Ingredient Edit(Ingredient updated)
    {
      var data = GetById(updated.Id);
      updated.Title = updated.Title != null ? updated.Title : data.Title;
      updated.Quantity = updated.Quantity != 0 ? updated.Quantity : data.Quantity;
      return _repo.Edit(updated);
    }
    internal string Delete(int id)
    {
      GetById(id);
      _repo.Delete(id);
      return "Deleted";
    }
  }
}