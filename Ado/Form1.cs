/*****************************************************************************
 **
 **  (c) All Rights Reserved.
 **  
 typedef enum   
{
//--------------- BEGIN CUSTOM AREA ------------------
    stSTATION0,     // Short I/O Test with Temperature  //test with or without MEMS:2022-5-11
    stSTATION1,     // LD / PD with Temperature
    stSTATION2,     // HFOV / VFOV with Temperature, Burn-In
    stSTATION3,     // Inspection, includ 0, 1, 2,
    stSTATION4,     // Test LD
//--------------- END CUSTOM AREA --------------------     
    stINVALID   //=====used for enumerated type range checking (DO NOT REMOVE)=====
}eSTATION;  
**
**  Add PID auto detect: { VID, PID } = ("0416", "B1B2")    //2022-5-9
**  Add comboBox to set Station to others                   //2022-5-12
**  Add station3 test, 1st receive LD/PD/Temperature, 2nd receive Birn-in result(cmd:AT+BI)
**  Read Ver. when station connected to show F/W ver and Station_No.    //2022-5-13
**  Replace interface into tabControl and add engineer setting tabPages. //2022-05-23
**  Add command send for testing. //2022-05-23
**  Add temperature reading for every 1 second. //2022-05-24
**  Station 2/3 modified to station <2-1>,<2-2>/<3-1>,<3-2>. FW:Mercury Station 2 <Ver:1.1>, Build May 26 2022 13:00:27 //2022-05-26 
**  Checksum rule modified for 4 bytes caculate.    //2022-05-27
**  Station id = <0-1>,<0-2>,<2-1>,<2-2>,3,<3-2>;   //2022-05-31
**  Modify sta<3-1> to repeat send "AT+RET" for 1 hr and read PDP/PDN/Temperature before and after 1 hr.   //2022-06-02
**  Jig_FW = <Ver:1.2>  Build:Jun 6 2022 14:03:41 ;<3-2> Burn-in 1hr.   //2022-06-07
**  Jig_FW = Mercury Dev0 Station 3 <Ver:1.3>  Build Jun  7 2022 15:17:41 ;Burn-in 1hr. //2022-06-08
**  Jig_FW = Mercury Dev0 Station 3 <Ver:1.3>  Build Jun  8 2022 17:30:35 ;UI reasonable. //2022-06-09
**  Move the 'btnTempRead' to Main_tabPage, It is invisible unless station 2.  //2022-06-13
**  JIG_FW update, PDP/PDN value need to be divided 100;    //2022-06-15
**  Add checking if report is opened. Show red "burn-in testing" when brun-in.  //2022-06-16 
**  Add btnBurnStop to interrupt burn-in.   if Sta02 then btnTest.enable=fasle, YesNo messageBox   //2022-06-17
**  Create new xls debug & btnBurnStop respone make sure question. //2022-06-20
**  SW ver=1.1; For Customer: Check if station is not 3, then set the station to 3. //2022-06-22
**  Add bChkPdByJig for if is check by Jig_FW rule. //2022-06-27
**  SW ver=1.2; JIG_FW ver.1.4 Jun 27 2022 17:31:41. Recover to check PDtest. //2022-06-27
**  Add reoport remark column for sorting.  //2022-06-28
**  Add ControlBox to avoid user close the app when do 1 hr burn-in.    //2022-06-30
**  For customer: add write "AT+BIS 0"; Write different Device_ID when StationID is the same.//2022-07-19
**  SW ver=1.3; 1PC_app to 3 test JIG;  //2022-7-25;    Layout setting  //2022-07-27 
**  Dvc0/Dvc1/Dvc2 comport auto-detect OK;  //2022-08-18, btnTest function OK;    //2022-08-23
**  btnTestDvc0, btnTestDvc1, btnTestDvc2 function OK;  station detect more stable;  //2022-08-29
**  iBurnStopStepDvc1 & bBurnStopAnsDvc1 to the Stop Burn-in procedure thread.  //2022-09-06
**  iBurnStopStepDvc2 & bBurnStopAnsDvc2 to the Stop Burn-in procedure thread.  //2022-09-07
**  PDP/PDN criteria edit(not ChkByHJig)    //2022-09-16
**  No hiding the Tabpages for can't revel it.  Clear the Text when ComPort number changed.  //2022-09-19
**  btnBurnStopDvc1, btnBurnStopDvc2 enable when burn finished. //2022-09-23
**  btnTestDvc0~2 enabled when test finished.   //2022-10-05
**  Set "AT+BIS 1" to be after "AT+RET" for MEMS opening could be stop.   //2022-10-31
**  Set Device_0 burn-in procedure in time3(same with Device_1/2)   //2022-11-03 => Test 2 jigs with HUB connection is fine. 
**  UI Extend connection jigs to 10.    //2022-11-03
**  cboComList.text changed while cboDevNo_SelectedIndexChanged.    //2022-11-07
**  cboDevNo.add when Device detected.  Add tabpages and UI for 10 devices.  //2022-11-08
**  Edit to avoid idle when jig no response. Form.Text edit to 1_To_10 Burn-in test.   //2022-11-09
**  Add Device_3~5 ElecTest/Burn1hr function. FullTest strStaId error debug Ok.  //2022-11-15
**  iBurnMin Math.Ceiling to Math.Floor. Add Device_6~9 ElecTest/Burn1hr function. //2022-11-16
**  WndProc to set Curr && IsOpenPort() modified to better && (Tabpage)Engineer setting edited. //2022-11-17
**  Close serailPort when form colse. Ask when Form1_Closing & Form1_Closed.   //2022-11-18
**  Add "Burn-in Finished" messageBox for every device alert.   //2022-11-21
**  Add "AT+BIT 60" when Burn-in(Sta=3 & BIS=1).   //2022-11-24
**  Add "bBurnAll2ndTesting" to wait "BurnAll 2nd test" proceed in line.  //2022-11-30
**  Add utilDvcxSerialWrite(eCPort port, string strCmd)...abComPortBusyFlag、DiscardInBuffer & DiscardOutBuffer.  //2022-12-04
**  Add Burn time setting for engineer. //2022-12-06
**  Modify TestDateTime read timing.    //2023-02-15
**  Add temperature check during burn-in peroid.   Add StationCheck(iDvc). //2023-02-15
**  Fix DateTime when Burn-in finish.   //2023-02-17
**  Remodify details to be more stable. //2023-02-21
**  Modify { VID, PID } detection method.   //2023-03-30
**  macAddresses = AddSpaceEveryNChar(macAddresses, 2); //2025-06-19
**  Add bDeviceArrival to check if device is connected. DvcNo to DvcSerial & DvcCom.  //2025-07-17
**  WndProc\DeviceArrival fixed. but GetPortNames() still wrong when 2nd time remove connection.  //2025-07-28
******************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Sort;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO.Ports;
using Microsoft.Win32;  //for PID:RegistryKey, Registry   //Eric
using System.Text.RegularExpressions;   //for PID:Regex //Eric
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;
using System.Net;
using System.Reflection;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Ado
{
    /* ---------------------------------------------------------
     * WINAPI STUFF
     * ------------------------------------------------------ */
    public enum Languages : Byte    //2023-04-10:From Jay
    {
        LANG_EN = 0,
        LANG_TW = 1,
        LANG_JA = 2,
    }
    [Flags]
    public enum ReceDataType : Byte
    {
      DATA_ACK        = 0,
      DATA_JSON       = 1,
      DATA_MESSAGE    = 2,
      DATA_CONFIG = 3   //2023-04-10:From Jay
    }

    public enum ReceAck : Byte
    {
      ACK_OK        = 0,
      ACK_ERROR     = 1,
    }

    public enum eCPort : uint {
        cPort0 = 0,
        cPort1 = 1,
        cPort2 = 2,
        cPort3 = 3,
        cPort4 = 4,
        cPort5 = 5,
        cPort6 = 6,
        cPort7 = 7,
        cPort8 = 8,
        cPort9 = 9
    }

    public partial class Form1 : Form
    {
        /*******************************************************************************
         * Constant              //2023-02-16:by Jay
         ******************************************************************************/
        /* These are constant variables */
        public static readonly string jsonjver = "1.0";
        public static readonly string jsonjver_config = "1.0";
        public static readonly string jsondev = "sta";  // StaFlow.exe
        public static readonly string userDocFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        /*******************************************************************************
         * Gobal Variable              //2023-02-16:by Jay
         ******************************************************************************/
        private delegate void DelegateShowMessage(string sMessage);
        private delegate void DelegateBoxPrintf(string info, bool clear, Color color);
        static string userAppFolder = userDocFolder + "\\Burn1to10";//@"\StaFlow";        
        string jsonConfigFile = userAppFolder + "\\config.json";
        static string fileName = Assembly.GetExecutingAssembly().GetName().Name;
        string fileVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        string buildDateTime = System.IO.File.GetCreationTime(Assembly.GetExecutingAssembly().Location).ToString("yyyy-MM-dd HH:mm:ss");

        //ReceDataType recDType = ReceDataType.DATA_MESSAGE;

        int T;
        int len;
        string RecRawData;
        readonly Feedback aas = new Feedback();
        string strComSelected = ""; //Eric:2022-5-9
        Boolean bTempReading = false;   //2022-05-24
        //******2022-11-09, 2024-03-13*********
        static SerialPort serialPort1 = new SerialPort(); static SerialPort serialPort2 = new SerialPort();
        static SerialPort serialPort3 = new SerialPort();
        static SerialPort serialPort4 = new SerialPort(); static SerialPort serialPort5 = new SerialPort();
        static SerialPort serialPort6 = new SerialPort(); static SerialPort serialPort7 = new SerialPort();
        static SerialPort serialPort8 = new SerialPort(); static SerialPort serialPort9 = new SerialPort();
        static SerialPort serialPort10 = new SerialPort();
        //******2022-11-15*********for referrence
        //System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        //t.Interval = 1000;
        //t.Tick += new EventHandler(timer_Tick);
        //t.Start();
        //void timer_Tick(object sender, EventArgs e)
        //{ Call method }
        //t.Stop();

        string strStaId = "";  //2022-05-31
        int iStaId = 0;  //station_ID:2022-07-01
        int iDvcId = 0;  //Device_ID:2022-07-01
        //2023-02-21
        string strBisVal = "0"; string strBisValDvc1 = "0"; 
        string strBisValDvc2 = "0"; string strBisValDvc3 = "0"; 
        string strBisValDvc4 = "0"; string strBisValDvc5 = "0"; 
        string strBisValDvc6 = "0"; string strBisValDvc7 = "0";
        string strBisValDvc8 = "0"; string strBisValDvc9 = "0";

        Boolean bBurn1hr = false;   //2022-06-02
        Boolean bBurn1hrDvc1, bBurn1hrDvc2 = false; //2022-08-29
        Boolean bBurn1hrDvc3, bBurn1hrDvc4, bBurn1hrDvc5, bBurn1hrDvc6,
            bBurn1hrDvc7, bBurn1hrDvc8, bBurn1hrDvc9 = false;   //2022-11-08
        Boolean bBurnFinished = false;  //2022-06-02
        Boolean bBurnFinishedDvc1, bBurnFinishedDvc2 = false; //2022-08-29
        Boolean bBurnFinishedDvc3, bBurnFinishedDvc4, bBurnFinishedDvc5, bBurnFinishedDvc6,
             bBurnFinishedDvc7, bBurnFinishedDvc8, bBurnFinishedDvc9 = false;   //2022-11-08
        int iBitVal = 0;    //2022-06-02
        //int iBitValDvc1, iBitValDvc2 = 0;   //2022-08-29

        string stringDateTime = "";   //2023-02-15
        //2023-06-26
        string strSNo = "";
        string strDev, strCmd, strType, strFwver, strIot, strTemp, strTMPsta,
                strPDP, strPDN, strPDresult, strCurr, strResult,strTestRmk, strDeviceID = "";

        string strDateTimeDvc0, strDateTimeDvc1, strDateTimeDvc2, strDateTimeDvc3, 
            strDateTimeDvc4, strDateTimeDvc5, strDateTimeDvc6, strDateTimeDvc7, 
            strDateTimeDvc8, strDateTimeDvc9 = "";  //2023-02-15
        DateTime dts0, dts1, dts2, dts3, dts4, dts5, dts6, dts7, dts8, dts9;  //2023-02-15

        /// <summary>
        /// Pre set the SW for certain user: Customer, 
        /// </summary>
        Boolean b4ProdLine = true;  //2022-06-22    //For MEGA1 product line,
        Boolean b4Customer = false;  //2022-06-22    //For Pegatron,Humane
        Boolean bChkPdByJig = false;   //2022-06-27    //If check PDP/PDN by JIG_FW 
        Boolean b4MGFelse = false;  //2022-07-25 For MGF else factory:FLEXium
        
        //2023-05-31
        //public static readonly string userDocFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
        //static string userAppFolder = userDocFolder + @"\Burn1to10";
        static DateTime TestDate = DateTime.Now;
        //static string strLogNameDaily = "Burn1to10" + "_" + TestDate.ToString("yyyyMMdd")+ ".csv";
        //static string strLogNameDaily = strFileDailyFolder + "\\" + "H4_IQC_LBS_BURN" + "_" + strDailyLogDate + ".csv";
        //string strFilePath = userAppFolder + "\\" + strLogNameDaily;    //@"\Burn1to10.csv";
        //2023-07-06
        string strFilePath = "";    //userAppFolder + "\\" + "H4_IQC_LBS_BURN.csv";
        static string strDailyLogDate = DateTime.Now.ToString("yyyy-MM-dd");
        static string strFileDailyFolder = userAppFolder + "\\" + DateTime.Now.ToString("yyyy")
            + "\\" + DateTime.Now.ToString("MM") + "\\" + DateTime.Now.ToString("dd");
        static string strLogNameDaily = ""; //strFileDailyFolder + "\\" + "H4_IQC_LBS_BURN" + "_" + strDailyLogDate + ".csv";
        string strFileDailyPath = "";   //userAppFolder + "\\" + strLogNameDaily;    //@"\Burn1to10.csv";
        //---------------
        Customer getCustomer = Customer.ctHumane;
        //string strTestDateTime = ""; string strTestMode = ""; string strDutMode = "";
        //string strRelStatus = ""; string strCofMode = ""; string strSfisCheckRoute = "";
        //string strOverallTestResult = ""; string strCycleTime = ""; string strIsnInput = "";
        //string strBuildEvent = ""; string strProductName = ""; string strTestLine = "";
        //string strLineType = ""; string strStationName = ""; string strStationMac = "";
        //string strFixtureId = ""; string strSiteId = ""; string strConfigInput = "";
        //string strSlotId = ""; string strOperatorId = ""; string strVersionToolFw = "";
        //string strVersionTestLog = ""; string strVersionTestSw = "";

        //string strConfigFatp = ""; string strConfigMlb = "";
        //string strConfigMlbFontana = ""; string strIsnFatpB1 = "";
        //string strIsnFatpH4 = ""; string strIsnMlbB1 = "";
        //string strIsnMlbFontana = ""; string strIsnMlbH4 = "";
        //string strVersionDutFw = "";

        //string strVersionTestLimits = ""; string strVersionTestOs = "";
        //string strStationRebootDateTime = ""; string strFirstFailItem = "";
        //string strDutColor = ""; string strUnitNumber = "";
        ////---------------
        //string strFuncFpcTest = ""; string strFuncTemperature = ""; string strFuncTmpStatus = "";
        //string strFuncPdPMeas = ""; string strFuncPdNMeas = ""; string strFuncPdResult = "";
        //string strFuncLddCurrent = ""; string strFuncQcFinal = "";

        ConfigJson configJson;  //2023-07-06
        //-----------------
        //string strSwVer = "Mercury_E:v_1.2.6, 2023-07-06 15:35; ";  //2023
        string strSwVer = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();  //2023-07-18
        string strFwVer = "JIG_FW:Ver_1.7, Jun 29 2023"; //15:03:00";    //2023-07-18
        //string form_txt="Lucio EVT Electric Test v.1.4 - 1pc To 10 Jigs";  //2022-11-09

        int iDvcCnt = 0; //2022-08-01; For burn-in Device count:0,1,2
        string strComSerial1, strComSerial2, strComSerial3 = "";   //2022-08-08:SerailPort?對應到com?
        string strComSerial4, strComSerial5, strComSerial6, 
            strComSerial7, strComSerial8, strComSerial9, strComSerial10 = "";   //2022-11-08

        List<string> JigComSerial = new List<string>(); //2023-10-19:List of Com connect to Jig (but connect to which DvcNo unknown)
        //List<string> strComSerial = new List<string>(); //2024-03-11：List of Com for SerialPort 1~10
        //string[] strComConnect = new string[] { };   //2024-03-11:Connected Com
        List<string> strComConnect = new List<string>(); //2025-07-17:Connected Com (but not sure if connect to device)
        //---create list<T>...2024-03-11----
        //string strVID = "0416"; string strPID = "B1B2";
        List<string> VidPidNames = ComPortNames("0416", "B1B2");
        //List<string> strComNowConnect = new List<string>(); //2024-03-12:Com that Connecting

        Boolean bAtVerSent, bAtVerAns = false;  //2022-08-16
        int iAtVerCmdStep = 0;  //2022-08-16
        Boolean bAtBisSet = false;  //2022-08-29

        //2024-03-13:SerialDvc? -> SerialPort? name to array
        static SerialPort Dvc0Serial, Dvc1Serial, Dvc2Serial;  //2022-08-18=>The serialPort of devices
        static SerialPort Dvc3Serial, Dvc4Serial, Dvc5Serial, Dvc6Serial, Dvc7Serial, Dvc8Serial, Dvc9Serial;  //2022-11-08: Device? get SerialPort?
        //static SerialPort ComInsertSerial= new SerialPort();  //2025-07-18:SerialPort for ComInsert
        string strComInsert;    //2025-07-18
        bool bEngineerCmdSend = false;  //2025-07-18
        //List<SerialPort> SerialDvc = new List<SerialPort>();  //Device[N].Serial:2024-03-11
        //SerialPort[] serialDvc = { Dvc0Serial, Dvc1Serial, Dvc2Serial, Dvc3Serial, Dvc4Serial,
        //    Dvc5Serial, Dvc6Serial, Dvc7Serial, Dvc8Serial, Dvc9Serial};  //2024-03-13:Dvc?->SerialPortN
        //2024-03-13:ComOfDvc -> ComPort? name to array
        static String strDvc0Com, strDvc1Com, strDvc2Com;   //2022-08-18=>The Com of devices
        static String strDvc3Com, strDvc4Com, strDvc5Com, strDvc6Com, strDvc7Com, strDvc8Com, strDvc9Com;  //2022-11-08: Device? get comport?
        //string[] strComDvc = { strDvc0Com, strDvc1Com, strDvc2Com, strDvc3Com, strDvc4Com,
        //    strDvc5Com, strDvc6Com, strDvc7Com, strDvc8Com, strDvc9Com };  //2024-03-13:ComOfDvcN->ComPort?
        string[] strComDvc = { "", "", "", "", "", "", "", "", "", "" };  //2024-03-22:ComOfDvcN->ComPort?
        //static string[] StationDvc = { "Device1", "Device2", "Device3", "Device4", "Device5" 
        //,"Device6","Device7","Device9","Device10"};   //2024-03-19

        DateTime dtBurnStartDvc0, dtBurnTimeDvc0;   //2022-08-29
        DateTime dtBurnStartDvc1, dtBurnTimeDvc1;   //2022-08-29
        DateTime dtBurnStartDvc2, dtBurnTimeDvc2;   //2022-08-29
        DateTime dtBurnStartDvc3, dtBurnTimeDvc3, dtBurnStartDvc4, dtBurnTimeDvc4;  //2022-11-08
        DateTime dtBurnStartDvc5, dtBurnTimeDvc5, dtBurnStartDvc6, dtBurnTimeDvc6;  //2022-11-08
        //For BurnInQueue()    //2022-11-21
        Boolean bBurnInQueStart = false;
        int iBurnInQueStep, iBurnQueNoResponTick = 0;   //2022-11-22
        Boolean bBurnTestResponse = false;  //2022-11-22: Wait for Devices Test response in BurnInQueue()
        //Boolean bBurnEndTest = false;   //2022-11-24: 自動批次燒機時，陸續燒機完成的各device電測中的旗標
        bool[] abComPortBusyFlag = new bool[] {false, false, false, false, false, false, false, false, false, false };  // array boolean

        DateTime dtBurnStartDvc7, dtBurnTimeDvc7, dtBurnStartDvc8, dtBurnTimeDvc8;  //2022-11-08
        DateTime dtBurnStartDvc9, dtBurnTimeDvc9;  //2022-11-08
        Boolean bBurnStopDvc0, bBurnStopDvc1, bBurnStopDvc2 = false;    //2022-08-31
        Boolean bBurnStopDvc3, bBurnStopDvc4, bBurnStopDvc5,
            bBurnStopDvc6, bBurnStopDvc7, bBurnStopDvc8, bBurnStopDvc9 = false;    //2022-11-08

        int iBurnStopStepDvc0, iBurnStopStepDvc1, iBurnStopStepDvc2 = 0;  //2022-09-06;
        int iBurnStopStepDvc3, iBurnStopStepDvc4, iBurnStopStepDvc5,
            iBurnStopStepDvc6, iBurnStopStepDvc7, iBurnStopStepDvc8, iBurnStopStepDvc9 = 0;    //2022-11-08
        //Boolean bBurnStopAnsDvc0, bBurnStopAnsDvc1, bBurnStopAnsDvc2 = false;
        /*const*/
        int iBurnMin = 60;   //2022-09-07:Burn-in time minuates
        int iTempChkTime = 0;  //2023-02-14: To check temperature during burn-in
        Boolean bTempChkInBurnDvc0, bTempChkInBurnDvc1, bTempChkInBurnDvc2
            , bTempChkInBurnDvc3, bTempChkInBurnDvc4, bTempChkInBurnDvc5
            , bTempChkInBurnDvc6, bTempChkInBurnDvc7, bTempChkInBurnDvc8
            , bTempChkInBurnDvc9 = false; //2023-02-17:To check temperature after certain time
        Boolean bSetCurr_0 = false; //2022-11-17
        //2023-06-26:If At command got answer.
        Boolean bAtComReceivDvc0, bAtComReceivDvc1, bAtComReceivDvc2,
            bAtComReceivDvc3, bAtComReceivDvc4, bAtComReceivDvc5,
            bAtComReceivDvc6, bAtComReceivDvc7, bAtComReceivDvc8,
            bAtComReceivDvc9 = false;

        //2025-07-14 Device SerailPort & ComPort
        //JigDevice SerComDvc0 = new JigDevice(); JigDevice SerComDvc1 = new JigDevice(); JigDevice SerComDvc2 = new JigDevice();
        //JigDevice SerComDvc3 = new JigDevice(); JigDevice SerComDvc4 = new JigDevice(); JigDevice SerComDvc5 = new JigDevice();
        //JigDevice SerComDvc6 = new JigDevice(); JigDevice SerComDvc7 = new JigDevice(); JigDevice SerComDvc8 = new JigDevice();
        //JigDevice SerComDvc9 = new JigDevice();
        Boolean bDeviceArrival = false;  //2025-07-17: flag for Device Arrival in Wndproc()

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)   //2023-07-14
        {
            utilHelpAbout();
        }
        private void utilHelpAbout()    //2023-07-14
        {
            string company = "Megaforce(R) " + fileName + " Ver:" + fileVersion + "\n";
            string copyright = "(C)Copyright Megaforce Corp 2023-2033.\n";
            string buildDT = "Built on " + buildDateTime + "\n";
            string Author = "Author: Eric Hsu\n";
            MessageBox.Show(company + copyright + buildDT + Author, "About " + fileName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)   //2023-07-14
        {
            this.Close();
            //utilWindowClosingWithConfirm(false);   //2023-02-22:by Jay
        }
        private void utilWindowClosingWithConfirm(bool bReStart)   //2023-07-14:by Jay
        {
            // release the device
            if (bReStart)
            {
                System.Windows.Forms.Application.ExitThread();
                Thread thread = new Thread(new ParameterizedThreadStart(taskRun));
                object appName = System.Windows.Forms.Application.ExecutablePath;
                Thread.Sleep(1);
                thread.Start(appName);
            }
            else
            {
                if (utilClosingConfirm() == DialogResult.Yes)
                {
                    //utilClosingApplication();
                    this.Close();
                    Environment.Exit(Environment.ExitCode);
                }
            }
        }
        private void taskRun(Object obj)   //2023-07-14:by Jay
        {
            Process ps = new Process();
            ps.StartInfo.FileName = obj.ToString();
            ps.Start();
        }
        private void saveAsFileToolStripMenuItem_Click(object sender, EventArgs e)  //2023-07-14
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = userAppFolder;
            saveFileDialog.FileName = jsonConfigFile;
            saveFileDialog.Filter = "json |*.json";
            saveFileDialog.Title = "Save the configuration as file";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveFileDialog.FileName != null) && (saveFileDialog.FileName != ""))
                {
                    utilSaveConfigFile();
                }
            }
        }

        private void loadJSONFileToolStripMenuItem_Click(object sender, EventArgs e)    //2023-07-14
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select JSON file of the configuration";
            dialog.InitialDirectory = userAppFolder;
            dialog.Filter = "JSON files (*.json)|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileJson = dialog.FileName;
                utilLoadConfigFile(fileJson, false);
            }
        }
        private DialogResult utilClosingConfirm()   //2023-07-14:by Jay
        {
            string message = "Are you sure you want to exit?";
            string caption = "Warning!!!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);
            return result;
        }
        private void utilCheckUserFile()    //2023-07-14
        {
            if (Directory.Exists(userAppFolder) == false)
            {
                Directory.CreateDirectory(userAppFolder);
            }
            if (Directory.Exists(strFileDailyFolder) == false)  //2023-07-05
            {
                Directory.CreateDirectory(strFileDailyFolder);
            }

            if (File.Exists(jsonConfigFile))
            {
                /* Load exsiting config file */
                utilLoadConfigFile(jsonConfigFile, false);
            }
            else
            {
                /* Create new config file */
                utilSaveConfigFile();
                utilLoadConfigFile(jsonConfigFile, false);
            }
            strFilePath = userAppFolder + "\\" + configJson.STATION_NAME + ".csv";  //2023-07-05
            strFileDailyPath = strFileDailyFolder + "\\" + configJson.STATION_NAME + "_" + strDailyLogDate + ".csv";    //2023-07-05
        }

        private bool utilLoadConfigFile(string fileName, bool getLang)  //2023-07-14
        {
            bool bFail = false;
            try
            {
                string jsonString = File.ReadAllText(@fileName);
                /* Load to Gobal configJson */
                // Newtonsoft.Json反序列化
                configJson = JsonConvert.DeserializeObject<ConfigJson>(jsonString);
                if (!getLang)
                {
                    /* 2nd setup utilCheckUserFile */
                    getCustomer = configJson.customer;
                }
            }
            catch
            {
                //utilStatusPrintf("Failed to open JSON file.");
                bFail = true;
            }
            return bFail;
        }

        private string utilPackageConfig()  //2023-07-14
        {
            string jsonStr = null;

            ConfigJson jData = new ConfigJson();
            JObject obj = new JObject();
            jData.jver = jsonjver_config;
            jData.dev = jsondev;
            jData.cmd = "cfg";
            jData.type = (int)ReceDataType.DATA_CONFIG;
            jData.id = 0;
            jData.customer = getCustomer;

            jData.TEST_MODE = "ONLINE";    //2023-05-10 //"OFFLINE";
            jData.DUT_MODE = "N/A";
            jData.REL_STATUS = "N/A";
            jData.COF_MODE = "ON";
            jData.SFIS_CHECK_ROUTE = "ON_LINE";    //"OFF_LINE";    //2023-04-18
            jData.BUILD_EVENT = "PVT";  //"CRB";    //2023-08-22
            jData.PRODUCT_NAME = "LUCIO";
            jData.TEST_LINE = "N/A";
            jData.LINE_TYPE = "IQC";
            jData.STATION_NAME = "H4_IQC_LBS_BURN"; //站別
            jData.FIXTURE_ID = "000000";
            jData.SITE_ID = "MFTW";                 //2023-08-22
            jData.CONFIG_INPUT = "N/A";
            jData.SLOT_ID = "N/A";
            jData.OPERATOR_ID = "";
            jData.VERSION_TEST_LOG = "1.3";
            jData.VERSION_TEST_SW = ""; //2023-06-09
            //2023-03-29
            jData.CONFIG_FATP = "N/A";
            jData.CONFIG_MLB = "N/A";
            jData.CONFIG_MLB_FONTANA = "N/A";
            jData.ISN_FATP_B1 = "N/A";
            jData.ISN_FATP_H4 = "N/A";
            jData.ISN_MLB_B1 = "N/A";
            jData.ISN_MLB_FONTANA = "N/A";
            jData.ISN_MLB_H4 = "N/A";
            jData.VERSION_DUT_FW = "N/A";
            jData.VERSION_TEST_LIMITS = "6.0";    //2023-07-05

            jData.DUT_COLOR = "BLACK";
            jData.UNIT_NUMBER = "N/A";

            //2023-07-04
            jData.FUNC_TEMP_SENSOR_TEST_UCL = 50;
            jData.FUNC_TEMP_SENSOR_TEST_LCL = 10;
            jData.FUNC_PDP_UCL = 1.01;  // 1.1;
            jData.FUNC_PDP_LCL = 1.49;  // 0.9;
            jData.FUNC_PDN_UCL = 2.29;  // 2.4;
            jData.FUNC_PDN_LCL = 1.81;  // 2.2;
            jData.FUNC_SN_LENGTH = 18;  //2023-07-13

            //Newtonsoft.Json.Linq.JObject jObj = JObject.Parse(jsonStr);
            //jData.checksum = utilGetAckCheckSum(ReceDataType.DATA_JSON, jObj);
            jData.checksum = 0;
            jsonStr = JsonConvert.SerializeObject(jData, Newtonsoft.Json.Formatting.Indented); //行列顯示
            //jsonStr = JsonConvert.SerializeObject(jData, Formatting.None);  //串列顯示

            return jsonStr;
        }

        private void btnCloseCom_Click(object sender, EventArgs e)  //2023-07-19
        {
            if (cboComList.Text == strComSerial1) { serialPort1.Close(); cboComDvc0.Text = ""; }
            else if (cboComList.Text == strComSerial2) { serialPort2.Close(); }
            else if (cboComList.Text == strComSerial3) { serialPort3.Close(); }
            else if (cboComList.Text == strComSerial4) { serialPort4.Close(); }
            else if (cboComList.Text == strComSerial5) { serialPort5.Close(); }
            else if (cboComList.Text == strComSerial6) { serialPort6.Close(); }
            else if (cboComList.Text == strComSerial7) { serialPort7.Close(); }
            else if (cboComList.Text == strComSerial8) { serialPort8.Close(); }
            else if (cboComList.Text == strComSerial9) { serialPort9.Close(); }
            else if (cboComList.Text == strComSerial10) { serialPort10.Close(); }
        }

        private void timer15_Tick(object sender, EventArgs e)   //2023-07-19
        {
            System.Windows.Forms.Application.DoEvents();    //Application.DoEvents();
            switch (iAtVerCmdStep)
            {
                case 0:
                    if (iDvcCnt > 0)
                    { iAtVerCmdStep = 1; }
                    break;
                case 1:
                    if (iDvcCnt >= 1)
                    {
                        iAtVerCmdStep = 2;
                        OpenPort(serialPort1, strComSerial1);   //2022-12-02: Must before .DiscardInBuffer
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                        serialPort1.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    break;
                case 2:
                    iAtVerCmdStep += 1;
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;  /*bAtSentPort1=true;*/
                    break;
                case 3:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 11; // 5;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 11;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_1\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 5: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 7;
                        OpenPort(serialPort1, strComSerial1);
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                        serialPort1.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 7: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 11;
                    }
                    break;
                case 11:
                    serialPort1.Close();    //2023-07-19
                    if (iDvcCnt >= 2)
                    {
                        iAtVerCmdStep = 12;
                        OpenPort(serialPort2, strComSerial2);
                        serialPort2.DiscardInBuffer(); serialPort2.DiscardOutBuffer();  //2022-12-04
                        serialPort2.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 21;
                    }
                    break;
                case 12:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true; /*bAtSentPort2 = true;*/
                    iAtVerCmdStep++;
                    break;
                case 13:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 21; //15;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 21;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_2\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 15: //2022-08-29
                    if (!bAtBisSet)
                    {
                        if (IsOpenPort(serialPort2, strComSerial2))  //2023-02-18
                        {
                            iAtVerCmdStep = 17;
                            //OpenPort(serialPort2, strComSerial2);
                            serialPort2.DiscardInBuffer(); serialPort2.DiscardOutBuffer();  //2022-12-04
                            serialPort2.Write("AT+BIS 0" + "\r\n");
                            bAtBisSet = true;
                        }
                    }
                    break;
                case 17: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 21;
                    }
                    break;
                case 21:
                    serialPort2.Close();    //2023-07-19
                    if (iDvcCnt >= 3)
                    {
                        iAtVerCmdStep = 22;
                        OpenPort(serialPort3, strComSerial3);
                        serialPort3.DiscardInBuffer(); serialPort3.DiscardOutBuffer();  //2022-12-04
                        serialPort3.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 22:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true; /*bAtSentPort3 = true;*/
                    iAtVerCmdStep++;
                    break;
                case 23:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 31; //25;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 31;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_3\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 25: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 27;
                        OpenPort(serialPort3, strComSerial3);
                        serialPort3.DiscardInBuffer(); serialPort3.DiscardOutBuffer();  //2022-12-04
                        serialPort3.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 27: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 31; //90;   //2022-11-09
                    }
                    break;
                //2022-11-09:iDvcCnt = 4~5; serialPort4/5、strComSerial4/5
                #region                 
                case 31:    //serialPort4
                    serialPort3.Close();    //2023-07-19
                    if (iDvcCnt >= 4)
                    {
                        iAtVerCmdStep = 32;
                        OpenPort(serialPort4, strComSerial4);
                        serialPort4.DiscardInBuffer(); serialPort4.DiscardOutBuffer();  //2022-12-04
                        serialPort4.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 32:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 33:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 41; // 35;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 41;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_4\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 35:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 37;
                        OpenPort(serialPort4, strComSerial4);
                        serialPort4.DiscardInBuffer(); serialPort4.DiscardOutBuffer();  //2022-12-04
                        serialPort4.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 37:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 41; //90;
                    }
                    break;
                #endregion
                #region
                case 41:    //serialPort5: 2022-11-09
                    serialPort4.Close();    //2023-07-19
                    if (iDvcCnt >= 5)
                    {
                        iAtVerCmdStep = 42;
                        OpenPort(serialPort5, strComSerial5);
                        serialPort5.DiscardInBuffer(); serialPort5.DiscardOutBuffer();  //2022-12-04
                        serialPort5.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 42:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 43:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 51; //45;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 51;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_5\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 45:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 47;
                        OpenPort(serialPort5, strComSerial5);
                        serialPort5.DiscardInBuffer(); serialPort5.DiscardOutBuffer();  //2022-12-04
                        serialPort5.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 47:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 51;
                    }
                    break;
                #endregion

                //2022-11-15:iDvcCnt = 6~10; serialPort6~10、strComSerial6~10
                #region
                case 51:    //serialPort6
                    serialPort5.Close();    //2023-07-19
                    if (iDvcCnt >= 6)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort6, strComSerial6);
                        serialPort6.DiscardInBuffer(); serialPort6.DiscardOutBuffer();  //2022-12-04
                        serialPort6.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 52:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 53:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 61;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 61;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_6\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 54:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort6, strComSerial6);
                        serialPort6.DiscardInBuffer(); serialPort6.DiscardOutBuffer();  //2022-12-04
                        serialPort6.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 55:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 61;
                    }
                    break;
                #endregion
                #region
                case 61:    //serialPort7
                    serialPort6.Close();    //2023-07-19
                    if (iDvcCnt >= 7)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort7, strComSerial7);
                        serialPort7.DiscardInBuffer(); serialPort7.DiscardOutBuffer();  //2022-12-04
                        serialPort7.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 62:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 63:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 71;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 71;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_7\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 64:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort7, strComSerial7);
                        serialPort7.DiscardInBuffer(); serialPort7.DiscardOutBuffer();  //2022-12-04
                        serialPort7.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 65:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 71;
                    }
                    break;
                #endregion
                #region
                case 71:    //serialPort8
                    serialPort7.Close();    //2023-07-19
                    if (iDvcCnt >= 8)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort8, strComSerial8);
                        serialPort8.DiscardInBuffer(); serialPort8.DiscardOutBuffer();  //2022-12-04
                        serialPort8.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 72:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 73:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 81;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 81;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_8\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 74:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort8, strComSerial8);
                        serialPort8.DiscardInBuffer(); serialPort8.DiscardOutBuffer();  //2022-12-04
                        serialPort8.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 75:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 81;
                    }
                    break;
                #endregion
                #region
                case 81:    //serialPort9
                    serialPort8.Close();    //2023-07-19
                    if (iDvcCnt >= 9)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort9, strComSerial9);
                        serialPort9.DiscardInBuffer(); serialPort9.DiscardOutBuffer();  //2022-12-04
                        serialPort9.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 82:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 83:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 91;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 91;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_9\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 84:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort9, strComSerial9);
                        serialPort9.DiscardInBuffer(); serialPort9.DiscardOutBuffer();  //2022-12-04
                        serialPort9.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 85:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 91;
                    }
                    break;
                #endregion
                #region
                case 91:    //serialPort10
                    serialPort9.Close();    //2023-07-19
                    if (iDvcCnt >= 10)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort10, strComSerial10);
                        serialPort10.DiscardInBuffer(); serialPort10.DiscardOutBuffer();  //2022-12-04
                        serialPort10.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 92:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 93:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 99;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 99;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_10\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 94:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort10, strComSerial10);
                        serialPort10.DiscardInBuffer(); serialPort10.DiscardOutBuffer();  //2022-12-04
                        serialPort10.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 95:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                #endregion

                case 99:    //2022-09-14
                    serialPort10.Close();    //2023-07-19
                    iAtVerCmdStep = 100;
                    break;
                case 100:
                    iAtVerCmdStep = 0;
                    iDvcCnt = 0;
                    timer15.Enabled = false;    //2023-07-19
                    break;
            }

        }

        private void utilSaveConfigFile()   //2023-07-14
        {
            try
            {
                using (FileStream fs = File.Create(jsonConfigFile))
                {
                    string jsonMess = utilPackageConfig();
                    byte[] info = new UTF8Encoding(true).GetBytes(jsonMess);
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  //utilStatusPrintf(ex.ToString());
            }
        }

        private void chkTempRec_CheckedChanged(object sender, EventArgs e)  //2023-06-29
        {
            if (chkTempRec.Checked) 
            { bTempRecording = true; }
            else { bTempRecording = false; }
        }

        private void txtSnoDvc0_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc0.SelectAll();
        }

        private void txtSnoDvc1_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc1.SelectAll();
        }

        private void txtSnoDvc2_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc2.SelectAll();
        }

        private void txtSnoDvc3_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc3.SelectAll();
        }

        private void txtSnoDvc4_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc4.SelectAll();
        }

        private void txtSnoDvc5_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc5.SelectAll();
        }

        private void txtSnoDvc6_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc6.SelectAll();
        }
        private void txtSnoDvc7_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc7.SelectAll();
        }

        private void txtSnoDvc8_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc8.SelectAll();
        }

        private void txtSnoDvc9_MouseClick(object sender, MouseEventArgs e)
        {
            txtSnoDvc9.SelectAll();
        }




        //2023-06-29:For Recording Temperature at case 19
        Boolean bTempRecording = false; //2023-06-29:Just for debugging
        int iIntevalCntDvc0, iIntevalCntDvc1, iIntevalCntDvc2, iIntevalCntDvc3, iIntevalCntDvc4
            , iIntevalCntDvc5, iIntevalCntDvc6, iIntevalCntDvc7, iIntevalCntDvc8, iIntevalCntDvc9 = 0; 
        const int iTempWatchInterval = 5;

        private void timer14_Tick(object sender, EventArgs e)   //2023-06-26:For use with Fixture Board V1.0 FW v1.5/v1.6
        {
            dtBurnTimeDvc1 = DateTime.Now; 
            TimeSpan tsBurnDvc1 = new TimeSpan(dtBurnTimeDvc1.Ticks - dtBurnStartDvc1.Ticks);
            int iBurnTimeDvc1 = Convert.ToInt32(Math.Floor(tsBurnDvc1.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();

            switch (iBurnStopStepDvc1)
            {
                case 0:
                    lblBurnRestDvc1.Visible = true;
                    btnBurnStopDvc1.Visible = true;
                    btnBurnStopDvc1.Enabled = true;
                    iBurnStopStepDvc1 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc1.Enabled = false;
                    iBurnStopStepDvc1 += 1;
                    break;
                case 2:
                    iBurnStopStepDvc1 += 1;
                    utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100)) 
                    {
                        iBurnStopStepDvc1 += 1;
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 1" + "\r\n");
                    }                    
                    break;
                case 4:
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc1 += 1;
                        bBurn1hrDvc1 = true;    //starting burn-in
                        bBurnFinishedDvc1 = false;
                        txtTestRmkDvc1.Text = "Before Burn-in";
                        btnTestDvc1_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc1) 
                    {
                        bAtComReceivDvc1 = false;
                        iBurnStopStepDvc1 = 10;
                        Console.WriteLine("Device_1 Burn-in 1hr Start.");
                        lblFinalDvc1.Text = "Burn-in Testing..."; lblFinalDvc1.ForeColor = Color.Red;
                    }
                    break;

                case 10:
                    if (IsOpenPort(Dvc1Serial, strDvc1Com))    //2023-02-16
                    {
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc1 += 1;
                    break;

                case 11: //2023-02-16    
                    //if ((iBurnTimeDvc1 > iTempChkTime) && !bTempChkInBurnDvc1)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc1Serial, strDvc1Com);
                    //    utilDvcxSerialWrite(eCPort.cPort1, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc1 = true;
                    //}

                    //2023-06-19
                    if (!bTempSensorNgDvc1) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort1, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc1 && !bWaitCoolDvc1)
                    {
                        //IsOpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc1 = 12;
                    }
                    else if (bTempUnder40Dvc1 && bWaitCoolDvc1)
                    {
                        //IsOpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc1 = 13;
                    }

                    if (iBurnTimeDvc1 > iBurnMin || bBurnStopDvc1)  //2022-09-19
                    {
                        bBurnFinishedDvc1 = true;
                        //OpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc1 = 20;
                        bBurnStopDvc1 = false;  //2022-09-08
                        richBox.AppendText("Device_1 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc1.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc1).ToString() + "分鐘"; } //2022-12-01
                    break;

                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc1)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc1 = 11; bWaitCoolDvc1 = true;
                        richBox.AppendText("Device_1 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc1) //CURR has been set to 146
                    {
                        iBurnStopStepDvc1 = 11; bWaitCoolDvc1 = false;
                        richBox.AppendText("Device_1 Laser opening.\r\n");
                    }
                    break;

                case 20:
                    iBurnStopStepDvc1 += 1;
                    txtTestRmkDvc1.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc1 = 30;
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc1.Visible = false;
                    //txtTestRmkDvc1.Text = "After Burn-in";   //2023-06-17
                    btnTestDvc1_Click(this, null);  //2022-11-23
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc1Stay = 0;  //2022-11-30
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc1);    //2023-02-17
                    if (bAtComReceivDvc1/*!bBurnAll2ndTesting*/)
                    {
                        iBurnStopStepDvc1 = 100;
                        bAtComReceivDvc1 = false;   //2023-06-26
                    }
                    else if (iBurnStopStepDvc1Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc1Stay = 0;
                        richBox.AppendText("Device_1 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc1 = 100;
                    }
                    else
                    { iBurnStopStepDvc1Stay += 1; }

                    break;

                case 100:
                    timer14.Enabled = false;
                    iBurnStopStepDvc1 = 0;
                    Console.WriteLine("Device_1:Burn-in finished:@timer14");
                    btnTestDvc1.Enabled = true; 
                    btnBurn1hrDvc1.Enabled = true;             
                    bTempChkInBurnDvc1 = false;
                    //txtSnoDvc1.Text = "";
                    break;
            }
        }

        //2023-06-17
        int iBurnTempLow = 40;  int iBurnTempHigh = 50;
        int iTempUcl = 50;  int iTempLcl = 10;  //2023-08-08
        Boolean bTempOver50Dvc0, bTempOver50Dvc1, bTempOver50Dvc2, bTempOver50Dvc3
            , bTempOver50Dvc4, bTempOver50Dvc5, bTempOver50Dvc6, bTempOver50Dvc7
            , bTempOver50Dvc8, bTempOver50Dvc9 = false; //if temp over 50 degrees(AT+TEMP?)
        Boolean bTempUnder40Dvc0, bTempUnder40Dvc1, bTempUnder40Dvc2, bTempUnder40Dvc3
            , bTempUnder40Dvc4, bTempUnder40Dvc5, bTempUnder40Dvc6, bTempUnder40Dvc7
            , bTempUnder40Dvc8, bTempUnder40Dvc9 = false; //if temp under 40 degrees(AT+TEMP?)
        Boolean bSetCurr0Dvc0, bSetCurr0Dvc1, bSetCurr0Dvc2, bSetCurr0Dvc3
            , bSetCurr0Dvc4, bSetCurr0Dvc5, bSetCurr0Dvc6, bSetCurr0Dvc7
            , bSetCurr0Dvc8, bSetCurr0Dvc9 = false;   //if Curr has set to 0
        Boolean bWaitCoolDvc0, bWaitCoolDvc1, bWaitCoolDvc2, bWaitCoolDvc3
            , bWaitCoolDvc4, bWaitCoolDvc5, bWaitCoolDvc6, bWaitCoolDvc7
            , bWaitCoolDvc8, bWaitCoolDvc9 = false; //if waiting coll down under 40
        Boolean bTempSensorNgDvc0, bTempSensorNgDvc1, bTempSensorNgDvc2, bTempSensorNgDvc3
            , bTempSensorNgDvc4, bTempSensorNgDvc5, bTempSensorNgDvc6, bTempSensorNgDvc7
            , bTempSensorNgDvc8, bTempSensorNgDvc9 = false; //2023-06-19:if temperature sensor isn't detected
        //2022-11-30
        Boolean bBurnAll2ndTesting = false; //2022-11-30: If there's no other Testing. 
        int iBurnStopStepDvc0Stay, iBurnStopStepDvc1Stay, iBurnStopStepDvc2Stay,
            iBurnStopStepDvc3Stay, iBurnStopStepDvc4Stay, iBurnStopStepDvc5Stay,
            iBurnStopStepDvc6Stay, iBurnStopStepDvc7Stay, iBurnStopStepDvc8Stay,
            iBurnStopStepDvc9Stay = 0;
        const int iBurnRetWaitTime = 5; //2023-06-19

        int iWaitTimerMs = 5;    //2023-02-18:Set 5 min
        int iMsecCount = 10;    //2023-02-18:1ms = 1 million counts
        int iWaitCount; //2023-02-18

        private void timer6_Tick(object sender, EventArgs e)    //For Device3:2022-11-14
        {
            dtBurnTimeDvc3 = DateTime.Now;
            TimeSpan tsBurnDvc3 = new TimeSpan(dtBurnTimeDvc3.Ticks - dtBurnStartDvc3.Ticks);   
            int iBurnTimeDvc3 = Convert.ToInt32(Math.Floor(tsBurnDvc3.TotalSeconds) / 60);  //2022-11-16
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc3)  
            {
                case 0:
                    lblBurnRestDvc3.Visible = true; 
                    btnBurnStopDvc3.Visible = true; 
                    btnBurnStopDvc3.Enabled = true;                    
                    iBurnStopStepDvc3 += 1; //2023-02-16
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc3.Enabled = false;
                    iBurnStopStepDvc3 += 1;
                    txtTestRmkDvc3.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc3 += 1;
                    utilDvcxSerialWrite(eCPort.cPort3, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc3 += 1;
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc3.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc3 += 1;
                        bBurn1hrDvc3 = true;    //starting burn-in
                        bBurnFinishedDvc3 = false;
                        btnTestDvc3_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc3)
                    {
                        bAtComReceivDvc3 = false;
                        iBurnStopStepDvc3 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_3 Burn-in 1hr Start.");
                        lblFinalDvc3.Text = "Burn-in Testing..."; lblFinalDvc3.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc3Serial, strDvc3Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc3 += 1;
                    break;

                case 11: //2023-02-16
                    //if ((iBurnTimeDvc3 > iTempChkTime) && !bTempChkInBurnDvc3)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc3Serial, strDvc3Com);
                    //    utilDvcxSerialWrite(eCPort.cPort3, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc3 = true;
                    //}

                    if (!bTempSensorNgDvc3) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort3, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc3 && !bWaitCoolDvc3)
                    {
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc3 = 12;
                    }
                    else if (bTempUnder40Dvc3 && bWaitCoolDvc3)
                    {
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc3 = 13;
                    }

                    if (iBurnTimeDvc3 > iBurnMin || bBurnStopDvc3) 
                    {
                        bBurnFinishedDvc3 = true;
                        //OpenPort(Dvc3Serial, strDvc3Com);
						//Dvc3Serial.DiscardInBuffer(); Dvc3Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc3 = 20;
                        bBurnStopDvc3 = false; 
                        richBox.AppendText("Device_3 快要完成了，請等候燒機後的測試紀錄\r\n"); 
                    }
                    else { lblBurnRestDvc3.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc3).ToString() + "分鐘"; }    //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc3)  //CURR has been set to 0
                    { 
                        iBurnStopStepDvc3 = 11; bWaitCoolDvc3 = true;
                        richBox.AppendText("Device_3 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc3) //CURR has been set to 146
                    { 
                        iBurnStopStepDvc3 = 11; bWaitCoolDvc3 = false;
                        richBox.AppendText("Device_3 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc3++;
                        if (iIntevalCntDvc3 >= iTempWatchInterval * (1000 / timer6.Interval))
                        {
                            iIntevalCntDvc3 = 0;
                            utilDvcxSerialWrite(eCPort.cPort3, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc3 > iTempChkTime) && !bTempChkInBurnDvc3)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc3Serial, strDvc3Com);
                    //    utilDvcxSerialWrite(eCPort.cPort3, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc3 = true;
                    //}
                    if (iBurnTimeDvc3 > iBurnMin || bBurnStopDvc3)
                    {
                        bBurnFinishedDvc3 = true;
                        //OpenPort(Dvc3Serial, strDvc3Com);
                        //Dvc3Serial.DiscardInBuffer(); Dvc3Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc3 = 20;
                        bBurnStopDvc3 = false;
                        richBox.AppendText("Device_3 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else { lblBurnRestDvc3.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc3).ToString() + "分鐘"; }    //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc3 += 1;
                    txtTestRmkDvc3.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc3 = 30;
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc3.Visible = false;
                    //txtTestRmkDvc3.Text = "After Burn-in";   //2023-06-17
                    btnTestDvc3_Click(this, null); 
                    //utilDvcxSerialWrite(eCPort.cPort3, "AT+RET" + "\r\n");  //2022-12-04
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc3Stay = 0;  //2022-11-30                    
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc3);    //2023-02-17
                    if (bAtComReceivDvc3)    //2022-12-01
                    {
                        bAtComReceivDvc3 = false;
                        iBurnStopStepDvc3 += 1;
                    }
                    else if (iBurnStopStepDvc3Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc3Stay = 0;
                        richBox.AppendText("Device_3 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc3 += 1;
                    }
                    else
                    { iBurnStopStepDvc3Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc3.Text == "") //2023-06-30
                    { iBurnStopStepDvc3 = 100; }
                    else
                    { iBurnStopStepDvc3 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc3 = 100;
                    break;

                case 100:
                    timer6.Enabled = false;
                    iBurnStopStepDvc3 = 0;
                    Console.WriteLine("Device_3:Burn-in finished:@timer6");
                    btnTestDvc3.Enabled = true; 
                    btnBurn1hrDvc3.Enabled = true;                   
                    bTempChkInBurnDvc3 = false; //2023-02-21
                    //txtSnoDvc3.Text = "";   //2023-06-15
                    //txtTestRmkDvc3.Text = "";   //2023-06-28
                    richBox.AppendText("Device_3:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc3.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void timer7_Tick(object sender, EventArgs e)    //For Device_4:2022-11-14
        {
            dtBurnTimeDvc4 = DateTime.Now;
            TimeSpan tsBurnDvc4 = new TimeSpan(dtBurnTimeDvc4.Ticks - dtBurnStartDvc4.Ticks);
            int iBurnTimeDvc4 = Convert.ToInt32(Math.Floor(tsBurnDvc4.TotalSeconds) / 60);  //2022-11-16
            //Console.WriteLine("Device_4: " + iDvcId + " Burn-in duration = " + iBurnTimeDvc4 + " min.");
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc4)
            {
                case 0:
                    lblBurnRestDvc4.Visible = true;
                    btnBurnStopDvc4.Visible = true;
                    btnBurnStopDvc4.Enabled = true;
                    iBurnStopStepDvc4 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc4.Enabled = false;
                    iBurnStopStepDvc4 += 1;
                    txtTestRmkDvc4.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc4 += 1;
                    utilDvcxSerialWrite(eCPort.cPort4, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc4 += 1;
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc4.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc4 += 1;
                        bBurn1hrDvc4 = true;    //starting burn-in
                        bBurnFinishedDvc4 = false;
                        btnTestDvc4_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc4)
                    {
                        bAtComReceivDvc4 = false;
                        iBurnStopStepDvc4 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_4 Burn-in 1hr Start.");
                        lblFinalDvc4.Text = "Burn-in Testing..."; lblFinalDvc4.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc4Serial, strDvc4Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc4 += 1;
                    break;
                case 11:                    
                    if (!bTempSensorNgDvc4) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort4, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc4 && !bWaitCoolDvc4)
                    {
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc4 = 12;
                    }
                    else if (bTempUnder40Dvc4 && bWaitCoolDvc4)
                    {
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc4 = 13;
                    }

                    if (iBurnTimeDvc4 > iBurnMin || bBurnStopDvc4)
                    {
                        bBurnFinishedDvc4 = true;
                        iBurnStopStepDvc4 = 20;
                        //OpenPort(Dvc4Serial, strDvc4Com);
						//Dvc4Serial.DiscardInBuffer(); Dvc4Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc4 = false;
                        richBox.AppendText("Device_4 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc4.Text = "燒機還要: " + (iBurnMin- iBurnTimeDvc4).ToString() + "分鐘"; }  //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc4)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc4 = 11; bWaitCoolDvc4 = true;
                        richBox.AppendText("Device_4 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc4) //CURR has been set to 146
                    {
                        iBurnStopStepDvc4 = 11; bWaitCoolDvc4 = false;
                        richBox.AppendText("Device_4 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc4++;
                        if (iIntevalCntDvc4 >= iTempWatchInterval * (1000 / timer7.Interval))
                        {
                            iIntevalCntDvc4 = 0;
                            utilDvcxSerialWrite(eCPort.cPort4, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc4 > iTempChkTime) && !bTempChkInBurnDvc4)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc4Serial, strDvc4Com);
                    //    utilDvcxSerialWrite(eCPort.cPort4, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc4 = true;
                    //}
                    if (iBurnTimeDvc4 > iBurnMin || bBurnStopDvc4)
                    {
                        bBurnFinishedDvc4 = true;
                        iBurnStopStepDvc4 = 20;
                        //OpenPort(Dvc4Serial, strDvc4Com);
                        //Dvc4Serial.DiscardInBuffer(); Dvc4Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc4 = false;
                        richBox.AppendText("Device_4 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc4.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc4).ToString() + "分鐘"; }  //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc4 += 1;
                    txtTestRmkDvc4.Text = "After Burn-in";
                    break;
                case 21:
                    bBurnAll2ndTesting = true;  //2022-11-30
                    iBurnStopStepDvc4 = 30;
                    btnBurnStopDvc4.Visible = false;
                    btnTestDvc4_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc4Stay = 0;  //2022-11-30
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc4);    //2023-02-17
                    if (!bBurnAll2ndTesting)    //2022-12-01
                    {
                        //OpenPort(Dvc4Serial, strDvc4Com);
                        //Dvc4Serial.Write("AT+BIS 0" + "\r\n");  //2022-12-01
                        iBurnStopStepDvc4 += 1;
                    }
                    else if (iBurnStopStepDvc4Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc4Stay = 0;
                        richBox.AppendText("Device_4 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc4 += 1;
                    }
                    else
                    { iBurnStopStepDvc4Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc4.Text == "") //2023-06-30
                    { iBurnStopStepDvc4 = 100; }
                    else
                    { iBurnStopStepDvc4 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc4 = 100;
                    break;

                case 100:
                    timer7.Enabled = false;
                    iBurnStopStepDvc4 = 0;
                    Console.WriteLine("Device_4:Burn-in finished:@timer7");
                    btnTestDvc4.Enabled = true;
                    btnBurn1hrDvc4.Enabled = true;
                    //ControlBox = true;                    
                    bTempChkInBurnDvc4 = false; //2023-02-21
                    //txtSnoDvc4.Text = "";   //2023-06-15
                    //txtTestRmkDvc4.Text = "";   //2023-06-28
                    richBox.AppendText("Device_4:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc4.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void btnBurnStopDvc3_Click(object sender, EventArgs e)  //2022-11-14
        {
            if (MessageBox.Show("確定要中斷 Device_3燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc3.Enabled = false;
                richBox.AppendText("interrupting...Device_3燒機提早停止，請稍候...\r\n");

                bBurnStopDvc3 = true;
                //MessageBox.Show("Device_3提早結束燒機，請再等候約30sec結束測試，不要立刻關閉電源與程式，請注意紀錄的時間非原預訂的燒機時間");
            }
        }

        private void btnBurnStopDvc4_Click(object sender, EventArgs e)  //2022-11-14
        {
            if (MessageBox.Show("確定要中斷 Device_4燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc4.Enabled = false;
                richBox.AppendText("interrupting...Device_4燒機提早停止，請稍候...\r\n");

                bBurnStopDvc4 = true;
                //MessageBox.Show("Device_4提早結束燒機，請再等候約30sec結束測試，不要立刻關閉電源與程式，請注意紀錄的時間非原預訂的燒機時間");
            }
        }

        private void timer8_Tick(object sender, EventArgs e)   //For Device_5: 2022-11-14
        {
            dtBurnTimeDvc5 = DateTime.Now;
            TimeSpan tsBurnDvc5 = new TimeSpan(dtBurnTimeDvc5.Ticks - dtBurnStartDvc5.Ticks);
            int iBurnTimeDvc5 = Convert.ToInt32(Math.Floor(tsBurnDvc5.TotalSeconds) / 60);  //2022-11-16
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc5)
            {
                case 0:
                    lblBurnRestDvc5.Visible = true;
                    btnBurnStopDvc5.Visible = true;
                    btnBurnStopDvc5.Enabled = true;
                    iBurnStopStepDvc5 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc5.Enabled = false;
                    iBurnStopStepDvc5 += 1;
                    txtTestRmkDvc5.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc5 += 1;
                    utilDvcxSerialWrite(eCPort.cPort5, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc5 += 1;
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc5.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc5 += 1;
                        bBurn1hrDvc5 = true;    //starting burn-in
                        bBurnFinishedDvc5 = false;
                        btnTestDvc5_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc5)
                    {
                        bAtComReceivDvc5 = false;
                        iBurnStopStepDvc5 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_5 Burn-in 1hr Start.");
                        lblFinalDvc5.Text = "Burn-in Testing..."; lblFinalDvc5.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc5Serial, strDvc5Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc5 += 1;
                    break;

                case 11:                    
                    if (!bTempSensorNgDvc5) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort5, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc5 && !bWaitCoolDvc5)
                    {
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc5 = 12;
                    }
                    else if (bTempUnder40Dvc5 && bWaitCoolDvc5)
                    {
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc5 = 13;
                    }

                    if (iBurnTimeDvc5 > iBurnMin || bBurnStopDvc5)
                    {
                        bBurnFinishedDvc5 = true;
                        //OpenPort(Dvc5Serial, strDvc5Com);
						//Dvc5Serial.DiscardInBuffer(); Dvc5Serial.DiscardOutBuffer();  //2022-12-04
                        iBurnStopStepDvc5 = 20;
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc5 = false;
                        richBox.AppendText("Device_5 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc5.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc5).ToString() + "分鐘"; } //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc5)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc5 = 11; bWaitCoolDvc5 = true;
                        richBox.AppendText("Device_5 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc5) //CURR has been set to 146
                    {
                        iBurnStopStepDvc5 = 11; bWaitCoolDvc5 = false;
                        richBox.AppendText("Device_5 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc5++;
                        if (iIntevalCntDvc5 >= iTempWatchInterval * (1000 / timer8.Interval))
                        {
                            iIntevalCntDvc5 = 0;
                            utilDvcxSerialWrite(eCPort.cPort5, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc5 > iTempChkTime) && !bTempChkInBurnDvc5)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc5Serial, strDvc5Com);
                    //    utilDvcxSerialWrite(eCPort.cPort5, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc5 = true;
                    //}
                    if (iBurnTimeDvc5 > iBurnMin || bBurnStopDvc5)
                    {
                        bBurnFinishedDvc5 = true;
                        //OpenPort(Dvc5Serial, strDvc5Com);
                        //Dvc5Serial.DiscardInBuffer(); Dvc5Serial.DiscardOutBuffer();  //2022-12-04
                        iBurnStopStepDvc5 = 20;
                        utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc5 = false;
                        richBox.AppendText("Device_5 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc5.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc5).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc5 += 1;
                    txtTestRmkDvc5.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc5 = 30;
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc5.Visible = false;
                    btnTestDvc5_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc5Stay = 0;  //2022-11-30                                     
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc5);    //2023-02-17
                    if (bAtComReceivDvc5)    //2022-12-01
                    {
                        bAtComReceivDvc5 = false;
                        iBurnStopStepDvc5 += 1;
                    }
                    else if (iBurnStopStepDvc5Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc5Stay = 0;
                        richBox.AppendText("Device_5 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc5 += 1;
                    }
                    else
                    { iBurnStopStepDvc5Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc5.Text == "") //2023-06-30
                    { iBurnStopStepDvc5 = 100; }
                    else
                    { iBurnStopStepDvc5 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc5 = 100;
                    break;

                case 100:
                    timer8.Enabled = false;
                    Console.WriteLine("Device_5:Burn-in finished:@timer8");
                    btnTestDvc5.Enabled = true;
                    btnBurn1hrDvc5.Enabled = true;
                    iBurnStopStepDvc5 = 0;
                    //ControlBox = true;                    
                    bTempChkInBurnDvc5 = false; //2023-02-21
                    //txtSnoDvc5.Text = "";   //2023-06-15
                    //txtTestRmkDvc5.Text = "";   //2023-06-28
                    richBox.AppendText("Device_5:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc5.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void btnTestDvc5_Click(object sender, EventArgs e)  //2022-11-15
        {
            if (!StationCheck(5)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc5.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc5.Enabled = true; btnBurn1hrDvc5.Enabled = true;
                    return;
                }
            }
            lblFinalDvc5.Text = ""; lblBurnRestDvc5.Text = "";
            if (iBurnStopStepDvc5 == 0)     //2023-08-11
            { txtTestRmkDvc5.Text = ""; }
            btnTestDvc5.Enabled = false;
            btnBurn1hrDvc5.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort5, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc5Serial, strDvc5Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc5Serial, strDvc5Com))
            {
				//Dvc5Serial.DiscardInBuffer(); Dvc5Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort5, "AT+RET" + "\r\n");
                dts5 = DateTime.Now; //2023-02-15
                strDateTimeDvc5= /*DateTime.Now*/dts5.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc5:Test not finished for COM port " + strDvc5Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc5)
            { 
                lblFinalDvc5.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc5)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnBurn1hrDvc5_Click(object sender, EventArgs e)   //2022-11-15
        {
            /*
            if (!StationCheck(5)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc5.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc5.Enabled = true; btnBurn1hrDvc5.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_5......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc5.Enabled = false;
            txtTestRmkDvc5.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc5Serial, strDvc5Com))    //2022-11-28
            {
                //Dvc5Serial.DiscardInBuffer(); Dvc5Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort5, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting    
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc5Serial, strDvc5Com);  
			//Dvc5Serial.DiscardInBuffer(); Dvc5Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS 1" + "\r\n"); //burn-in setting
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc5 = true; 
            bBurnFinishedDvc5 = false;
            //ControlBox = false;

            txtTestRmkDvc5.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc5_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_5 Burn-in 1hr Start.");
            lblFinalDvc5.Text = "Burn-in Testing..."; lblFinalDvc5.ForeColor = Color.Red;
            */
            timer8.Enabled = true; iBurnStopStepDvc5 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc5 = DateTime.Now;
            //txtTestRmkDvc5.Text = "";   //2023-02-15
            bTempSensorNgDvc5 = false;  //2023-06-19
        }

        private void btnTestDvc6_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (!StationCheck(6)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc6.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc6.Enabled = true; btnBurn1hrDvc6.Enabled = true;
                    return;
                }
            }
            lblFinalDvc6.Text = ""; lblBurnRestDvc6.Text = "";
            if (iBurnStopStepDvc6 == 0)     //2023-08-11
            { txtTestRmkDvc6.Text = ""; }
            btnTestDvc6.Enabled = false;
            btnBurn1hrDvc6.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort6, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc6Serial, strDvc6Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc6Serial, strDvc6Com))
            {
                //Dvc6Serial.DiscardInBuffer(); Dvc6Serial.DiscardOutBuffer();  //2022-12-04
				utilDvcxSerialWrite(eCPort.cPort6, "AT+RET" + "\r\n");
                dts6 = DateTime.Now; //2023-02-15
                strDateTimeDvc6 = /*DateTime.Now*/dts6.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc6:Test not finished for COM port " + strDvc6Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc6)
            { 
                lblFinalDvc6.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc6)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnBurn1hrDvc6_Click(object sender, EventArgs e)   //2022-11-16
        {
            /*
            if (!StationCheck(6)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc6.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc6.Enabled = true; btnBurn1hrDvc6.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_6......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc6.Enabled = false;
            txtTestRmkDvc6.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc6Serial, strDvc6Com))    //2022-11-28
            {
                //Dvc6Serial.DiscardInBuffer(); Dvc6Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort6, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting  
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc6Serial, strDvc6Com);
            //Dvc6Serial.DiscardInBuffer(); Dvc6Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS 1" + "\r\n"); //burn-in setting 
            timerDelay1ms(200);  //2022-11-28
 
            bBurn1hrDvc6 = true;
            bBurnFinishedDvc6 = false;
            //ControlBox = false;

            txtTestRmkDvc6.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc6_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_6 Burn-in Start.");
            lblFinalDvc6.Text = "Burn-in Testing..."; lblFinalDvc6.ForeColor = Color.Red;
            */
            timer9.Enabled = true; iBurnStopStepDvc6 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc6 = DateTime.Now;
            //txtTestRmkDvc6.Text = "";   //2023-02-15
            bTempSensorNgDvc6 = false;  //2023-06-19
        }

        private void timer9_Tick(object sender, EventArgs e)   //For Device_6: 2022-11-16
        {
            dtBurnTimeDvc6 = DateTime.Now;
            TimeSpan tsBurnDvc6 = new TimeSpan(dtBurnTimeDvc6.Ticks - dtBurnStartDvc6.Ticks);
            int iBurnTimeDvc6 = Convert.ToInt32(Math.Floor(tsBurnDvc6.TotalSeconds) / 60);  //2022-11-16
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc6)
            {
                case 0:
                    lblBurnRestDvc6.Visible = true;
                    btnBurnStopDvc6.Visible = true;
                    btnBurnStopDvc6.Enabled = true;
                    iBurnStopStepDvc6 += 1; //2023-02-16
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc6.Enabled = false;
                    iBurnStopStepDvc6 += 1;
                    txtTestRmkDvc6.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc6 += 1;
                    utilDvcxSerialWrite(eCPort.cPort6, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc6 += 1;
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc6.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc6 += 1;
                        bBurn1hrDvc6 = true;    //starting burn-in
                        bBurnFinishedDvc6 = false;
                        btnTestDvc6_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc6)
                    {
                        bAtComReceivDvc6 = false;
                        iBurnStopStepDvc6 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_6 Burn-in 1hr Start.");
                        lblFinalDvc6.Text = "Burn-in Testing..."; lblFinalDvc6.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc6Serial, strDvc6Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc6 += 1;
                    break;

                case 11: //2023-02-16
                    if (!bTempSensorNgDvc6) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort6, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc6 && !bWaitCoolDvc6)
                    {
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc6 = 12;
                    }
                    else if (bTempUnder40Dvc6 && bWaitCoolDvc6)
                    {
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc6 = 13;
                    }

                    if (iBurnTimeDvc6 > iBurnMin || bBurnStopDvc6)
                    {
                        iBurnStopStepDvc6 = 20;
                        bBurnFinishedDvc6 = true;
                        //OpenPort(Dvc6Serial, strDvc6Com);
                        //Dvc6Serial.DiscardInBuffer(); Dvc6Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc6 = false;
                        richBox.AppendText("Device_6 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc6.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc6).ToString() + "分鐘"; } //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc6)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc6 = 11; bWaitCoolDvc6 = true;
                        richBox.AppendText("Device_6 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc6) //CURR has been set to 146
                    {
                        iBurnStopStepDvc6 = 11; bWaitCoolDvc6 = false;
                        richBox.AppendText("Device_6 Laser opening.\r\n");
                    }
                    break;
                    #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc6++;
                        if (iIntevalCntDvc6 >= iTempWatchInterval * (1000 / timer9.Interval))
                        {
                            iIntevalCntDvc6 = 0;
                            utilDvcxSerialWrite(eCPort.cPort6, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc6 > iTempChkTime) && !bTempChkInBurnDvc6)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc6Serial, strDvc6Com);
                    //    utilDvcxSerialWrite(eCPort.cPort6, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc6 = true;                        
                    //}
                    if (iBurnTimeDvc6 > iBurnMin || bBurnStopDvc6)
                    {
                        iBurnStopStepDvc6 = 20;
                        bBurnFinishedDvc6 = true;
                        //OpenPort(Dvc6Serial, strDvc6Com);
                        //Dvc6Serial.DiscardInBuffer(); Dvc6Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc6 = false;
                        richBox.AppendText("Device_6 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc6.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc6).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc6 += 1;
                    txtTestRmkDvc6.Text = "After Burn-in";
                    break;
                case 21:
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc6.Visible = false;
                    iBurnStopStepDvc6 = 30;
                    btnTestDvc6_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc6Stay = 0;  //2022-11-30                    
                    break;
                case 30:                    
                    Console.WriteLine(strDateTimeDvc6);    //2023-02-17

                    if (bAtComReceivDvc6)    //2022-12-01
                    {
                        bAtComReceivDvc6 = false;
                        iBurnStopStepDvc6 += 1;
                    }
                    else if (iBurnStopStepDvc6Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc6Stay = 0;
                        richBox.AppendText("Device_6 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc6 += 1;
                    }
                    else
                    { iBurnStopStepDvc6Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc6.Text == "") //2023-06-30
                    { iBurnStopStepDvc6 = 100; }
                    else
                    { iBurnStopStepDvc6 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc6 = 100;
                    break;
                case 100:    //2023-02-21
                    timer9.Enabled = false;
                    Console.WriteLine("Device_6:Burn-in finished:@timer9");
                    btnTestDvc6.Enabled = true;
                    btnBurn1hrDvc6.Enabled = true;
                    //ControlBox = true;                    
                    bTempChkInBurnDvc6 = false; //2023-02-21
                    //txtSnoDvc6.Text = "";   //2023-06-15
                    iBurnStopStepDvc6 = 0;
                    //txtTestRmkDvc6.Text = "";   //2023-06-28
                    richBox.AppendText("Device_6:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc6.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void timer10_Tick(object sender, EventArgs e)   //For Device_7: 2022-11-16
        {
            dtBurnTimeDvc7 = DateTime.Now;
            TimeSpan tsBurnDvc7 = new TimeSpan(dtBurnTimeDvc7.Ticks - dtBurnStartDvc7.Ticks);
            int iBurnTimeDvc7 = Convert.ToInt32(Math.Floor(tsBurnDvc7.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc7)
            {
                case 0:
                    lblBurnRestDvc7.Visible = true;
                    btnBurnStopDvc7.Visible = true;
                    btnBurnStopDvc7.Enabled = true;
                    iBurnStopStepDvc7 += 1; //2023-02-16
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc7.Enabled = false;
                    iBurnStopStepDvc7 += 1;
                    txtTestRmkDvc7.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc7 += 1;
                    utilDvcxSerialWrite(eCPort.cPort7, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc7 += 1;
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc7.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc7 += 1;
                        bBurn1hrDvc7 = true;    //starting burn-in
                        bBurnFinishedDvc7 = false;
                        btnTestDvc7_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc7)
                    {
                        bAtComReceivDvc7 = false;
                        iBurnStopStepDvc7 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_7 Burn-in 1hr Start.");
                        lblFinalDvc7.Text = "Burn-in Testing..."; lblFinalDvc7.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10: //2023-02-16
                    if (IsOpenPort(Dvc7Serial, strDvc7Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc7 += 1;
                    break;

                case 11:
                    if (!bTempSensorNgDvc7) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort7, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc7 && !bWaitCoolDvc7)
                    {
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc7 = 12;
                    }
                    else if (bTempUnder40Dvc7 && bWaitCoolDvc7)
                    {
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc7 = 13;
                    }

                    if (iBurnTimeDvc7 > iBurnMin || bBurnStopDvc7)
                    {
                        bBurnFinishedDvc7 = true;
                        iBurnStopStepDvc7 = 20;
                        //OpenPort(Dvc7Serial, strDvc7Com);
						//Dvc7Serial.DiscardInBuffer(); Dvc7Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc7 = false;
                        richBox.AppendText("Device_7 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc7.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc7).ToString() + "分鐘"; } //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc7)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc7 = 11; bWaitCoolDvc7 = true;
                        richBox.AppendText("Device_7 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc7) //CURR has been set to 146
                    {
                        iBurnStopStepDvc7 = 11; bWaitCoolDvc7 = false;
                        richBox.AppendText("Device_7 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc7++;
                        if (iIntevalCntDvc7 >= iTempWatchInterval * (1000 / timer10.Interval))
                        {
                            iIntevalCntDvc7 = 0;
                            utilDvcxSerialWrite(eCPort.cPort7, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc7 > iTempChkTime) && !bTempChkInBurnDvc7)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc7Serial, strDvc7Com);
                    //    utilDvcxSerialWrite(eCPort.cPort7, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc7 = true;
                    //}
                    if (iBurnTimeDvc7 > iBurnMin || bBurnStopDvc7)
                    {
                        bBurnFinishedDvc7 = true;
                        iBurnStopStepDvc7 = 20;
                        //OpenPort(Dvc7Serial, strDvc7Com);
                        //Dvc7Serial.DiscardInBuffer(); Dvc7Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc7 = false;
                        richBox.AppendText("Device_7 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc7.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc7).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc7 += 1;
                    txtTestRmkDvc7.Text = "After Burn-in";
                    break;
                case 21:                    
                        bBurnAll2ndTesting = true;  //2022-11-30
                        btnBurnStopDvc7.Visible = false;
                        iBurnStopStepDvc7 = 30;
                        btnTestDvc7_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                        iBurnStopStepDvc7Stay = 0;  //2022-11-30                    
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc7);    //2023-02-17
                    if (bAtComReceivDvc7)    //2022-12-01
                    {
                        bAtComReceivDvc7= false;
                        iBurnStopStepDvc7 += 1;
                    }
                    else if (iBurnStopStepDvc7Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc7Stay = 0;
                        richBox.AppendText("Device_7 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc7 += 1;
                    }
                    else
                    { iBurnStopStepDvc7Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc7.Text == "") //2023-06-30
                    { iBurnStopStepDvc7 = 100; }
                    else
                    { iBurnStopStepDvc7 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc7 = 100;
                    break;

                case 100:
                    timer10.Enabled = false;
                    iBurnStopStepDvc7 = 0;
                    Console.WriteLine("Device_7:Burn-in finished:@timer10");
                    btnTestDvc7.Enabled = true;
                    btnBurn1hrDvc7.Enabled = true;
                    bTempChkInBurnDvc7 = false; //2023-02-21
                    //txtSnoDvc7.Text = "";   //2023-06-15
                    //txtTestRmkDvc7.Text = "";   //2023-06-28
                    richBox.AppendText("Device_7:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc7.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void timer11_Tick(object sender, EventArgs e)   //For Device_8: 2023-06-27
        {
            dtBurnTimeDvc8 = DateTime.Now;
            TimeSpan tsBurnDvc8 = new TimeSpan(dtBurnTimeDvc8.Ticks - dtBurnStartDvc8.Ticks);
            int iBurnTimeDvc8 = Convert.ToInt32(Math.Floor(tsBurnDvc8.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc8)
            {
                case 0:
                    lblBurnRestDvc8.Visible = true;
                    btnBurnStopDvc8.Visible = true;
                    btnBurnStopDvc8.Enabled = true;
                    iBurnStopStepDvc8 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc8.Enabled = false;
                    iBurnStopStepDvc8 += 1;
                    txtTestRmkDvc8.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc8 += 1;
                    utilDvcxSerialWrite(eCPort.cPort8, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc8 += 1;
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc8.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc8 += 1;
                        bBurn1hrDvc8 = true;    //starting burn-in
                        bBurnFinishedDvc8 = false;
                        btnTestDvc8_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc8)
                    {
                        bAtComReceivDvc8 = false;
                        iBurnStopStepDvc8 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_8 Burn-in 1hr Start.");
                        lblFinalDvc8.Text = "Burn-in Testing..."; lblFinalDvc8.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc8Serial, strDvc8Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc8 += 1; 
                    break;

                case 11:
                    if (!bTempSensorNgDvc8) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort8, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc8 && !bWaitCoolDvc8)
                    {
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc8 = 12;
                    }
                    else if (bTempUnder40Dvc8 && bWaitCoolDvc8)
                    {
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc8 = 13;
                    }

                    if (iBurnTimeDvc8 > iBurnMin || bBurnStopDvc8)
                    {
                        bBurnFinishedDvc8 = true;
                        iBurnStopStepDvc8 = 20;
                        //OpenPort(Dvc8Serial, strDvc8Com);
						//Dvc8Serial.DiscardInBuffer(); Dvc8Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc8 = false;
                        richBox.AppendText("Device_8 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc8.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc8).ToString() + "分鐘"; } //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc8)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc8 = 11; bWaitCoolDvc8 = true;
                        richBox.AppendText("Device_8 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc8) //CURR has been set to 146
                    {
                        iBurnStopStepDvc8 = 1; bWaitCoolDvc8 = false;
                        richBox.AppendText("Device_8 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc8++;
                        if (iIntevalCntDvc8 >= iTempWatchInterval * (1000 / timer11.Interval))
                        {
                            iIntevalCntDvc8 = 0;
                            utilDvcxSerialWrite(eCPort.cPort8, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc8 > iTempChkTime) && !bTempChkInBurnDvc8)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc8Serial, strDvc8Com);
                    //    utilDvcxSerialWrite(eCPort.cPort8, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc8 = true;
                    //}
                    if (iBurnTimeDvc8 > iBurnMin || bBurnStopDvc8)
                    {
                        bBurnFinishedDvc8 = true;
                        iBurnStopStepDvc8 = 20;
                        //OpenPort(Dvc8Serial, strDvc8Com);
                        //Dvc8Serial.DiscardInBuffer(); Dvc8Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc8 = false;
                        richBox.AppendText("Device_8 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc8.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc8).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc8 += 1;
                    txtTestRmkDvc8.Text = "After Burn-in";
                    break;
                case 21:
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc8.Visible = false;
                    iBurnStopStepDvc8 = 30;
                    btnTestDvc8_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc8Stay = 0;  //2022-11-30                    
                    break;
                case 30:                    
                    Console.WriteLine(strDateTimeDvc8);    //2023-02-17
                    if (bAtComReceivDvc8)    //2022-12-01
                    {
                        bAtComReceivDvc8 = false;
                        iBurnStopStepDvc8 += 1;
                    }
                    else if (iBurnStopStepDvc8Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc8Stay = 0;
                        richBox.AppendText("Device_8 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc8 += 1;
                    }
                    else
                    { iBurnStopStepDvc8Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc8.Text == "") //2023-06-30
                    { iBurnStopStepDvc8 = 100; }
                    else
                    { iBurnStopStepDvc8 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc8 = 100;
                    break;

                case 100:
                    timer11.Enabled = false;
                    iBurnStopStepDvc8 = 0;
                    Console.WriteLine("Device_8:Burn-in finished:@timer11");
                    btnTestDvc8.Enabled = true;
                    btnBurn1hrDvc8.Enabled = true;
                    //ControlBox = true;                    
                    bTempChkInBurnDvc8 = false; //2023-02-21
                    //txtSnoDvc8.Text = "";   //2023-06-15
                    //txtTestRmkDvc8.Text = "";   //2023-06-28
                    richBox.AppendText("Device_8:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc8.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void timer12_Tick(object sender, EventArgs e)   //For Device_9: 2022-11-16
        {
            dtBurnTimeDvc9 = DateTime.Now;
            TimeSpan tsBurnDvc9 = new TimeSpan(dtBurnTimeDvc9.Ticks - dtBurnStartDvc9.Ticks);
            int iBurnTimeDvc9 = Convert.ToInt32(Math.Floor(tsBurnDvc9.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc9)
            {
                case 0:
                    lblBurnRestDvc9.Visible = true;
                    btnBurnStopDvc9.Visible = true;
                    btnBurnStopDvc9.Enabled = true;
                    iBurnStopStepDvc9 += 1; //2023-02-16                   
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc9.Enabled = false;
                    iBurnStopStepDvc9 += 1;
                    txtTestRmkDvc9.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc9 += 1;
                    utilDvcxSerialWrite(eCPort.cPort9, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc9 += 1;
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc9.Text = "Before Burn-in";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc9 += 1;
                        bBurn1hrDvc9 = true;    //starting burn-in
                        bBurnFinishedDvc9 = false;
                        btnTestDvc9_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc9)
                    {
                        bAtComReceivDvc9 = false;
                        iBurnStopStepDvc9 = 19; //10; //2023-06-28
                        Console.WriteLine("Device_9 Burn-in Start." + "\r\n");
                        lblFinalDvc9.Text = "Burn-in Testing..."; lblFinalDvc9.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc9Serial, strDvc9Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc9 += 1; 
                    break;

                case 11:
                    if (!bTempSensorNgDvc9) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort9, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc9 && !bWaitCoolDvc9)
                    {
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc9 = 12;
                    }
                    else if (bTempUnder40Dvc9 && bWaitCoolDvc9)
                    {
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc9 = 13;
                    }

                    if (iBurnTimeDvc9 > iBurnMin || bBurnStopDvc9)
                    {
                        bBurnFinishedDvc9 = true;
                        iBurnStopStepDvc9 = 20;
                        //OpenPort(Dvc9Serial, strDvc9Com);
						//Dvc9Serial.DiscardInBuffer(); Dvc9Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc9 = false;
                        richBox.AppendText("Device_9 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc9.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc9).ToString() + "分鐘"; } //2022-12-01
                    break;
                case 12:
                    if (bSetCurr0Dvc9)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc9 = 11; bWaitCoolDvc9 = true;
                        richBox.AppendText("Device_9 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc9) //CURR has been set to 146
                    {
                        iBurnStopStepDvc9 = 11; bWaitCoolDvc9 = false;
                        richBox.AppendText("Device_9 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc9++;
                        if (iIntevalCntDvc9 >= iTempWatchInterval * (1000 / timer12.Interval))
                        {
                            iIntevalCntDvc9 = 0;
                            utilDvcxSerialWrite(eCPort.cPort9, "AT+TEMP?" + "\r\n");
                        }
                    }
                    //if ((iBurnTimeDvc9 > iTempChkTime) && !bTempChkInBurnDvc9)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc9Serial, strDvc9Com);
                    //    utilDvcxSerialWrite(eCPort.cPort9, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc9 = true;
                    //}
                    if (iBurnTimeDvc9 > iBurnMin || bBurnStopDvc9)
                    {
                        bBurnFinishedDvc9 = true;
                        iBurnStopStepDvc9 = 20;
                        //OpenPort(Dvc9Serial, strDvc9Com);
                        //Dvc9Serial.DiscardInBuffer(); Dvc9Serial.DiscardOutBuffer();  //2022-12-04
                        utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        bBurnStopDvc9 = false;
                        richBox.AppendText("Device_9 快要完成了，請等候燒機後的測試紀錄\r\n");
                    }
                    else
                    { lblBurnRestDvc9.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc9).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc9 += 1;
                    txtTestRmkDvc9.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc9 = 30;
                    bBurnAll2ndTesting = true;
                    btnBurnStopDvc9.Visible = false;
                    btnTestDvc9_Click(null, null); 
                    timerDelay1s(iBurnRetWaitTime);
                    iBurnStopStepDvc9Stay = 0;
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc9);    //2023-02-17
                    if (bAtComReceivDvc9)    //2022-12-01
                    {
                        bAtComReceivDvc9 = false;
                        iBurnStopStepDvc9 += 1;
                    }
                    else if (iBurnStopStepDvc9Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc9Stay = 0;
                        iBurnStopStepDvc9 += 1;
                        richBox.AppendText("Device_9 燒機後電測無回應結果-2？\r\n");
                    }
                    else
                    { iBurnStopStepDvc9Stay += 1; }
                    
                    break;
                case 31:
                    if (txtSnoDvc9.Text == "") //2023-06-30
                    { iBurnStopStepDvc9 = 100; }
                    else
                    { iBurnStopStepDvc9 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc9 = 100;
                    break;

                case 100:
                    timer12.Enabled = false;
                    iBurnStopStepDvc9 = 0;
                    Console.WriteLine("Device_9:Burn-in finished:@timer12");
                    btnTestDvc9.Enabled = true;
                    btnBurn1hrDvc9.Enabled = true;                   
                    bTempChkInBurnDvc9 = false; //2023-02-21
                    //txtSnoDvc9.Text = "";   //2023-06-15
                    //txtTestRmkDvc9.Text = "";   //2023-06-28
                    richBox.AppendText("Device_9:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc9.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void btnTestDvc7_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (!StationCheck(7)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc7.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc7.Enabled = true; btnBurn1hrDvc7.Enabled = true;
                    return;
                }
            }
            lblFinalDvc7.Text = ""; lblBurnRestDvc7.Text = "";
            if (iBurnStopStepDvc7 == 0)     //2023-08-11
            { txtTestRmkDvc7.Text = ""; }
            btnTestDvc7.Enabled = false;
            btnBurn1hrDvc7.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort7, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc7Serial, strDvc7Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc7Serial, strDvc7Com))
            {
				//Dvc7Serial.DiscardInBuffer(); Dvc7Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort7, "AT+RET" + "\r\n");
                dts7 = DateTime.Now; //2023-02-15
                strDateTimeDvc7 = /*DateTime.Now*/dts7.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc7:Test not finished for COM port " + strDvc7Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc7)
            { 
                lblFinalDvc7.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc7)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnTestDvc8_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (!StationCheck(8)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc8.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc8.Enabled = true; btnBurn1hrDvc8.Enabled = true;
                    return;
                }
            }
            lblFinalDvc8.Text = ""; lblBurnRestDvc8.Text = "";
            if (iBurnStopStepDvc8 == 0)     //2023-08-11
            { txtTestRmkDvc8.Text = ""; }
            btnTestDvc8.Enabled = false;
            btnBurn1hrDvc8.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort8, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc8Serial, strDvc8Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc8Serial, strDvc8Com))
            {
				//Dvc8Serial.DiscardInBuffer(); Dvc8Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort8, "AT+RET" + "\r\n");
                dts8 = DateTime.Now; //2023-02-15
                strDateTimeDvc8 = /*DateTime.Now*/dts8.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc8:Test not finished for COM port " + strDvc8Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc8)
            { 
                lblFinalDvc8.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc8)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnTestDvc9_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (!StationCheck(9)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc9.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc9.Enabled = true; btnBurn1hrDvc9.Enabled = true;
                    return;
                }
            }

            lblFinalDvc9.Text = ""; lblBurnRestDvc9.Text = "";
            if (iBurnStopStepDvc9 == 0)     //2023-08-11
            { txtTestRmkDvc9.Text = ""; }
            btnTestDvc9.Enabled = false;
            btnBurn1hrDvc9.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort9, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc9Serial, strDvc9Com);  //2022-12-01: One more port open for sure
            if (IsOpenPort(Dvc9Serial, strDvc9Com))
            {
				//Dvc9Serial.DiscardInBuffer(); Dvc9Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort9, "AT+RET" + "\r\n");
                dts9 = DateTime.Now; //2023-02-15
                strDateTimeDvc9 = /*DateTime.Now*/dts9.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc9:Test not finished for COM port " + strDvc9Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc9)
            { 
                lblFinalDvc9.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc9)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnBurn1hrDvc7_Click(object sender, EventArgs e)   //2022-11-16
        {
            /*
            if (!StationCheck(7)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc7.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc7.Enabled = true; btnBurn1hrDvc7.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_7......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc7.Enabled = false;
            txtTestRmkDvc7.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc7Serial, strDvc7Com))    //2022-11-28
            {
                //Dvc7Serial.DiscardInBuffer(); Dvc7Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort7, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting
            timerDelay1ms(100);  //2022-11-28

            utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28
 
            bBurn1hrDvc7 = true;
            bBurnFinishedDvc7 = false;
            //ControlBox = false;

            txtTestRmkDvc7.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc7_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_7 Burn-in Start.");
            lblFinalDvc7.Text = "Burn-in Testing..."; lblFinalDvc7.ForeColor = Color.Red;
            */
            timer10.Enabled = true; iBurnStopStepDvc7 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc7 = DateTime.Now;
            //txtTestRmkDvc7.Text = "";   //2023-02-15
            bTempSensorNgDvc7 = false;  //2023-06-19
        }

        private void btnBurn1hrDvc8_Click(object sender, EventArgs e)   //2022-11-16
        {
            /*
            if (!StationCheck(8)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc8.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc8.Enabled = true; btnBurn1hrDvc8.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_8......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc8.Enabled = false;
            txtTestRmkDvc8.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc8Serial, strDvc8Com))    //2022-11-28
            {
                //Dvc8Serial.DiscardInBuffer(); Dvc8Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort8, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting  
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc8Serial, strDvc8Com);
            //Dvc8Serial.DiscardInBuffer(); Dvc8Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc8 = true;
            bBurnFinishedDvc8 = false;
            //ControlBox = false;

            txtTestRmkDvc8.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc8_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_8 Burn-in Start.");
            lblFinalDvc8.Text = "Burn-in Testing..."; lblFinalDvc8.ForeColor = Color.Red;
            */
            timer11.Enabled = true; iBurnStopStepDvc8 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc8 = DateTime.Now;
            //txtTestRmkDvc8.Text = "";   //2023-02-15
            bTempSensorNgDvc8 = false;  //2023-06-19
        }

        private void btnBurn1hrDvc9_Click(object sender, EventArgs e)   //2022-11-16
        {
            /*
            if (!StationCheck(9)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc9.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc9.Enabled = true; btnBurn1hrDvc9.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_9......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc9.Enabled = false;
            txtTestRmkDvc9.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc9Serial, strDvc9Com))    //2022-11-28
            {
                //Dvc9Serial.DiscardInBuffer(); Dvc9Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort9, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting 
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc9Serial, strDvc9Com);
            //Dvc9Serial.DiscardInBuffer(); Dvc9Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc9 = true;
            bBurnFinishedDvc9 = false;
            //ControlBox = false;

            txtTestRmkDvc9.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc9_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_9 Burn-in Start.");
            lblFinalDvc9.Text = "Burn-in Testing..."; lblFinalDvc9.ForeColor = Color.Red;
            */
            timer12.Enabled = true; iBurnStopStepDvc9 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc9 = DateTime.Now;
            //txtTestRmkDvc9.Text = "";   //2023-02-15
            bTempSensorNgDvc9 = false;  //2023-06-19
        }

        private void btnBurnStopDvc5_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (MessageBox.Show("確定要中斷 Device_5燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc5.Enabled = false;
                richBox.AppendText("interrupting...Device_5燒機提早停止，請稍候...\r\n");
                bBurnStopDvc5 = true;
            }
        }

        private void btnBurnStopDvc6_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (MessageBox.Show("確定要中斷 Device_6燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc6.Enabled = false;
                richBox.AppendText("interrupting...Device_6燒機提早停止，請稍候...\r\n");
                bBurnStopDvc6 = true;
            }
        }

        private void btnBurnStopDvc7_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (MessageBox.Show("確定要中斷 Device_7燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc7.Enabled = false;
                richBox.AppendText("interrupting...Device_7燒機提早停止，請稍候...\r\n");
                bBurnStopDvc7 = true;
            }
        }

        private void btnBurnStopDvc8_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (MessageBox.Show("確定要中斷 Device_8燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc8.Enabled = false;
                richBox.AppendText("interrupting...Device_8燒機提早停止，請稍候...\r\n");
                bBurnStopDvc8 = true;
            }
        }

        private void btnBurnStopDvc9_Click(object sender, EventArgs e)  //2022-11-16
        {
            if (MessageBox.Show("確定要中斷 Device_9燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc9.Enabled = false;
                richBox.AppendText("interrupting...Device_9燒機提早停止，請稍候...\r\n");
                bBurnStopDvc9 = true;
            }
        }

        private void btnBurn1hrDvc4_Click(object sender, EventArgs e)   //2022-11-14
        {
            /*
            if (!StationCheck(4)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc4.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc4.Enabled = true; btnBurn1hrDvc4.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_4......Burn-in starting : " + "\r\n");
            btnBurn1hrDvc4.Enabled = false;
            txtTestRmkDvc4.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc4Serial, strDvc4Com))    //2022-11-28
            {
                //Dvc4Serial.DiscardInBuffer(); Dvc4Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort4, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting    
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc4Serial, strDvc4Com);
			//Dvc4Serial.DiscardInBuffer(); Dvc4Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc4 = true;
            bBurnFinishedDvc4 = false;
            //ControlBox = false;

            txtTestRmkDvc4.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc4_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_4 Burn-in Start.");
            lblFinalDvc4.Text = "Burn-in Testing..."; lblFinalDvc4.ForeColor = Color.Red;
            */
            timer7.Enabled = true; iBurnStopStepDvc4 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc4 = DateTime.Now;
            //txtTestRmkDvc4.Text = "";   //2023-02-15
            bTempSensorNgDvc4 = false;  //2023-06-19
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)   //2022-11-18
        {
            if (MessageBox.Show("Are you sure to exit？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //avoid serialPort not closed
                serialPort1.Close(); serialPort2.Close(); serialPort3.Close(); serialPort4.Close();
                serialPort5.Close(); serialPort6.Close(); serialPort7.Close();
                serialPort8.Close(); serialPort9.Close(); serialPort10.Close();
            }
            else { e.Cancel = true; }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) //2022-11-18
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void btnTestDvc4_Click(object sender, EventArgs e)  //2022-11-14
        {
            if (!StationCheck(4)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc4.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc4.Enabled = true; btnBurn1hrDvc4.Enabled = true;
                    return;
                }
            }
            lblFinalDvc4.Text = ""; lblBurnRestDvc4.Text = "";
            if (iBurnStopStepDvc4 == 0)     //2023-08-11
            { txtTestRmkDvc4.Text = ""; }
            btnTestDvc4.Enabled = false;
            btnBurn1hrDvc4.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort4, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            if (IsOpenPort(Dvc4Serial, strDvc4Com))
            {
				//Dvc4Serial.DiscardInBuffer(); Dvc4Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort4, "AT+RET" + "\r\n");
                dts4 = DateTime.Now; //2023-02-15
                strDateTimeDvc4 = /*DateTime.Now*/dts4.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc4:Test not finished for COM port " + strDvc4Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc4)
            { 
                lblFinalDvc4.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc4)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void timer13_Tick(object sender, EventArgs e)  //2022-11-31
        {
            BurnInQueue();  //BurnInAllQue();
        }
        private void BurnInAllQue()  //2022-11-23
        {
#if false
#region
            System.Windows.Forms.Application.DoEvents();
            switch (iBurnInQueStep)
            {
                case 0:
                    if (bBurnInQueStart)
                    { iBurnInQueStep += 1; } 
                    break;
                case 1:
                    if (strDvc0Com != null)    //Device_0
                    {
                        richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                        btnBurn1hrDvc0.Enabled = false;
                        btnTest_Click(null, null);
                        if (IsOpenPort(Dvc0Serial, strDvc0Com))
                        {
							//Dvc0Serial.DiscardInBuffer(); Dvc0Serial.DiscardOutBuffer();  //2022-12-04
                            utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS 1" + "\r\n");
                        }                        

                        Console.WriteLine("Device_0 Burn-in 1hr Start.");
                        lblFinalDvc0.Text = "Burn-in Testing..."; lblFinalDvc0.ForeColor = Color.Red;  //2022-06-17

                        bBurn1hr = true;
                        bBurnFinished = false;
                        //ControlBox = false; 

                        timer3.Enabled = true;
                        dtBurnStartDvc0 = DateTime.Now;

                        iBurnInQueStep += 1;
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 2:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        //timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 100)
                        {
                            richBox.AppendText("Device_0燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 11:
                    if (strDvc1Com != null)    //Device_1
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc1_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 12:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_1燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 21:
                    if (strDvc2Com != null)    //Device_2
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc2_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 22:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_2燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 31:
                    if (strDvc3Com != null)    //Device_3
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc3_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 32:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_3燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 41:
                    if (strDvc4Com != null)    //Device_4
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc4_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 42:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_4燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 51:
                    if (strDvc5Com != null)    //Device_5
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc5_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 52:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_5燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 61:
                    if (strDvc6Com != null)    //Device_6
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc6_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 62:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_6燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 71:
                    if (strDvc7Com != null)    //Device_7
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc7_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 72:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_7燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 81:
                    if (strDvc8Com != null)    //Device_8
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc8_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 82:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_8燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 91:
                    if (strDvc9Com != null)    //Device_9
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc9_Click(null, null);   //2022-11-23(avoid report repeat open)
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 92:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(500);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_9燒機前電測無回應？");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 101:
                    iBurnInQueStep = 0; bBurnInQueStart = false;
                    break;
            }
#endregion
#endif
        }

        private void btnBurnAll_Click(object sender, EventArgs e)   //2022-11-21: Connected devices all start burn in a row.
        {
            ChkFileExist(strFilePath); //2022-11-24
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (IsFileLocked(strFilePath))   //This must be after checking File.Exists
            {
                richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true;
                return;
            }

            if (!bBurnInQueStart)
            { 
                bBurnInQueStart = true;
                timer13.Enabled = true; //2022-11-31
            }
            else
            { 
                bBurnInQueStart = false;
                timer13.Enabled = false; //2022-11-31
            }
        }

        private void btnTestDvc3_Click(object sender, EventArgs e)  //2022-11-14
        {
            if (!StationCheck(3)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc3.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc3.Enabled = true; btnBurn1hrDvc3.Enabled = true;
                    return;
                }
            }
            lblFinalDvc3.Text = ""; lblBurnRestDvc3.Text = "";
            if (iBurnStopStepDvc3 == 0)     //2023-08-11
            { txtTestRmkDvc3.Text = ""; }
            btnTestDvc3.Enabled = false;
            btnBurn1hrDvc3.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            utilDvcxSerialWrite(eCPort.cPort3, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            //OpenPort(Dvc3Serial, strDvc3Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc3Serial, strDvc3Com))
            {
				//Dvc3Serial.DiscardInBuffer(); Dvc3Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort3, "AT+RET" + "\r\n");
                dts3 = DateTime.Now; //2023-02-15
                strDateTimeDvc3 = /*DateTime.Now*/dts3.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc3:Test not finished for COM port " + strDvc3Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc3)
            { 
                lblFinalDvc3.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc3)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnBurn1hrDvc3_Click(object sender, EventArgs e)   //2022-11-14
        {
            /*
            if (!StationCheck(3)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc3.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc3.Enabled = true; btnBurn1hrDvc3.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_3......Burn-in starting : " + "\r\n");  
            btnBurn1hrDvc3.Enabled = false;
            txtTestRmkDvc3.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc3Serial, strDvc3Com))    //2022-11-28
            {
                Dvc3Serial.DiscardInBuffer(); Dvc3Serial.DiscardOutBuffer();  //2022-12-04
                utilDvcxSerialWrite(eCPort.cPort3, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting    
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc3Serial, strDvc3Com); 
			//Dvc3Serial.DiscardInBuffer(); Dvc3Serial.DiscardOutBuffer();  //2022-12-04
            utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc3 = true;
            bBurnFinishedDvc3 = false;
            //ControlBox = false;

            txtTestRmkDvc3.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc3_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21

            Console.WriteLine("Device_3 Burn-in 1hr Start.");
            lblFinalDvc3.Text = "Burn-in Testing..."; lblFinalDvc3.ForeColor = Color.Red;
            */

            timer6.Enabled = true; iBurnStopStepDvc3 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc3 = DateTime.Now;
            //txtTestRmkDvc3.Text = "";   //2023-02-15
            bTempSensorNgDvc3 = false;  //2023-06-19
        }

        private void txtTempCheckTime_KeyDown(object sender, KeyEventArgs e)    //2023-02-14
        {
            if (e.KeyCode == Keys.Enter)    //if the enter key was pressed down
            { iTempChkTime = Convert.ToInt32(txtTempChkTime.Text); } //record temperature after iTempChkTime
        }

        private void btnBurnTimeSet_Click(object sender, EventArgs e)
        {
            iBurnMin = Convert.ToInt32(txtBurnTime.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            statusStrip1.AutoSize = false;  toolStripStatusLabel1.Width = 270;  //2024-02-20
            toolStripStatusLabel1.Text = ""; //2024-02-20
            txtMac.Text = GetMacAddress().ToString(); //2023-07-28
            utilCheckUserFile();    //2023-07-06
            lblSWver.Text = strSwVer;  //2022-06-27
            if (b4Customer)  //2022-06-27    //JIG FW
            { lblSWver.Text += strFwVer; } //Release to Customer recently
            else { lblSWver.Text += strFwVer; }
            this.Text = "Mercury_E: v" + strSwVer/*.Substring(10, 7)*/ + " (1_To_10 Burn-in)";   //2022-07-19
            lblVerPs.Text = "1對10燒機"; //2022-09-13
            txtBurnTime.Text = iBurnMin.ToString(); //2022-12-06

            btnTempReadDvc0.Visible = false; lblTempDvc0.Visible = false; txtTempDvc0.Visible = false;    //2022-06-13
            lblDevIdDvc0.Visible = false; lblTestRmkDvc0.Visible = false; txtTestRmkDvc0.Visible = false;    //2022-07-25
            lblDevIdDvc0.Text = ""; lblDevIdDvc1.Text = ""; lblDevIdDvc2.Text = ""; //2022-09-14
            lblDevIdDvc3.Text = ""; lblDevIdDvc4.Text = ""; lblDevIdDvc5.Text = ""; lblDevIdDvc6.Text = ""; //2022-11-09
            lblDevIdDvc7.Text = ""; lblDevIdDvc8.Text = ""; lblDevIdDvc9.Text = ""; //2022-11-09
            lblSta0optDvc0.Visible = false; btnMemsSetDvc0.Visible = false; cboSta0optDvc0.Visible = false; btnMemsReadDvc0.Visible = false;    //Burn-in only:2022-09-15            

            if (b4Customer || b4MGFelse)   //2022-06-22
            {
                btnBurn1hrDvc0.Visible = false; //2022-06-16    //btnBurn1hr not for Customer
                lblTestRmkDvc0.Visible = false; txtTestRmkDvc0.Visible = false; //2022-06-28
                lblDevIdDvc0.Visible = false;    //2022-07-21
            }
            else    //2022-07-25
            {
                lblDevIdDvc0.Visible = true; lblTestRmkDvc0.Visible = true; txtTestRmkDvc0.Visible = true;
            }

            lblBurnRestDvc0.Visible = false; btnBurnStopDvc0.Visible = false; btnBurnStopDvc0.ForeColor = Color.Red;    //2022-06-17
            lblBurnRestDvc1.Visible = false; btnBurnStopDvc1.Visible = false; btnBurnStopDvc1.ForeColor = Color.Red;    //2022-09-08
            lblBurnRestDvc2.Visible = false; btnBurnStopDvc2.Visible = false; btnBurnStopDvc2.ForeColor = Color.Red;    //2022-09-08
            //2022-11-15
            lblBurnRestDvc3.Visible = false; btnBurnStopDvc3.Visible = false; btnBurnStopDvc3.ForeColor = Color.Red;
            lblBurnRestDvc4.Visible = false; btnBurnStopDvc4.Visible = false; btnBurnStopDvc4.ForeColor = Color.Red;
            lblBurnRestDvc5.Visible = false; btnBurnStopDvc5.Visible = false; btnBurnStopDvc5.ForeColor = Color.Red;
            lblBurnRestDvc6.Visible = false; btnBurnStopDvc6.Visible = false; btnBurnStopDvc6.ForeColor = Color.Red;
            lblBurnRestDvc7.Visible = false; btnBurnStopDvc7.Visible = false; btnBurnStopDvc7.ForeColor = Color.Red;
            lblBurnRestDvc8.Visible = false; btnBurnStopDvc8.Visible = false; btnBurnStopDvc8.ForeColor = Color.Red;
            lblBurnRestDvc9.Visible = false; btnBurnStopDvc9.Visible = false; btnBurnStopDvc9.ForeColor = Color.Red;

            InitPortConfig();
            utilVerChk();   //2024-03-07, 2025-07-10

            Control.CheckForIllegalCrossThreadCalls = false;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(dataReceived1);
            //准备就绪- ready
            serialPort1.DtrEnable = true;
            serialPort1.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort1.ReadTimeout = 1000;
            serialPort1.Close();

            serialPort2.DataReceived += new SerialDataReceivedEventHandler(dataReceived2);
            //准备就绪- ready
            serialPort2.DtrEnable = true;
            serialPort2.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort2.ReadTimeout = 1000;
            serialPort2.Close();

            serialPort3.DataReceived += new SerialDataReceivedEventHandler(dataReceived3);
            //准备就绪- ready
            serialPort3.DtrEnable = true;
            serialPort3.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort3.ReadTimeout = 1000;
            serialPort3.Close();
            #region
            //2022-11-15: serialPort4
            serialPort4.DataReceived += new SerialDataReceivedEventHandler(dataReceived4);
            //准备就绪- ready
            serialPort4.DtrEnable = true;
            serialPort4.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort4.ReadTimeout = 1000;
            serialPort4.Close();
            #endregion
            #region
            //2022-11-15: serialPort5
            serialPort5.DataReceived += new SerialDataReceivedEventHandler(dataReceived5);
            //准备就绪- ready
            serialPort5.DtrEnable = true;
            serialPort5.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort5.ReadTimeout = 1000;
            serialPort5.Close();
            #endregion
            #region
            //2022-11-15: serialPort6
            serialPort6.DataReceived += new SerialDataReceivedEventHandler(dataReceived6);
            //准备就绪- ready
            serialPort6.DtrEnable = true;
            serialPort6.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort6.ReadTimeout = 1000;
            serialPort6.Close();
            #endregion
            #region
            //2022-11-15: serialPort7
            serialPort7.DataReceived += new SerialDataReceivedEventHandler(dataReceived7);
            //准备就绪- ready
            serialPort7.DtrEnable = true;
            serialPort7.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort7.ReadTimeout = 1000;
            serialPort7.Close();
            #endregion
            #region
            //2022-11-15: serialPort8
            serialPort8.DataReceived += new SerialDataReceivedEventHandler(dataReceived8);
            //准备就绪- ready
            serialPort8.DtrEnable = true;
            serialPort8.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort8.ReadTimeout = 1000;
            serialPort8.Close();
            #endregion
            #region
            //2022-11-15: serialPort9
            serialPort9.DataReceived += new SerialDataReceivedEventHandler(dataReceived9);
            //准备就绪- ready
            serialPort9.DtrEnable = true;
            serialPort9.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort9.ReadTimeout = 1000;
            serialPort9.Close();
            #endregion
            #region
            //2022-11-15: serialPort10
            serialPort10.DataReceived += new SerialDataReceivedEventHandler(dataReceived10);
            //准备就绪- ready
            serialPort10.DtrEnable = true;
            serialPort10.RtsEnable = true; // Arduion Reset
            //设置数据读取超时为1秒- Set data read timeout limit = 1 sec;
            serialPort10.ReadTimeout = 1000;
            serialPort10.Close();
            #endregion

            if (b4ProdLine || b4Customer) //2022-06-22
            {
                //tabControl1.TabPages.Remove(tabPage_Test);   //Remove the Engineer_Setting page, 2022-5-23
            }
            ChkFileExist(strFileDailyPath); //2023-07-06
            ChkFileExist(strFilePath);  //2022-06-17
        }

        private void openport() //2022-5-6
        {
            if (!serialPort1.IsOpen)
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort1.PortName = strComSerial1;   //cboComList.Text;
                    cboBaudDvc0.Text = "115200";
                    serialPort1.Open();
                    timerDelay1ms(100);
                }
                catch   //2022-06-08
                {
                    serialPort1.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort2.IsOpen)
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort2.PortName = strComSerial2; //cboComList.Text;
                    cboBaudDvc1.Text = "115200";
                    serialPort2.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort2.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort3.IsOpen)
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort3.PortName = strComSerial3; //cboComList.Text;
                    cboBaudDvc2.Text = "115200";
                    serialPort3.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort3.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort4.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort4.PortName = strComSerial4; //cboComList.Text;
                    cboBaudDvc3.Text = "115200";
                    serialPort4.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort4.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort5.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort5.PortName = strComSerial5; //cboComList.Text;
                    cboBaudDvc4.Text = "115200";
                    serialPort5.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort5.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort6.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort6.PortName = strComSerial6; //cboComList.Text;
                    cboBaudDvc5.Text = "115200";
                    serialPort6.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort6.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort7.IsOpen)
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort7.PortName = strComSerial7; //cboComList.Text;
                    cboBaudDvc6.Text = "115200";
                    serialPort7.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort7.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort8.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort8.PortName = strComSerial8; //cboComList.Text;
                    cboBaudDvc7.Text = "115200";
                    serialPort8.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort8.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort9.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort9.PortName = strComSerial9; //cboComList.Text;
                    cboBaudDvc8.Text = "115200";
                    serialPort9.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort9.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
            if (!serialPort10.IsOpen)    //2022-12-04
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                    serialPort10.PortName = strComSerial10; //cboComList.Text;
                    cboBaudDvc9.Text = "115200";
                    serialPort10.Open();
                    timerDelay1ms(100);
                }
                catch
                {
                    serialPort10.Close();
                    //MessageBox.Show("Com Port not found.");
                }
            }
        }

        private void OpenPort(SerialPort serialportCnt, string strPort) //2022-08-08
        {
            if (/*serialportCnt != null &&*/ !serialportCnt.IsOpen)   //2022-12-01
            {
                try
                {
                    //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();                    
                    serialportCnt.PortName = strPort;    //cboComList.Text;
                    cboBaudDvc0.Text = "115200";
                    serialportCnt.Open();
                    timerDelay1ms(100);
                }
                catch   //2022-06-08
                {
                    serialportCnt.Close();
                    richBox.AppendText("Test not finished for COM port " + strPort + " was not opened." + "\r\n");//2022-12-01
                }
            }
        }

        public Boolean IsOpenPort(SerialPort serialPort, string strPort) //2022-08-03
        {
            if (serialPort != null)  //2022-12-01
            {
                OpenPort(serialPort, strPort);
                if (!serialPort.IsOpen)   //2023-02-21
                {
                    try
                    {
                        //string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();                    
                        serialPort.PortName = strPort;    //cboComList.Text;
                        cboBaudDvc0.Text = "115200";
                        serialPort.Open();
                        timerDelay1ms(100);
                    }
                    catch   //2022-06-08
                    {
                        serialPort.Close();
                        richBox.AppendText("Test not finished for COM port " + strPort + " was not opened." + "\r\n");//2022-12-01
                        return false;
                    }
                }

                timerDelay1ms(100);  //2022-12-01:Sometimes port open need time

                if (/*serialPort!=null &&*/ serialPort.IsOpen) //2022-12-01
                { return true; }
                else
                {
                    Console.WriteLine(serialPort + strPort + "cannot be opened.");  //2022-11-29
                    return false;
                }
            }
            else { return false; }

        }

        private void utilDvcxSerialWrite(eCPort port, string strCmd)  //by Jay:2022-12-04
        {
            int counter = 100000;
            if(eCPort.cPort0 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort0])
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort0] = true;
                IsOpenPort(Dvc0Serial, strDvc0Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc0Serial.DiscardOutBuffer();
                Dvc0Serial.DiscardInBuffer();
                Dvc0Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort1 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort1])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort1] = true;
                IsOpenPort(Dvc1Serial, strDvc1Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc1Serial.DiscardOutBuffer();
                Dvc1Serial.DiscardInBuffer();
                Dvc1Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort2 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort2])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort2] = true;
                IsOpenPort(Dvc2Serial, strDvc2Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc2Serial.DiscardOutBuffer();
                Dvc2Serial.DiscardInBuffer();
                Dvc2Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort3 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort3])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort3] = true;
                IsOpenPort(Dvc3Serial, strDvc3Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc3Serial.DiscardOutBuffer();
                Dvc3Serial.DiscardInBuffer();
                Dvc3Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort4 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort4])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort4] = true;
                IsOpenPort(Dvc4Serial, strDvc4Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc4Serial.DiscardOutBuffer();
                Dvc4Serial.DiscardInBuffer();
                Dvc4Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort5 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort5])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort5] = true;
                IsOpenPort(Dvc5Serial, strDvc5Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc5Serial.DiscardOutBuffer();
                Dvc5Serial.DiscardInBuffer();
                Dvc5Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort6 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort6])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort6] = true;
                IsOpenPort(Dvc6Serial, strDvc6Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc6Serial.DiscardOutBuffer();
                Dvc6Serial.DiscardInBuffer();
                Dvc6Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort7 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort7])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort7] = true;
                IsOpenPort(Dvc7Serial, strDvc7Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc7Serial.DiscardOutBuffer();
                Dvc7Serial.DiscardInBuffer();
                Dvc7Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort8 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort8])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort8] = true;
                IsOpenPort(Dvc8Serial, strDvc8Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc8Serial.DiscardOutBuffer();
                Dvc8Serial.DiscardInBuffer();
                Dvc8Serial.Write(strCmd + "\r\n");
            }
            else if(eCPort.cPort9 == port)
            {
                while (abComPortBusyFlag[(int)eCPort.cPort9])                    
                {
                    counter--;
                    if(counter == 0)
                        break;
                }
                abComPortBusyFlag[(int)eCPort.cPort9] = true;
                IsOpenPort(Dvc9Serial, strDvc9Com);    //2023-06-17
                /* Serial Port Flush */
                Dvc9Serial.DiscardOutBuffer();
                Dvc9Serial.DiscardInBuffer();
                Dvc9Serial.Write(strCmd + "\r\n");
            }
            else
            {
                richBox.AppendText(port.ToString() + " port is invalid." + "\r\n"); 
            }
        }
        
        //初始化串口界面参数设置
        private void InitPortConfig()
        {
            int i;
            try
            {                
                string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                string[] baud = { "57600", "115200" };
                cboBaudDvc0.Items.AddRange(baud);
                cboBaudDvc0.Text = baud[1]; cboBaudDvc1.Text = baud[1]; cboBaudDvc2.Text = baud[1];    //by Eric   //2022-08-17
                serialPort1.BaudRate = Convert.ToInt32(cboBaudDvc0.Text);
                serialPort2.BaudRate = Convert.ToInt32(cboBaudDvc1.Text);   //2022-08-02
                serialPort3.BaudRate = Convert.ToInt32(cboBaudDvc2.Text);   //2022-08-17

                cboBaudDvc3.Text = baud[1]; cboBaudDvc4.Text = baud[1]; cboBaudDvc5.Text = baud[1];  //2022-11-08
                cboBaudDvc6.Text = baud[1]; cboBaudDvc7.Text = baud[1];  //2022-11-08
                cboBaudDvc8.Text = baud[1]; cboBaudDvc9.Text = baud[1];  //2022-11-08
                serialPort4.BaudRate = Convert.ToInt32(cboBaudDvc3.Text);  //2022-11-08
                serialPort5.BaudRate = Convert.ToInt32(cboBaudDvc4.Text);  //2022-11-08 
                serialPort6.BaudRate = Convert.ToInt32(cboBaudDvc5.Text);  //2022-11-08
                serialPort7.BaudRate = Convert.ToInt32(cboBaudDvc6.Text);  //2022-11-08
                serialPort8.BaudRate = Convert.ToInt32(cboBaudDvc7.Text);  //2022-11-08
                serialPort9.BaudRate = Convert.ToInt32(cboBaudDvc8.Text);  //2022-11-08
                serialPort10.BaudRate = Convert.ToInt32(cboBaudDvc9.Text);  //2022-11-08
                cboComList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                i = COMPort.Length - 1;
                //cboComList.Text = COMPort[i]; //2025-07-25
                T = COMPort.Length;
                lblFinalDvc0.Text = ""; lblFinalDvc1.Text = ""; lblFinalDvc2.Text = ""; //2022-09-08
                lblFinalDvc3.Text = ""; lblFinalDvc4.Text = ""; lblFinalDvc5.Text = ""; //2022-11-08
                lblFinalDvc6.Text = ""; lblFinalDvc7.Text = ""; lblFinalDvc8.Text = ""; lblFinalDvc9.Text = "";//2022-11-08
            }
            catch
            {

            }
        }

        private int GetAckCheckSum(ReceDataType sel, JObject jObj)
        {
            int intCS = 0;
            if (sel == ReceDataType.DATA_ACK)
            {
                foreach (var item in jObj)
                {
                    //if(item.Key == "checksum")
                    //    break;
                    if ((item.Key == "jver") || (item.Key == "dev") || (item.Key == "cmd"))
                    {
                        int strLength = item.Value.ToObject<string>().Length;
                        for (int i = 0; i < strLength; i++)
                        {
                            intCS += item.Value.ToObject<string>()[i];
                        }
                    }
                    else
                    {
                        //intCS += item.Value.ToObject<int>();
                        //---4 bytes checksum---    //2022-05-27
                        //Console.WriteLine(Convert.ToString(item.Value.ToObject<int>(), toBase: 16));    //to 16-bits
                        //Console.WriteLine(string.Format("{0,0:X8}", item.Value.ToObject<int>()));   //fill to 8 characters: 01,23,45,67
                        string strItemVal = Convert.ToString(string.Format("{0,0:X8}", item.Value.ToObject<int>()));
                        intCS += Convert.ToInt32(strItemVal.Substring(6, 2), 16);
                        intCS += Convert.ToInt32(strItemVal.Substring(4, 2), 16);
                        intCS += Convert.ToInt32(strItemVal.Substring(2, 2), 16);
                        intCS += Convert.ToInt32(strItemVal.Substring(0, 2), 16);
                    }
                }
            }
            else if (sel == ReceDataType.DATA_JSON)
            {
                foreach (var item in jObj)
                {
                    //if(item.Key == "checksum")
                    //    break;
                    if ((item.Key == "jver") || (item.Key == "dev") || (item.Key == "cmd"))
                    {
                        int strLength = item.Value.ToObject<string>().Length;
                        for (int i = 0; i < strLength; i++)
                        {
                            intCS += item.Value.ToObject<string>()[i];
                        }
                    }
                    else
                    {
                        //intCS += item.Value.ToObject<int>();
                        //---4 bytes checksum---    //2022-05-27
                        string strItemVal = Convert.ToString(string.Format("{0,0:X8}", item.Value.ToObject<int>()));    //to 16-bits  //fill to 8 characters: 01,23,45,67
                        intCS += Convert.ToInt32(strItemVal.Substring(6, 2), 16);  //Transfer the last byte to decimal value
                        intCS += Convert.ToInt32(strItemVal.Substring(4, 2), 16);
                        intCS += Convert.ToInt32(strItemVal.Substring(2, 2), 16);
                        intCS += Convert.ToInt32(strItemVal.Substring(0, 2), 16);
                    }
                }
            }
            intCS %= 256;
            return (intCS);
        }

        private void uartDataParser(char[] receData, int len)
        {
            //string strDev, strCmd, strType, /*strStaId,*/ strFwver, strIot, strTemp, strTMPsta,
            //    strPDP, strPDN, strPDresult, strCurr = "";   //2022-5-7            
            //string strTestRmk = "";  //2022-06-28, Add remark info column
            //string strDeviceID = "";    //2022-07-21, Add Device ID column

            if (len != 0)
            {
                int intJsonStartIdx = 0;    //
                int intJsonEndIdx = 0;  //
                RecRawData = aas.feedbackString(receData, len);
                tbxAtReturn.Text += RecRawData + "\r\n";    //Eric:2022-5-6
                for (int i = 0; i < len; i++)   //Eric
                {
                    if (receData[i] == '{') { intJsonStartIdx = i; }
                    if (receData[i] == '}') { intJsonEndIdx = i; }
                }

                if ((receData[intJsonStartIdx] == '{') && (receData[intJsonEndIdx] == '}'))    //
                {                   //if ( (receData[0] == '{') && (receData[len-3] == '}')) {                  
                    RecRawData = RecRawData.Substring(intJsonStartIdx, intJsonEndIdx - intJsonStartIdx + 1);  //Eric: Only take those Data between "{" & "}"
                    try
                    {
                        //bool PD_P_chk = false;
                        //bool PD_N_chk = false;
                        int calCheckSum = 0;    // calculate check sum
                        //string strResult = "Not yet";  //2022-05-27
                        //string strGPIOreturn = "";  //2022-4-19                        

                        // Newtonsoft.Json反序列化
                        ReciveJData rJD = JsonConvert.DeserializeObject<ReciveJData>(RecRawData);
                        if (rJD.type == (int)ReceDataType.DATA_JSON)
                        {
                            //richBox.AppendText("SN : " + barcode.Text + "\r\n");
                            string jsonStr = JsonConvert.SerializeObject(rJD, Formatting.Indented); //行列顯示,適人看
                            /* Serial Print */
                            //string jsonStr = JsonConvert.SerializeObject(rJD, Formatting.None); //串列顯示,不適人看
                            //richBox.AppendText(jsonStr + "\r\n");     //remarked by Eric:2022-04-15

                            JObject jObj = JObject.Parse(jsonStr);
                            calCheckSum = GetAckCheckSum(ReceDataType.DATA_JSON, jObj); //need to be 0
                            if (calCheckSum != 0/*rJA.checksum*/)
                            {
                                //richBox.AppendText("Checksum ERROR" + "\r\n");
                                Console.WriteLine("Checksum ERROR");
                            }
                            else
                            {
                                //richBox.AppendText("Checksum OK" + "\r\n");
                                Console.WriteLine("Checksum OK");
                            }

                            ///11/22
                            //string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                            //string strSeperator = ",";
                            StringBuilder sbOutput = new StringBuilder();
                            double fPDP, fPDN;

                            fPDP = rJD.PDP / 100.00;
                            fPDN = rJD.PDN / 100.00;
                            //string stringDateTime = DateTime.Now.ToString("yyyy-MM-dd-HH:mm:ss");
                            strDev = rJD.dev; strCmd = rJD.cmd; strType = rJD.type.ToString();
                            /*strStaId = rJD.id.ToString();*/  /*strFwver=rJD.fwver.ToString();*/  strIot = rJD.iot.ToString();
                            /*strTemp = rJD.temp.ToString(); strTMPsta = rJD.temps.ToString();*/ strPDP = /*rJD.PDP*/fPDP.ToString();   //2022-06-15
                            strPDN = /*rJD.PDN*/fPDN.ToString(); strPDresult = rJD.PDTest.ToString(); strCurr = rJD.current.ToString();
                            strFwver = (Convert.ToSingle((rJD.fwver).ToString("X")) / 10).ToString("0.0");   //FW ver: 16 -> 1.0
                            //strTestRmk = txtTestRmkDvc0.Text;   //2022-06-28
                            iStaId = rJD.id % 16; iDvcId = rJD.id / 16;   //2022-08-19
                            
                            //------------------------------------------------2023-02-15
                            if (iDvcId == 0) { stringDateTime = strDateTimeDvc0; }
                            else if (iDvcId == 1) { stringDateTime = strDateTimeDvc1; }
                            else if (iDvcId == 2) { stringDateTime = strDateTimeDvc2; }
                            else if (iDvcId == 3) { stringDateTime = strDateTimeDvc3; }
                            else if (iDvcId == 4) { stringDateTime = strDateTimeDvc4; }
                            else if (iDvcId == 5) { stringDateTime = strDateTimeDvc5; }
                            else if (iDvcId == 6) { stringDateTime = strDateTimeDvc6; }
                            else if (iDvcId == 7) { stringDateTime = strDateTimeDvc7; }
                            else if (iDvcId == 8) { stringDateTime = strDateTimeDvc8; }
                            else if (iDvcId == 9) { stringDateTime = strDateTimeDvc9; }

                            //string strSNo = ""; //2022-08-23

                            if (!b4Customer)   //2022-07-21
                            {
                                strDeviceID = "Device_" + iDvcId.ToString();
                            }

                            switch (/*rJD.id*/iStaId)
                            {
                                case 0: // Short I/O Test with Temperature
                                    radSta0Dvc0.Checked = true;
                                    strPDP = "NA"; strPDN = "NA"; strPDresult = "NA";
                                    strCurr = "NA";
                                    
                                    if (rJD.iot != 0 || rJD.temps != 0) 
                                    { strResult = "NG"; } //2022-5-9
                                    else { strResult = "PASS"; }                                    
                                    
                                    if (rJD.temps == 4 || strTMPsta == "4") { strTemp = "X"; }  //2022-06-08
                                    break;
                                case 1: // LD / PD with Temperature
                                    radSta1Dvc0.Checked = true;
                                    //if (rJD.PDTest != 0) { strResult = "NG"; }
                                    //else { strResult = "PASS"; }
                                    if (bChkPdByJig) //2022-08-30
                                    {
                                        strPDresult = rJD.PDTest.ToString();    //2022-09-01
                                    }
                                    else
                                    {
                                        if ((rJD.PDP >= configJson.FUNC_PDP_LCL* 100 && rJD.PDP <= configJson.FUNC_PDP_UCL*100) 
                                            && (rJD.PDN >= configJson.FUNC_PDN_LCL*100 && rJD.PDN <= configJson.FUNC_PDN_UCL*100) 
                                            /*&& (Math.Abs(rJD.PDP + rJD.PDN - 330) <= 10)*/)    //2023-08-22
                                        { strPDresult = "0"; }
                                        else { strPDresult = "1"; }
                                    }
                                    if (strPDresult == "0" /*&& rJD.temps == 0*/) { strResult = "PASS"; }   //2022-09-01
                                    else { strResult = "NG"; }
                                    strIot = "NA"; strTemp = "NA"; strTMPsta = "NA";
                                    richBox.AppendText("PDtest = " + strPDresult/*rJD.PDTest.ToString()*/ + "; PDP = " + rJD.PDP.ToString() + "; PDN = " + rJD.PDN.ToString() + "\r\n"); //2022-09-15
                                    break;
                                case 2: // HFOV / VFOV with Temperature, Burn-In loop
                                    radSta2Dvc0.Checked = true;
                                    break;
                                case 3: // Inspection, includ 0, 1, 2, but no IO_test
                                    if (iDvcId == 0) { radSta3Dvc0.Checked = true; }    //2022-08-19
                                    else if (iDvcId == 1) { radSta3Dvc1.Checked = true; }
                                    else if (iDvcId == 2) { radSta3Dvc2.Checked = true; }
                                    else if (iDvcId == 3) { radSta3Dvc3.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 4) { radSta3Dvc4.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 5) { radSta3Dvc5.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 6) { radSta3Dvc6.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 7) { radSta3Dvc7.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 8) { radSta3Dvc8.Checked = true; }    //2022-11-08
                                    else if (iDvcId == 9) { radSta3Dvc9.Checked = true; }    //2022-11-08
                                    //TypeConverter("radSta3Dvc" + iDvcId.ToString()).Checked = true;
                                    strPDP = /*rJD.PDP*/fPDP.ToString(); strPDN = /*rJD.PDN*/fPDN.ToString();   //2023-09-01
                                    if (bChkPdByJig) //2022-09-16
                                    {
                                        if (rJD.PDTest != 0) { strPDresult = "1"; }  //2022-09-01
                                        else { strPDresult = "0"; }
                                    }
                                    else
                                    {
                                        //if ((rJD.PDP >= 130 && rJD.PDP <= 140) && (rJD.PDN >= 186 && rJD.PDN <= 196))    //2022-08-30
                                        if ((/*rJD.PDP*/fPDP >= configJson.FUNC_PDP_LCL && /*rJD.PDP*/fPDP <= configJson.FUNC_PDP_UCL) 
                                            && (/*rJD.PDN*/fPDN >= configJson.FUNC_PDN_LCL && /*rJD.PDN*/fPDN <= configJson.FUNC_PDN_UCL) 
                                            /*&& (Math.Abs(fPDP + fPDN - 3.30) <= 0.10)*/)    //2023-09-05
                                       { strPDresult = "0"; }
                                        else { strPDresult = "1"; } //2022-09-16
                                    }

                                    strIot = "NA";
                                    //Console.WriteLine("Device: " + iDvcId + "; Station: " + strStaId + "; iBitVal=" + iBitVal);   //2022-08-19
                                    if (rJD.temps == 4 || strTMPsta == "4") { strTemp = "X"; }  //2022-06-08
                                    else { strTemp = rJD.temp.ToString(); /*strTMPsta = rJD.temps.ToString();*/ } //2023-08-02

                                    iTempUcl = configJson.FUNC_TEMP_SENSOR_TEST_UCL;    //2023-08-22
                                    iTempLcl = configJson.FUNC_TEMP_SENSOR_TEST_LCL;    //2023-08-22
                                    if (rJD.temp > iTempUcl || rJD.temp < iTempLcl)    //2023-08-08
                                    { strTMPsta = "3"; }
                                    else  //2023-09-04
                                    { if(rJD.temps != 4) 
                                        { strTMPsta = "0"; } 
                                    }

                                    if (strPDresult == "0" /*&& rJD.temps == 0*/ && strTMPsta == "0") //2023-08-08
                                    { strResult = "PASS"; }    //2022-09-01
                                    else { strResult = "NG"; }

                                    if (iDvcId == 0 && !bBurn1hr && iBitVal==0 /*&& strBisVal=="0"*/)   //2022-10-05
                                    {
                                        btnTestDvc0.Enabled = true; //2022-06-06
                                        btnBurn1hrDvc0.Enabled = true;  //2022-06-09
                                        //ControlBox = true;   //2022-06-30
                                    }

                                    if (iDvcId == 0) { strSNo = txtSnoDvc0.Text; strTestRmk = txtTestRmkDvc0.Text; }  //2022-09-08
                                    else if (iDvcId == 1) { strSNo = txtSnoDvc1.Text; strTestRmk = txtTestRmkDvc1.Text; }
                                    else if (iDvcId == 2) { strSNo = txtSnoDvc2.Text; strTestRmk = txtTestRmkDvc2.Text; }
                                    else if (iDvcId == 3) { strSNo = txtSnoDvc3.Text; strTestRmk = txtTestRmkDvc3.Text; }   //2022-11-08
                                    else if (iDvcId == 4) { strSNo = txtSnoDvc4.Text; strTestRmk = txtTestRmkDvc4.Text; }   //2022-11-08
                                    else if (iDvcId == 5) { strSNo = txtSnoDvc5.Text; strTestRmk = txtTestRmkDvc5.Text; }   //2022-11-08
                                    else if (iDvcId == 6) { strSNo = txtSnoDvc6.Text; strTestRmk = txtTestRmkDvc6.Text; }   //2022-11-08
                                    else if (iDvcId == 7) { strSNo = txtSnoDvc7.Text; strTestRmk = txtTestRmkDvc7.Text; }   //2022-11-08
                                    else if (iDvcId == 8) { strSNo = txtSnoDvc8.Text; strTestRmk = txtTestRmkDvc8.Text; }   //2022-11-08
                                    else if (iDvcId == 9) { strSNo = txtSnoDvc9.Text; strTestRmk = txtTestRmkDvc9.Text; }   //2022-11-08
                                    richBox.AppendText("SN : " + strSNo + "\r\n");    //2022-08-23
                                    richBox.AppendText("PDP = " + /*rJD.PDP*/fPDP.ToString() + " ; PDN = " + /*rJD.PDN*/fPDN.ToString() + " ; PDtest = " + strPDresult/*rJD.PDTest.ToString()*/ + "\r\n"); //2022-09-15
                                    richBox.AppendText("Temperature = " + /*rJD.temp.ToString()*/strTemp + " ; Temp_status = " + /*rJD.temps.ToString()*/strTMPsta + "\r\n");   //2023-09-01
                                    break;
                                case 4: // Test LD
                                    radSta4Dvc0.Checked = true;
                                    break;
                                default:

                                    break;
                            }
                                                        
                            if (rJD.iot != 0)
                            { richBox.AppendText("FPC IO test failed at IO_" + strIot + "\r\n"); }
                            if (rJD.temps == 4) //2023-09-05
                            { richBox.AppendText("Temerature sensor test failed." + "\r\n"); }

                            if (/*rJD.id*/iStaId != 0) //2022-06-01
                            {
                                switch (rJD.current)
                                {
                                    case 96:
                                        strCurr = "60 mA"; /*Convert.ToString(60);*/
                                        break;
                                    case 118:
                                        strCurr = "70 mA"; /*Convert.ToString(70);*/
                                        break;
                                    case 146:
                                        strCurr = "80 mA";/*Convert.ToString(80);*/
                                        break;
                                    default:
                                        if (rJD.current > 146) { strCurr = "Over 80 mA"; }
                                        if (rJD.current < 146 && rJD.current > 118) { strCurr = "Over 70 mA"; }
                                        if (rJD.current < 118 && rJD.current > 96) { strCurr = "Over 60 mA"; }
                                        if (rJD.current < 96) { strCurr = "under 60 mA"; }
                                        if (rJD.current == 0) { strCurr = "0 mA"; } //2023-06-17
                                        break;
                                }
                            }                            

                            //string[][] inaOutput = new string[][]
                            //{
                            //    new string[]{ /*txtSnoDvc0.Text*/strSNo, stringDateTime, /*strDev, strCmd, strType,*/   //2022-08-23
                            //        strStaId, /*strFwver,*/ strIot, strTemp, strTMPsta,
                            //        strPDP, strPDN, strPDresult, strCurr, strResult, strDeviceID, strTestRmk }   //2022-07-21
                            //};
                            
                            richBox.AppendText(strDeviceID + ", Station站別：" + strStaId + "\r\n");    //Eric:2022-06-16
                            cboStaSet.SelectedIndex = /*rJD.id*/iStaId;   //2022-05-25
                            richBox.AppendText(strDeviceID + ", Result: " + strResult + "\r\n");   //2022-08-18

                            if ((bBurn1hr && !bBurnFinished))    //(iDvcId == 0) 2022-09-01
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc0.Text = "Burn-in Testing.."; lblFinalDvc0.ForeColor = Color.Red;
                                if (bBurnInQueStart) 
                                { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc1 && !bBurnFinishedDvc1) /*|| !bBurnStopDvc1*/)    //2022-09-01
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc1.Text = "Burn-in Testing.."; lblFinalDvc1.ForeColor = Color.Red;
                                if (bBurnInQueStart) 
                                { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc2 && !bBurnFinishedDvc2))    //(iDvcId == 2)2022-09-01
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc2.Text = "Burn-in Testing.."; lblFinalDvc2.ForeColor = Color.Red;
                                if (bBurnInQueStart) 
                                { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc3 && !bBurnFinishedDvc3))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc3.Text = "Burn-in Testing.."; lblFinalDvc3.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc4 && !bBurnFinishedDvc4))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc4.Text = "Burn-in Testing.."; lblFinalDvc4.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc5 && !bBurnFinishedDvc5))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc5.Text = "Burn-in Testing.."; lblFinalDvc5.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc6 && !bBurnFinishedDvc6))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc6.Text = "Burn-in Testing.."; lblFinalDvc6.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc7 && !bBurnFinishedDvc7))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc7.Text = "Burn-in Testing.."; lblFinalDvc7.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc8 && !bBurnFinishedDvc8))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc8.Text = "Burn-in Testing.."; lblFinalDvc8.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }
                            else if ((bBurn1hrDvc9 && !bBurnFinishedDvc9))    //2022-11-08
                            {
                                richBox.AppendText(strDeviceID + ", Burn-in is running...燒機中\r\n");
                                lblFinalDvc9.Text = "Burn-in Testing.."; lblFinalDvc9.ForeColor = Color.Red;
                                if (bBurnInQueStart) { bBurnTestResponse = true; }  //2022-11-22
                            }

                            switch (iDvcId) //re-write: 2022-09-06
                            {
                                case 0:
                                    #region
                                    if (bBurnFinished)  //2022-09-16
                                    {
                                        lblFinalDvc0.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc0.ForeColor = Color.Black; //2022-06-16
                                        btnBurn1hrDvc0.Enabled = true;  //2022-06-07
                                        btnTestDvc0.Enabled = true;     //2022-06-20
                                        bBurnFinished = false; bBurn1hr = false;   //2022-11-29
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                        btnBurnStopDvc0.Visible = false; //2022-11-02
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hr && !bBurnFinished)   //2022-11-02
                                    { btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc0.Text != "" || strSNo != "") //2023-06-28
                                    {
                                        //sbOutput.AppendLine(string.Join(strSeperator, inaOutput[0]));
                                        //File.AppendAllText(strFilePath, sbOutput.ToString());
                                        LogFileSaving();    //2023-06-26
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hr)
                                        { bBurn1hr = false; } //2022-06-06                                      
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                        //Dvc0Serial.Close(); //serialPort1.Close();
                                        //if (bBurn1hr && bBurnFinished)    //2022-06-20(no SN)
                                        //{
                                        //    btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true; /*ControlBox = true;*/
                                        //    bBurn1hr = false;   //2022-11-29
                                        //    lblBurnRestDvc0.Text = "Burn-in 完成"; //2022-09-16
                                        //    bBurnAll2ndTesting = false; //2022-11-30
                                        //}
                                        //else if (rJD.cmd == "AT+RET" && !bBurn1hr && !bBurnFinished)   //2022-11-02
                                        //{ btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true; /*ControlBox = true;*/ }
                                    }
                                    bAtComReceivDvc0 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 1:
                                    #region
                                    if (bBurnFinishedDvc1)  //2022-09-16
                                    {
                                        lblFinalDvc1.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc1.ForeColor = Color.Black;
                                        btnBurn1hrDvc1.Enabled = true;  //2022-06-07
                                        btnTestDvc1.Enabled = true;     //2022-06-20
                                        bBurnFinishedDvc1 = false; bBurn1hrDvc1 = false;   //2022-11-29
                                        btnBurnStopDvc1.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc1 && !bBurnFinishedDvc1)   //2022-10-05
                                    { btnTestDvc1.Enabled = true; btnBurn1hrDvc1.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc1.Text != "" || strSNo != "") //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-26
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc1)
                                        { bBurn1hrDvc1 = false; } //2022-06-06
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc1 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 2:
#region
                                    if (bBurnFinishedDvc2)  //2022-09-16
                                    {
                                        lblFinalDvc2.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc2.ForeColor = Color.Black;
                                        btnBurn1hrDvc2.Enabled = true;  //2022-06-07
                                        btnTestDvc2.Enabled = true;     //2022-06-20
                                        bBurnFinishedDvc2 = false; bBurn1hrDvc2 = false;   //2022-11-29
                                        btnBurnStopDvc2.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc2 && !bBurnFinishedDvc2)   //2022-10-05
                                    { btnTestDvc2.Enabled = true; btnBurn1hrDvc2.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc2.Text != "" || strSNo != "") //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc2)
                                        { bBurn1hrDvc2 = false; } //2022-06-06
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc2 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 3:  //2022-11-08
#region
                                    if (bBurnFinishedDvc3)
                                    {
                                        lblFinalDvc3.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc3.ForeColor = Color.Black;
                                        btnBurn1hrDvc3.Enabled = true;
                                        btnTestDvc3.Enabled = true;
                                        bBurnFinishedDvc3 = false; bBurn1hrDvc3 = false;   //2022-11-29
                                        btnBurnStopDvc3.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc3 && !bBurnFinishedDvc3)
                                    { btnTestDvc3.Enabled = true; btnBurn1hrDvc3.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc3.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc3)
                                        { bBurn1hrDvc3 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc3 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 4:  //2022-11-14
#region
                                    if (bBurnFinishedDvc4)
                                    {
                                        lblFinalDvc4.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc4.ForeColor = Color.Black;
                                        btnBurn1hrDvc4.Enabled = true;
                                        btnTestDvc4.Enabled = true;
                                        bBurnFinishedDvc4 = false; bBurn1hrDvc4 = false;   //2022-11-29
                                        btnBurnStopDvc4.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc4 && !bBurnFinishedDvc4)
                                    { btnTestDvc4.Enabled = true; btnBurn1hrDvc4.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc4.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc4)
                                        { bBurn1hrDvc4 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc4 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 5:  //2022-11-15
#region
                                    if (bBurnFinishedDvc5)
                                    {
                                        lblFinalDvc5.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc5.ForeColor = Color.Black;
                                        btnBurn1hrDvc5.Enabled = true;
                                        btnTestDvc5.Enabled = true;
                                        bBurnFinishedDvc5 = false; bBurn1hrDvc5 = false;   //2022-11-29
                                        btnBurnStopDvc5.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc5 && !bBurnFinishedDvc5)
                                    { btnTestDvc5.Enabled = true; btnBurn1hrDvc5.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc5.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc5)
                                        { bBurn1hrDvc5 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc5 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 6:  //2022-11-16
#region
                                    if (bBurnFinishedDvc6)
                                    {
                                        lblFinalDvc6.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc6.ForeColor = Color.Black;
                                        btnBurn1hrDvc6.Enabled = true;
                                        btnTestDvc6.Enabled = true;
                                        bBurnFinishedDvc6 = false; bBurn1hrDvc6 = false;   //2022-11-29
                                        btnBurnStopDvc6.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc6 && !bBurnFinishedDvc6)
                                    { btnTestDvc6.Enabled = true; btnBurn1hrDvc6.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc6.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc6)
                                        { bBurn1hrDvc6 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc6 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 7:  //2022-11-16
#region
                                    if (bBurnFinishedDvc7)
                                    {
                                        lblFinalDvc7.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc7.ForeColor = Color.Black;
                                        btnBurn1hrDvc7.Enabled = true;
                                        btnTestDvc7.Enabled = true;
                                        bBurnFinishedDvc7 = false; bBurn1hrDvc7 = false;   //2022-11-29
                                        btnBurnStopDvc7.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc7 && !bBurnFinishedDvc7)
                                    { btnTestDvc7.Enabled = true; btnBurn1hrDvc7.Enabled = true; /*ControlBox = true;*/ }

                                    if (txtSnoDvc7.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc7)
                                        { bBurn1hrDvc7 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc7 = true;    //2023-06-30

                                    #endregion
                                    break;
                                case 8:  //2022-11-16
#region
                                    if (bBurnFinishedDvc8)
                                    {
                                        lblFinalDvc8.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc8.ForeColor = Color.Black;
                                        btnBurn1hrDvc8.Enabled = true;
                                        btnTestDvc8.Enabled = true;
                                        bBurnFinishedDvc8 = false; bBurn1hrDvc8 = false;   //2022-11-29
                                        btnBurnStopDvc8.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc8 && !bBurnFinishedDvc8)
                                    { btnTestDvc8.Enabled = true; btnBurn1hrDvc8.Enabled = true; ControlBox = true; }

                                    if (txtSnoDvc8.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc8)
                                        { bBurn1hrDvc8 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc8 = true;    //2023-06-30
                                    #endregion
                                    break;
                                case 9:  //2022-11-16
#region
                                    if (bBurnFinishedDvc9)
                                    {
                                        lblFinalDvc9.Text = "\r\nFinal : " + strResult;
                                        lblFinalDvc9.ForeColor = Color.Black;
                                        btnBurn1hrDvc9.Enabled = true;
                                        btnTestDvc9.Enabled = true;
                                        bBurnFinishedDvc9 = false; bBurn1hrDvc8 = false;   //2022-11-29
                                        btnBurnStopDvc9.Visible = false; //2022-09-16
                                        if (bBurnAll2ndTesting) //2022-11-30
                                        { bBurnAll2ndTesting = false; }
                                    }
                                    else if (rJD.cmd == "AT+RET" && !bBurn1hrDvc9 && !bBurnFinishedDvc9)
                                    { btnTestDvc9.Enabled = true; btnBurn1hrDvc9.Enabled = true; ControlBox = true; }

                                    if (txtSnoDvc9.Text != "" || strSNo != "")  //2023-06-28
                                    {
                                        LogFileSaving();    //2023-06-27
                                        timerDelay1ms(100);  //2022-11-24:Wait File.AppendAllText() complete.
                                        if (bBurn1hrDvc9)
                                        { bBurn1hrDvc9 = false; }
                                    }
                                    else
                                    {
                                        richBox.AppendText("The test result won't be saved since no serial number was inputted.\r\n");
                                    }
                                    bAtComReceivDvc9 = true;    //2023-06-30
                                    #endregion
                                    break;
                            }

                            //if (/*rJD.id*/iStaId == 0 && rJD.cmd=="AT+RET")     //2022-06-01
                            //{ btnTestDvc0.Enabled = true; }

                            //if (!bBurn1hr && bBurnFinished) //2022-06-02
                            //{ 
                            //    txtSnoDvc0.Text = "";
                            //}                                                                                    

                            //if (/*rJD.id*/iStaId != 3 /*&& rJD.id != 0*/ && /*rJD.id*/iStaId != 2)   //2022-05-31
                            //{ 
                            //    btnTestDvc0.Enabled = true;
                            //    Dvc0Serial.Close();  //serialPort1.Close();    //2022-05-16    //it should be colse or the com port won't be removed.
                            //    //barcode.Text = "";  //2022-06-09
                            //    ControlBox = true;   //2022-06-30
                            //}
                        }
                        else
                        {
                            //recDType = ReceDataType.DATA_ACK;                            
                            // Newtonsoft.Json反序列化
                            ReciveJAck rJA = JsonConvert.DeserializeObject<ReciveJAck>(RecRawData);                            

                            /* same as Arduino serializeJsonPretty */
                            //string jsonStr = JsonConvert.SerializeObject(rJA, Formatting.Indented); //行列顯示,適人看
                            string jsonStr = JsonConvert.SerializeObject(rJA, Formatting.None); //串列顯示,不適人看
                            //richBox.AppendText(jsonStr + "\r\n");

                            JObject jObj = JObject.Parse(jsonStr);                            

                            calCheckSum = GetAckCheckSum(ReceDataType.DATA_ACK, jObj); //need to be 0
                            if (calCheckSum != 0/*rJA.checksum*/)
                            {
                                /*richBox.AppendText*/
                                Console.WriteLine("ERROR checksum" + "\r\n");
                            }
                            else if (rJA.ack == (int)ReceAck.ACK_ERROR)
                            {
                                /*richBox.AppendText*/
                                Console.WriteLine("ERROR " + rJA.data1.ToString() + " " + rJA.data2.ToString() + "\r\n");
                            }
                            //else if (rJA.ack == 4) //No SX1503 IC   //2022-5-7
                            //{
                            //    richBox.AppendText("ERROR : No SX1503 IC" + "\r\n");
                            //}
                            else
                            {
                                //Console.WriteLine("Checksum Pass" + "\r\n");    //2022-05-27
                                //if (/*rJA.id*/iStaId != 3)    //2022-06-16
                                //{
                                //    strStaId = /*rJA.id*/iStaId.ToString();  //2022-06-01
                                //}

                                iStaId = rJA.id % 16;   //2022-08-29
                                iDvcId = rJA.id / 16;   //2022-08-29
                                strStaId = /*rJA.id*/iStaId.ToString(); //2023-06-17

                                switch (rJA.cmd) //2022-05-26
                                {
                                    case "AT+BIT?": //2022-06-02
                                        break;
                                    case "AT+BIS?": //2022-5-30
                                    case "AT+BIS":
                                        cboBis.SelectedIndex = rJA.data1;   
                                        //strBisVal = rJA.data1.ToString();   //2022-05-31                                        
                                        if (/*rJA.id*/iStaId == 2 && !bBurn1hr)   //2022-06-02
                                        {
                                            strBisVal = rJA.data1.ToString();   //2022-05-31
                                            if (rJA.data1 == 0) 
                                            {
                                                richBox.AppendText/*MessageBox.Show*/("Station <2-1>:MEMS Burn-in Test. 展開MEMS燒機測試\r\n");
                                                strStaId = "<2-1>";  //2022-05-31
                                            }
                                            if (rJA.data1 == 1) 
                                            {
                                                richBox.AppendText/*MessageBox.Show*/("Station <2-2>:Laser contiously on. 雷射測試(H不開)\r\n");
                                                strStaId = "<2-2>";  //2022-05-31
                                            }
                                        }
                                        if (/*rJA.id*/iStaId == 3)
                                        {                                            
                                            if (rJA.data1 == 0) 
                                            {
                                                switch (iDvcId)  //2022-09-05
                                                {
                                                   case 0:
                                                        strBisVal = rJA.data1.ToString();   //2022-05-31
                                                        if (!bBurn1hr && !bBurnFinished)
                                                        {
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinished || bBurn1hr) { strStaId = "<3-2>"; }
                                                        //Dvc0Serial.Close();
                                                        break;
                                                    case 1:
                                                        strBisValDvc1 = rJA.data1.ToString();   //2022-05-31
                                                        if (!bBurn1hrDvc1 && !bBurnFinishedDvc1)
                                                        {
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc1 || bBurn1hrDvc1) { strStaId = "<3-2>"; }
                                                        //Dvc1Serial.Close();
                                                        break;
                                                    case 2:
                                                        strBisValDvc2 = rJA.data1.ToString();   //2022-05-31
                                                        if (!bBurn1hrDvc2 && !bBurnFinishedDvc2)
                                                        {
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc2 || bBurn1hrDvc2) { strStaId = "<3-2>"; }
                                                        //Dvc2Serial.Close();
                                                        break;
                                                    case 3: //2022-11-14
                                                        strBisValDvc3 = rJA.data1.ToString();  
                                                        if (!bBurn1hrDvc3 && !bBurnFinishedDvc3)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }
                                                        //if (bBurnFinishedDvc3 || bBurn1hrDvc3) { strStaId = "<3-2>"; }
                                                        //Dvc3Serial.Close();
                                                        break;
                                                    case 4: //2022-11-14
                                                        strBisValDvc4 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc4 && !bBurnFinishedDvc4)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n"); 
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }
                                                        //if (bBurnFinishedDvc4 || bBurn1hrDvc4) { strStaId = "<3-2>"; }
                                                        //Dvc4Serial.Close();
                                                        break;
                                                    case 5: //2022-11-15
                                                        strBisValDvc5 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc5 && !bBurnFinishedDvc5)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc5 || bBurn1hrDvc5) { strStaId = "<3-2>"; }
                                                        //Dvc5Serial.Close();
                                                        break;
                                                    case 6: //2022-11-16
                                                        strBisValDvc6 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc6 && !bBurnFinishedDvc6)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc6 || bBurn1hrDvc6) { strStaId = "<3-2>"; }
                                                        //Dvc6Serial.Close();
                                                        break;
                                                    case 7: //2022-11-16
                                                        strBisValDvc7 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc7 && !bBurnFinishedDvc7)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc7 || bBurn1hrDvc7) { strStaId = "<3-2>"; }
                                                        //Dvc7Serial.Close();
                                                        break;
                                                    case 8: //2022-11-16
                                                        strBisValDvc8 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc8 && !bBurnFinishedDvc8)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc8 || bBurn1hrDvc8) { strStaId = "<3-2>"; }
                                                        //Dvc8Serial.Close();
                                                        break;
                                                    case 9: //2022-11-16
                                                        strBisValDvc9 = rJA.data1.ToString();
                                                        if (!bBurn1hrDvc9 && !bBurnFinishedDvc9)
                                                        { 
                                                            //richBox.AppendText("Station <3-1>:Full function. 全功能測試\r\n");
                                                            strStaId = "<3-1>"; //2022-11-15
                                                        }                                                        
                                                        //if (bBurnFinishedDvc9 || bBurn1hrDvc9) { strStaId = "<3-2>"; }
                                                        //Dvc9Serial.Close();
                                                        break;
                                                }
                                            }
                                            if (rJA.data1 == 1)
                                            {                                                
                                                strStaId = "<3-2>";  //2022-05-31
                                                //richBox.AppendText("Device: " + iDvcId + ", Burn-in Test for 1 hr. 燒機一小時測試\r\n");   //2022-09-05
                                                switch (iDvcId)  //2022-09-05
                                                {
                                                    case 0:
                                                        strBisVal = rJA.data1.ToString();   //2022-05-31
                                                        richBox.AppendText("Device: " + iDvcId +", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 1:
                                                        strBisValDvc1 = rJA.data1.ToString();   //2022-05-31
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 2:
                                                        strBisValDvc2 = rJA.data1.ToString();   //2022-05-31
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 3:   //2022-11-14
                                                        strBisValDvc3 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 4:   //2022-11-14
                                                        strBisValDvc4 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 5:   //2022-11-15
                                                        strBisValDvc5 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 6:   //2022-11-16
                                                        strBisValDvc6 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 7:   //2022-11-16
                                                        strBisValDvc7 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 8:   //2022-11-16
                                                        strBisValDvc8 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                    case 9:   //2022-11-16
                                                        strBisValDvc9 = rJA.data1.ToString();
                                                        richBox.AppendText("Device: " + iDvcId + ", Burn-in Test. 燒機測試\r\n");
                                                        break;
                                                }
                                            }
                                            if (bAtBisSet) 
                                            { bAtBisSet = false; }  //2022-08-29
                                        }

                                        break;
                                    case "AT+TEMP?":
                                        //bTempChkDuringBurn = false;
                                        //TempChkDuringBurn();
                                        //if (rJA.ack == 4) //No SX1503 IC   //2022-5-7
                                        //{ richBox.AppendText("ERROR : No SX1503 IC" + "\r\n"); }
                                        
                                        switch (iDvcId) //2023-02-17
                                        {
                                            case 0:
                                                if (bTempChkInBurnDvc0) 
                                                { 
                                                    txtTestRmkDvc0.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                    + "; " + rJA.data1.ToString() + " deg";
                                                    txtTempDvc0.Text = Convert.ToString(rJA.data1);
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_0: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc0 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh/*50*/)
                                                { bTempOver50Dvc0 = true; bTempUnder40Dvc0 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc0 = false; bTempUnder40Dvc0 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc0 = true; }
                                                break;                                             
                                            case 1:
                                                if (bTempChkInBurnDvc1) 
                                                { 
                                                    txtTestRmkDvc1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";                                                    
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_1: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc1 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc1 = true; bTempUnder40Dvc1 = false; }
                                                else if(rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow) 
                                                { bTempOver50Dvc1 = false; bTempUnder40Dvc1 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc1 = true; }
                                                break;
                                            case 2:
                                                if (bTempChkInBurnDvc2)
                                                {
                                                    txtTestRmkDvc2.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_2: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc2 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh) 
                                                { bTempOver50Dvc2 = true; bTempUnder40Dvc2 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc2 = false; bTempUnder40Dvc2 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc2 = true; }
                                                break;
                                            case 3:
                                                if (bTempChkInBurnDvc3)
                                                {
                                                    txtTestRmkDvc3.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_3: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc3 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc3 = true; bTempUnder40Dvc3 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc3 = false; bTempUnder40Dvc3 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc3 = true; }
                                                break;
                                            case 4:
                                                if (bTempChkInBurnDvc4)
                                                {
                                                    txtTestRmkDvc4.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_4: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc4 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc4 = true; bTempUnder40Dvc4 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc4 = false; bTempUnder40Dvc4 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc4 = true; }
                                                break;
                                            case 5:
                                                if (bTempChkInBurnDvc5)
                                                {
                                                    txtTestRmkDvc5.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_5: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc5 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc5 = true; bTempUnder40Dvc5 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc5 = false; bTempUnder40Dvc5 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc5 = true; }
                                                break;
                                            case 6:
                                                if (bTempChkInBurnDvc6)
                                                {
                                                    txtTestRmkDvc6.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_6: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc6 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc6 = true; bTempUnder40Dvc6 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc6 = false; bTempUnder40Dvc6 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc6 = true; }
                                                break;
                                            case 7:
                                                if (bTempChkInBurnDvc7)
                                                {
                                                    txtTestRmkDvc7.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_7: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc7 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc7 = true; bTempUnder40Dvc7 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc7 = false; bTempUnder40Dvc7 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc7 = true; }
                                                break;
                                            case 8:
                                                if (bTempChkInBurnDvc8)
                                                {
                                                    txtTestRmkDvc8.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_8: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc8 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc8 = true; bTempUnder40Dvc8 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc8 = false; bTempUnder40Dvc8 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc8 = true; }
                                                break;
                                            case 9:
                                                if (bTempChkInBurnDvc9)
                                                {
                                                    txtTestRmkDvc9.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
                                                        + "; " + rJA.data1.ToString() + " deg";
                                                }
                                                if (rJA.ack == 4) //No SX1503 IC   //2023-06-19
                                                {
                                                    richBox.AppendText("Device_9: No SX1503 IC" + "\r\n");
                                                    bTempSensorNgDvc9 = true;
                                                }
                                                //2023-06-17
                                                if (rJA.data1 > iBurnTempHigh)
                                                { bTempOver50Dvc9 = true; bTempUnder40Dvc9 = false; }
                                                else if (rJA.data1 <= iBurnTempHigh && rJA.data1 >= iBurnTempLow)
                                                { bTempOver50Dvc9 = false; bTempUnder40Dvc9 = false; }
                                                else if (rJA.data1 < iBurnTempLow)
                                                { bTempUnder40Dvc9 = true; }
                                                break;
                                            }
                                        //txtTempDvc0.Text = Convert.ToString(rJA.data1);
                                        //if (rJA.data1 >= 37.5)
                                        //{ richBox.AppendText/*MessageBox.Show*/("Temperature is over 37.5 degree 溫度已達37.5度\r\n"); }

                                        if (bTempRecording) //2023-06-29:For recording
                                        {
                                            strIdentifyByDevice();
                                            strTemp = rJA.data1.ToString(); 
                                            TemperatureRecording();
                                        }
                                        break;
                                    case "AT+MEMS?":
                                    case "AT+MEMS":
                                        cboSta0optDvc0.SelectedIndex = rJA.data1;
                                        //serialPort1.Close();
                                        break;
                                    case "AT+VER?":
                                    case "AT+STA?":
                                        if (b4Customer)    //2022-06-22 only for Customer, set Station<3-1> if it's not.
                                        {                                            
                                            if (/*rJA.id*/iStaId != 3)    //Set to sta_3 if it's not...
                                            {
                                                openport();
                                                serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                                                serialPort1.Write("AT+STA " + (3 + iDvcId * 16) + "\r\n");  //2022-07-19
                                                return;
                                            }
                                            if (strBisVal != "0")   //For customer to Set BIS=0, 2022-07-19
                                            { 
                                                openport();
                                                serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                                                serialPort1.Write("AT+BIS 0" + "\r\n"); 
                                            }
                                        }
                                        else   //2022-07-21
                                        {                                            
                                            if (iStaId != 3)    //For 1pcTo3jig：2022-09-15
                                            {
                                                richBox.AppendText( "不是燒機用的站別 " + iDvcId + "，需請工程師做設定\r\n");
                                                MessageBox.Show("有治具不是燒機的站別，需請工程師做設定");
                                            }
                                            if (iDvcId == 9)  //2022-11-15: Device_9
                                            {
                                                if (lblDevIdDvc9.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc9.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc9.Text = ""; cboComDvc9.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc9.Text = strComSerial1;
                                                        strDvc9Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc9Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc9.Text = strComSerial2;
                                                        strDvc9Com = strComSerial2;
                                                        Dvc9Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc9.Text = strComSerial3;
                                                        strDvc9Com = strComSerial3;
                                                        Dvc9Serial = serialPort3;
                                                    }

                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc9.Text = strComSerial4;
                                                        strDvc9Com = strComSerial4;
                                                        Dvc9Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc9.Text = strComSerial5;
                                                        strDvc9Com = strComSerial5;
                                                        Dvc9Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc9.Text = strComSerial6;
                                                        strDvc9Com = strComSerial6;
                                                        Dvc9Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc9.Text = strComSerial7;
                                                        strDvc9Com = strComSerial7;
                                                        Dvc9Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc9.Text = strComSerial8;
                                                        strDvc9Com = strComSerial8;
                                                        Dvc9Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc9.Text = strComSerial9;
                                                        strDvc9Com = strComSerial9;
                                                        Dvc9Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc9.Text = strComSerial10;
                                                        strDvc9Com = strComSerial10;
                                                        Dvc9Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc9.Text = strComInsert;
                                                        strDvc9Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_9 ComPort = " + strDvc9Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_9 ComPort = " + strDvc9Com );    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 8)  //2022-11-15: Device_8
                                            {
                                                if (lblDevIdDvc8.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc8.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc8.Text = ""; cboComDvc8.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc8.Text = strComSerial1;
                                                        strDvc8Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc8Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc8.Text = strComSerial2;
                                                        strDvc8Com = strComSerial2;
                                                        Dvc8Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc8.Text = strComSerial3;
                                                        strDvc8Com = strComSerial3;
                                                        Dvc8Serial = serialPort3;
                                                    }

                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc8.Text = strComSerial4;
                                                        strDvc8Com = strComSerial4;
                                                        Dvc8Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc8.Text = strComSerial5;
                                                        strDvc8Com = strComSerial5;
                                                        Dvc8Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc8.Text = strComSerial6;
                                                        strDvc8Com = strComSerial6;
                                                        Dvc8Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc8.Text = strComSerial7;
                                                        strDvc8Com = strComSerial7;
                                                        Dvc8Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc8.Text = strComSerial8;
                                                        strDvc8Com = strComSerial8;
                                                        Dvc8Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc8.Text = strComSerial9;
                                                        strDvc8Com = strComSerial9;
                                                        Dvc8Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc8.Text = strComSerial10;
                                                        strDvc8Com = strComSerial10;
                                                        Dvc8Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc8.Text = strComInsert;
                                                        strDvc8Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_8 ComPort = " + strDvc8Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_8 ComPort = " + strDvc8Com);    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 7)  //2022-11-15: Device_7
                                            {
                                                if (lblDevIdDvc7.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc7.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc7.Text = ""; cboComDvc7.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc7.Text = strComSerial1;
                                                        strDvc7Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc7Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc7.Text = strComSerial2;
                                                        strDvc7Com = strComSerial2;
                                                        Dvc7Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc7.Text = strComSerial3;
                                                        strDvc7Com = strComSerial3;
                                                        Dvc7Serial = serialPort3;
                                                    }

                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc7.Text = strComSerial4;
                                                        strDvc7Com = strComSerial4;
                                                        Dvc7Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc7.Text = strComSerial5;
                                                        strDvc7Com = strComSerial5;
                                                        Dvc7Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc7.Text = strComSerial6;
                                                        strDvc7Com = strComSerial6;
                                                        Dvc7Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc7.Text = strComSerial7;
                                                        strDvc7Com = strComSerial7;
                                                        Dvc7Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc7.Text = strComSerial8;
                                                        strDvc7Com = strComSerial8;
                                                        Dvc7Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc7.Text = strComSerial9;
                                                        strDvc7Com = strComSerial9;
                                                        Dvc7Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc7.Text = strComSerial10;
                                                        strDvc7Com = strComSerial10;
                                                        Dvc7Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc7.Text = strComInsert;
                                                        strDvc7Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_7 ComPort = " + strDvc7Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_7 ComPort = " + strDvc7Com);    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 6)  //2022-11-15: Device_6
                                            {
                                                if (lblDevIdDvc6.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc6.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc6.Text = ""; cboComDvc6.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc6.Text = strComSerial1;
                                                        strDvc6Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc6Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc6.Text = strComSerial2;
                                                        strDvc6Com = strComSerial2;
                                                        Dvc6Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc6.Text = strComSerial3;
                                                        strDvc6Com = strComSerial3;
                                                        Dvc6Serial = serialPort3;
                                                    }

                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc6.Text = strComSerial4;
                                                        strDvc6Com = strComSerial4;
                                                        Dvc6Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc6.Text = strComSerial5;
                                                        strDvc6Com = strComSerial5;
                                                        Dvc6Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc6.Text = strComSerial6;
                                                        strDvc6Com = strComSerial6;
                                                        Dvc6Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc6.Text = strComSerial7;
                                                        strDvc6Com = strComSerial7;
                                                        Dvc6Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc6.Text = strComSerial8;
                                                        strDvc6Com = strComSerial8;
                                                        Dvc6Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc6.Text = strComSerial9;
                                                        strDvc6Com = strComSerial9;
                                                        Dvc6Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc6.Text = strComSerial10;
                                                        strDvc6Com = strComSerial10;
                                                        Dvc6Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc6.Text = strComInsert;
                                                        strDvc6Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_6 ComPort = " + strDvc6Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_6 ComPort = " + strDvc6Com);    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 5)  //2022-11-15: Device_5
                                            {
                                                if (lblDevIdDvc5.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc5.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc5.Text = ""; cboComDvc5.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc5.Text = strComSerial1;
                                                        strDvc5Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc5Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc5.Text = strComSerial2;
                                                        strDvc5Com = strComSerial2;
                                                        Dvc5Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc5.Text = strComSerial3;
                                                        strDvc5Com = strComSerial3;
                                                        Dvc5Serial = serialPort3;
                                                    }

                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc5.Text = strComSerial4;
                                                        strDvc5Com = strComSerial4;
                                                        Dvc5Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc5.Text = strComSerial5;
                                                        strDvc5Com = strComSerial5;
                                                        Dvc5Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc5.Text = strComSerial6;
                                                        strDvc5Com = strComSerial6;
                                                        Dvc5Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc5.Text = strComSerial7;
                                                        strDvc5Com = strComSerial7;
                                                        Dvc5Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc5.Text = strComSerial8;
                                                        strDvc5Com = strComSerial8;
                                                        Dvc5Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc5.Text = strComSerial9;
                                                        strDvc5Com = strComSerial9;
                                                        Dvc5Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc5.Text = strComSerial10;
                                                        strDvc5Com = strComSerial10;
                                                        Dvc5Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc5.Text = strComInsert;
                                                        strDvc5Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_5 ComPort = " + strDvc5Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_5 ComPort = " + strDvc5Com);    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 4)  //2022-11-09: Device_4
                                            {
                                                if (lblDevIdDvc4.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc4.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc4.Text = ""; cboComDvc4.Items.Clear();
                                                    if (iAtVerCmdStep == 3)
                                                    {
                                                        cboComDvc4.Text = strComSerial1;
                                                        strDvc4Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc4Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc4.Text = strComSerial2;
                                                        strDvc4Com = strComSerial2;
                                                        Dvc4Serial = serialPort2;
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc4.Text = strComSerial3;
                                                        strDvc4Com = strComSerial3;
                                                        Dvc4Serial = serialPort3;
                                                    }
              #region
                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc4.Text = strComSerial4;
                                                        strDvc4Com = strComSerial4;
                                                        Dvc4Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc4.Text = strComSerial5;
                                                        strDvc4Com = strComSerial5;
                                                        Dvc4Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc4.Text = strComSerial6;
                                                        strDvc4Com = strComSerial6;
                                                        Dvc4Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc4.Text = strComSerial7;
                                                        strDvc4Com = strComSerial7;
                                                        Dvc4Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc4.Text = strComSerial8;
                                                        strDvc4Com = strComSerial8;
                                                        Dvc4Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc4.Text = strComSerial9;
                                                        strDvc4Com = strComSerial9;
                                                        Dvc4Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc4.Text = strComSerial10;
                                                        strDvc4Com = strComSerial10;
                                                        Dvc4Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc4.Text = strComInsert;
                                                        strDvc4Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_4 ComPort = " + strDvc4Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_4 ComPort = " + strDvc4Com);    //2025-07-25
                                                    #endregion
                                                }
                                            }
                                            else if (iDvcId == 3)  //2022-11-09: Device_3
                                            {
                                                if (lblDevIdDvc3.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc3.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc3.Text = ""; cboComDvc3.Items.Clear();
                                                    if (iAtVerCmdStep == 3) 
                                                    {
                                                        cboComDvc3.Text = strComSerial1;
                                                        strDvc3Com = strComSerial1;    //-->Remember the ComPort of Device
                                                        Dvc3Serial = serialPort1;   //-->Remember the serialPort of Device
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc3.Text = strComSerial2;
                                                        strDvc3Com = strComSerial2;   
                                                        Dvc3Serial = serialPort2; 
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc3.Text = strComSerial3;
                                                        strDvc3Com = strComSerial3;   
                                                        Dvc3Serial = serialPort3;  
                                                    }
                                                    //2022-11-16:Dvc3 strComSerial4~10
#region
                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc3.Text = strComSerial4;
                                                        strDvc3Com = strComSerial4;
                                                        Dvc3Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc3.Text = strComSerial5;
                                                        strDvc3Com = strComSerial5;
                                                        Dvc3Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc3.Text = strComSerial6;
                                                        strDvc3Com = strComSerial6;
                                                        Dvc3Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc3.Text = strComSerial7;
                                                        strDvc3Com = strComSerial7;
                                                        Dvc3Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc3.Text = strComSerial8;
                                                        strDvc3Com = strComSerial8;
                                                        Dvc3Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc3.Text = strComSerial9;
                                                        strDvc3Com = strComSerial9;
                                                        Dvc3Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc3.Text = strComSerial10;
                                                        strDvc3Com = strComSerial10;
                                                        Dvc3Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc3.Text = strComInsert;
                                                        strDvc3Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_3 ComPort = " + strDvc3Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_3 ComPort = " + strDvc3Com);    //2025-07-25
                                                    #endregion
                                                }
                                            }
                                            else if (iDvcId == 2)  //2022-08-08: Device_2
                                            {                                                
                                                if (lblDevIdDvc2.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc2.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc2.Text = ""; cboComDvc2.Items.Clear();
                                                    if (iAtVerCmdStep == 3)    //2022-08-10
                                                    {
                                                        cboComDvc2.Text = strComSerial1;
                                                        strDvc2Com = strComSerial1;    //2022-08-18 -->Remember the ComPort of Device2
                                                        Dvc2Serial = serialPort1;   //2022-08-18 -->Remember the serialPort of Device2
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc2.Text = strComSerial2;
                                                        strDvc2Com = strComSerial2;    //2022-08-18
                                                        Dvc2Serial = serialPort2;   //2022-08-18
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc2.Text = strComSerial3;
                                                        strDvc2Com = strComSerial3;    //2022-08-18
                                                        Dvc2Serial = serialPort3;   //2022-08-18
                                                    }
                                                    //2022-11-16:Dvc2-strComSerial4~10
#region
                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc2.Text = strComSerial4;
                                                        strDvc2Com = strComSerial4;
                                                        Dvc2Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc2.Text = strComSerial5;
                                                        strDvc2Com = strComSerial5;
                                                        Dvc2Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc2.Text = strComSerial6;
                                                        strDvc2Com = strComSerial6;
                                                        Dvc2Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc2.Text = strComSerial7;
                                                        strDvc2Com = strComSerial7;
                                                        Dvc2Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc2.Text = strComSerial8;
                                                        strDvc2Com = strComSerial8;
                                                        Dvc2Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc2.Text = strComSerial9;
                                                        strDvc2Com = strComSerial9;
                                                        Dvc2Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc2.Text = strComSerial10;
                                                        strDvc2Com = strComSerial10;
                                                        Dvc2Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc2.Text = strComInsert;
                                                        strDvc2Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_2 ComPort = " + strDvc2Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_2 ComPort = " + strDvc2Com);    //2025-07-25
                                                    #endregion
                                                }
                                            }
                                            else if (iDvcId == 1)    //Device_1
                                            {
                                                if (lblDevIdDvc1.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else
                                                {
                                                    lblDevIdDvc1.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc1.Text = ""; cboComDvc1.Items.Clear();
                                                    if (iAtVerCmdStep == 3)    //2022-08-10
                                                    {
                                                        cboComDvc1.Text = strComSerial1;
                                                        strDvc1Com = strComSerial1;    //2022-08-18 -->Remember the ComPort of Device1
                                                        Dvc1Serial = serialPort1;   //2022-08-18 -->Remember the serialPort of Device1
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc1.Text = strComSerial2;
                                                        strDvc1Com = strComSerial2;    //2022-08-18
                                                        Dvc1Serial = serialPort2;   //2022-08-18
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc1.Text = strComSerial3;
                                                        strDvc1Com = strComSerial3;    //2022-08-18
                                                        Dvc1Serial = serialPort3;   //2022-08-18
                                                    }
                                                    //2022-11-16:Dvc1-strComSerial4~10
                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc1.Text = strComSerial4;
                                                        strDvc1Com = strComSerial4;
                                                        Dvc1Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc1.Text = strComSerial5;
                                                        strDvc1Com = strComSerial5;
                                                        Dvc1Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc1.Text = strComSerial6;
                                                        strDvc1Com = strComSerial6;
                                                        Dvc1Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc1.Text = strComSerial7;
                                                        strDvc1Com = strComSerial7;
                                                        Dvc1Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc1.Text = strComSerial8;
                                                        strDvc1Com = strComSerial8;
                                                        Dvc1Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc1.Text = strComSerial9;
                                                        strDvc1Com = strComSerial9;
                                                        Dvc1Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc1.Text = strComSerial10;
                                                        strDvc1Com = strComSerial10;
                                                        Dvc1Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc1.Text = strComInsert;
                                                        strDvc1Com = strComInsert;
                                                        bDeviceArrival = false;
                                                    }
                                                    richBox.AppendText("Device_1 ComPort = " + strDvc1Com + ", ");    //2025-07-17
                                                    Console.WriteLine("Device_1 ComPort = " + strDvc1Com);    //2025-07-25
                                                }
                                            }
                                            else if (iDvcId == 0)    //Device_0
                                            {
                                                if (lblDevIdDvc0.Text != "" && !bEngineerCmdSend)   //2025-07-18
                                                {
                                                    MessageBox.Show("Device ID repeated.有重複的ID");
                                                }
                                                else 
                                                {
                                                    lblDevIdDvc0.Text = "Device_ID = " + iDvcId.ToString();
                                                    cboComDvc0.Text = ""; cboComDvc0.Items.Clear();
                                                    //this.tabControl1.TabPages[0].Text = "Device0";  //2022-09-13
                                                    if (iAtVerCmdStep == 3)    //2022-08-10
                                                    {
                                                        cboComDvc0.Text = strComSerial1;
                                                        strDvc0Com = strComSerial1;    //2022-08-18 -->Remember the ComPort of Device0
                                                        Dvc0Serial = serialPort1;   //2022-08-18 -->Remember the serialPort of Device0
                                                    }
                                                    if (iAtVerCmdStep == 13)
                                                    {
                                                        cboComDvc0.Text = strComSerial2;
                                                        strDvc0Com = strComSerial2;    //2022-08-18
                                                        Dvc0Serial = serialPort2;   //2022-08-18
                                                    }
                                                    if (iAtVerCmdStep == 23)
                                                    {
                                                        cboComDvc0.Text = strComSerial3;
                                                        strDvc0Com = strComSerial3;    //2022-08-18
                                                        Dvc0Serial = serialPort3;   //2022-08-18
                                                    }
                                                    //2022-11-16:Dvc0-strComSerial4~10
#region
                                                    if (iAtVerCmdStep == 33)
                                                    {
                                                        cboComDvc0.Text = strComSerial4;
                                                        strDvc0Com = strComSerial4;
                                                        Dvc0Serial = serialPort4;
                                                    }
                                                    if (iAtVerCmdStep == 43)
                                                    {
                                                        cboComDvc0.Text = strComSerial5;
                                                        strDvc0Com = strComSerial5;
                                                        Dvc0Serial = serialPort5;
                                                    }
                                                    if (iAtVerCmdStep == 53)
                                                    {
                                                        cboComDvc0.Text = strComSerial6;
                                                        strDvc0Com = strComSerial6;
                                                        Dvc0Serial = serialPort6;
                                                    }
                                                    if (iAtVerCmdStep == 63)
                                                    {
                                                        cboComDvc0.Text = strComSerial7;
                                                        strDvc0Com = strComSerial7;
                                                        Dvc0Serial = serialPort7;
                                                    }
                                                    if (iAtVerCmdStep == 73)
                                                    {
                                                        cboComDvc0.Text = strComSerial8;
                                                        strDvc0Com = strComSerial8;
                                                        Dvc0Serial = serialPort8;
                                                    }
                                                    if (iAtVerCmdStep == 83)
                                                    {
                                                        cboComDvc0.Text = strComSerial9;
                                                        strDvc0Com = strComSerial9;
                                                        Dvc0Serial = serialPort9;
                                                    }
                                                    if (iAtVerCmdStep == 93)
                                                    {
                                                        cboComDvc0.Text = strComSerial10;
                                                        strDvc0Com = strComSerial10;
                                                        Dvc0Serial = serialPort10;
                                                    }
                                                    if (bDeviceArrival)     //2025-07-18
                                                    {
                                                        cboComDvc0.Text = strComInsert;
                                                        strDvc0Com = strComInsert;
                                                        bDeviceArrival=false; 
                                                    }
                                                    richBox.AppendText("Device_0 ComPort = " + strDvc0Com + ", ");   //2025-07-17
                                                    Console.WriteLine("Device_0 ComPort = " + strDvc0Com);    //2025-07-25
                                                    #endregion
                                                }
                                            }

                                            bEngineerCmdSend = false;   //2025-07-18
                                            if (bAtVerSent) //2022-08-16
                                            { bAtVerSent = false;   bAtVerAns = true; }
                                        }

                                        switch (/*rJA.id*/iStaId)   //2022-07-01
                                        {
                                            case 0:
                                                radSta0Dvc0.Checked = true;
                                                btnMemsSetDvc0.Enabled = true; cboSta0optDvc0.Enabled = true;   btnMemsReadDvc0.Enabled = true;  //2022-5-30
                                                cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                                                //btnMemsRead_Click(null, null);   //2022-5-31
                                                btnTempReadDvc0.Visible = false; lblTempDvc0.Visible = false; txtTempDvc0.Visible = false;    //2022-06-13
                                                break;
                                            case 1:
                                                radSta1Dvc0.Checked = true;
                                                btnMemsSetDvc0.Enabled = false; cboSta0optDvc0.Enabled = false; btnMemsReadDvc0.Enabled = false;   //2022-05-30
                                                cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                                                btnTempReadDvc0.Visible = false; lblTempDvc0.Visible = false; txtTempDvc0.Visible = false;    //2022-06-13
                                                break;
                                            case 2:
                                                radSta2Dvc0.Checked = true;
                                                btnMemsSetDvc0.Enabled = false; cboSta0optDvc0.Enabled = false; btnMemsReadDvc0.Enabled = false;   //2022-05-26
                                                cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                                                btnBisRead_Click(null, null);   //2022-5-30
                                                btnTempReadDvc0.Visible = true; btnTempReadDvc0.Enabled = true; lblTempDvc0.Visible = true; txtTempDvc0.Visible = true;    //2022-06-13
                                                btnTestDvc0.Enabled = false;    //2022-06-17
                                                break;
                                            case 3:
                                                if (iDvcId == 0)    //2022-09-15
                                                { radSta3Dvc0.Checked = true; /*Dvc0Serial.Close();*/ }
                                                else if (iDvcId == 1)    //2022-09-15
                                                { radSta3Dvc1.Checked = true; /*Dvc1Serial.Close();*/ }
                                                else if (iDvcId == 2)    //2022-09-15
                                                { radSta3Dvc2.Checked = true; /*Dvc2Serial.Close();*/ }
                                                else if (iDvcId == 3)    //2022-11-09
                                                { radSta3Dvc3.Checked = true; /*Dvc3Serial.Close()*/; }
                                                else if (iDvcId == 4)    //2022-11-09
                                                { radSta3Dvc4.Checked = true; /*Dvc4Serial.Close();*/ }
                                                else if (iDvcId == 5)    //2022-11-09
                                                { radSta3Dvc5.Checked = true; /*Dvc5Serial.Close()*/; }
                                                else if (iDvcId == 6)    //2022-11-09
                                                { radSta3Dvc6.Checked = true; /*Dvc6Serial.Close();*/ }
                                                else if (iDvcId == 7)    //2022-11-09
                                                { radSta3Dvc7.Checked = true; /*Dvc7Serial.Close()*/; }
                                                else if (iDvcId == 8)    //2022-11-09
                                                { radSta3Dvc8.Checked = true; /*Dvc8Serial.Close();*/ }
                                                else if (iDvcId == 9)    //2022-11-09
                                                { radSta3Dvc9.Checked = true; /*Dvc9Serial.Close();*/ }
                                                btnMemsSetDvc0.Enabled = false; cboSta0optDvc0.Enabled = false; btnMemsReadDvc0.Enabled = false;   //2022-05-26
                                                cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                                                btnTempReadDvc0.Visible = false; lblTempDvc0.Visible = false; txtTempDvc0.Visible = false;    //2022-06-13                                               
                                                break;
                                            case 4:
                                                radSta4Dvc0.Checked = true;
                                                btnMemsSetDvc0.Enabled = false; cboSta0optDvc0.Enabled = false; btnMemsReadDvc0.Enabled = false;   //2022-05-26
                                                cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                                                btnTempReadDvc0.Visible = false; lblTempDvc0.Visible = false; txtTempDvc0.Visible = false;    //2022-06-13
                                                break;
                                            default:

                                                break;
                                        }
                                        if (/*rJA.id*/iStaId < 5)   //2022-07-01
                                        {
                                            if(!bBurn1hr || !bBurn1hrDvc1 || !bBurn1hrDvc2 || !bBurn1hrDvc3 || !bBurn1hrDvc4
                                                || !bBurn1hrDvc5 || !bBurn1hrDvc6 || !bBurn1hrDvc7 || !bBurn1hrDvc8 || !bBurn1hrDvc9)   //2022-11-15
                                            { 
                                                richBox.AppendText("Station " + /*rJA.id*/iStaId.ToString() + " connected." + "\r\n"); 
                                                Console.WriteLine("Device_" + iDvcId + "= Station " + /*rJA.id*/iStaId.ToString() + " connected."); //2025-07-25
                                            }

                                            cboStaSet.SelectedIndex = iStaId/*rJA.id*/; //2022-07-01
                                            //Console.WriteLine(cboDevNo.Items.IndexOf(iDvcId));  //2024-03-29
                                            Console.WriteLine("Device_" + iDvcId);    //2025-07-25
                                            if (cboDevNo.Items.IndexOf(iDvcId) < 0) //2024-03-29
                                            { cboDevNo.Items.Add(iDvcId); } //2022-11-08
                                            //cboDevNo.Text = iDvcId.ToString();   //2022-11-09 //remarked:2025-07-18
                                            if (!b4Customer)
                                            { 
                                                //richBox.AppendText("Device_ID = " + iDvcId.ToString() + "\r\n");    //2022-07-19
                                                //toolStripStatusLabel1.Text = "Device_ID = " + iDvcId.ToString()+ ", StationId = "+iStaId; //
                                            }
                                        }
                                        else 
                                        { richBox.AppendText("Station id error.\r\n"); }
                                        break;
                                    case "AT+CURR": //2023-06-17
                                        switch (iDvcId)
                                        {
                                            case 0:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc0 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc0 = false; }
                                                Console.WriteLine("Dvc0_CURR = " + rJA.data1);
                                                break;
                                            case 1:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc1 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc1 = false; }
                                                Console.WriteLine("Dvc1_CURR = " + rJA.data1);
                                                break;
                                            case 2:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc2 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc2 = false; }
                                                Console.WriteLine("Dvc2_CURR = " + rJA.data1);
                                                break;
                                            case 3:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc3 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc3 = false; }
                                                Console.WriteLine("Dvc3_CURR = " + rJA.data1);
                                                break;
                                            case 4:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc4 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc4 = false; }
                                                Console.WriteLine("Dvc4_CURR = " + rJA.data1);
                                                break;
                                            case 5:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc5 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc5 = false; }
                                                Console.WriteLine("Dvc5_CURR = " + rJA.data1);
                                                break;
                                            case 6:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc6 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc6 = false; }
                                                Console.WriteLine("Dvc2_CURR = " + rJA.data1);
                                                break;
                                            case 7:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc7 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc7 = false; }
                                                Console.WriteLine("Dvc7_CURR = " + rJA.data1);
                                                break;
                                            case 8:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc8 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc8 = false; }
                                                Console.WriteLine("Dvc8_CURR = " + rJA.data1);
                                                break;
                                            case 9:
                                                if (rJA.data1 == 0)
                                                { bSetCurr0Dvc9 = true; strCurr = "0 mA"; }
                                                else if (rJA.data1 == 146)
                                                { bSetCurr0Dvc9 = false; }
                                                Console.WriteLine("Dvc9_CURR = " + rJA.data1);
                                                break;
                                            default:
                                                break;
                                        }
                                        
                                        break;
                                    default:
                                        break;
                                }
                                if( rJA.cmd == "AT+VER?" ) //2023-06-30
                                {
                                    if (iDvcId == 0 && !bBurn1hr)    //2022-06-02
                                    { richBox.AppendText("Device_0, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 1 && !bBurn1hrDvc1)    //2022-09-08
                                    { richBox.AppendText("Device_1, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 2 && !bBurn1hrDvc2)    //2022-09-08
                                    { richBox.AppendText("Device_2, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 3 && !bBurn1hrDvc3)    //2022-11-15
                                    { richBox.AppendText("Device_3, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 4 && !bBurn1hrDvc4)    //2022-11-15
                                    { richBox.AppendText("Device_4, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 5 && !bBurn1hrDvc5)    //2022-11-15
                                    { richBox.AppendText("Device_5, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 6 && !bBurn1hrDvc6)    //2022-11-15
                                    { richBox.AppendText("Device_6, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 7 && !bBurn1hrDvc7)    //2022-11-15
                                    { richBox.AppendText("Device_7, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 8 && !bBurn1hrDvc8)    //2022-11-15
                                    { richBox.AppendText("Device_8, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                    else if (iDvcId == 9 && !bBurn1hrDvc9)    //2022-11-15
                                    { richBox.AppendText("Device_9, Jig F/W ver: " + rJA.data1.ToString() + "." + rJA.data2.ToString() + "\n"); }
                                }
                                

                                if (/*rJA.id*/iStaId != 3 && bTempReading == false && /*rJA.id*/iStaId != 0 /*&& rJA.id != 2*/)  //2022-06-01   //for Sta2 to close port:2022-06-24
                                {
                                    ///*serialPort1*/Dvc0Serial.Close();  //2022-09-08
                                    if (/*rJA.id*/iStaId != 2) //2022-07-01
                                    { btnTestDvc0.Enabled = true; btnTestDvc1.Enabled = true; btnTestDvc2.Enabled = true; }  //2022-09-08
                                }

                                if (/*rJA.id*/iStaId == 3)   //2022-07-01
                                {
                                    if(rJA.cmd == "AT+VER?" || rJA.cmd == "AT+STA?")
                                    { btnBurn1hrDvc0.Enabled = true; btnBurn1hrDvc1.Enabled = true; btnBurn1hrDvc2.Enabled = true; }                                    
                                }
                                else { btnBurn1hrDvc0.Enabled = false; btnBurn1hrDvc1.Enabled = false; btnBurn1hrDvc2.Enabled = false; }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        //richBox.AppendText(RecRawData); //2022-12-04
                        Console.WriteLine(RecRawData);  //2022-12-04
                        if (!bBurnFinished && !bBurn1hr)
                        {
                            //MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");    //Eric:2022-06-07
                        }
                        btnTestDvc0.Enabled = true;  //2022-05-16

                        if(bBurn1hr)
                        {
                            openport();
                            serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                            //serialPort1.Write("AT+BIT 0" + "\r\n"); //2022-06-08
                            btnBurn1hrDvc0.Enabled = true;  //2022-06-08
                            richBox.AppendText("請勿開啟報表，並等待MEMS展開測試完成後，再做下個測試。\r\n");   //2022-06-08
                        }
                    }

                }
                else
                {
                    //recDType = ReceDataType.DATA_MESSAGE;
                    RecRawData = aas.feedbackString(receData, len);
                    //richBox.AppendText(RecRawData);
                    Console.WriteLine(RecRawData);  //2022-12-04
                }

                //serialPort1.Close();    //2022-5-7                
            }
        }


        //接收数据, receive data
        private void dataReceived1(object sender, SerialDataReceivedEventArgs e)    //2022-12-04
        {
            if (serialPort1.IsOpen)
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort1.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort1.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");   //2022-06-07
                }
            }
            else
            {
                //serialPort1.Close();    //2022-06-01
            }
            abComPortBusyFlag[(int)eCPort.cPort0] = false;  //by Jay:2022-12-04
        }

        private void dataReceived2(object sender, SerialDataReceivedEventArgs e)    //2022-12-04
        {
            if (serialPort2.IsOpen)
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort2.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort2.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");   //2022-06-07
                }
            }
            else
            {
                //serialPort2.Close();    //2022-06-01
            }
            abComPortBusyFlag[(int)eCPort.cPort1] = false;  //by Jay:2022-12-04
        }

        private void dataReceived3(object sender, SerialDataReceivedEventArgs e)    //2022-12-04
        {
            if (serialPort3.IsOpen)
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort3.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort3.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");   //2022-06-07
                }
            }
            else
            {
                //serialPort3.Close();    //2022-06-01
            }
            abComPortBusyFlag[(int)eCPort.cPort2] = false;  //by Jay:2022-12-04
        }

        private void dataReceived4(object sender, SerialDataReceivedEventArgs e)    //2022-12-04
        {
            if (serialPort4.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort4.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort4.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?"); 
                }
            }
            else
            {
                //serialPort4.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort3] = false;  //by Jay:2022-12-04
        }

        private void dataReceived5(object sender, SerialDataReceivedEventArgs e)    //2022-12-04
        {
            if (serialPort5.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort5.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort5.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                //serialPort5.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort4] = false;  //by Jay:2022-12-04
        }

        private void dataReceived6(object sender, SerialDataReceivedEventArgs e)  //2022-12-04
        {
            if (serialPort6.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort6.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort6.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                //serialPort6.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort5] = false;  //by Jay:2022-12-04
        }

        private void dataReceived7(object sender, SerialDataReceivedEventArgs e)  //2022-12-04
        {
            if (serialPort7.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort7.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort7.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                serialPort7.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort6] = false;  //by Jay:2022-12-04
        }

        private void dataReceived8(object sender, SerialDataReceivedEventArgs e)  //2022-12-04
        {
            if (serialPort8.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort8.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort8.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                serialPort8.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort7] = false;  //by Jay:2022-12-04
        }

        private void dataReceived9(object sender, SerialDataReceivedEventArgs e)  //2022-12-04
        {
            if (serialPort9.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort9.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort9.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                serialPort9.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort8] = false;  //by Jay:2022-12-04
        }

        private void dataReceived10(object sender, SerialDataReceivedEventArgs e)  //2022-12-04
        {
            if (serialPort10.IsOpen) //2022-11-15
            {
                timerDelay1ms(500);  //（ms）等待一定時間，確保資料的完整性 int len =>50ms is too short
                try
                {
                    int len = serialPort10.BytesToRead;
                    if (len != 0)
                    {
                        char[] buff = new char[len];
                        serialPort10.Read(buff, 0, len);
                        uartDataParser(buff, len);
                    }
                }
                catch (System.Exception /*ex*/)
                {
                    Console.WriteLine("Baudrate error?");
                }
            }
            else
            {
                serialPort10.Close();
            }
            abComPortBusyFlag[(int)eCPort.cPort9] = false;  //by Jay:2022-12-04
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                //Console.WriteLine("ComPort.Length = " + COMPort.Length);    //2023-07-19
                if (T != len)   //if(len>T)=>New COM added, if(T>len)=>Certain COM removed
                {
                    List<string> names = ComPortNames("0416", "B1B2");  //E1Plus { VID, PID };  //Eric:2022-5-10

                    int i = COMPort.Length - 1; //2022-08-08
                    T = COMPort.Length;
                    cboComList.Text = "";
                    cboComList.Items.Clear();
                    cboComList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                    cboDevNo.Items.Clear(); //2022-11-22, avoid repeat cboDevNo
                    lblDevIdDvc0.Text = ""; lblDevIdDvc1.Text = ""; lblDevIdDvc2.Text = ""; //2022-09-19
                    lblDevIdDvc3.Text = ""; lblDevIdDvc4.Text = ""; lblDevIdDvc5.Text = ""; lblDevIdDvc6.Text = ""; //2022-11-21
                    lblDevIdDvc7.Text = ""; lblDevIdDvc8.Text = ""; lblDevIdDvc9.Text = ""; //2022-11-21
                    if ((i >= 0) && (names.Count > 0))  //Eric
                    {
                        foreach (String s in SerialPort.GetPortNames())
                        {
                            if (names.Contains(s))
                            {
                                cboComList.Text = s; // COMPort[i];
                                iDvcCnt = iDvcCnt + 1;    //2022-08-08
                                richBox.AppendText(cboComList.Text.ToString() + "  Connected.\r\n");  //Eric
                                strComSelected = cboComList.Text;    //Eric
                                len = COMPort.Length;
                                cboComList.BackColor = Color.White;
                                
                                if (iDvcCnt == 1)    //2022-08-16
                                {
                                    //cboComDvc0.Text = ""; cboComDvc0.Items.Clear();
                                    strComSerial1 = s; //2022-08-08                                    
                                }
                                if (iDvcCnt == 2)    //2022-08-16
                                {
                                    //cboComDvc1.Text = ""; cboComDvc1.Items.Clear();
                                    strComSerial2 = s; //2022-08-08
                                }
                                if (iDvcCnt == 3)    //2022-08-16
                                {
                                    //cboComDvc2.Text = ""; cboComDvc2.Items.Clear();
                                    strComSerial3 = s; //2022-08-08
                                }
                                if (iDvcCnt == 4)    //2022-11-09
                                {
                                    //cboComDvc3.Text = ""; cboComDvc3.Items.Clear();
                                    strComSerial4 = s;
                                }
                                if (iDvcCnt == 5)    //2022-11-09
                                {
                                    //cboComDvc4.Text = ""; cboComDvc4.Items.Clear();
                                    strComSerial5 = s;
                                }
                                //For Device_6~10:2022-11-15
#region                                
                                if (iDvcCnt == 6)
                                {
                                    //cboComDvc5.Text = ""; cboComDvc5.Items.Clear();
                                    strComSerial6 = s;
                                }
                                if (iDvcCnt == 7)
                                {
                                    //cboComDvc6.Text = ""; cboComDvc6.Items.Clear();
                                    strComSerial7 = s;
                                }
                                if (iDvcCnt == 8)
                                {
                                    //cboComDvc7.Text = ""; cboComDvc7.Items.Clear();
                                    strComSerial8 = s;
                                }
                                if (iDvcCnt == 9)
                                {
                                    //cboComDvc8.Text = ""; cboComDvc8.Items.Clear();
                                    strComSerial9 = s;
                                }
                                if (iDvcCnt == 10)
                                {
                                    //cboComDvc9.Text = ""; cboComDvc9.Items.Clear();
                                    strComSerial10 = s;
                                }
                                #endregion
                                /*strComSerial*/JigComSerial.Add(s);    //2023-10-19-->2025-07-17
                                Console.WriteLine("Insert ComPort = " + s);    //2023-10-19
                                //toolStripStatusLabel1.Text = "Insert ComPort = " + s;   //2025-07-08
                            }
                        }
                        timer15.Enabled = true; //2023-10-19
                    }
                    else
                    {
                        Console.WriteLine("Line 485...No com port or the right PID device connected.");    //just remark.
                        //richTxtFwResponse.AppendText(strComSelected/*cboCom.Text.ToString()*/ + "  disconnected.\r\n");  //Eric
                        //serialPort1.Close();    //2022-06-06
                    }
#if false   //2022-12-04
#region
                    if (cboComList.Text != strComSelected)
                    {
                        serialPort1.Close();    //2022-05-30
                        cboComDvc0.Text = "";   lblDevIdDvc0.Text = "Device_ID";   //2022-08-09
                        serialPort2.Close(); cboComDvc1.Text = ""; serialPort3.Close(); cboComDvc2.Text = "";    //2022-08-09
                        btnTestDvc0.Enabled = false;    //Eric
                        serialPort4.Close(); cboComDvc3.Text = ""; serialPort5.Close(); cboComDvc4.Text = "";   //2022-11-21
                        serialPort6.Close(); cboComDvc5.Text = ""; serialPort7.Close(); cboComDvc6.Text = "";   //2022-11-21
                        serialPort8.Close(); cboComDvc7.Text = ""; serialPort9.Close(); cboComDvc8.Text = "";   //2022-11-21
                        serialPort10.Close(); cboComDvc9.Text = "";  //2022-11-21
                        richBox.AppendText(strComSelected/*cboCom.Text.ToString()*/ + "  disconnected.\r\n");  //Eric
                    }
#endregion
#endif
                }
                else
                {
                    len = COMPort.Length;
                    //Console.WriteLine("Device count Number = " + lstComSerial.Count.ToString());    //2023-10-19
                    //AtVerAskQueue(false);    //2023-07-19
                }

            }
            catch (Exception /*ex*/)
            {
                lblFinalDvc0.Text = "";
                // ex.Message = 索引在陣列的界限之外。
                serialPort1.Dispose();
                serialPort1.Close();    //2022-05-30    //for sta3 close
            }            
            //BurnInQueue(); //2022-11-21
        }

        private void utilVerChk()    //2024-03-07
        {
            try
            {
                int k = 0;
                string[] COMPort = System.IO.Ports.SerialPort.GetPortNames();
                if (bDeviceArrival)   //2025-07-17 for New Com arrival in WndProc()
                { 
                    len = COMPort.Length; bDeviceArrival = false; 
                    return;
                }              
                Console.WriteLine("COMPort.count= " + COMPort.Count());
                foreach (String s in SerialPort.GetPortNames())    //2024-03-08:Check com ports connecting right now.
                { 
                    toolStripStatusLabel1.Text += s + " inserted. ";
                    Console.WriteLine("Insert ComPort = " + s);    //2025-07-16
                    strComConnect.Add(s);    //2024-03-11:for test
                    //Array.Resize(ref strComConnect, strComConnect.Count + 1);
                    //strComConnect[k] = s; k++;
                    //strComConnect.Append(s);
                }
                //Console.WriteLine("ComPorts all = "+strComConnect.Count); //Console.WriteLine(strComConnect[k-1].Length); 
                Console.WriteLine("ComPorts all = " + strComConnect.Count);
                //for (int i = 0; i < COMPort.Length; i++)    //2024-03-11：SerailPort(i+1)=strComSerial[i+1] for test
                //{ Console.WriteLine("SerialPort " + (i + 1) + " Insert ComPort = " + COMPort[i]); }

                if (T != len)   //if(len>T)=>New COM added, if(T>len)=>Certain COM removed
                {
                    //string strVID = "0416"; string strPID = "B1B2";
                    //List<string> names = ComPortNames(/*"0416"*/strVID, strPID/*"B1B2"*/);  //E1Plus { VID, PID };  //Eric:2022-5-10

                    int i = COMPort.Length - 1; //2022-08-08
                    T = COMPort.Length;
                    cboComList.Text = "";
                    cboComList.Items.Clear();
                    cboComList.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
                    cboDevNo.Items.Clear(); //2022-11-22, avoid repeat cboDevNo
                    lblDevIdDvc0.Text = ""; lblDevIdDvc1.Text = ""; lblDevIdDvc2.Text = ""; //2022-09-19
                    lblDevIdDvc3.Text = ""; lblDevIdDvc4.Text = ""; lblDevIdDvc5.Text = ""; lblDevIdDvc6.Text = ""; //2022-11-21
                    lblDevIdDvc7.Text = ""; lblDevIdDvc8.Text = ""; lblDevIdDvc9.Text = ""; //2022-11-21
                    if ((i >= 0) && (VidPidNames.Count > 0))  //Eric
                    {
                        foreach (String s in SerialPort.GetPortNames())    //逐一檢查連上的Com找到符合(Pid,Vid)的DeviceS
                        {
                            if (VidPidNames.Contains(s))
                            {
                                //cboComList.Text = s; // COMPort[i];   //2025-07-25
                                iDvcCnt = iDvcCnt + 1;    //2022-08-08
                                richBox.AppendText(/*cboComList.Text.ToString()*/s + "  Connected.\r\n");  //Eric
                                Console.WriteLine(/*boComList.Text.ToString()*/s + "  Connected.");
                                strComSelected = s; // cboComList.Text;    //Eric
                                len = COMPort.Length;
                                cboComList.BackColor = Color.White;

                                if (iDvcCnt == 1)    //2022-08-16
                                {
                                    //cboComDvc0.Text = ""; cboComDvc0.Items.Clear();
                                    strComSerial1 = s; //2022-08-08: serialPort1 now is connecting to Com "S",
                                    //strComConnect[iDvcCnt - 1] = s;    //2024-03-19
                                }
                                if (iDvcCnt == 2)    //2022-08-16
                                {
                                    //cboComDvc1.Text = ""; cboComDvc1.Items.Clear();
                                    strComSerial2 = s; //2022-08-08: serialPort2
                                    //strComConnect[iDvcCnt - 1] = s;    //2024-03-19
                                }
                                if (iDvcCnt == 3)    //2022-08-16
                                {
                                    //cboComDvc2.Text = ""; cboComDvc2.Items.Clear();
                                    strComSerial3 = s; //2022-08-08: serialPort3
                                }
                                if (iDvcCnt == 4)    //2022-11-09
                                {
                                    //cboComDvc3.Text = ""; cboComDvc3.Items.Clear();
                                    strComSerial4 = s;  //serialPort4
                                }
                                if (iDvcCnt == 5)    //2022-11-09
                                {
                                    //cboComDvc4.Text = ""; cboComDvc4.Items.Clear();
                                    strComSerial5 = s;  //serialPort5
                                }
                                //For Device_6~10:2022-11-15
                                #region                                
                                if (iDvcCnt == 6)
                                {
                                    //cboComDvc5.Text = ""; cboComDvc5.Items.Clear();
                                    strComSerial6 = s;  //serialPort6
                                }
                                if (iDvcCnt == 7)
                                {
                                    //cboComDvc6.Text = ""; cboComDvc6.Items.Clear();
                                    strComSerial7 = s;  //serialPort7
                                }
                                if (iDvcCnt == 8)
                                {
                                    //cboComDvc7.Text = ""; cboComDvc7.Items.Clear();
                                    strComSerial8 = s;  //serialPort8
                                }
                                if (iDvcCnt == 9)
                                {
                                    //cboComDvc8.Text = ""; cboComDvc8.Items.Clear();
                                    strComSerial9 = s;  //serialPort9
                                }
                                if (iDvcCnt == 10)
                                {
                                    //cboComDvc9.Text = ""; cboComDvc9.Items.Clear();
                                    strComSerial10 = s; //serialPort10
                                }
                                #endregion
                                JigComSerial/*strComSerial*/.Add(s);    //2023-10-19:List of Com when start app. -> 2024-03-11
                                Console.WriteLine("Insert Jig ComPort = " + s);    //2023-10-19
                                Console.WriteLine("Jig strComSerial" + iDvcCnt + " = " + s/*strComSerial[iDvcCnt - 1]*/);  //2024-03-13
                                //timer15.Enabled = true; //2024-03-21:AtVerCheck
                            }
                            //for (int j = 0; j < COMPort.Length; j++)    //2024-03-11：SerailPort(j+1)=strComSerial[j]
                            //{ Console.WriteLine("SerialPort " + (j + 1) + " Insert ComPort = " + s); }
                        }
                        Console.WriteLine("Insert Jig count = " + JigComSerial.Count);
                        timer15.Enabled = true; //2023-10-19:AtVerCheck
                    }
                    else
                    {
                        Console.WriteLine("Line 7046...No com port or the right PID device connected.");    //just remark.
                        //richTxtFwResponse.AppendText(strComSelected/*cboCom.Text.ToString()*/ + "  disconnected.\r\n");  //Eric
                        //serialPort1.Close();    //2022-06-06
                    }
#if false   //2022-12-04
#region
                    if (cboComList.Text != strComSelected)
                    {
                        serialPort1.Close();    //2022-05-30
                        cboComDvc0.Text = "";   lblDevIdDvc0.Text = "Device_ID";   //2022-08-09
                        serialPort2.Close(); cboComDvc1.Text = ""; serialPort3.Close(); cboComDvc2.Text = "";    //2022-08-09
                        btnTestDvc0.Enabled = false;    //Eric
                        serialPort4.Close(); cboComDvc3.Text = ""; serialPort5.Close(); cboComDvc4.Text = "";   //2022-11-21
                        serialPort6.Close(); cboComDvc5.Text = ""; serialPort7.Close(); cboComDvc6.Text = "";   //2022-11-21
                        serialPort8.Close(); cboComDvc7.Text = ""; serialPort9.Close(); cboComDvc8.Text = "";   //2022-11-21
                        serialPort10.Close(); cboComDvc9.Text = "";  //2022-11-21
                        richBox.AppendText(strComSelected/*cboCom.Text.ToString()*/ + "  disconnected.\r\n");  //Eric
                    }
#endregion
#endif
                }
                else
                {
                    len = COMPort.Length;
                    //Console.WriteLine("Device count Number = " + lstComSerial.Count.ToString());    //2023-10-19
                    //AtVerAskQueue(false);    //2023-07-19
                }

            }
            catch (Exception /*ex*/)
            {
                lblFinalDvc0.Text = "";
                // ex.Message = 索引在陣列的界限之外。
                serialPort1.Dispose();
                serialPort1.Close();    //2022-05-30    //for sta3 close
            }
            //BurnInQueue(); //2022-11-21
        }

        private void DvcRemovedUiRefresh(string port)    //2024-03-22：Refresh UI to add/remove COM/Dvc0_id... when insert or remove Device
        {
            if(strDvc0Com == port)    //2025-07-22:Device_0
            {
                cboComDvc0.Text = ""; cboComDvc0.Items.Clear(); lblDevIdDvc0.Text = ""; radSta3Dvc0.Checked = false;
                strDvc0Com = ""; Dvc0Serial.Close(); Dvc0Serial.Dispose();    //2025-07-22:Device_0
                richBox.AppendText("Device_0 removed.\r\n");
                cboDevNo.Items.Remove(iDvcId);    //2025-07-25
                Console.WriteLine(Dvc9Serial.ToString());   //2025-07-25
            }
            else if(strDvc1Com == port)   //2025-07-22:Device_1
            {
                cboComDvc1.Text = ""; cboComDvc1.Items.Clear(); lblDevIdDvc1.Text = ""; radSta3Dvc1.Checked = false;
                strDvc1Com = ""; Dvc1Serial.Close(); Dvc1Serial.Dispose();
                richBox.AppendText("Device_1 removed.\r\n");
            }
            else if (strDvc2Com == port)   //2025-07-22:Device_1
            {
                cboComDvc2.Text = ""; cboComDvc2.Items.Clear(); lblDevIdDvc2.Text = ""; radSta3Dvc2.Checked = false;
                strDvc2Com = ""; Dvc2Serial.Close(); Dvc2Serial.Dispose();
                richBox.AppendText("Device_2 removed.\r\n");
            }
            else if (strDvc3Com == port)   //2025-07-22:Device_1
            {
                cboComDvc3.Text = ""; cboComDvc3.Items.Clear(); lblDevIdDvc3.Text = ""; radSta3Dvc3.Checked = false;
                strDvc3Com = ""; Dvc3Serial.Close(); Dvc3Serial.Dispose();
                richBox.AppendText("Device_3 removed.\r\n");
            }
            else if (strDvc4Com == port)   //2025-07-22:Device_1
            {
                cboComDvc4.Text = ""; cboComDvc4.Items.Clear(); lblDevIdDvc4.Text = ""; radSta3Dvc4.Checked = false;
                strDvc4Com = ""; Dvc4Serial.Close(); Dvc4Serial.Dispose();
                richBox.AppendText("Device_4 removed.\r\n");
            }
            else if (strDvc5Com == port)   //2025-07-22:Device_1
            {
                cboComDvc5.Text = ""; cboComDvc5.Items.Clear(); lblDevIdDvc5.Text = ""; radSta3Dvc5.Checked = false;
                strDvc5Com = ""; Dvc5Serial.Close(); Dvc5Serial.Dispose();
                richBox.AppendText("Device_5 removed.\r\n");
            }
            else if (strDvc6Com == port)   //2025-07-22:Device_1
            {
                cboComDvc6.Text = ""; cboComDvc6.Items.Clear(); lblDevIdDvc6.Text = ""; radSta3Dvc6.Checked = false;
                strDvc6Com = ""; Dvc6Serial.Close(); Dvc6Serial.Dispose();
                richBox.AppendText("Device_6 removed.\r\n");
            }
            else if (strDvc7Com == port)   //2025-07-22:Device_1
            {
                cboComDvc7.Text = ""; cboComDvc7.Items.Clear(); lblDevIdDvc7.Text = ""; radSta3Dvc7.Checked = false;
                strDvc7Com = ""; Dvc7Serial.Close(); Dvc7Serial.Dispose();
                richBox.AppendText("Device_7 removed.\r\n");
            }
            else if (strDvc8Com == port)   //2025-07-22:Device_1
            {
                cboComDvc8.Text = ""; cboComDvc8.Items.Clear(); lblDevIdDvc8.Text = ""; radSta3Dvc8.Checked = false;
                strDvc8Com = ""; Dvc8Serial.Close(); Dvc8Serial.Dispose();
                richBox.AppendText("Device_8 removed.\r\n");
            }
            else if (strDvc9Com == port)   //2025-07-22:Device_1
            {
                cboDevNo.Items.Remove(iDvcId); cboCmdList.Items.Remove(strDvc9Com); //2025-07-25
                cboComDvc9.Text = ""; cboComDvc9.Items.Clear(); lblDevIdDvc9.Text = ""; radSta3Dvc9.Checked = false;
                strDvc9Com = ""; Dvc9Serial.Close(); Dvc9Serial.Dispose();
                richBox.AppendText("Device_9 removed.\r\n");
                //Console.WriteLine(Dvc9Serial.ToString());   //2025-07-25
            }
            cboCmdList.Text = ""; //2025-07-25
        }

        private void BurnInQueue()  //2022-11-21
        {
            int iBurnRetWait = 1;    //msec:2022-12-02
            System.Windows.Forms.Application.DoEvents();
            switch (iBurnInQueStep)
            {
                case 0:
                    if(!timer3.Enabled && !timer4.Enabled && !timer5.Enabled
                        && !timer6.Enabled && !timer7.Enabled && !timer8.Enabled
                        && !timer9.Enabled && !timer10.Enabled && !timer11.Enabled
                        && !timer12.Enabled)   //2022-11-29
                    { btnBurnAll.Enabled = true; }

                    if (bBurnInQueStart)
                    { iBurnInQueStep += 1; btnBurnAll.Enabled = false; }    //2022-11-28
                    break;
                case 1:
                    if (strDvc0Com != null)    //Device_0
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hr_Click(null, null);
                    }
                    else { iBurnInQueStep += 10; }
                    break ;
                case 2:
                    if(bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1s(iBurnRetWait);  //2022-11-23
                    }
                    else
                    { 
                        iBurnQueNoResponTick += 1;
                        if(iBurnQueNoResponTick>100)
                        {
                            richBox.AppendText("Device_0燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 11:
                    if (strDvc1Com != null)    //Device_1
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc1_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 12:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 100)
                        {
                            richBox.AppendText("Device_1燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 21:
                    if (strDvc2Com != null)    //Device_2
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc2_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 22:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 100)
                        {
                            richBox.AppendText("Device_2燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 31:
                    if (strDvc3Com != null)    //Device_3
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc3_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 32:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_3燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 41:
                    if (strDvc4Com != null)    //Device_4
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc4_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 42:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_4燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 51:
                    if (strDvc5Com != null)    //Device_5
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc5_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 52:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_5燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 61:
                    if (strDvc6Com != null)    //Device_6
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc6_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 62:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_6燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 71:
                    if (strDvc7Com != null)    //Device_7
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc7_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 72:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_7燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 81:
                    if (strDvc8Com != null)    //Device_8
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc8_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 82:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_8燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 91:
                    if (strDvc9Com != null)    //Device_9
                    {
                        iBurnInQueStep += 1;
                        btnBurn1hrDvc9_Click(null, null);   //2022-11-23(avoid report repeat open)
                        timerDelay1s(iBurnRetWait);  //2022-12-02
                    }
                    else { iBurnInQueStep += 10; }
                    break;
                case 92:
                    if (bBurnTestResponse)
                    {
                        bBurnTestResponse = false;
                        iBurnInQueStep += 9;
                        iBurnQueNoResponTick = 0;
                        timerDelay1ms(100);  //2022-11-23
                    }
                    else
                    {
                        iBurnQueNoResponTick += 1;
                        if (iBurnQueNoResponTick > 500)
                        {
                            richBox.AppendText("Device_9燒機前電測無回應？\r\n");
                            iBurnInQueStep += 9;
                            iBurnQueNoResponTick = 0;
                        }
                    }
                    break;
                case 101:
                    iBurnInQueStep = 0; bBurnInQueStart = false;
                    break;
            }
        }

        private void AtVerAskQueue(Boolean bExecute) //2023-07-19
        {
            if (!bExecute) { return; }  //2023-07-19
            System.Windows.Forms.Application.DoEvents();    //Application.DoEvents();   //2022-11-21
            switch (iAtVerCmdStep)
            {
                case 0:
                    if (iDvcCnt > 0) 
                    { iAtVerCmdStep = 1; }
                    break;
                case 1:
                    if (iDvcCnt >= 1) 
                    {
                        //if(IsOpenPort(serialPort1, strComSerial1))  //2022-11-09
                        //{
                            iAtVerCmdStep = 2;
                            OpenPort(serialPort1, strComSerial1);   //2022-12-02: Must before .DiscardInBuffer
                            serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                            serialPort1.Write("AT+VER?" + "\r\n");  //2023-06-30
                        //}
                        //else   //Jig no response
                        //{
                        //    //iDvcCnt = 0;
                        //    iAtVerCmdStep = 11;
                        //    /*MessageBox.Show*/
                        //    richBox.AppendText("治具無正確回應，請檢查usb/usb HUB連線是否正常；Jig do not response normally.\r\n");
                        //}
                    }
                    break;
                case 2:
                    iAtVerCmdStep += 1;
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;  /*bAtSentPort1=true;*/
                    break;
                case 3:
                    if(bAtVerAns)
                    {
                        iAtVerCmdStep = 11; // 5;
                        bAtVerAns=false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 11;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_1\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 5: //2022-08-29
                    if(!bAtBisSet)
                    {
                        //if (IsOpenPort(serialPort1, strComSerial1))  //2023-05-30
                        //{
                            iAtVerCmdStep = 7;
                        OpenPort(serialPort1, strComSerial1);
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                            serialPort1.Write("AT+BIS 0" + "\r\n");
                            bAtBisSet = true;
                        //}                            
                    }                    
                    break;
                case 7: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 11;
                    }
                    break;
                case 11:
                    if (iDvcCnt >= 2)
                    {
                        //if (IsOpenPort(serialPort2, strComSerial2))  //2023-02-18
                        //{
                            //timerDelay1ms(200);
                            iAtVerCmdStep = 12;
                        OpenPort(serialPort2, strComSerial2);
                        serialPort2.DiscardInBuffer(); serialPort2.DiscardOutBuffer();  //2022-12-04
                            serialPort2.Write("AT+VER?" + "\r\n");  //2023-06-30
                        //}
                        //else
                        //{ 
                        //    iAtVerCmdStep = 21;
                        //    richBox.AppendText("iDvcCnt_2 cannot be opened." + "\r\n");//2023-02-21
                        //}
                    }
                    else
                    { 
                        iAtVerCmdStep = 21;
                    }
                    break;                
                case 12:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true; /*bAtSentPort2 = true;*/
                    iAtVerCmdStep++;
                    break;
                case 13:                    
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 21; //15;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 21;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_2\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 15: //2022-08-29
                    if (!bAtBisSet)
                    {
                        if (IsOpenPort(serialPort2, strComSerial2))  //2023-02-18
                        {
                            iAtVerCmdStep = 17;
                            //OpenPort(serialPort2, strComSerial2);
                            serialPort2.DiscardInBuffer(); serialPort2.DiscardOutBuffer();  //2022-12-04
                            serialPort2.Write("AT+BIS 0" + "\r\n");
                            bAtBisSet = true;
                        }                            
                    }                        
                    break;
                case 17: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 21;
                    }
                    break;
                case 21:
                    if (iDvcCnt >= 3)
                    {
                        iAtVerCmdStep = 22;
                        OpenPort(serialPort3, strComSerial3);
                        serialPort3.DiscardInBuffer(); serialPort3.DiscardOutBuffer();  //2022-12-04
                        serialPort3.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    { 
                        iAtVerCmdStep = 99;                        
                    }
                    break;
                case 22:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true; /*bAtSentPort3 = true;*/
                    iAtVerCmdStep++;
                    break;
                case 23:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 31; //25;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 31;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_3\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 25: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 27;
                        OpenPort(serialPort3, strComSerial3);
                        serialPort3.DiscardInBuffer(); serialPort3.DiscardOutBuffer();  //2022-12-04
                        serialPort3.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 27: //2022-08-29
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 31; //90;   //2022-11-09
                    }
                    break;
                //2022-11-09:iDvcCnt = 4~5; serialPort4/5、strComSerial4/5
#region                 
                case 31:    //serialPort4
                    if (iDvcCnt >= 4)
                    {
                        iAtVerCmdStep = 32;
                        OpenPort(serialPort4, strComSerial4);
                        serialPort4.DiscardInBuffer(); serialPort4.DiscardOutBuffer();  //2022-12-04
                        serialPort4.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 32:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 33:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 41; // 35;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 41;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_4\r\n");
                   }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 35:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 37;
                        OpenPort(serialPort4, strComSerial4);
                        serialPort4.DiscardInBuffer(); serialPort4.DiscardOutBuffer();  //2022-12-04
                        serialPort4.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 37:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 41; //90;
                    }
                    break;
#endregion
#region
                case 41:    //serialPort5: 2022-11-09
                    if (iDvcCnt >= 5)
                    {
                        iAtVerCmdStep = 42;
                        OpenPort(serialPort5, strComSerial5);
                        serialPort5.DiscardInBuffer(); serialPort5.DiscardOutBuffer();  //2022-12-04
                        serialPort5.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 42:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 43:
                    if (bAtVerAns)
                    {
                        iAtVerCmdStep = 51; //45;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 51;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_5\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 45:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 47;
                        OpenPort(serialPort5, strComSerial5);
                        serialPort5.DiscardInBuffer(); serialPort5.DiscardOutBuffer();  //2022-12-04
                        serialPort5.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 47:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 51;
                    }
                    break;
#endregion

                //2022-11-15:iDvcCnt = 6~10; serialPort6~10、strComSerial6~10
#region
                case 51:    //serialPort6
                    if (iDvcCnt >= 6)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort6, strComSerial6);
                        serialPort6.DiscardInBuffer(); serialPort6.DiscardOutBuffer();  //2022-12-04
                        serialPort6.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 52:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 53:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 61;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 61;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_6\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 54:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort6, strComSerial6);
                        serialPort6.DiscardInBuffer(); serialPort6.DiscardOutBuffer();  //2022-12-04
                        serialPort6.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 55:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 61;
                    }
                    break;
#endregion
#region
                case 61:    //serialPort7
                    if (iDvcCnt >= 7)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort7, strComSerial7);
                        serialPort7.DiscardInBuffer(); serialPort7.DiscardOutBuffer();  //2022-12-04
                        serialPort7.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 62:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 63:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 71;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 71;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_7\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 64:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort7, strComSerial7);
                        serialPort7.DiscardInBuffer(); serialPort7.DiscardOutBuffer();  //2022-12-04
                        serialPort7.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 65:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 71;
                    }
                    break;
#endregion
#region
                case 71:    //serialPort8
                    if (iDvcCnt >= 8)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort8, strComSerial8);
                        serialPort8.DiscardInBuffer(); serialPort8.DiscardOutBuffer();  //2022-12-04
                        serialPort8.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 72:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 73:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 81;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 81;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_8\r\n");
                   }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 74:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort8, strComSerial8);
                        serialPort8.DiscardInBuffer(); serialPort8.DiscardOutBuffer();  //2022-12-04
                        serialPort8.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 75:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 81;
                    }
                    break;
#endregion
#region
                case 81:    //serialPort9
                    if (iDvcCnt >= 9)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort9, strComSerial9);
                        serialPort9.DiscardInBuffer(); serialPort9.DiscardOutBuffer();  //2022-12-04
                        serialPort9.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 82:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 83:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 91;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 91;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_9\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 84:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort9, strComSerial9);
                        serialPort9.DiscardInBuffer(); serialPort9.DiscardOutBuffer();  //2022-12-04
                        serialPort9.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 85:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 91;
                    }
                    break;
#endregion
#region
                case 91:    //serialPort10
                    if (iDvcCnt >= 10)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort10, strComSerial10);
                        serialPort10.DiscardInBuffer(); serialPort10.DiscardOutBuffer();  //2022-12-04
                        serialPort10.Write("AT+VER?" + "\r\n");  //2023-06-30
                    }
                    else
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
                case 92:
                    iWaitCount = iWaitTimerMs * iMsecCount;    //2023-02-18:5 min
                    bAtVerSent = true;
                    iAtVerCmdStep++;
                    break;
                case 93:
                    if (bAtVerAns)
                    {
                        //iAtVerCmdStep++;
                        iAtVerCmdStep = 99;
                        bAtVerAns = false;
                    }
                    else if (iWaitCount <= 0)
                    {
                        iAtVerCmdStep = 99;
                        bAtVerAns = false;
                        richBox.AppendText("治具無ver正確回應iDvcCnt_10\r\n");
                    }
                    else
                    {
                        iWaitCount -= 1;
                    }
                    break;
                case 94:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep++;
                        OpenPort(serialPort10, strComSerial10);
                        serialPort10.DiscardInBuffer(); serialPort10.DiscardOutBuffer();  //2022-12-04
                        serialPort10.Write("AT+BIS 0" + "\r\n");
                        bAtBisSet = true;
                    }
                    break;
                case 95:
                    if (!bAtBisSet)
                    {
                        iAtVerCmdStep = 99;
                    }
                    break;
#endregion

                case 99:    //2022-09-14
                    iAtVerCmdStep = 100;
                    break;
                case 100:                    
                    iAtVerCmdStep = 0;
                    iDvcCnt = 0;
                    break;
            }
            
        }

        private void richBox_TextChanged(object sender, EventArgs e)
        {
            richBox.SelectionStart = richBox.Text.Length;
            richBox.ScrollToCaret();
        }

        private void btnTest_Click(object sender, EventArgs e)  //buttonOpenport;   //2022-05-31
        {
            if (!StationCheck(0)) { return; }   //2023-02-15

            ChkFileExist(strFilePath); //2022-06-17
            ChkFileExist(strFileDailyPath); //2023-07-06
            //ControlBox = false;   //2022-06-30
            if (txtSnoDvc0.Text != "")     //2022-07-21
            {
                if (IsFileLocked(strFilePath))   //2022-06-17 =>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true;
                    return;
                }
            }

            lblFinalDvc0.Text = "";     //by Eric
            lblBurnRestDvc0.Text = "";  //2022-09-19
            if (iBurnStopStepDvc0 == 0)     //2023-08-11
            { txtTestRmkDvc0.Text = ""; }
            btnTestDvc0.Enabled = false; //2022-05-13
            btnBurn1hrDvc0.Enabled = false; //2022-06-09

            richBox.AppendText("Device_0...Testing..." + "\r\n");    //2022-09-13                
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            //OpenPort(Dvc0Serial, strDvc0Com);
            utilDvcxSerialWrite(eCPort.cPort0, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            if (IsOpenPort(Dvc0Serial, strDvc0Com)) //(IsOpenPort(serialPort1, strComSerial1))   //2022-08-18
            {
             utilDvcxSerialWrite(eCPort.cPort0, "AT+RET" + "\n\r");
                dts0 = DateTime.Now; //2023-02-15
                strDateTimeDvc0 = /*DateTime.Now*/dts0.ToString("yyyy-MM-dd HH:mm:ss"); //2023-02-15
                //Console.WriteLine(strDateTimeDvc0);    //2023-02-17
            }  //==> Sometimes no sending?
            else   //2022-11-21
            { MessageBox.Show("Dvc0:Test not finished for COM port " + strDvc0Com + " was not opened.\r\n"); }
            timerDelay1s(2);    //2023-06-27
            if (bBurnFinished)  //2022-06-17
            { 
                lblFinalDvc0.Text = "Burn-in Testing."; //2022-08-18                
            }
            //if (bBurn1hrDvc1)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }


        private void buttonClear_Click(object sender, EventArgs e)
        {
            /* Clear Button */
            richBox.Text = ""; tbxAtReturn.Text = "";
            txtSnoDvc0.Text = "";
            txtSnoDvc0.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)   //2022-5-7
        {
            tbxAtReturn.SelectionStart = tbxAtReturn.Text.Length;
            tbxAtReturn.ScrollToCaret();
        }

        private void cbocom_SelectedIndexChanged(object sender, EventArgs e)    //2022-5-9
        {
            //openport();
        }
        
        public static List<string> ComPortNames(String VID, String PID) //2022-5-9
        {   //Compile an array of COM port names associated with given VID and PID
            // 讀取PID和VID
            String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
            Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
            List<string> comports = new List<string>();
            RegistryKey rk1 = Registry.LocalMachine;
            RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
            foreach (String s3 in rk2.GetSubKeyNames())
            {
                RegistryKey rk3 = rk2.OpenSubKey(s3);
                foreach (String s in rk3.GetSubKeyNames())
                {
                    if (_rx.Match(s).Success)
                    {
                        RegistryKey rk4 = rk3.OpenSubKey(s);
                        foreach (String s2 in rk4.GetSubKeyNames())
                        {
                            RegistryKey rk5 = rk4.OpenSubKey(s2);
                            RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
                            if (rk6 != null)    //2023-03-30
                            { comports.Add((string)rk6.GetValue("PortName")); }                                
                            // 獲取port name，如有多個相同設備，加入comports array
                        }
                    }
                }
            }
            return comports;
        }

        private void barcode_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)    //if the enter key was pressed down
            //    btnTest_Click(sender, e); //trigger the botton click event
        }

        private void cboSta0opt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!/*serialPort1*/Dvc0Serial.IsOpen && cboComList.Text != "")
            {
                try
                {
                    /*serialPort1*/Dvc0Serial.PortName = cboComList.Text; ;   //by Eric
                    /*serialPort1*/Dvc0Serial.BaudRate = Convert.ToInt32(cboBaudDvc0.Text);   //by Eric
                    /*serialPort1*/Dvc0Serial.Open();
                }
                catch
                { MessageBox.Show("serialPort cannot be opened."); }
            }

            if (/*serialPort1*/Dvc0Serial.IsOpen && cboComList.Text != "")    //2022-05-19
            {
                try
                {
                    if (cboSta0optDvc0.Text == "0")
                    {
                        /*serialPort1*/Dvc0Serial.DiscardInBuffer(); Dvc0Serial.DiscardOutBuffer();  //2022-12-04                        
                        Dvc0Serial.Write("AT+MEMS 0" + "\r\n");
                        MessageBox.Show("Set to no_MEMS.設軟排為無MEMS");
                    }
                    else
                    {
                        Dvc0Serial.DiscardInBuffer(); Dvc0Serial.DiscardOutBuffer();  //2022-12-04
                        Dvc0Serial.Write("AT+MEMS 1" + "\r\n");
                        MessageBox.Show("Set to no_MEMS.設軟排有MEMS");
                    }

                }
                catch
                { MessageBox.Show("MEMS setting error."); }
            }
            else
            {
                MessageBox.Show("serailPort not opened.");
                /*serialPort1*/Dvc0Serial.Close();
            }
        }
        private void btnStationSet_Click(object sender, EventArgs e) //2022-11-07
        {
            int iStaDevSet = cboStaSet.SelectedIndex + (cboDevNo.SelectedIndex) * 16;    //2022-07-01

            if (iStaDevSet == (iStaId + iDvcId * 16))   //For write Device_ID only:2022-07-19
            { return; }
            
            switch (cboDevNo.Text)  //2022-11-07
            {
                case "0":
                    Dvc0Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort0, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-04
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station " 
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                case "1":
                    Dvc1Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort1, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-04
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                case "2":
                    Dvc2Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort2, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-04
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                    break;
                case "3":
                    Dvc3Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort3, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                    break;
                case "4":
                    Dvc4Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort4, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                case "5":
                    Dvc5Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort5, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;
                    break;
                case "6":
                    Dvc6Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort6, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;
                    break;
                case "7":
                    Dvc7Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort7, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;
                    break;
                case "8":
                    Dvc8Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort8, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;
                    break;
                case "9":
                    Dvc9Serial.Open();
                    utilDvcxSerialWrite(eCPort.cPort9, "AT+STA " + iStaDevSet + "\r\n");  //2022-12-05
                    MessageBox.Show("Set " + cboDevNo.SelectedIndex + " to Station "
                        + cboStaSet.SelectedIndex + ". 設定為站別 " + cboStaSet.SelectedIndex);
                    //cboBis.Enabled = false; btnBisSet.Enabled = false;
                    break;
                default:

                    break;
            }
        }

        private void cboStaSet_SelectedIndexChanged(object sender, EventArgs e) //2022-05-12
        {
#if false
#region
            btnTest.Enabled = false; //2022-05-13            
            openport();
            //serialPort1.DiscardInBuffer();  //2022-05-13    //Station3 will leave 2nd received data in buffer
            switch (cboStaSet.Text)
            {
                case "0":                    
                    serialPort1.Write("AT+STA 0" + "\r\n");
                    MessageBox.Show("Set to Station 0. 已設定為站別0");
                    cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                case "1":
                    serialPort1.Write("AT+STA 1" + "\r\n");
                    MessageBox.Show("Set to Station 1. 已設定為站別1");
                    cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                case "2":
                    serialPort1.Write("AT+STA 2" + "\r\n");
                    MessageBox.Show("Set to Station 2. 已設定為站別2");
                    cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                    break;
                case "3":
                    serialPort1.Write("AT+STA 3" + "\r\n");
                    MessageBox.Show("Set to Station 3. 已設定為站別3");
                    cboBis.Enabled = true; btnBisSet.Enabled = true;  //2022-05-26
                    break;
                case "4":
                    serialPort1.Write("AT+STA 4" + "\r\n");
                    MessageBox.Show("Set to Station 4. 已設定為站別4");
                    cboBis.Enabled = false; btnBisSet.Enabled = false;  //2022-05-26
                    break;
                default:

                    break;
            }
#endregion
#endif
        }

        private void btnMemsSet_Click(object sender, EventArgs e)
        {
            openport();
            //serialPort1.Write("AT+MEMS?" + "\r\n");
            if (serialPort1.IsOpen && cboComList.Text != "")    //2022-05-19
            {
                try
                {
                    if (cboSta0optDvc0.Text == "0")
                    {                        
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                        serialPort1.Write("AT+MEMS 0" + "\r\n");
                        MessageBox.Show("Set to no_MEMS.設軟排為無MEMS");
                    }
                    else
                    {
                        serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                        serialPort1.Write("AT+MEMS 1" + "\r\n");
                        MessageBox.Show("Set to no_MEMS.設軟排有MEMS");
                    }

                }
                catch
                { MessageBox.Show("MEMS setting error."); }
            }
            else
            {
                MessageBox.Show("serailPort not opened.");
                serialPort1.Close();
            }
        }

        private void btnCmdSend_Click(object sender, EventArgs e)
        {
            bEngineerCmdSend = true; //2025-07-18
            switch (cboDevNo.Text)   //2022-11-17    //(cboDevNo.SelectedIndex) //2022-08-24
            {
                case "0":
                    IsOpenPort(Dvc0Serial, strDvc0Com);
                    utilDvcxSerialWrite(eCPort.cPort0, cboCmdList.Text + "\r\n");
                    break;
                case "1":
                    IsOpenPort(Dvc1Serial, strDvc1Com);
                    utilDvcxSerialWrite(eCPort.cPort1, cboCmdList.Text + "\r\n");
                    break;
                case "2":
                    IsOpenPort(Dvc2Serial, strDvc2Com);
                    utilDvcxSerialWrite(eCPort.cPort2, cboCmdList.Text + "\r\n");
                    break;
                case "3":
                    IsOpenPort(Dvc3Serial, strDvc3Com);
                    utilDvcxSerialWrite(eCPort.cPort3, cboCmdList.Text + "\r\n");
                    break;
                case "4":
                    IsOpenPort(Dvc4Serial, strDvc4Com);
                    utilDvcxSerialWrite(eCPort.cPort4, cboCmdList.Text + "\r\n");
                    break;
                case "5":
                    IsOpenPort(Dvc5Serial, strDvc5Com);
                    utilDvcxSerialWrite(eCPort.cPort5, cboCmdList.Text + "\r\n");
                    break;
                case "6":
                    IsOpenPort(Dvc6Serial, strDvc6Com);
                    utilDvcxSerialWrite(eCPort.cPort6, cboCmdList.Text + "\r\n");
                    break;
                case "7":
                    IsOpenPort(Dvc7Serial, strDvc7Com);
                    utilDvcxSerialWrite(eCPort.cPort7, cboCmdList.Text + "\r\n");
                    break;
                case "8":
                    IsOpenPort(Dvc8Serial, strDvc8Com);
                    utilDvcxSerialWrite(eCPort.cPort8, cboCmdList.Text + "\r\n");
                    break;
                case "9":
                    IsOpenPort(Dvc9Serial, strDvc9Com);
                    utilDvcxSerialWrite(eCPort.cPort9, cboCmdList.Text + "\r\n");
                    break;
            }            
        }

        private void btnMemsRead_Click(object sender, EventArgs e)  //2022-05-23
        {
            openport();
            serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
            serialPort1.Write("AT+MEMS?" + "\r\n");
        }

        private void timer2_Tick(object sender, EventArgs e)    //2022-05-23
        {
            try
            {
                openport();                
                serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                serialPort1.Write("AT+TEMP?" + "\r\n");
                richBox.AppendText("溫度測試中；Temperature reading.\r\n");
            }
            catch 
            { 
                timer2.Enabled = false;
                serialPort1.Close();    //2022-11-21
                MessageBox.Show("Temperature read error.\r\n"); 
            }
        }

        private void cboDevNo_SelectedIndexChanged(object sender, EventArgs e)  //2022-11-07
        {
            try
            {
                switch (cboDevNo.Text)  //2022-11-08
                {
                    case "0":
                        cboComList.Text = strDvc0Com;   //Dvc0Serial.PortName;
                        break;
                    case "1":
                        cboComList.Text = strDvc1Com;   //Dvc1Serial.PortName;
                        break;
                    case "2":
                        cboComList.Text = strDvc2Com;   //Dvc2Serial.PortName;
                        break;
                    case "3":   //2022-11-15
                        cboComList.Text = strDvc3Com;   //Dvc3Serial.PortName;
                        break;
                    case "4":   //2022-11-15
                        cboComList.Text = strDvc4Com;   //Dvc4Serial.PortName;
                        break;
                    case "5":   //2022-11-15
                        cboComList.Text = strDvc5Com;   //Dvc5Serial.PortName;
                        break;
                    case "6":   //2022-11-15
                        cboComList.Text = strDvc6Com;   //Dvc6Serial.PortName;
                        break;
                    case "7":   //2022-11-15
                        cboComList.Text = strDvc7Com;   //Dvc7Serial.PortName;
                        break;
                    case "8":   //2022-11-15
                        cboComList.Text = strDvc8Com;   //Dvc8Serial.PortName;
                        break;
                    case "9":   //2022-11-15
                        cboComList.Text = strDvc9Com;   //Dvc9Serial.PortName;
                        break;
                    default:
                        cboComList.Text = "";    //2024-03-29
                        break;
                }            
            }
            catch { }
        }

        private void btnBurnStopDvc2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要中斷 Device_2燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc2.Enabled = false;
                richBox.AppendText("interrupting...Device_2燒機提早停止，請稍候...\r\n");
                //OpenPort(Dvc2Serial, strDvc2Com);
                //Dvc2Serial.Write("AT+BIS 0" + "\r\n"); 
                //timerDelay1ms(500);

                bBurnStopDvc2 = true;
                //MessageBox.Show("Device_2提早結束燒機，請再等候約30sec結束測試，不要立刻關閉電源與程式，請注意紀錄的時間非原預訂的燒機時間");
            }
        }

        private void timer4_Tick(object sender, EventArgs e)    //2023-06-26:Device 1 Burn-in，For use with Fixture Board V1.0 FW v1.5/v1.6
        {
            dtBurnTimeDvc1 = DateTime.Now;
            TimeSpan tsBurnDvc1 = new TimeSpan(dtBurnTimeDvc1.Ticks - dtBurnStartDvc1.Ticks);
            int iBurnTimeDvc1 = Convert.ToInt32(Math.Floor(tsBurnDvc1.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();
            
            switch (iBurnStopStepDvc1)
            {
                case 0:
                    lblBurnRestDvc1.Visible = true;
                    btnBurnStopDvc1.Visible = true;
                    btnBurnStopDvc1.Enabled = true;
                    iBurnStopStepDvc1 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc1.Enabled = false;
                    iBurnStopStepDvc1 += 1;
                    txtTestRmkDvc1.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc1 += 1;
                    utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc1 += 1;
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc1.Text = "Before Burn-in";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc1 += 1;
                        bBurn1hrDvc1 = true;    //starting burn-in
                        bBurnFinishedDvc1 = false;                        
                        btnTestDvc1_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc1)
                    {
                        bAtComReceivDvc1 = false;
                        iBurnStopStepDvc1 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_1 Burn-in 1hr Start.");
                        lblFinalDvc1.Text = "Burn-in Testing..."; lblFinalDvc1.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc1Serial, strDvc1Com))    //2023-02-16
                    {
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc1 += 1;
                    break;
                case 11:                     
                    //2023-06-19
                    if (!bTempSensorNgDvc1) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort1, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc1 && !bWaitCoolDvc1)
                    {
                        //IsOpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc1 = 12;
                    }
                    else if (bTempUnder40Dvc1 && bWaitCoolDvc1)
                    {
                        //IsOpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc1 = 13;
                    }

                    if (iBurnTimeDvc1 > iBurnMin || bBurnStopDvc1)  //2022-09-19
                    {
                        bBurnFinishedDvc1 = true;
                        //OpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc1 = 20;
                        bBurnStopDvc1 = false;  //2022-09-08
                        richBox.AppendText("Device_1 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc1.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc1).ToString() + "分鐘"; } //2022-12-01
                    break;

                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc1)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc1 = 11; bWaitCoolDvc1 = true;
                        richBox.AppendText("Device_1 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc1) //CURR has been set to 146
                    {
                        iBurnStopStepDvc1 = 11; bWaitCoolDvc1 = false;
                        richBox.AppendText("Device_1 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc1++;
                        if (iIntevalCntDvc1 >= iTempWatchInterval * (1000 / timer4.Interval)) 
                        {
                            iIntevalCntDvc1 = 0;
                            utilDvcxSerialWrite(eCPort.cPort1, "AT+TEMP?" + "\r\n");
                        }                         
                    }
                    //if ((iBurnTimeDvc1 > iTempChkTime) && !bTempChkInBurnDvc1)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc1Serial, strDvc1Com);
                    //    utilDvcxSerialWrite(eCPort.cPort1, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc1 = true;
                    //}                  
                    if (iBurnTimeDvc1 > iBurnMin || bBurnStopDvc1)  //2022-09-19
                    {
                        bBurnFinishedDvc1 = true;
                        //OpenPort(Dvc1Serial, strDvc1Com);
                        utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc1 = 20;
                        bBurnStopDvc1 = false;  //2022-09-08
                        richBox.AppendText("Device_1 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc1.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc1).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc1 += 1;
                    txtTestRmkDvc1.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc1 = 30;
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc1.Visible = false;
                    //txtTestRmkDvc1.Text = "After Burn-in";
                    btnTestDvc1_Click(this, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc1Stay = 0;  //2022-11-30
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc1);    //2023-02-17
                    if (bAtComReceivDvc1/*!bBurnAll2ndTesting*/)
                    {
                        iBurnStopStepDvc1 += 1;
                        bAtComReceivDvc1 = false;   //2023-06-26
                    }
                    else if (iBurnStopStepDvc1Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc1Stay = 0;
                        richBox.AppendText("Device_1 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc1 += 1;
                    }
                    else
                    { iBurnStopStepDvc1Stay += 1; }

                    break;
                case 31:
                    if (txtSnoDvc1.Text == "") //2023-06-30
                    { iBurnStopStepDvc1 = 100; }
                    else
                    { iBurnStopStepDvc1 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc1 = 100;
                    break;

                case 100:
                    timer4.Enabled = false;
                    iBurnStopStepDvc1 = 0;
                    Console.WriteLine("Device_1:Burn-in finished:@timer14");
                    btnTestDvc1.Enabled = true;
                    btnBurn1hrDvc1.Enabled = true;
                    bTempChkInBurnDvc1 = false;
                    //txtSnoDvc1.Text = "";
                    //txtTestRmkDvc1.Text = "";   //2023-06-28
                    richBox.AppendText("Device_1:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc1.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)    //2022-09-06
        {
            dtBurnTimeDvc2 = DateTime.Now;  //2022-08-29
            TimeSpan tsBurnDvc2 = new TimeSpan(dtBurnTimeDvc2.Ticks - dtBurnStartDvc2.Ticks);   //2022-08-30
            int iBurnTimeDvc2 = Convert.ToInt32(Math.Floor(tsBurnDvc2.TotalSeconds) / 60);    //2022-11-16
            System.Windows.Forms.Application.DoEvents();    //2023-06-21

            switch (iBurnStopStepDvc2)  //2022-09-06
            {
                case 0:
                    lblBurnRestDvc2.Visible = true; //2022-09-16
                    btnBurnStopDvc2.Visible = true; //2022-09-16
                    btnBurnStopDvc2.Enabled = true; //2022-09-16
                    iBurnStopStepDvc2 += 1; //2023-02-16
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc2.Enabled = false;
                    iBurnStopStepDvc2 += 1;
                    txtTestRmkDvc2.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc2 += 1;
                    utilDvcxSerialWrite(eCPort.cPort2, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc2 += 1;
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    txtTestRmkDvc2.Text = "Before Burn-in" + "\r\n";
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc2 += 1;
                        bBurn1hrDvc2 = true;    //starting burn-in
                        bBurnFinishedDvc2 = false;
                        btnTestDvc2_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc2)
                    {
                        bAtComReceivDvc2 = false;
                        iBurnStopStepDvc2 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_2 Burn-in 1hr Start.");
                        lblFinalDvc2.Text = "Burn-in Testing..."; lblFinalDvc2.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:
                    if (IsOpenPort(Dvc2Serial, strDvc2Com))
                    {
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc2 += 1;
                    break;
                case 11:
                    if (!bTempSensorNgDvc2) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort2, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc2 && !bWaitCoolDvc2)
                    {
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc2 = 12;
                    }
                    else if (bTempUnder40Dvc2 && bWaitCoolDvc2)
                    {
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc2 = 13;
                    }

                    if (iBurnTimeDvc2 > iBurnMin || bBurnStopDvc2)  //2022-09-19
                    {
                        bBurnFinishedDvc2 = true;
                        //OpenPort(Dvc2Serial, strDvc2Com);
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc2 = 20;
                        bBurnStopDvc2 = false;  //2022-09-08
                        richBox.AppendText("Device_2 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc2.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc2).ToString() + "分鐘"; } //2022-12-01
                    break;

                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc2)  //CURR has been set to 0
                    { 
                        iBurnStopStepDvc2 = 11; bWaitCoolDvc2 = true;
                        richBox.AppendText("Device_2 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc2) //CURR has been set to 146
                    { 
                        iBurnStopStepDvc2 = 11; bWaitCoolDvc2 = false;
                        richBox.AppendText("Device_2 Laser opening.\r\n");
                    }
                    break;
                #endregion

                case 19:    //2023-06-28: For FW v1.8
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc2++;
                        if (iIntevalCntDvc2 >= iTempWatchInterval * (1000 / timer5.Interval))
                        {
                            iIntevalCntDvc2 = 0;
                            utilDvcxSerialWrite(eCPort.cPort2, "AT+TEMP?" + "\r\n");
                        }                        
                    }
                    //if ((iBurnTimeDvc2 > iTempChkTime) && !bTempChkInBurnDvc2)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc2Serial, strDvc2Com);
                    //    utilDvcxSerialWrite(eCPort.cPort2, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc2 = true;
                    //}
                    if (iBurnTimeDvc2 > iBurnMin || bBurnStopDvc2)  //2022-09-19
                    {
                        bBurnFinishedDvc2 = true;
                        //OpenPort(Dvc2Serial, strDvc2Com);
                        utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc2 = 20;
                        bBurnStopDvc2 = false;  //2022-09-08
                        richBox.AppendText("Device_2 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc2.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc2).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc2 += 1;
                    txtTestRmkDvc2.Text = "After Burn-in";
                    break;
                case 21:
                    bBurnAll2ndTesting = true;  //2022-11-30
                    iBurnStopStepDvc2 = 30;
                    btnBurnStopDvc2.Visible = false;
                    //txtTestRmkDvc2.Text = "After Burn-in";   //2023-06-17
                    btnTestDvc2_Click(null, null); 
                    //utilDvcxSerialWrite(eCPort.cPort2, "AT+RET" + "\r\n");  //2022-12-04
                    iBurnStopStepDvc2Stay = 0;  //2022-11-30                    
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc2);    //2023-02-17
                    if (bAtComReceivDvc2) 
                    {
                        bAtComReceivDvc2 = false;
                        iBurnStopStepDvc2 += 1;
                    }
                    else if (iBurnStopStepDvc2Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc2Stay = 0;
                        richBox.AppendText("Device_2 燒機後電測無回應結果-2？\r\n");
                        iBurnStopStepDvc2 += 1;
                    }
                    else
                    { iBurnStopStepDvc2Stay += 1; }                    
                    break;
                case 31:
                    if (txtSnoDvc2.Text == "") //2023-06-30
                    { iBurnStopStepDvc2 = 100; }
                    else
                    { iBurnStopStepDvc2 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc2 = 100;
                    break;

                case 100:
                    timer5.Enabled = false;
                    Console.WriteLine("Device_2:Burn-in finished:@timer5");
                    btnTestDvc2.Enabled = true; //2022-09-23
                    btnBurn1hrDvc2.Enabled = true;  //2022-09-23
                    iBurnStopStepDvc2 = 0;                                     
                    bTempChkInBurnDvc2 = false; //2023-02-21
                    //txtSnoDvc2.Text = "";   //2023-06-15
                    //txtTestRmkDvc2.Text = "";   //2023-06-28
                    richBox.AppendText("Device_2:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc2.Text = "燒機結束";  //2023-06-29
                    break;
            }
        }

        private void btnBurnStopDvc1_Click(object sender, EventArgs e)  //2022-08-31
        {
            if (MessageBox.Show("確定要中斷 Device_1燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc1.Enabled = false;  
                richBox.AppendText("interrupting...Device_1燒機提早停止，請稍候...\r\n");
                //OpenPort(Dvc1Serial, strDvc1Com);  //openport();
                //Dvc1Serial.Write("AT+BIS 0" + "\r\n"); 
                //timerDelay1ms(500);

                bBurnStopDvc1 = true; 
                //MessageBox.Show("Device_1提早結束燒機，請再等候約30sec結束測試，不要立刻關閉電源與程式，請注意紀錄的時間非原預訂的燒機時間");
            }
        }

        private void btnTempRead_Click(object sender, EventArgs e)  //2022-05-24
        {
            if(bTempReading==false)
            {
                timer2.Enabled = true;
                bTempReading = true;
                btnTempReadDvc0.Text = "Stop";
            }
            else
            {
                timer2.Enabled = false;
                bTempReading = false;
                btnTempReadDvc0.Text = "Start";
                txtTempDvc0.Text = "<temp(C)>";
                richBox.AppendText("溫度測試結束；Stop reading temperature.\r\n");
                serialPort1.Close();    //2022-05-30
            }
        }

        private void btnBisSet_Click(object sender, EventArgs e)    //2022-05-26
        {
            switch (cboDevNo.Text/*SelectedIndex*/)  //2022-11-14
            {
                case "0":
                    IsOpenPort(Dvc0Serial, strDvc0Com);
                    utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "1":
                    IsOpenPort(Dvc1Serial, strDvc1Com);
                    utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "2":
                    IsOpenPort(Dvc2Serial, strDvc2Com);
                    utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "3":
                    IsOpenPort(Dvc3Serial, strDvc3Com);
                    utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "4":
                    IsOpenPort(Dvc4Serial, strDvc4Com);
                    utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "5":
                    IsOpenPort(Dvc5Serial, strDvc5Com);
                    utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "6":
                    IsOpenPort(Dvc6Serial, strDvc6Com);
                    utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "7":
                    IsOpenPort(Dvc7Serial, strDvc7Com);
                    utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "8":
                    IsOpenPort(Dvc8Serial, strDvc8Com);
                    utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
                case "9":
                    IsOpenPort(Dvc9Serial, strDvc9Com);
                    utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS " + cboBis.Text + "\r\n");
                    break;
            }
            //serialPort1.Write("AT+BIS " + cboBis.Text + "\r\n");
        }

        private void btnBurn1hrDvc2_Click(object sender, EventArgs e)   //2022-09-06
        {
            /*
            if (!StationCheck(2)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            if (txtSnoDvc2.Text != "")
            {
                if (IsFileLocked(strFilePath))
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc2.Enabled = true; btnBurn1hrDvc2.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");    //2022-09-13
            btnBurn1hrDvc2.Enabled = false;
            txtTestRmkDvc2.Text = "";   //2023-06-19
            //if (IsOpenPort(Dvc2Serial, strDvc2Com))    //2022-11-28
            //{
            //    utilDvcxSerialWrite(eCPort.cPort2, "AT+BIT " + (iBurnMin) + "\r\n");
            //}     //burn-in setting    
            //timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc2Serial, strDvc2Com);  //2022-10-31
            utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc2 = true;    //
            bBurnFinishedDvc2 = false;  //
            //ControlBox = false;
            txtTestRmkDvc2.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc2_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21
            Console.WriteLine("Device_2 Burn-in 1hr Start.");
            lblFinalDvc2.Text = "Burn-in Testing..."; lblFinalDvc2.ForeColor = Color.Red;
            */
            timer5.Enabled = true; iBurnStopStepDvc2 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc2 = DateTime.Now;
            //txtTestRmkDvc2.Text = "";   //2023-02-15
            bTempSensorNgDvc2 = false;  //2023-06-19
        }

        private void btnBisRead_Click(object sender, EventArgs e)   //2022-11-14
        {
            switch(cboDevNo.Text/*SelectedIndex*/)  //2022-11-14
            {
                case "0": //0:
                    IsOpenPort(Dvc0Serial, strDvc0Com);
                    utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS?" + "\r\n");
                    break;
                case "1": //1:
                    IsOpenPort(Dvc1Serial, strDvc1Com);
                    utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS?" + "\r\n");
                    break;
                case "2": //2:
                    IsOpenPort(Dvc2Serial, strDvc2Com);
                    utilDvcxSerialWrite(eCPort.cPort2, "AT+BIS?" + "\r\n");
                    break;
                case "3": //3: //2022-11-14
                    IsOpenPort(Dvc3Serial, strDvc3Com);
                    utilDvcxSerialWrite(eCPort.cPort3, "AT+BIS?" + "\r\n");
                    break;
                case "4": //4: //2022-11-14
                    IsOpenPort(Dvc4Serial, strDvc4Com);
                    utilDvcxSerialWrite(eCPort.cPort4, "AT+BIS?" + "\r\n");
                    break;
                case "5": //2022-11-22
                    IsOpenPort(Dvc5Serial, strDvc5Com);
                    utilDvcxSerialWrite(eCPort.cPort5, "AT+BIS?" + "\r\n");
                    break;
                case "6": //2022-11-22
                    IsOpenPort(Dvc6Serial, strDvc6Com);
                    utilDvcxSerialWrite(eCPort.cPort6, "AT+BIS?" + "\r\n");
                    break;
                case "7": //2022-11-22
                    IsOpenPort(Dvc7Serial, strDvc7Com);
                    utilDvcxSerialWrite(eCPort.cPort7, "AT+BIS?" + "\r\n");
                    break;
                case "8": //2022-11-22
                    IsOpenPort(Dvc8Serial, strDvc8Com);
                    utilDvcxSerialWrite(eCPort.cPort8, "AT+BIS?" + "\r\n");
                    break;
                case "9": //2022-11-22
                    IsOpenPort(Dvc9Serial, strDvc9Com);
                    utilDvcxSerialWrite(eCPort.cPort9, "AT+BIS?" + "\r\n");
                    break;
            }

            if (iAtVerCmdStep == 0)  //2022-11-14
            { 
                if(cboComList.Text== strComSerial1) 
                { 
                    OpenPort(serialPort1, cboComList.Text); timerDelay1ms(100);
                    serialPort1.DiscardInBuffer(); serialPort1.DiscardOutBuffer();  //2022-12-04
                    serialPort1.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial2) 
                { 
                    OpenPort(serialPort2, cboComList.Text); timerDelay1ms(100);
                    serialPort2.DiscardInBuffer(); serialPort2.DiscardOutBuffer();  //2022-12-04
                    serialPort2.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial3) 
                { 
                    OpenPort(serialPort3, cboComList.Text); timerDelay1ms(100);
                    serialPort3.DiscardInBuffer(); serialPort3.DiscardOutBuffer();  //2022-12-04
                    serialPort3.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial4)  //2022-11-14
                { 
                    OpenPort(serialPort4, cboComList.Text); timerDelay1ms(100);
                    serialPort4.DiscardInBuffer(); serialPort4.DiscardOutBuffer();  //2022-12-04
                    serialPort4.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial5)  //2022-11-14
                { 
                    OpenPort(serialPort5, cboComList.Text); timerDelay1ms(100);
                    serialPort5.DiscardInBuffer(); serialPort5.DiscardOutBuffer();  //2022-12-04
                    serialPort5.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial6)  //2022-11-22
                { 
                    OpenPort(serialPort6, cboComList.Text); timerDelay1ms(100);
                    serialPort6.DiscardInBuffer(); serialPort6.DiscardOutBuffer();  //2022-12-04
                    serialPort6.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial7)  //2022-11-22
                { 
                    OpenPort(serialPort7, cboComList.Text); timerDelay1ms(100);
                    serialPort7.DiscardInBuffer(); serialPort7.DiscardOutBuffer();  //2022-12-04
                    serialPort7.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial8)  //2022-11-22
                { 
                    OpenPort(serialPort8, cboComList.Text); timerDelay1ms(100);
                    serialPort8.DiscardInBuffer(); serialPort8.DiscardOutBuffer();  //2022-12-04
                    serialPort8.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial9)  //2022-11-22
                { 
                    OpenPort(serialPort9, cboComList.Text); timerDelay1ms(100);
                    serialPort9.DiscardInBuffer(); serialPort9.DiscardOutBuffer();  //2022-12-04
                    serialPort9.Write("AT+BIS?" + "\r\n"); 
                }
                else if (cboComList.Text == strComSerial10)  //2022-11-22
                { 
                    OpenPort(serialPort10, cboComList.Text); timerDelay1ms(100);
                    serialPort10.DiscardInBuffer(); serialPort10.DiscardOutBuffer();  //2022-12-04
                    serialPort10.Write("AT+BIS?" + "\r\n"); 
                } //2022-12-02
            }
        }

        private void btnBurn1hr_Click(object sender, EventArgs e)   //2022-06-02
        {
/*
            if (!StationCheck(0)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);  //2022-06-17

            if (txtSnoDvc0.Text != "")     //2022-07-21
            {
                if (IsFileLocked(strFilePath))   //2022-06-16
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc0.Enabled = true; btnBurn1hrDvc0.Enabled = true;
                    return;
                }
            }
            richBox.AppendText("\r\nDevice_0......Burn-in starting : " + "\r\n");    //2022-09-13
            btnBurn1hrDvc0.Enabled = false;  //2022-06-07
            txtTestRmkDvc0.Text = "";   //2023-06-19
            //if (IsOpenPort(Dvc1Serial, strDvc1Com))    //2022-11-28
            //{
            //    utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + (iBurnMin) + "\r\n");
            //}     //burn-in setting    
            //timerDelay1ms(100);

            //OpenPort(Dvc0Serial, strDvc0Com);  //2022-10-31
            utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hr = true;
            bBurnFinished = false;
            //ControlBox = false;   //2022-06-30

            txtTestRmkDvc0.Text = "Before Burn-in";   //2023-06-17
            btnTest_Click(null, null);  //2022-06-06
            //utilDvcxSerialWrite(eCPort.cPort0, "AT+RET" + "\r\n");    //2023-06-15
            Thread.Sleep(iBurnRetWaitTime*1000);    //2023-06-21

            Console.WriteLine("Device_0 Burn-in 1hr Start.");
            lblFinalDvc0.Text = "Burn-in Testing..."; lblFinalDvc0.ForeColor = Color.Red;  //2022-06-17
*/
            timer3.Enabled = true; iBurnStopStepDvc0 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc0 = DateTime.Now;   //2022-08-30
            //txtTestRmkDvc0.Text = "";   //2023-02-15
            bTempSensorNgDvc0 = false;  //2023-06-19            
        }

        private void btnBurn1hrDvc1_Click(object sender, EventArgs e)   //2022-08-29
        {
/*
            if (!StationCheck(1)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);

            if (txtSnoDvc1.Text != "")
            {
                if (IsFileLocked(strFilePath)) //This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc1.Enabled = true; btnBurn1hrDvc1.Enabled = true;
                    return;
                }
            }
            
            richBox.AppendText("\r\nDevice_1......Burn-in starting : " + "\r\n");    //2022-09-13
            btnBurn1hrDvc1.Enabled = false;
            txtTestRmkDvc1.Text = "";   //2023-06-19
            if (IsOpenPort(Dvc1Serial, strDvc1Com))    //2022-11-28
            {
                utilDvcxSerialWrite(eCPort.cPort1, "AT+BIT " + (iBurnMin) + "\r\n");
            }     //burn-in setting    
            timerDelay1ms(100);  //2022-11-28

            //OpenPort(Dvc1Serial, strDvc1Com);  //2022-10-31
            utilDvcxSerialWrite(eCPort.cPort1, "AT+BIS 1" + "\r\n");
            timerDelay1ms(200);  //2022-11-28

            bBurn1hrDvc1 = true;    //2023-06-16
            bBurnFinishedDvc1 = false;  //
            //ControlBox = false;  

            txtTestRmkDvc1.Text = "Before Burn-in";   //2023-06-17
            btnTestDvc1_Click(null, null);
            Thread.Sleep(iBurnRetWaitTime * 1000);    //2023-06-21
            Console.WriteLine("Device_1 Burn-in 1hr Start.");
            lblFinalDvc1.Text = "Burn-in Testing..."; lblFinalDvc1.ForeColor = Color.Red;
*/
            timer4.Enabled = true; iBurnStopStepDvc1 = 0;  //2023-06-28:back to step0
            dtBurnStartDvc1 = DateTime.Now;   //2022-08-30
            bTempSensorNgDvc1 = false;  //2023-06-19
        }

        private void btnTestDvc2_Click(object sender, EventArgs e)  //2022-08-18
        {
            if (!StationCheck(2)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc2.Text != "")
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc2.Enabled = true; btnBurn1hrDvc2.Enabled = true;
                    return;
                }
            }
            lblFinalDvc2.Text = ""; lblBurnRestDvc2.Text = "";  //2022-09-19

            if (iBurnStopStepDvc2 == 0)     //2023-08-11
            { txtTestRmkDvc2.Text = ""; }

            btnTestDvc2.Enabled = false;
            btnBurn1hrDvc2.Enabled = false;

            richBox.AppendText("\r\nDevice_2...Testing..." + "\r\n");    //2022-09-13
            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            //OpenPort(Dvc2Serial, strDvc2Com);
            utilDvcxSerialWrite(eCPort.cPort2, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500); //2023-06-27

            //OpenPort(Dvc2Serial, strDvc2Com);  //2022-12-02: One more port open for sure
            if (IsOpenPort(Dvc2Serial, strDvc2Com)) //2022-08-18
            {
                utilDvcxSerialWrite(eCPort.cPort2, "AT+RET" + "\r\n");
                dts2 = DateTime.Now; //2023-02-15
                strDateTimeDvc2 = /*DateTime.Now*/dts2.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc2:Test not finished for COM port " + strDvc2Com + " was not opened.\r\n"); }
            timerDelay1s(2); //2023-06-27
            if (bBurnFinishedDvc2)
            { 
                lblFinalDvc2.Text = "Burn-in Testing.";
            }
            //if (bBurn1hrDvc2)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void btnTestDvc1_Click(object sender, EventArgs e)  //2022-08-18
        {
            if (!StationCheck(1)) { return; }   //2023-02-15
            ChkFileExist(strFilePath);
            ChkFileExist(strFileDailyPath); //2023-07-06

            if (txtSnoDvc1.Text != "") 
            {
                if (IsFileLocked(strFilePath))   //=>This must be after checking File.Exists
                {
                    richBox.AppendText("Please close the report file. 請勿開啟報表檔案。\r\n");
                    MessageBox.Show("Close the report file will be fine. 請勿開啟報表檔案");
                    btnTestDvc1.Enabled = true; btnBurn1hrDvc1.Enabled = true;
                    return;
                }
            }
            lblFinalDvc1.Text = ""; lblBurnRestDvc1.Text = "";  //2022-09-19

            if (iBurnStopStepDvc1 == 0)     //2023-08-11
            { txtTestRmkDvc1.Text = ""; }

            btnTestDvc1.Enabled = false; 
            btnBurn1hrDvc1.Enabled = false;

            richBox.AppendText("...Testing..." + "\r\n");    //2022-09-13    

            richBox.ForeColor = Color.FromArgb(255, 255, 128);

            //2023-06-17
            //OpenPort(Dvc1Serial, strDvc1Com);
            utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 146" + "\r\n");
            timerDelay1ms(500);

            if (IsOpenPort(Dvc1Serial, strDvc1Com)) //2022-08-18
            {
                utilDvcxSerialWrite(eCPort.cPort1, "AT+RET" + "\r\n");
                dts1 = DateTime.Now; //2023-02-15
                strDateTimeDvc1 = /*DateTime.Now*/dts1.ToString("yyyy-MM-dd-HH:mm:ss"); //2023-02-15
            }
            else   //2022-11-21
            { MessageBox.Show("Dvc1:Test not finished for COM port " + strDvc1Com + " was not opened.\r\n"); }
            timerDelay1s(2);    //2023-06-27
            if (bBurnFinishedDvc1)  
            { 
                lblFinalDvc1.Text = "Burn-in Testing.";                
            }   
            //if (bBurn1hrDvc1)  //2023-06-16
            //{ strStaId = "<3-2>"; }
        }

        private void timer3_Tick(object sender, EventArgs e)   //2023-06-27
        {
            dtBurnTimeDvc0 = DateTime.Now;
            TimeSpan tsBurnDvc0 = new TimeSpan(dtBurnTimeDvc0.Ticks - dtBurnStartDvc0.Ticks);
            int iBurnTimeDvc0 = Convert.ToInt32(Math.Floor(tsBurnDvc0.TotalSeconds) / 60);
            System.Windows.Forms.Application.DoEvents();

            switch (iBurnStopStepDvc0)
            {
                case 0:
                    lblBurnRestDvc0.Visible = true;
                    btnBurnStopDvc0.Visible = true;
                    btnBurnStopDvc0.Enabled = true;
                    iBurnStopStepDvc0 += 1;
                    break;
                case 1:
                    richBox.AppendText("\r\n......Burn-in starting : " + "\r\n");
                    btnBurn1hrDvc0.Enabled = false;
                    iBurnStopStepDvc0 += 1;
                    txtTestRmkDvc0.Text = "";   //2023-08-08
                    break;
                case 2:
                    iBurnStopStepDvc0 += 1;
                    utilDvcxSerialWrite(eCPort.cPort0, "AT+BIT " + (iBurnMin) + "\r\n"); //burn-in setting 
                    break;
                case 3:
                    if (timerDelay1ms(100))
                    {
                        iBurnStopStepDvc0 += 1;
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS 1" + "\r\n");
                    }
                    break;
                case 4:
                    if (timerDelay1ms(200))
                    {
                        iBurnStopStepDvc0 += 1;
                        bBurn1hr = true;    //starting burn-in
                        bBurnFinished = false;
                        txtTestRmkDvc0.Text = "Before Burn-in";
                        btnTest_Click(this, null);
                    }
                    break;
                case 5:
                    if (bAtComReceivDvc0)
                    {
                        bAtComReceivDvc0 = false;
                        iBurnStopStepDvc0 = 19; //= 10; //2023-06-28
                        Console.WriteLine("Device_0 Burn-in 1hr Start.");
                        lblFinalDvc0.Text = "Burn-in Testing..."; lblFinalDvc0.ForeColor = Color.Red;
                    }
                    break;

                #region
                case 10:    //case 10~case 13 could use with FW <v1.6, shut down LD when temerature over 50
                    if (IsOpenPort(Dvc0Serial, strDvc0Com))    //2023-02-16
                    {
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+BIT " + 0 + "\r\n"); //set mirror not open
                    }
                    iBurnStopStepDvc0 += 1;
                    break;
                case 11:    //case 11~case 13 is used for FW before v1.6
                    //2023-06-19
                    if (!bTempSensorNgDvc0) //To cehck if temperature sensor is good to go
                    { utilDvcxSerialWrite(eCPort.cPort0, "AT+TEMP?" + "\r\n"); }

                    if (bTempOver50Dvc0 && !bWaitCoolDvc0)
                    {
                        //IsOpenPort(Dvc0Serial, strDvc0Com);
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+CURR 0" + "\r\n");
                        iBurnStopStepDvc0 = 12;
                    }
                    else if (bTempUnder40Dvc0 && bWaitCoolDvc0)
                    {
                        //IsOpenPort(Dvc0Serial, strDvc0Com);
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+CURR 146" + "\r\n");
                        iBurnStopStepDvc0 = 13;
                    }

                    if (iBurnTimeDvc0 > iBurnMin || bBurnStopDvc0)  //2022-09-19
                    {
                        bBurnFinished = true;
                        //OpenPort(Dvc0Serial, strDvc0Com);
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc0 = 20;
                        bBurnStopDvc0 = false;  //2022-09-08
                        richBox.AppendText("Device_0 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc0.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc0).ToString() + "分鐘"; } //2022-12-01
                    break;
                //2023-06-17
                case 12:
                    if (bSetCurr0Dvc0)  //CURR has been set to 0
                    {
                        iBurnStopStepDvc0 = 11; bWaitCoolDvc0 = true;
                        richBox.AppendText("Device_0 Wait Laser Cooling down.\r\n");
                    }
                    break;
                case 13:
                    if (!bSetCurr0Dvc0) //CURR has been set to 146
                    {
                        iBurnStopStepDvc0 = 11; bWaitCoolDvc0 = false;
                        richBox.AppendText("Device_0 Laser opening.\r\n");
                    }
                    break;
                #endregion
                //2023-06-28:For FW_v1.8
                case 19:
                    if (bTempRecording) //2023-06-29:Just for test
                    {
                        iIntevalCntDvc0++;
                        if (iIntevalCntDvc0 >= iTempWatchInterval * (1000 / timer3.Interval))   //(1000/timer3.Interval)=1sec
                        {
                            iIntevalCntDvc0 = 0;
                            utilDvcxSerialWrite(eCPort.cPort0, "AT+TEMP?" + "\r\n");
                        }                        
                    }
                    //if ((iBurnTimeDvc0 > iTempChkTime) && !bTempChkInBurnDvc0)   //2023-02-15:To check temperature after certain time
                    //{
                    //    //OpenPort(Dvc0Serial, strDvc0Com);
                    //    utilDvcxSerialWrite(eCPort.cPort0, "AT+TEMP?" + "\r\n");
                    //    bTempChkInBurnDvc0 = true;
                    //}
                    if (iBurnTimeDvc0 > iBurnMin || bBurnStopDvc0)  //2022-09-19
                    {
                        bBurnFinished = true;
                        //OpenPort(Dvc0Serial, strDvc0Com);
                        utilDvcxSerialWrite(eCPort.cPort0, "AT+BIS 0" + "\r\n");
                        timerDelay1ms(300);  //2022-12-01
                        iBurnStopStepDvc0 = 20;
                        bBurnStopDvc0 = false;  //2022-09-08
                        richBox.AppendText("Device_0 快要完成了，請等候燒機後的測試紀錄\r\n");   //2022-11-02
                    }
                    else
                    { lblBurnRestDvc0.Text = "燒機還要: " + (iBurnMin - iBurnTimeDvc0).ToString() + "分鐘"; } //2022-12-01
                    break;

                case 20:
                    iBurnStopStepDvc0 += 1;
                    txtTestRmkDvc0.Text = "After Burn-in";
                    break;
                case 21:
                    iBurnStopStepDvc0 = 30;
                    bBurnAll2ndTesting = true;  //2022-11-30
                    btnBurnStopDvc0.Visible = false;
                    //txtTestRmkDvc0.Text = "After Burn-in";   //2023-06-17
                    btnTest_Click(this, null); 
                    timerDelay1s(iBurnRetWaitTime);    //2023-06-17
                    iBurnStopStepDvc0Stay = 0;  //2022-11-30
                    break;
                case 30:
                    Console.WriteLine(strDateTimeDvc0);    //2023-02-17
                    if (bAtComReceivDvc0/*!bBurnAll2ndTesting*/)
                    {
                        iBurnStopStepDvc0 += 1;
                        bAtComReceivDvc0 = false;   //2023-06-26
                    }
                    else if (iBurnStopStepDvc0Stay > 30)   //2022-11-30
                    {
                        iBurnStopStepDvc0 += 1;
                        iBurnStopStepDvc0Stay = 0;
                        richBox.AppendText("Device_0 燒機後電測無回應結果-2？\r\n");
                    }
                    else
                    { iBurnStopStepDvc0Stay += 1; }

                    break;
                case 31:
                    if (txtSnoDvc0.Text == "") //2023-06-30
                    { iBurnStopStepDvc0 = 100; }
                    else
                    { iBurnStopStepDvc0 += 1; }
                    break;
                case 32:    //2023-06-30
                    timerDelay1ms(500);
                    iBurnStopStepDvc0 = 100;
                    break;

                case 100:
                    timer3.Enabled = false;
                    iBurnStopStepDvc0 = 0;
                    Console.WriteLine("Device_0:Burn-in finished:@timer14");
                    btnTestDvc0.Enabled = true;
                    btnBurn1hrDvc0.Enabled = true;
                    bTempChkInBurnDvc0 = false;
                    //txtSnoDvc0.Text = "";
                    //txtTestRmkDvc0.Text = "";   //2023-06-28
                    richBox.AppendText("Device_0:Burn-in finished. 燒機結束\r\n");    //2023-06-29
                    lblBurnRestDvc0.Text = "燒機結束";  //2023-06-29
                    break;
            }

        }

        private void btnAtSetCmdSend_Click(object sender, EventArgs e)    //2022-06-06
        {
            int iParameter = -1;
            if (cboAtSetCmd.Text == "AT+STA")   //2023-02-16
            {
                iParameter = Convert.ToInt32(txtParameter.Text) + Convert.ToInt32(cboDevNo.Text) * 16;
            }
            else
            { iParameter = Convert.ToInt32(txtParameter.Text); }

            switch (cboDevNo.Text)   //2022-11-17    // (cboDevNo.SelectedIndex) //2022-08-24
            {
                case "0":
                    IsOpenPort(Dvc0Serial, strDvc0Com);
                    utilDvcxSerialWrite(eCPort.cPort0, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "1":
                    IsOpenPort(Dvc1Serial, strDvc1Com);
                    utilDvcxSerialWrite(eCPort.cPort1, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "2":
                    IsOpenPort(Dvc2Serial, strDvc2Com);
                    utilDvcxSerialWrite(eCPort.cPort2, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "3":
                    IsOpenPort(Dvc3Serial, strDvc3Com);
                    utilDvcxSerialWrite(eCPort.cPort3, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "4":
                    IsOpenPort(Dvc4Serial, strDvc4Com);
                    utilDvcxSerialWrite(eCPort.cPort4, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "5":
                    IsOpenPort(Dvc5Serial, strDvc5Com);
                    utilDvcxSerialWrite(eCPort.cPort5, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "6":
                    IsOpenPort(Dvc6Serial, strDvc6Com);
                    utilDvcxSerialWrite(eCPort.cPort6, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "7":
                    IsOpenPort(Dvc7Serial, strDvc7Com);
                    utilDvcxSerialWrite(eCPort.cPort7, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "8":
                    IsOpenPort(Dvc8Serial, strDvc8Com);
                    utilDvcxSerialWrite(eCPort.cPort8, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
                case "9":
                    IsOpenPort(Dvc9Serial, strDvc9Com);
                    utilDvcxSerialWrite(eCPort.cPort9, cboAtSetCmd.Text + " " + iParameter/*txtParameter.Text*/ + "\r\n");
                    break;
            }            
        }
        public void CreateLogFolder() //2023-05-31
        {
            if (!System.IO.Directory.Exists(userAppFolder))
            {
                System.IO.Directory.CreateDirectory(userAppFolder);
            }
        }
        public void ChkFileExist(string filename)   //2022-06-17 //copy from btnTest
        {
            CreateLogFolder(); //2023-05-31
            if (!File.Exists(/*strFilePath*/filename))  //2023-07-05
            {
                string strSeperator = ",";
                StringBuilder sbOutput = new StringBuilder();

                string[][] inaOutput = new string[][]
                {
                    new string[]{ "SN","Date & Time",/*"dev","cmd","type",*/
                        "Station_id",/*"FWver",*/"FPC_test","Temperature(C)","TMP_status",
                        "PD_P(V)","PD_N(V)","PD_result","LDD_current","QC_final"}  //2022-5-6
                };

                sbOutput.AppendLine(string.Join(strSeperator, inaOutput[0]));

                File.AppendAllText(/*strFilePath*/filename, sbOutput.ToString());   //2023-07-06
            }
        }

        public bool IsFileLocked(string filename)   //2022-06-16
        {
            bool Locked = false;
            try
            {
                FileStream fs =
                    File.Open(filename, FileMode.OpenOrCreate,
                    FileAccess.ReadWrite, FileShare.None);
                fs.Close();
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
                Locked = true;
            }
            return Locked;
        }

        private void btnBurnStop_Click(object sender, EventArgs e)  //2022-06-17
        {
            if (MessageBox.Show("確定要中斷燒錄嗎？", "問題", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnBurnStopDvc0.Enabled = false;    //2022-06-20
                richBox.AppendText("interrupting...Device_0燒機提早停止，請稍候...\r\n"); //2022-06-20

                //if(!IsOpenPort(Dvc0Serial,strDvc0Com)) { Dvc0Serial.Open(); }  //2022-09-13
                //Dvc0Serial.Write("AT+BIS 0" + "\r\n");  //2022-08-30
                //timerDelay1ms(500);

                bBurnStopDvc0 = true;   //2022-11-02
                //MessageBox.Show("Device_0提早結束燒機，請再等候約30sec結束測試，不要立刻關閉電源與程式，請注意紀錄的時間非原預訂的燒機時間");
            }                
        }

        protected override void WndProc(ref Message m)  //2022-11-17
        {
            const int WM_DEVICECHANGE = 0x219;
            const int DBT_DEVICEARRIVAL = 0x8000;
            const int DBT_DEVICEREMOVECOMPLETE = 0x8004;

            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;
            const int SC_CLICK = 0xF093;
            const int SC_DOUBLE_CLICK = 0xF063;
            const int iCurr80mA = 146;

            object ojb = new object();
            try   //2023-09-25
            {
                // WM_DEVICECHANGE Message : 電腦硬體裝置改變時產生的訊息
                if (m.Msg == WM_DEVICECHANGE)
                {
                    switch (m.WParam.ToInt32())
                    {
                        case WM_DEVICECHANGE:
                            richBox.AppendText("DEVICE CHANGE\n");
                            break;
                        // DBT_DEVICEARRIVAL Event : 裝置插入並且可以使用時，產生的系統訊息
                        case DBT_DEVICEARRIVAL:
                            string[] portnames = SerialPort.GetPortNames();
                            bDeviceArrival = true;   //2025-07-17
                            int k = 0;
                            foreach (string s in portnames)
                            {
                                if (strComConnect.Contains(s))
                                { k++; }
                                else
                                {
                                    strComConnect.Add(s); Console.WriteLine(strComConnect.Count);
                                    toolStripStatusLabel1.Text = s + " inserted";
                                    Console.WriteLine(s + " inserted\r");
                                    
                                    if (VidPidNames.Contains(s))
                                    {
                                        Console.WriteLine("New inserted Device's COM= " + s);
                                        strComInsert = s; cboComList.Items.Add(s);

                                        try   //2025-07-28
                                        {
                                            if (IsOpenPort(serialPort1, s))
                                            {
                                                serialPort1.Write("AT+VER?" + "\r\n");
                                                break;
                                            }
                                            else if (IsOpenPort(serialPort2, s))
                                            {
                                                serialPort2.Write("AT+VER?" + "\r\n");
                                                break;
                                            }
                                            else if(IsOpenPort(serialPort3, s))
                                            {
                                                serialPort3.Write("AT+VER?" + "\r\n");
                                                break;
                                            }
                                            else if(IsOpenPort(serialPort4, s))
                                            {
                                                serialPort4.Write("AT+VER?" + "\r\n");
                                                break;
                                            }
                                        }
                                        catch (UnauthorizedAccessException)
                                        {
                                            Console.WriteLine($"串口 {strComInsert/*s*/} 正在被其他應用程序使用。");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"串口 {strComInsert/*s*/} 無法打開，錯誤信息: {ex.Message}");
                                        }

                                        if (JigComSerial.IndexOf(s) < 0)
                                        {
                                            JigComSerial.Add(s);
                                        }
                                        //cboComList.Items.Add(s);
                                        //cboComList.Text = s;  //2025-07-18
                                        return;
                                    }
                                }
                            }
                            utilVerChk();
                            break;

                        // DBT_DEVICEREMOVECOMPLETE Event : 裝置卸載或移除時產生的系統訊息
                        case DBT_DEVICEREMOVECOMPLETE:   //2025-07-18
                            string[] ports = SerialPort.GetPortNames();  //2nd Remove same device could be wrong？
                            k = 0;

                            if (ports.Length != strComConnect.Count) //2025-07-28
                            {
                                if (ports.Length != 0)
                                {
                                    foreach (string s1 in JigComSerial.ToArray())  //ToArray：解決"集合已修改; 列舉作業可能尚未執行" 
                                    {
                                        if (ports.Contains(s1))
                                        { k++; }
                                        else
                                        {
                                            strComConnect.Remove(s1);
                                            JigComSerial.Remove(s1); cboCmdList.Items.Remove(s1); //cboCmdList.Items.Clear();  //2025-07-24
                                            Console.WriteLine(s1 + " has been removed.\r");
                                            toolStripStatusLabel1.Text = s1 + " removed";
                                            richBox.AppendText(s1 + " has been removed.\r\n");
                                            DvcRemovedUiRefresh(s1);
                                        }
                                    }
                                }
                            }
                            break;
                    }
                }
                else if (m.Msg == WM_SYSCOMMAND)
                {
                    if (m.WParam.ToInt32() == SC_CLOSE)
                    {
                        // 点击winform右上关闭按钮 
                        // 加入想要的逻辑处理
                        //utilWindowClosingWithConfirm(false);
                        //return;
                    }
                    else if (m.WParam.ToInt32() == SC_CLICK)
                    {
                        return;
                    }
                    else if (m.WParam.ToInt32() == SC_DOUBLE_CLICK)
                    {
                        // It will close window while double click to exit on left-top corner.
                        //utilWindowClosingWithConfirm();
                        if (!bSetCurr_0)
                        {
                            if (MessageBox.Show("Set LD curr to 0？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (IsOpenPort(Dvc0Serial, strDvc0Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort0, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc1Serial, strDvc1Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc2Serial, strDvc2Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort2, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc3Serial, strDvc3Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort3, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc4Serial, strDvc4Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort4, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc5Serial, strDvc5Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort5, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc6Serial, strDvc6Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort6, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc7Serial, strDvc7Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort7, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc8Serial, strDvc8Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort8, "AT+CURR 0" + "\r\n");
                                }
                                if (IsOpenPort(Dvc9Serial, strDvc9Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort9, "AT+CURR 0" + "\r\n");
                                }
                                bSetCurr_0 = true;
                            }
                        }
                        else
                        {
                            if (MessageBox.Show("Set LD curr to 80mA？", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (IsOpenPort(Dvc0Serial, strDvc0Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort0, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc1Serial, strDvc1Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort1, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc2Serial, strDvc2Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort2, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc3Serial, strDvc3Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort3, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc4Serial, strDvc4Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort4, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc5Serial, strDvc5Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort5, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc6Serial, strDvc6Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort6, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc7Serial, strDvc7Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort7, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc8Serial, strDvc8Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort8, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                if (IsOpenPort(Dvc9Serial, strDvc9Com))
                                {
                                    utilDvcxSerialWrite(eCPort.cPort9, "AT+CURR " + iCurr80mA + "\r\n");
                                }
                                bSetCurr_0 = false;
                            }
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "WndProc");
            }
            base.WndProc(ref m);
        }

        private Boolean StationCheck(int iDvc)  //2023-02-15
        {
            switch (iDvc)
            {
                case 0:
                    if (radSta0Dvc0.Checked || radSta1Dvc0.Checked || radSta2Dvc0.Checked ||
                        radSta3Dvc0.Checked || radSta4Dvc0.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 1:
                    if (radSta0Dvc1.Checked || radSta1Dvc1.Checked || radSta2Dvc1.Checked ||
                        radSta3Dvc1.Checked || radSta4Dvc1.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 2:
                    if (radSta0Dvc2.Checked || radSta1Dvc2.Checked || radSta2Dvc2.Checked ||
                        radSta3Dvc2.Checked || radSta4Dvc2.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 3:
                    if (radSta0Dvc3.Checked || radSta1Dvc3.Checked || radSta2Dvc3.Checked ||
                        radSta3Dvc3.Checked || radSta4Dvc3.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 4:
                    if (radSta0Dvc4.Checked || radSta1Dvc4.Checked || radSta2Dvc4.Checked ||
                        radSta3Dvc4.Checked || radSta4Dvc4.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 5:
                    if (radSta0Dvc5.Checked || radSta1Dvc5.Checked || radSta2Dvc5.Checked ||
                        radSta3Dvc5.Checked || radSta4Dvc5.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 6:
                    if (radSta0Dvc6.Checked || radSta1Dvc6.Checked || radSta2Dvc6.Checked ||
                        radSta3Dvc6.Checked || radSta4Dvc6.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 7:
                    if (radSta0Dvc7.Checked || radSta1Dvc7.Checked || radSta2Dvc7.Checked ||
                        radSta3Dvc7.Checked || radSta4Dvc7.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 8:
                    if (radSta0Dvc8.Checked || radSta1Dvc8.Checked || radSta2Dvc8.Checked ||
                        radSta3Dvc8.Checked || radSta4Dvc8.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                case 9:
                    if (radSta0Dvc9.Checked || radSta1Dvc9.Checked || radSta2Dvc9.Checked ||
                        radSta3Dvc9.Checked || radSta4Dvc9.Checked)
                    { return true; }
                    else
                    {
                        richBox.AppendText("Device_" + iDvc + ":No station is detected.\r\n");
                        return false;
                    }
                    //break;
                default:
                    richBox.AppendText("No device was detected.\r\n");
                    return false;
                    //break;
            }
            
        }

        public static bool timerDelay1s(int delayTime)  //2023-02-18:by Jay
        {
            if (delayTime > 59)
            {
                MessageBox.Show("Delay Invalid", "Warning!!!");
            }
            else
            {
                DateTime now = DateTime.Now;
                double s;
                do
                {
                    TimeSpan spand = DateTime.Now - now;
                    s = spand.Seconds;
                    //s = spand.Milliseconds / 1000;
                    System.Windows.Forms.Application.DoEvents();
                }
                while (s < delayTime);
            }
            return true;
        }

        public static bool timerDelay1ms(int delayTime)  //2023-02-18:by Jay
        {
            if (delayTime > 999)
            {
                MessageBox.Show("Delay Invalid", "Warning!!!");
            }
            else
            {
                DateTime now = DateTime.Now;
                int s;
                do
                {
                    TimeSpan spand = DateTime.Now - now;
                    s = spand.Milliseconds;
                    System.Windows.Forms.Application.DoEvents();
                }
                while (s < delayTime);
            }
            return true;
        }
        public static bool waitCounter1ms(int waitTime)  //2023-02-18: waiting timer counter
        {
            //DateTime now = DateTime.Now;
            int i = waitTime * 10000;
            do
            {
                //TimeSpan spand = DateTime.Now - now;
                //s = spand.Milliseconds;
                i -= 1;
                if(i <= 0) 
                { return true; }
                System.Windows.Forms.Application.DoEvents();
            }
            while (i > 0);

            return false;
        }

        public void LogFileSaving()   //2023-06-26
        {
            string strSeperator = ",";
            StringBuilder sbOutput = new StringBuilder();
            StringBuilder sbOutput1 = new StringBuilder();  //2023-07-06

            string[][] inaOutput = new string[][]
            {
                new string[]{ strSNo, stringDateTime, strStaId, strIot, strTemp, strTMPsta,
                    strPDP, strPDN, strPDresult, strCurr, strResult, strDeviceID, strTestRmk }
            };

            sbOutput.AppendLine(string.Join(strSeperator, inaOutput[0]));
            File.AppendAllText(strFilePath, sbOutput.ToString());
            //2023-07-06
            sbOutput1.AppendLine(string.Join(strSeperator, inaOutput[0]));
            File.AppendAllText(strFileDailyPath, sbOutput1.ToString()); 
        }
        private void TemperatureRecording() //2023-06-29:Just for debugging
        {
            string strTempRecordPath = userAppFolder + "\\" + "Burn1to10TempLog" + "_" + TestDate.ToString("yyyyMMdd") + ".csv";
            string strSeperator = ",";
            StringBuilder sbOutput = new StringBuilder();
            CreateLogFolder();
            string[][] inaOutputTemp = new string[][]
                {
                new string[]{ strSNo, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), strDeviceID, "AT+TEMP?"/*strCmd*/, strStaId, strFwver
                    ,strTemp, /*strTMPsta,*/ strCurr }
                };
            if (!File.Exists(strTempRecordPath))
            {
                string[][] title = new string[][]
                {
                    new string[]{ "SN","Date & Time","device","cmd", "Station_id","FWver",
                        "Temperature(C)",/*"TMP_status",*/ "LDD_current"}
                };
                sbOutput.AppendLine(string.Join(strSeperator, title[0]));
                File.AppendAllText(strTempRecordPath, sbOutput.ToString());
            }
            else 
            {                
                sbOutput.AppendLine(string.Join(strSeperator, inaOutputTemp[0]));
                File.AppendAllText(strTempRecordPath, sbOutput.ToString());
            }            
        }
        private void strIdentifyByDevice()  //2023-06-29
        {
            switch (iDvcId)
            {
                case 0:
                    strSNo = txtSnoDvc0.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 1:
                    strSNo = txtSnoDvc1.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 2:
                    strSNo = txtSnoDvc2.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 3:
                    strSNo = txtSnoDvc3.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 4:
                    strSNo = txtSnoDvc4.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 5:
                    strSNo = txtSnoDvc5.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 6:
                    strSNo = txtSnoDvc6.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 7:
                    strSNo = txtSnoDvc7.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 8:
                    strSNo = txtSnoDvc8.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
                case 9:
                    strSNo = txtSnoDvc9.Text; strDeviceID = "Device_" + iDvcId.ToString();
                    break;
            }                
        }

        private Boolean MustDataCheck()  //2023-07-06
        {
            Boolean result = false;
            if (txtSnoDvc0.Text == "")
            {
                MessageBox.Show("請輸入操作者ID");
                return result;
            }
            if ((txtSnoDvc0.Text.Trim().Length == 18))
            { result = true; }
            else if (txtSnoDvc0.Text.Trim().Length >= 4 && txtSnoDvc0.Text.Substring(0, 4) == "test")
            { result = true; }
            else
            {
                MessageBox.Show("測試編號必須為18碼，或者以test為開頭");
                result = false;
            }
            return result;
        }
        public static string GetMacAddress()    //2023-02-20
        {
            string macAddresses = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)  //2023-03-21
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
                else if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    macAddresses += nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            macAddresses = AddSpaceEveryNChar(macAddresses, 2); //2025-06-19
            return macAddresses;
        }
        static string AddSpaceEveryNChar(string str, int split)   //2023-08-11
        {
            for (int a = 2; a <= str.Length - 1; a = a + split + 1)
            {
                str = str.Insert(a, "-");
            }
            Console.WriteLine(str);
            return str;
        }
        public static String GetRebootTime()   //2023-02-03
        {
            EventLog systemLog = new EventLog("System");
            var bootEntry = systemLog?.Entries.Cast<EventLogEntry>().
                Where(x => x.InstanceId == 12).
                OrderByDescending(x => x.TimeGenerated).
                FirstOrDefault();

            if (bootEntry != null)
            {
                Console.WriteLine("Last boot: " + bootEntry.TimeGenerated.ToString("yyyy-MM-dd HH:mm:ss"));
            }
            else
            {
                Console.WriteLine("Could not open System log or no boot event found.");
            }
            return bootEntry.TimeGenerated.ToString("yyyy-MMd-d HH:mm:ss.ss");    //2023-03-13
            //Console.ReadLine();
        }

    }
}
