using System;



namespace ProgramNum
{
    class Program
    {
        public static void Main (string[]args)
        { 
            string respuesta;
           do
           {
                System.Console.WriteLine("SELECCIONE UN PROGRAMA QUE QUIERA EJECUTAR");

                System.Console.WriteLine("");
                System.Console.WriteLine("(1-) MOSTAR EN PANTALLA LOS NUMEROS DEL 1 AL 500.");
                System.Console.WriteLine("");

                System.Console.WriteLine("(2-) MOSTRAR EN PANTALLA LOS NUMEROS DEL 500 AL 1.");
                System.Console.WriteLine("");
 
                System.Console.WriteLine("(3-) MOSTRAR EN PANTALLA LOS NUMEROS IMPARES COMPRENDIDOS ENTRE EL 1 Y EL 100.");
                System.Console.WriteLine("");

                System.Console.WriteLine("(4-) MOSTRAR EN PANTALLA LOS NUMEROS DEL 0 AL 1000, INCREMENTANDO DE 5 EN 5.");
                System.Console.WriteLine("");

                System.Console.WriteLine("(5-) PEDIR AL USUARIO UN NUMERO, Y MUESTAR EN PANTALLA LA SECUENCIA DESCENDENTE.");
                System.Console.WriteLine("");

                System.Console.WriteLine("(6-) PEDIR AL USUARIO UN NUMERO. EL NUMERO RECIBIDO LO MULTIPLICARA POR 5.");
                System.Console.WriteLine("");

                System.Console.WriteLine("(7-) PEDIR AL USUARIO DOS NUMERO.");
                System.Console.WriteLine("");
            
                int ejercicio = Convert.ToInt32(Console.ReadLine())!;
                int punto;
                Console.Clear();
                Console.WriteLine("Procesando.");
                Thread.Sleep(1000);
                Console.Clear();
                System.Console.WriteLine("Procesando..");
                Thread.Sleep(1000);
                Console.Clear();
                System.Console.WriteLine("Procesando...");
                Thread.Sleep(1000);
                Console.Clear();

                switch (ejercicio)
                {
                  case 1: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                  System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  punto = int.Parse(Console.ReadLine()!);

                   switch (punto)
                   {
                    case 1:
                    System.Console.WriteLine("Has elegido DO WHILE");
                    int numero = 1;

                    do
                    {
                        System.Console.WriteLine("{0}|", numero);
                        numero++;

                    } while (numero <= 500);break;

                    case 2: System.Console.WriteLine("Has elegido While");
                    int numenor = 1;

                    while (numenor <=500)
                    {
                        System.Console.WriteLine("{0}", numenor);
                        numenor++;
                    }
                    System.Console.WriteLine("Ha terminado el programa WHILE");
                    System.Console.WriteLine("");break;

                    default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2"); break;
                   }
                   break;

                   case 2: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                   System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                   int PUNT = Convert.ToInt32(Console.ReadLine());

                   switch (PUNT)
                   {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    int quin = 500;
                    do
                    {
                        System.Console.WriteLine("{0}", quin);
                        quin--;
                    } while (quin >= 1);break;

                    case 2: System.Console.WriteLine("Has elegido WHILE");
                    int quiniento = 500;

                    while (quiniento >= 1)
                    {
                        System.Console.WriteLine("{0}", quiniento);
                        quiniento--;
                    }
                    System.Console.WriteLine("Has terminado el programa WHILE");
                    System.Console.WriteLine("");break;
                    default:System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                   }
                   break;

                   case 3: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                  System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  int ejercicio3 = Convert.ToInt32(Console.ReadLine());
                  Console.Clear();

                  switch (ejercicio3)
                  {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    int cien = 1; 

                    do
                    {
                        if (cien % 2 == 1)
                        {
                            System.Console.WriteLine("{0}", cien);
                        }
                        cien++;
                    } while (cien <= 100);break;

                    case 2: System.Console.WriteLine("Has elegido WHILE");
                    int CIEN = 1;

                    while (CIEN <= 100)
                    {
                        if (CIEN % 2 == 1)
                        {
                            System.Console.WriteLine("{0}", CIEN);
                        }
                        CIEN++;
                    }
                    System.Console.WriteLine("Ha terminado el Programa");
                    System.Console.WriteLine("");break;
                    default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                  }
                  break;

                  case 4: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                   System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  int mil = Convert.ToInt32(Console.ReadLine());

                  switch (mil)
                  {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    int AUM = 0;

                    do
                    {
                        System.Console.WriteLine("{0}", AUM);
                        AUM = AUM + 5;

                    } while (AUM <= 1000);break;

                    case 2: System.Console.WriteLine("Has elegido WHILE");
                    int AUMENTA = 0;

                    while (AUMENTA <= 1000)
                    {
                        System.Console.WriteLine("{0}", AUMENTA);
                        AUMENTA = AUMENTA + 5;
                    }
                    System.Console.WriteLine("Ha terminado el Programa");
                    System.Console.WriteLine("");break;
                    default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                  }
                  break;

                  case 5: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                  System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  int ejercicio5 = Convert.ToInt32(Console.ReadLine());
                  Console.Clear();

                  switch (ejercicio5)
                  {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    Thread.Sleep(4000);
                    Console.Clear();
                    System.Console.Write("Escriba un numero cualquiera para mostarlo de forma descendente: ");
                    int descendente = int.Parse(Console.ReadLine()!);

                    do
                    {
                        System.Console.WriteLine("{0}|", descendente);
                        descendente--;
                    } while (descendente >= 0);break;

                    case 2: System.Console.WriteLine("Has elegido WHILE");
                    Thread.Sleep(4000);
                    Console.Clear();
                    System.Console.Write("Escriba un numero cualquiera para mostarlo de forma descendente: ");
                    int descen = int.Parse(Console.ReadLine()!);

                    while (descen >= 0)
                    {
                        System.Console.Write("{0}|", descen);
                        descen--;
                    }
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Ha terminado el programa WHILE");
                    Console.ReadKey();
                    Console.Clear();   break;
                    
                    default:System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                  }
                  break;

                  case 6: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                  System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  int ejercicio6 = Convert.ToInt32(Console.ReadLine());
                  Console.Clear();

                  switch (ejercicio6)
                  {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.Write("Introduzca un numero: ");
                    int numeroAle = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    int resultado;
                    resultado = numeroAle * 5;

                    System.Console.WriteLine($"El numero introducido {numeroAle} multipilicado por 5 es {resultado}");
                    System.Console.WriteLine("");

                    if (numeroAle % 2 == 0)
                    {
                        System.Console.WriteLine("El resultado es Par");
                        do
                        {
                            System.Console.WriteLine("{0}|", numeroAle);
                            numeroAle++;
                            
                        } while (numeroAle <= resultado);
                    }
                    else if (numeroAle % 2 == 1)
                    {
                        System.Console.WriteLine("El resultado es Impar");
                        do
                        {
                            System.Console.WriteLine("{0}|", numeroAle);
                            numeroAle++;

                        } while (numeroAle <= resultado);
                    }
                   break;

                   case 2: System.Console.WriteLine("Has elegido WHILE");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.Write("Introduzca un numero: ");
                    int numeroAl = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    int resultad;
                    resultad = numeroAl * 5;

                    System.Console.WriteLine($"El numero introducido {numeroAl} multipilicado por 5 es {resultad}");
                    System.Console.WriteLine("");
                    
                    if (numeroAl % 2 == 0)
                    {
                        System.Console.WriteLine("El resultado es Par");

                        while (numeroAl <= resultad)
                        {
                            System.Console.WriteLine("{0}|", numeroAl);
                            numeroAl++;
                        }
                    }
                    else if (numeroAl % 2 == 1)
                    {
                        System.Console.WriteLine("El numero es Impar");

                        while (numeroAl <= resultad)
                        {
                         System.Console.WriteLine("{0}|", numeroAl);
                         numeroAl++;   
                        }
                    }
                    System.Console.WriteLine("El programa con WHILE ha terminado");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    default:System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                  }
                  break;

                  case 7: System.Console.WriteLine("¿Quieres ver el ejercicio con el ciclo DO WHILE OR WHILE?");
                  System.Console.WriteLine("");
                  System.Console.WriteLine("1- DO WHILE \n2- WHILE");
                  int ejercicio7 = Convert.ToInt32(Console.ReadLine());
                  Console.Clear();

                  switch (ejercicio7)
                  {
                    case 1: System.Console.WriteLine("Has elegido DO WHILE");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.Write("Digite un numero: ");
                    int Dig1 = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    System.Console.Write("Digite otro numero: ");
                    int Dig2 = int.Parse(Console.ReadLine()!);
                    Console.Clear();

                    if (Dig1 > Dig2)
                    {
                        System.Console.WriteLine($"El digito {Dig1} es mayor que el digito {Dig2}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("De forma Descendente: ");

                        do
                        {
                            System.Console.WriteLine("{0}|", Dig1);
                            Dig1--;

                        } while (Dig1 >= Dig2);
                    }
                    else if (Dig2 > Dig1)
                    {
                        System.Console.WriteLine($"El digito {Dig2} es mayor que el digito {Dig1}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("De forma Ascendente: ");

                        do
                        {
                            System.Console.WriteLine("{0}|", Dig1);
                            Dig1++;
                        } while (Dig1 <= Dig2);
                    } break;

                    case 2: System.Console.WriteLine("Has elegido WHILE");
                    Console.ReadKey();
                    Console.Clear();
                    System.Console.Write("Digite un numero: ");
                    int DIG1 = int.Parse(Console.ReadLine()!);
                    Console.Clear();
                    System.Console.Write("Digite otro numero: ");
                    int DIG2 = int.Parse(Console.ReadLine()!);
                    Console.Clear();

                    if (DIG1 > DIG2)
                    {
                        System.Console.WriteLine($"El digito {DIG1} es mayor que el digito {DIG2}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("De forma Descendente");
                        while (DIG1 >= DIG2)
                        {
                            System.Console.WriteLine("{0}|", DIG1);
                            DIG1--;
                        }
                    }
                    else if (DIG2 > DIG1)
                    {
                        System.Console.WriteLine($"El digito {DIG2} es mayor que el digito {DIG1}");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("De forma Ascendente");
                        while (DIG1 <= DIG2)
                        {
                            System.Console.WriteLine("{0}|", DIG1);
                            DIG1++;
                        }
                        
                    }
                    System.Console.WriteLine("Ha terminado el programa con WHILE");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                    default:System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DE 1-2");break;
                  }
                  break;

                  default: System.Console.WriteLine("ERROR - ELIJA UN NUMERO DENTRO DEL RANGO DE 1-7");break;
               }

             System.Console.WriteLine("¿DESEA REPETIR EL PROGRAMA?");
             respuesta = Console.ReadLine()!;
             Console.Clear();
           } while (respuesta != "no");
           Console.Clear();

            System.Console.WriteLine("HA TERMINADO EL PROGRAMA");
        }   

    }  
}