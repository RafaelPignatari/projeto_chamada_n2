using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class CursoController : SuperController<CursoViewModel>
    {
        public CursoController()
        {
            DAO = new CursoDAO();
        }
        protected override void ValidateModel(CursoViewModel model)
        {
            ModelState.Clear();

            if(string.IsNullOrEmpty(model.Nome))
            {
                ModelState.AddModelError("Nome", "Nome não pode ser vazio.");
            }
        }
    }
}