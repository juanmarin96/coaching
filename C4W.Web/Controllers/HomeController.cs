using C4W.Web.Common;
using C4W.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C4W.Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About(string section)
        {
            ViewBag.Section = section;
            return View();
        }


        public ActionResult Contact(int? e)
        {
            if (e == null)
                return View();

            var evento = db.Events.Find((int)e);

            Contacto c = new Contacto()
            {
                Comentario = "Me interesa '" + evento.Title + " " + evento.ShortDesc + "' que tendrá lugar en " + evento.Location + " los días " + evento.Days + " de " + evento.Month + "."
            };

            return View(c);
        }

        public ActionResult Agenda()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var eventos = db.Events.ToList();

            List<string> meses = new List<string>() { "enero", "febrero", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

            foreach (var evento in eventos) {
                int d;
                if (int.TryParse(evento.Days, out d))
                {
                    evento.DaysNro = d;
                }
                else
                {
                    evento.DaysNro = 12;
                }

                for (int i = 0; i < meses.Count; ++i) {
                    if (evento.Month.ToLower().Contains(meses[i]))
                    {
                        evento.MonthNro = i + 1;
                    }
                }

            }

            return View(eventos.OrderBy(e => e.MonthNro).ThenBy(e => e.DaysNro));
        }

        public ActionResult Pagos()
        {
            return View();
        }

        public ActionResult Personas()
        {
            return View();
        }

        public ActionResult Empresas()
        {
            return View();
        }

        public ActionResult Hacemos(string section)
        {
            ViewBag.Section = section;
            return View();
        }

        public ActionResult Pensamos()
        {
            return View();
        }

        public ActionResult Certificaciones(string section)
        {
            ViewBag.Section = section;
            return View();
        }

        public ActionResult PagosCCC() {
            return View();
        }

        public ActionResult PagosPayPal() {
            return View();
        }

        [HttpPost]
        public ActionResult Send(Contacto contacto)
        {
            string msg = string.Format("{0} de {1}-{2} se ha comunicado con Coaching for Wellness. <br/> Puedes contactarlo en {3} y {4}. <br/><br/> {5}", contacto.Nombre, contacto.Pais, contacto.Ciudad, contacto.Correo, contacto.Telefono, contacto.Comentario);
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

            db.Contactos.Add(contacto);
            db.SaveChanges();

            return Json(new { data, type }, JsonRequestBehavior.AllowGet);
        }
    }
}