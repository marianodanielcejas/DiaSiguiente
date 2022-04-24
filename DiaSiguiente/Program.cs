using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaSiguiente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int año;

            Console.WriteLine("Ingrese el dia por favor: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el mes por favor: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año por favor: ");
            año = int.Parse(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                if (dia > 0 && dia <= 31)
                {
                    if (dia == 31)
                    {
                        dia = 32 - dia;
                        mes = mes + 1;
                    }
                    else
                    {
                        dia = dia + 1;
                    }
                    switch (mes)
                    {
                        case 1: Console.WriteLine("La fecha siguiente es: " + dia + " De Enero " + " de " + año);
                            break;

                        case 2: Console.WriteLine("La fecha siguiente es: " + dia + " De Febrero " + " de " + año);
                            break;

                        case 3:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Marzo " + " de " + año);
                            break;

                        case 4:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Abril " + " de " + año);
                            break;

                        case 5:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Mayo " + " de " + año);
                            break;
                        case 6:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Junio " + " de " + año);
                            break;
                        case 7:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Julio " + " de " + año);
                            break;
                        case 8:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Agosto " + " de " + año);
                            break;
                        case 9:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Septiembre " + " de " + año);
                            break;
                        case 10:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Octubre " + " de " + año);
                            break;
                        case 11:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Noviembre " + " de " + año);
                            break;
                        case 12:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Diciembre" + " de " + año);
                            break;
                        default:
                            año = año + 1;
                            Console.WriteLine("La fecha siguiente es: " + dia + " De enero " + " de " + año);
                            break;
                    }
                }
                if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12 && (dia <= 0 || dia > 31))
                {
                    Console.WriteLine("El mes ingresado no tiene mas de 31 dias/No tiene valores menores a 0.");
                }
            }

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                if (dia > 0 && dia <= 30)
                {
                    if (dia == 30)
                    {
                        dia = 31 - dia;
                        mes = mes + 1;
                    }
                    else
                    {
                        dia = dia + 1;
                    }
                }
                if(mes == 4 || mes == 6 || mes == 9 || mes == 11 &&(dia <= 0 && dia > 30))
                {
                    Console.WriteLine("El mes no tiene mas de 30 dias/No admite valores inferiores a 0");
                }
                else
                {
                    switch (mes)
                    {
                        case 4:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Abril " + " de " + año);
                            break;
                        case 5:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De mayo " + " de " + año);
                            break;
                        case 6:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Junio " + " de " + año);
                            break;
                        case 7:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Julio " + " de " + año);
                            break;
                        case 9:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Septiembre " + " de " + año);
                            break;
                        case 10:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De octubre " + " de " + año);
                            break;
                        case 11:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Noviembre " + " de " + año);
                            break;
                        case 12:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Diciembre " + " de " + año);
                            break;

                    }
                }
                
            }

            if (mes == 2)
            {
                if (AñoBiciesto(año))
                {
                    if(dia > 0 && dia <= 29)
                    {
                        if(dia == 29)
                        {
                            dia = 30 - dia;
                            mes = mes + 1;
                        }
                        else
                        {
                            dia = dia + 1;
                        }
                    }
                }
                else
                {
                    if(dia > 0 && dia <= 28)
                    {
                        if (dia == 28)
                        {
                            dia = 29 - dia;
                            mes = mes + 1;
                        }
                        else
                        {
                            dia = dia + 1;
                        }
                    }
                }
                if(mes == 2 && (dia <= 0 || dia > 29))
                {
                    Console.WriteLine("El mes elegido no tiene 30 dias");
                }
                else
                {
                    switch (mes)
                    {
                        case 2:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Febrero " + " de " + año);
                            break;

                        case 3:
                            Console.WriteLine("La fecha siguiente es: " + dia + " De Marzo " + " de " + año);
                            break;

                    }
                }
            }   
        }
        static public bool AñoBiciesto(int ab)
        {
            bool dato = false;
            if (ab % 4 == 0 && (ab % 100 != 0 || ab % 400 == 0))
            {
                dato = true;
            }
            return dato;
        }
    }
}
