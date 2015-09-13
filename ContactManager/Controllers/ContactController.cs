using System.Web.Mvc;
using ContactManager.Models;
using ContactManager.Services;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ContactRepository contactRepository;
        
        public ContactController()
        {
            this.contactRepository = new ContactRepository();
        }

        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }

        public Contact[] Get()
        {
            return contactRepository.GetAllContacts();
        }
    }
}