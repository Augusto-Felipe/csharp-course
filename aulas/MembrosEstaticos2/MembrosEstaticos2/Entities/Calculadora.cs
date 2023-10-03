namespace MembrosEstaticos2.Entities;

class Calculadora
{
    public static double Pi = 3.14;

    public static double Circunferencia(double raio)
    {
        return Pi * raio * 2.0;
    }

    public static double Volume(double raio)
    {
        return 4.0 / 3.0 * Pi * raio * raio * raio;
    }
}
