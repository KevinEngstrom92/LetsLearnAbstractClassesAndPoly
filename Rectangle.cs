namespace InheritanceAndPolyMorphism
{
    class Rectangle : Shape
    {
        public int OtherSide { get; set; }
        public Rectangle(string Color, int HOR, int OtherSide) : base(Color, HOR)
        {
            this.OtherSide = OtherSide;
            this.Color = Color;
            this.HeightOrRadius = HOR;
        }

        public override int Area()
        {
            return this.HeightOrRadius * this.OtherSide;
        }
    }
}
