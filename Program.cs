using System;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenGl;

namespace OpenGl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Demo window");

            var settings = new NativeWindowSettings() 
            {
                Size = new Vector2i(1280, 720),

                Location = new Vector2i(100, 100),
              
                Title = "OpenGl Demo",
               
            };

            var scene = new Scene( );

            using (var window = new DemoWindow(GameWindowSettings.Default, settings))
            {
                
                window.Run();
            }

        }

           
    }
}
