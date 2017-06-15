class Invoice
{
    private string partNumber;
    private string partDesc;
    private int itemQuantity;
    private decimal pricePerItem;

    public Invoice() : this("610214653208", 
        "Explore the Galaxy S8 and S8+ features that mark the beginning of a new way to experience the world.",
        4, 
        750.00M) { }

    public Invoice(string partNumber, string partDesc, int itemQuantity, decimal pricePerItem)
    {
        this.PartNumber = partNumber;
        this.PartDesc = partDesc;
        this.ItemQuantity = itemQuantity;
        this.PricePerItem = pricePerItem;
    }

    public string PartNumber { get => partNumber; set => partNumber = value; }
    public string PartDesc { get => partDesc; set => partDesc = value; }
    public int ItemQuantity
    {
        get => itemQuantity;
        set
        {
            if (value > 0)
                itemQuantity = value;
        }
    }
    public decimal PricePerItem
    {
        get => pricePerItem;
        set
        {
            if (value > 0)
                pricePerItem = value;
        }
    }

    public decimal GetInvoiceAmount()
    {
        return (itemQuantity * pricePerItem);
    }
}