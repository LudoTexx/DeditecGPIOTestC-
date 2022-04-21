//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//***********************************************************************************
//
//
//
//	delib_defines.cs
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
        public class ModuleID
        {
            // all Modul-ID's
            public const uint USB_Interface8                    = 1;
            public const uint USB_CAN_STICK                     = 2;
            public const uint USB_LOGI_500                      = 3;
            public const uint USB_SER_DEBUG                     = 4;
            public const uint RO_SER                            = 5;
            public const uint USB_BITP_200                      = 6;
            public const uint RO_USB1                           = 7;
            public const uint RO_USB                            = 7;
            public const uint RO_ETH                            = 8;
            public const uint USB_MINI_STICK                    = 9;
            public const uint USB_LOGI_18                       = 10;
            public const uint RO_CAN                            = 11;
            public const uint USB_SPI_MON                       = 12;
            public const uint USB_WATCHDOG                      = 13;
            public const uint USB_OPTOIN_8                      = 14;
            public const uint USB_RELAIS_8                      = 14;
            public const uint USB_OPTOIN_8_RELAIS_8             = 15;
            public const uint USB_OPTOIN_16_RELAIS_16           = 16;
            public const uint USB_OPTOIN_32                     = 16;
            public const uint USB_RELAIS_32                     = 16;
            public const uint USB_OPTOIN_32_RELAIS_32           = 17;
            public const uint USB_OPTOIN_64                     = 17;
            public const uint USB_RELAIS_64                     = 17;
            public const uint BS_USB_8                          = 15;
            public const uint BS_USB_16                         = 16;
            public const uint BS_USB_32                         = 17;
            public const uint USB_TTL_32                        = 18;
            public const uint USB_TTL_64                        = 18;
            public const uint RO_ETH_INTERN                     = 19;

            public const uint BS_SER                            = 20;
            public const uint BS_CAN                            = 21;
            public const uint BS_ETH                            = 22;

            public const uint NET_ETH                           = 23;

            public const uint RO_CAN2                           = 24;
            public const uint RO_USB2                           = 25;
            public const uint RO_ETH_LC                         = 26;
            //
            public const uint ETH_RELAIS_8                      = 27;
            public const uint ETH_OPTOIN_8                      = 27;
            public const uint ETH_O4_R4_ADDA                    = 28;
            //
            public const uint ETHERNET_MODULE                   = 29;
            //
            public const uint ETH_TTL_64                        = 30;
            //
            public const uint NET_USB2                          = 31;
            public const uint NET_ETH_LC                        = 32;
            public const uint NET_USB1                          = 33;
            public const uint NET_SER                           = 34;
            public const uint NET_CAN_OPEN                      = 35;
            public const uint NET_RAS_PI                        = 36;

            public const uint USB_CANOPEN_STICK 				= 37;			// USB-CAN-Stick for CANopen Modules

            public const uint ETH_CUST_0                        = 38;

            public const uint WEU_RELAIS_8                      = 39;			// USB
            public const uint WEU_OPTO_8                        = 39;			// USB
            public const uint WEU_E_RELAIS_8                    = 40;			// ETH

            public const uint BS_WEU                            = 41;			// USB
            public const uint BS_WEU_E                          = 42;			// ETH
        }

        //
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // Declarations

        // ----------------------------------------------------------------------------
        // Special Function-Codes
        public const uint DAPI_SPECIAL_CMD_GET_MODULE_CONFIG                        = 0x01;
        public const uint DAPI_SPECIAL_CMD_TIMEOUT                                  = 0x02;
        public const uint DAPI_SPECIAL_CMD_DI                                       = 0x0a;
        public const uint DAPI_SPECIAL_CMD_SET_DIR_DX_1                             = 0x03;
        public const uint DAPI_SPECIAL_CMD_SET_DIR_DX_8                             = 0x04;
        public const uint DAPI_SPECIAL_CMD_GET_MODULE_VERSION                       = 0x05;
        public const uint DAPI_SPECIAL_CMD_DA                                       = 0x06;
        public const uint DAPI_SPECIAL_CMD_WATCHDOG                                 = 0x07;
        public const uint DAPI_SPECIAL_CMD_COUNTER                                  = 0x08;
        public const uint DAPI_SPECIAL_CMD_AD                                       = 0x09;
        public const uint DAPI_SPECIAL_CMD_CNT48                                    = 0x0b;
        public const uint DAPI_SPECIAL_CMD_SW_FIFO		                            = 0x0c;
        public const uint DAPI_SPECIAL_CMD_MODULE_REBOOT                            = 0x0d;
        public const uint DAPI_SPECIAL_CMD_MODULE_RESCAN                            = 0x0e;
        public const uint DAPI_SPECIAL_CMD_RESTART_CHECK_MODULE_CONFIG              = 0x0f;
        public const uint DAPI_SPECIAL_CMD_PWM                                      = 0x13;
        public const uint DAPI_SPECIAL_CMD_GET_DIR_DX_1                             = 0x14;	 
		public const uint DAPI_SPECIAL_CMD_GET_DIR_DX_8                             = 0x15;
        public const uint DAPI_SPECIAL_CMD_CANOPEN_STICK                            = 0x16;
        public const uint DAPI_SPECIAL_CMD_GET_INTERNAL_STATISTIC                   = 0x17;
     	public const uint DAPI_SPECIAL_CMD_GET_HANDLE_VARIABLE						= 0x18;

        // values for PAR1
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DI                     = 1;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DI_FF                  = 7;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DI_COUNTER             = 8;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DO                     = 2;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DX                     = 3;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_AD                     = 4;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_DA                     = 5;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_TEMP                   = 9;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_STEPPER                = 6;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_CNT48                  = 10;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_PULSE_GEN              = 11;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_PWM_OUT                = 12;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_HW_INTERFACE1          = 13;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_SW_FEATURE1            = 14;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_HW_GROUP               = 15;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_SW_CLASS               = 16;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_MODULE_ID              = 17;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_MC_FEATURE1            = 18;
        public const uint DAPI_SPECIAL_GET_MODULE_CONFIG_PAR_TCP_FEATURE1           = 19;
        //
        public const uint DAPI_SPECIAL_GET_MODULE_PAR_VERSION_0                     = 0;
        public const uint DAPI_SPECIAL_GET_MODULE_PAR_VERSION_1                     = 1;
        public const uint DAPI_SPECIAL_GET_MODULE_PAR_VERSION_2                     = 2;
        public const uint DAPI_SPECIAL_GET_MODULE_PAR_VERSION_3                     = 3;
        //
        public const uint DAPI_SPECIAL_TIMEOUT_SET_VALUE_SEC                        = 1;
        public const uint DAPI_SPECIAL_TIMEOUT_ACTIVATE                             = 2;
		public const uint DAPI_SPECIAL_TIMEOUT_ACTIVATE_AUTO_REACTIVATE				= 10;
		public const uint DAPI_SPECIAL_TIMEOUT_ACTIVATE_SECURE_OUTPUTS				= 11;
        public const uint DAPI_SPECIAL_TIMEOUT_DEACTIVATE                           = 3;
        public const uint DAPI_SPECIAL_TIMEOUT_GET_STATUS                           = 4;
        public const uint DAPI_SPECIAL_TIMEOUT_DO_VALUE_LOAD_DEFAULT				= 5;
        public const uint DAPI_SPECIAL_TIMEOUT_DO_VALUE_MASK_WR_CLR32				= 6;
        public const uint DAPI_SPECIAL_TIMEOUT_DO_VALUE_MASK_RD_CLR32				= 7;
        public const uint DAPI_SPECIAL_TIMEOUT_DO_VALUE_MASK_WR_SET32				= 8;
        public const uint DAPI_SPECIAL_TIMEOUT_DO_VALUE_MASK_RD_SET32               = 9;
        //
        public const uint DAPI_SPECIAL_DI_FF_FILTER_VALUE_SET                       = 1;
        public const uint DAPI_SPECIAL_DI_FF_FILTER_VALUE_GET                       = 2;
        public const uint DAPI_SPECIAL_DI_FILTER_VALUE_SET                       	= 3;
        public const uint DAPI_SPECIAL_DI_FILTER_VALUE_GET                       	= 4;
        //
        public const uint DAPI_SPECIAL_RO_AD_FIFO_ACTIVATE                          = 2;
        public const uint DAPI_SPECIAL_RO_AD_FIFO_DEACTIVATE                        = 3;
        public const uint DAPI_SPECIAL_RO_AD_FIFO_GET_STATUS                        = 4;
        public const uint DAPI_SPECIAL_RO_AD_FIFO_SET_INTERVAL_MS                   = 5;
        public const uint DAPI_SPECIAL_RO_AD_FIFO_SET_CHANNEL                       = 6;
        public const uint DAPI_SPECIAL_RO_AD_FIFO_INIT                              = 7;
		//
        public const uint DAPI_SPECIAL_AD_READ_MULTIPLE_AD                          = 1;
        public const uint DAPI_SPECIAL_AD_FILTER_SET                                = 8;
        public const uint DAPI_SPECIAL_AD_FILTER_GET                                = 9;
        //
        public const uint DAPI_SPECIAL_DA_PAR_DA_SET_FACTORY_DEFAULTS_TO_OUTPUT     = 1;
        public const uint DAPI_SPECIAL_DA_PAR_DA_SAVE_EEPROM_CONFIG                 = 2;
        public const uint DAPI_SPECIAL_DA_PAR_DA_LOAD_EEPROM_CONFIG                 = 3;
        //
        public const uint DAPI_SPECIAL_WATCHDOG_SET_TIMEOUT_MSEC                    = 1;
        public const uint DAPI_SPECIAL_WATCHDOG_GET_TIMEOUT_MSEC                    = 2;
        public const uint DAPI_SPECIAL_WATCHDOG_GET_STATUS                          = 3;
        public const uint DAPI_SPECIAL_WATCHDOG_GET_WD_COUNTER_MSEC                 = 4;
        public const uint DAPI_SPECIAL_WATCHDOG_GET_TIMEOUT_RELAIS_COUNTER_MSEC     = 5;
        public const uint DAPI_SPECIAL_WATCHDOG_SET_TIMEOUT_REL1_COUNTER_MSEC       = 6;
        public const uint DAPI_SPECIAL_WATCHDOG_SET_TIMEOUT_REL2_COUNTER_MSEC       = 7;
        //
        public const uint DAPI_SPECIAL_COUNTER_LATCH_ALL                            = 1;
        public const uint DAPI_SPECIAL_COUNTER_LATCH_ALL_WITH_RESET                 = 2;
        public const uint DAPI_SPECIAL_COUNTER_PRELOAD_SET							= 3;
        public const uint DAPI_SPECIAL_COUNTER_PRELOAD_GET							= 4;
        public const uint DAPI_SPECIAL_COUNTER_MODE_SET								= 5;
        public const uint DAPI_SPECIAL_COUNTER_MODE_GET								= 6;
        public const uint DAPI_SPECIAL_COUNTER_GET									= 7;
        //
        public const uint DAPI_SPECIAL_CNT48_RESET_SINGLE                           = 1;
        public const uint DAPI_SPECIAL_CNT48_RESET_GROUP8                           = 2;
        public const uint DAPI_SPECIAL_CNT48_LATCH_GROUP8                           = 3;
        public const uint DAPI_SPECIAL_CNT48_DI_GET1                                = 4;
        //
        public const uint DAPI_SPECIAL_SW_FIFO_INIT_AND_CLEAR						= 1;
        public const uint DAPI_SPECIAL_SW_FIFO_ACTIVATE                             = 2;
        public const uint DAPI_SPECIAL_SW_FIFO_DEACTIVATE                           = 3;
        public const uint DAPI_SPECIAL_SW_FIFO_SET_SUBMODULE                        = 4;
        public const uint DAPI_SPECIAL_SW_FIFO_SET_CHANNEL							= 5;
        public const uint DAPI_SPECIAL_SW_FIFO_SET_FREQUENCY_HZ						= 6;
        public const uint DAPI_SPECIAL_SW_FIFO_SET_MODE								= 7;
        public const uint DAPI_SPECIAL_SW_FIFO_IO_ACTIVATE                          = 8;
        public const uint DAPI_SPECIAL_SW_FIFO_IO_DEACTIVATE                        = 9;
		
        public const uint DAPI_SPECIAL_SW_FIFO_GET_STATUS							= 0x81;		// Bit 7 ist gesetzt bei Lesebefehlen
        public const uint DAPI_SPECIAL_SW_FIFO_GET_BYTES_FREE						= 0x82;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_ACTIVITY							= 0x83;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_SUBMODULE						= 0x84;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_CHANNEL							= 0x85;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_FREQUENCY_HZ						= 0x86;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_MODE								= 0x87;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_BYTES_PER_SAMPLE					= 0x88;
		public const uint DAPI_SPECIAL_SW_FIFO_GET_INSTANCE_TYPE					= 0x89;
        public const uint DAPI_SPECIAL_SW_FIFO_GET_STATUS_BYTES_OUT                 = 0x90;
        //
		// Bit 6,7=Timestamp. 00 = E9 Start / 01=E9 Start + 2 Byte Timestamp /  10=E9 Start + 4 Byte Timestamp
		// Bit 5: (0=output/1=input)
		// Bit 4: (0=Analog/1=digital)
		// IN
        public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_TS_0B                      	= 0x00;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_TS_2B						= 0x40;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_TS_4B						= 0x80;
		//
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_TESTCOUNTER32				= 0x3F;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_TESTCOUNTER16				= 0x3E;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_AD16							= 0x20;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_AD16_ON_CHANGE				= 0x21;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_AD18							= 0x22;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_AD18_ON_CHANGE				= 0x23;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_DI8							= 0x30;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_DI8_ON_CHANGE				= 0x31;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_DI16							= 0x32;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_IN_DI16_ON_CHANGE				= 0x33;
		// OUT
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_OUT_TS_0B_NO_START				= 0x00;
		//
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_OUT_DA16						= 0x20;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_OUT_DO8							= 0x30;
		public const uint DAPI_SPECIAL_SW_FIFO_MODE_OUT_DO16						= 0x31;
		//
		public const uint DAPI_SPECIAL_INSTANCE_TYPE_FIFO_IN						= 0x01;
		public const uint DAPI_SPECIAL_INSTANCE_TYPE_FIFO_OUT						= 0x02;
		//
        public const uint DAPI_SPECIAL_SW_FIFO_STATUS_IS_ACTIVE						= 0x01;
        public const uint DAPI_SPECIAL_SW_FIFO_STATUS_IO_IS_ACTIVE					= 0x02;
        public const uint DAPI_SPECIAL_SW_FIFO_STATUS_FIFO_OVERFLOW					= 0x04;
        public const uint DAPI_SPECIAL_SW_FIFO_STATUS_FIFO_UNDERRUN					= 0x08;
        public const uint DAPI_SPECIAL_SW_FIFO_STATUS_FIFO_OUT_OF_SYNC				= 0x10;
		//
        public const uint DAPI_SPECIAL_PWM_FREQ_LOAD_DFAULT                         = 1;
        public const uint DAPI_SPECIAL_PWM_FREQ_SAVE_EEPROM                         = 2;
        public const uint DAPI_SPECIAL_PWM_FREQ_LOAD_EEPROM                         = 3;
        public const uint DAPI_SPECIAL_PWM_FREQ_SET                                 = 4;
        public const uint DAPI_SPECIAL_PWM_FREQ_READBACK                            = 5;
		//
        public const uint DAPI_SPECIAL_CANOPEN_STICK_FLUSH							= 1;
        public const uint DAPI_SPECIAL_CANOPEN_STICK_SDO_READ						= 2;

        // values for PAR2
        public const uint DAPI_SPECIAL_AD_CH0_CH15                                  = 0;
        public const uint DAPI_SPECIAL_AD_CH16_CH31                                 = 1;
        public const uint DAPI_SPECIAL_AD_CH32_CH47                                 = 2;
        public const uint DAPI_SPECIAL_AD_CH48_CH63                                 = 3;

        // ----------------------------------------------------------------------------
        // DapiScanModules-Codes
        public const uint DAPI_SCANMODULE_GET_MODULES_AVAILABLE                     = 1;

        // ----------------------------------------------------------------------------
        // SOFTWARE Features Class
        public const uint DAPI_SW_CLASS_TYPE_OF_MODULE_IDENTIFICATION   = (1<<0);           // Bit 0
        public const uint DAPI_SW_CLASS_DI_DO_DX_CHANNELS               = (1<<1);           // Bit 1
        public const uint DAPI_SW_CLASS_AD_DA_CHANNELS                  = (1<<2);           // Bit 2

        // ----------------------------------------------------------------------------
        // Hardware Group
        public const uint DAPI_HW_GROUP_RO                              = (1<<0);           // Bit 0
        public const uint DAPI_HW_GROUP_LOGICANALYZER                   = (1<<1);           // Bit 1
        public const uint DAPI_HW_GROUP_DI_DO_AD_DA                     = (1<<2);           // Bit 2
        public const uint DAPI_HW_GROUP_USB                             = (1<<3);           // Bit 3
        public const uint DAPI_HW_GROUP_BS                              = (1<<4);           // Bit 4
        public const uint DAPI_HW_GROUP_NET                             = (1<<5);           // Bit 5
        public const uint DAPI_HW_GROUP_ETH                             = (1<<6);           // Bit 6
        public const uint DAPI_HW_GROUP_CUST                            = (1<<7);           // Bit 7

        // --------------------------------------------------------
        // Software Feature Bits
        public const uint DAPI_SW_FEATURE_BIT_SUPPORTED_BY_FIRMWARE    				= 0x00000001;
        public const uint DAPI_SW_FEATURE_BIT_RO_AD_SOFTWARE_FIFO					= 0x00000002;
        public const uint DAPI_SW_FEATURE_BIT_SW_FIFO								= 0x00000100;
        public const uint DAPI_SW_FEATURE_BIT_CFG_DO_CMD_SET_CLR_BIT_32				= 0x00000004;
        public const uint DAPI_SW_FEATURE_BIT_EEPROM_RN23              				= 0x00000008;
        public const uint DAPI_SW_FEATURE_BIT_EEPROM_E2_2K              			= 0x00000020;
        public const uint DAPI_SW_FEATURE_BIT_EEPROM_E2_32K             			= 0x00000040;
        public const uint DAPI_SW_FEATURE_BIT_EEPROM_FS_SUPPORT         			= 0x00000080;
        public const uint DAPI_SW_FEATURE_BIT_DX_1_MODE                 			= 0x00000010;
        public const uint DAPI_SW_FEATURE_BIT_AUTO_OUTPUTS_OFF_TIMEOUT  			= 0x02000000;
        public const uint DAPI_SW_FEATURE_BIT_AUTO_OUTPUTS_OFF_TIMEOUT_WITH_MASK	= 0x00008000;
        public const uint DAPI_SW_FEATURE_BIT_SUPP_INDIVIDUAL_CH_NAMES  			= 0x00001000;
        public const uint DAPI_SW_FEATURE_BIT_DEV_IO_REG_ERR_SUPP       			= 0x00002000;
        public const uint DAPI_SW_FEATURE_BIT_SUPP_SYSTEM_INFO          			= 0x00004000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_WATCHDOG              			= 0x10000000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_DI                    			= 0x20000000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_DI_CNT                			= 0x40000000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_DI_CNT_LATCH          			= 0x00080000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_DI_FF                 			= 0x80000000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_DO                    			= 0x01000000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_DO_WITH_TIMER         			= 0x00040000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_PWM_OUT               			= 0x04000000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_DX                    			= 0x08000000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_DA                    			= 0x00100000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_AD                    			= 0x00200000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_CNT_OUT32             			= 0x00400000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_CNT_IN48              			= 0x00800000;

        public const uint DAPI_SW_FEATURE_BIT_CFG_TEMP                  			= 0x00010000;
        public const uint DAPI_SW_FEATURE_BIT_CFG_STEPPER               			= 0x00020000;

        // --------------------------------------------------------
        // Hardware Interface Bits
        public const uint DAPI_HW_INTERFACE_BIT_SUPPORTED_BY_FIRMWARE   			= 0x00000001;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_ETH                             = 0x00000002;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_WIFI                            = 0x00000100;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_CAN                             = 0x00000004;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_RS232               			= 0x00000008;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_RS232_RS485         			= 0x00000010;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_USB1                			= 0x00000020;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_USB2                			= 0x00000040;
        public const uint DAPI_HW_INTERFACE_BIT_CFG_CANOPEN             			= 0x00000080;

        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_MASK             			= 0xFF000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_RO               			= 0x01000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_RO2              			= 0x02000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_BS               			= 0x03000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_NET              			= 0x04000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_NET_IP           			= 0x05000000;
        public const uint DAPI_HW_INTERFACE_PRODUCT_ID_CANOPEN_STICK    			= 0x06000000;

        // --------------------------------------------------------
        // TCP Feature Bits
        public const uint DAPI_TCP_FEATURE_BIT_SUPPORTED_BY_FIRMWARE    			= 0x00000001;
        public const uint DAPI_TCP_FEATURE_BIT_SUPP_RTC                 			= 0x00000002;
        public const uint DAPI_TCP_FEATURE_BIT_SUPP_SYSTEM_INFO         			= 0x00000004;
        public const uint DAPI_TCP_FEATURE_BIT_SUPP_IF_RELOAD_FEATURE				= 0x00000008;

		// --------------------------------------------------------
		// MC-(Module-Config) Feature Bits
        public const uint DAPI_MC_FEATURE_BIT_SUPPORTED_BY_FIRMWARE					= 0x00000001;
        public const uint DAPI_MC_FEATURE_BIT_SUPP_RESET_FACT_DEFAULTS				= 0x00000002;

		// ----------------------------------------------------------------------------
		// ----------------------------------------------------------------------------
		// ----------------------------------------------------------------------------
		// ----------------------------------------------------------------------------
		// ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // DI - Counter Mode
        public const uint DAPI_CNT_MODE_READ                        = 0x00;
        public const uint DAPI_CNT_MODE_READ_WITH_RESET             = 0x01;
        public const uint DAPI_CNT_MODE_READ_LATCHED                = 0x02;

        // ----------------------------------------------------------------------------
        // A/D and D/A Modes
        public const uint DAPI_ADDA_MODE_16BIT_UNIPOL_10V           = 0x00;
        public const uint DAPI_ADDA_MODE_16BIT_UNIPOL_5V            = 0x01;
        public const uint DAPI_ADDA_MODE_16BIT_UNIPOL_2V5           = 0x02;
        public const uint DAPI_ADDA_MODE_18BIT_UNIPOL_10V           = 0x03;
        public const uint DAPI_ADDA_MODE_16BIT_UNIPOL_20V			= 0x04;
    
        public const uint DAPI_ADDA_MODE_16BIT_BIPOL_10V            = 0x40;
        public const uint DAPI_ADDA_MODE_16BIT_BIPOL_5V             = 0x41;
        public const uint DAPI_ADDA_MODE_16BIT_BIPOL_2V5            = 0x42;
        public const uint DAPI_ADDA_MODE_18BIT_BIPOL_10V            = 0x43;
        public const uint DAPI_ADDA_MODE_16BIT_BIPOL_20V			= 0x44;

        public const uint DAPI_ADDA_MODE_16BIT_0_20mA               = 0x80;
        public const uint DAPI_ADDA_MODE_16BIT_4_20mA               = 0x81;
        public const uint DAPI_ADDA_MODE_16BIT_0_24mA               = 0x82;
        //public const uint DAPI_ADDA_MODE_0_25mA                   = 0x83;
        public const uint DAPI_ADDA_MODE_16BIT_0_50mA               = 0x84;
        public const uint DAPI_ADDA_MODE_18BIT_0_50mA               = 0x85;

        public const uint DAPI_ADDA_MODE_18BIT_0_20mA_TESTMODE      = 0xfb;
        public const uint DAPI_ADDA_MODE_18BIT_BIPOL_10V_TESTMODE   = 0xfc;

        public const uint DAPI_ADDA_MODE_16BIT_BI_CAL_MODE          = 0xfd;
        public const uint DAPI_ADDA_MODE_16BIT_0_20mA_TESTMODE      = 0xfe;
        public const uint DAPI_ADDA_MODE_16BIT_BIPOL_10V_TESTMODE   = 0xff;

        public const uint DAPI_ADDA_MODE_PREVENT_DAPI_MODE_ERROR    = 0x8000;

        // --------------------------------------------------------
        // A/D and D/A units
        public const uint DAPI_ADDA_UNIT_ILLEGAL                    = 0x00;
        public const uint DAPI_ADDA_UNIT_VOLT                       = 0x01;
        public const uint DAPI_ADDA_UNIT_MA                         = 0x02;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // Stepper-Defines

        // ------------------------------------
        // ERROR Codes
        public const uint DAPI_STEPPER_ERR_NONE                                         = 0;            // No error
        public const uint DAPI_STEPPER_ERR_PARAMETER                                    = 1;            // Invalid value range 
        public const uint DAPI_STEPPER_ERR_MOTOR_MOVE                                   = 2;            // Motor is currently moving
        public const uint DAPI_STEPPER_ERR_DISABLE_MOVE                                 = 3;            // Moving motor is disabled
        public const uint DAPI_STEPPER_ERR_DEVICE_NOT_FOUND                             = 0xffffffff;   // No device

        // ------------------------------------
        // Special Stepper Function-Codes
        public const uint DAPI_STEPPER_RETURN_0_BYTES                                   = 0x00000000;       // command returns 0 byte
        public const uint DAPI_STEPPER_RETURN_1_BYTES                                   = 0x40000000;       // command returns 1 byte
        public const uint DAPI_STEPPER_RETURN_2_BYTES                                   = 0x80000000;       // command returns 2 byte
        public const uint DAPI_STEPPER_RETURN_4_BYTES                                   = 0xc0000000;       // command returns 4 byte

        public const uint DAPI_STEPPER_CMD_SET_MOTORCHARACTERISTIC                      = ( 0x00000001 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_GET_MOTORCHARACTERISTIC                      = ( 0x00000002 + DAPI_STEPPER_RETURN_4_BYTES ); 
        public const uint DAPI_STEPPER_CMD_SET_POSITION                                 = ( 0x00000003 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_GO_POSITION                                  = ( 0x00000004 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_GET_POSITION                                 = ( 0x00000005 + DAPI_STEPPER_RETURN_4_BYTES );  
        public const uint DAPI_STEPPER_CMD_SET_FREQUENCY                                = ( 0x00000006 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_SET_FREQUENCY_DIRECTLY                       = ( 0x00000007 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_GET_FREQUENCY                                = ( 0x00000008 + DAPI_STEPPER_RETURN_2_BYTES );  
        public const uint DAPI_STEPPER_CMD_FULLSTOP                                     = ( 0x00000009 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_STOP                                         = ( 0x00000010 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_GO_REFSWITCH                                 = ( 0x00000011 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_DISABLE                                      = ( 0x00000014 + DAPI_STEPPER_RETURN_0_BYTES );  
        public const uint DAPI_STEPPER_CMD_MOTORCHARACTERISTIC_LOAD_DEFAULT             = ( 0x00000015 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_MOTORCHARACTERISTIC_EEPROM_SAVE              = ( 0x00000016 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_MOTORCHARACTERISTIC_EEPROM_LOAD              = ( 0x00000017 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_GET_CPU_TEMP                                 = ( 0x00000018 + DAPI_STEPPER_RETURN_1_BYTES );
        public const uint DAPI_STEPPER_CMD_GET_MOTOR_SUPPLY_VOLTAGE                     = ( 0x00000019 + DAPI_STEPPER_RETURN_2_BYTES );
        public const uint DAPI_STEPPER_CMD_GO_POSITION_RELATIVE                         = ( 0x00000020 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_EEPROM_ERASE                                 = ( 0x00000021 + DAPI_STEPPER_RETURN_0_BYTES );
        public const uint DAPI_STEPPER_CMD_SET_VECTORMODE                               = ( 0x00000040 + DAPI_STEPPER_RETURN_0_BYTES );  

        // ------------------------------------
        // values for PAR1 for DAPI_STEPPER_CMD_SET_MOTORCHARACTERISTIC
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_STEPMODE                               = 1;    // Stepmode (full-, half-, quarter-, eighth- or sixteenth stop mode)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_GOFREQUENCY                            = 2;    // Step frequency for GoPosition [fullstep / s]
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_STARTFREQUENCY                         = 3;    // Start frequency [fullstep / s]
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_STOPFREQUENCY                          = 4;    // Stop frequency [fullstep / s]
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_MAXFREQUENCY                           = 5;    // Max. frequency [fullstep / s]
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_ACCELERATIONSLOPE                      = 6;    // Acceleration slope [fullstep / ms] - (maximum value=1000)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_DECELERATIONSLOPE                      = 7;    // Deceleration slope [fullstep / ms] - (maximum value=1000)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_PHASECURRENT                           = 8;    // Phase current [mA] - (maximum value=1500)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_HOLDPHASECURRENT                       = 9;    // Phase current at motor hold [mA] - (maximum value=1500)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_HOLDTIME                               = 10;   // Time in that the hold goes to motorstop [ms]
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_STATUSLEDMODE                          = 11;   // Mode of the Status-LED
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_INVERT_ENDSW1                          = 12;   // Invert end-switch 1
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_INVERT_ENDSW2                          = 13;   // Invert end-switch 2 
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_INVERT_REFSW1                          = 14;   // Invert ref-switch 1
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_INVERT_REFSW2                          = 15;   // Invert ref-switch 2
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_INVERT_DIRECTION                       = 16;   // Invert direction
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_ENDSWITCH_STOPMODE                     = 17;   // Setting of the stop behaviour (0=Fullstop / 1=Stop)
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_GOREFERENCEFREQUENCY_TOENDSWITCH       = 18;   // Motor Frequency for GoReferenceCommand
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_GOREFERENCEFREQUENCY_AFTERENDSWITCH    = 19;   // Motor Frequency for GoReferenceCommand
        public const uint DAPI_STEPPER_MOTORCHAR_PAR_GOREFERENCEFREQUENCY_TOOFFSET          = 20;   // Motor Frequency for GoReferenceCommand

        // ----------------------------------------------------------------------------
        // values for PAR1 for DAPI_STEPPER_CMD_GO_REFSWITCH
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF1                = 1;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF2                = 2;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF_LEFT            = 4;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF_RIGHT           = 8;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF_GO_POSITIVE     = 16;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_REF_GO_NEGATIVE     = 32;
        public const uint DAPI_STEPPER_GO_REFSWITCH_PAR_SET_POS_0           = 64;

        // ------------------------------------
        // Stepper Read Status
        public const uint DAPI_STEPPER_STATUS_GET_POSITION                  = 0x01;
        public const uint DAPI_STEPPER_STATUS_GET_SWITCH                    = 0x02;
        public const uint DAPI_STEPPER_STATUS_GET_ACTIVITY                  = 0x03;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // CAN-Defines

        // ------------------------------------
        // CAN Commands
        public const uint DAPI_CAN_CMD_SET_BITRATE      = 1;
        public const uint DAPI_CAN_CMD_SET_MASK0        = 2;
        public const uint DAPI_CAN_CMD_SET_RX_ADDRESS   = 3;
        public const uint DAPI_CAN_CMD_CLR_TIMESTAMP    = 4;
        public const uint DAPI_CAN_CMD_GET_BITRATE      = 5;
        public const uint DAPI_CAN_CMD_GET_TIMESTAMP    = 6;

        public const uint DAPI_CAN_CMD_TEST_GEN_RX_PACK = 0xfffffff0;

        public const uint DAPI_PAR_CAN_MESSAGE_BOX_0    = 0;
        public const uint DAPI_PAR_CAN_MESSAGE_BOX_1    = 1;
        public const uint DAPI_PAR_CAN_MESSAGE_BOX_2    = 2;
        public const uint DAPI_PAR_CAN_MESSAGE_BOX_3    = 3;

        public const uint DAPI_CAN_BITRATE_10000        = 10000;
        public const uint DAPI_CAN_BITRATE_20000        = 20000;
        public const uint DAPI_CAN_BITRATE_50000        = 50000;
        public const uint DAPI_CAN_BITRATE_100000       = 100000;
        public const uint DAPI_CAN_BITRATE_125000       = 125000;
        public const uint DAPI_CAN_BITRATE_250000       = 250000;
        public const uint DAPI_CAN_BITRATE_500000       = 500000;
        public const uint DAPI_CAN_BITRATE_800000       = 800000;
        public const uint DAPI_CAN_BITRATE_1000000      = 1000000;

        public const uint DAPI_CAN_MASK_SINGLE          = 0xffffffff;
        public const uint DAPI_CAN_MASK_ALL             = 0x0;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // CNT48 Commands

        public const uint DAPI_CNT48_FILTER_20ns                            = 0x0000;
        public const uint DAPI_CNT48_FILTER_100ns                           = 0x1000;
        public const uint DAPI_CNT48_FILTER_250ns                           = 0x2000;
        public const uint DAPI_CNT48_FILTER_500ns                           = 0x3000;
        public const uint DAPI_CNT48_FILTER_1us                             = 0x4000;
        public const uint DAPI_CNT48_FILTER_2_5us                           = 0x5000;
        public const uint DAPI_CNT48_FILTER_5us                             = 0x6000;
        public const uint DAPI_CNT48_FILTER_10us                            = 0x7000;
        public const uint DAPI_CNT48_FILTER_25us                            = 0x8000;
        public const uint DAPI_CNT48_FILTER_50us                            = 0x9000;
        public const uint DAPI_CNT48_FILTER_100us                           = 0xA000;
        public const uint DAPI_CNT48_FILTER_250us                           = 0xB000;
        public const uint DAPI_CNT48_FILTER_500us                           = 0xC000;
        public const uint DAPI_CNT48_FILTER_1ms                             = 0xD000;
        public const uint DAPI_CNT48_FILTER_2_5ms                           = 0xE000;
        public const uint DAPI_CNT48_FILTER_5ms                             = 0xF000;

        public const uint DAPI_CNT48_MODE_COUNT_RISING_EDGE                 = 0x0000;
        public const uint DAPI_CNT48_MODE_COUNT_RISING_EDGE_X2              = 0x0001;
        public const uint DAPI_CNT48_MODE_COUNT_RISING_EDGE_X4              = 0x0002;
        public const uint DAPI_CNT48_MODE_T                                 = 0x000D;
        public const uint DAPI_CNT48_MODE_FREQUENCY                         = 0x000E;
        public const uint DAPI_CNT48_MODE_PWM                               = 0x000F;

        public const uint DAPI_CNT48_SUBMODE_NO_RESET                       = 0x0000;
        public const uint DAPI_CNT48_SUBMODE_RESET_WITH_READ                = 0x0010;
        public const uint DAPI_CNT48_SUBMODE_NO_RESET_NO_HW_RESET           = 0x0020;
        public const uint DAPI_CNT48_SUBMODE_RESET_WITH_READ_NO_HW_RESET    = 0x0030;
        public const uint DAPI_CNT48_SUBMODE_RESET_ON_CH_7                  = 0x0070;
        public const uint DAPI_CNT48_SUBMODE_LATCH_COMMON                   = 0x0080;
        public const uint DAPI_CNT48_SUBMODE_FREQUENCY_TIME_BASE_1ms        = 0x0030;
        public const uint DAPI_CNT48_SUBMODE_FREQUENCY_TIME_BASE_10ms       = 0x0020;
        public const uint DAPI_CNT48_SUBMODE_FREQUENCY_TIME_BASE_100ms      = 0x0010;
        public const uint DAPI_CNT48_SUBMODE_FREQUENCY_TIME_BASE_1sec       = 0x0000;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // Software FIFO Commands

        public const uint DAPI_FIFO_TYPE_READ_AD_FIFO                       = 0x01;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // PWM Commands
        
        public const uint DAPI_PWM_FREQUENCY_10HZ                           = 1;
        public const uint DAPI_PWM_FREQUENCY_100HZ                          = 10;
        public const uint DAPI_PWM_FREQUENCY_250HZ                          = 25;
        public const uint DAPI_PWM_FREQUENCY_1000HZ                         = 100;
        public const uint DAPI_PWM_FREQUENCY_SERVO_M1                       = 254;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // Definitions for DapiOpenEx

        [StructLayout(LayoutKind.Sequential)]
        public class DAPI_OPENMODULEEX_STRUCT
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string address;
            public uint timeout;
            public uint portno;

            public uint encryption_type;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string encryption_password;
        };
        
        public const uint DAPI_OPEN_MODULE_OPTION_USE_EXBUFFER          			= (1<<0);   // Bit 0
        public const uint DAPI_OPEN_MODULE_OPTION_NO_RESCAN             			= (1<<1);   // Bit 1
        public const uint DAPI_OPEN_MODULE_OPTION_CANOPENSTICK_NO_REGISTER_REROUTE	= (1<<2);	// Bit 2

        public const uint DAPI_OPEN_MODULE_ENCRYPTION_TYPE_NONE         = 0;
        public const uint DAPI_OPEN_MODULE_ENCRYPTION_TYPE_NORMAL       = 1;
        public const uint DAPI_OPEN_MODULE_ENCRYPTION_TYPE_ADMIN        = 2;
        public const uint DAPI_OPEN_MODULE_ENCRYPTION_TYPE_ADMIN_TEMP   = 3;
		
        public const uint DAPI_OPEN_MODULE_MODE_NORMAL					= 0;
        public const uint DAPI_OPEN_MODULE_MODE_EX						= 1;

        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        // ----------------------------------------------------------------------------
        
    }
}

