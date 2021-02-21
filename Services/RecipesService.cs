using System;
using System.Collections.Generic;
using Allspice.Models;
using Allspice.Repositories;

namespace Allspice.Services
{
  public class RecipesService
  {
    private readonly RecipesRepository _repo;

    public RecipesService(RecipesRepository repo)
    {
      _repo = repo;
    }

    internal IEnumerable<Recipe> GetAll()
    {
      return _repo.GetAll();
    }

    internal Recipe GetById(int id)
    {
      var data = _repo.GetById(id);
      if (data == null)
      {
        throw new Exception("Invalid Id");
      }
      return data;
    }

    internal Recipe Create(Recipe newRec)
    {
      return _repo.Create(newRec);
    }

    internal Recipe Edit(Recipe updated)
    {
      var data = GetById(updated.Id);
      updated.Description = updated.Description != null ? updated.Description : data.Description;
      updated.Title = updated.Title != null && updated.Title.Length > 2 ? updated.Title : data.Title;
      updated.ImgUrl = updated.ImgUrl != null ? updated.ImgUrl : data.ImgUrl;
      return _repo.Edit(updated);
    }
    internal string Delete(int id)
    {
      var data = GetById(id);
      _repo.Delete(id);
      return "Deleted";
    }
  }
}