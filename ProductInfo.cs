internal class ProductInfo
{
    public string Name { get; set; } = "";
    public int Price { get; set; } = 0;
    public int NumberlnStock { get; set; } = 0;
    public override string ToString()
    => $"Name={Name}, Descnption= {Price}, Number in Stock={NumberlnStock}";
}