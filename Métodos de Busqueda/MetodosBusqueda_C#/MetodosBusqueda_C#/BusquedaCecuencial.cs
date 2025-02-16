using System;

namespace MetodosBusqueda_C_
{
    internal class BusquedaSecuencial
    {
        public int BuscarElemento(int[] A, int dato)
        {
            int pos = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (dato == A[i])
                {
                    pos = i;
                    break;
                }
            }

            return pos;
        }
    }
}
    