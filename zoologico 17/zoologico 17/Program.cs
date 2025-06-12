using System;
using System.Collections.Generic;

// Clase base: Animal
public class Animal
{
    // Propiedades de la clase Animal
    public string Nombre { get; set; } // Nombre del animal
    public int Edad { get; set; } // Edad del animal
    public string Especie { get; set; } // Especie del animal

    // Constructor de la clase Animal
    public Animal(string nombre, int edad, string especie)
    {
        Nombre = nombre;
        Edad = edad;
        Especie = especie;
    }

    // Método virtual para emitir sonido (puede ser sobrescrito por clases derivadas)
    public virtual void EmitirSonido()
    {
        Console.WriteLine($"{Nombre} está emitiendo un sonido.");
    }
}

// Clase hija: Mamífero
public class Mamifero : Animal
{
    // Constructor que llama al constructor de la clase base Animal
    public Mamifero(string nombre, int edad, string especie) : base(nombre, edad, especie) { }

    // Método sobrescrito para emitir sonido específico de un mamífero
    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre}, el mamífero, está rugiendo.");
    }

    // Método específico para mamíferos
    public void Amamantar()
    {
        Console.WriteLine($"{Nombre} está amamantando a sus crías.");
    }
}

// Clase hija: Ave
public class Ave : Animal
{
    public Ave(string nombre, int edad, string especie) : base(nombre, edad, especie) { }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre}, el ave, está cantando.");
    }

    // Método específico para aves
    public void Volar()
    {
        Console.WriteLine($"{Nombre} está volando en el cielo.");
    }
}

// Clase hija: Reptil
public class Reptil : Animal
{
    public Reptil(string nombre, int edad, string especie) : base(nombre, edad, especie) { }

    public override void EmitirSonido()
    {
        Console.WriteLine($"{Nombre}, el reptil, está siseando.");
    }

    // Método específico para reptiles
    public void TomarSol()
    {
        Console.WriteLine($"{Nombre} está tomando el sol.");
    }
}

// Clase Zoológico que maneja una colección de animales
public class Zoologico
{
    private List<Animal> animales = new List<Animal>(); // Lista para almacenar animales

    // Método para agregar un animal al zoológico
    public void AgregarAnimal(Animal animal)
    {
        animales.Add(animal);
    }

    // Método para mostrar los animales y sus acciones específicas
    public void MostrarAnimales()
    {
        foreach (var animal in animales)
        {
            animal.EmitirSonido(); // Cada animal emite su sonido

            // Identificar el tipo de animal y ejecutar acciones específicas
            if (animal is Mamifero mamifero)
            {
                mamifero.Amamantar();
            }
            else if (animal is Ave ave)
            {
                ave.Volar();
            }
            else if (animal is Reptil reptil)
            {
                reptil.TomarSol();
            }
        }
    }
}

// Clase principal con el método Main
class Program
{
    static void Main()
    {
        // Crear instancia del zoológico
        Zoologico zoo = new Zoologico();

        // Agregar diferentes tipos de animales al zoológico
        zoo.AgregarAnimal(new Mamifero("León", 5, "Felino"));
        zoo.AgregarAnimal(new Ave("Águila", 3, "Rapaz"));
        zoo.AgregarAnimal(new Reptil("Serpiente", 2, "Cobra"));

        // Mostrar los animales y sus características
        zoo.MostrarAnimales();
    }
}