namespace BarAPI.Models;

public static class Roles
{
    public const string Administrador = "Administrador";
    public const string Mesero = "Mesero";
    public const string Cajero = "Cajero";

    public static readonly string[] Todos = { Administrador, Mesero, Cajero };
}