using Encaptulation.Entity;
using Encaptulation.Interface;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("Laptop",99,10);

        //access public property
        Console.WriteLine($"Product Name: {product.Name}");

        Console.WriteLine($"Product Stock Quantity: {product.GetStockQuantity()}");


        ICircle circle = new Circle();
        circle.Radious = 10;
        circle.Draw();

        // Create a rectangle object
        IRectangle rectangle = new Rectangle();
        rectangle.Leangth = 6;
        rectangle.Width = 4;
        rectangle.Draw();


    }
}