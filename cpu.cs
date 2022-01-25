using System;
namespace gamboe
{
    public class cpu
    {
        private readonly byte[] _mem = new byte[0x1000]; // ram
        private readonly byte[] V = new byte[16]; // data registers
        private UInt16 I = 0; // 16 bit address register
        private readonly UInt16[] _stack = new UInt16[16];

        private UInt16 _progc = 0; // program counter
        private UInt16 _stackp = 0; // stack pos
        
        private const int screen_width = 64;
        private const int screen_height = 32;
        private readonly bool[,] screen = new bool[screen_width, screen_height];
        
    }
}