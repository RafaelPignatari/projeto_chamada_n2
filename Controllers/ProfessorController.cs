using Microsoft.AspNetCore.Mvc;
using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class ProfessorController : SuperController<ProfessorViewModel>
    {
        public ProfessorController()
        {
            DAO = new ProfessorDAO();
        }
        protected override void ValidateModel(ProfessorViewModel model)
        {
            ModelState.Clear();

            if(string.IsNullOrEmpty(model.Nome))
            {
                ModelState.AddModelError("Nome", "Nome não pode ser vazio.");
            }
        }
    }
}