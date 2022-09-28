namespace MyApp;
// Bad example

//interface ILaundry
//{
//    void WashClothes();
//    void DryClothes();
//}

//class ComboWashingMashine : ILaundry
//{
//    public void WashClothes()
//    {
//        //do the work
//    }

//    public void DryClothes()
//    {
//        //do the work
//    }
//}

//class SimpleWashingMashine : ILaundry
//{
//    public void WashClothes()
//    {
//        //yep, I can do that as well
//    }

//    public void DryClothes()
//    {
//        //oops, no can't do
//        throw new NotImplementedException();
//    }
//}

//Good Example
interface IWashLaundry
{
    void WashClothes();
}

interface IDryLaundry
{
    void DryClothes();
}

class ComboWashingMashine : IWashLaundry, IDryLaundry
{
    public void WashClothes()
    {
        //do the work
    }

    public void DryClothes()
    {
        //do the work
    }
}

class SimpleWashingMashine : IWashLaundry
{
    public void WashClothes()
    {
        //yep, I can do that as well
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }
}