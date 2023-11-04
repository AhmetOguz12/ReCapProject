using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ColorTest();
CarTest();

//BrandTest();

static void CarTest()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
    }
}

static void ColorTest()
{
    ColorManager colorManager = new ColorManager(new EfColorDal());

    foreach (var color in colorManager.GetAll())
    {
        Console.WriteLine(color.ColorName);
    }
}

static void BrandTest()
{
    BrandManager brandManager = new BrandManager(new EfBrandDal());

    foreach (var brand in brandManager.GetAll())
    {
        Console.WriteLine(brand.BrandName);
    }
}