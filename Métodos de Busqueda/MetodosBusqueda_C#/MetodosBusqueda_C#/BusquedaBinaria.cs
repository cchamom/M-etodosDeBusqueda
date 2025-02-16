using System;

namespace MetodosBusqueda_C_
{
    internal class BusquedaBinaria
    {
        public int BuscarElemento(int[] A, int dato)
        {
            int inicio = 0;
            int fin = A.Length - 1;

            while (inicio <= fin)
            {
                int medio = (inicio + fin) / 2;

                if (A[medio] == dato)
                {
                    return medio; 
                }
                else if (A[medio] < dato)
                {
                    inicio = medio + 1; 
                }
                else
                {
                    fin = medio - 1; 
                }
            }

            return -1; 
        }
    }
}
