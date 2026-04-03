using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace SupplyHub.Web.Texts;

public static class UiTexts
{
    public const string AppName = "SupplyHub";
    public const string AppDescription = "Inventory and stock management demo built with ASP.NET Core MVC";
    public const string Home = "Home";

    public const string Index = "Index";
    public const string Details = "Details";
    public const string Edit = "Edit";
    public const string Delete = "Delete";
    public const string Cancel = "Cancel";
    public const string ConfirmDeletion = "Confirm deletion";
    public const string BackToList = "Back to list";

    // Home
    public const string HomeTitle = "Home Page";

    // Categories
    public const string Categories = "Categories";
    public const string Category = "Category";
    public const string CreateCategory = "Create Category";
    public const string NewCategory = "New category";
    public const string CategoriesCardDescription = "Create and mantain product categories";
    public const string CategoriesCardButtonText = "Go to categories";
    public const string SearchCategoryPlaceholder = "Search category...";
    public const string NoCategoriesFound = "No categories found";

    // Products
    public const string Products = "Products";
    public const string Product = "Product";
    public const string CreateProduct = "Create Product";
    public const string NewProduct = "New product";
    public const string ProductsCardDescription = "View and edit product information and stock";
    public const string ProductsCardButtonText = "Go to products";
    public const string SearchProductPlaceholder = "Search product...";
    public const string NoProductsFound = "No products found";

    // Suppliers
    public const string Suppliers = "Suppliers";
    public const string Supplier = "Supplier";
    public const string CreateSupplier = "Create Supplier";
    public const string NewSupplier = "New supplier";
    public const string SuppliersCardDescription = "Store and update supplier contact information";
    public const string SuppliersCardButtonText = "Go to suppliers";
    public const string SearchSupplierPlaceholder = "Search supplier...";
    public const string NoSuppliersFound = "No suppliers found";

    // Stock Movements
    public const string StockMovements = "Stock Movements";
    public const string StockMovementsCardDescription = "Track incoming and outgoing stock movements";
    public const string StockMovementsCardButtonText = "Go to movements";
}
