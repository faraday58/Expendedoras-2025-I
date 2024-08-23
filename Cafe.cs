using System;
namespace Expendedoras_2025_I
{
    internal class Cafe : Expendedora
    {
        public override sbyte Temperatura { 
            get => base.Temperatura;
            set {

                if (value > 50 && value <60)
                {
                    _temperatura = value;
                }
                else
                {
                    _temperatura = 50;
                }


            }
        }



        public Cafe()
        {
            Marca = "Nescafe";
            Temperatura = 70;
            Saludar();
            ClearDisplay();
            Console.WriteLine("Despierta con {0}", Marca);
            string codigo = MostrarProducto();
            MostrarPrecio(codigo);


        }

        public Cafe(bool mantenimiento)
        {
            if (mantenimiento)
            {
                Console.WriteLine("Entrando en modo " +
                    "Mantenimiento");
            }
            else
            {
                Saludar();
            }
        }

        public override string MostrarProducto()
        {
            Console.WriteLine(" A1: Moka Blanco K2: Capuchino ");
            string codigo = Console.ReadLine();
            return codigo;
            
        }
        public override void MostrarPrecio(string codigo)
        {
            switch (codigo)
            {
                case "A1":
                    Console.WriteLine("El precio es: ${0}",Precio +100);
                    break;
                case "K2":
                    Console.WriteLine("El precio es: ${0}", Precio + 80);
                    break;
            }
         
        }


    }
}
