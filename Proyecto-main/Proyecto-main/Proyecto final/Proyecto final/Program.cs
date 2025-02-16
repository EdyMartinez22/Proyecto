using Proyecto_final;
using System.Runtime.CompilerServices;

int centinela = 1;
int centinel2 = 1;
List<Persona> listpersonas = new List<Persona>();
List<Asientos> listaAsientos = new List<Asientos>();
List<Avion> ListAviones = new List<Avion>();

while (centinela == 1)
{
    Console.WriteLine("*************    MENU PRINCIPAL     *************");
    Console.WriteLine("***                                           ***");
    Console.WriteLine("***    1. Accceder como administrador         ***");
    Console.WriteLine("***    2. Accceder como Registro              ***");
    Console.WriteLine("***    3. Accceder para llenar                ***");
    Console.WriteLine("***    4. Salir del menu                      ***");
    Console.WriteLine("***                                           ***");
    Console.WriteLine("****************       UNAH         *************");
    int op = Convert.ToInt32(Console.ReadLine());

    switch (op)
    {
        case 1:
            {
                centinel2 = 1;
                while (centinel2 == 1)
                {
                    Console.WriteLine("*************    MENU PRINCIPAL     *************");
                    Console.WriteLine("***                                           ***");
                    Console.WriteLine("***          1. Agragar Pilotos               ***");
                    Console.WriteLine("***          2. Agragar Tripulación           ***");
                    Console.WriteLine("***          3. Agregar Asientos              ***");
                    Console.WriteLine("***          4. Agregar Aviones               ***");
                    Console.WriteLine("***          5. Salir del menu                ***");
                    Console.WriteLine("***                                           ***");
                    Console.WriteLine("****************       UNAH         *************");
                    int opci = Convert.ToInt32(Console.ReadLine());

                    switch (opci)
                    {
                        case 1:
                            {
                                Piloto piloto1 = new Piloto();
                                Console.WriteLine("Ingrese el nombre del Piloto");
                                piloto1.Nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido del piloto");
                                piloto1.Apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese la edad del Piloto");
                                piloto1.Edad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el correo del piloto");
                                piloto1.Correo = Console.ReadLine();
                                Console.WriteLine("Ingrese la dirección del Piloto");
                                piloto1.Direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese la identidad del Piloto");
                                piloto1.Identidad = Console.ReadLine();
                                Console.WriteLine("Ingrese numero de empleado del piloto");
                                piloto1.Noempleado = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese la aerolinea asiganada");
                                piloto1.Aerolinea_asignada = Console.ReadLine();
                                Console.WriteLine("Ingrese la cantidad de años de experiencia");
                                piloto1.Aniodeexperiencia = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("EL PILOTO FUE AGREGADO CON EXITO");
                                listpersonas.Add(piloto1);
                                break;
                            }
                        case 2:
                            {
                                Tripulacion tripulacion1 = new Tripulacion();
                                Console.WriteLine("Ingrese el nombre del empleado");
                                tripulacion1.Nombre = Console.ReadLine();
                                Console.WriteLine("Ingrese el apellido del empleado");
                                tripulacion1.Apellido = Console.ReadLine();
                                Console.WriteLine("Ingrese la edad del empleado");
                                tripulacion1.Edad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el correo del empleado");
                                tripulacion1.Correo = Console.ReadLine();
                                Console.WriteLine("Ingrese la dirección del empleado");
                                tripulacion1.Direccion = Console.ReadLine();
                                Console.WriteLine("Ingrese la identidad del empleado");
                                tripulacion1.Identidad = Console.ReadLine();
                                Console.WriteLine("Ingrese numero de empleado del empleado");
                                tripulacion1.Codigo_empleado = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el cargo del empleado");
                                tripulacion1.Cargo = Console.ReadLine();

                                listpersonas.Add(tripulacion1);
                                break;
                            }
                        case 3:
                            {
                                Asientos asientos1 = new Asientos();
                                Console.WriteLine("Ingrese la clase del asiento");
                                asientos1.Clase = Console.ReadLine();
                                Console.WriteLine("Ingrese la Id del asiento");
                                asientos1.Id_asiento = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese el numero de asiento");
                                asientos1.No_asientos = Console.ReadLine();
                                Console.WriteLine("Asiento agregado con exito");

                                listaAsientos.Add(asientos1);

                                break;
                            }
                        case 4:
                            {
                                Avion aviones = new Avion();
                                Console.WriteLine("Ingrese la capacidad del avión");
                                aviones.Capacidad = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Ingrese la Id asiento");
                                int BuscarAsientos = Convert.ToInt32(Console.ReadLine());

                                Asientos AsientoEncontado = null;
                                Boolean error = false;

                                foreach (Asientos asientos2 in listaAsientos)
                                {
                                    if (asientos2.Id_asiento == BuscarAsientos)
                                    {
                                        AsientoEncontado = asientos2;
                                    }
                                }
                                if (AsientoEncontado == null)
                                {
                                    Console.WriteLine("No se encontro el asiento");
                                    error = true;
                                }
                                else
                                {
                                    aviones.Asientos = AsientoEncontado;
                                }
                                if (!error)
                                {
                                    ListAviones.Add(aviones);
                                    Console.WriteLine("Avion Agregado a la Lista con Exito!");
                                }
                                break;
                            }
                        case 5:
                            {
                                centinel2 = 0;
                                break;
                            }
                        default:
                            Console.WriteLine("Opcion Invalidad");
                            break;
                    }
                }
                break;
            }
        case 2:
            {
                Pasajero pasajero1 = new Pasajero();
                Console.WriteLine("Rellenar los datos de los pasajeros");
                Console.WriteLine("\nIngrese el nombre del pasajero");
                pasajero1.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el apellido del pasajero");
                pasajero1.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese la edad del pasajero");
                pasajero1.Edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el correo del pasajero");
                pasajero1.Correo = Console.ReadLine();
                Console.WriteLine("Ingrese la dirección del pasajero");
                pasajero1.Direccion = Console.ReadLine();
                Console.WriteLine("Ingrese la identidad del pasajero");
                pasajero1.Identidad = Console.ReadLine();
                Console.WriteLine("Ingrese la Id del pasajero");
                pasajero1.Codigo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el numero de pasajeros");
                pasajero1.Numero_pasajero = Console.ReadLine();
                Console.WriteLine("Ingrese el numero de maletas del pasajero");
                pasajero1.Numero_maleta = Convert.ToInt32(Console.ReadLine());

                listpersonas.Add(pasajero1);
                Console.WriteLine("\nPasajero agregado con exito!");
                break;
            }
            
    }

}