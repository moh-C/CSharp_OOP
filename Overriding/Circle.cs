namespace Overriding
{
    class Circle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw of Circle");
        }
    }
}