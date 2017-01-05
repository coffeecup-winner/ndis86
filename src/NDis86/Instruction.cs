using System.Collections.Generic;

namespace NDis86
{
    public class Instruction
    {
        public Instruction(ulong offset, MnemonicCode code, string hex, string assembly, IReadOnlyList<Operand> operands)
        {
            Offset = offset;
            Code = code;
            Hex = hex;
            Assembly = assembly;
            Operands = operands;
        }

        public ulong Offset { get; }
        MnemonicCode Code { get; }
        public string Hex { get; }
        public string Assembly { get; }
        public IReadOnlyList<Operand> Operands { get; }
    }

    public class Operand
    {
        public Operand(OperandType type, ushort size, OperandType @base, OperandType index, byte scale, byte offset, LValue lvalue)
        {
            Type = type;
            Size = size;
            Base = @base;
            Index = index;
            Scale = scale;
            Offset = offset;
            LValue = lvalue;
        }

        public OperandType Type { get; }
        public ushort Size { get; }
        public OperandType Base { get; }
        public OperandType Index { get; }
        public byte Scale { get; }
        public byte Offset { get; }
        public LValue LValue { get; }
    }
}
