namespace WPC.SOLID.LSP_1
{
    abstract class Vehicle
    {
        public string Name { get; set; }
        public abstract void Move();
    }

    class Airplane : Vehicle
    {
        public void Fly()
        {
            Console.WriteLine("I am flying!");
        }

        public override void Move()
        {
            Fly();
        }
    }

    class Car : Vehicle
    {
        public override void Move()
        {
            Drive();
        }

        private void Drive()
        {
            Console.WriteLine("I am driving!");
        }
    }
}

namespace WPC.SOLID.LSP_2
{
    public abstract class Shape
    {
        public abstract int Area { get; }
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int Area => A * B;
    }

    //złamanie LSP
    public class Square : Rectangle
    {
        public override int A { set => base.A = base.B = value; }
        public override int B { set => base.B = base.A = value; }
    }

}
