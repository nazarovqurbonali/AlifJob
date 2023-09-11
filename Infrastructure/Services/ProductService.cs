using Domain;
using Domain.Reponce;

namespace Infrasructure.Services;

public class ProductService : IProductService
{
    public async Task<Response<string>> GetProductAsync(Product product, int summa, string phone, Diapazon diapazon)
    {
        if (product == Product.Smartphone)
        {
            if (diapazon == Diapazon.Three || diapazon == Diapazon.Six || diapazon == Diapazon.Nine)
            {
                var result = summa;
                return new Response<string>($"SmartPhone for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.Twelve)
            {
                var result = (summa * 3 / 100) + summa;
                return new Response<string>($"SmartPhone for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.EighTeen)
            {
                var result = (summa * 6 / 100) + summa;
                return new Response<string>($"SmartPhone for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.TwentyFour)
            {
                var result = (summa * 9 / 100) + summa;
                return new Response<string>($"SmartPhone for credit = {result} somoni ,phone = {phone} ");
            }
        }

        if (product == Product.Laptop)
        {
            if (diapazon == Diapazon.Three || diapazon == Diapazon.Six || diapazon == Diapazon.Nine)
            {
                var result = summa;
                return new Response<string>($"Laptop for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.Twelve)
            {
                var result = (summa * 4 / 100) + summa;
                return new Response<string>($"Laptop for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.EighTeen)
            {
                var result = (summa * 8 / 100) + summa;
                return new Response<string>($"Laptop for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.TwentyFour)
            {
                var result = (summa * 12 / 100) + summa;
                return new Response<string>($"Laptop for credit = {result} somoni ,phone = {phone} ");
            }
        }
        
        if (product == Product.Tv)
        {
            if (diapazon == Diapazon.Three || diapazon == Diapazon.Six || diapazon == Diapazon.Nine)
            {
                var result = summa;
                return new Response<string>($"TV for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.Twelve)
            {
                var result = (summa * 5 / 100) + summa;
                return new Response<string>($"TV for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.EighTeen)
            {
                var result = (summa * 10 / 100) + summa;
                return new Response<string>($"TV for credit = {result} somoni ,phone = {phone} ");
            }

            if (diapazon == Diapazon.TwentyFour)
            {
                var result = (summa * 15 / 100) + summa;
                return new Response<string>($"TV for credit = {result} somoni ,phone = {phone} ");
            }
        }

        return new Response<string>($"Please fill out this field");
    }
}