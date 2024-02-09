using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Enums;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Services;

public class BmiService : IBmiService{
    public Bmi ProcessBmi(Person person){

    var bmi = new Bmi();
   float gravedadTierra = 9.81F;
   float gravedadMarte = 3.711F;

    bmi.Index = person.Weight * (gravedadMarte / gravedadTierra);
    
    return bmi;
    }
}