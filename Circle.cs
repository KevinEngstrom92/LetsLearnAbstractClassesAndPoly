namespace InheritanceAndPolyMorphism
{
    class Circle : Shape
    {
        const double Pi = 3.1415;
        public Circle(string Color, int HOR) : base(Color, HOR)
        {
            this.Color = Color;
            this.HeightOrRadius = HOR;
        }

        public override int Area()
        {
            return (int)((this.HeightOrRadius * this.HeightOrRadius) * Pi);
        }
    }
}
