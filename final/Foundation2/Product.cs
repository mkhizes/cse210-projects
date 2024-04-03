class Product
{
    private string _name{get;set;}
    private string _productId{get; set;}
    private decimal _price{get; set;}
    private int _quantity{get;set;}

    public Product()
    {
        
    }

    public decimal GetTotalCost()
    {
        return 0;
    }

    public string GetName()
    {
        return"";
    }

    public string GetProductId()
    {
        return"";
    }
}
