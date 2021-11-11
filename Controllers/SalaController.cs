using Microsoft.AspNetCore.Mvc;
using ProjetoN2.DAO;
using ProjetoN2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoN2.Controllers
{
    public class SalaController : SuperController<SalaViewModel>
    {
        public SalaController()
        {
            DAO = new SalaDAO();
        }
        protected override void ValidateModel(SalaViewModel model)
        {
            ModelState.Clear();

            if (model.Capacidade < 5)
            {
                ModelState.AddModelError("Capacidade", "Capacidade não pode ser menor que 5.");
            }
        }
    }
}
