using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class MateriaController : SuperController<MateriaViewModel>
    {
        public MateriaController()
        {
            DAO = new MateriaDAO();
        }

        protected override void ValidateModel(MateriaViewModel model)
        {
            ModelState.Clear();

            if(string.IsNullOrEmpty(model.Nome))
            {
                ModelState.AddModelError("Nome", "Nome não pode ser vazio.");
            }

            if(((MateriaDAO)DAO).professorDAO.SelectById(model.ProfessorId) == null)
            {
                ModelState.AddModelError("ProfessorId", "Nenhum professor existe.");
            }

            if(((MateriaDAO)DAO).cursoDAO.SelectById(model.CursoId) == null)
            {
                ModelState.AddModelError("CursoId", "Nenhum curso existe.");
            }
        }

        protected override void PrepareView()
        {
            ViewBag.Professores = ((MateriaDAO)DAO).professorDAO.SelectAll();
            ViewBag.Cursos = ((MateriaDAO)DAO).cursoDAO.SelectAll();
        }
    }
}