
using PAP.Business;
using PAP.DataAccess;
using PAP.Mvc.ModelBinders;
using System;
using System.Linq;
using System.Web.Mvc;

namespace PAP.Mvc.Controllers
{
    [RoutePrefix("biblioteca")]
    public class LibraryController : Controller
    {
        private readonly BookManager _bookManager;

        public LibraryController()
        {
            _bookManager = new BookManager();
        }

        public ActionResult Index()
        {
            return View(_bookManager.GetAll());
        }

        public ActionResult Catalog(string vista)
        {
            var books = _bookManager.GetAll();

            if (string.Equals(vista, "cards",
                StringComparison.OrdinalIgnoreCase))
            {
                return View("Cards", books);
            }

            return View("Index", books);
        }

        [Route("detalle/{id:int}")]
        public ActionResult Details(int id)
        {
            var book = _bookManager.GetById(id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

        [HttpGet]
        [Route("crear")]
        public ActionResult Create()
        {
            return View(new Book
            {
                PublicationDate = DateTime.Today,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                IsInStock = true
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("crear")]
        public ActionResult Create(Book book)
        {
            if (!ModelState.IsValid)
                return View(book);

            _bookManager.Add(book);

            TempData["Mensaje"] = "Libro creado correctamente.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var book = _bookManager.GetById(id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            if (!ModelState.IsValid)
                return View(book);

            var existing = _bookManager.GetById(book.Id);

            if (existing == null)
                return HttpNotFound();

            existing.Name = book.Name;
            existing.Title = book.Title;
            existing.Category = book.Category;
            existing.Publisher = book.Publisher;
            existing.Author = book.Author;
            existing.Description = book.Description;
            existing.PublicationDate = book.PublicationDate;
            existing.Height = book.Height;
            existing.Width = book.Width;
            existing.Price = book.Price;
            existing.IsBestSeller = book.IsBestSeller;
            existing.Genre = book.Genre;
            existing.IsInStock = book.IsInStock;
            existing.PublisherId = book.PublisherId;
            existing.CategoryId = book.CategoryId;
            existing.GenreId = book.GenreId;
            existing.ISBN = book.ISBN;
            existing.Pages = book.Pages;
            existing.Language = book.Language;
            existing.CoverImageUrl = book.CoverImageUrl;

            _bookManager.Update(existing);

            TempData["Mensaje"] = "Libro actualizado correctamente.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var book = _bookManager.GetById(id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var book = _bookManager.GetById(id);

            if (book == null)
                return HttpNotFound();

            _bookManager.Delete(id);

            TempData["Mensaje"] = "Libro eliminado correctamente.";
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("precio")]
        public ActionResult PrecioDemo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("precio")]
        public ActionResult PrecioDemo(
            [ModelBinder(typeof(CurrencyModelBinder))] decimal precio)
        {
            ViewBag.PrecioConvertido = precio;
            ModelState.Values.ToList().ForEach(
                x => ViewBag.Errors += string.Join(",", x.Errors));

            return View();
        }
    }
}
