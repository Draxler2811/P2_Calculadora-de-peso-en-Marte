using TecNM.Practica2.Core.Entities;
using TecNM.Practica2.Core.Managers.Interfaces;
using TecNM.Practica2.Core.Services.Interfaces;

namespace TecNM.Practica2.Core.Managers;

public class BmiManager : IBmiManager{
    private readonly IBmiService _service;

    public BmiManager(IBmiService service){
        _service = service;
    }

    public Bmi GetBmi(Person person){
        return _service.ProcessBmi(person);
    }
}