namespace InheritanceAndPolyMorphism
{
    class Square : Shape
    {
        public Square(string Color, int HOR) : base(Color, HOR)
        {
            this.Color = Color;
            this.HeightOrRadius = HOR;

        }

        public override int Area()
        {
            return this.HeightOrRadius * this.HeightOrRadius;

        }

    }
}
