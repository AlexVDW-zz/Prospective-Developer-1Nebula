public class Factory
{
    private readonly RobotService _robotService;
    private readonly PartsService _partsService;
    private readonly CarService _carService;
    
    public Factory(RobotService robotService, PartsService partsService, CarService carService)
    {
        _robotService = robotService;
        _partsService = partsService;
        _carService = carService;
    }

    public Robot BuildRobot(RobotTypeEnum RobotType)
    {
        switch(RobotType){
            case RoboticDog:
                var parts = GetPartsFor(RobotType);
                return _robotService.BuildRobotDog(parts);
            case RoboticCat:
                var parts = GetPartsFor(RobotType);
                return _robotService.BuildRobotCat(parts);
            case RoboticCar:
                var parts = GetPartsFor(RobotType);
                return _robotService.BuildRobotCar(parts);
            default:
                return null;
        }
    }

    public Car BuildCar(CarTypeEnum CarType)
    {
        switch(CarType){
            case Toyota:
            case Ford:
            case Opel:
            case Honda:
                var parts = GetPartsFor(CarType);
                return _carService.BuildCar(parts);
            default:
                return null;
        }
    }

    private List<Parts> GetPartsFor(RobotTypeEnum RobotType)
    {
        return _partsService.GetParts(RobotType);
    }

    private List<Parts> GetPartsFor(CarTypeEnum CarType)
    {
        return _partsService.GetParts(CarType);
    }
}