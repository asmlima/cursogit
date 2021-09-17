using System;

namespace Primeiro
{
    class Aluno
    {
        public string Nome;
        public double NotaT1;
        public double NotaT2;
        public double NotaT3;

        public double NotaFinal()
        {
            return NotaT1 + NotaT2 + NotaT3;
        }

        public void AprovadoReprovado()
        {
            double notaFinal = NotaFinal();
            Console.WriteLine($"NOTA FINAL = {notaFinal}");
            if (notaFinal < 60.00)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine($"FALTARAM {60.00 - notaFinal} PONTOS");
            }
            else
                Console.WriteLine("APROVADO");
        }
    }
}
