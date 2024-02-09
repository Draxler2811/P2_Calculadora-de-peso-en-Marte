using System;
using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Enums;
using TecNM.Practica2.Core.Managers;
using TecNM.Practica2.Core.Services;


namespace TecNM.Practica2.App;

public static class Program{

    public static void Main(String[] args ){
        float weight = 0;

        System.Console.WriteLine("Ingresa tu peso en Kilogramos");
        Single.TryParse(System.Console.ReadLine(), out weight);

    
        // var bmi = new Bmi();
        var person = new Person{Weight = weight};

        var service = new BmiService();
        var managers = new BmiManager(service);

        Bmi bmi = managers.GetBmi(person);

        System.Console.WriteLine($"Tu peso en Marte es: {bmi.Index}");
    }
}


