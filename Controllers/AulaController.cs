using ProjetoN2.DAO;
using ProjetoN2.Models;

namespace ProjetoN2.Controllers
{
    public class AulaController : SuperController<AulaViewModel>
    {
        public AulaController()
        {
            DAO = new AulaDAO();
        }

        protected override void ValidateModel(AulaViewModel model)
        {
            ModelState.Clear();

            if(((AulaDAO)DAO).materiaDAO.SelectById(model.MateriaId) == null)
            {
                ModelState.AddModelError("MateriaId", "Nenhuma matéria existe");
            }

            if(((AulaDAO)DAO).turmaDAO.SelectById(model.TurmaId) == null)
            {
                ModelState.AddModelError("TurmaId", "Nenhuma turma existe");
            }

            if(((AulaDAO)DAO).salaDAO.SelectById(model.SalaId) == null)
            {
                ModelState.AddModelError("SalaId", "Nenhuma sala existe");
            }
        }

        protected override void PrepareView()
        {
            ViewBag.Materias = ((AulaDAO)DAO).materiaDAO.SelectAll();
            ViewBag.Turmas = ((AulaDAO)DAO).turmaDAO.SelectAll();
            ViewBag.Salas = ((AulaDAO)DAO).salaDAO.SelectAll();
        }
    }
}