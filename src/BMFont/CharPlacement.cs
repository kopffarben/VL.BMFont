
namespace BMFont
{
    using Stride.Core.Mathematics; 

    public struct CharPlacement
    {
        public Int2 SrcPos;
        public Int2 SrcSize;
        public Int2 DesPos;
        public Int2 DesSize;
        public CharPlacement(Int2 SrcPos, Int2 SrcSize, Int2 DesPos, Int2 DesSize)
        {
            this.SrcPos = SrcPos;
            this.SrcSize = SrcSize;
            this.DesPos = DesPos;
            this.DesSize = DesSize;
        }
    }

    public struct CharPlacementUV
    {
        public Vector2 SrcPos;
        public Vector2 SrcSize;
        public Vector2 DesPos;
        public Vector2 DesSize;
        public CharPlacementUV(Vector2 SrcPos, Vector2 SrcSize, Vector2 DesPos, Vector2 DesSize)
        {
            this.SrcPos = SrcPos;
            this.SrcSize = SrcSize;
            this.DesPos = DesPos;
            this.DesSize = DesSize;
        }
    }

    public static class Chars
    {
        public const char LineBrake = '\n';
        public const char Return = '\r';
        /* a few more... */
    }
}