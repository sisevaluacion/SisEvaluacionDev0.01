using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPlantilla.Controllers
{
    public class HomeController : Controller
    {
        BDSisEvaluacionDataContext oBD = new BDSisEvaluacionDataContext();
        public ActionResult Index()
        {
            ViewBag.Message = "En esta seccion se da la bienvenida al usuario y se crean los atajos principales de cada modulo.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Página de contacto.";

            return View();
        }


        public ActionResult Evaluacion()
        {
            ViewBag.Mensaje = "Este modulo pertenece al Sistema de evaluacion para los alumnos de la UAC";
            return View();
        }
        public ActionResult RegistrarDocente()
        {
            ViewBag.Mensaje = "Este modulo pertenece al Docente";
            return View();
        }
        public ActionResult ListarDocente()
        {
            var Consulta = from C in oBD.uspListarDocente() select C;
            return View(Consulta);
            
        }
        public ActionResult RegistrarAlumno()
        {
            ViewBag.Mensaje = "Este modulo pertenece al Alumno";
            return View();
        }
        public ActionResult ListarAlumno()
        {
            var Consulta = from C in oBD.uspListarAlumno() select C;
            return View(Consulta);

        }
        public ActionResult RegistrarAsignatura()
        {
            ViewBag.Mensaje = "Este modulo pertenece a la Asignatura";
            return View();
        }
        public ActionResult ListarAsignatura()
        {
            var Consulta = from C in oBD.uspListarAsignatura() select C;
            return View(Consulta);

        }
        public ActionResult AsignarCargaAcademica()
        {
            ViewBag.Mensaje = "Este modulo pertenece a la Asignación de Asignaturas";
            return View();
        }
        public ActionResult ListarCargaAcademica()
        {
            var Consulta = from C in oBD.uspListarCargaAcademica() select C;
            return View(Consulta);

        }
        public ActionResult ElaborarTema()
        {
            ViewBag.Mensaje = "Este modulo pertenece a la Asignación de Asignaturas";
            return View();
        }
        public ActionResult ListarElaborarTema()
        {
            var Consulta = from C in oBD.uspListarElaborarTema() select C;
            return View(Consulta);

        }
        public ActionResult ElaborarPregunta()
        {
            ViewBag.Mensaje = "Este modulo pertenece a la Asignación de Asignaturas";
            return View();
        }
        public ActionResult ListarElaborarPregunta()
        {
            var Consulta = from C in oBD.uspListarElaborarPregunta() select C;
            return View(Consulta);

        }
        //public ActionResult Create(int? id) // id is the selected agent
        //{
        //    var agqry = db.partener.Where(p => p.part_type == 1).Where(p => p.activ == true);
        //    var cltqry = db.partener.Where(p => p.part_type == 2).Where(p => p.activ == true);
        //    List<SelectListItem> idagenti = new List<SelectListItem>();
        //    foreach (partener ag in agqry)
        //    {
        //        idagenti.Add(new SelectListItem { Text = ag.den_parten, Value = ag.id_parten.ToString() });
        //    }
        //    if (id != null)
        //    {
        //        cltqry = cltqry.Where(p => p.par_parten == id);
        //    }
        //    ViewData["idagenti"] = idagenti;
        //    ViewBag.id_parten = new SelectList(cltqry, "id_parten", "den_parten");//
        //}
        // GET: /Movies/Create

       
    }
}
