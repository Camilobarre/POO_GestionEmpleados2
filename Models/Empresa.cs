using System;
using System.Collections.Generic;
using System.Linq;
using POO_GestionEmpleados2.Models;
public class Empresa
{
    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public List<Empleado> ListaEmpleados { get; set; }
    public List<Cliente> ListaClientes { get; set; }

    public Empresa(string nombre, string direccion)
    {
        Nombre = nombre;
        Direccion = direccion;
        ListaEmpleados = new List<Empleado>();
        ListaClientes = new List<Cliente>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        ListaEmpleados.Add(empleado);
    }

    public void EliminarEmpleado(string nombre, string apellido)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.Nombre == nombre && e.Apellido == apellido);
        if (empleado != null)
        {
            ListaEmpleados.Remove(empleado);
        }
    }

    public void MostrarTodosLosEmpleados()
    {
        foreach (var empleado in ListaEmpleados)
        {
            empleado.MostrarInformacion();
        }
    }

    public void ActualizarEmpleado(string numeroDeIdentificacion, string nuevaPosicion, decimal nuevoSalario)
    {
        var empleado = ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
        if (empleado != null)
        {
            empleado.Posicion = nuevaPosicion;
            empleado.Salario = nuevoSalario;
        }
    }

    public Empleado BuscarEmpleado(string numeroDeIdentificacion)
    {
        return ListaEmpleados.FirstOrDefault(e => e.NumeroDeIdentificacion == numeroDeIdentificacion);
    }

    public void MostrarEmpleadosPorCargo(string cargo)
    {
        var empleadosPorCargo = ListaEmpleados.Where(e => e.Posicion == cargo).ToList();
        foreach (var empleado in empleadosPorCargo)
        {
            empleado.MostrarInformacion();
        }
    }

    public void AgregarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    public void EliminarCliente(string nombre, string apellido)
    {
        var cliente = ListaClientes.FirstOrDefault(c => c.Nombre == nombre && c.Apellido == apellido);
        if (cliente != null)
        {
            ListaClientes.Remove(cliente);
        }
    }

    public void MostrarTodosLosClientes()
    {
        foreach (var cliente in ListaClientes)
        {
            cliente.MostrarInformacion();
        }
    }
}
