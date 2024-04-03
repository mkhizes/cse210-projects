class Address
{
    private string _street{get;set;}
    private string _city{get;set;}
    private string _state{get;set;}
    private string _country{get;set;}

    public Address()
    {
       
    }

    public bool IsInUSA()
    {
        return true;
    }

    public string GetFullAddress()
    {
        return "";
    }
}
