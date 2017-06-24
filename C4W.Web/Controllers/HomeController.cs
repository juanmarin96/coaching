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
            var lang = Session["lang"];
            
            //texto en el idioma ingles
            if(lang!= null && lang.ToString() == "en")
            {

                ViewData["bannerMoodle_index1"] = "SIGN-IN TO OUR";
                ViewData["bannerMoodle_index2"] = "VIRTUAL CAMPUS";
                ViewData["pagosOnline_index"] = "ONLINE PAYMENTS";
                ViewData["mandalas1"] = "DOWNLOAD YOUR";
                ViewData["mandalas2"] = " MANDALA COLORING BOOK";
                ViewData["contactanos_index"] = "CONTACT US";
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";
                

                //navbar links
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contact_link"] = "CONTACT US";

            }
            //texto en el idioma español
            else
            {

                ViewData["bannerMoodle_index1"] = "INGRESA AQUÍ AL";
                ViewData["bannerMoodle_index2"] = "CAMPUS VIRTUAL";
                ViewData["pagosOnline_index"] = "PAGOS EN LÍNEA";
                ViewData["mandalas1"] = "DESCARGA TU LIBRO DE";
                ViewData["mandalas2"] = "MANDALAS PARA COLOREAR";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["T1_sobre1"] = "QUIÉNES";
                ViewData["T1_sobre2"] = "SOMOS";

                //navbas links
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";

            }
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
            var lang = Session["lang"];

            //texto en el idioma ingles
            if (lang != null && lang.ToString() == "en")
            {
                ViewData["p1_sobre"] = "An organization that promotes wellness in all aspects of life. Coaching for Wellness (CFW) was co-created in 2004 by Susan Seidman and Annie Torres, both certified as Master Coaches (MCC) and pioneers in the coaching profession in the United States, Puerto Rico, and Latin America. We are passionate about what we do. We strive to make continuous improvement something real, which allows us to be highly differentiated in the market.";
                ViewData["p2_sobre"] = "We aim - for excellence, facilitating experiences for our clients that inspire- their Being to maximize - results. We are responsible with our environment and with every person we come into contact with, firmly believing that love is the force that transforms all situations. Our clients are located in the United States, Puerto Rico, Colombia, Peru, Argentina and Panama. ";
                ViewData["T1_sobre1"] = "WHO";
                ViewData["T1_sobre2"] = "WE ARE";
                ViewData["mision_titulo_sobre1"] = "OUR";
                ViewData["mision_titulo_sobre2"] = "MISION";
                ViewData["mision_sobre"] = "Our mission is to bring a holistic and empowered mindset to individuals and organizations through the art of transformational coaching.";
                ViewData["vision_titulo_sobre1"] = "OUR";
                ViewData["vision_titulo_sobre2"] = "VISION";
                ViewData["vision_sobre"] = "Our vision is to participate in the evolution of global transformation by bringing the coaching process as a viable path towards the expansion of human awareness resulting in the realization of human potential.";
                ViewData["valoresCentrales_sobre1"] = "OUR";
                ViewData["valoresCentrales_sobre2"] = "CORE VALUES";
                ViewData["amor_titulo"] = "Love";
                ViewData["auten_titulo"] = "Authenticity";
                ViewData["congru_titulo"] = "Congruency";
                ViewData["grati_titulo"] = "Gratitude";
                ViewData["pasion_titulo"] = "Passion";
                ViewData["transpa_titulo"] = "Transparency";
                ViewData["p_amor_titulo"] = "All of our values are built on a foundation of love, which encompasses the higher purpose of our existence as an organization and the reason that underpins our services.";
                ViewData["p_auten_titulo"] = "We are an authentic organization that respects the authenticity of each person, aspect that we honor by celebrating each individual as a unique being.";
                ViewData["p_congru_titulo"] = "We seek permanent balance between our ideals, actions and way of life, that allows us to approach the world with integrity, modeling what we teach and inspiring each person.";
                ViewData["p_grati_titulo"] = "Since the coaching experience gives us the opportunity to facilitate in transforming lives, there is a presence of gratitude in all we do.";
                ViewData["p_pasion_titulo"] = "It is the engine that drives our behaviors, linking our higher purpose to the life project of each person who comes into contact with us, which inspires them and leaves a mark on us all.";
                ViewData["p_transpa_titulo"] = "Our most important goal is to create a loving atmosphere of trust, honesty, and confidentiality for our clients and colleagues.";
                ViewData["contactanos_index"] = "CONTACT US";
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";

                //navbar links
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contact_link"] = "CONTACT US";


            }
            //texto en el idioma español
            else
            {
                ViewData["p1_sobre"] =
                    "Somos una organización que promueve el bienestar en todos los aspectos de la vida. Coaching For Wellness (CFW) fue fundado en 2004 por Susan Seidman y Annie Torres, ambas Máster Coaches Certificadas (MCC por sus siglas en inglés) y pioneras en la profesión de coaching en los Estados Unidos, Puerto Rico y Latinoamérica. Nos apasiona lo que hacemos. Procuramos hacer del mejoramiento continuo algo real, lo que nos permite ser altamente diferenciados en el mercado.";
                ViewData["p2_sobre"] = "Actuamos bajo la convicción de hacer las cosas con excelencia, brindando a nuestros clientes experiencias que inspiran al Ser para maximizar los resultados. Somos responsables con nuestro entorno y con cada persona con la que tenemos contacto, creyendo firmemente que el amor es la fuerza que transforma cualquier situación. Nuestros clientes, además de en Estados Unidos, se han concentrado en países como Puerto Rico, Colombia, Perú, Argentina y Panamá.";
                ViewData["T1_sobre1"] = "QUIÉNES";
                ViewData["T1_sobre2"] = "SOMOS";
                ViewData["mision_titulo_sobre1"] = "NUESTRA";
                ViewData["mision_titulo_sobre2"] = "MISIÓN";
                ViewData["mision_sobre"] = "Nuestra misión es brindar un esquema de pensamiento holístico y empoderado a individuos y organizaciones, mediante el arte del coaching transformacional.";
                ViewData["vision_titulo_sobre1"] = "NUESTRA";
                ViewData["vision_titulo_sobre2"] = "VISIÓN";
                ViewData["vision_sobre"] = "Nuestra visión es participar en la evolución de la transformación global, ofreciendo el proceso de coaching como un camino viable hacia la expansión de la conciencia humana, resultando en la realización del potencial de los seres humanos.";
                ViewData["valoresCentrales_sobre1"] = "NUESTROS";
                ViewData["valoresCentrales_sobre2"] = "VALORES CENTRALES";
                ViewData["amor_titulo"] = "Amor";
                ViewData["auten_titulo"] = "Auntenticidad";
                ViewData["congru_titulo"] = "Congruencia";
                ViewData["grati_titulo"] = "Gratitud";
                ViewData["pasion_titulo"] = "Pasión";
                ViewData["transpa_titulo"] = "Transparencia";
                ViewData["p_amor_titulo"] = "Todos nuestros valores se fundamentan sobre una base de amor, la cual comprende el propósito más elevado de nuestra existencia como organización, así como la razón de ser de nuestros servicios.";
                ViewData["p_auten_titulo"] = "Somos una organización auténtica y respetamos la autenticidad de cada ser, aspecto que honramos celebrando a cada persona como un ser único e irrepetible.";
                ViewData["p_congru_titulo"] = "Buscamos permanente equilibrio entre nuestros ideales, acciones y filosofía de vida, que permita acercarnos al mundo desde la integridad y el ejemplo, generando inspiración en cada ser.";
                ViewData["p_grati_titulo"] = "La gratitud está presente en todo lo que hacemos, ya que valoramos cómo la experiencia de coaching nos permite contribuir a transformar vidas.";
                ViewData["p_pasion_titulo"] = "Es el motor que impulsa nuestros comportamientos, vinculando nuestro- propósito- superior- al proyecto de vida de cada persona que tiene contacto con nosotros, lo cual les inspira y deja huellas para todos.";
                ViewData["p_transpa_titulo"] = "Nuestra meta principal es crear un ambiente amoroso - de confianza, honestidad y confidencialidad - para nuestros clientes y colegas.";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";

                //navbas links
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";


            }
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
            var lang = Session["lang"];

            //texto en el idioma ingles
            if (lang != null && lang.ToString() == "en")
            {
                ViewData["title_pagos1"] = "ONLINE";
                ViewData["title_pagos2"] = "PAYMENTS";
                //navbar links
                ViewData["aboutUs_link"] = "ABOUT US";
                ViewData["certi_link"] = "CERTIFICATIONS";
                ViewData["servi_link"] = "SERVICES";
                ViewData["contactanos_index"] = "CONTACT US";
                ViewData["contact_link"] = "CONTACT US";
                ViewData["derechos_index"] = "ALL RIGHTS RESERVED - COACHING FOR WELLNESS 2017";

            }
            //texto en el idioma español
            else
            {
                ViewData["title_pagos1"] = "PAGOS";
                ViewData["title_pagos2"] = "EN LÍNEA";
                //navbas links
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                ViewData["contact_link"] = "CONTÁCTANOS";
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";


            }
            return View();
        }

        public ActionResult Personas()
        {
            return View();
        }

        public ActionResult Servicios()
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