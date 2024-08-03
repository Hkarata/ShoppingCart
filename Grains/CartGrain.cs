using GrainInterfaces;

namespace Grains;

public class CartGrain : ICart
{
    public async ValueTask<Dictionary<string, int>> AddToCart(string product, int quantity)
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Dictionary<string, int>> GetCartContents()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<Dictionary<string, int>> RemoveFromCart(string product, int quantity)
    {
        throw new NotImplementedException();
    }

    public async ValueTask ClearCart()
    {
        throw new NotImplementedException();
    }

    public async ValueTask<string> Checkout()
    {
        throw new NotImplementedException();
    }
}