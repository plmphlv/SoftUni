using P02.Graphic_Editor.Editors;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            GraphicEditor graphicEditor = new GraphicEditor();

            Circle circle = new Circle();
            Square square = new Square();
            Rectangle rectangle = new Rectangle();

            graphicEditor.DrawShape(circle);
            graphicEditor.DrawShape(square);
            graphicEditor.DrawShape(rectangle);
        }
    }
}
