﻿using System.Diagnostics;

namespace pkNX.Structures
{
    // https://github.com/gameswop/mtasa-resources/blob/d557a72fefef57ac34780a76edf16383d3dff0e8/%5Bgamemodes%5D/%5Bamx%5D/amx-deps/src/amx/amx.c#L143
	public enum AmxOpCode : uint
	{
		NONE,              
		LOAD_PRI,
		LOAD_ALT,
		LOAD_S_PRI,
		LOAD_S_ALT,
		LREF_PRI,
		LREF_ALT,
		LREF_S_PRI,
		LREF_S_ALT,
		LOAD_I,
		LODB_I,
		CONST_PRI,
		CONST_ALT,
		ADDR_PRI,
		ADDR_ALT,
		STOR_PRI,
		STOR_ALT,
		STOR_S_PRI,
		STOR_S_ALT,
		SREF_PRI,
		SREF_ALT,
		SREF_S_PRI,
		SREF_S_ALT,
		STOR_I,
		STRB_I,
		LIDX,
		LIDX_B,
		IDXADDR,
		IDXADDR_B,
		ALIGN_PRI,
		ALIGN_ALT,
		LCTRL,
		SCTRL,
		MOVE_PRI,
		MOVE_ALT,
		XCHG,
		PUSH_PRI,
		PUSH_ALT,
		PICK,
		PUSH_C,
		PUSH,
		PUSH_S,
		PPRI,
		PALT,
		STACK,
		HEAP,
		PROC,
		RET,
		RETN,
		CALL,
		CALL_PRI,
		JUMP,
		JREL,
		JZER,
		JNZ,
		JEQ,
		JNEQ,
		JLESS,
		JLEQ,
		JGRTR,
		JGEQ,
		JSLESS,
		JSLEQ,
		JSGRTR,
		JSGEQ,
		SHL,
		SHR,
		SSHR,
		SHL_C_PRI,
		SHL_C_ALT,
		SHR_C_PRI,
		SHR_C_ALT,
		SMUL,
		SDIV,
		SDIV_ALT,
		UMUL,
		UDIV,
		UDIV_ALT,
		ADD,
		SUB,
		SUB_ALT,
		AND,
		OR,
		XOR,
		NOT,
		NEG,
		INVERT,
		ADD_C,
		SMUL_C,
		ZERO_PRI,
		ZERO_ALT,
		ZERO,
		ZERO_S,
		SIGN_PRI,
		SIGN_ALT,
		EQ,
		NEQ,
		LESS,
		LEQ,
		GRTR,
		GEQ,
		SLESS,
		SLEQ,
		SGRTR,
		SGEQ,
		EQ_C_PRI,
		EQ_C_ALT,
		INC_PRI,
		INC_ALT,
		INC,
		INC_S,
		INC_I,
		DEC_PRI,
		DEC_ALT,
		DEC,
		DEC_S,
		DEC_I,
		MOVS,
		CMPS,
		FILL,
		HALT,
		BOUNDS,
		SYSREQ_PRI,
		SYSREQ_C,
		FILE,    
		LINE,    
		SYMBOL,  
		SRANGE,  
		JUMP_PRI,
		SWITCH,
		CASETBL,
		SWAP_PRI,
		SWAP_ALT,
		PUSH_ADR,
		NOP,
		SYSREQ_N,
		SYMTAG,  
		BREAK,
		PUSH2_C,
		PUSH2,
		PUSH2_S,
		PUSH2_ADR,
		PUSH3_C,
		PUSH3,
		PUSH3_S,
		PUSH3_ADR,
		PUSH4_C,
		PUSH4,
		PUSH4_S,
		PUSH4_ADR,
		PUSH5_C,
		PUSH5,
		PUSH5_S,
		PUSH5_ADR,
		LOAD_BOTH,
		LOAD_S_BOTH,
		CONST,
		CONST_S,
		/* overlay instructions */
		ICALL,
		IRETN,
		ISWITCH,
		ICASETBL,
		/* packed instructions */
		LOAD_P_PRI,
		LOAD_P_ALT,
		LOAD_P_S_PRI,
		LOAD_P_S_ALT,
		LREF_P_PRI,
		LREF_P_ALT,
		LREF_P_S_PRI,
		LREF_P_S_ALT,
		LODB_P_I,
		CONST_P_PRI,
		CONST_P_ALT,
		ADDR_P_PRI,
		ADDR_P_ALT,
		STOR_P_PRI,
		STOR_P_ALT,
		STOR_P_S_PRI,
		STOR_P_S_ALT,
		SREF_P_PRI,
		SREF_P_ALT,
		SREF_P_S_PRI,
		SREF_P_S_ALT,
		STRB_P_I,
		LIDX_P_B,
		IDXADDR_P_B,
		ALIGN_P_PRI,
		ALIGN_P_ALT,
		PUSH_P_C,
		PUSH_P,
		PUSH_P_S,
		STACK_P,
		HEAP_P,
		SHL_P_C_PRI,
		SHL_P_C_ALT,
		SHR_P_C_PRI,
		SHR_P_C_ALT,
		ADD_P_C,
		SMUL_P_C,
		ZERO_P,
		ZERO_P_S,
		EQ_P_C_PRI,
		EQ_P_C_ALT,
		INC_P,
		INC_P_S,
		DEC_P,
		DEC_P_S,
		MOVS_P,
		CMPS_P,
		FILL_P,
		HALT_P,
		BOUNDS_P,
		PUSH_P_ADR,

		SYSREQ_D,
		SYSREQ_ND,
		NUM_OPCODES,
	}

    public static class AmxOpCodeExtensions
    {
        public static AmxOpCode Invert(this AmxOpCode spop)
        {
            switch (spop)
            {
                case AmxOpCode.JSLEQ:
                    return AmxOpCode.JSGRTR;
                case AmxOpCode.JSLESS:
                    return AmxOpCode.JSGEQ;
                case AmxOpCode.JSGRTR:
                    return AmxOpCode.JSLEQ;
                case AmxOpCode.JSGEQ:
                    return AmxOpCode.JSLESS;
                case AmxOpCode.JEQ:
                    return AmxOpCode.JNEQ;
                case AmxOpCode.JNEQ:
                    return AmxOpCode.JEQ;
                case AmxOpCode.JNZ:
                    return AmxOpCode.JZER;
                case AmxOpCode.JZER:
                    return AmxOpCode.JNZ;
                case AmxOpCode.SLEQ:
                    return AmxOpCode.SGRTR;
                case AmxOpCode.SLESS:
                    return AmxOpCode.SGEQ;
                case AmxOpCode.SGRTR:
                    return AmxOpCode.SLEQ;
                case AmxOpCode.SGEQ:
                    return AmxOpCode.SLESS;
                case AmxOpCode.EQ:
                    return AmxOpCode.NEQ;
                case AmxOpCode.NEQ:
                    return AmxOpCode.EQ;
                default:
                    Trace.Fail(nameof(spop));
                    return spop;
            }
        }
    }
}
