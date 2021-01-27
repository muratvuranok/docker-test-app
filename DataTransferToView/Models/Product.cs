using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataTransferToView.Models
{
    public class Product
    {
        [Display(Name = "Ürün ID")]
        public int ProductID { get; set; } 
        [Display(Name ="Ürün Adı")]
        public string ProductName { get; set; } 
        [Display(Name = "Ürün Fiyat")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Ürün Stok Adet")]
        public short UnitsInstock { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryID { get; set; }

        public static List<Product> ProductList
        {
            get
            {
                return new List<Product>
                {
                    new Product { ProductID = 1,  ProductName = "Alice Mutton",                    UnitPrice = 18.00M,  UnitsInstock = 39,  CategoryID = 1},
                    new Product { ProductID = 2,  ProductName = "Aniseed Syrup",                   UnitPrice = 19.00M,  UnitsInstock = 17,  CategoryID = 1},
                    new Product { ProductID = 3,  ProductName = "Boston Crab Meat",                UnitPrice = 10.00M,  UnitsInstock = 13,  CategoryID = 1},
                    new Product { ProductID = 4,  ProductName = "Camembert Pierrot",               UnitPrice = 22.00M,  UnitsInstock = 53,  CategoryID = 1},
                    new Product { ProductID = 5,  ProductName = "Carnarvon Tigers",                UnitPrice = 21.35M,  UnitsInstock = 0,   CategoryID = 1},
                    new Product { ProductID = 6,  ProductName = "Chai",                            UnitPrice = 25.00M,  UnitsInstock = 120, CategoryID = 1},
                    new Product { ProductID = 7,  ProductName = "Chang",                           UnitPrice = 30.00M,  UnitsInstock = 15,  CategoryID = 1},
                    new Product { ProductID = 8,  ProductName = "Chartreuse verte",                UnitPrice = 40.00M,  UnitsInstock = 6,   CategoryID = 1},
                    new Product { ProductID = 9,  ProductName = "Chef Anton's Cajun Seasoning",    UnitPrice = 97.00M,  UnitsInstock = 29,  CategoryID = 1},
                    new Product { ProductID = 10, ProductName = "Chef Anton's Gumbo Mix",          UnitPrice = 31.00M,  UnitsInstock = 31,  CategoryID = 1},
                    new Product { ProductID = 11, ProductName = "Chocolade",                       UnitPrice = 21.00M,  UnitsInstock = 22,  CategoryID = 1},
                    new Product { ProductID = 12, ProductName = "Côte de Blaye",                   UnitPrice = 38.00M,  UnitsInstock = 86,  CategoryID = 1},
                    new Product { ProductID = 13, ProductName = "Escargots de Bourgogne",          UnitPrice = 6.00M,   UnitsInstock = 24,  CategoryID = 2},
                    new Product { ProductID = 14, ProductName = "Filo Mix",                        UnitPrice = 23.25M,  UnitsInstock = 35,  CategoryID = 2},
                    new Product { ProductID = 15, ProductName = "Flotemysost",                     UnitPrice = 15.50M,  UnitsInstock = 39,  CategoryID = 2},
                    new Product { ProductID = 16, ProductName = "Geitost",                         UnitPrice = 17.45M,  UnitsInstock = 29,  CategoryID = 2},
                    new Product { ProductID = 17, ProductName = "Genen Shouyu",                    UnitPrice = 39.00M,  UnitsInstock = 0,   CategoryID = 2},
                    new Product { ProductID = 18, ProductName = "Gnocchi di nonna Alice ",         UnitPrice = 62.50M,  UnitsInstock = 42,  CategoryID = 2},
                    new Product { ProductID = 19, ProductName = "Gorgonzola Telino ",              UnitPrice = 9.20M,   UnitsInstock = 25,  CategoryID = 2},
                    new Product { ProductID = 20, ProductName = "Grandma's Boysenberry Spread  ",  UnitPrice = 81.00M,  UnitsInstock = 40,  CategoryID = 2},
                    new Product { ProductID = 21, ProductName = "Gravad lax",                      UnitPrice = 10.00M,  UnitsInstock = 3,   CategoryID = 2},
                    new Product { ProductID = 22, ProductName = "Guaraná Fantástica",              UnitPrice = 21.00M,  UnitsInstock = 104, CategoryID = 2},
                    new Product { ProductID = 23, ProductName = "Gudbrandsdalsost",                UnitPrice = 9.00M,   UnitsInstock = 61,  CategoryID = 2},
                    new Product { ProductID = 24, ProductName = "Gula Malacca",                    UnitPrice = 4.50M,   UnitsInstock = 20,  CategoryID = 2},
                    new Product { ProductID = 25, ProductName = "Gumbär Gummibärchen",             UnitPrice = 14.00M,  UnitsInstock = 76,  CategoryID = 3},
                    new Product { ProductID = 26, ProductName = "Gustaf's Knäckebröd",             UnitPrice = 31.23M,  UnitsInstock = 15,  CategoryID = 3},
                    new Product { ProductID = 27, ProductName = "Ikura",                           UnitPrice = 43.90M,  UnitsInstock = 49,  CategoryID = 3},
                    new Product { ProductID = 28, ProductName = "Inlagd Sill",                     UnitPrice = 45.60M,  UnitsInstock = 26,  CategoryID = 3},
                    new Product { ProductID = 29, ProductName = "Ipoh Coffee",                     UnitPrice = 123.79M, UnitsInstock = 0,   CategoryID = 3},
                    new Product { ProductID = 30, ProductName = "Jack's New England Clam Chowder", UnitPrice = 25.89M,  UnitsInstock = 10,  CategoryID = 3},
                    new Product { ProductID = 31, ProductName = "Konbu",                           UnitPrice = 12.50M,  UnitsInstock = 0,   CategoryID = 3},
                    new Product { ProductID = 32, ProductName = "Lakkalikööri",                    UnitPrice = 32.00M,  UnitsInstock = 9,   CategoryID = 3},
                    new Product { ProductID = 33, ProductName = "Laughing Lumberjack Lager",       UnitPrice = 2.50M,   UnitsInstock = 112, CategoryID = 3},
                    new Product { ProductID = 34, ProductName = "Longlife Tofu",                   UnitPrice = 14.00M,  UnitsInstock = 111, CategoryID = 3},
                    new Product { ProductID = 35, ProductName = "Louisiana Fiery Hot Pepper Sauc", UnitPrice = 18.00M,  UnitsInstock = 20,  CategoryID = 3},
                    new Product { ProductID = 36, ProductName = "Louisiana Hot Spiced Okra",       UnitPrice = 19.00M,  UnitsInstock = 112, CategoryID = 3},
                    new Product { ProductID = 37, ProductName = "Manjimup Dried Apples",           UnitPrice = 26.00M,  UnitsInstock = 11,  CategoryID = 3},
                    new Product { ProductID = 38, ProductName = "Mascarpone Fabioli",              UnitPrice = 263.50M, UnitsInstock = 17,  CategoryID = 4},
                    new Product { ProductID = 39, ProductName = "Maxilaku",                        UnitPrice = 18.00M,  UnitsInstock = 69,  CategoryID = 4},
                    new Product { ProductID = 40, ProductName = "Mishi Kobe Niku",                 UnitPrice = 18.40M,  UnitsInstock = 123, CategoryID = 4},
                    new Product { ProductID = 41, ProductName = "Mozzarella di Giovanni  ",        UnitPrice = 9.65M,   UnitsInstock = 85,  CategoryID = 4},
                    new Product { ProductID = 42, ProductName = "Nord-Ost Matjeshering   ",        UnitPrice = 14.00M,  UnitsInstock = 26,  CategoryID = 4},
                    new Product { ProductID = 43, ProductName = "Northwoods Cranberry Sauce",      UnitPrice = 46.00M,  UnitsInstock = 17,  CategoryID = 4},
                    new Product { ProductID = 44, ProductName = "NuNuCa Nuß-Nougat-Creme ",        UnitPrice = 19.45M,  UnitsInstock = 27,  CategoryID = 4},
                    new Product { ProductID = 45, ProductName = "Original Frankfurter grüne Soße", UnitPrice = 9.50M,   UnitsInstock = 5,   CategoryID = 4},
                    new Product { ProductID = 46, ProductName = "Outback Lager",                   UnitPrice = 12.00M,  UnitsInstock = 95,  CategoryID = 4},
                    new Product { ProductID = 47, ProductName = "Pâté chinois",                    UnitPrice = 9.50M,   UnitsInstock = 36,  CategoryID = 4},
                    new Product { ProductID = 48, ProductName = "Pavlova",                         UnitPrice = 12.75M,  UnitsInstock = 15,  CategoryID = 5},
                    new Product { ProductID = 49, ProductName = "Perth Pasties",                   UnitPrice = 20.00M,  UnitsInstock = 10,  CategoryID = 5},
                    new Product { ProductID = 50, ProductName = "Queso Cabrales",                  UnitPrice = 16.25M,  UnitsInstock = 65,  CategoryID = 5},
                    new Product { ProductID = 51, ProductName = "Queso Manchego La Pastora",       UnitPrice = 53.00M,  UnitsInstock = 20,  CategoryID = 5},
                    new Product { ProductID = 52, ProductName = "Raclette Courdavault",            UnitPrice = 7.00M,   UnitsInstock = 38,  CategoryID = 5},
                    new Product { ProductID = 53, ProductName = "Ravioli Angelo",                  UnitPrice = 32.80M,  UnitsInstock = 0,   CategoryID = 5},
                    new Product { ProductID = 54, ProductName = "Rhönbräu Klosterbier",            UnitPrice = 7.45M,   UnitsInstock = 21,  CategoryID = 5},
                    new Product { ProductID = 55, ProductName = "Röd Kaviar ",                     UnitPrice = 24.00M,  UnitsInstock = 115, CategoryID = 6},
                    new Product { ProductID = 56, ProductName = "Rogede sild",                     UnitPrice = 38.00M,  UnitsInstock = 21,  CategoryID = 6},
                    new Product { ProductID = 57, ProductName = "Rössle Sauerkraut ",              UnitPrice = 19.50M,  UnitsInstock = 36,  CategoryID = 6},
                    new Product { ProductID = 58, ProductName = "Sasquatch Ale",                   UnitPrice = 13.25M,  UnitsInstock = 62,  CategoryID = 6},
                    new Product { ProductID = 59, ProductName = "Schoggi Schokolade",              UnitPrice = 55.00M,  UnitsInstock = 79,  CategoryID = 6},
                    new Product { ProductID = 60, ProductName = "Scottish Longbreads",             UnitPrice = 34.00M,  UnitsInstock = 19,  CategoryID = 6},
                    new Product { ProductID = 61, ProductName = "Singaporean Hokkien Fried Mee ",  UnitPrice = 28.50M,  UnitsInstock = 113, CategoryID = 7},
                    new Product { ProductID = 62, ProductName = "Sir Rodney's Marmalade  ",        UnitPrice = 49.30M,  UnitsInstock = 17,  CategoryID = 7},
                    new Product { ProductID = 63, ProductName = "Sir Rodney's Scones",             UnitPrice = 43.90M,  UnitsInstock = 24,  CategoryID = 7},
                    new Product { ProductID = 64, ProductName = "Sirop d'érable",                  UnitPrice = 33.25M,  UnitsInstock = 22,  CategoryID = 7},
                    new Product { ProductID = 65, ProductName = "Spegesild  ",                     UnitPrice = 21.05M,  UnitsInstock = 76,  CategoryID = 7},
                    new Product { ProductID = 66, ProductName = "Steeleye Stout",                  UnitPrice = 17.00M,  UnitsInstock = 4,   CategoryID = 8},
                    new Product { ProductID = 67, ProductName = "Tarte au sucre",                  UnitPrice = 14.00M,  UnitsInstock = 52,  CategoryID = 8},
                    new Product { ProductID = 68, ProductName = "Teatime Chocolate Biscuits",      UnitPrice = 12.50M,  UnitsInstock = 6,   CategoryID = 8},
                    new Product { ProductID = 69, ProductName = "Thüringer Rostbratwurst ",        UnitPrice = 36.00M,  UnitsInstock = 26,  CategoryID = 8},
                    new Product { ProductID = 70, ProductName = "Tofu",                            UnitPrice = 15.00M,  UnitsInstock = 15,  CategoryID = 8},
                    new Product { ProductID = 71, ProductName = "Tourtière",                       UnitPrice = 21.50M,  UnitsInstock = 26,  CategoryID = 8},
                    new Product { ProductID = 72, ProductName = "Tunnbröd",                        UnitPrice = 34.80M,  UnitsInstock = 14,  CategoryID = 8},
                    new Product { ProductID = 73, ProductName = "Uncle Bob's Organic Dried Pears", UnitPrice = 15.00M,  UnitsInstock = 101, CategoryID = 8},
                    new Product { ProductID = 74, ProductName = "Valkoinen suklaa",                UnitPrice = 10.00M,  UnitsInstock = 4,   CategoryID = 8},
                    new Product { ProductID = 75, ProductName = "Vegie-spread",                    UnitPrice = 7.75M,   UnitsInstock = 125, CategoryID = 8},
                    new Product { ProductID = 76, ProductName = "Wimmers gute Semmelknödel",       UnitPrice = 18.00M,  UnitsInstock = 57,  CategoryID = 8},
                    new Product { ProductID = 77, ProductName = "Zaanse koeken",                   UnitPrice = 13.00M,  UnitsInstock = 32,  CategoryID = 8 }
               };
            }
        }
    }
}
