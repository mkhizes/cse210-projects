 using System;
using System.IO;
class Order
{
    private Customer _customer{get;set;}
    private List<Product> _products{get; set; }


    public Order(Customer customer)
    {
        return;
    }

    public void AddProduct(Product product)
    {
       return; 
    }

    public decimal CalculateTotalCost()
    {
        return 0;
    }

    public string GetPackingLabel()
    {
        return "";
    }

    public string GetShippingLabel()
    {
        return "";
    }
}