using DIinject;
using Unity;

Console.WriteLine("Hello, World!");

UnityContainer IU = new UnityContainer();
IU.RegisterType<BL>();
IU.RegisterType<DL>();
IU.RegisterType<IProduct, DL>();

BL objBL = IU.Resolve<BL>();
objBL.insert();
Console.WriteLine();