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
        public ActionResult Es()
        {
            Session["lang"] = "es";
            return RedirectToAction("Index");
        }
        public ActionResult En()
        {
            Session["lang"] = "en";
            return RedirectToAction("Index");
        }

        public ActionResult About(string section)
        {
            ViewBag.Section = section;
            return View();
        }


        public ActionResult Contact(int? e)
        {
            var lang = Session["lang"];

            //texto en el idioma ingles
            if (lang != null && lang.ToString() == "en")
            {
                //footer
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables del navbar
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contact_link"] = "CONTACT US";
                //variables de contacto
                ViewData["t1C"] = "CONTACT US";
                ViewData["t2C"] = "NAME";
                ViewData["t3C"] = "COUNTRY";
                ViewData["t4C"] = "CITY";
                ViewData["t5C"] = "E-MAIL";
                ViewData["t6C"] = "TELEPHONE";
                ViewData["t7C"] = "COMMENTS";
                ViewData["t8C"] = "SUBMIT";
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";

                //variables de contacto
                ViewData["t1C"] = "CONTÁCTANOS";
                ViewData["t2C"] = "NOMBRE";
                ViewData["t3C"] = "PAÍS";
                ViewData["t4C"] = "CIUDAD";
                ViewData["t5C"] = "E-MAIL";
                ViewData["t6C"] = "TELEPHONE";
                ViewData["t7C"] = "COMENTARIO";
                ViewData["t8C"] = "ENVIAR";
            }
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
            var lang = Session["lang"];

            //texto en el idioma ingles
            if (lang != null && lang.ToString() == "en")
            {
                //footer
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables del navbar
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contact_link"] = "CONTACT US";
                //variables de personas
                ViewData["t1Cer"] = "CERTIFICATION PROGRAMS";
                ViewData["t2Cer"] = "COACHING";
                ViewData["t3Cer"] = "All professional preparation in the development of Coaching competencies, its integration and implementation begins with the life aspect. This program teaches all the coaching skills from the perspective of Life Coaching, an aspect of great relevance in the training of an Executive and Corporate Coach.";
                ViewData["t4Cer"] = "OUR CERTIFICATION PROGRAMS";
                ViewData["t5Cer"] = "Offer two levels of certification, each one fulfilling the ICF requirements for that specific level.";
                ViewData["t6Cer"] = "PROFESSIONAL LEVEL COACHING";
                ViewData["t7Cer"] = "BUSINESS AND LIFE COACHING";
                ViewData["t8Cer"] = "PROFESSIONAL LEVEL";
                ViewData["t9Cer"] = "ASSOCIATE LEVEL COACHING";
                ViewData["t10Cer"] = "PROFESSIONAL LEVEL";
                ViewData["t11Cer"] = "LIFE AND WELLNESS COACHING";
                ViewData["t12Cer"] = "LIFE AND SPIRITUAL COACHING";
                ViewData["t13Cer"] = "OASIS BREATHING TECHNIQUE";
                //helper de presonas
                ViewData["t14Cer"] = "OASIS BREATHING TECHNIQUE";
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";

                //variables de personas
                ViewData["t1Cer"] = "PROGRAMAS DE CERTIFICACIÓN";
                ViewData["t2Cer"] = "COACHING";
                ViewData["t3Cer"] = "Toda preparación profesional en el desarrollo de las competencias de coaching, su integración y su aplicación, comienza por el área de vida.Este programa enseña todas las destrezas de coaching desde un punto de vista del coaching de vida, aspecto de gran pertinencia en la formación de un coach ejecutivo y corporativo.";
                ViewData["t4Cer"] = "NUESTROS PROGRAMAS CERTIFICADOS";
                ViewData["t5Cer"] = "Ofrecen dos niveles de certificación que cumplen a cabalidad con los requerimientos de la ICF para cada nivel de credencial.";
                ViewData["t6Cer"] = "COACHING NIVEL PROFESIONAL";
                ViewData["t7Cer"] = "COACH EMPRESARIAL  Y DE VIDA";
                ViewData["t8Cer"] = "NIVEL PROFESIONAL";
                ViewData["t9Cer"] = "COACHING NIVEL ASOCIADO";
                ViewData["t10Cer"] = "NIVEL PROFESIONAL";
                ViewData["t11Cer"] = "COACHING DE VIDA Y BIENESTAR";
                ViewData["t12Cer"] = "COACHING DE VIDA Y ESPIRITUAL";
                ViewData["t13Cer"] = "TÉCNICA DE RESPIRACIÓN OASIS";
                //helper de personas
                ViewData["t14Cer"] = "OASIS BREATHING TECHNIQUE";
            }
            return View();
        }

        public ActionResult Servicios()
        {
            var lang = Session["lang"];

            //texto en el idioma ingles
            if (lang != null && lang.ToString() == "en")
            {
                //footer
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables del navbar
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contact_link"] = "CONTACT US";
                //variables de servicios
                ViewData["t1Ser"] = "SERVICES";
                ViewData["t2Ser"] = "ONE-ON-ONE COACHING";
                ViewData["t3Ser"] = "We offer individual services in";
                ViewData["t4Ser"] = "Life Coaching";
                ViewData["t5Ser"] = "Executive and Business Coaching(e.g., teams, sales)";
                ViewData["t6Ser"] = "Relationship Coaching";
                ViewData["t7Ser"] = "Wellness Coaching";
                ViewData["t8Ser"] = "Spiritual Coaching";
                ViewData["t9Ser"] = "Contact us for additional information regarding our services.";
                ViewData["t10Ser"] = "WEBINARS";
                ViewData["t11Ser"] = "We offer online seminars about diverse topics, geared towards:";
                ViewData["t12Ser"] = "People interested in learning more about coaching and being coached";
                ViewData["t13Ser"] = "People interested in becoming certified coaches";
                ViewData["t14Ser"] = "Certified coaches";
                ViewData["t15Ser"] = "General public";
                ViewData["t16Ser"] = "Contact us for additional information regarding our webinars.";
                ViewData["t17Ser"] = "MENTORING FOR COACHES";
                ViewData["t18Ser"] = "Geared toward coaches seeking to improve their coaching skills, or coaches interested in complying with the mentoring requirements for ICF credentials.";
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTACT US";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";
                //variables de servicios
                ViewData["t1Ser"] = "SERVICIOS";
                ViewData["t2Ser"] = "COACHING INDIVIDUAL";
                ViewData["t3Ser"] = "Ofrecemos servicios individualizados de coaching:";
                ViewData["t4Ser"] = "Coaching de vida";
                ViewData["t5Ser"] = "Coaching ejecutivo y de negocios (Ej., equipos, ventas)";
                ViewData["t6Ser"] = "Coaching de relaciones";
                ViewData["t7Ser"] = "Coaching de bienestar";
                ViewData["t8Ser"] = "Coaching espiritual";
                ViewData["t9Ser"] = "Contáctenos para información adicional sobre nuestros servicios.";
                ViewData["t10Ser"] = "CHARLAS EN LÍNEA";
                ViewData["t11Ser"] = "Ofrecemos charlas virtuales (webinars) sobre diversos temas para:";
                ViewData["t12Ser"] = "Interesados en conocer más información sobre coaching y/o recibir servicios de coaching";
                ViewData["t13Ser"] = "Interesados en formarse como coaches";
                ViewData["t14Ser"] = "Coaches certificados";
                ViewData["t15Ser"] = "Público en general";
                ViewData["t16Ser"] = "Contáctenos para información adicional sobre nuestras charlas y otros eventos.";
                ViewData["t17Ser"] = "MENTORIAS PARA COACHES";
                ViewData["t18Ser"] = "Ofrecemos servicios individualizados y grupales de mentoría en coaching dirigidos a coaches en formación y/o certificados que deseen mejorar sus destrezas de coaching, o para coaches interesados en cumplir con el requisito de mentorías  que les permita solicitar credenciales ante la ICF. Contáctenos para información adicional sobre nuestros programa";
            }
            
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