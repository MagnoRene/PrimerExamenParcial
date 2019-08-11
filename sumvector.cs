using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvFi
{
    class sumvector
    {
        #region Parte1 

        // explicar por constructor
        private List<int> _Componentes;

        //constructor
        public sumvector(List<int> Componentes)
        {
            _Componentes = Componentes;

        }

        public sumvector()
        {
        }
        #endregion

        public List<int> Componentes
        {
            get
            {
                return _Componentes;
            }
        }

        public int this[int i]
        {
            get { return _Componentes[i]; }
            set { _Componentes[i] = value; }
        }
        public int Dimension { get { return _Componentes.Count; } }


        public static sumvector operator +(sumvector v1, sumvector v2)
        {
            return v1.Suma(v2);
        }
        public static sumvector operator -(sumvector v1, sumvector v2)
        {
            return v1.Resta(v2);
        }
        public static sumvector operator *(sumvector v1, sumvector v2)
        {
            return v1.Multiplicar(v2);
        }


        public double PE(sumvector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado            
            double resultado = 0;

            for (int i = 0; i < Dimension; i++)
            {
                //resultado.Add(this[i] + v2[i]);
                resultado += (this[i]) + (v2[i]);
            }

            return resultado;
        }

        // suma de vectores =  a la suma  de las componentes correspondientes de ambos vectos
        public sumvector Suma(sumvector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }

            return new sumvector(resultado);
        }


        public sumvector Resta(sumvector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] - v2[i]);
            }

            return new sumvector(resultado);
        }


        public sumvector Multiplicar(sumvector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("las dimensiones no son iguales");
            }

            //creamos una lista  llamada resultado

            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] * v2[i]);
            }

            return new sumvector(resultado);
        }
    }
}
