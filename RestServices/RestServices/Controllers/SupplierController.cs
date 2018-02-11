using RestServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RestServices.Controllers
{
    public class SupplierController : Controller
    {
        FactoryEntities db = new FactoryEntities();
        
        // GET: Supplier/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Supplier suplier = await db.Supplier.FindAsync(id);            

            if (suplier == null)
            {
                return HttpNotFound();
            }

            SupplierDTO suplierDTO = new SupplierDTO()
            {
                Id = suplier.Id,
                City = suplier.City,
                CompanyName = suplier.CompanyName,
                ContactName = suplier.ContactName,
                ContactTitle = suplier.ContactTitle,
                Country = suplier.Country,
                Fax = suplier.Fax,
                Phone = suplier.Phone
            };

            return View(suplierDTO);
        }
    }
}