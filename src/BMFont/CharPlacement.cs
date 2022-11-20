
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

    public static class Chars
    {
        public const char LineBrake = '\n';
        public const char Return = '\r';
        /* a few more... */
    }
}