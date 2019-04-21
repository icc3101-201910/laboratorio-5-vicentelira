using System;
using System.Collections.Generic;


public interface ICalcular
{
    int Calcular();

}

public class Calculadora : ICalcular
{
    private int numero;
    public List<ICalcular> calculadoras;

    public Calculadora(int numero){
        this.numero = numero;
        calculadoras = new List<ICalcular>();
    }
    public virtual int GetNumero()
    {
        return int.Parse("");
    }
    public int Calcular()
    {
        return numero = int.Parse("calculadoras");
    }

}

public class PersonaQueSuma5 : Calculadora,ICalcular
{
    public PersonaQueSuma5(int numero) : base(numero)
    {

    }
    public int GetNumero(int numero)
    {
        return numero;
    }
    public int Calcular(int numero)
    {
        return numero + 5;
    }
}

public class RobotFibonacci : Calculadora,ICalcular
{
    public RobotFibonacci(int numero): base (numero){

    }
    public int GetNumero(int numero)
    {
        return numero;
    }
    public int Calcular(int numero)
    {
        int a, b,aux;
        a = 0;
        b = 1;
        for (int i=0; i < numero; i++)
        {
            aux = a;
            b = aux + a;
            a = b;
        }
        return a;
    }
}

public class PerroFactorial : Calculadora,ICalcular
{
    public PerroFactorial(int numero) : base(numero)
    {

    }
    public int GetNumero(int numero)
    {
        return numero;
    }
    public int Calcular(int numero)
    {
        int resultado = 1;
        for (int i=1; i <= numero; i++)
        {
            resultado = resultado + i;
        }
        return resultado;
    }
}

public  class Cubo : Calculadora,ICalcular
{
    public Cubo(int numero) : base(numero)
    {

    }
    public int GetNumero(int numero)
    {
        return numero;
    }
    public int Calcular(int numero)
    {
        return numero * numero * numero;
    }
}

public class Cuadrado : Calculadora,ICalcular
{
    public Cuadrado(int numero) : base(numero)
    {

    }
    public int GetNumero(int numero)
    {
        return numero;
    }
    public int Calcular(int numero)
    {
        return numero * numero;
    }
}
namespace lab_cinco_po
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("elige un numero:");
            Calculadora numero1 = new PersonaQueSuma5(int.Parse(Console.ReadLine()));
            Console.WriteLine("elige un numero para fibonacci:");
            Calculadora numero2 = new RobotFibonacci(int.Parse(Console.ReadLine()));
            Console.WriteLine("elige un numero para el factorial:");
            Calculadora numero3 = new PerroFactorial(int.Parse(Console.ReadLine()));
            Console.WriteLine("elige otro numero:");
            Calculadora numero4 = new Cubo(int.Parse(Console.ReadLine()));
            Console.WriteLine("elige un numero mas:");
            Calculadora numero5 = new Cuadrado(int.Parse(Console.ReadLine()));

            List<ICalcular> numeros = new List<ICalcular>();
            numeros.Add(numero1);
            numeros.Add(numero2);
            numeros.Add(numero3);
            numeros.Add(numero4);
            numeros.Add(numero5);

            Console.WriteLine("-Tu numero + 5 es: " + numeros);
            Console.WriteLine("-Tu sucesion de fibonacci es: " + numeros);
            Console.WriteLine("-Tu numero en factorial es: " + numeros);
            Console.WriteLine("-Tu numero al cubo es : " + numeros);
            Console.WriteLine("-Tu numero al cuadrado es: " + numeros);
            Console.WriteLine("Hello World!");
        }
    }
}
