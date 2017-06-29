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
                ViewData["cfw"] = "";
                ViewData["susan"] = "";

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
                ViewData["cfw"] = "¿PARA QUÉ CWF?";
                ViewData["susan"] = "SUSAN SEIDMAN TE LO EXPLICA";

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
                ViewData["contactanos_index"] = "CONTÁCTANOS";
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
                ViewData["t1Cer"] = "CERTIFICATION";
                ViewData["t1Cer1"] = "PROGRAMS";
                ViewData["t2Cer"] = "COACHING";
                ViewData["t3Cer"] = "All professional preparation in the development of Coaching competencies, its integration and implementation begins with the life aspect. This program teaches all the coaching skills from the perspective of Life Coaching, an aspect of great relevance in the training of an Executive and Corporate Coach.";
                ViewData["t4Cer"] = "OUR CERTIFICATION PROGRAMS";
                ViewData["t5Cer"] = "Offer two levels of certification, each one fulfilling the ICF requirements for that specific level.";
                ViewData["t6Cer"] = "PROFESSIONAL";
                ViewData["t6Cerco"] = "LEVEL";
                ViewData["t6Cer6"] = "COACHING";
                ViewData["t7Cer"] = "BUSINESS";
                ViewData["t7Cere"] = "AND LIFE";
                ViewData["t7jCer"] = "COACHING";
                ViewData["t8Cer"] = "PROFESSIONAL LEVEL";
                ViewData["t9Cer"] = "ASSOCIATE";
                ViewData["t9Cerl"] = "LEVEL";
                ViewData["t9Cer9"] = "COACHING";
                ViewData["t10Cer"] = "ASSOCIATE LEVEL";
                ViewData["t11Cer"] = "LIFE";
                ViewData["t11Cerw"] = "AND WELLNESS";
                ViewData["t11Cer11"] = "COACHING";
                ViewData["t12Cer"] = "LIFE";
                ViewData["t12Cerv"] = "AND SPIRITUAL";
                ViewData["t12kCer"] = "COACHING";
                ViewData["t13Cer"] = "OASIS BREATHING TECHNIQUE";
                //helper de presonas
                ViewData["t14Cer"] = "This certification navigates the most important issues in the Coaching profession, and seeks to balance both life and business components (emphasizing Organizational Culture and Executive Coaching). In turn, this dual focus allows the participant to have state-of-the-art tools to become a successful coach in various market niches. This certification program is an Accredited Coach Training Program (ACTP) by the International Coach Federation (ICF). As an ACTP the program complies with the training requirement component for the Professional Certified Coach (PCC) credential.";
                ViewData["t15Cer"] = "OVERVIEW OF OUR PROGRAMS";
                ViewData["t16Cer"] = "Our programs seek to bring a state of balance and well-being to the coaching profession, for coach and coachee, based on the fundamental belief that global transformation depends on our understanding and application of 'Whole Brain thinking', emotional intelligence, and the integration of values ​​through action.";
                ViewData["t17Cer"] = "PHILOSOPHY OR COACHING APPROACH";
                ViewData["t18Cer"] = "Our programs follow a holistic approach that seeks to raise the awareness of coaches and coachees about the connection between body, mind, emotions and spirit, and their effect on life. Our methodology is based on an ontological philosophy, directed towards reflection and introspection to generate new mental models, beliefs and behaviors that are aligned to achieving the goals set up in coaching. In addition, our methodology follows a biological/physiological approach, integrating knowledge about how the brain functions and its relevance to the coaching process. ";
                ViewData["t19Cer"] = "In summary, we use an integral and ontological approach to highlight the importance of going beyond the external work of goal-setting and implementing action plans, and to deepen the inner processes that allow coachees to know themselves better, and to use this information to move forward and achieve their goals.";
                ViewData["t20Cer"] = "METHODOLOGY";
                ViewData["t21Cer"] = "The Program follows a Blended methodology (in person and online), which includes four (4) in-person modules of 30 hours each (full three-day weekends) with intervals of 2 or 3 months between each meeting. Total work hours for the entire training program are 226. The total approved hours by ICF is 136, which refers to the training requirement for PCC credentialing.";
                ViewData["t22Cer"] = "The topics discussed throughout the certification are:";
                ViewData["t23Cer"] = "MODULE 1:";
                ViewData["t24Cer"] = "Life Coaching (30 hours)";
                ViewData["t25Cer"] = "MODULE 2:";
                ViewData["t26Cer"] = "Business Coaching (emphasizing Organizational Culture and Executive Coaching; 30 hours)";
                ViewData["t27Cer"] = "MODULE 3:";
                ViewData["t28Cer"] = "Relationship Coaching and Emotional Intelligence (30 hours)";
                ViewData["t29Cer"] = "MODULE 4:";
                ViewData["t30Cer"] = "Marketing for Coaching (30 hours)";
                ViewData["t31Cer"] = "VIRTUAL ACTIVITIES";
                ViewData["t32Cer"] = "Eight (8) tele-classes / practice labs (2 hours each; 16 hours total)";
                ViewData["t33Cer"] = "Two (2) Group mentoring sessions (2 hours each; 4 hours total)";
                ViewData["t34Cer"] = "Six (6) Individual mentoring sessions (1 hour each approx.; 6 hours total)";
                ViewData["t35Cer"] = "LEARNING OBJECTIVES";
                ViewData["t36Cer"] = "At the end of the Program, participants will have developed the knowledge, skills and abilities required to:";
                ViewData["t37Cer"] = "Apply pure coaching skills that assist clients in moving toward success and meeting their goals.";
                ViewData["t38Cer"] = "Contrast between the coachee’s internal agenda (motivation) and the external agenda (action) to support his or her self-awareness and learning. ";
                ViewData["t39Cer"] = "Effectively work with teams, executives, and salespeople to improve performance and goal attainment.";
                ViewData["t40Cer"] = "Use 360 and other assessment tools; and master effective feedback processes.";
                ViewData["t41Cer"] = "Create and implement programs to transform corporate cultures into coaching cultures.";
                ViewData["t42Cer"] = "Work as a Life, Relationships, Family, Business, Leadership, Career, or Outplacement Coach";
                ViewData["t43Cer"] = "Effectively market coaching services.";
                ViewData["t44Cer"] = "Practice the coaching profession in various market niches.";
                ViewData["t45Cer"] = "INSTRUCTORS";
                ViewData["t46Cer"] = "Susan Seidman, MCC";
                ViewData["t47Cer"] = "Annie Torres, MCC";
                ViewData["t48Cer"] = "Lida Garzón, PCC";
                ViewData["t49Cer"] = "Alejandra Ramírez, PCC";
                ViewData["t50Cer"] = "Lucio Pérez, PCC";
                ViewData["t51Cer"] = "Lisa Soto, PCC";
                ViewData["t52Cer"] = "DATES OF UPCOMING PROGRAMS";
                ViewData["t53Cer"] = "Write to contactus@coachingforwellness.com for details of programs in your area.";
                ViewData["t54Cer"] = "LANGUAGES IN WHICH THE PROGRAM IS OFFERED";
                ViewData["t55Cer"] = "The Program is offered in Spanish and English in several countries in Latin America and the United States.";
                ViewData["t56Cer"] = "WHO IS THIS PROGRAM DIRECTED TO?";
                ViewData["t57Cer"] = "The Program is aimed at people aged 21 and older, who align with the view of coaching as a vehicle for individual and organizational transformation. This program is recommended for people who want a career as a life or business coach; business and community leaders; human resources professionals, managers, and entrepreneurs";
                ViewData["t58Cer"] = "REQUIREMENTS FOR PROGRAM ADMISSION";
                ViewData["t59Cer"] = "The admissions policy includes an interview process with a certified coach to: a) explore person-program fit and the person’s level of understanding and interest in coaching; b) explain program requirements and commitments; and c) clarify expectations and concerns.";
                ViewData["t60Cer"] = "REGISTRATION AND PAYMENT POLICIES";
                ViewData["t61Cer"] = "The total cost includes all program components: in-person modules, virtual activities, mentoring and practices.";
                ViewData["t62Cer"] = "Payment options include: 1) cash payment, 2) discount for early payment, or 3) deferred payment in four installments, due before each in-person module.";
                ViewData["t63Cer"] = "Mentoring Sessions: The Program includes 10 hours of individual and group mentoring. Mentoring sessions requested outside of established dates will incur in a penalty of $100 USD per hour.";
                ViewData["t64Cer"] = "Written Exam: Participant evaluation includes passing a written exam at the end of the training process (after Module 4). For administration of written exam outside of established dates $125 USD fee will apply.";
                ViewData["t65Cer"] = "Oral Exam Retake: The coach certification also requires passing an oral exam. If first attempt is not approved, the participant can schedule a second examination at no additional cost. For a third attempt and beyond, the participant needs to receive additional mentoring (at $100 USD per hour). For administration of oral exam outside of established dates $125 USD fee will apply.";
                ViewData["t66Cer"] = "Completion of in-person modules: If the participant is absent from an in-person module (or part of it), he/she can attend a future module with another group at no additional cost, or request individual tutoring at an additional cost, to get up to date and continue within the timeline of their group. The participant is responsible for any travel and lodging expenses for attending programs outside of his/her city or country. ";
                ViewData["t67Cer"] = "The participant is responsible for the purchase of three coaching books assigned as part of the Program";
                ViewData["t68Cer"] = "WITHDRAWALS AND REFUNDS";
                ViewData["t69Cer"] = "If the participant decides to voluntarily withdraw from the Program before its completion, all agreed upon commitments on confidentiality and payments remain. ";
                ViewData["t70Cer"] = "No refunds will be made if the participant chooses to voluntarily withdraw from the Program.";
                ViewData["t71Cer"] = "If the participant decides to complete the certification at a future date, processed payments will be credited to the new program.";
                ViewData["t72Cer"] = "DURATION OF THE PROGRAM";
                ViewData["t73Cer"] = "The estimated duration of the training component is 10 months.";
                ViewData["t74Cer"] = "Contact us at info@coachingforwellness.com for more information about this program.";
                //oasis
                ViewData["to1"] = "OASIS BREATHING ";
                ViewData["to2"] = "TECHNIQUE";
                ViewData["to3"] = "Is STRESS wreaking havoc in your personal/professional life?";
                ViewData["to4"] = "Looking for calm in the chaos?";
                ViewData["to5"] = "Find it in OASIS.";
                ViewData["to6"] = "Learn the OASIS 60-second Strategies for a happier, healthier way of living";
                ViewData["to7"] = "Find balance and enjoyment today";
                ViewData["to8"] = "Susan Seidman is a Certified Oasis Trainer who offers in-person and online Training Programs in English and Spanish.";
                ViewData["to9"] = "The Oasis 60-second Strategies are a Jumpstart Sanity Kit for all walks of life.";
                ViewData["to10"] = "Four proven strategies to change your brain and your life in less than a minute.";
                ViewData["to11"] = "They are simple, practical and easy-to-learn daily strategies.";
                ViewData["to12"] = "They honestly do take only 60 seconds each.";
                ViewData["to13"] = "They’re a fast track to re-wiring your brain from chaos to calm. ";
                ViewData["to14"] = "Practical Mindfulness tools to strengthen your mind, body and spirit.";
                ViewData["to15"] = "The OASIS 60-second Strategies teach you how to ride life’s small waves and large tsunamis to enjoy greater health and happiness in your life.";
                ViewData["to16"] = "Learn how to use the neuroplasticity of your own brain.";
                ViewData["to17"] = "Become the CEO of your own life.";
                ViewData["to18"] = "The essence of OASIS is not to eliminate stress. Rather, it is to help us interact consciously – and with clarity – with what is on our plate.";
                ViewData["to19"] = "We all have stress. The good news: we do not need to be helpless victims to it. How we respond to stress makes all the difference.";
                ViewData["to20"]= "WHY WAIT? Give yourself an OASIS now!";
                ViewData["to21"] = "This course also offers the following CCEUs for coaches:";
                ViewData["to22"] = "Core Competencies - 7.38 hours";
                ViewData["to23"] = "Resource Development - 4.62 hours ";
                ViewData["to24"] = "For more information, visit: ";
                ViewData["to25"] = "http://www.milliegrenough.com/oasis-training/oasis-trainers";
                //espiritual
                ViewData["te1"] = "This certification focuses on the SPIRITUAL BEING, and its infinite possibilities of happiness and connection that lead to inner peace and the fulfilment of life. It touches on all life coaching topics from a holistic perspective. In addition, it explores human spirituality in depth from spiritual leadership as a source of inspiration, motivation and connection in diverse family, social and work settings. This allows the participant to have state-of-the art tools to become a successful coach in various market niches.";
                ViewData["te2"] = "Humanity is returning to the Source, which drives people’s higher purposes. This program is a path of inner discovery; a process of interiorization based on self-coaching tools.";
                ViewData["te3"] = "OVERVIEW OF OUR PROGRAMS";
                ViewData["te4"] = "Our programs seek to bring a state of balance and well-being to the coaching profession, for coach and coachee, based on the fundamental belief that global transformation depends on our understanding and application of 'Whole Brain thinking', emotional intelligence, and the integration of values ​​through action.";
                ViewData["te5"] = "Our goal is to professionally inspire and train authentic, empowered, compassionate and effective coaches who not only meet the ethical and professional standards defined by the ICF, but who live these standards at their core.";
                ViewData["te6"] = "PHILOSOPHY OR COACHING APPROACH";
                ViewData["te7"] = "Our programs follow a holistic approach that seeks to raise the awareness of coaches and coachees about the connection between body, mind, emotions and spirit, and their effect on life. Our methodology is based on an ontological philosophy, directed towards reflection and introspection to generate new mental models, beliefs and behaviors that are aligned to achieving the goals set up in coaching. In addition, our methodology follows a biological/physiological approach, integrating knowledge about how the brain functions and its relevance to the coaching process.";
                ViewData["te8"] = "In summary, we use an integral and ontological approach to highlight the importance of going beyond the external work of goal-setting and implementing action plans, and to deepen the inner processes that allow coachees to know themselves better, and to use this information to move forward and achieve their goals.";
                ViewData["te9"] = "METHODOLOGY";
                ViewData["te10"] = "The Program follows a Blended methodology (in person and online), which includes three (3) in-person modules of 20 hours each (full two-day weekends) with intervals of 2 or 3 months between each meeting. The total hours of work during the training process are 128.";
                ViewData["te11"] = "This program is also offered 100% online with live weekly teleclasses/webinars.";
                ViewData["te12"] = "The topics discussed throughout the certification are:";
                ViewData["te13"] = "MODULE 1:";
                ViewData["te14"] = "Life Coaching (20 hours)";
                ViewData["te15"] = "MODULE 2:";
                ViewData["te16"] = "Spiritual Coaching ( 20 hours)";
                ViewData["te17"] = "MODULE 3:";
                ViewData["te18"] = "Marketing for Spiritual Coaching (20 hours)";
                ViewData["te19"] = "VIRTUAL ACTIVITIES";
                ViewData["te20"] = "Work is completed in 68 hours, as follows:";
                ViewData["te21"] = "Five (5) tele-classes / practice labs (2 hours each; 10 hours total)";
                ViewData["te22"] = "Two (2) Group mentoring sessions (2 hours each; 4 hours total)";
                ViewData["te23"] = "Six (6) Individual mentoring sessions (1 hour each approx.; 6 hours total)";
                ViewData["te24"] = "48 hours of individual and group practices. Peer coaching: 32 hours, group meetings: 16.";
                ViewData["te25"] = "LEARNING OBJECTIVES";
                ViewData["te26"] = "At the end of the Program, participants will have developed the knowledge, skills and abilities required to:";
                ViewData["te27"] = "Apply  pure coaching skills with a spiritual approach that assist clients in moving toward success and fulfillment of spiritual goals.";
                ViewData["te28"] = "Approach the Being from its own greatness and potential, recognizing that greatness resides in all.";
                ViewData["te29"] = "Identify elements linked to various spiritual agendas, and contrast between the coachee’s internal agenda (motivation) and the external agenda (action) to support his or her self-awareness and spiritual learning.";
                ViewData["te30"] = "Work effectively with people on various spiritual agendas to achieve their goals and dreams in terms of a deeper inner and external connection.";
                ViewData["te31"] = "Practice the spiritual coaching profession in various market niches.";
                ViewData["te32"] = "DATES OF UPCOMING PROGRAMS";
                ViewData["te33"] = "Write to contactus@coachingforwellness.com for details of programs in your area.";
                ViewData["te34"] = "LANGUAGES IN WHICH THE PROGRAM IS OFFERED";
                ViewData["te35"] = "The Program is offered in Spanish and English in several countries in Latin America and the United States.";
                ViewData["te36"] = "WHO IS THIS PROGRAM DIRECTED TO?";
                ViewData["te37"] = "The Program is aimed at people aged 21 and older, who align with the view of coaching as a vehicle for the transformation of individuals from a spiritual approach. This program is recommended for people who want a career as a life and spiritual coach; and those interested in experiencing a profound change in their own lives and their relationships from the principles of inner peace.";
                ViewData["te38"] = "DURATION OF THE PROGRAM";
                ViewData["te39"] = "The estimated duration of the training component is 6 months.";
                ViewData["te40"] = "This certification is aligned with the ICF Code of Ethics and Core Competencies. It complies with the training requirements of the Associate Certified Coach (ACC) credential. Coaches can request an ACC credential after successful completion of the coaching experience hours established by the ICF.  ";
                ViewData["te41"] = "Contact us at info@coachingforwellness.com for more information about this program. ";

                //bienestar
                ViewData["tb1"] = "This certification focuses on the BEING, and its infinite possibilities of prosperity and well-being at all levels. It walks through all life coaching topics, from a holistic perspective, which allows the participant to have state-of-the-art tools to become a successful coach in various market niches.";
                ViewData["tb2"] = "OVERVIEW OF OUR PROGRAMS";
                ViewData["tb3"] = "Our programs seek to bring a state of balance and well-being to the coaching profession, for coach and coachee, based on the fundamental belief that global transformation depends on our understanding and application of 'Whole Brain thinking', emotional intelligence, and the integration of values ​​through action.";
                ViewData["tb4"] = "Our goal is to professionally inspire and train authentic, empowered, compassionate and effective coaches who not only meet the ethical and professional standards defined by the ICF, but who live these standards at their core.";
                ViewData["tb5"] = "PHILOSOPHY OR COACHING APPROACH";
                ViewData["tb6"] = "Our programs follow a holistic approach that seeks to raise the awareness of coaches and coachees about the connection between body, mind, emotions and spirit, and their effect on life. Our methodology is based on an ontological philosophy, directed towards reflection and introspection to generate new mental models, beliefs and behaviors that are aligned to achieving the goals set up in coaching. In addition, our methodology follows a biological/physiological approach, integrating knowledge about how the brain functions and its relevance to the coaching process.";
                ViewData["tb7"] = "In summary, we use an integral and ontological approach to highlight the importance of going beyond the external work of goal-setting and implementing action plans, and to deepen the inner processes that allow coachees to know themselves better, and to use this information to move forward and achieve their goals.";
                ViewData["tb8"] = "METHODOLOGY";
                ViewData["tb9"] = "The Program follows a Blended methodology (in person and online), which includes three (3) in-person modules of 20 hours each (full two-day weekends) with intervals of 2 or 3 months between each meeting. The total hours of work during the training process are 128.";
                ViewData["tb10"] = "This program is also offered 100% online with live weekly teleclasses/webinars.";
                ViewData["tb11"] = "The topics discussed throughout the certification are:";
                ViewData["tb12"] = "MODULE 1:";
                ViewData["tb13"] = "Life Coaching (20 hours)";
                ViewData["tb14"] = "MODULE 2:";
                ViewData["tb15"] = "Wellness Coaching ( 20 hours)";
                ViewData["tb16"] = "MODULE 3:";
                ViewData["tb17"] = "Relationship Coaching and Marketing (20 hours)";
                ViewData["tb18"] = "VIRTUAL ACTIVITIES";
                ViewData["tb19"] = "Work is completed in 68 hours, as follows:";
                ViewData["tb20"] = "Five (5) tele-classes / practice labs (2 hours each; 10 hours total)";
                ViewData["tb21"] = "Two (2) Group mentoring sessions (2 hours each; 4 hours total)";
                ViewData["tb22"] = "Six (6) Individual mentoring sessions (1 hour each approx.; 6 hours total)";
                ViewData["tb23"] = "48 hours of individual and group practices. Peer coaching: 32 hours, group meetings: 16.";
                ViewData["tb24"] = "LEARNING OBJECTIVES";
                ViewData["tb25"] = "At the end of the Program, participants will have developed the knowledge, skills and abilities required to:";
                ViewData["tb26"] = "Apply pure coaching skills with a wellness approach that assist clients in moving toward success and meeting their wellness goals.";
                ViewData["tb27"] = "Approach the Being from its own greatness and potential, recognizing that greatness resides in all.";
                ViewData["tb28"] = "Identify elements linked to various wellness agendas, and contrast between the coachee’s internal agenda (motivation) and the external agenda (action) to support his or her self-awareness and wellness learning.";
                ViewData["tb29"] = "Work effectively with people on various LIFE agendas to achieve the goals and dreams they want to achieve.";
                ViewData["tb30"] = "Practice the coaching profession in various market niches.";
                ViewData["tb31"] = "DATES OF UPCOMING PROGRAMS";
                ViewData["tb32"] = "Write to contactus@coachingforwellness.com for details of programs in your area.";
                ViewData["tb33"] = "LANGUAGES IN WHICH THE PROGRAM IS OFFERED";
                ViewData["tb34"] = "The Program is offered in Spanish and English in several countries in Latin America and the United States.";
                ViewData["tb35"] = "WHO IS THIS PROGRAM DIRECTED TO?";
                ViewData["tb36"] = "The Program is aimed at people aged 21 and older, who align with the view of coaching as a vehicle for individual transformation. This program is recommended for people who want a career as a life and wellness coach; community leaders; and those interested in experiencing a profound change in their own lives and their relationships from the principles of abundance and well-being.";
                ViewData["tb37"] = "DURATION OF THE PROGRAM";
                ViewData["tb38"] = "The estimated duration of the training component is 6 months.";
                ViewData["tb39"] = "This certification is aligned with the ICF Code of Ethics and Core Competencies. It complies with the training requirements of the Associate Certified Coach (ACC) credential. Coaches can request an ACC credential after successful completion of the coaching experience hours established by the ICF.  ";
                ViewData["tb40"] = "Contact us at info@coachingforwellness.com for more information about this program. ";

                //nivel asociado
                ViewData["ta1"] = "This certification navigates the most important issues in the Coaching profession, and seeks to balance both life and business components (emphasizing Organizational Culture and Executive Coaching). In turn, this dual focus allows the participant to have state-of-the-art tools to become a successful coach in various market niches.";
                ViewData["ta2"] = "OVERVIEW OF OUR PROGRAMS";
                ViewData["ta3"] = "Our programs seek to bring a state of balance and well-being to the coaching profession, for coach and coachee, based on the fundamental belief that global transformation depends on our understanding and application of 'Whole Brain thinking', emotional intelligence, and the integration of values ​​through action.";
                ViewData["ta4"] = "Our goal is to professionally inspire and train authentic, empowered, compassionate and effective coaches who not only meet the ethical and professional standards defined by the ICF, but who live these standards at their core.";
                ViewData["ta5"] = "PHILOSOPHY OR COACHING APPROACH";
                ViewData["ta6"] = "Our programs follow a holistic approach that seeks to raise the awareness of coaches and coachees about the connection between body, mind, emotions and spirit, and their effect on life. Our methodology is based on an ontological philosophy, directed towards reflection and introspection to generate new mental models, beliefs and behaviors that are aligned to achieving the goals set up in coaching. In addition, our methodology follows a biological/physiological approach, integrating knowledge about how the brain functions and its relevance to the coaching process.";
                ViewData["ta7"] = "In summary, we use an integral and ontological approach to highlight the importance of going beyond the external work of goal-setting and implementing action plans, and to deepen the inner processes that allow coachees to know themselves better, and to use this information to move forward and achieve their goals.";
                ViewData["ta8"] = "METHODOLOGY";
                ViewData["ta9"] = "The Program follows a Blended methodology (in person and online), which includes three (3) in-person modules of 20 hours each (full two-day weekends) with intervals of 2 or 3 months between each meeting. The total hours of work during the training process are 128.";
                ViewData["ta10"] = "This program is also offered 100% online with live weekly teleclasses/webinars.";
                ViewData["ta11"] = "The topics discussed throughout the certification are:";
                ViewData["ta12"] = "MODULE 1:";
                ViewData["ta13"] = "Life Coaching (20 hours)";
                ViewData["ta14"] = "MODULE 2:";
                ViewData["ta15"] = "Business Coaching (emphasizing Organizational Culture and Executive Coaching; 20 hours)";
                ViewData["ta16"] = "MODULE 3:";
                ViewData["ta17"] = "Marketing for Coaching (20 hours)";
                ViewData["ta18"] = "VIRTUAL ACTIVITIES";
                ViewData["ta19"] = "Work is completed in 68 hours, as follows:";
                ViewData["ta20"] = "Five (5) tele-classes / practice labs (2 hours each; 10 hours total)";
                ViewData["ta21"] = "Two (2) Group mentoring sessions (2 hours each; 4 hours total)";
                ViewData["ta22"] = "Six (6) Individual mentoring sessions (1 hour each approx.; 6 hours total)";
                ViewData["ta23"] = "48 hours of individual and group practices. Peer coaching: 32 hours, group meetings: 16.";
                ViewData["ta24"] = "LEARNING OBJECTIVES";
                ViewData["ta25"] = "At the end of the Program, participants will have developed the knowledge, skills and abilities required to:";
                ViewData["ta26"] = "Apply pure coaching skills that assist clients in moving toward success and meeting their goals.";
                ViewData["ta27"] = "Maximize leadership competencies in multiple individual and group contexts.";
                ViewData["ta28"] = "Contrast between the coachee’s internal agenda (motivation) and the external agenda (action) to support his or her self-awareness and learning.";
                ViewData["ta29"] = "Create and implement programs to transform corporate cultures into coaching cultures.";
                ViewData["ta30"] = "Work effectively with executives for performance improvement and goal attainment in their role.";
                ViewData["ta31"] = "Effectively market coaching services.";
                ViewData["ta32"] = "Practice the coaching profession in various market niches.";
                ViewData["ta33"] = "DATES OF UPCOMING PROGRAMS";
                ViewData["ta34"] = "Write to contactus@coachingforwellness.com for details of programs in your area.";
                ViewData["ta35"] = "LANGUAGES IN WHICH THE PROGRAM IS OFFERED";
                ViewData["ta36"] = "The Program is offered in Spanish and English in several countries in Latin America and the United States.";
                ViewData["ta37"] = "WHO IS THIS PROGRAM DIRECTED TO ? ";
                ViewData["ta38"] = "The Program is aimed at people aged 21 and older, who align with the view of coaching as a vehicle for individual and organizational transformation.This program is recommended for people who want a career as a life or business coach; business and community leaders; human resources professionals, managers, and entrepreneurs.";
                ViewData["ta39"] = "DURATION OF THE PROGRAM";
                ViewData["ta40"] = "The estimated duration of the training component is 6 months.";
                ViewData["ta41"] = "This certification is aligned with the ICF Code of Ethics and Core Competencies. It complies with the training requirements of the Associate Certified Coach (ACC) credential. Coaches can request an ACC credential after successful completion of the coaching experience hours established by the ICF. ";
                ViewData["ta42"] = "Contact us at info@coachingforwellness.com for more information about this program. ";
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";

                //variables de personas
                ViewData["t1Cer"] = "PROGRAMAS";
                ViewData["t1Cer1"] = "DE CERTIFICACIÓN";
                ViewData["t2Cer"] = "COACHING";
                ViewData["t3Cer"] = "Toda preparación profesional en el desarrollo de las competencias de coaching, su integración y su aplicación, comienza por el área de vida.Este programa enseña todas las destrezas de coaching desde un punto de vista del coaching de vida, aspecto de gran pertinencia en la formación de un coach ejecutivo y corporativo.";
                ViewData["t4Cer"] = "NUESTROS PROGRAMAS CERTIFICADOS";
                ViewData["t5Cer"] = "Ofrecen dos niveles de certificación que cumplen a cabalidad con los requerimientos de la ICF para cada nivel de credencial.";
                ViewData["t6Cer"] = "COACHING";
                ViewData["t6Cerco"] = "NIVEL";
                ViewData["t6Cer6"] = "PROFESIONAL";
                ViewData["t7Cer"] = "COACHING";
                ViewData["t7Cere"] = "EMPRESARIAL";
                ViewData["t7jCer"] = "Y DE VIDA";
                ViewData["t8Cer"] = "NIVEL PROFESIONAL";
                ViewData["t9Cer"] = "COACHING ";
                ViewData["t9Cerl"] = "NIVEL";
                ViewData["t9Cer9"] = "ASOCIADO";
                ViewData["t10Cer"] = "NIVEL ASOCIADO ";
                ViewData["t11Cer"] = "COACHING";
                ViewData["t11Cerw"] = "DE VIDA";
                ViewData["t11Cer11"] = "Y BIENESTAR";
                ViewData["t12Cer"] = "COACHING";
                ViewData["t12Cerv"] = "DE VIDA";
                ViewData["t12kCer"] = "Y ESPIRITUAL";
                ViewData["t13Cer"] = "TÉCNICA DE RESPIRACIÓN OASIS";
                //helper de personas
                ViewData["t14Cer"] = "Esta certificación hace un recorrido por los temas de mayor importancia en la profesión del Coaching, enfocada en elementos equilibrados entre la vida y la empresa, lo que permite ampliar las posibilidades de ejercer con éxito en diversos nichos de mercado. Se encuentra acreditada como ACTP (Accredited Coach Training Program) por la International Coach Federation (ICF), lo que permite solicitar la credencial PCC (Professional Certified Coach).";
                ViewData["t15Cer"] = "VISIÓN GENERAL Y METAS DEL PROGRAMA";
                ViewData["t16Cer"] = "Nuestros programas se concentran en traer un estado de equilibrio y bienestar a la profesión de coaching, tanto para el coach como para el coachee, basados en la creencia fundamental de que la transformación global depende de nuestra comprensión del balance, del liderazgo de todo el cerebro, de la inteligencia emocional, y de la unificación de los valores mediante la acción.";
                ViewData["t17Cer"] = "FILOSOFÍA O ACERCAMIENTO DE COACHING";
                ViewData["t18Cer"] = "Nuestros programas han sido diseñados bajo un enfoque holístico que busca elevar la consciencia de coaches y coachees sobre la conexión entre el cuerpo, la mente, las emociones y el espíritu, y su efecto en nuestras vidas. Nuestra metodología se fundamenta en una filosofía ontológica, dirigida a la reflexión e introspección para generar nuevos modelos de pensamiento y nuevos comportamientos que estén alineados al logro de las metas trabajadas en coaching. Nuestra metodología de coaching además integra una vertiente biológica y utiliza el conocimiento sobre el funcionamiento del cerebro y su relevancia para el proceso de coaching.";
                ViewData["t19Cer"] = "En resumen, utilizamos un enfoque integral y ontológico para resaltar la importancia de ir más allá del trabajo externo de establecer metas e implementar planes de acción, y profundizar en los procesos internos que permitan al coachee conocerse mejor y utilizar esta información para moverse hacia el logro de su meta.";
                ViewData["t20Cer"] = "METODOLOGÍA";
                ViewData["t21Cer"] = "Se presenta en metodología Blended (Mixto presencial - en línea), la cual incluye cuatro (4) inmersiones presenciales de 30 horas cada una (en fines de semana completos de tres días) con intervalos de 2 a 3 meses entre cada encuentro. El total de horas de trabajo durante el programa es de 226. El total de horas aprobadas por la ICF para solicitar la credencial de PCC son 136, correspondiente a la formación/enseñanza en coaching.";
                ViewData["t22Cer"] = "Los temas de exploración en el proceso son los siguientes:";
                ViewData["t23Cer"] = "INMERSIÓN 1:";
                ViewData["t24Cer"] = "Coaching de vida (30 horas)";
                ViewData["t25Cer"] = "INMERSIÓN 2:";
                ViewData["t26Cer"] = "Coaching empresarial (ejecutivo; 30 horas)";
                ViewData["t27Cer"] = "INMERSIÓN 3:";
                ViewData["t28Cer"] = "Coaching de relaciones e inteligencia emocional (30 horas)";
                ViewData["t29Cer"] = "INMERSIÓN 4:";
                ViewData["t30Cer"] = "Mercadeo para coaching (30 horas)";
                ViewData["t31Cer"] = "ACTIVIDADES VIRTUALES";
                ViewData["t32Cer"] = "Ocho (8) tele-clases/laboratorios de práctica de 2 horas cada uno para un total de 16 hrs";
                ViewData["t33Cer"] = "Dos (2) mentorías grupales de 2 horas cada una para un total de 4 horas";
                ViewData["t34Cer"] = "Seis (6) mentorías individuales de 1 hora cada una (aprox.) para un total de 6 horas";
                ViewData["t35Cer"] = "OBJETIVOS DE APRENDIZAJE";
                ViewData["t36Cer"] = "Al final del Programa, los participantes habrán desarrollado los conocimientos, las destrezas y habilidades requeridas para:";
                ViewData["t37Cer"] = "Identificar la diferencia entre la agenda interna (motivación) y la agenda externa (acción) para apoyar la concienciación y el aprendizaje del coachee.";
                ViewData["t38Cer"] = "Aplicar las destrezas de coaching puro que mueven a los clientes hacia el éxito y el cumplimiento de metas.";
                ViewData["t39Cer"] = "Trabajar efectivamente con equipos, ejecutivos y recursos de ventas para mejorar rendimiento y alcanzar las metas.";
                ViewData["t40Cer"] = "Utilizar herramientas de avalúo 360 y manejar procesos de retroalimentación efectiva.";
                ViewData["t41Cer"] = "Crear e implementar programas para transformar culturas corporativas en culturas de coaching.";
                ViewData["t42Cer"] = "Trabajar como Coach de: vida, relaciones, familia y padres, empresarial, liderazgo, carrera o outplacement.";
                ViewData["t43Cer"] = "Mercadear efectivamente sus servicios de coaching.";
                ViewData["t44Cer"] = "Ejercer la profesión de Coaching en diversos nichos de mercado.";
                ViewData["t45Cer"] = "INSTRUCTORES";
                ViewData["t46Cer"] = "Susan Seidman, MCC";
                ViewData["t47Cer"] = "Annie Torres, MCC";
                ViewData["t48Cer"] = "Lida Garzón, PCC";
                ViewData["t49Cer"] = "Alejandra Ramírez, PCC";
                ViewData["t50Cer"] = "Lucio Pérez, PCC";
                ViewData["t51Cer"] = "Lisa Soto, PCC";
                ViewData["t52Cer"] = "FECHAS DE LOS PRÓXIMOS PROGRAMAS";
                ViewData["t53Cer"] = "Escríbenos a contacto@coachingforwellness.com para recibir el detalle de fechas en tu área.";
                ViewData["t54Cer"] = "IDIOMAS EN LOS QUE SE OFRECE EL PROGRAMA";
                ViewData["t55Cer"] = "El Programa se ofrece en español e inglés en varios países de Latinoamérica y en Estados Unidos.";
                ViewData["t56Cer"] = "¿A QUIÉN ESTÁ DIRIGIDO ESTE PROGRAMA?";
                ViewData["t57Cer"] = "El Programa está dirigido a personas de 21 años en adelante, que se identifiquen con la visión del coaching como un vehículo para la transformación de individuos y organizaciones. Se recomienda este Programa para quienes deseen una carrera como coach de vida o empresarial; líderes organizacionales o sociales, directores de recursos humanos, gerentes, empresarios y emprendedores.";
                ViewData["t58Cer"] = "¿CUÁLES SON LOS REQUISITOS DE ADMISIÓN AL PROGRAMA?";
                ViewData["t59Cer"] = "La política de admisión incluye un proceso de entrevista con un coach certificado con los objetivos de: a) explorar el nivel de comprensión del participante potencial sobre lo que es coaching y su nivel de interés/compromiso en convertirse en coach; b) explicar los requisitos y compromisos del Programa; y, c) indagar si existe afinidad entre los valores y expectativas del participante potencial y del Programa.";
                ViewData["t60Cer"] = "POLÍTICAS DE PAGOS Y MATRÍCULA/REGISTRO EN EL PROGRAMA";
                ViewData["t61Cer"] = "El costo incluye todos los elementos del programa: inmersiones presenciales, actividades virtuales, mentorías y prácticas.";
                ViewData["t62Cer"] = "El participante puede escoger entre varias opciones de pago, a saber: 1) pago de contado, 2) sistema de pronto pago con descuento, ó 3) pago diferido a cuatro plazos, a ser cancelados antes de la fecha de cada inmersión.";
                ViewData["t63Cer"] = "Sesiones de mentoría: El Programa include 10 horas de mentoría individuales y grupales en el transcurso de la certificación. Sesiones de mentoría solicitadas fuera de los parámetros de tiempo establecidos tendrán una penalidad de $100 USD por hora.";
                ViewData["t64Cer"] = "Examen escrito: La evaluación del participante incluye la aprobación de un examen escrito al final del proceso de formación (luego de la Inmersión 4). Para solicitudes de administración extemporánea del examen escrito aplicará una penalidad de $125 USD.";
                ViewData["t65Cer"] = "Reposición de examen oral: La evaluación del participante incluye la aprobación de un examen oral como requisito final para obtener su certificado. Si el participante no aprueba el examen oral en su primer intento, tiene la oportunidad de agendar un segundo examen sin costo adicional. De no aprobar el examen en el segundo intento, el participante necesita recibir mentoría adicional(a un costo de $100 USD por hora).";
                ViewData["t66Cer"] = "Reposición de tiempo en inmersiones presenciales";
                ViewData["t67Cer"] = "El participante es responsable de la adquisición de tres libros sobre coaching, que son asignados en el Programa.";
                ViewData["t68Cer"] = "POLÍTICAS SOBRE SEPARACIÓN DEL PROGRAMA Y REEMBOLSOS";
                ViewData["t69Cer"] = "Si el participante escoge removerse voluntariamente del Programa antes de su conclusión, su decisión no lo libera de los compromisos acordados sobre la confidencialidad y los términos de pagos establecidos al momento de registrarse en el Programa.";
                ViewData["t70Cer"] = "No se efectuarán devoluciones de dinero si el participante escoge removerse voluntariamente del Programa.";
                ViewData["t71Cer"] = "Si el participante decide completar su proceso de certificación en una fecha futura, los pagos que haya realizado serán acreditados a su nuevo programa.";
                ViewData["t72Cer"] = "DURACIÓN DEL PROGRAMA";
                ViewData["t73Cer"] = "La duración del proceso de formación está estimada en 10 meses.";
                ViewData["t74Cer"] = "Escríbenos a info@coachingforwellness.com para conocer más detalles sobre este programa.";
                //oasis
                ViewData["to1"] = "TÉCNICA DE RESPIRACIÓN ";
                ViewData["to2"] = "OASIS";
                ViewData["to3"] = "¿El estrés está causando estragos en su vida personal / profesional?";
                ViewData["to4"] = "¿Busca calma en el caos?";
                ViewData["to5"] = "Encuéntrelo en OASIS.";
                ViewData["to6"] = "Aprenda las estrategias de 60 segundos de OASIS para una vida más feliz y saludable.";
                ViewData["to7"] = "Encuentre equilibrio y disfrute hoy.";
                ViewData["to8"] = "Susan Seidman es una adiestradora certificada de Oasis, quien ofrece programas de certificación en persona y en línea, tanto en español como en inglés.";
                ViewData["to9"] = "Las estrategias de Oasis de 60 segundos son un kit para dar un impulso y lograr sanidad en todos los sectores de la vida.";
                ViewData["to10"] = "Cuatro estrategias probadas para cambiar su cerebro y su vida en menos de un minuto.";
                ViewData["to11"] = "Son estrategias diarias sencillas, prácticas y fáciles de aprender.";
                ViewData["to12"] = "Honestamente toman sólo 60 segundos cada una.";
                ViewData["to13"] = "Son una vía rápida para volver a alambrar su cerebro del caos a la calma. ";
                ViewData["to14"] = "Son herramientas prácticas de Mindfulness para fortalecer su mente, cuerpo y espíritu.";
                ViewData["to15"] = "Las estrategias de 60 segundos de OASIS le enseñan cómo navegar las pequeñas olas de la vida y los grandes tsunamis para disfrutar de una mayor salud y felicidad en su vida.";
                ViewData["to16"] = "Aprenda a usar la neuroplasticidad de su propio cerebro.";
                ViewData["to17"] = "Conviértase en el CEO de su propia vida.";
                ViewData["to18"] = "La esencia de OASIS no es eliminar el estrés. Más bien, es ayudarnos a interactuar conscientemente - y con claridad - con lo que está en nuestro plato.";
                ViewData["to19"] = "Todos tenemos estrés. La buena noticia: no necesitamos ser víctimas indefensas. La manera como respondemos al estrés hace toda la diferencia.";
                ViewData["to20"] = "¿POR QUÉ ESPERAR? ¡Dése un OASIS ahora!";
                ViewData["to21"] = "Este curso también ofrece a los coaches las siguientes horas de educación continua:";
                ViewData["to22"] = "Competencias básicas - 7.38 horas";
                ViewData["to23"] = "Desarrollo de Recursos - 4.62 horas";
                ViewData["to24"] = "Para obtener información adicional, visite: ";
                ViewData["to25"] = "http://www.milliegrenough.com/oasis-training/oasis-trainers/";
                //espiritual
                ViewData["te1"] = "Esta certificación se concentra en el SER ESPIRITUAL, y sus posibilidades infinitas de felicidad y conexión que llevan a la paz interior y la plenitud de la vida. Hace un recorrido por los temas del coaching de vida, desde una perspectiva holística. Además, explora a profundidad la espiritualidad humana desde el liderazgo espiritual como fuente de inspiración, motivación y conexión con diversos contextos familiares, sociales y laborales. Todo ello permite al participante contar con herramientas de vanguardia con las que se podrá desempeñar como coach espiritual en su entorno en diversos nichos de mercado.";
                ViewData["te2"] = "La humanidad está retornando a la Fuente, lo que impulsa los propósitos superiores de las personas. Este programa es un camino de descubrimiento interno; un proceso de interiorización sustentado en herramientas de autocoaching.";
                ViewData["te3"] = "VISIÓN GENERAL DE NUESTROS PROGRAMAS";
                ViewData["te4"] = "Nuestros programas se concentran en traer un estado de equilibrio y bienestar a la profesión de coaching, tanto para el coach como para el coachee, basados en la creencia fundamental de que la transformación global depende de nuestra comprensión del balance, del liderazgo de 'todo el cerebro', de la inteligencia emocional, y de la unificación de los valores mediante la acción.";
                ViewData["te5"] = "Nuestro objetivo es inspirar y capacitar profesionalmente a coaches auténticos, empoderados, compasivos y eficaces, que no sólo cumplen con las normas de ética y conducta definidas por la ICF, sino que viven estas normas en su esencia.";
                ViewData["te6"] = "FILOSOFÍA O ACERCAMIENTO DE COACHING";
                ViewData["te7"] = "Nuestros programas han sido diseñados bajo un enfoque holístico que busca elevar la consciencia de coaches y coachees sobre la conexión entre el cuerpo, la mente, las emociones y el espíritu, y su efecto en la vida. Nuestra metodología se fundamenta en una filosofía ontológica, dirigida a la reflexión e introspección para generar nuevos modelos de pensamiento y nuevos comportamientos que estén alineados al logro de las metas trabajadas en coaching. Nuestra metodología de coaching además integra una vertiente biológica y utiliza el conocimiento sobre el funcionamiento del cerebro y su relevancia para el proceso de coaching.";
                ViewData["te8"] = "En resumen, utilizamos un enfoque integral y ontológico para resaltar la importancia de ir más allá del trabajo externo de establecer metas e implementar planes de acción, y profundizar en los procesos internos que permitan a los coachees conocerse mejor y utilizar esta información para moverse hacia el logro de sus metas.";
                ViewData["te9"] = "METODOLOGÍA";
                ViewData["te10"] = "Se presenta en metodología Blended (Mixto: presencial - en línea), la cual incluye tres (3) inmersiones presenciales de 20 horas cada una (en fines de semana completos de dos días) con intervalos de 2 a 3 meses entre cada encuentro. El total de horas de trabajo durante el proceso de formación son 128.";
                ViewData["te11"] = "Este programa también se desarrolla 100% en línea con tele-clases en vivo semanales.";
                ViewData["te12"] = "Los temas de exploración en el proceso son los siguientes:";
                ViewData["te13"] = "INMERSIÓN 1:";
                ViewData["te14"] = "Coaching de vida (20 horas)";
                ViewData["te15"] = "INMERSIÓN 2:";
                ViewData["te16"] = "Coaching espiritual (20 horas)";
                ViewData["te17"] = "INMERSIÓN 3:";
                ViewData["te18"] = "Mercadeo desde una perspectiva espiritual (20 horas)";
                ViewData["te19"] = "ACTIVIDADES VIRTUALES";
                ViewData["te20"] = "Se trabajan 68 horas distribuidas así:";
                ViewData["te21"] = "Cinco (5) tele-clases/laboratorios de práctica de 2 horas cada una para un total de 10 horas";
                ViewData["te22"] = "Dos (2) Mentorías grupales de 2 horas cada una para un total de 4 horas";
                ViewData["te23"] = "Seis (6) Mentorías individuales de 1 hora cada una (aprox.) para un total de 6 horas";
                ViewData["te24"] = "Prácticas individuales y grupales en un total de 48 horas. Pares: 32 horas, grupales: 16";
                ViewData["te25"] = "OBJETIVOS DE APRENDIZAJE";
                ViewData["te26"] = "Al final del Programa, los participantes habrán desarrollado los conocimientos, las destrezas y habilidades requeridas para:";
                ViewData["te27"] = "Aplicar las destrezas de coaching puro con un acercamiento espiritual que movilizan a los clientes hacia el éxito y el cumplimiento de metas espirituales.";
                ViewData["te28"] = "Abordar el SER desde su propia grandeza y potencial, reconociendo que esta grandeza reside en todos.";
                ViewData["te29"] = "Identificar los elementos vinculados a diversas agendas de carácter espiritual en los coachees, y la diferencia entre la agenda interna (motivación) y la agenda externa (acción) para apoyar la concienciación y el aprendizaje espiritual. ";
                ViewData["te30"] = "Trabajar efectivamente con personas en diversas agendas espirituales para que alcancen sus metas y sueños en términos de una conexión - interna y externa - más profunda.";
                ViewData["te31"] = "Ejercer la profesión de Coaching espiritual en diversos nichos de mercado.";
                ViewData["te32"] = "FECHAS DE LOS PRÓXIMOS PROGRAMAS";
                ViewData["te33"] = "Escríbenos a contacto@coachingforwellness.com para recibir el detalle de fechas en tu área.";
                ViewData["te34"] = "IDIOMAS EN LOS QUE SE OFRECE EL PROGRAMA";
                ViewData["te35"] = "El Programa se ofrece en español e inglés en varios países de Latinoamérica y en Estados Unidos.";
                ViewData["te36"] = "¿A QUIÉN ESTÁ DIRIGIDO ESTE PROGRAMA?";
                ViewData["te37"] = "El Programa está dirigido a personas de 21 años en adelante, que se identifiquen con la visión del coaching como un vehículo para la transformación de individuos desde el enfoque espiritual. Se recomienda este Programa para quienes deseen una carrera como coach de vida y espiritual; y para aquellas personas que deseen un cambio profundo en sus propias vidas y en sus relaciones a partir de los principios de la paz interior.";
                ViewData["te38"] = "DURACIÓN DEL PROGRAMA";
                ViewData["te39"] = "La duración del proceso de formación está estimada en 6 meses.";
                ViewData["te40"] = "La certificación está alineada al código de ética y las competencias centrales de la International Coach Federation (ICF). Además, brinda los requisitos necesarios para solicitar la acreditación ACC (Associate Certified Coach) en la ICF, luego de culminado el proceso con CFW y luego de haber completado el total de horas de experiencia requeridas por la ICF. ";
                ViewData["te41"] = "Escríbenos a info@coachingforwellness.com para conocer más detalles sobre este programa. ";
                //bienestar
                ViewData["tb1"] = "Esta certificación se concentra en el SER, y sus posibilidades infinitas de prosperidad y bienestar a todos los niveles. Hace un recorrido por todos los temas del coaching de vida, desde una perspectiva holística, lo que permite al participante contar con herramientas de vanguardia con las que se podrá desempeñar como coach de vida en su entorno en diversos nichos de mercado.";
                ViewData["tb2"] = "VISIÓN GENERAL DE NUESTROS PROGRAMAS";
                ViewData["tb3"] = "Nuestros programas se concentran en traer un estado de equilibrio y bienestar a la profesión de coaching, tanto para el coach como para el coachee, basados en la creencia fundamental de que la transformación global depende de nuestra comprensión del balance, del liderazgo de 'todo el cerebro', de la inteligencia emocional, y de la unificación de los valores mediante la acción.";
                ViewData["tb4"] = "Nuestro objetivo es inspirar y capacitar profesionalmente a coaches auténticos, empoderados, compasivos y eficaces, que no sólo cumplen con las normas de ética y conducta definidas por la ICF, sino que viven estas normas en su esencia.";
                ViewData["tb5"] = "FILOSOFÍA O ACERCAMIENTO DE COACHING";
                ViewData["tb6"] = "Nuestros programas han sido diseñados bajo un enfoque holístico que busca elevar la consciencia de coaches y coachees sobre la conexión entre el cuerpo, la mente, las emociones y el espíritu, y su efecto en la vida. Nuestra metodología se fundamenta en una filosofía ontológica, dirigida a la reflexión e introspección para generar nuevos modelos de pensamiento y nuevos comportamientos que estén alineados al logro de las metas trabajadas en coaching. Nuestra metodología de coaching además integra una vertiente biológica y utiliza el conocimiento sobre el funcionamiento del cerebro y su relevancia para el proceso de coaching.";
                ViewData["tb7"] = "En resumen, utilizamos un enfoque integral y ontológico para resaltar la importancia de ir más allá del trabajo externo de establecer metas e implementar planes de acción, y profundizar en los procesos internos que permitan a los coachees conocerse mejor y utilizar esta información para moverse hacia el logro de sus metas.";
                ViewData["tb8"] = "METODOLOGÍA";
                ViewData["tb9"] = "Se presenta en metodología Blended (Mixto: presencial - en línea), la cual incluye tres (3) inmersiones presenciales de 20 horas cada una (en fines de semana completos de dos días) con intervalos de 2 a 3 meses entre cada encuentro. El total de horas de trabajo durante el proceso de formación son 128.";
                ViewData["tb10"] = "Este programa también se desarrolla 100% en línea con tele-clases en vivo semanales.";
                ViewData["tb11"] = "Los temas de exploración en el proceso son los siguientes:";
                ViewData["tb12"] = "INMERSIÓN 1:";
                ViewData["tb13"] = "Coaching de vida (20 horas)";
                ViewData["tb14"] = "INMERSIÓN 2:";
                ViewData["tb15"] = "Coaching de bienestar (20 horas)";
                ViewData["tb16"] = "INMERSIÓN 3:";
                ViewData["tb17"] = "Coaching de relaciones y mercadeo (20 horas)";
                ViewData["tb18"] = "ACTIVIDADES VIRTUALES";
                ViewData["tb20"] = "Cinco (5) tele-clases/laboratorios de práctica de 2 horas cada una para un total de 10 horas";
                ViewData["tb21"] = "Dos (2) Mentorías grupales de 2 horas cada una para un total de 4 horas";
                ViewData["tb22"] = "Seis (6) Mentorías individuales de 1 hora cada una para un total de 6 horas";
                ViewData["tb23"] = "Prácticas individuales y grupales en un total de 48 horas. Pares: 32 horas, grupales: 16";
                ViewData["tb24"] = "OBJETIVOS DE APRENDIZAJE";
                ViewData["tb25"] = "Al final del Programa, los participantes habrán desarrollado los conocimientos, las destrezas y habilidades requeridas para:";
                ViewData["tb26"] = "Aplicar las destrezas de coaching puro que mueven a los clientes hacia el éxito y el cumplimiento de metas.";
                ViewData["tb27"] = "Abordar el SER desde su propia grandeza y potencial, reconociendo que esta grandeza reside en todos.";
                ViewData["tb28"] = "Identificar la diferencia entre la agenda interna (motivación) y la agenda externa (acción) para apoyar la concienciación y el aprendizaje del coachee.";
                ViewData["tb29"] = "Trabajar efectivamente con personas en diversas agendas de VIDA para que alcancen las metas y sueños que desean lograr. ";
                ViewData["tb30"] = "Ejercer la profesión de Coaching de vida en diversos nichos de mercado.";
                ViewData["tb31"] = "FECHAS DE LOS PRÓXIMOS PROGRAMAS";
                ViewData["tb32"] = "Escríbenos a contacto@coachingforwellness.com para recibir el detalle de fechas en tu área.";
                ViewData["tb33"] = "IDIOMAS EN LOS QUE SE OFRECE EL PROGRAMA";
                ViewData["tb34"] = "El Programa se ofrece en español e inglés en varios países de Latinoamérica y en Estados Unidos.";
                ViewData["tb35"] = "¿A QUIÉN ESTÁ DIRIGIDO ESTE PROGRAMA?";
                ViewData["tb36"] = "El Programa está dirigido a personas de 21 años en adelante, que se identifiquen con la visión del coaching como un vehículo para la transformación de individuos. Se recomienda este Programa para quienes deseen una carrera como coach de vida y bienestar; líderes sociales; y para aquellas personas que deseen un cambio profundo en sus propias vidas y en sus relaciones a partir de los principios de la abundancia y el bienestar.";
                ViewData["tb37"] = "DURACIÓN DEL PROGRAMA";
                ViewData["tb38"] = "La duración del proceso de formación está estimada en 6 meses.";
                ViewData["tb39"] = "La certificación está alineada al código de ética y las competencias centrales de la International Coach Federation (ICF). Además, brinda los requisitos necesarios para solicitar la acreditación ACC (Associate Certified Coach) en la ICF, luego de culminado el proceso con CFW y luego de haber completado el total de horas de experiencia requeridas por la ICF. ";
                ViewData["tb40"] = "Escríbenos a info@coachingforwellness.com para conocer más detalles sobre este programa. ";

                //nivel asociado
                ViewData["ta1"] = "Esta certificación hace un recorrido por los temas de mayor importancia en la profesión del Coaching, enfocada en elementos equilibrados entre la vida y la empresa (con énfasis en cultura organizacional y coaching ejecutivo), lo que permite al participante contar con herramientas de vanguardia con las que se podrá desempeñar como coach en diversos nichos de mercado. ";
                ViewData["ta2"] = "VISIÓN GENERAL DE NUESTROS PROGRAMAS";
                ViewData["ta3"] = "Nuestros programas se concentran en traer un estado de equilibrio y bienestar a la profesión de coaching, tanto para el coach como para el coachee, basados en la creencia fundamental de que la transformación global depende de nuestra comprensión del balance, del liderazgo de 'todo el cerebro', de la inteligencia emocional, y de la unificación de los valores mediante la acción.";
                ViewData["ta4"] = "Nuestro objetivo es inspirar y capacitar profesionalmente a coaches auténticos, empoderados, compasivos y eficaces, que no sólo cumplen con las normas de ética y conducta definidas por la ICF, sino que viven estas normas en su esencia.";
                ViewData["ta5"] = "FILOSOFÍA O ACERCAMIENTO DE COACHING";
                ViewData["ta6"] = "Nuestros programas han sido diseñados bajo un enfoque holístico que busca elevar la consciencia de coaches y coachees sobre la conexión entre el cuerpo, la mente, las emociones y el espíritu, y su efecto en la vida. Nuestra metodología se fundamenta en una filosofía ontológica, dirigida a la reflexión e introspección para generar nuevos modelos de pensamiento y nuevos comportamientos que estén alineados al logro de las metas trabajadas en coaching. Nuestra metodología de coaching además integra una vertiente biológica y utiliza el conocimiento sobre el funcionamiento del cerebro y su relevancia para el proceso de coaching.";
                ViewData["ta7"] = "En resumen, utilizamos un enfoque integral y ontológico para resaltar la importancia de ir más allá del trabajo externo de establecer metas e implementar planes de acción, y profundizar en los procesos internos que permitan a los coachees conocerse mejor y utilizar esta información para moverse hacia el logro de sus metas.";
                ViewData["ta8"] = "METODOLOGÍA";
                ViewData["ta9"] = "Se presenta en metodología Blended (Mixto: presencial – en línea), la cual incluye tres (3) inmersiones presenciales de 20 horas cada una (en fines de semana completos de dos días) con intervalos de 2 a 3 meses entre cada encuentro. El total de horas de trabajo durante el proceso de formación son 128.";
                ViewData["ta10"] = "Este programa también se desarrolla 100% en línea con tele-clases en vivo semanales..";
                ViewData["ta11"] = "Los temas de exploración en el proceso son los siguientes";
                ViewData["ta12"] = "INMERSIÓN 1:";
                ViewData["ta13"] = "Coaching de vida (20 horas)";
                ViewData["ta14"] = "INMERSIÓN 2:";
                ViewData["ta15"] = "Coaching empresarial (con énfasis en cultura organizacional y coaching ejecutivo; 20 horas)";
                ViewData["ta16"] = "INMERSIÓN 3:";
                ViewData["ta17"] = "Mercadeo para coaching (20 horas)";
                ViewData["ta18"] = "ACTIVIDADES VIRTUALES";
                ViewData["ta19"] = "Se trabajan 68 horas distribuidas así:";
                ViewData["ta20"] = "Cinco (5) tele-clases/laboratorios de práctica de 2 horas cada una para un total de 10 horas";
                ViewData["ta21"] = "Dos (2) Mentorías grupales de 2 horas cada una para un total de 4 horas";
                ViewData["ta22"] = "Seis (6) Mentorías individuales de 1 hora cada una (aprox.) para un total de 6 horas";
                ViewData["ta23"] = "Prácticas individuales y grupales en un total de 48 horas. Pares: 32 horas, grupales: 16";
                ViewData["ta24"] = "OBJETIVOS DE APRENDIZAJE";
                ViewData["ta25"] = "Al final del Programa, los participantes habrán desarrollado los conocimientos, las destrezas y habilidades requeridas para:";
                ViewData["ta26"] = "Aplicar las destrezas de coaching puro que mueven a los clientes hacia el éxito y el cumplimiento de metas.";
                ViewData["ta27"] = "Maximizar competencias de liderazgo en diversos contextos personales y sociales.";
                ViewData["ta28"] = "Identificar la diferencia entre la agenda interna (motivación) y la agenda externa (acción) para apoyar la concienciación y el aprendizaje del coachee. ";
                ViewData["ta29"] = "Crear e implementar programas para transformar culturas corporativas en culturas de coaching.";
                ViewData["ta30"] = "Trabajar efectivamente con ejecutivos para mejorar rendimiento y alcanzar las metas en su cargo.";
                ViewData["ta31"] = "Mercadear efectivamente sus servicios de coaching.";
                ViewData["ta32"] = "Ejercer la profesión de Coaching en diversos nichos de mercado.";
                ViewData["ta33"] = "FECHAS DE LOS PRÓXIMOS PROGRAMAS";
                ViewData["ta34"] = "Escríbenos a contacto@coachingforwellness.com para recibir el detalle de fechas en tu área.";
                ViewData["ta35"] = "IDIOMAS EN LOS QUE SE OFRECE EL PROGRAMA";
                ViewData["ta36"] = "El Programa se ofrece en español e inglés en varios países de Latinoamérica y en Estados Unidos.";
                ViewData["ta37"] = "¿A QUIÉN ESTÁ DIRIGIDO ESTE PROGRAMA?";
                ViewData["ta38"] = "El Programa está dirigido a personas de 21 años en adelante, que se identifiquen con la visión del coaching como un vehículo para la transformación de individuos y organizaciones. Se recomienda este Programa para quienes deseen una carrera como coach de vida y empresarial; líderes de organizaciones empresariales y sociales; directores de recursos humanos, gerentes, empresarios y emprendedores.";
                ViewData["ta39"] = "DURACIÓN DEL PROGRAMA";
                ViewData["ta40"] = "La duración del proceso de formación está estimada en 6 meses.";
                ViewData["ta41"] = "La certificación está alineada al código de ética y las competencias centrales de la International Coach Federation (ICF). Además, brinda los requisitos necesarios para solicitar la acreditación ACC (Associate Certified Coach) en la ICF, luego de culminado el proceso con CFW y luego de haber completado el total de horas de experiencia requeridas por la ICF. ";
                ViewData["ta42"] = "Escríbenos a info@coachingforwellness.com para conocer más detalles sobre este programa. ";
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
                ViewData["t2Ser"] = "ONE-ON-ONE";
                ViewData["t2Serc"] = "COACHING";
                ViewData["t3Ser"] = "We offer individual services in";
                ViewData["t4Ser"] = "Life Coaching";
                ViewData["t5Ser"] = "Executive and Business Coaching(e.g., teams, sales)";
                ViewData["t6Ser"] = "Relationship Coaching";
                ViewData["t7Ser"] = "Wellness Coaching";
                ViewData["t8Ser"] = "Spiritual Coaching";
                ViewData["t9Ser"] = "Contact us for additional information regarding our services.";
                ViewData["t10Ser"] = "WEBINARS";
                ViewData["t10Serl"] = "";
                ViewData["t11Ser"] = "We offer online seminars about diverse topics, geared towards:";
                ViewData["t12Ser"] = "People interested in learning more about coaching and being coached";
                ViewData["t13Ser"] = "People interested in becoming certified coaches";
                ViewData["t14Ser"] = "Certified coaches";
                ViewData["t15Ser"] = "General public";
                ViewData["t16Ser"] = "Contact us for additional information regarding our webinars.";
                ViewData["t17Ser"] = "MENTORING FOR";
                ViewData["t17Serco"] = "COACHES";
                ViewData["t18Ser"] = "Geared toward coaches seeking to improve their coaching skills, or coaches interested in complying with the mentoring requirements for ICF credentials.";
                ViewData["t18Seru"] = "Contact us for additional information regarding our program.";
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";
                //variables de servicios
                ViewData["t1Ser"] = "SERVICIOS";
                ViewData["t2Ser"] = "COACHING";
                ViewData["t2Serc"] = "INDIVIDUAL";
                ViewData["t3Ser"] = "Ofrecemos servicios individualizados de coaching:";
                ViewData["t4Ser"] = "Coaching de vida";
                ViewData["t5Ser"] = "Coaching ejecutivo y de negocios (Ej., equipos, ventas)";
                ViewData["t6Ser"] = "Coaching de relaciones";
                ViewData["t7Ser"] = "Coaching de bienestar";
                ViewData["t8Ser"] = "Coaching espiritual";
                ViewData["t9Ser"] = "Contáctenos para información adicional sobre nuestros servicios.";
                ViewData["t10Ser"] = "CHARLAS EN";
                ViewData["t10Serl"] = "LÍNEA";
                ViewData["t11Ser"] = "Ofrecemos charlas virtuales (webinars) sobre diversos temas para:";
                ViewData["t12Ser"] = "Interesados en conocer más información sobre coaching y/o recibir servicios de coaching";
                ViewData["t13Ser"] = "Interesados en formarse como coaches";
                ViewData["t14Ser"] = "Coaches certificados";
                ViewData["t15Ser"] = "Público en general";
                ViewData["t16Ser"] = "Contáctenos para información adicional sobre nuestras charlas y otros eventos.";
                ViewData["t17Ser"] = "MENTORIAS PARA";
                ViewData["t17Serco"] = "COACHES";
                ViewData["t18Ser"] = "Ofrecemos servicios individualizados y grupales de mentoría en coaching dirigidos a coaches en formación y/o certificados que deseen mejorar sus destrezas de coaching, o para coaches interesados en cumplir con el requisito de mentorías  que les permita solicitar credenciales ante la ICF.";
                ViewData["t18Seru"] = "Contáctenos para información adicional sobre nuestros programa";
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
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";
            }

            return View();
        }

        public ActionResult PagosPayPal() {
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
            }
            //texto en el idioma español
            else
            {
                //footer
                ViewData["derechos_index"] = "TODOS LOS DERECHOS RESERVADOS - COACHING FOR WELLNESS 2017";
                ViewData["contactanos_index"] = "CONTÁCTANOS";
                //variables de vabvar
                ViewData["aboutUs_link"] = "SOBRE NOSOTROS";
                ViewData["certi_link"] = "CERTIFICACIONES";
                ViewData["servi_link"] = "SERVICIOS";
                ViewData["contact_link"] = "CONTÁCTANOS";
            }

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