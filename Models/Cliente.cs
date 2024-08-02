using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_GestionEmpleados2.Models;
public class Cliente : Persona
{
    public string Email { get; set; }
    public string Telefono { get; set; }

    public Cliente(string nombre, string apellido, byte edad, string email, string telefono)
        : base(nombre, apellido, edad)
    {
        this.Email = email;
        this.Telefono = telefono;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Email: {Email}, Telefono: {Telefono}");
    }
}