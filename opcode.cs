namespace gamboe
{
    public readonly struct Opcode{
        public ushort data{get;}
        public byte set{get;}
        public ushort nnn {get;}
        public byte nn {get;}
        public byte n {get;}
        public byte x {get;}
        public byte y {get;}
    }
}