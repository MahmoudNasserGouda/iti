using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModel;

namespace WebApplication1
{
    public class ProductsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Products
        [HttpGet]
        public ActionResult Index()
        {
            List<ProductViewModel> products = new List<ProductViewModel>();
            foreach (var item in db.Product)
            {
                var productvm = new ProductViewModel();
                productvm.ID = item.ID;
                productvm.Name = item.Name;
                productvm.Category = db.Category.Find(item.CategoryID).Name;
                productvm.Supplier = db.Supplier.Find(item.SupplierID).Name;
                productvm.Price = item.Price;
                products.Add(productvm);
            }

            return View(products);
        }

        // GET: Products/Details/5
        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product p = db.Product.Where(sp =>  sp.ID == id).FirstOrDefault();
            ProductViewModel product = new ProductViewModel() 
            { 
                ID = p.ID,
                Name = p.Name,
                Price = p.Price,
                Category = db.Category.Find(p.CategoryID).Name,
                Supplier = db.Supplier.Find(p.SupplierID).Name
            };
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Product.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // GET: Products/Edit/5
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name", product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Supplier, "ID", "Name", product.SupplierID);
            return View(product);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "ID,Name,CategoryID,SupplierID,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Category, "ID", "Name", product.CategoryID);
            ViewBag.SupplierID = new SelectList(db.Supplier, "ID", "Name", product.SupplierID);
            return View(product);
        }

        // GET: Products/Delete/5
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = db.Product.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            db.Product.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
