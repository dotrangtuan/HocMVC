using App.Models;

public class ProductServices {
    public List<ProductModel>? Products = new List<ProductModel>();

    public ProductServices() {
        Products!.AddRange(new ProductModel[] {
            new ProductModel() {Id = 1, Name = "Iphone 15", Price = 200000},
            new ProductModel() {Id = 2, Name = "Iphone 15 Plus", Price = 2000111},
            new ProductModel() {Id = 3, Name = "Iphone 15 ", Price = 2000111},
            new ProductModel() {Id = 4, Name = "Iphone 15 Pro Max", Price = 2000111},
        });
    }
}