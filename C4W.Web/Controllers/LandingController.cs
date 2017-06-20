using C4W.Web.Common;
using C4W.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C4W.Web.Controllers
{
    public class LandingController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Landing
        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult ic() {
            ViewBag.Fecha = "AGOSTO 27";
            ViewBag.Ciudad = "BOGOTÁ";
            ViewBag.Pais = "COLOMBIA";
            return View();
        }

        public ActionResult coachingempresarialvida(string id)
        {
            ViewBag.Landing = "CERTIFICACIÓN INTERNACIONAL COACHING EMPRESARIAL Y DE VIDA";
            if (id == null)
            {
                id = "medellin-colombia";
            }
            switch (id)
            {
                case "medellin-colombia":
                    ViewBag.Fecha = "SEPTIEMBRE 17";
                    ViewBag.Ciudad = "MEDELLÍN";
                    ViewBag.Pais = "COLOMBIA";
                    break;
                case "bogota-colombia":
                    ViewBag.Fecha = "AGOSTO 19";
                    ViewBag.Ciudad = "BOGOTÁ";
                    ViewBag.Pais = "COLOMBIA";
                    break;
                case "lima-peru":
                    ViewBag.Fecha = "SEPTIEMBRE 10";
                    ViewBag.Ciudad = "LIMA";
                    ViewBag.Pais = "PERÚ";
                    break;
            }
            return View();
        }

        public ActionResult Actp(string id)
        {
            ViewBag.Landing = "CERTIFICACIÓN INTERNACIONAL COACHING EMPRESARIAL Y DE VIDA NIVEL PROFESIONAL";
            if (id == null)
            {
                id = "medellin-colombia";
            }
            switch(id)
            {
                case "medellin-colombia":
                    ViewBag.Fecha = "JUNIO 24";
                    ViewBag.Ciudad = "MEDELLÍN";
                    ViewBag.Pais = "COLOMBIA";
                    break;
                case "bogota-colombia":                    
                    ViewBag.Fecha = "AGOSTO 19";
                    ViewBag.Ciudad = "BOGOTÁ";
                    ViewBag.Pais = "COLOMBIA";
                    break;
                case "lima-peru":
                    ViewBag.Fecha = "JULIO 8";
                    ViewBag.Ciudad = "LIMA";
                    ViewBag.Pais = "PERÚ";
                    break;
            }
            return View();
        }


        [HttpPost]
        public ActionResult Send(ContactoLanding contacto)
        {
            string msg = 
                string.Format(
                    "{0} de {1} ({2}) se ha comunicado con Coaching for Wellness a través de la Landing {3}. <br/> Puedes contactarlo en {4} y su telefono es: {5}",
                    contacto.Nombre, contacto.Pais, contacto.Ciudad, contacto.Landing, contacto.Email, contacto.Telefono);
            string data = "Gracias por contactarnos. En breve nos comunicaremos con usted";
            int type = 0;
            try
            {
                Mailer.SendMail(Mailer.SENDER, msg);
            }
            catch (Exception e)
            {
                //data = "Uppss... ha ocurrido un error al enviar el correo, intentelo más tarde.";
                //type = 1;
            }

            db.ContactosLanding.Add(contacto);
            db.SaveChanges();

            return Json(new { data, type }, JsonRequestBehavior.AllowGet);
        }
    }
}