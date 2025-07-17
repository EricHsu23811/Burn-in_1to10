
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ado
{
    public enum Customer : Byte //2023-07-06:by Jay
    {
        /********************************************************************************/
        ctHumane,

        /*******************************************************************************/
        ctInvalid   //  used for enumerated type range
                    // checking (DO NOT REMOVE)
    }
    
    public class ReciveJData {
		public string jver {get; set; }
		public string dev {get; set; }	//"mcy"=Mecury
		public string cmd { get; set; } //2022-5-6
		public int type {get; set; } // 0:JSON ACK, 1:JSON Data
		public int id {get; set; }
		public int fwver { get; set; } //2022-5-6
		public int iot { get; set; } //2022-5-6
		public int temp {get; set; }
		public int temps { get; set; } //2022-5-6:temperature status
		//public int status {get; set; }
		public int PDP {get; set; }
		public int PDN {get; set; }
		//public int gpio {get; set; }   
		//public int state {get; set; }	//For FPC_IO_test:2022-04-15
		//public int PDadj {get; set; }
		public int current {get; set; } //2022-5-6
		//public int PDGain {get; set; }
		public int PDTest {get; set; } //2022-5-6
		//public int PDTest71 {get; set; }
		//public int PDTest72 {get; set; }
		//public int error {get; set; } //2022-5-6
		public int checksum {get; set; }
	}

	public class ReciveJAck {
		public string jver {get; set; }
		public string dev {get; set; }
		public string cmd {get; set; }
        public int type {get; set; } // 0:JSON ACK, 1:JSON Data
		public int id {get; set; }
		public int ack {get; set; }     // 0:OK, 1:ERROR
		public int data1 {get; set; }
		public int data2 {get; set; }
		public int data3 { get; set; }  //2022-5-5
		public int checksum {get; set; }
	}

    public class ConfigJson //2023-07-06:copy from FunctionTest
    {
        public string jver { get; set; }
        public string dev { get; set; }
        public string cmd { get; set; }
        public int type { get; set; }               // 0:JSON ACK, 1:JSON Data, 3:Config
        public int id { get; set; }
        public Customer customer { get; set; }

        //2023-04-10: Add log column for Humane
        public string TEST_MODE { get; set; }
        public string DUT_MODE { get; set; }
        public string REL_STATUS { get; set; }
        public string COF_MODE { get; set; }
        public string SFIS_CHECK_ROUTE { get; set; }
        public string BUILD_EVENT { get; set; }
        public string PRODUCT_NAME { get; set; }
        public string TEST_LINE { get; set; }
        public string LINE_TYPE { get; set; }
        public string STATION_NAME { get; set; }
        public string FIXTURE_ID { get; set; }
        public string SITE_ID { get; set; }
        public string CONFIG_INPUT { get; set; }
        public string SLOT_ID { get; set; }
        public string OPERATOR_ID { get; set; }
        public string VERSION_TEST_LOG { get; set; }
        public string VERSION_TEST_SW { get; set; }

        //2023-03-29
        public string CONFIG_FATP { get; set; }
        public string CONFIG_MLB { get; set; }
        public string CONFIG_MLB_FONTANA { get; set; }
        public string ISN_FATP_B1 { get; set; }
        public string ISN_FATP_H4 { get; set; }
        public string ISN_MLB_B1 { get; set; }
        public string ISN_MLB_FONTANA { get; set; }
        public string ISN_MLB_H4 { get; set; }
        public string VERSION_DUT_FW { get; set; }

        public string VERSION_TEST_LIMITS { get; set; }
        public string DUT_COLOR { get; set; }
        public string UNIT_NUMBER { get; set; }

        //2023-07-5
        public int FUNC_TEMP_SENSOR_TEST_UCL { get; set; }  //2023-08-22
        public int FUNC_TEMP_SENSOR_TEST_LCL { get; set; }  //2023-08-22
        public double FUNC_PDP_UCL { get; set; }
        public double FUNC_PDP_LCL { get; set; }
        public double FUNC_PDN_UCL { get; set; }
        public double FUNC_PDN_LCL { get; set; }
        public int FUNC_SN_LENGTH { get; set; }	//2023-07-13

        public int checksum { get; set; }
    }
    public class JigDevice  //2022-5-6:Jig Devices' Serialport and Comport
    {
        public SerialPort DvcSerail { get; set; } //2022-5-6:Device Serialprot
        public string strDvcCom { get; set; } //2022-5-6:Device Comport
    }
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
