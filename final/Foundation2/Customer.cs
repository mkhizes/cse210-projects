class Customer
{
    private string _name{get;set;}
    private Address _address{get;set;}

    public Customer()
    {
        
    }

    public bool IsInUSA()
    {
      return true;
    }

    public string GetName()
    {
        return"";
    }

    public string GetAddress()
    {
        return "";
    }
}