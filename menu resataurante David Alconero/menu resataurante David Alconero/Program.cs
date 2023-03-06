// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Bienvenidos al restaurante  KrustyBurger");
//crear menu de un restaurante para poder despachar pedidos
//items: hamburguesas, aguas, papas, helado, pizza, pastas y postres
//mostrar el menu
//ordenar
//pago

//variables
bool continuar = false;
int _opcionMenu = 0;
int _menu1=0, _menu2=0, _menu3=0, _menu4=0, _menu5=0, _menu6=0, _menu7 = 0;
int pm1 = 34, pm2 = 45, pm3 = 69, pm4 = 12, pm5 = 40, pm6 = 33, pm7 = 66;


Console.WriteLine("El menu es:");
Console.WriteLine("1. Hamburguesas de Lomito..................Q34.00");
Console.WriteLine("2. pasta al pesto..........................Q45.00");
Console.WriteLine("3. pizza de pepperoni......................Q69.00");
Console.WriteLine("4. Postres-Pasteles de triple chocolate....Q12.00");
Console.WriteLine("5. helado-galleta..........................Q40.00");
Console.WriteLine("6. papas fritas con queso..................Q33.00");
Console.WriteLine("7. Bebidas.................................Q66.00");

Console.WriteLine("Seleccione los items del menu que desa ordenar");
try
{
    do
    {
        _opcionMenu = int.Parse(Console.ReadLine());
        switch (_opcionMenu)
        {
            case 1:
                {
                    _menu1 = _menu1+ 1;
                }
                break;
            case 2:
                {
                    _menu2 = _menu2+ 1;
                }
                break;

            case 3:
                {
                    _menu3 = _menu3+ 1;
                }
                break;

            case 4:
                {
                    _menu4 = _menu4+ 1;
                }
                break;

            case 5:
                {
                    _menu5 = _menu5 + 1;
                }
                break;

            case 6:
                {
                    _menu7 = _menu7 + 1;
                }
                break;
            case 7:
                {
                    _menu7 = _menu7 + 1;
                }
                break;
            default:
                {
                    Console.WriteLine("ingresar un numero valido");
                }
                break;
        }
        Console.WriteLine("Desaea continuar? si/no");
        string respuesta = Console.ReadLine().ToLower();

        if (respuesta == "si")
        {
            Console.WriteLine("Ingrese el sieguiente item");
            continuar = true;
        }
        else
        {
            continuar = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Muchas Gracias por su compra");
            int total = ((_menu1 * pm1) + (_menu2 * pm2) + (_menu3 * pm3) + (_menu4 * pm4) + (_menu5 * pm5) + (_menu6 * pm6) + (_menu7 * pm7));
            Console.WriteLine("Su total es Q." + total);
        }
    } while (continuar == true);

}
catch (Exception)
{
    Console.WriteLine(" ha existido un error. Vuelva a ejecutar el programa");
}
  Console.ReadKey();