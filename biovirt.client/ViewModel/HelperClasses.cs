using Blazor.Extensions.Canvas.WebGL;

namespace BioVirt.Client.ViewModel
{
    public class ProgramInfo
    {
        public WebGLProgram Program { get; set; }
        public UniformLocations UniformLocations { get; set; } = new UniformLocations();
        public AttribLocations AttribLocations { get; set; } = new AttribLocations();
    }

    public class UniformLocations
    {
        public WebGLUniformLocation ProjectionMatrix { get; set; }
        public WebGLUniformLocation ModelViewMatrix { get; set; }
    }

    public class AttribLocations
    {
        public int VertexPosition { get; set; }
        public int VertexColor { get; set; }
    }

    public class Buffers
    {
        public WebGLBuffer Position { get; set; }
        public WebGLBuffer Color { get; set; }
        public WebGLBuffer Indices { get; set; }
    }
}
