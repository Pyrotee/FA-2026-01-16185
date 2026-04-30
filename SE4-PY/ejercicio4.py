
print("---SISTEMA DE CALCULO DE AREAS---\n");

print("Menu de opciones:");
print("1. Cuadrado");
print("2. Rectangulo");
print("3. Triangulo");
print("4. Circulo\n");

print("Ingrese una opcion: ");
opc = int.input(Console.ReadLine());

            

match (opc)
            
        case 1:
                    
                    lc = int(input("\Ingrese lado: "));
                    area = lc * lc;
                    Console.WriteLine($"El area del cuadrado es: {area}");
                    break;
                case 2:
                    Console.Write("\n Ingrese base: ");
                    int br = int.Parse(Console.ReadLine());
                    Console.Write("\n Ingrese altura: ");
                    int ar = int.Parse(Console.ReadLine());
                    area = br * ar;
                    Console.WriteLine($"El area del rectangulo es: {area}");
                    break;
                case 3:
                    Console.Write("\n Ingrese base: ");
                    int bt = int.Parse(Console.ReadLine());
                    Console.Write("\n Ingrese altura: ");
                    int at = int.Parse(Console.ReadLine());
                    area = (bt * at) / 2;
                    Console.WriteLine($"El area del triangulo es: {area}");
                    break;
                case 4:
                    Console.Write("\n Ingrese radio: ");
                    int rc = int.Parse(Console.ReadLine());
                    area = Math.PI * Math.Pow(rc,2);
                    Console.WriteLine($"\nEl area del circulo es: {area}");
                    break;
                default: Console.Write("\nOpcion incorrecta!"); break;