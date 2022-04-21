//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//
//
//
//	delib64.cs
//	project: DELIB
//
//
//  (c) DEDITEC GmbH, 2009-2021
//  web: http://www.deditec.de/
//  mail: vertrieb@deditec.de
//
//
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DeLib
{
    public partial class DeLibNET
    {

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // Prototypes for DELIB-Functions
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------


        // ----------------------------------------------------------------------------
        //
        [DllImport("delib64.dll")]
        public static extern uint DapiOpenModule(uint moduleID, uint nr);
        [DllImport("delib64.dll")]
        public static extern uint DapiOpenModuleEx(uint moduleID, uint nr, [In, Out] DAPI_OPENMODULEEX_STRUCT exbuffer, uint open_options);
        [DllImport("delib64.dll")]
        public static extern uint DapiCloseModule(uint handle);

        [DllImport("delib64.dll")]
        public static extern uint DapiScanModule(uint moduleID, uint cmd);
        [DllImport("delib64.dll")]
        public static extern uint DapiScanAllModulesAvailable(uint todo);
        [DllImport("delib64.dll")]
        public static extern uint DapiScanAllModulesAvailableListEcecute(uint nr, uint todo);

        [DllImport("delib64.dll")]
        public static extern uint DapiGetDELIBVersion(uint mode, uint par);

        [DllImport("delib64.dll")]
        public static extern uint DapiPing(uint handle, uint value);

        // ----------------------------------------------------------------------------
        // Register Access
        [DllImport("delib64.dll")]
        public static extern void DapiWriteByte(uint handle, uint adress, uint value);
        [DllImport("delib64.dll")]
        public static extern void DapiWriteWord(uint handle, uint adress, uint value);
        [DllImport("delib64.dll")]
        public static extern void DapiWriteLong(uint handle, uint adress, uint value);
        [DllImport("delib64.dll")]
        public static extern void DapiWriteLongLong(uint handle, uint adress, UInt64 value);

        [DllImport("delib64.dll")]
        public static extern uint DapiReadByte(uint handle, uint adress);
        [DllImport("delib64.dll")]
        public static extern uint DapiReadWord(uint handle, uint adress);
        [DllImport("delib64.dll")]
        public static extern uint DapiReadLong(uint handle, uint adress);
        [DllImport("delib64.dll")]
        public static extern UInt64 DapiReadLongLong(uint handle, uint adress);

        // ----------------------------------------------------------------------------
        // Error Handling
        [DllImport("delib64.dll")]
        public static extern uint DapiGetLastError();
        [DllImport("delib64.dll")]
        public static extern uint DapiGetLastErrorAndClear();
        [DllImport("delib64.dll")]
        public static extern uint DapiGetLastErrorText(StringBuilder msg, uint msg_length);
        [DllImport("delib64.dll")]
        public static extern void DapiClearLastError();

        [DllImport("delib64.dll")]
        public static extern uint DapiGetLastErrorByHandle(uint handle);
        [DllImport("delib64.dll")]
        public static extern void DapiClearLastErrorByHandle(uint handle);

        // ----------------------------------------------------------------------------
        // Digital Inputs
        [DllImport("delib64.dll")]
        public static extern uint DapiDIGet1(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern uint DapiDIGet8(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern uint DapiDIGet16(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern uint DapiDIGet32(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern UInt64 DapiDIGet64(uint handle, uint ch);

        [DllImport("delib64.dll")]
        public static extern uint DapiDIGetFF32(uint handle, uint ch);

        [DllImport("delib64.dll")]
        public static extern uint DapiDIGetCounter(uint handle, uint ch, uint mode);

        // ----------------------------------------------------------------------------
        // Digital Outputs
        [DllImport("delib64.dll")]
        public static extern void DapiDOSet1(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDOSet8(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDOSet16(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDOSet32(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDOSet64(uint handle, uint ch, UInt64 data);

        [DllImport("delib64.dll")]
        public static extern uint DapiDOReadback32(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern UInt64 DapiDOReadback64(uint handle, uint ch);

        [DllImport("delib64.dll")]
        public static extern void DapiDOSet1_WithTimer(uint handle, uint ch, uint data, uint time_ms);
        [DllImport("delib64.dll")]
        public static extern void DapiDOSetBit32(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDOClrBit32(uint handle, uint ch, uint data);

        // ----------------------------------------------------------------------------
        // Analog Inputs
        [DllImport("delib64.dll")]
        public static extern uint DapiADGet(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern float DapiADGetValueModeUnit(uint handle, uint ch, ref uint mode, ref uint unit);
        [DllImport("delib64.dll")]
        public static extern float DapiADGetVolt(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern float DapiADGetmA(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern void DapiADSetMode(uint handle, uint ch, uint mode);
        [DllImport("delib64.dll")]
        public static extern uint DapiADGetMode(uint handle, uint ch);

        // ----------------------------------------------------------------------------
        // Analog Outputs
        [DllImport("delib64.dll")]
        public static extern void DapiDASet(uint handle, uint ch, uint data);
        [DllImport("delib64.dll")]
        public static extern void DapiDASetVolt(uint handle, uint ch, float data);
        [DllImport("delib64.dll")]
        public static extern void DapiDASetmA(uint handle, uint ch, float data);
        [DllImport("delib64.dll")]
        public static extern float DapiDAGetValueModeUnit(uint handle, uint ch, ref uint mode, ref uint unit);
        [DllImport("delib64.dll")]
        public static extern void DapiDASetMode(uint handle, uint ch, uint mode);
        [DllImport("delib64.dll")]
        public static extern uint DapiDAGetMode(uint handle, uint ch);
        
        // ----------------------------------------------------------------------------
        // Temperature Inputs
        [DllImport("delib64.dll")]
        public static extern float DapiTempGet(uint handle, uint ch);
        
        // ----------------------------------------------------------------------------
        // Counter48 Inputs
        [DllImport("delib64.dll")]      
        public static extern void DapiCnt48ModeSet(uint handle, uint ch, uint mode);
        [DllImport("delib64.dll")]
        public static extern uint DapiCnt48ModeGet(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern uint DapiCnt48CounterGet32(uint handle, uint ch);
        [DllImport("delib64.dll")]
        public static extern UInt64 DapiCnt48CounterGet48(uint handle, uint ch);

        // ----------------------------------------------------------------------------
        // Pulse-Generator Outputs
        [DllImport("delib64.dll")]
        public static extern void DapiPulseGenSet(uint handle, uint ch, uint mode, uint par0, uint par1, uint par2);

        // ----------------------------------------------------------------------------
        // PWM Outputs
        [DllImport("delib64.dll")]
        public static extern void DapiPWMOutSet(uint handle, uint ch, float data);
        [DllImport("delib64.dll")]
        public static extern float DapiPWMOutReadback(uint handle, uint ch);

        // ----------------------------------------------------------------------------
        // Stepper
        [DllImport("delib64.dll")]
        public static extern uint DapiStepperCommand(uint handle, uint motor, uint cmd, uint par1, uint par2, uint par3, uint par4);
        [DllImport("delib64.dll")]
        public static extern uint DapiStepperCommandEx(uint handle, uint motor, uint cmd, uint par1, uint par2, uint par3, uint par4, uint par5, uint par6, uint par7);
        [DllImport("delib64.dll")]
        public static extern uint DapiStepperGetStatus(uint handle, uint motor, uint cmd);

        // ----------------------------------------------------------------------------
        // Watchdog
        [DllImport("delib64.dll")]
        public static extern void DapiWatchdogEnable(uint handle);
        [DllImport("delib64.dll")]
        public static extern void DapiWatchdogDisable(uint handle);
        [DllImport("delib64.dll")]
        public static extern void DapiWatchdogRetrigger(uint handle);

        // --------------------------------------------------------
        // Fifo
        [DllImport("delib64.dll")]
        public static extern uint DapiReadFifo(uint handle, uint fifo_instance, uint type, [MarshalAs(UnmanagedType.LPArray)]byte[] buff, uint buff_len);
        [DllImport("delib64.dll")]
        public static extern uint DapiWriteFifo(uint handle, uint fifo_instance, uint type, [MarshalAs(UnmanagedType.LPArray)]byte[] buff, uint buff_len);
        // ----------------------------------------------------------------------------
        // CAN
        [StructLayout(LayoutKind.Sequential)]
        public class DAPI_CAN_MESSAGE_STRUCT
        {
            public uint address;
            public uint timestamp;
            public uint use_extended_ids;
            public uint rtr;
            public uint data_count;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
            public byte[] data;
        };

        [DllImport("delib64.dll")]
        public static extern uint DapiCANCommand(uint handle, uint cmd, uint par1, uint par2, uint par3);
        [DllImport("delib64.dll")]
        public static extern uint DapiCANGetPacket(uint handle, uint message_box_nr, [In, Out] DAPI_CAN_MESSAGE_STRUCT can_msg);
        [DllImport("delib64.dll")]
        public static extern void DapiCANSendPacket(uint handle, [In, Out] DAPI_CAN_MESSAGE_STRUCT can_msg);

        // ----------------------------------------------------------------------------
        // Special
        [DllImport("delib64.dll")]
        public static extern uint DapiSpecialCommand(uint handle, uint cmd, uint par1, uint par2, uint par3);
        [DllImport("delib64.dll")]
        public static extern uint DapiSpecialCommandExt(uint handle, uint cmd, uint par1, uint par2, uint par3, ref uint par4_ref, ref uint par5_ref, ref uint par6_ref, [MarshalAs(UnmanagedType.LPArray)]byte[] buff1, uint buff1_size, [MarshalAs(UnmanagedType.LPArray)]byte[] buff2, uint buff2_size, [MarshalAs(UnmanagedType.LPArray)]byte[] buff3, uint buff3_size, ref uint buff3_length_ref);

        [DllImport("delib64.dll")]
        public static extern uint DapiReadMultipleBytes(uint handle, uint adress, uint adress_depth, uint increments, [MarshalAs(UnmanagedType.LPArray)]byte[] buff, uint buff_len);
        [DllImport("delib64.dll")]
        public static extern uint DapiWriteMultipleBytes(uint handle, uint adress, uint adress_depth, uint increments, [MarshalAs(UnmanagedType.LPArray)]byte[] buff, uint buff_len);

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        
    }
}

