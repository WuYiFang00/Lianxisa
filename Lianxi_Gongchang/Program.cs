using System;

namespace Lianxi_Gongchang
{
    class Program
    {
        static void Main(string[] args)
        {
            Icar icar;
            Console.WriteLine("Hello World!");
            Factory factory = new Factory();
            icar=factory.GetCar(0);
            Console.WriteLine(icar);
            Console.ReadKey();
        }
        public interface Icar
        {
            void GetCar();
        }
        public enum CarType { 
            Sport=0,
            Jeep=1,
            HatChack=2
        }
        public class SportCar : Icar
        {
            public void GetCar()
            {
                Console.WriteLine("越野车");
            }
        }
        public class JeepCar : Icar
        {
            public void GetCar()
            {
                Console.WriteLine("吉普车");
            }
        }
        public class HatChackCar : Icar
        {
            public void GetCar()
            {
                Console.WriteLine("跑车");
            }
        }
        public class ExcCar : Icar
        {
            public void GetCar()
            {
                Console.WriteLine("狗皮没有");
            }
        }
        public class Factory
        {
            public Icar GetCar(CarType carType)
            {
                switch (carType)
                {
                    case CarType.Sport:
                        return new SportCar();
                    case CarType.Jeep:
                        return new JeepCar();
                    case CarType.HatChack:
                        return new HatChackCar();
                    default:
                        return new ExcCar();
                }
            }
        }
    }
}
