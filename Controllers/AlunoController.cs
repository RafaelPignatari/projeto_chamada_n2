using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class AlunoController : SuperController<AlunoViewModel>
    {
        public AlunoController()
        {
            DAO = new AlunoDAO();
        }

        protected override void ValidateModel(AlunoViewModel model)
        {
            ModelState.Clear();

            if(string.IsNullOrEmpty(model.Nome))
            {
                ModelState.AddModelError("Nome", "Nome não pode ser vazio.");
            }

            if(((AlunoDAO)DAO).turmaDAO.SelectById(model.TurmaId) == null)
            {
                ModelState.AddModelError("TurmaId", "Nenhuma turma existe.");
            }
        }

        protected override void PrepareView()
        {
            ViewBag.Turmas = ((AlunoDAO)DAO).turmaDAO.SelectAll();
        }
    }
}