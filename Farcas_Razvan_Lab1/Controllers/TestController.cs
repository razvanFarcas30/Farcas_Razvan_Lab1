using Microsoft.AspNetCore.Mvc;

namespace Farcas_Razvan_Lab1.Controllers;

public class TestController : Controller
{
    public string Index()
    {
        return "Bun venit in aplicatia mea!";
    }

    public string Salut()
    {
        return "Salut!";
    }

    public string Detalii(string nume, int varsta)
    {
        return $"Salut {nume}, ai {varsta} ani.";
    }
}