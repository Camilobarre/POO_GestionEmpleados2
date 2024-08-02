using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_GestionEmpleados2.Models;
public class Persona
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public byte Edad { get; set; }

    public Persona(string nombre, string apellido, byte edad)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.Edad = edad;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre} {Apellido}, Edad: {Edad}");
    }
}