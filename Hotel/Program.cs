class Habitacion
{
    private int Numero;
    private int Cantidad;
    private bool Ocupada;

    public Habitacion(int numero, int cantidad)
    {
        Numero = numero;
        Cantidad = cantidad;
        Ocupada = true;
    }

    public bool Reserva()
    {
        if (Ocupada)
        {
            Ocupada = true;
            Console.WriteLine("Habitacion reservada");
            return true;
        }
        else
        {
            Console.WriteLine("Habitacion no disponible");
            return false;
        }
    }

    public bool Liberar()
    {
        if (!Ocupada)
        {
            Ocupada = false;
            Console.WriteLine("Habitacion liberada");
            return true;
        }
        else
        {
            Console.WriteLine("Habitacion no ocupada");
            return false;
        }
    }

}

class Hotel
{
    List<Habitacion> Habitaciones;

    public Hotel()
    {
        Habitaciones = new List<Habitacion>();
    }

    public void AgregarHabitacion(Habitacion habitacion)
    {
        Habitaciones.Add(habitacion);
    }

    public void MostrarHabitaciones()
    {
        foreach (var habitacion in Habitaciones)
        {
            Console.WriteLine($"Habitacion: {habitacion} - Capacidad {habitacion}");
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Hotel hotel = new Hotel();

        hotel.AgregarHabitacion(new Habitacion(2,1));
        hotel.AgregarHabitacion(new Habitacion(5,1));
        hotel.AgregarHabitacion(new Habitacion(7,1));


        Console.WriteLine("la lista de avitaciones son");
        hotel.MostrarHabitaciones();



    }
}