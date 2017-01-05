using NDis86;
using System;

namespace NDisCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var bytes = new byte[] { 0x65, 0x67, 0x89, 0x87, 0x76, 0x65, 0x54, 0x56, 0x78, 0x89, 0x09, 0x00, 0x90, };
            var disassembler = new Disassembler(syntax: DisassemblySyntax.Intel);
            foreach (var instr in disassembler.Disassemble(bytes, withAssembly: true))
            {
                Console.WriteLine(instr.Assembly);
            }
        }
    }
}
