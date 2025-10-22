class Cliente
{
     private String nombre;
    private double cantidadTotal;
    
    public Cliente(String nombre){
        this.nombre = nombre;
        this.cantidadTotal = 0;
    }

    public String GetNombre(){
        return nombre;
    }

    public void SetNombre(String nombre){
        this.nombre = nombre;
    }

    public double GetCantidadTotal(){
        return cantidadTotal;
    }

  // no pongo setter de cantidad total, ya que usamos dos metodos especificos para cambiar el valor del atributo

    public  void Ingresar(double cantidad){
        cantidadTotal += cantidad;
    }

    public  void Sacar(double cantidad){
        if (cantidad > cantidadTotal)
        {
            Console.WriteLine("No tiene suficiente Efectivo");
        }
        else
        {
            cantidadTotal -= cantidad;
        }
        
    }

    public  void MostrarInformacion() {
        Console.WriteLine("Cliente:" + GetNombre() + "| Cantidad: " + GetCantidadTotal());
    }
}