using System;
using System.Runtime.InteropServices;

namespace NDis86
{
    #region Mnemonic constants
    public enum MnemonicCode
    {
        Iaaa,
        Iaad,
        Iaam,
        Iaas,
        Iadc,
        Iadd,
        Iaddpd,
        Iaddps,
        Iaddsd,
        Iaddss,
        Iaddsubpd,
        Iaddsubps,
        Iaesdec,
        Iaesdeclast,
        Iaesenc,
        Iaesenclast,
        Iaesimc,
        Iaeskeygenassist,
        Iand,
        Iandnpd,
        Iandnps,
        Iandpd,
        Iandps,
        Iarpl,
        Iblendpd,
        Iblendps,
        Iblendvpd,
        Iblendvps,
        Ibound,
        Ibsf,
        Ibsr,
        Ibswap,
        Ibt,
        Ibtc,
        Ibtr,
        Ibts,
        Icall,
        Icbw,
        Icdq,
        Icdqe,
        Iclc,
        Icld,
        Iclflush,
        Iclgi,
        Icli,
        Iclts,
        Icmc,
        Icmova,
        Icmovae,
        Icmovb,
        Icmovbe,
        Icmovg,
        Icmovge,
        Icmovl,
        Icmovle,
        Icmovno,
        Icmovnp,
        Icmovns,
        Icmovnz,
        Icmovo,
        Icmovp,
        Icmovs,
        Icmovz,
        Icmp,
        Icmppd,
        Icmpps,
        Icmpsb,
        Icmpsd,
        Icmpsq,
        Icmpss,
        Icmpsw,
        Icmpxchg,
        Icmpxchg16b,
        Icmpxchg8b,
        Icomisd,
        Icomiss,
        Icpuid,
        Icqo,
        Icrc32,
        Icvtdq2pd,
        Icvtdq2ps,
        Icvtpd2dq,
        Icvtpd2pi,
        Icvtpd2ps,
        Icvtpi2pd,
        Icvtpi2ps,
        Icvtps2dq,
        Icvtps2pd,
        Icvtps2pi,
        Icvtsd2si,
        Icvtsd2ss,
        Icvtsi2sd,
        Icvtsi2ss,
        Icvtss2sd,
        Icvtss2si,
        Icvttpd2dq,
        Icvttpd2pi,
        Icvttps2dq,
        Icvttps2pi,
        Icvttsd2si,
        Icvttss2si,
        Icwd,
        Icwde,
        Idaa,
        Idas,
        Idec,
        Idiv,
        Idivpd,
        Idivps,
        Idivsd,
        Idivss,
        Idppd,
        Idpps,
        Iemms,
        Ienter,
        Iextractps,
        If2xm1,
        Ifabs,
        Ifadd,
        Ifaddp,
        Ifbld,
        Ifbstp,
        Ifchs,
        Ifclex,
        Ifcmovb,
        Ifcmovbe,
        Ifcmove,
        Ifcmovnb,
        Ifcmovnbe,
        Ifcmovne,
        Ifcmovnu,
        Ifcmovu,
        Ifcom,
        Ifcom2,
        Ifcomi,
        Ifcomip,
        Ifcomp,
        Ifcomp3,
        Ifcomp5,
        Ifcompp,
        Ifcos,
        Ifdecstp,
        Ifdiv,
        Ifdivp,
        Ifdivr,
        Ifdivrp,
        Ifemms,
        Iffree,
        Iffreep,
        Ifiadd,
        Ificom,
        Ificomp,
        Ifidiv,
        Ifidivr,
        Ifild,
        Ifimul,
        Ifincstp,
        Ifist,
        Ifistp,
        Ifisttp,
        Ifisub,
        Ifisubr,
        Ifld,
        Ifld1,
        Ifldcw,
        Ifldenv,
        Ifldl2e,
        Ifldl2t,
        Ifldlg2,
        Ifldln2,
        Ifldpi,
        Ifldz,
        Ifmul,
        Ifmulp,
        Ifndisi,
        Ifneni,
        Ifninit,
        Ifnop,
        Ifnsave,
        Ifnsetpm,
        Ifnstcw,
        Ifnstenv,
        Ifnstsw,
        Ifpatan,
        Ifprem,
        Ifprem1,
        Ifptan,
        Ifrndint,
        Ifrstor,
        Ifrstpm,
        Ifscale,
        Ifsin,
        Ifsincos,
        Ifsqrt,
        Ifst,
        Ifstp,
        Ifstp1,
        Ifstp8,
        Ifstp9,
        Ifsub,
        Ifsubp,
        Ifsubr,
        Ifsubrp,
        Iftst,
        Ifucom,
        Ifucomi,
        Ifucomip,
        Ifucomp,
        Ifucompp,
        Ifxam,
        Ifxch,
        Ifxch4,
        Ifxch7,
        Ifxrstor,
        Ifxsave,
        Ifxtract,
        Ifyl2x,
        Ifyl2xp1,
        Igetsec,
        Ihaddpd,
        Ihaddps,
        Ihlt,
        Ihsubpd,
        Ihsubps,
        Iidiv,
        Iimul,
        Iin,
        Iinc,
        Iinsb,
        Iinsd,
        Iinsertps,
        Iinsw,
        Iint,
        Iint1,
        Iint3,
        Iinto,
        Iinvd,
        Iinvept,
        Iinvlpg,
        Iinvlpga,
        Iinvvpid,
        Iiretd,
        Iiretq,
        Iiretw,
        Ija,
        Ijae,
        Ijb,
        Ijbe,
        Ijcxz,
        Ijecxz,
        Ijg,
        Ijge,
        Ijl,
        Ijle,
        Ijmp,
        Ijno,
        Ijnp,
        Ijns,
        Ijnz,
        Ijo,
        Ijp,
        Ijrcxz,
        Ijs,
        Ijz,
        Ilahf,
        Ilar,
        Ilddqu,
        Ildmxcsr,
        Ilds,
        Ilea,
        Ileave,
        Iles,
        Ilfence,
        Ilfs,
        Ilgdt,
        Ilgs,
        Ilidt,
        Illdt,
        Ilmsw,
        Ilock,
        Ilodsb,
        Ilodsd,
        Ilodsq,
        Ilodsw,
        Iloop,
        Iloope,
        Iloopne,
        Ilsl,
        Ilss,
        Iltr,
        Imaskmovdqu,
        Imaskmovq,
        Imaxpd,
        Imaxps,
        Imaxsd,
        Imaxss,
        Imfence,
        Iminpd,
        Iminps,
        Iminsd,
        Iminss,
        Imonitor,
        Imontmul,
        Imov,
        Imovapd,
        Imovaps,
        Imovbe,
        Imovd,
        Imovddup,
        Imovdq2q,
        Imovdqa,
        Imovdqu,
        Imovhlps,
        Imovhpd,
        Imovhps,
        Imovlhps,
        Imovlpd,
        Imovlps,
        Imovmskpd,
        Imovmskps,
        Imovntdq,
        Imovntdqa,
        Imovnti,
        Imovntpd,
        Imovntps,
        Imovntq,
        Imovq,
        Imovq2dq,
        Imovsb,
        Imovsd,
        Imovshdup,
        Imovsldup,
        Imovsq,
        Imovss,
        Imovsw,
        Imovsx,
        Imovsxd,
        Imovupd,
        Imovups,
        Imovzx,
        Impsadbw,
        Imul,
        Imulpd,
        Imulps,
        Imulsd,
        Imulss,
        Imwait,
        Ineg,
        Inop,
        Inot,
        Ior,
        Iorpd,
        Iorps,
        Iout,
        Ioutsb,
        Ioutsd,
        Ioutsw,
        Ipabsb,
        Ipabsd,
        Ipabsw,
        Ipackssdw,
        Ipacksswb,
        Ipackusdw,
        Ipackuswb,
        Ipaddb,
        Ipaddd,
        Ipaddq,
        Ipaddsb,
        Ipaddsw,
        Ipaddusb,
        Ipaddusw,
        Ipaddw,
        Ipalignr,
        Ipand,
        Ipandn,
        Ipavgb,
        Ipavgusb,
        Ipavgw,
        Ipblendvb,
        Ipblendw,
        Ipclmulqdq,
        Ipcmpeqb,
        Ipcmpeqd,
        Ipcmpeqq,
        Ipcmpeqw,
        Ipcmpestri,
        Ipcmpestrm,
        Ipcmpgtb,
        Ipcmpgtd,
        Ipcmpgtq,
        Ipcmpgtw,
        Ipcmpistri,
        Ipcmpistrm,
        Ipextrb,
        Ipextrd,
        Ipextrq,
        Ipextrw,
        Ipf2id,
        Ipf2iw,
        Ipfacc,
        Ipfadd,
        Ipfcmpeq,
        Ipfcmpge,
        Ipfcmpgt,
        Ipfmax,
        Ipfmin,
        Ipfmul,
        Ipfnacc,
        Ipfpnacc,
        Ipfrcp,
        Ipfrcpit1,
        Ipfrcpit2,
        Ipfrsqit1,
        Ipfrsqrt,
        Ipfsub,
        Ipfsubr,
        Iphaddd,
        Iphaddsw,
        Iphaddw,
        Iphminposuw,
        Iphsubd,
        Iphsubsw,
        Iphsubw,
        Ipi2fd,
        Ipi2fw,
        Ipinsrb,
        Ipinsrd,
        Ipinsrq,
        Ipinsrw,
        Ipmaddubsw,
        Ipmaddwd,
        Ipmaxsb,
        Ipmaxsd,
        Ipmaxsw,
        Ipmaxub,
        Ipmaxud,
        Ipmaxuw,
        Ipminsb,
        Ipminsd,
        Ipminsw,
        Ipminub,
        Ipminud,
        Ipminuw,
        Ipmovmskb,
        Ipmovsxbd,
        Ipmovsxbq,
        Ipmovsxbw,
        Ipmovsxdq,
        Ipmovsxwd,
        Ipmovsxwq,
        Ipmovzxbd,
        Ipmovzxbq,
        Ipmovzxbw,
        Ipmovzxdq,
        Ipmovzxwd,
        Ipmovzxwq,
        Ipmuldq,
        Ipmulhrsw,
        Ipmulhrw,
        Ipmulhuw,
        Ipmulhw,
        Ipmulld,
        Ipmullw,
        Ipmuludq,
        Ipop,
        Ipopa,
        Ipopad,
        Ipopcnt,
        Ipopfd,
        Ipopfq,
        Ipopfw,
        Ipor,
        Iprefetch,
        Iprefetchnta,
        Iprefetcht0,
        Iprefetcht1,
        Iprefetcht2,
        Ipsadbw,
        Ipshufb,
        Ipshufd,
        Ipshufhw,
        Ipshuflw,
        Ipshufw,
        Ipsignb,
        Ipsignd,
        Ipsignw,
        Ipslld,
        Ipslldq,
        Ipsllq,
        Ipsllw,
        Ipsrad,
        Ipsraw,
        Ipsrld,
        Ipsrldq,
        Ipsrlq,
        Ipsrlw,
        Ipsubb,
        Ipsubd,
        Ipsubq,
        Ipsubsb,
        Ipsubsw,
        Ipsubusb,
        Ipsubusw,
        Ipsubw,
        Ipswapd,
        Iptest,
        Ipunpckhbw,
        Ipunpckhdq,
        Ipunpckhqdq,
        Ipunpckhwd,
        Ipunpcklbw,
        Ipunpckldq,
        Ipunpcklqdq,
        Ipunpcklwd,
        Ipush,
        Ipusha,
        Ipushad,
        Ipushfd,
        Ipushfq,
        Ipushfw,
        Ipxor,
        Ircl,
        Ircpps,
        Ircpss,
        Ircr,
        Irdmsr,
        Irdpmc,
        Irdrand,
        Irdtsc,
        Irdtscp,
        Irep,
        Irepne,
        Iret,
        Iretf,
        Irol,
        Iror,
        Iroundpd,
        Iroundps,
        Iroundsd,
        Iroundss,
        Irsm,
        Irsqrtps,
        Irsqrtss,
        Isahf,
        Isalc,
        Isar,
        Isbb,
        Iscasb,
        Iscasd,
        Iscasq,
        Iscasw,
        Iseta,
        Isetae,
        Isetb,
        Isetbe,
        Isetg,
        Isetge,
        Isetl,
        Isetle,
        Isetno,
        Isetnp,
        Isetns,
        Isetnz,
        Iseto,
        Isetp,
        Isets,
        Isetz,
        Isfence,
        Isgdt,
        Ishl,
        Ishld,
        Ishr,
        Ishrd,
        Ishufpd,
        Ishufps,
        Isidt,
        Iskinit,
        Isldt,
        Ismsw,
        Isqrtpd,
        Isqrtps,
        Isqrtsd,
        Isqrtss,
        Istc,
        Istd,
        Istgi,
        Isti,
        Istmxcsr,
        Istosb,
        Istosd,
        Istosq,
        Istosw,
        Istr,
        Isub,
        Isubpd,
        Isubps,
        Isubsd,
        Isubss,
        Iswapgs,
        Isyscall,
        Isysenter,
        Isysexit,
        Isysret,
        Itest,
        Iucomisd,
        Iucomiss,
        Iud2,
        Iunpckhpd,
        Iunpckhps,
        Iunpcklpd,
        Iunpcklps,
        Ivaddpd,
        Ivaddps,
        Ivaddsd,
        Ivaddss,
        Ivaddsubpd,
        Ivaddsubps,
        Ivaesdec,
        Ivaesdeclast,
        Ivaesenc,
        Ivaesenclast,
        Ivaesimc,
        Ivaeskeygenassist,
        Ivandnpd,
        Ivandnps,
        Ivandpd,
        Ivandps,
        Ivblendpd,
        Ivblendps,
        Ivblendvpd,
        Ivblendvps,
        Ivbroadcastsd,
        Ivbroadcastss,
        Ivcmppd,
        Ivcmpps,
        Ivcmpsd,
        Ivcmpss,
        Ivcomisd,
        Ivcomiss,
        Ivcvtdq2pd,
        Ivcvtdq2ps,
        Ivcvtpd2dq,
        Ivcvtpd2ps,
        Ivcvtps2dq,
        Ivcvtps2pd,
        Ivcvtsd2si,
        Ivcvtsd2ss,
        Ivcvtsi2sd,
        Ivcvtsi2ss,
        Ivcvtss2sd,
        Ivcvtss2si,
        Ivcvttpd2dq,
        Ivcvttps2dq,
        Ivcvttsd2si,
        Ivcvttss2si,
        Ivdivpd,
        Ivdivps,
        Ivdivsd,
        Ivdivss,
        Ivdppd,
        Ivdpps,
        Iverr,
        Iverw,
        Ivextractf128,
        Ivextractps,
        Ivhaddpd,
        Ivhaddps,
        Ivhsubpd,
        Ivhsubps,
        Ivinsertf128,
        Ivinsertps,
        Ivlddqu,
        Ivmaskmovdqu,
        Ivmaskmovpd,
        Ivmaskmovps,
        Ivmaxpd,
        Ivmaxps,
        Ivmaxsd,
        Ivmaxss,
        Ivmcall,
        Ivmclear,
        Ivminpd,
        Ivminps,
        Ivminsd,
        Ivminss,
        Ivmlaunch,
        Ivmload,
        Ivmmcall,
        Ivmovapd,
        Ivmovaps,
        Ivmovd,
        Ivmovddup,
        Ivmovdqa,
        Ivmovdqu,
        Ivmovhlps,
        Ivmovhpd,
        Ivmovhps,
        Ivmovlhps,
        Ivmovlpd,
        Ivmovlps,
        Ivmovmskpd,
        Ivmovmskps,
        Ivmovntdq,
        Ivmovntdqa,
        Ivmovntpd,
        Ivmovntps,
        Ivmovq,
        Ivmovsd,
        Ivmovshdup,
        Ivmovsldup,
        Ivmovss,
        Ivmovupd,
        Ivmovups,
        Ivmpsadbw,
        Ivmptrld,
        Ivmptrst,
        Ivmread,
        Ivmresume,
        Ivmrun,
        Ivmsave,
        Ivmulpd,
        Ivmulps,
        Ivmulsd,
        Ivmulss,
        Ivmwrite,
        Ivmxoff,
        Ivmxon,
        Ivorpd,
        Ivorps,
        Ivpabsb,
        Ivpabsd,
        Ivpabsw,
        Ivpackssdw,
        Ivpacksswb,
        Ivpackusdw,
        Ivpackuswb,
        Ivpaddb,
        Ivpaddd,
        Ivpaddq,
        Ivpaddsb,
        Ivpaddsw,
        Ivpaddusb,
        Ivpaddusw,
        Ivpaddw,
        Ivpalignr,
        Ivpand,
        Ivpandn,
        Ivpavgb,
        Ivpavgw,
        Ivpblendvb,
        Ivpblendw,
        Ivpclmulqdq,
        Ivpcmpeqb,
        Ivpcmpeqd,
        Ivpcmpeqq,
        Ivpcmpeqw,
        Ivpcmpestri,
        Ivpcmpestrm,
        Ivpcmpgtb,
        Ivpcmpgtd,
        Ivpcmpgtq,
        Ivpcmpgtw,
        Ivpcmpistri,
        Ivpcmpistrm,
        Ivperm2f128,
        Ivpermilpd,
        Ivpermilps,
        Ivpextrb,
        Ivpextrd,
        Ivpextrq,
        Ivpextrw,
        Ivphaddd,
        Ivphaddsw,
        Ivphaddw,
        Ivphminposuw,
        Ivphsubd,
        Ivphsubsw,
        Ivphsubw,
        Ivpinsrb,
        Ivpinsrd,
        Ivpinsrq,
        Ivpinsrw,
        Ivpmaddubsw,
        Ivpmaddwd,
        Ivpmaxsb,
        Ivpmaxsd,
        Ivpmaxsw,
        Ivpmaxub,
        Ivpmaxud,
        Ivpmaxuw,
        Ivpminsb,
        Ivpminsd,
        Ivpminsw,
        Ivpminub,
        Ivpminud,
        Ivpminuw,
        Ivpmovmskb,
        Ivpmovsxbd,
        Ivpmovsxbq,
        Ivpmovsxbw,
        Ivpmovsxwd,
        Ivpmovsxwq,
        Ivpmovzxbd,
        Ivpmovzxbq,
        Ivpmovzxbw,
        Ivpmovzxdq,
        Ivpmovzxwd,
        Ivpmovzxwq,
        Ivpmuldq,
        Ivpmulhrsw,
        Ivpmulhuw,
        Ivpmulhw,
        Ivpmulld,
        Ivpmullw,
        Ivpor,
        Ivpsadbw,
        Ivpshufb,
        Ivpshufd,
        Ivpshufhw,
        Ivpshuflw,
        Ivpsignb,
        Ivpsignd,
        Ivpsignw,
        Ivpslld,
        Ivpslldq,
        Ivpsllq,
        Ivpsllw,
        Ivpsrad,
        Ivpsraw,
        Ivpsrld,
        Ivpsrldq,
        Ivpsrlq,
        Ivpsrlw,
        Ivpsubb,
        Ivpsubd,
        Ivpsubq,
        Ivpsubsb,
        Ivpsubsw,
        Ivpsubusb,
        Ivpsubusw,
        Ivpsubw,
        Ivptest,
        Ivpunpckhbw,
        Ivpunpckhdq,
        Ivpunpckhqdq,
        Ivpunpckhwd,
        Ivpunpcklbw,
        Ivpunpckldq,
        Ivpunpcklqdq,
        Ivpunpcklwd,
        Ivpxor,
        Ivrcpps,
        Ivrcpss,
        Ivroundpd,
        Ivroundps,
        Ivroundsd,
        Ivroundss,
        Ivrsqrtps,
        Ivrsqrtss,
        Ivshufpd,
        Ivshufps,
        Ivsqrtpd,
        Ivsqrtps,
        Ivsqrtsd,
        Ivsqrtss,
        Ivstmxcsr,
        Ivsubpd,
        Ivsubps,
        Ivsubsd,
        Ivsubss,
        Ivtestpd,
        Ivtestps,
        Ivucomisd,
        Ivucomiss,
        Ivunpckhpd,
        Ivunpckhps,
        Ivunpcklpd,
        Ivunpcklps,
        Ivxorpd,
        Ivxorps,
        Ivzeroall,
        Ivzeroupper,
        Iwait,
        Iwbinvd,
        Iwrmsr,
        Ixadd,
        Ixchg,
        Ixcryptcbc,
        Ixcryptcfb,
        Ixcryptctr,
        Ixcryptecb,
        Ixcryptofb,
        Ixgetbv,
        Ixlatb,
        Ixor,
        Ixorpd,
        Ixorps,
        Ixrstor,
        Ixsave,
        Ixsetbv,
        Ixsha1,
        Ixsha256,
        Ixstore,
        Iinvalid,
        I3dnow,
        Inone,
        Idb,
        Ipause,
        MAX_MNEMONIC_CODE
    }
    #endregion

    #region Registers and operand types
    public enum OperandType
    {
        None,

        /* 8 bit GPRs */
        AL, CL, DL, BL,
        AH, CH, DH, BH,
        SPL, BPL, SIL, DIL,
        R8B, R9B, R10B, R11B,
        R12B, R13B, R14B, R15B,

        /* 16 bit GPRs */
        AX, CX, DX, BX,
        SP, BP, SI, DI,
        R8W, R9W, R10W, R11W,
        R12W, R13W, R14W, R15W,

        /* 32 bit GPRs */
        EAX, ECX, EDX, EBX,
        ESP, EBP, ESI, EDI,
        R8D, R9D, R10D, R11D,
        R12D, R13D, R14D, R15D,

        /* 64 bit GPRs */
        RAX, RCX, RDX, RBX,
        RSP, RBP, RSI, RDI,
        R8, R9, R10, R11,
        R12, R13, R14, R15,

        /* segment registers */
        ES, CS, SS, DS,
        FS, GS,

        /* control registers*/
        CR0, CR1, CR2, CR3,
        CR4, CR5, CR6, CR7,
        CR8, CR9, CR10, CR11,
        CR12, CR13, CR14, CR15,

        /* debug registers */
        DR0, DR1, DR2, DR3,
        DR4, DR5, DR6, DR7,
        DR8, DR9, DR10, DR11,
        DR12, DR13, DR14, DR15,

        /* mmx registers */
        MM0, MM1, MM2, MM3,
        MM4, MM5, MM6, MM7,

        /* x87 registers */
        ST0, ST1, ST2, ST3,
        ST4, ST5, ST6, ST7,

        /* extended multimedia registers */
        XMM0, XMM1, XMM2, XMM3,
        XMM4, XMM5, XMM6, XMM7,
        XMM8, XMM9, XMM10, XMM11,
        XMM12, XMM13, XMM14, XMM15,

        /* 256B multimedia registers */
        YMM0, YMM1, YMM2, YMM3,
        YMM4, YMM5, YMM6, YMM7,
        YMM8, YMM9, YMM10, YMM11,
        YMM12, YMM13, YMM14, YMM15,

        RIP,

        /* Operand Types */
        Register,
        Memory,
        Pointer,
        Immediate,
        ImmediateBranch,
        Constant
    }
    #endregion

    [StructLayout(LayoutKind.Sequential)]
    public struct Ptr
    {
        public ushort seg;
        public uint off;
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct LValue
    {
        [FieldOffset(0)]
        public sbyte @sbyte;
        [FieldOffset(0)]
        public byte ubyte;
        [FieldOffset(0)]
        public short sword;
        [FieldOffset(0)]
        public ushort uword;
        [FieldOffset(0)]
        public int sdword;
        [FieldOffset(0)]
        public uint udword;
        [FieldOffset(0)]
        public long sqword;
        [FieldOffset(0)]
        public ulong uqword;
        [FieldOffset(0)]
        public Ptr ptr;
    };

    [StructLayout(LayoutKind.Sequential)]
    public struct UDOperand
    {
        public OperandType type;
        public ushort size;
        public OperandType @base;
        public OperandType index;
        public byte scale;
        public byte offset;
        public LValue lval;
        /*
        * internal use only
        */
        public ulong _legacy; /* this will be removed in 1.8 */
        public byte _oprcode;
    };

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UD
    {
        /*
        * input buffering
        */
        public IntPtr in_hook; // int (* inp_hook) (UD* ud);
        public IntPtr inp_file; // FILE* inp_file;
        public IntPtr inp_buf; // const uint8_t* inp_buf;
        public uint inp_buf_size;
        public uint inp_buf_index;
        public byte inp_curr;
        public uint inp_ctr;
        public fixed byte inp_sess[64];
        public int inp_end;
        public int inp_peek;

        public IntPtr translator; // void (* translator) (UD* ud);
        public ulong insn_offset;
        public fixed byte insn_hexcode[64];

        /*
         * Assembly output buffer
         */
        public IntPtr asm_buf; // char* asm_buf;
        public uint asm_buf_size;
        public uint asm_buf_fill;
        public fixed byte asm_buf_int[128];

        /*
        * Symbol resolver for use in the translation phase.
        */
        public IntPtr sym_resolver; // const char* (*sym_resolver)(UD* ud, uint64_t addr, int64_t *offset);

        public byte dis_mode;
        public ulong pc;
        public byte vendor;
        public MnemonicCode mnemonic;
        public UDOperand operand_0;
        public UDOperand operand_1;
        public UDOperand operand_2;
        public UDOperand operand_3;

        public byte error;
        public byte _rex;
        public byte pfx_rex;
        public byte pfx_seg;
        public byte pfx_opr;
        public byte pfx_adr;
        public byte pfx_lock;
        public byte pfx_str;
        public byte pfx_rep;
        public byte pfx_repe;
        public byte pfx_repne;
        public byte opr_mode;
        public byte adr_mode;
        public byte br_far;
        public byte br_near;
        public byte have_modrm;
        public byte modrm;
        public byte modrm_offset;
        public byte vex_op;
        public byte vex_b1;
        public byte vex_b2;
        public byte primary_opcode;
        public IntPtr user_opaque_data; // void* user_opaque_data;
        public IntPtr itab_entry; // struct ud_itab_entry * itab_entry;
        public IntPtr ud_lookup_table_list_entry; // struct ud_lookup_table_list_entry *le;
    }

    public static unsafe class NativeUDis86
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void TranslateDelegate(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_init(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_mode(UD* ud, byte mode);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_pc(UD* ud, ulong pc);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_input_hook(UD* ud, IntPtr hook);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_input_buffer(UD* ud, byte* buf, uint size);

        // [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        // public static extern void ud_set_input_file(UD* ud, IntPtr file);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_vendor(UD* ud, uint vendor);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_syntax(UD* ud, IntPtr translate);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_input_skip(UD* ud, uint skip);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ud_input_end(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ud_decode(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ud_disassemble(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_translate_intel(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_translate_att(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ud_insn_asm(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern UD* ud_insn_ptr(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ud_insn_off(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ud_insn_hex(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ud_insn_len(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern UDOperand* ud_insn_opr(UD* ud, uint n);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ud_opr_is_sreg(UDOperand* opr);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ud_opr_is_gpr(UDOperand* opr);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern MnemonicCode ud_insn_mnemonic(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ud_lookup_mnemonic(MnemonicCode code);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_user_opaque_data(UD* ud, IntPtr data);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ud_get_user_opaque_data(UD* ud);

        [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ud_set_asm_buffer(UD* ud, byte* buf, uint size);

        // [DllImport("libudis86", CallingConvention = CallingConvention.Cdecl)]
        // public static extern void ud_set_sym_resolver(UD* ud, const char* (*resolver)(UD* ud, uint64_t addr, int64_t *offset));
    }
}
