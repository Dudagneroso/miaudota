using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miaudota
{
    public class Idade
    {
        public int Anos { get; set; }
        public int Meses { get; set; }

        public Idade()
        {
            Anos = 0;
            Meses = 0;
        }


        public static Idade Calcular(Gato gato, DateTime referencia)
        {
            DateTime nasc = gato.DataNascimento;

            int totalMeses = (referencia.Year - nasc.Year) * 12 + referencia.Month - nasc.Month;
            if (referencia.Day < nasc.Day)
            {
                totalMeses--;
            }

            if (totalMeses < 0)
            {
                totalMeses = 0;
            }

            return new Idade
            {
                Anos = totalMeses / 12,
                Meses = totalMeses % 12
            };
        }

        public override string ToString()
        {
            if (Anos == 0)
            {
                return $"{Meses} mês{(Meses > 1 ? "es" : "")}";

            }
            else if (Meses == 0)
            {
                return $"{Anos} ano{(Anos > 1 ? "s" : "")}";
            }
            else
            {
                return $"{Anos} ano{(Anos > 1 ? "s" : "")} e {Meses} mês{(Meses > 1 ? "es" : "")}";
            }
        }

    }
}
