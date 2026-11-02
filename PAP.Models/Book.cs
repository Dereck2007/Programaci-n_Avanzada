using System;

namespace PAP.Models
{
    public class Book2 : Entity
    {
        private string _internalCode;
        public Book2()
        {
            _internalCode = Guid.NewGuid().ToString();
        }

        public string InternalCode { get { return _internalCode; } }
        public string Category { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public decimal Price { get; set; }
        public bool IsBestSeller { get; set; }
        public string Genre { get; set; }
        public bool IsInStock { get; set; }
    }
}
