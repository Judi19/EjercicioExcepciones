namespace EjercicioExcepciones
{
    public class Operaciones
    {
        public double Sumar(double Digito1, double Digito2)
        {
            return Digito1 + Digito2;
        }
        public double Restar(double Digito1, double Digito2)
        {
            return Digito1 - Digito2;
        }
        public double Multiplicar(double Digito1, double Digito2)
        {
            return Digito1 * Digito2;
        }
        public double Dividir(double Digito1, double Digito2)
        {
            if (Digito2 == 0)
            {
                throw new DivideByZeroException("No se puede dividir por cero");
            }
            return Digito1 / Digito2;
        }
    }
}
