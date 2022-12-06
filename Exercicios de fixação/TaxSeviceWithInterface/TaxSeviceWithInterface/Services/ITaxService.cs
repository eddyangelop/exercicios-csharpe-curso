using TaxService.Services;

namespace TaxService.Services
{
    internal interface ITaxService
    {
        double Tax(double amount);

    }
}
