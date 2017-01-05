﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace NDis86
{
    public unsafe class Disassembler
    {
        private readonly UD[] _ud = new UD[1];

        public Disassembler(DisassemblyMode mode = DisassemblyMode.Mode32Bit, DisassemblySyntax? syntax = null)
        {
            IntPtr translate;
            switch (syntax)
            {
                case DisassemblySyntax.Intel:
                    translate = Marshal.GetFunctionPointerForDelegate<NativeUDis86.TranslateDelegate>(NativeUDis86.ud_translate_intel);
                    break;
                case DisassemblySyntax.ATT:
                    translate = Marshal.GetFunctionPointerForDelegate<NativeUDis86.TranslateDelegate>(NativeUDis86.ud_translate_att);
                    break;
                case null:
                    translate = IntPtr.Zero;
                    break;
                default: throw new ArgumentException();
            }
            fixed (UD* pUD = _ud)
            {
                NativeUDis86.ud_init(pUD);
                NativeUDis86.ud_set_mode(pUD, (byte)mode);
                NativeUDis86.ud_set_syntax(pUD, translate);
            }
        }

        public IReadOnlyList<Instruction> Disassemble(byte[] asm, bool withHex = false, bool withAssembly = false)
        {
            var result = new List<Instruction>();
            fixed (UD* pUD = _ud)
            fixed (byte* pAsm = asm)
            {
                NativeUDis86.ud_set_input_buffer(pUD, pAsm, (uint)asm.Length);
                while (NativeUDis86.ud_disassemble(pUD) != 0)
                {
                    result.Add(new Instruction(
                        NativeUDis86.ud_insn_off(pUD),
                        NativeUDis86.ud_insn_mnemonic(pUD),
                        withHex ? MarshalZString(NativeUDis86.ud_insn_hex(pUD)) : null,
                        withAssembly ? MarshalZString(NativeUDis86.ud_insn_asm(pUD)) : null,
                        GetOperands(pUD)));
                }
            }
            return result;
        }

        private IReadOnlyList<Operand> GetOperands(UD* pUD)
        {
            var operands = new List<Operand>();
            UDOperand* pOp = null;
            uint index = 0;
            while ((pOp = NativeUDis86.ud_insn_opr(pUD, index++)) != null)
            {
                operands.Add(new Operand(
                    pOp->type,
                    pOp->size,
                    pOp->@base,
                    pOp->index,
                    pOp->scale,
                    pOp->offset,
                    pOp->lval));
            }
            return operands;
        }

        private string MarshalZString(byte* pStr)
        {
            var sb = new StringBuilder();
            while (*pStr != 0)
            {
                sb.Append((char)*pStr++);
            }
            return sb.ToString();
        }
    }
}
