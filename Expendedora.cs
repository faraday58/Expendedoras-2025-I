using System;
using System.Threading;

namespace Expendedoras_2025_I
{
    public abstract class Expendedora
    {
        #region Atributos
        private string _marca;
        protected sbyte _temperatura;
        private ushort _cantProductos;
        private float _precio;

        #endregion

        #region Propiedades o Encapsulado
        public virtual sbyte Temperatura { 
            get => _temperatura;
            set
            {
                if( value >= 10 && value < 21)
                {
                    _temperatura = value;
                }
                else
                {
                    _temperatura = 18;
                }
                
            }
        }
        public string Marca { get => _marca; set => _marca = value; }
        public float Precio { get => _precio; set => _precio = value; }
        #endregion

        #region Constructores
        public Expendedora()
        {
            /*
            Temperatura = 25;
            _precio = 15;
            Marca = "AWS";
            Saludar();
            ClearDisplay();
            string codigo = MostrarProducto();
            ClearDisplay();
            MostrarPrecio( codigo );
            */
        }
       
        public Expendedora( bool mantenimiento)
        {
            if (  mantenimiento)
            {
                Console.WriteLine("Hola, Ingresa " +
                    "la nueva temperatura");
                Temperatura = sbyte.Parse( Console.ReadLine());
                ClearDisplay();
                Console.WriteLine("Temperatura: {0} [°C] ",Temperatura );

            }
        }

        #endregion
        #region Métodos
        public void ClearDisplay()
        {
            Thread.Sleep(5000);
            Console.Clear();
        }

        public void Saludar()
        {
            Console.WriteLine("{0} Bienvenido, " +
                "elige tu producto \n Temperatura {1} [°C] ", Marca,Temperatura);
        }

        public virtual string MostrarProducto()
        {
            string codigo;
            Console.WriteLine(" 2A: Papas \t 3C: Chocolate ");
            Console.WriteLine("Ingrese el código del producto");
            codigo = Console.ReadLine();
            return codigo;

        }

        public virtual void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "2A":
                    Console.WriteLine("Precio: ${0}", Precio);
                    break;
                case "3C":
                    Console.WriteLine("Precio: ${0}", Precio += 5 );
                    break;
                default:
                    Console.WriteLine("Producto no encontrado");
                    break;
            }

        }



        #endregion


    }
}
