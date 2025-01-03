using System;

class Empleado
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public decimal SalarioBase { get; set; }

    public Empleado(string nombre, int edad, decimal salarioBase)
    {
        Nombre = nombre;
        Edad = edad;
        SalarioBase = salarioBase;
    }

    public virtual void MostrarInformacion()
    {
        Console.WriteLine($"Hola {Nombre}, tu edad es {Edad} y el salario base es {SalarioBase:C}.");
    }
}

class EmpleadoTiempoCompleto : Empleado
{
    public decimal Bonificacion { get; set; }

    public EmpleadoTiempoCompleto(string nombre, int edad, decimal salarioBase, decimal bonificacion)
        : base(nombre, edad, salarioBase)
    {
        Bonificacion = bonificacion;
    }

    public void CalcularSalarioTotal()
    {
        decimal salarioTotal = SalarioBase + Bonificacion;
        Console.WriteLine($"El salario total de {Nombre} es {salarioTotal:C}.");
    }
}

class EmpleadoPorHoras : Empleado
{
    public int HorasTrabajadas { get; set; }
    public decimal TarifaPorHora { get; set; }

    public EmpleadoPorHoras(string nombre, int edad, decimal salarioBase, int horasTrabajadas, decimal tarifaPorHora)
        : base(nombre, edad, salarioBase)
    {
        HorasTrabajadas = horasTrabajadas;
        TarifaPorHora = tarifaPorHora;
    }

    public void CalcularSalarioTotal()
    {
        decimal salarioTotal = HorasTrabajadas * TarifaPorHora;
        Console.WriteLine($"El salario total de {Nombre} es {salarioTotal:C}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        EmpleadoTiempoCompleto empleado1 = new EmpleadoTiempoCompleto("Juan", 30, 1500, 500);
        empleado1.MostrarInformacion();
        empleado1.CalcularSalarioTotal();

        EmpleadoPorHoras empleado2 = new EmpleadoPorHoras("Ana", 25, 0, 40, 15);
        empleado2.MostrarInformacion();
        empleado2.CalcularSalarioTotal();
    }
}
