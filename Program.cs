namespace Diamante_de_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int letra = RecebeLetra();
                decimal tamanho = 2 * letra - 129;
                DesenhaDiamante(letra, tamanho);
                if (DeveContinuar()) break;
            }
        }
        private static void DesenhaDiamante(int letra, decimal tamanho)
        {
            decimal metade = (tamanho - 1) / 2;
            Console.WriteLine();

            for (int i = 0; i < tamanho; i++)
            {
                int letraMostrada = letra - Convert.ToInt32(Math.Abs(i - metade));

                for (int j = 0; j < tamanho; j++)
                {
                    if (Math.Abs(j - metade) == i && i <= metade) Console.Write(Convert.ToChar(letraMostrada));
                    else if (Math.Abs(j - metade) == Math.Abs(i - 2 * metade) && i > metade) Console.Write(Convert.ToChar(letraMostrada));
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        private static int RecebeLetra()
        {
            Console.WriteLine("Informe a letra desejada (maiúscula):");
            int letra = 0;

            do
            {
                letra = Convert.ToInt32(Convert.ToChar(Console.ReadLine()));
                if (letra < 65 || letra > 90) Console.WriteLine("Tente novamente:"); ;
            }
            while (letra < 65 || letra > 90);

            return letra;
        }
        static bool DeveContinuar()
        {
            Console.WriteLine("\nDeseja continuar? [S/N]");
            string continuar = Console.ReadLine();
            return continuar == "N" || continuar == "n";
        }
    }
}
