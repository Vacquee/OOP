using System;
using OOP;


class products
{
    public static (string, int, string) userInput()
    {
        Console.Write(@"


               ██████╗ ██████╗  ██████╗ ██████╗ ██╗   ██╗ ██████╗████████╗    ███╗   ███╗ █████╗ ███╗   ██╗ █████╗  ██████╗ ███████╗███╗   ███╗███████╗███╗   ██╗████████╗    ███████╗██╗   ██╗███████╗████████╗███████╗███╗   ███╗
               ██╔══██╗██╔══██╗██╔═══██╗██╔══██╗██║   ██║██╔════╝╚══██╔══╝    ████╗ ████║██╔══██╗████╗  ██║██╔══██╗██╔════╝ ██╔════╝████╗ ████║██╔════╝████╗  ██║╚══██╔══╝    ██╔════╝╚██╗ ██╔╝██╔════╝╚══██╔══╝██╔════╝████╗ ████║
               ██████╔╝██████╔╝██║   ██║██║  ██║██║   ██║██║        ██║       ██╔████╔██║███████║██╔██╗ ██║███████║██║  ███╗█████╗  ██╔████╔██║█████╗  ██╔██╗ ██║   ██║       ███████╗ ╚████╔╝ ███████╗   ██║   █████╗  ██╔████╔██║
               ██╔═══╝ ██╔══██╗██║   ██║██║  ██║██║   ██║██║        ██║       ██║╚██╔╝██║██╔══██║██║╚██╗██║██╔══██║██║   ██║██╔══╝  ██║╚██╔╝██║██╔══╝  ██║╚██╗██║   ██║       ╚════██║  ╚██╔╝  ╚════██║   ██║   ██╔══╝  ██║╚██╔╝██║
               ██║     ██║  ██║╚██████╔╝██████╔╝╚██████╔╝╚██████╗   ██║       ██║ ╚═╝ ██║██║  ██║██║ ╚████║██║  ██║╚██████╔╝███████╗██║ ╚═╝ ██║███████╗██║ ╚████║   ██║       ███████║   ██║   ███████║   ██║   ███████╗██║ ╚═╝ ██║
               ╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚═════╝  ╚═════╝  ╚═════╝   ╚═╝       ╚═╝     ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═╝     ╚═╝╚══════╝╚═╝  ╚═══╝   ╚═╝       ╚══════╝   ╚═╝   ╚══════╝   ╚═╝   ╚══════╝╚═╝     ╚═╝
                                                                                                                                                                                                                    
           

        ");

        Console.WriteLine(" ");
        string test = Console.ReadLine();
        Console.Write("\n\nEnter the product name: ");
        string productName = Console.ReadLine();
        Console.Write("Enter the product price: ");
        int productPrice = int.Parse(Console.ReadLine());
        Console.Write("Enter the product description: ");
        string productDescription = Console.ReadLine();

        return (productName, productPrice, productDescription);
    }
}

class ProductInformation
{
    string ProductName;
    int ProductPrice;
    string ProductDescription;

    public ProductInformation(string productName, int productPrice, string productDescription)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        ProductDescription = productDescription;
    }

    public void DisplayProductInformation()
    {
        Console.WriteLine(@"
                    Product Information
            ");

        Console.WriteLine(
            "Product Name: {0}\nProduct Price: {1}\nProduct Description: {2}",
            ProductName, ProductPrice, ProductDescription
        );
    }
}

class MainProgram
{
    public static void Main()
    {
        OOP.ManageProduct.InsertNewProduct newProduct = new OOP.ManageProduct.InsertNewProduct();
        var (productName, productPrice, productDescription) = products.userInput();
        newProduct.InsertData(productName, productPrice, productDescription);
    }
}