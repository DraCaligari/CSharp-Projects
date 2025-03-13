
// Variables para almacenar la información de los animales
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// Variables para soportar la entrada de datos
int maxPets = 8;
string? readResult;
string menuSelection = "";

// Array para almacenar los datos de los animales en tiempo de ejecución
string[,] ourAnimals = new string[maxPets, 6];

// Crear algunas entradas iniciales en el array ourAnimals
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "mediana, color crema, hembra, golden retriever, pesa alrededor de 65 libras. Está entrenada para hacer sus necesidades fuera de casa.";
            animalPersonalityDescription = "le encanta que le froten la barriga y perseguir su cola. Da muchos besos.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "grande, color marrón rojizo, macho, golden retriever, pesa alrededor de 85 libras. Está entrenado para hacer sus necesidades fuera de casa.";
            animalPersonalityDescription = "le encanta que le froten las orejas cuando te recibe en la puerta. Le gusta apoyarse y dar abrazos de perro.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "pequeña, blanca, hembra, pesa alrededor de 8 libras. Está entrenada para usar la caja de arena.";
            animalPersonalityDescription = "amigable";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    // Almacenar la información del animal en el array ourAnimals
    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Especie: " + animalSpecies;
    ourAnimals[i, 2] = "Edad: " + animalAge;
    ourAnimals[i, 3] = "Apodo: " + animalNickname;
    ourAnimals[i, 4] = "Descripción física: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personalidad: " + animalPersonalityDescription;
}

// Bucle principal del menú
do
{
    // Mostrar las opciones del menú principal
    Console.Clear();
    Console.WriteLine("Bienvenido a la aplicación Contoso PetFriends. Las opciones del menú son:");
    Console.WriteLine(" 1. Listar toda la información actual de las mascotas");
    Console.WriteLine(" 2. Agregar un nuevo amigo animal al array ourAnimals");
    Console.WriteLine(" 3. Asegurar que las edades y descripciones físicas estén completas");
    Console.WriteLine(" 4. Asegurar que los apodos y descripciones de personalidad estén completos");
    Console.WriteLine(" 5. Editar la edad de un animal");
    Console.WriteLine(" 6. Editar la descripción de personalidad de un animal");
    Console.WriteLine(" 7. Mostrar todos los gatos con una característica específica");
    Console.WriteLine(" 8. Mostrar todos los perros con una característica específica");
    Console.WriteLine();
    Console.WriteLine("Ingrese el número de su selección (o escriba 'exit' para salir del programa)");

    // Leer la selección del usuario
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    // Procesar la opción seleccionada del menú
    switch (menuSelection)
    {
        case "1":
            // Listar toda la información actual de las mascotas
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    Console.WriteLine();
                    for (int j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            Console.WriteLine("\n\rPresione Enter para continuar");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Agregar un nuevo amigo animal al array ourAnimals
            string otraMascota = "y";
            int contadorMascotas = 0;

            // Contar cuántas mascotas ya están registradas
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    contadorMascotas += 1;
                }
            }

            // Verificar si hay espacio para más mascotas
            if (contadorMascotas < maxPets)
            {
                Console.WriteLine($"Actualmente tenemos {contadorMascotas} mascotas que necesitan hogar. Podemos aceptar {(maxPets - contadorMascotas)} más.");
            }

            // Bucle para agregar nuevas mascotas
            while (otraMascota == "y" && contadorMascotas < maxPets)
            {
                bool entradaValida = false;

                // Obtener la especie (gato o perro)
                do
                {
                    Console.WriteLine("\n\rIngrese 'dog' o 'cat' para comenzar una nueva entrada");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            entradaValida = false;
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while (entradaValida == false);

                // Construir el ID del animal (por ejemplo, C1, C2, D3)
                animalID = animalSpecies.Substring(0, 1) + (contadorMascotas + 1).ToString();

                // Obtener la edad del animal (puede ser '?' si se desconoce)
                do
                {
                    int edadMascota;
                    Console.WriteLine("Ingrese la edad de la mascota o '?' si es desconocida");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            entradaValida = int.TryParse(animalAge, out edadMascota);
                        }
                        else
                        {
                            entradaValida = true;
                        }
                    }
                } while (entradaValida == false);

                // Obtener la descripción física del animal (puede estar vacía)
                do
                {
                    Console.WriteLine("Ingrese una descripción física de la mascota (tamaño, color, género, peso, entrenamiento)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPhysicalDescription == "")
                        {
                            animalPhysicalDescription = "por definir";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // Obtener la descripción de la personalidad del animal (puede estar vacía)
                do
                {
                    Console.WriteLine("Ingrese una descripción de la personalidad de la mascota (gustos, disgustos, trucos, nivel de energía)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "por definir";
                        }
                    }
                } while (animalPersonalityDescription == "");

                // Obtener el apodo del animal (puede estar vacío)
                do
                {
                    Console.WriteLine("Ingrese un apodo para la mascota");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "por definir";
                        }
                    }
                } while (animalNickname == "");

                // Almacenar la información de la mascota en el array ourAnimals
                ourAnimals[contadorMascotas, 0] = "ID #: " + animalID;
                ourAnimals[contadorMascotas, 1] = "Especie: " + animalSpecies;
                ourAnimals[contadorMascotas, 2] = "Edad: " + animalAge;
                ourAnimals[contadorMascotas, 3] = "Apodo: " + animalNickname;
                ourAnimals[contadorMascotas, 4] = "Descripción física: " + animalPhysicalDescription;
                ourAnimals[contadorMascotas, 5] = "Personalidad: " + animalPersonalityDescription;

                // Incrementar el contador de mascotas
                contadorMascotas += 1;

                // Verificar si se ha alcanzado el límite de mascotas
                if (contadorMascotas < maxPets)
                {
                    // Preguntar si se desea agregar otra mascota
                    Console.WriteLine("¿Desea ingresar información para otra mascota? (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();
                        if (readResult != null)
                        {
                            otraMascota = readResult.ToLower();
                        }
                    } while (otraMascota != "y" && otraMascota != "n");
                }
            }

            // Notificar si se ha alcanzado el límite de mascotas
            if (contadorMascotas >= maxPets)
            {
                Console.WriteLine("Hemos alcanzado el límite de mascotas que podemos gestionar.");
                Console.WriteLine("Presione Enter para continuar.");
                readResult = Console.ReadLine();
            }
            break;

        case "3":
            // Asegurar que las edades y descripciones físicas estén completas
            Console.WriteLine("Proyecto de desafío - vuelva pronto para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Asegurar que los apodos y descripciones de personalidad estén completos
            Console.WriteLine("Proyecto de desafío - vuelva pronto para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Editar la edad de un animal
            Console.WriteLine("EN CONSTRUCCIÓN - vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Editar la descripción de personalidad de un animal
            Console.WriteLine("EN CONSTRUCCIÓN - vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Mostrar todos los gatos con una característica específica
            Console.WriteLine("EN CONSTRUCCIÓN - vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Mostrar todos los perros con una característica específica
            Console.WriteLine("EN CONSTRUCCIÓN - vuelva el próximo mes para ver el progreso.");
            Console.WriteLine("Presione Enter para continuar.");
            readResult = Console.ReadLine();
            break;

        default:
            break;
    }

} while (menuSelection != "exit");
