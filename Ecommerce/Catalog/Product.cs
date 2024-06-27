namespace Catalog
{
    public class Product
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public double UnitPrice { get; set; }
        public Product() { }

        public Product(int Id,string title,double UnitPrice) { this.Id = Id; this.Title = title;this.UnitPrice = UnitPrice; }

        public override string ToString()
        {
            return "ID -> "+this.Id+"  Title -> "+this.Title+"  UnitPrice -> "+this.UnitPrice;
        }

    }
}
