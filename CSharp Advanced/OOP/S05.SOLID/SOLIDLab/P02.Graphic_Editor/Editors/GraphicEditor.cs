using System;
using P02.Graphic_Editor.Models.Interfaces;

namespace P02.Graphic_Editor.Editors
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            //Type ShapeType = Assembly.GetExecutingAssembly().GetType().Where(typeof=>(IShape).IsAssignableFrom(t) && t.Name.StartsWith().First();

            Type type = shape.GetType();

            Console.WriteLine($"I'm {type.Name}");

            //if (shape is Circle)
            //{
            //    Console.WriteLine("I'm Circle");
            //}
            //else if (shape is Rectangle)
            //{
            //    Console.WriteLine("I'm Recangle");
            //}
            //else if (shape is Square)
            //{
            //    Console.WriteLine("I'm Square");
            //}
        }
    }
}
