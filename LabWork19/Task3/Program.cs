using Task3;

IShape circle = new Circle();
circle = new BoldShapeDecorator(circle);
circle = new RedShapeDecorator(circle);
circle.Draw();

Console.WriteLine();


IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle());
Console.WriteLine("Circle with normal border");
circle.Draw();

Console.WriteLine("Circle of red border");
redCircle.Draw();

Console.WriteLine("Rectangle of red border");
redRectangle.Draw();