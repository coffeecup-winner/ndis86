using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDis86
{
    public enum DisassemblyMode
    {
        Mode16Bit = 16,
        Mode32Bit = 32,
        Mode64Bit = 64,
    }

    public enum DisassemblySyntax
    {
        Intel,
        ATT,
    }
}
