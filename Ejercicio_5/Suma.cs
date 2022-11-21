class Suma{
    public int num1;
    public int num2;
    public int num3;
    public int num4;
    public int num5;
    public int num6;
    public int num7;
    public int num8;
    public int suma;
    public void OPsumar(){
        Console.WriteLine("Ingrese el primer número");
        num1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número");
        num3=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el cuarto número");
        num4=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el quinto número");
        num5=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el sexto número");
        num6=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el septimo número");
        num7=Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Ingrese el octavo número");
        num8=Convert.ToInt32(Console.ReadLine());

        suma=num1+num2+num3+num4+num5+num6+num7+num8;
        Console.WriteLine("La suma de los 8 números es: "+suma);
    }
}