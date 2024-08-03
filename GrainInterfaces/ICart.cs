namespace GrainInterfaces;

[Alias("GrainInterfaces.ICart")]
public interface ICart : IGrainWithGuidKey
{
    [Alias("AddToCart")]
    ValueTask<Dictionary<string, int>> AddToCart(string product, int quantity);
    
    [Alias("GetCartContents")]
    ValueTask<Dictionary<string, int>> GetCartContents();
    
    [Alias("RemoveFromCart")]
    ValueTask<Dictionary<string, int>> RemoveFromCart(string product, int quantity);
    
    [Alias("ClearCart")]
    ValueTask ClearCart();
    
    [Alias("Checkout")]
    ValueTask<string> Checkout();
}