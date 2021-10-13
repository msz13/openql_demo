
namespace OpenGl {


    public class Scene {
        public Scene(int veritces, int indices)
        {
            Veritces = veritces;
            Indices = indices;
        }

        public float[] Veritces { get;  }

        public float[] Indices { get;  }

    }


    public class Rectangle: Scene {

        public Rectangle()  {}

    }

}

