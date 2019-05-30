using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hjorringFurnitues.Web.Pages.Logic
{
    public class Product
    {
        private int id;
        private string url;
        private string header;
        private string shortDesc;
        private string longDesc;
        private DateTime productCreationDate;
        private double price;

        public Product(int id, string url, string header, string shortDesc, string longDesc, DateTime productCreationDate, double price)
        {
            Id = id;
            Url = url;
            Header = header;
            ShortDesc = shortDesc;
            LongDesc = longDesc;
            ProductCreationDate = productCreationDate;
            Price = price;
        }

        public int Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public string Header { get => header; set => header = value; }
        public string ShortDesc { get => shortDesc; set => shortDesc = value; }
        public string LongDesc { get => longDesc; set => longDesc = value; }
        public DateTime ProductCreationDate { get => productCreationDate; set => productCreationDate = value; }
        public double Price { get => price; set => price = value; }

        private string GetCsvString()
        {
            return $"{Id},{Url},{Header},{ShortDesc},{LongDesc},{ProductCreationDate},{Price}";
        }
    }
}
