using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_GestionEmpleados2.Models;
public class Empleado : Persona
{
    public Guid Id { get; set; }
    public string? NumeroDeIdentificacion { get; set; }
    public string? Posicion { get; set; }
    public decimal Salario { get; set; }

    public Empleado(string nombre, string apellido, byte edad, string numeroDeIdentifiacion, string posicion, decimal salario)
    : base(nombre, apellido, edad)
    {
        this.Id = Guid.NewGuid();
        this.NumeroDeIdentificacion = numeroDeIdentifiacion;
        this.Posicion = posicion;
        this.Salario = salario;
    }

    private decimal CalcularBonifiacion()
    {
        return Salario * 0.1m;
    }

    public override void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Número de identificación: {NumeroDeIdentificacion}, Salario: {Salario + CalcularBonifiacion()}");
    }
}