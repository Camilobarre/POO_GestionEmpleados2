using POO_GestionEmpleados2.Models;

Empresa empresa = new Empresa("Mi Empresa", "Calle Falsa 123");

// Añadiendo empleados y clientes quemados
empresa.AgregarEmpleado(new Empleado("Juan", "Perez", 30, "12345", "Desarrollador", 50000m));
empresa.AgregarEmpleado(new Empleado("Maria", "Gomez", 28, "67890", "Analista", 45000m));
empresa.AgregarEmpleado(new Empleado("Luis", "Martinez", 35, "54321", "Gerente", 60000m));

empresa.AgregarCliente(new Cliente("Ana", "Lopez", 25, "ana@correo.com", "123456789"));
empresa.AgregarCliente(new Cliente("Carlos", "Hernandez", 40, "carlos@correo.com", "987654321"));
empresa.AgregarCliente(new Cliente("Elena", "Torres", 33, "elena@correo.com", "456789123"));

bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("Seleccione una opción:");
    Console.WriteLine("1. Agregar Empleado");
    Console.WriteLine("2. Eliminar Empleado");
    Console.WriteLine("3. Mostrar Todos los Empleados");
    Console.WriteLine("4. Actualizar Empleado");
    Console.WriteLine("5. Buscar Empleado");
    Console.WriteLine("6. Mostrar Empleados por Cargo");
    Console.WriteLine("7. Agregar Cliente");
    Console.WriteLine("8. Eliminar Cliente");
    Console.WriteLine("9. Mostrar Todos los Clientes");
    Console.WriteLine("0. Salir");

    string opcion = Console.ReadLine();

    switch (opcion)
    {
        case "1":
            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado:");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del empleado:");
            byte edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el número de identificación del empleado:");
            string numeroDeIdentificacion = Console.ReadLine();
            Console.WriteLine("Ingrese la posición del empleado:");
            string posicion = Console.ReadLine();
            Console.WriteLine("Ingrese el salario del empleado:");
            decimal salario = decimal.Parse(Console.ReadLine());
            empresa.AgregarEmpleado(new Empleado(nombre, apellido, edad, numeroDeIdentificacion, posicion, salario));
            PausarMenu();
            break;

        case "2":
            Console.WriteLine("Ingrese el nombre del empleado a eliminar:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado a eliminar:");
            apellido = Console.ReadLine();
            empresa.EliminarEmpleado(nombre, apellido);
            PausarMenu();
            break;

        case "3":
            empresa.MostrarTodosLosEmpleados();
            PausarMenu();
            break;

        case "4":
            Console.WriteLine("Ingrese el número de identificación del empleado a actualizar:");
            numeroDeIdentificacion = Console.ReadLine();
            Console.WriteLine("Ingrese la nueva posición del empleado:");
            posicion = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo salario del empleado:");
            salario = decimal.Parse(Console.ReadLine());
            empresa.ActualizarEmpleado(numeroDeIdentificacion, posicion, salario);
            PausarMenu();
            break;

        case "5":
            Console.WriteLine("Ingrese el número de identificación del empleado a buscar:");
            numeroDeIdentificacion = Console.ReadLine();
            var empleado = empresa.BuscarEmpleado(numeroDeIdentificacion);
            if (empleado != null)
            {
                empleado.MostrarInformacion();
            }
            else
            {
                Console.WriteLine("Empleado no encontrado");
            }
            PausarMenu();
            break;

        case "6":
            Console.WriteLine("Ingrese el cargo a buscar:");
            string cargo = Console.ReadLine();
            empresa.MostrarEmpleadosPorCargo(cargo);
            PausarMenu();
            break;

        case "7":
            Console.WriteLine("Ingrese el nombre del cliente:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del cliente:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del cliente:");
            edad = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el email del cliente:");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono del cliente:");
            string telefono = Console.ReadLine();
            empresa.AgregarCliente(new Cliente(nombre, apellido, edad, email, telefono));
            PausarMenu();
            break;

        case "8":
            Console.WriteLine("Ingrese el nombre del cliente a eliminar:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del cliente a eliminar:");
            apellido = Console.ReadLine();
            empresa.EliminarCliente(nombre, apellido);
            PausarMenu();
            break;

        case "9":
            empresa.MostrarTodosLosClientes();
            PausarMenu();
            break;

        case "0":
            salir = true;
            Console.WriteLine("Hasta luego, vuelva pronto!");
            break;

        default:
            Console.WriteLine("Opción no válida");
            PausarMenu();
            break;
    }
}


static void PausarMenu()
{
    Console.WriteLine("Presione cualquier tecla para volver al menú...");
    Console.ReadKey();
}