
namespace Ado
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Main = new System.Windows.Forms.TabPage();
            this.btnBurnAll = new System.Windows.Forms.Button();
            this.cboComDvc0 = new System.Windows.Forms.ComboBox();
            this.lblDevIdDvc0 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc0 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc0 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc0 = new System.Windows.Forms.Button();
            this.lblSWver = new System.Windows.Forms.Label();
            this.lblBurnRestDvc0 = new System.Windows.Forms.Label();
            this.lblTempDvc0 = new System.Windows.Forms.Label();
            this.btnTempReadDvc0 = new System.Windows.Forms.Button();
            this.txtTempDvc0 = new System.Windows.Forms.TextBox();
            this.btnBurn1hrDvc0 = new System.Windows.Forms.Button();
            this.btnMemsReadDvc0 = new System.Windows.Forms.Button();
            this.btnMemsSetDvc0 = new System.Windows.Forms.Button();
            this.cboSta0optDvc0 = new System.Windows.Forms.ComboBox();
            this.lblSta0optDvc0 = new System.Windows.Forms.Label();
            this.lblPdGainSetD0 = new System.Windows.Forms.Label();
            this.cboPdGainSetDvc0 = new System.Windows.Forms.ComboBox();
            this.grpStaDvc0 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc0 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc0 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc0 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc0 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc0 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFinalDvc0 = new System.Windows.Forms.Label();
            this.lblSnoDvc0 = new System.Windows.Forms.Label();
            this.txtSnoDvc0 = new System.Windows.Forms.TextBox();
            this.btnClearDvc0 = new System.Windows.Forms.Button();
            this.lblBaudDvc0 = new System.Windows.Forms.Label();
            this.lblComDvc0 = new System.Windows.Forms.Label();
            this.cboBaudDvc0 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc0 = new System.Windows.Forms.Button();
            this.tabPage_Device1 = new System.Windows.Forms.TabPage();
            this.lblTestRmkDvc1 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc1 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc1 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc1 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc1 = new System.Windows.Forms.Label();
            this.lblFinalDvc1 = new System.Windows.Forms.Label();
            this.lblDevIdDvc1 = new System.Windows.Forms.Label();
            this.grpStaDvc1 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc1 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc1 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc1 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc1 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc1 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lblSnoDvc1 = new System.Windows.Forms.Label();
            this.txtSnoDvc1 = new System.Windows.Forms.TextBox();
            this.btnClearDvc1 = new System.Windows.Forms.Button();
            this.lblBaudDvc1 = new System.Windows.Forms.Label();
            this.lblComDvc1 = new System.Windows.Forms.Label();
            this.cboBaudDvc1 = new System.Windows.Forms.ComboBox();
            this.cboComDvc1 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc1 = new System.Windows.Forms.Button();
            this.tabPage_Device2 = new System.Windows.Forms.TabPage();
            this.lblTestRmkDvc2 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc2 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc2 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc2 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc2 = new System.Windows.Forms.Label();
            this.lblFinalDvc2 = new System.Windows.Forms.Label();
            this.lblDevIdDvc2 = new System.Windows.Forms.Label();
            this.grpStaDvc2 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc2 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc2 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc2 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc2 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc2 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.lblSnoDvc2 = new System.Windows.Forms.Label();
            this.txtSnoDvc2 = new System.Windows.Forms.TextBox();
            this.btnClearDvc2 = new System.Windows.Forms.Button();
            this.lblBaudDvc2 = new System.Windows.Forms.Label();
            this.lblComDvc2 = new System.Windows.Forms.Label();
            this.cboBaudDvc2 = new System.Windows.Forms.ComboBox();
            this.cboComDvc2 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc2 = new System.Windows.Forms.Button();
            this.tabPage_Device3 = new System.Windows.Forms.TabPage();
            this.lblTestRmkDvc3 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc3 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc3 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc3 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc3 = new System.Windows.Forms.Label();
            this.lblFinalDvc3 = new System.Windows.Forms.Label();
            this.lblDevIdDvc3 = new System.Windows.Forms.Label();
            this.grpStaDvc3 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc3 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc3 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc3 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc3 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc3 = new System.Windows.Forms.RadioButton();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.lblSnoDvc3 = new System.Windows.Forms.Label();
            this.txtSnoDvc3 = new System.Windows.Forms.TextBox();
            this.btnClearDvc3 = new System.Windows.Forms.Button();
            this.lblBaudDvc3 = new System.Windows.Forms.Label();
            this.lblComDvc3 = new System.Windows.Forms.Label();
            this.cboBaudDvc3 = new System.Windows.Forms.ComboBox();
            this.cboComDvc3 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc3 = new System.Windows.Forms.Button();
            this.tabPage_Device4 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc4 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc4 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc4 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc4 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc4 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc4 = new System.Windows.Forms.Label();
            this.lblFinalDvc4 = new System.Windows.Forms.Label();
            this.lblDevIdDvc4 = new System.Windows.Forms.Label();
            this.grpStaDvc4 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc4 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc4 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc4 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc4 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc4 = new System.Windows.Forms.RadioButton();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.txtSnoDvc4 = new System.Windows.Forms.TextBox();
            this.btnClearDvc4 = new System.Windows.Forms.Button();
            this.lblBaudDvc4 = new System.Windows.Forms.Label();
            this.lblComDvc4 = new System.Windows.Forms.Label();
            this.cboBaudDvc4 = new System.Windows.Forms.ComboBox();
            this.cboComDvc4 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc4 = new System.Windows.Forms.Button();
            this.tabPage_Device5 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc5 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc5 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc5 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc5 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc5 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc5 = new System.Windows.Forms.Label();
            this.lblFinalDvc5 = new System.Windows.Forms.Label();
            this.lblDevIdDvc5 = new System.Windows.Forms.Label();
            this.grpStaDvc5 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc5 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc5 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc5 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc5 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc5 = new System.Windows.Forms.RadioButton();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.txtSnoDvc5 = new System.Windows.Forms.TextBox();
            this.btnClearDvc5 = new System.Windows.Forms.Button();
            this.lblBaudDvc5 = new System.Windows.Forms.Label();
            this.lblComDvc5 = new System.Windows.Forms.Label();
            this.cboBaudDvc5 = new System.Windows.Forms.ComboBox();
            this.cboComDvc5 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc5 = new System.Windows.Forms.Button();
            this.tabPage_Device6 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc6 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc6 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc6 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc6 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc6 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc6 = new System.Windows.Forms.Label();
            this.lblFinalDvc6 = new System.Windows.Forms.Label();
            this.lblDevIdDvc6 = new System.Windows.Forms.Label();
            this.grpStaDvc6 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc6 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc6 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc6 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc6 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc6 = new System.Windows.Forms.RadioButton();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.txtSnoDvc6 = new System.Windows.Forms.TextBox();
            this.btnClearDvc6 = new System.Windows.Forms.Button();
            this.lblBaudDvc6 = new System.Windows.Forms.Label();
            this.lblComDvc6 = new System.Windows.Forms.Label();
            this.cboBaudDvc6 = new System.Windows.Forms.ComboBox();
            this.cboComDvc6 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc6 = new System.Windows.Forms.Button();
            this.tabPage_Device7 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc7 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc7 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc7 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc7 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc7 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc7 = new System.Windows.Forms.Label();
            this.lblFinalDvc7 = new System.Windows.Forms.Label();
            this.lblDevIdDvc7 = new System.Windows.Forms.Label();
            this.grpStaDvc7 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc7 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc7 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc7 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc7 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc7 = new System.Windows.Forms.RadioButton();
            this.button33 = new System.Windows.Forms.Button();
            this.button34 = new System.Windows.Forms.Button();
            this.txtSnoDvc7 = new System.Windows.Forms.TextBox();
            this.btnClearDvc7 = new System.Windows.Forms.Button();
            this.lblBaudDvc7 = new System.Windows.Forms.Label();
            this.lblComDvc7 = new System.Windows.Forms.Label();
            this.cboBaudDvc7 = new System.Windows.Forms.ComboBox();
            this.cboComDvc7 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc7 = new System.Windows.Forms.Button();
            this.tabPage_Device8 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc8 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc8 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc8 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc8 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc8 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc8 = new System.Windows.Forms.Label();
            this.lblFinalDvc8 = new System.Windows.Forms.Label();
            this.lblDevIdDvc8 = new System.Windows.Forms.Label();
            this.grpStaDvc8 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc8 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc8 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc8 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc8 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc8 = new System.Windows.Forms.RadioButton();
            this.button39 = new System.Windows.Forms.Button();
            this.button40 = new System.Windows.Forms.Button();
            this.txtSnoDvc8 = new System.Windows.Forms.TextBox();
            this.btnClearDvc8 = new System.Windows.Forms.Button();
            this.lblBaudDvc8 = new System.Windows.Forms.Label();
            this.lblComDvc8 = new System.Windows.Forms.Label();
            this.cboBaudDvc8 = new System.Windows.Forms.ComboBox();
            this.cboComDvc8 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc8 = new System.Windows.Forms.Button();
            this.tabPage_Device9 = new System.Windows.Forms.TabPage();
            this.lblSnoDvc9 = new System.Windows.Forms.Label();
            this.lblTestRmkDvc9 = new System.Windows.Forms.Label();
            this.txtTestRmkDvc9 = new System.Windows.Forms.TextBox();
            this.btnBurnStopDvc9 = new System.Windows.Forms.Button();
            this.btnBurn1hrDvc9 = new System.Windows.Forms.Button();
            this.lblBurnRestDvc9 = new System.Windows.Forms.Label();
            this.lblFinalDvc9 = new System.Windows.Forms.Label();
            this.lblDevIdDvc9 = new System.Windows.Forms.Label();
            this.grpStaDvc9 = new System.Windows.Forms.GroupBox();
            this.radSta4Dvc9 = new System.Windows.Forms.RadioButton();
            this.radSta3Dvc9 = new System.Windows.Forms.RadioButton();
            this.radSta2Dvc9 = new System.Windows.Forms.RadioButton();
            this.radSta1Dvc9 = new System.Windows.Forms.RadioButton();
            this.radSta0Dvc9 = new System.Windows.Forms.RadioButton();
            this.button45 = new System.Windows.Forms.Button();
            this.button46 = new System.Windows.Forms.Button();
            this.txtSnoDvc9 = new System.Windows.Forms.TextBox();
            this.btnClearDvc9 = new System.Windows.Forms.Button();
            this.lblBaudDvc9 = new System.Windows.Forms.Label();
            this.lblComDvc9 = new System.Windows.Forms.Label();
            this.cboBaudDvc9 = new System.Windows.Forms.ComboBox();
            this.cboComDvc9 = new System.Windows.Forms.ComboBox();
            this.btnTestDvc9 = new System.Windows.Forms.Button();
            this.tabPage_Test = new System.Windows.Forms.TabPage();
            this.btnCloseCom = new System.Windows.Forms.Button();
            this.chkTempRec = new System.Windows.Forms.CheckBox();
            this.lblTempChkTime = new System.Windows.Forms.Label();
            this.txtTempChkTime = new System.Windows.Forms.TextBox();
            this.txtBurnTime = new System.Windows.Forms.TextBox();
            this.lblBrunTimeSet = new System.Windows.Forms.Label();
            this.btnBurnTimeSet = new System.Windows.Forms.Button();
            this.cboComList = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.cboDevNo = new System.Windows.Forms.ComboBox();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboAtSetCmd = new System.Windows.Forms.ComboBox();
            this.btnAtSetCmdSend = new System.Windows.Forms.Button();
            this.btnBisRead = new System.Windows.Forms.Button();
            this.btnBisSet = new System.Windows.Forms.Button();
            this.btnStationSet = new System.Windows.Forms.Button();
            this.cboBis = new System.Windows.Forms.ComboBox();
            this.lblBisStatus = new System.Windows.Forms.Label();
            this.cboStaSet = new System.Windows.Forms.ComboBox();
            this.lblStaSet = new System.Windows.Forms.Label();
            this.lblCmdList = new System.Windows.Forms.Label();
            this.cboCmdList = new System.Windows.Forms.ComboBox();
            this.btnCmdSend = new System.Windows.Forms.Button();
            this.tbxAtReturn = new System.Windows.Forms.TextBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort3 = new System.IO.Ports.SerialPort(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.lblVerPs = new System.Windows.Forms.Label();
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.timer13 = new System.Windows.Forms.Timer(this.components);
            this.timer14 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadJSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer15 = new System.Windows.Forms.Timer(this.components);
            this.txtMac = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage_Main.SuspendLayout();
            this.grpStaDvc0.SuspendLayout();
            this.tabPage_Device1.SuspendLayout();
            this.grpStaDvc1.SuspendLayout();
            this.tabPage_Device2.SuspendLayout();
            this.grpStaDvc2.SuspendLayout();
            this.tabPage_Device3.SuspendLayout();
            this.grpStaDvc3.SuspendLayout();
            this.tabPage_Device4.SuspendLayout();
            this.grpStaDvc4.SuspendLayout();
            this.tabPage_Device5.SuspendLayout();
            this.grpStaDvc5.SuspendLayout();
            this.tabPage_Device6.SuspendLayout();
            this.grpStaDvc6.SuspendLayout();
            this.tabPage_Device7.SuspendLayout();
            this.grpStaDvc7.SuspendLayout();
            this.tabPage_Device8.SuspendLayout();
            this.grpStaDvc8.SuspendLayout();
            this.tabPage_Device9.SuspendLayout();
            this.grpStaDvc9.SuspendLayout();
            this.tabPage_Test.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // richBox
            // 
            this.richBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.richBox.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.richBox.Location = new System.Drawing.Point(456, 58);
            this.richBox.Margin = new System.Windows.Forms.Padding(4);
            this.richBox.Name = "richBox";
            this.richBox.ReadOnly = true;
            this.richBox.Size = new System.Drawing.Size(469, 444);
            this.richBox.TabIndex = 11;
            this.richBox.Text = "";
            this.richBox.TextChanged += new System.EventHandler(this.richBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Main);
            this.tabControl1.Controls.Add(this.tabPage_Device1);
            this.tabControl1.Controls.Add(this.tabPage_Device2);
            this.tabControl1.Controls.Add(this.tabPage_Device3);
            this.tabControl1.Controls.Add(this.tabPage_Device4);
            this.tabControl1.Controls.Add(this.tabPage_Device5);
            this.tabControl1.Controls.Add(this.tabPage_Device6);
            this.tabControl1.Controls.Add(this.tabPage_Device7);
            this.tabControl1.Controls.Add(this.tabPage_Device8);
            this.tabControl1.Controls.Add(this.tabPage_Device9);
            this.tabControl1.Controls.Add(this.tabPage_Test);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(437, 470);
            this.tabControl1.TabIndex = 23;
            // 
            // tabPage_Main
            // 
            this.tabPage_Main.Controls.Add(this.btnBurnAll);
            this.tabPage_Main.Controls.Add(this.cboComDvc0);
            this.tabPage_Main.Controls.Add(this.lblDevIdDvc0);
            this.tabPage_Main.Controls.Add(this.lblTestRmkDvc0);
            this.tabPage_Main.Controls.Add(this.txtTestRmkDvc0);
            this.tabPage_Main.Controls.Add(this.btnBurnStopDvc0);
            this.tabPage_Main.Controls.Add(this.lblSWver);
            this.tabPage_Main.Controls.Add(this.lblBurnRestDvc0);
            this.tabPage_Main.Controls.Add(this.lblTempDvc0);
            this.tabPage_Main.Controls.Add(this.btnTempReadDvc0);
            this.tabPage_Main.Controls.Add(this.txtTempDvc0);
            this.tabPage_Main.Controls.Add(this.btnBurn1hrDvc0);
            this.tabPage_Main.Controls.Add(this.btnMemsReadDvc0);
            this.tabPage_Main.Controls.Add(this.btnMemsSetDvc0);
            this.tabPage_Main.Controls.Add(this.cboSta0optDvc0);
            this.tabPage_Main.Controls.Add(this.lblSta0optDvc0);
            this.tabPage_Main.Controls.Add(this.lblPdGainSetD0);
            this.tabPage_Main.Controls.Add(this.cboPdGainSetDvc0);
            this.tabPage_Main.Controls.Add(this.grpStaDvc0);
            this.tabPage_Main.Controls.Add(this.lblFinalDvc0);
            this.tabPage_Main.Controls.Add(this.lblSnoDvc0);
            this.tabPage_Main.Controls.Add(this.txtSnoDvc0);
            this.tabPage_Main.Controls.Add(this.btnClearDvc0);
            this.tabPage_Main.Controls.Add(this.lblBaudDvc0);
            this.tabPage_Main.Controls.Add(this.lblComDvc0);
            this.tabPage_Main.Controls.Add(this.cboBaudDvc0);
            this.tabPage_Main.Controls.Add(this.btnTestDvc0);
            this.tabPage_Main.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Main.Name = "tabPage_Main";
            this.tabPage_Main.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Main.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Main.TabIndex = 0;
            this.tabPage_Main.Text = "Device0";
            this.tabPage_Main.UseVisualStyleBackColor = true;
            // 
            // btnBurnAll
            // 
            this.btnBurnAll.Enabled = false;
            this.btnBurnAll.Location = new System.Drawing.Point(48, 220);
            this.btnBurnAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnAll.Name = "btnBurnAll";
            this.btnBurnAll.Size = new System.Drawing.Size(93, 40);
            this.btnBurnAll.TabIndex = 80;
            this.btnBurnAll.Text = "Burn-in All";
            this.btnBurnAll.UseVisualStyleBackColor = true;
            this.btnBurnAll.Click += new System.EventHandler(this.btnBurnAll_Click);
            // 
            // cboComDvc0
            // 
            this.cboComDvc0.FormattingEnabled = true;
            this.cboComDvc0.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc0.Name = "cboComDvc0";
            this.cboComDvc0.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc0.TabIndex = 78;
            // 
            // lblDevIdDvc0
            // 
            this.lblDevIdDvc0.AutoSize = true;
            this.lblDevIdDvc0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc0.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc0.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc0.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc0.Name = "lblDevIdDvc0";
            this.lblDevIdDvc0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc0.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc0.TabIndex = 77;
            this.lblDevIdDvc0.Text = "Device_ID";
            this.lblDevIdDvc0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTestRmkDvc0
            // 
            this.lblTestRmkDvc0.AutoSize = true;
            this.lblTestRmkDvc0.Location = new System.Drawing.Point(157, 380);
            this.lblTestRmkDvc0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc0.Name = "lblTestRmkDvc0";
            this.lblTestRmkDvc0.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc0.TabIndex = 76;
            this.lblTestRmkDvc0.Text = "備註欄";
            // 
            // txtTestRmkDvc0
            // 
            this.txtTestRmkDvc0.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc0.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc0.Name = "txtTestRmkDvc0";
            this.txtTestRmkDvc0.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc0.TabIndex = 75;
            // 
            // btnBurnStopDvc0
            // 
            this.btnBurnStopDvc0.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc0.Name = "btnBurnStopDvc0";
            this.btnBurnStopDvc0.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc0.TabIndex = 74;
            this.btnBurnStopDvc0.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc0.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc0.Click += new System.EventHandler(this.btnBurnStop_Click);
            // 
            // lblSWver
            // 
            this.lblSWver.AutoSize = true;
            this.lblSWver.Location = new System.Drawing.Point(11, 395);
            this.lblSWver.Name = "lblSWver";
            this.lblSWver.Size = new System.Drawing.Size(225, 15);
            this.lblSWver.TabIndex = 72;
            this.lblSWver.Text = "SW_ver_date/matching FW_ver_build";
            this.lblSWver.Visible = false;
            // 
            // lblBurnRestDvc0
            // 
            this.lblBurnRestDvc0.AutoSize = true;
            this.lblBurnRestDvc0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc0.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc0.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc0.Name = "lblBurnRestDvc0";
            this.lblBurnRestDvc0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc0.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc0.TabIndex = 73;
            this.lblBurnRestDvc0.Text = "Burn-in time";
            this.lblBurnRestDvc0.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTempDvc0
            // 
            this.lblTempDvc0.AutoSize = true;
            this.lblTempDvc0.Location = new System.Drawing.Point(215, 304);
            this.lblTempDvc0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempDvc0.Name = "lblTempDvc0";
            this.lblTempDvc0.Size = new System.Drawing.Size(56, 15);
            this.lblTempDvc0.TabIndex = 64;
            this.lblTempDvc0.Text = "溫度(C)";
            // 
            // btnTempReadDvc0
            // 
            this.btnTempReadDvc0.Enabled = false;
            this.btnTempReadDvc0.Location = new System.Drawing.Point(351, 298);
            this.btnTempReadDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTempReadDvc0.Name = "btnTempReadDvc0";
            this.btnTempReadDvc0.Size = new System.Drawing.Size(72, 26);
            this.btnTempReadDvc0.TabIndex = 63;
            this.btnTempReadDvc0.Text = "Start";
            this.btnTempReadDvc0.UseVisualStyleBackColor = true;
            this.btnTempReadDvc0.Click += new System.EventHandler(this.btnTempRead_Click);
            // 
            // txtTempDvc0
            // 
            this.txtTempDvc0.Location = new System.Drawing.Point(277, 299);
            this.txtTempDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempDvc0.Name = "txtTempDvc0";
            this.txtTempDvc0.Size = new System.Drawing.Size(67, 25);
            this.txtTempDvc0.TabIndex = 62;
            this.txtTempDvc0.Text = "<temp(C)>";
            this.txtTempDvc0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBurn1hrDvc0
            // 
            this.btnBurn1hrDvc0.Enabled = false;
            this.btnBurn1hrDvc0.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc0.Name = "btnBurn1hrDvc0";
            this.btnBurn1hrDvc0.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc0.TabIndex = 57;
            this.btnBurn1hrDvc0.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc0.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc0.Click += new System.EventHandler(this.btnBurn1hr_Click);
            // 
            // btnMemsReadDvc0
            // 
            this.btnMemsReadDvc0.Enabled = false;
            this.btnMemsReadDvc0.Location = new System.Drawing.Point(215, 214);
            this.btnMemsReadDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemsReadDvc0.Name = "btnMemsReadDvc0";
            this.btnMemsReadDvc0.Size = new System.Drawing.Size(105, 32);
            this.btnMemsReadDvc0.TabIndex = 56;
            this.btnMemsReadDvc0.Text = "MEMS_Read";
            this.btnMemsReadDvc0.UseVisualStyleBackColor = true;
            this.btnMemsReadDvc0.Click += new System.EventHandler(this.btnMemsRead_Click);
            // 
            // btnMemsSetDvc0
            // 
            this.btnMemsSetDvc0.Enabled = false;
            this.btnMemsSetDvc0.Location = new System.Drawing.Point(325, 214);
            this.btnMemsSetDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemsSetDvc0.Name = "btnMemsSetDvc0";
            this.btnMemsSetDvc0.Size = new System.Drawing.Size(97, 32);
            this.btnMemsSetDvc0.TabIndex = 55;
            this.btnMemsSetDvc0.Text = "MEMS_Set";
            this.btnMemsSetDvc0.UseVisualStyleBackColor = true;
            this.btnMemsSetDvc0.Click += new System.EventHandler(this.btnMemsSet_Click);
            // 
            // cboSta0optDvc0
            // 
            this.cboSta0optDvc0.Enabled = false;
            this.cboSta0optDvc0.FormattingEnabled = true;
            this.cboSta0optDvc0.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboSta0optDvc0.Location = new System.Drawing.Point(101, 214);
            this.cboSta0optDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSta0optDvc0.Name = "cboSta0optDvc0";
            this.cboSta0optDvc0.Size = new System.Drawing.Size(107, 23);
            this.cboSta0optDvc0.TabIndex = 52;
            this.cboSta0optDvc0.Text = "0";
            // 
            // lblSta0optDvc0
            // 
            this.lblSta0optDvc0.AutoSize = true;
            this.lblSta0optDvc0.Location = new System.Drawing.Point(13, 218);
            this.lblSta0optDvc0.Name = "lblSta0optDvc0";
            this.lblSta0optDvc0.Size = new System.Drawing.Size(86, 15);
            this.lblSta0optDvc0.TabIndex = 51;
            this.lblSta0optDvc0.Text = "Sta_0 MEMS";
            // 
            // lblPdGainSetD0
            // 
            this.lblPdGainSetD0.AutoSize = true;
            this.lblPdGainSetD0.Location = new System.Drawing.Point(11, 244);
            this.lblPdGainSetD0.Name = "lblPdGainSetD0";
            this.lblPdGainSetD0.Size = new System.Drawing.Size(89, 15);
            this.lblPdGainSetD0.TabIndex = 50;
            this.lblPdGainSetD0.Text = "PD_GAIN Set";
            this.lblPdGainSetD0.Visible = false;
            // 
            // cboPdGainSetDvc0
            // 
            this.cboPdGainSetDvc0.FormattingEnabled = true;
            this.cboPdGainSetDvc0.Items.AddRange(new object[] {
            "0",
            "7"});
            this.cboPdGainSetDvc0.Location = new System.Drawing.Point(101, 241);
            this.cboPdGainSetDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPdGainSetDvc0.Name = "cboPdGainSetDvc0";
            this.cboPdGainSetDvc0.Size = new System.Drawing.Size(107, 23);
            this.cboPdGainSetDvc0.TabIndex = 49;
            this.cboPdGainSetDvc0.Text = "0";
            this.cboPdGainSetDvc0.Visible = false;
            // 
            // grpStaDvc0
            // 
            this.grpStaDvc0.Controls.Add(this.radSta4Dvc0);
            this.grpStaDvc0.Controls.Add(this.radSta3Dvc0);
            this.grpStaDvc0.Controls.Add(this.radSta2Dvc0);
            this.grpStaDvc0.Controls.Add(this.radSta1Dvc0);
            this.grpStaDvc0.Controls.Add(this.radSta0Dvc0);
            this.grpStaDvc0.Controls.Add(this.button2);
            this.grpStaDvc0.Controls.Add(this.button1);
            this.grpStaDvc0.Enabled = false;
            this.grpStaDvc0.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc0.Name = "grpStaDvc0";
            this.grpStaDvc0.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc0.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc0.TabIndex = 48;
            this.grpStaDvc0.TabStop = false;
            this.grpStaDvc0.Text = "station 站別";
            // 
            // radSta4Dvc0
            // 
            this.radSta4Dvc0.AutoSize = true;
            this.radSta4Dvc0.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc0.Name = "radSta4Dvc0";
            this.radSta4Dvc0.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc0.TabIndex = 5;
            this.radSta4Dvc0.Text = "Station 4";
            this.radSta4Dvc0.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc0
            // 
            this.radSta3Dvc0.AutoSize = true;
            this.radSta3Dvc0.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc0.Name = "radSta3Dvc0";
            this.radSta3Dvc0.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc0.TabIndex = 4;
            this.radSta3Dvc0.Text = "Station 3";
            this.radSta3Dvc0.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc0
            // 
            this.radSta2Dvc0.AutoSize = true;
            this.radSta2Dvc0.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc0.Name = "radSta2Dvc0";
            this.radSta2Dvc0.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc0.TabIndex = 3;
            this.radSta2Dvc0.Text = "Station 2";
            this.radSta2Dvc0.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc0
            // 
            this.radSta1Dvc0.AutoSize = true;
            this.radSta1Dvc0.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc0.Name = "radSta1Dvc0";
            this.radSta1Dvc0.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc0.TabIndex = 2;
            this.radSta1Dvc0.Text = "Station 1";
            this.radSta1Dvc0.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc0
            // 
            this.radSta0Dvc0.AutoSize = true;
            this.radSta0Dvc0.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc0.Name = "radSta0Dvc0";
            this.radSta0Dvc0.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc0.TabIndex = 0;
            this.radSta0Dvc0.Text = "Station 0";
            this.radSta0Dvc0.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, -64);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, -64);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 58);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenPort";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblFinalDvc0
            // 
            this.lblFinalDvc0.AutoSize = true;
            this.lblFinalDvc0.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc0.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc0.Name = "lblFinalDvc0";
            this.lblFinalDvc0.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc0.TabIndex = 47;
            this.lblFinalDvc0.Text = "Final result";
            // 
            // lblSnoDvc0
            // 
            this.lblSnoDvc0.AutoSize = true;
            this.lblSnoDvc0.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc0.Name = "lblSnoDvc0";
            this.lblSnoDvc0.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc0.TabIndex = 46;
            this.lblSnoDvc0.Text = "Serial No.";
            // 
            // txtSnoDvc0
            // 
            this.txtSnoDvc0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc0.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc0.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc0.Name = "txtSnoDvc0";
            this.txtSnoDvc0.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc0.TabIndex = 39;
            this.txtSnoDvc0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc0_MouseClick);
            this.txtSnoDvc0.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_KeyDown);
            // 
            // btnClearDvc0
            // 
            this.btnClearDvc0.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc0.Name = "btnClearDvc0";
            this.btnClearDvc0.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc0.TabIndex = 45;
            this.btnClearDvc0.Text = "Clear";
            this.btnClearDvc0.UseVisualStyleBackColor = true;
            this.btnClearDvc0.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // lblBaudDvc0
            // 
            this.lblBaudDvc0.AutoSize = true;
            this.lblBaudDvc0.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc0.Name = "lblBaudDvc0";
            this.lblBaudDvc0.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc0.TabIndex = 44;
            this.lblBaudDvc0.Text = "BaudRate";
            // 
            // lblComDvc0
            // 
            this.lblComDvc0.AutoSize = true;
            this.lblComDvc0.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc0.Name = "lblComDvc0";
            this.lblComDvc0.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc0.TabIndex = 43;
            this.lblComDvc0.Text = "COM";
            // 
            // cboBaudDvc0
            // 
            this.cboBaudDvc0.Enabled = false;
            this.cboBaudDvc0.FormattingEnabled = true;
            this.cboBaudDvc0.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc0.Name = "cboBaudDvc0";
            this.cboBaudDvc0.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc0.TabIndex = 42;
            // 
            // btnTestDvc0
            // 
            this.btnTestDvc0.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc0.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc0.Name = "btnTestDvc0";
            this.btnTestDvc0.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc0.TabIndex = 40;
            this.btnTestDvc0.Text = "Test";
            this.btnTestDvc0.UseVisualStyleBackColor = true;
            this.btnTestDvc0.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // tabPage_Device1
            // 
            this.tabPage_Device1.Controls.Add(this.lblTestRmkDvc1);
            this.tabPage_Device1.Controls.Add(this.txtTestRmkDvc1);
            this.tabPage_Device1.Controls.Add(this.btnBurnStopDvc1);
            this.tabPage_Device1.Controls.Add(this.btnBurn1hrDvc1);
            this.tabPage_Device1.Controls.Add(this.lblBurnRestDvc1);
            this.tabPage_Device1.Controls.Add(this.lblFinalDvc1);
            this.tabPage_Device1.Controls.Add(this.lblDevIdDvc1);
            this.tabPage_Device1.Controls.Add(this.grpStaDvc1);
            this.tabPage_Device1.Controls.Add(this.lblSnoDvc1);
            this.tabPage_Device1.Controls.Add(this.txtSnoDvc1);
            this.tabPage_Device1.Controls.Add(this.btnClearDvc1);
            this.tabPage_Device1.Controls.Add(this.lblBaudDvc1);
            this.tabPage_Device1.Controls.Add(this.lblComDvc1);
            this.tabPage_Device1.Controls.Add(this.cboBaudDvc1);
            this.tabPage_Device1.Controls.Add(this.cboComDvc1);
            this.tabPage_Device1.Controls.Add(this.btnTestDvc1);
            this.tabPage_Device1.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device1.Name = "tabPage_Device1";
            this.tabPage_Device1.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device1.TabIndex = 2;
            this.tabPage_Device1.Text = "Device1";
            this.tabPage_Device1.UseVisualStyleBackColor = true;
            // 
            // lblTestRmkDvc1
            // 
            this.lblTestRmkDvc1.AutoSize = true;
            this.lblTestRmkDvc1.Location = new System.Drawing.Point(157, 380);
            this.lblTestRmkDvc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc1.Name = "lblTestRmkDvc1";
            this.lblTestRmkDvc1.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc1.TabIndex = 93;
            this.lblTestRmkDvc1.Text = "備註欄";
            // 
            // txtTestRmkDvc1
            // 
            this.txtTestRmkDvc1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc1.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc1.Name = "txtTestRmkDvc1";
            this.txtTestRmkDvc1.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc1.TabIndex = 92;
            // 
            // btnBurnStopDvc1
            // 
            this.btnBurnStopDvc1.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc1.Name = "btnBurnStopDvc1";
            this.btnBurnStopDvc1.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc1.TabIndex = 91;
            this.btnBurnStopDvc1.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc1.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc1.Click += new System.EventHandler(this.btnBurnStopDvc1_Click);
            // 
            // btnBurn1hrDvc1
            // 
            this.btnBurn1hrDvc1.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc1.Name = "btnBurn1hrDvc1";
            this.btnBurn1hrDvc1.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc1.TabIndex = 90;
            this.btnBurn1hrDvc1.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc1.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc1.Click += new System.EventHandler(this.btnBurn1hrDvc1_Click);
            // 
            // lblBurnRestDvc1
            // 
            this.lblBurnRestDvc1.AutoSize = true;
            this.lblBurnRestDvc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc1.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc1.Name = "lblBurnRestDvc1";
            this.lblBurnRestDvc1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc1.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc1.TabIndex = 89;
            this.lblBurnRestDvc1.Text = "Burn-in time";
            this.lblBurnRestDvc1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFinalDvc1
            // 
            this.lblFinalDvc1.AutoSize = true;
            this.lblFinalDvc1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc1.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc1.Name = "lblFinalDvc1";
            this.lblFinalDvc1.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc1.TabIndex = 88;
            this.lblFinalDvc1.Text = "Final result";
            // 
            // lblDevIdDvc1
            // 
            this.lblDevIdDvc1.AutoSize = true;
            this.lblDevIdDvc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc1.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc1.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc1.Name = "lblDevIdDvc1";
            this.lblDevIdDvc1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc1.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc1.TabIndex = 87;
            this.lblDevIdDvc1.Text = "Device_ID";
            this.lblDevIdDvc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc1
            // 
            this.grpStaDvc1.Controls.Add(this.radSta4Dvc1);
            this.grpStaDvc1.Controls.Add(this.radSta3Dvc1);
            this.grpStaDvc1.Controls.Add(this.radSta2Dvc1);
            this.grpStaDvc1.Controls.Add(this.radSta1Dvc1);
            this.grpStaDvc1.Controls.Add(this.radSta0Dvc1);
            this.grpStaDvc1.Controls.Add(this.button3);
            this.grpStaDvc1.Controls.Add(this.button4);
            this.grpStaDvc1.Enabled = false;
            this.grpStaDvc1.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc1.Name = "grpStaDvc1";
            this.grpStaDvc1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc1.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc1.TabIndex = 86;
            this.grpStaDvc1.TabStop = false;
            this.grpStaDvc1.Text = "station 站別";
            // 
            // radSta4Dvc1
            // 
            this.radSta4Dvc1.AutoSize = true;
            this.radSta4Dvc1.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc1.Name = "radSta4Dvc1";
            this.radSta4Dvc1.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc1.TabIndex = 5;
            this.radSta4Dvc1.Text = "Station 4";
            this.radSta4Dvc1.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc1
            // 
            this.radSta3Dvc1.AutoSize = true;
            this.radSta3Dvc1.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc1.Name = "radSta3Dvc1";
            this.radSta3Dvc1.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc1.TabIndex = 4;
            this.radSta3Dvc1.Text = "Station 3";
            this.radSta3Dvc1.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc1
            // 
            this.radSta2Dvc1.AutoSize = true;
            this.radSta2Dvc1.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc1.Name = "radSta2Dvc1";
            this.radSta2Dvc1.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc1.TabIndex = 3;
            this.radSta2Dvc1.Text = "Station 2";
            this.radSta2Dvc1.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc1
            // 
            this.radSta1Dvc1.AutoSize = true;
            this.radSta1Dvc1.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc1.Name = "radSta1Dvc1";
            this.radSta1Dvc1.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc1.TabIndex = 2;
            this.radSta1Dvc1.Text = "Station 1";
            this.radSta1Dvc1.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc1
            // 
            this.radSta0Dvc1.AutoSize = true;
            this.radSta0Dvc1.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc1.Name = "radSta0Dvc1";
            this.radSta0Dvc1.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc1.TabIndex = 0;
            this.radSta0Dvc1.Text = "Station 0";
            this.radSta0Dvc1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(212, -64);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 58);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(0, -64);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 58);
            this.button4.TabIndex = 0;
            this.button4.Text = "OpenPort";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc1
            // 
            this.lblSnoDvc1.AutoSize = true;
            this.lblSnoDvc1.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc1.Name = "lblSnoDvc1";
            this.lblSnoDvc1.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc1.TabIndex = 85;
            this.lblSnoDvc1.Text = "Serial No.";
            // 
            // txtSnoDvc1
            // 
            this.txtSnoDvc1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc1.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc1.Name = "txtSnoDvc1";
            this.txtSnoDvc1.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc1.TabIndex = 78;
            this.txtSnoDvc1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc1_MouseClick);
            // 
            // btnClearDvc1
            // 
            this.btnClearDvc1.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc1.Name = "btnClearDvc1";
            this.btnClearDvc1.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc1.TabIndex = 84;
            this.btnClearDvc1.Text = "Clear";
            this.btnClearDvc1.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc1
            // 
            this.lblBaudDvc1.AutoSize = true;
            this.lblBaudDvc1.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc1.Name = "lblBaudDvc1";
            this.lblBaudDvc1.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc1.TabIndex = 83;
            this.lblBaudDvc1.Text = "BaudRate";
            // 
            // lblComDvc1
            // 
            this.lblComDvc1.AutoSize = true;
            this.lblComDvc1.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc1.Name = "lblComDvc1";
            this.lblComDvc1.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc1.TabIndex = 82;
            this.lblComDvc1.Text = "COM";
            // 
            // cboBaudDvc1
            // 
            this.cboBaudDvc1.Enabled = false;
            this.cboBaudDvc1.FormattingEnabled = true;
            this.cboBaudDvc1.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc1.Name = "cboBaudDvc1";
            this.cboBaudDvc1.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc1.TabIndex = 81;
            // 
            // cboComDvc1
            // 
            this.cboComDvc1.FormattingEnabled = true;
            this.cboComDvc1.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc1.Name = "cboComDvc1";
            this.cboComDvc1.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc1.TabIndex = 80;
            // 
            // btnTestDvc1
            // 
            this.btnTestDvc1.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc1.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc1.Name = "btnTestDvc1";
            this.btnTestDvc1.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc1.TabIndex = 79;
            this.btnTestDvc1.Text = "Test";
            this.btnTestDvc1.UseVisualStyleBackColor = true;
            this.btnTestDvc1.Click += new System.EventHandler(this.btnTestDvc1_Click);
            // 
            // tabPage_Device2
            // 
            this.tabPage_Device2.Controls.Add(this.lblTestRmkDvc2);
            this.tabPage_Device2.Controls.Add(this.txtTestRmkDvc2);
            this.tabPage_Device2.Controls.Add(this.btnBurnStopDvc2);
            this.tabPage_Device2.Controls.Add(this.btnBurn1hrDvc2);
            this.tabPage_Device2.Controls.Add(this.lblBurnRestDvc2);
            this.tabPage_Device2.Controls.Add(this.lblFinalDvc2);
            this.tabPage_Device2.Controls.Add(this.lblDevIdDvc2);
            this.tabPage_Device2.Controls.Add(this.grpStaDvc2);
            this.tabPage_Device2.Controls.Add(this.lblSnoDvc2);
            this.tabPage_Device2.Controls.Add(this.txtSnoDvc2);
            this.tabPage_Device2.Controls.Add(this.btnClearDvc2);
            this.tabPage_Device2.Controls.Add(this.lblBaudDvc2);
            this.tabPage_Device2.Controls.Add(this.lblComDvc2);
            this.tabPage_Device2.Controls.Add(this.cboBaudDvc2);
            this.tabPage_Device2.Controls.Add(this.cboComDvc2);
            this.tabPage_Device2.Controls.Add(this.btnTestDvc2);
            this.tabPage_Device2.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device2.Name = "tabPage_Device2";
            this.tabPage_Device2.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device2.TabIndex = 3;
            this.tabPage_Device2.Text = "Device2";
            this.tabPage_Device2.UseVisualStyleBackColor = true;
            // 
            // lblTestRmkDvc2
            // 
            this.lblTestRmkDvc2.AutoSize = true;
            this.lblTestRmkDvc2.Location = new System.Drawing.Point(157, 380);
            this.lblTestRmkDvc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc2.Name = "lblTestRmkDvc2";
            this.lblTestRmkDvc2.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc2.TabIndex = 109;
            this.lblTestRmkDvc2.Text = "備註欄";
            // 
            // txtTestRmkDvc2
            // 
            this.txtTestRmkDvc2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc2.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc2.Name = "txtTestRmkDvc2";
            this.txtTestRmkDvc2.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc2.TabIndex = 108;
            // 
            // btnBurnStopDvc2
            // 
            this.btnBurnStopDvc2.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc2.Name = "btnBurnStopDvc2";
            this.btnBurnStopDvc2.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc2.TabIndex = 107;
            this.btnBurnStopDvc2.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc2.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc2.Click += new System.EventHandler(this.btnBurnStopDvc2_Click);
            // 
            // btnBurn1hrDvc2
            // 
            this.btnBurn1hrDvc2.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc2.Name = "btnBurn1hrDvc2";
            this.btnBurn1hrDvc2.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc2.TabIndex = 106;
            this.btnBurn1hrDvc2.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc2.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc2.Click += new System.EventHandler(this.btnBurn1hrDvc2_Click);
            // 
            // lblBurnRestDvc2
            // 
            this.lblBurnRestDvc2.AutoSize = true;
            this.lblBurnRestDvc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc2.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc2.Name = "lblBurnRestDvc2";
            this.lblBurnRestDvc2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc2.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc2.TabIndex = 105;
            this.lblBurnRestDvc2.Text = "Burn-in time";
            this.lblBurnRestDvc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc2
            // 
            this.lblFinalDvc2.AutoSize = true;
            this.lblFinalDvc2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc2.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc2.Name = "lblFinalDvc2";
            this.lblFinalDvc2.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc2.TabIndex = 104;
            this.lblFinalDvc2.Text = "Final result";
            // 
            // lblDevIdDvc2
            // 
            this.lblDevIdDvc2.AutoSize = true;
            this.lblDevIdDvc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc2.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc2.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc2.Name = "lblDevIdDvc2";
            this.lblDevIdDvc2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc2.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc2.TabIndex = 103;
            this.lblDevIdDvc2.Text = "Device_ID";
            this.lblDevIdDvc2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc2
            // 
            this.grpStaDvc2.Controls.Add(this.radSta4Dvc2);
            this.grpStaDvc2.Controls.Add(this.radSta3Dvc2);
            this.grpStaDvc2.Controls.Add(this.radSta2Dvc2);
            this.grpStaDvc2.Controls.Add(this.radSta1Dvc2);
            this.grpStaDvc2.Controls.Add(this.radSta0Dvc2);
            this.grpStaDvc2.Controls.Add(this.button7);
            this.grpStaDvc2.Controls.Add(this.button8);
            this.grpStaDvc2.Enabled = false;
            this.grpStaDvc2.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc2.Name = "grpStaDvc2";
            this.grpStaDvc2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc2.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc2.TabIndex = 102;
            this.grpStaDvc2.TabStop = false;
            this.grpStaDvc2.Text = "station 站別";
            // 
            // radSta4Dvc2
            // 
            this.radSta4Dvc2.AutoSize = true;
            this.radSta4Dvc2.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc2.Name = "radSta4Dvc2";
            this.radSta4Dvc2.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc2.TabIndex = 5;
            this.radSta4Dvc2.Text = "Station 4";
            this.radSta4Dvc2.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc2
            // 
            this.radSta3Dvc2.AutoSize = true;
            this.radSta3Dvc2.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc2.Name = "radSta3Dvc2";
            this.radSta3Dvc2.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc2.TabIndex = 4;
            this.radSta3Dvc2.Text = "Station 3";
            this.radSta3Dvc2.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc2
            // 
            this.radSta2Dvc2.AutoSize = true;
            this.radSta2Dvc2.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc2.Name = "radSta2Dvc2";
            this.radSta2Dvc2.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc2.TabIndex = 3;
            this.radSta2Dvc2.Text = "Station 2";
            this.radSta2Dvc2.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc2
            // 
            this.radSta1Dvc2.AutoSize = true;
            this.radSta1Dvc2.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc2.Name = "radSta1Dvc2";
            this.radSta1Dvc2.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc2.TabIndex = 2;
            this.radSta1Dvc2.Text = "Station 1";
            this.radSta1Dvc2.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc2
            // 
            this.radSta0Dvc2.AutoSize = true;
            this.radSta0Dvc2.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc2.Name = "radSta0Dvc2";
            this.radSta0Dvc2.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc2.TabIndex = 0;
            this.radSta0Dvc2.Text = "Station 0";
            this.radSta0Dvc2.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(212, -64);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(195, 58);
            this.button7.TabIndex = 10;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(0, -64);
            this.button8.Margin = new System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(195, 58);
            this.button8.TabIndex = 0;
            this.button8.Text = "OpenPort";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc2
            // 
            this.lblSnoDvc2.AutoSize = true;
            this.lblSnoDvc2.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc2.Name = "lblSnoDvc2";
            this.lblSnoDvc2.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc2.TabIndex = 101;
            this.lblSnoDvc2.Text = "Serial No.";
            // 
            // txtSnoDvc2
            // 
            this.txtSnoDvc2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc2.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc2.Name = "txtSnoDvc2";
            this.txtSnoDvc2.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc2.TabIndex = 94;
            this.txtSnoDvc2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc2_MouseClick);
            // 
            // btnClearDvc2
            // 
            this.btnClearDvc2.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc2.Name = "btnClearDvc2";
            this.btnClearDvc2.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc2.TabIndex = 100;
            this.btnClearDvc2.Text = "Clear";
            this.btnClearDvc2.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc2
            // 
            this.lblBaudDvc2.AutoSize = true;
            this.lblBaudDvc2.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc2.Name = "lblBaudDvc2";
            this.lblBaudDvc2.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc2.TabIndex = 99;
            this.lblBaudDvc2.Text = "BaudRate";
            // 
            // lblComDvc2
            // 
            this.lblComDvc2.AutoSize = true;
            this.lblComDvc2.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc2.Name = "lblComDvc2";
            this.lblComDvc2.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc2.TabIndex = 98;
            this.lblComDvc2.Text = "COM";
            // 
            // cboBaudDvc2
            // 
            this.cboBaudDvc2.Enabled = false;
            this.cboBaudDvc2.FormattingEnabled = true;
            this.cboBaudDvc2.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc2.Name = "cboBaudDvc2";
            this.cboBaudDvc2.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc2.TabIndex = 97;
            // 
            // cboComDvc2
            // 
            this.cboComDvc2.FormattingEnabled = true;
            this.cboComDvc2.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc2.Name = "cboComDvc2";
            this.cboComDvc2.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc2.TabIndex = 96;
            // 
            // btnTestDvc2
            // 
            this.btnTestDvc2.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc2.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc2.Name = "btnTestDvc2";
            this.btnTestDvc2.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc2.TabIndex = 95;
            this.btnTestDvc2.Text = "Test";
            this.btnTestDvc2.UseVisualStyleBackColor = true;
            this.btnTestDvc2.Click += new System.EventHandler(this.btnTestDvc2_Click);
            // 
            // tabPage_Device3
            // 
            this.tabPage_Device3.Controls.Add(this.lblTestRmkDvc3);
            this.tabPage_Device3.Controls.Add(this.txtTestRmkDvc3);
            this.tabPage_Device3.Controls.Add(this.btnBurnStopDvc3);
            this.tabPage_Device3.Controls.Add(this.btnBurn1hrDvc3);
            this.tabPage_Device3.Controls.Add(this.lblBurnRestDvc3);
            this.tabPage_Device3.Controls.Add(this.lblFinalDvc3);
            this.tabPage_Device3.Controls.Add(this.lblDevIdDvc3);
            this.tabPage_Device3.Controls.Add(this.grpStaDvc3);
            this.tabPage_Device3.Controls.Add(this.lblSnoDvc3);
            this.tabPage_Device3.Controls.Add(this.txtSnoDvc3);
            this.tabPage_Device3.Controls.Add(this.btnClearDvc3);
            this.tabPage_Device3.Controls.Add(this.lblBaudDvc3);
            this.tabPage_Device3.Controls.Add(this.lblComDvc3);
            this.tabPage_Device3.Controls.Add(this.cboBaudDvc3);
            this.tabPage_Device3.Controls.Add(this.cboComDvc3);
            this.tabPage_Device3.Controls.Add(this.btnTestDvc3);
            this.tabPage_Device3.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device3.Name = "tabPage_Device3";
            this.tabPage_Device3.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device3.TabIndex = 4;
            this.tabPage_Device3.Text = "Device3";
            this.tabPage_Device3.UseVisualStyleBackColor = true;
            // 
            // lblTestRmkDvc3
            // 
            this.lblTestRmkDvc3.AutoSize = true;
            this.lblTestRmkDvc3.Location = new System.Drawing.Point(156, 380);
            this.lblTestRmkDvc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc3.Name = "lblTestRmkDvc3";
            this.lblTestRmkDvc3.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc3.TabIndex = 125;
            this.lblTestRmkDvc3.Text = "備註欄";
            // 
            // txtTestRmkDvc3
            // 
            this.txtTestRmkDvc3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc3.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc3.Name = "txtTestRmkDvc3";
            this.txtTestRmkDvc3.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc3.TabIndex = 124;
            // 
            // btnBurnStopDvc3
            // 
            this.btnBurnStopDvc3.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc3.Name = "btnBurnStopDvc3";
            this.btnBurnStopDvc3.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc3.TabIndex = 123;
            this.btnBurnStopDvc3.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc3.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc3.Click += new System.EventHandler(this.btnBurnStopDvc3_Click);
            // 
            // btnBurn1hrDvc3
            // 
            this.btnBurn1hrDvc3.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc3.Name = "btnBurn1hrDvc3";
            this.btnBurn1hrDvc3.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc3.TabIndex = 122;
            this.btnBurn1hrDvc3.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc3.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc3.Click += new System.EventHandler(this.btnBurn1hrDvc3_Click);
            // 
            // lblBurnRestDvc3
            // 
            this.lblBurnRestDvc3.AutoSize = true;
            this.lblBurnRestDvc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc3.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc3.Name = "lblBurnRestDvc3";
            this.lblBurnRestDvc3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc3.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc3.TabIndex = 121;
            this.lblBurnRestDvc3.Text = "Burn-in time";
            this.lblBurnRestDvc3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc3
            // 
            this.lblFinalDvc3.AutoSize = true;
            this.lblFinalDvc3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc3.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc3.Name = "lblFinalDvc3";
            this.lblFinalDvc3.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc3.TabIndex = 120;
            this.lblFinalDvc3.Text = "Final result";
            // 
            // lblDevIdDvc3
            // 
            this.lblDevIdDvc3.AutoSize = true;
            this.lblDevIdDvc3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc3.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc3.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc3.Name = "lblDevIdDvc3";
            this.lblDevIdDvc3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc3.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc3.TabIndex = 119;
            this.lblDevIdDvc3.Text = "Device_ID";
            this.lblDevIdDvc3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc3
            // 
            this.grpStaDvc3.Controls.Add(this.radSta4Dvc3);
            this.grpStaDvc3.Controls.Add(this.radSta3Dvc3);
            this.grpStaDvc3.Controls.Add(this.radSta2Dvc3);
            this.grpStaDvc3.Controls.Add(this.radSta1Dvc3);
            this.grpStaDvc3.Controls.Add(this.radSta0Dvc3);
            this.grpStaDvc3.Controls.Add(this.button9);
            this.grpStaDvc3.Controls.Add(this.button10);
            this.grpStaDvc3.Enabled = false;
            this.grpStaDvc3.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc3.Name = "grpStaDvc3";
            this.grpStaDvc3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc3.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc3.TabIndex = 118;
            this.grpStaDvc3.TabStop = false;
            this.grpStaDvc3.Text = "station 站別";
            // 
            // radSta4Dvc3
            // 
            this.radSta4Dvc3.AutoSize = true;
            this.radSta4Dvc3.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc3.Name = "radSta4Dvc3";
            this.radSta4Dvc3.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc3.TabIndex = 5;
            this.radSta4Dvc3.Text = "Station 4";
            this.radSta4Dvc3.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc3
            // 
            this.radSta3Dvc3.AutoSize = true;
            this.radSta3Dvc3.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc3.Name = "radSta3Dvc3";
            this.radSta3Dvc3.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc3.TabIndex = 4;
            this.radSta3Dvc3.Text = "Station 3";
            this.radSta3Dvc3.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc3
            // 
            this.radSta2Dvc3.AutoSize = true;
            this.radSta2Dvc3.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc3.Name = "radSta2Dvc3";
            this.radSta2Dvc3.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc3.TabIndex = 3;
            this.radSta2Dvc3.Text = "Station 2";
            this.radSta2Dvc3.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc3
            // 
            this.radSta1Dvc3.AutoSize = true;
            this.radSta1Dvc3.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc3.Name = "radSta1Dvc3";
            this.radSta1Dvc3.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc3.TabIndex = 2;
            this.radSta1Dvc3.Text = "Station 1";
            this.radSta1Dvc3.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc3
            // 
            this.radSta0Dvc3.AutoSize = true;
            this.radSta0Dvc3.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc3.Name = "radSta0Dvc3";
            this.radSta0Dvc3.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc3.TabIndex = 0;
            this.radSta0Dvc3.Text = "Station 0";
            this.radSta0Dvc3.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(212, -64);
            this.button9.Margin = new System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(195, 58);
            this.button9.TabIndex = 10;
            this.button9.Text = "Clear";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(0, -64);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(195, 58);
            this.button10.TabIndex = 0;
            this.button10.Text = "OpenPort";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc3
            // 
            this.lblSnoDvc3.AutoSize = true;
            this.lblSnoDvc3.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc3.Name = "lblSnoDvc3";
            this.lblSnoDvc3.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc3.TabIndex = 117;
            this.lblSnoDvc3.Text = "Serial No.";
            // 
            // txtSnoDvc3
            // 
            this.txtSnoDvc3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc3.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc3.Name = "txtSnoDvc3";
            this.txtSnoDvc3.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc3.TabIndex = 110;
            this.txtSnoDvc3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc3_MouseClick);
            // 
            // btnClearDvc3
            // 
            this.btnClearDvc3.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc3.Name = "btnClearDvc3";
            this.btnClearDvc3.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc3.TabIndex = 116;
            this.btnClearDvc3.Text = "Clear";
            this.btnClearDvc3.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc3
            // 
            this.lblBaudDvc3.AutoSize = true;
            this.lblBaudDvc3.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc3.Name = "lblBaudDvc3";
            this.lblBaudDvc3.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc3.TabIndex = 115;
            this.lblBaudDvc3.Text = "BaudRate";
            // 
            // lblComDvc3
            // 
            this.lblComDvc3.AutoSize = true;
            this.lblComDvc3.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc3.Name = "lblComDvc3";
            this.lblComDvc3.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc3.TabIndex = 114;
            this.lblComDvc3.Text = "COM";
            // 
            // cboBaudDvc3
            // 
            this.cboBaudDvc3.Enabled = false;
            this.cboBaudDvc3.FormattingEnabled = true;
            this.cboBaudDvc3.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc3.Name = "cboBaudDvc3";
            this.cboBaudDvc3.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc3.TabIndex = 113;
            // 
            // cboComDvc3
            // 
            this.cboComDvc3.FormattingEnabled = true;
            this.cboComDvc3.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc3.Name = "cboComDvc3";
            this.cboComDvc3.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc3.TabIndex = 112;
            // 
            // btnTestDvc3
            // 
            this.btnTestDvc3.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc3.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc3.Name = "btnTestDvc3";
            this.btnTestDvc3.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc3.TabIndex = 111;
            this.btnTestDvc3.Text = "Test";
            this.btnTestDvc3.UseVisualStyleBackColor = true;
            this.btnTestDvc3.Click += new System.EventHandler(this.btnTestDvc3_Click);
            // 
            // tabPage_Device4
            // 
            this.tabPage_Device4.Controls.Add(this.lblSnoDvc4);
            this.tabPage_Device4.Controls.Add(this.lblTestRmkDvc4);
            this.tabPage_Device4.Controls.Add(this.txtTestRmkDvc4);
            this.tabPage_Device4.Controls.Add(this.btnBurnStopDvc4);
            this.tabPage_Device4.Controls.Add(this.btnBurn1hrDvc4);
            this.tabPage_Device4.Controls.Add(this.lblBurnRestDvc4);
            this.tabPage_Device4.Controls.Add(this.lblFinalDvc4);
            this.tabPage_Device4.Controls.Add(this.lblDevIdDvc4);
            this.tabPage_Device4.Controls.Add(this.grpStaDvc4);
            this.tabPage_Device4.Controls.Add(this.txtSnoDvc4);
            this.tabPage_Device4.Controls.Add(this.btnClearDvc4);
            this.tabPage_Device4.Controls.Add(this.lblBaudDvc4);
            this.tabPage_Device4.Controls.Add(this.lblComDvc4);
            this.tabPage_Device4.Controls.Add(this.cboBaudDvc4);
            this.tabPage_Device4.Controls.Add(this.cboComDvc4);
            this.tabPage_Device4.Controls.Add(this.btnTestDvc4);
            this.tabPage_Device4.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device4.Name = "tabPage_Device4";
            this.tabPage_Device4.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device4.TabIndex = 5;
            this.tabPage_Device4.Text = "Device4";
            this.tabPage_Device4.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc4
            // 
            this.lblSnoDvc4.AutoSize = true;
            this.lblSnoDvc4.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc4.Name = "lblSnoDvc4";
            this.lblSnoDvc4.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc4.TabIndex = 125;
            this.lblSnoDvc4.Text = "Serial No.";
            // 
            // lblTestRmkDvc4
            // 
            this.lblTestRmkDvc4.AutoSize = true;
            this.lblTestRmkDvc4.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc4.Name = "lblTestRmkDvc4";
            this.lblTestRmkDvc4.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc4.TabIndex = 124;
            this.lblTestRmkDvc4.Text = "備註欄";
            // 
            // txtTestRmkDvc4
            // 
            this.txtTestRmkDvc4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc4.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc4.Name = "txtTestRmkDvc4";
            this.txtTestRmkDvc4.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc4.TabIndex = 123;
            // 
            // btnBurnStopDvc4
            // 
            this.btnBurnStopDvc4.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc4.Name = "btnBurnStopDvc4";
            this.btnBurnStopDvc4.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc4.TabIndex = 122;
            this.btnBurnStopDvc4.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc4.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc4.Click += new System.EventHandler(this.btnBurnStopDvc4_Click);
            // 
            // btnBurn1hrDvc4
            // 
            this.btnBurn1hrDvc4.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc4.Name = "btnBurn1hrDvc4";
            this.btnBurn1hrDvc4.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc4.TabIndex = 121;
            this.btnBurn1hrDvc4.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc4.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc4.Click += new System.EventHandler(this.btnBurn1hrDvc4_Click);
            // 
            // lblBurnRestDvc4
            // 
            this.lblBurnRestDvc4.AutoSize = true;
            this.lblBurnRestDvc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc4.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc4.Name = "lblBurnRestDvc4";
            this.lblBurnRestDvc4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc4.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc4.TabIndex = 120;
            this.lblBurnRestDvc4.Text = "Burn-in time";
            this.lblBurnRestDvc4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc4
            // 
            this.lblFinalDvc4.AutoSize = true;
            this.lblFinalDvc4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc4.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc4.Name = "lblFinalDvc4";
            this.lblFinalDvc4.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc4.TabIndex = 119;
            this.lblFinalDvc4.Text = "Final result";
            // 
            // lblDevIdDvc4
            // 
            this.lblDevIdDvc4.AutoSize = true;
            this.lblDevIdDvc4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc4.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc4.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc4.Name = "lblDevIdDvc4";
            this.lblDevIdDvc4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc4.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc4.TabIndex = 118;
            this.lblDevIdDvc4.Text = "Device_ID";
            this.lblDevIdDvc4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc4
            // 
            this.grpStaDvc4.Controls.Add(this.radSta4Dvc4);
            this.grpStaDvc4.Controls.Add(this.radSta3Dvc4);
            this.grpStaDvc4.Controls.Add(this.radSta2Dvc4);
            this.grpStaDvc4.Controls.Add(this.radSta1Dvc4);
            this.grpStaDvc4.Controls.Add(this.radSta0Dvc4);
            this.grpStaDvc4.Controls.Add(this.button15);
            this.grpStaDvc4.Controls.Add(this.button16);
            this.grpStaDvc4.Enabled = false;
            this.grpStaDvc4.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc4.Name = "grpStaDvc4";
            this.grpStaDvc4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc4.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc4.TabIndex = 117;
            this.grpStaDvc4.TabStop = false;
            this.grpStaDvc4.Text = "station 站別";
            // 
            // radSta4Dvc4
            // 
            this.radSta4Dvc4.AutoSize = true;
            this.radSta4Dvc4.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc4.Name = "radSta4Dvc4";
            this.radSta4Dvc4.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc4.TabIndex = 5;
            this.radSta4Dvc4.Text = "Station 4";
            this.radSta4Dvc4.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc4
            // 
            this.radSta3Dvc4.AutoSize = true;
            this.radSta3Dvc4.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc4.Name = "radSta3Dvc4";
            this.radSta3Dvc4.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc4.TabIndex = 4;
            this.radSta3Dvc4.Text = "Station 3";
            this.radSta3Dvc4.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc4
            // 
            this.radSta2Dvc4.AutoSize = true;
            this.radSta2Dvc4.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc4.Name = "radSta2Dvc4";
            this.radSta2Dvc4.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc4.TabIndex = 3;
            this.radSta2Dvc4.Text = "Station 2";
            this.radSta2Dvc4.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc4
            // 
            this.radSta1Dvc4.AutoSize = true;
            this.radSta1Dvc4.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc4.Name = "radSta1Dvc4";
            this.radSta1Dvc4.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc4.TabIndex = 2;
            this.radSta1Dvc4.Text = "Station 1";
            this.radSta1Dvc4.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc4
            // 
            this.radSta0Dvc4.AutoSize = true;
            this.radSta0Dvc4.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc4.Name = "radSta0Dvc4";
            this.radSta0Dvc4.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc4.TabIndex = 0;
            this.radSta0Dvc4.Text = "Station 0";
            this.radSta0Dvc4.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(212, -64);
            this.button15.Margin = new System.Windows.Forms.Padding(4);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(195, 58);
            this.button15.TabIndex = 10;
            this.button15.Text = "Clear";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(0, -64);
            this.button16.Margin = new System.Windows.Forms.Padding(4);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(195, 58);
            this.button16.TabIndex = 0;
            this.button16.Text = "OpenPort";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc4
            // 
            this.txtSnoDvc4.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc4.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc4.Name = "txtSnoDvc4";
            this.txtSnoDvc4.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc4.TabIndex = 110;
            this.txtSnoDvc4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc4_MouseClick);
            // 
            // btnClearDvc4
            // 
            this.btnClearDvc4.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc4.Name = "btnClearDvc4";
            this.btnClearDvc4.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc4.TabIndex = 116;
            this.btnClearDvc4.Text = "Clear";
            this.btnClearDvc4.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc4
            // 
            this.lblBaudDvc4.AutoSize = true;
            this.lblBaudDvc4.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc4.Name = "lblBaudDvc4";
            this.lblBaudDvc4.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc4.TabIndex = 115;
            this.lblBaudDvc4.Text = "BaudRate";
            // 
            // lblComDvc4
            // 
            this.lblComDvc4.AutoSize = true;
            this.lblComDvc4.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc4.Name = "lblComDvc4";
            this.lblComDvc4.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc4.TabIndex = 114;
            this.lblComDvc4.Text = "COM";
            // 
            // cboBaudDvc4
            // 
            this.cboBaudDvc4.Enabled = false;
            this.cboBaudDvc4.FormattingEnabled = true;
            this.cboBaudDvc4.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc4.Name = "cboBaudDvc4";
            this.cboBaudDvc4.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc4.TabIndex = 113;
            // 
            // cboComDvc4
            // 
            this.cboComDvc4.FormattingEnabled = true;
            this.cboComDvc4.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc4.Name = "cboComDvc4";
            this.cboComDvc4.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc4.TabIndex = 112;
            // 
            // btnTestDvc4
            // 
            this.btnTestDvc4.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc4.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc4.Name = "btnTestDvc4";
            this.btnTestDvc4.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc4.TabIndex = 111;
            this.btnTestDvc4.Text = "Test";
            this.btnTestDvc4.UseVisualStyleBackColor = true;
            this.btnTestDvc4.Click += new System.EventHandler(this.btnTestDvc4_Click);
            // 
            // tabPage_Device5
            // 
            this.tabPage_Device5.Controls.Add(this.lblSnoDvc5);
            this.tabPage_Device5.Controls.Add(this.lblTestRmkDvc5);
            this.tabPage_Device5.Controls.Add(this.txtTestRmkDvc5);
            this.tabPage_Device5.Controls.Add(this.btnBurnStopDvc5);
            this.tabPage_Device5.Controls.Add(this.btnBurn1hrDvc5);
            this.tabPage_Device5.Controls.Add(this.lblBurnRestDvc5);
            this.tabPage_Device5.Controls.Add(this.lblFinalDvc5);
            this.tabPage_Device5.Controls.Add(this.lblDevIdDvc5);
            this.tabPage_Device5.Controls.Add(this.grpStaDvc5);
            this.tabPage_Device5.Controls.Add(this.txtSnoDvc5);
            this.tabPage_Device5.Controls.Add(this.btnClearDvc5);
            this.tabPage_Device5.Controls.Add(this.lblBaudDvc5);
            this.tabPage_Device5.Controls.Add(this.lblComDvc5);
            this.tabPage_Device5.Controls.Add(this.cboBaudDvc5);
            this.tabPage_Device5.Controls.Add(this.cboComDvc5);
            this.tabPage_Device5.Controls.Add(this.btnTestDvc5);
            this.tabPage_Device5.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device5.Name = "tabPage_Device5";
            this.tabPage_Device5.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device5.TabIndex = 6;
            this.tabPage_Device5.Text = "Device5";
            this.tabPage_Device5.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc5
            // 
            this.lblSnoDvc5.AutoSize = true;
            this.lblSnoDvc5.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc5.Name = "lblSnoDvc5";
            this.lblSnoDvc5.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc5.TabIndex = 141;
            this.lblSnoDvc5.Text = "Serial No.";
            // 
            // lblTestRmkDvc5
            // 
            this.lblTestRmkDvc5.AutoSize = true;
            this.lblTestRmkDvc5.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc5.Name = "lblTestRmkDvc5";
            this.lblTestRmkDvc5.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc5.TabIndex = 140;
            this.lblTestRmkDvc5.Text = "備註欄";
            // 
            // txtTestRmkDvc5
            // 
            this.txtTestRmkDvc5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc5.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc5.Name = "txtTestRmkDvc5";
            this.txtTestRmkDvc5.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc5.TabIndex = 139;
            // 
            // btnBurnStopDvc5
            // 
            this.btnBurnStopDvc5.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc5.Name = "btnBurnStopDvc5";
            this.btnBurnStopDvc5.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc5.TabIndex = 138;
            this.btnBurnStopDvc5.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc5.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc5.Click += new System.EventHandler(this.btnBurnStopDvc5_Click);
            // 
            // btnBurn1hrDvc5
            // 
            this.btnBurn1hrDvc5.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc5.Name = "btnBurn1hrDvc5";
            this.btnBurn1hrDvc5.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc5.TabIndex = 137;
            this.btnBurn1hrDvc5.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc5.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc5.Click += new System.EventHandler(this.btnBurn1hrDvc5_Click);
            // 
            // lblBurnRestDvc5
            // 
            this.lblBurnRestDvc5.AutoSize = true;
            this.lblBurnRestDvc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc5.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc5.Name = "lblBurnRestDvc5";
            this.lblBurnRestDvc5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc5.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc5.TabIndex = 136;
            this.lblBurnRestDvc5.Text = "Burn-in time";
            this.lblBurnRestDvc5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc5
            // 
            this.lblFinalDvc5.AutoSize = true;
            this.lblFinalDvc5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc5.Location = new System.Drawing.Point(11, 266);
            this.lblFinalDvc5.Name = "lblFinalDvc5";
            this.lblFinalDvc5.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc5.TabIndex = 135;
            this.lblFinalDvc5.Text = "Final result";
            // 
            // lblDevIdDvc5
            // 
            this.lblDevIdDvc5.AutoSize = true;
            this.lblDevIdDvc5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc5.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc5.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc5.Name = "lblDevIdDvc5";
            this.lblDevIdDvc5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc5.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc5.TabIndex = 134;
            this.lblDevIdDvc5.Text = "Device_ID";
            this.lblDevIdDvc5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc5
            // 
            this.grpStaDvc5.Controls.Add(this.radSta4Dvc5);
            this.grpStaDvc5.Controls.Add(this.radSta3Dvc5);
            this.grpStaDvc5.Controls.Add(this.radSta2Dvc5);
            this.grpStaDvc5.Controls.Add(this.radSta1Dvc5);
            this.grpStaDvc5.Controls.Add(this.radSta0Dvc5);
            this.grpStaDvc5.Controls.Add(this.button21);
            this.grpStaDvc5.Controls.Add(this.button22);
            this.grpStaDvc5.Enabled = false;
            this.grpStaDvc5.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc5.Name = "grpStaDvc5";
            this.grpStaDvc5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc5.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc5.TabIndex = 133;
            this.grpStaDvc5.TabStop = false;
            this.grpStaDvc5.Text = "station 站別";
            // 
            // radSta4Dvc5
            // 
            this.radSta4Dvc5.AutoSize = true;
            this.radSta4Dvc5.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc5.Name = "radSta4Dvc5";
            this.radSta4Dvc5.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc5.TabIndex = 5;
            this.radSta4Dvc5.Text = "Station 4";
            this.radSta4Dvc5.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc5
            // 
            this.radSta3Dvc5.AutoSize = true;
            this.radSta3Dvc5.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc5.Name = "radSta3Dvc5";
            this.radSta3Dvc5.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc5.TabIndex = 4;
            this.radSta3Dvc5.Text = "Station 3";
            this.radSta3Dvc5.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc5
            // 
            this.radSta2Dvc5.AutoSize = true;
            this.radSta2Dvc5.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc5.Name = "radSta2Dvc5";
            this.radSta2Dvc5.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc5.TabIndex = 3;
            this.radSta2Dvc5.Text = "Station 2";
            this.radSta2Dvc5.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc5
            // 
            this.radSta1Dvc5.AutoSize = true;
            this.radSta1Dvc5.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc5.Name = "radSta1Dvc5";
            this.radSta1Dvc5.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc5.TabIndex = 2;
            this.radSta1Dvc5.Text = "Station 1";
            this.radSta1Dvc5.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc5
            // 
            this.radSta0Dvc5.AutoSize = true;
            this.radSta0Dvc5.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc5.Name = "radSta0Dvc5";
            this.radSta0Dvc5.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc5.TabIndex = 0;
            this.radSta0Dvc5.Text = "Station 0";
            this.radSta0Dvc5.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(212, -64);
            this.button21.Margin = new System.Windows.Forms.Padding(4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(195, 58);
            this.button21.TabIndex = 10;
            this.button21.Text = "Clear";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(0, -64);
            this.button22.Margin = new System.Windows.Forms.Padding(4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(195, 58);
            this.button22.TabIndex = 0;
            this.button22.Text = "OpenPort";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc5
            // 
            this.txtSnoDvc5.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc5.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc5.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc5.Name = "txtSnoDvc5";
            this.txtSnoDvc5.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc5.TabIndex = 126;
            this.txtSnoDvc5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc5_MouseClick);
            // 
            // btnClearDvc5
            // 
            this.btnClearDvc5.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc5.Name = "btnClearDvc5";
            this.btnClearDvc5.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc5.TabIndex = 132;
            this.btnClearDvc5.Text = "Clear";
            this.btnClearDvc5.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc5
            // 
            this.lblBaudDvc5.AutoSize = true;
            this.lblBaudDvc5.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc5.Name = "lblBaudDvc5";
            this.lblBaudDvc5.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc5.TabIndex = 131;
            this.lblBaudDvc5.Text = "BaudRate";
            // 
            // lblComDvc5
            // 
            this.lblComDvc5.AutoSize = true;
            this.lblComDvc5.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc5.Name = "lblComDvc5";
            this.lblComDvc5.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc5.TabIndex = 130;
            this.lblComDvc5.Text = "COM";
            // 
            // cboBaudDvc5
            // 
            this.cboBaudDvc5.Enabled = false;
            this.cboBaudDvc5.FormattingEnabled = true;
            this.cboBaudDvc5.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc5.Name = "cboBaudDvc5";
            this.cboBaudDvc5.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc5.TabIndex = 129;
            // 
            // cboComDvc5
            // 
            this.cboComDvc5.FormattingEnabled = true;
            this.cboComDvc5.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc5.Name = "cboComDvc5";
            this.cboComDvc5.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc5.TabIndex = 128;
            // 
            // btnTestDvc5
            // 
            this.btnTestDvc5.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc5.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc5.Name = "btnTestDvc5";
            this.btnTestDvc5.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc5.TabIndex = 127;
            this.btnTestDvc5.Text = "Test";
            this.btnTestDvc5.UseVisualStyleBackColor = true;
            this.btnTestDvc5.Click += new System.EventHandler(this.btnTestDvc5_Click);
            // 
            // tabPage_Device6
            // 
            this.tabPage_Device6.Controls.Add(this.lblSnoDvc6);
            this.tabPage_Device6.Controls.Add(this.lblTestRmkDvc6);
            this.tabPage_Device6.Controls.Add(this.txtTestRmkDvc6);
            this.tabPage_Device6.Controls.Add(this.btnBurnStopDvc6);
            this.tabPage_Device6.Controls.Add(this.btnBurn1hrDvc6);
            this.tabPage_Device6.Controls.Add(this.lblBurnRestDvc6);
            this.tabPage_Device6.Controls.Add(this.lblFinalDvc6);
            this.tabPage_Device6.Controls.Add(this.lblDevIdDvc6);
            this.tabPage_Device6.Controls.Add(this.grpStaDvc6);
            this.tabPage_Device6.Controls.Add(this.txtSnoDvc6);
            this.tabPage_Device6.Controls.Add(this.btnClearDvc6);
            this.tabPage_Device6.Controls.Add(this.lblBaudDvc6);
            this.tabPage_Device6.Controls.Add(this.lblComDvc6);
            this.tabPage_Device6.Controls.Add(this.cboBaudDvc6);
            this.tabPage_Device6.Controls.Add(this.cboComDvc6);
            this.tabPage_Device6.Controls.Add(this.btnTestDvc6);
            this.tabPage_Device6.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device6.Name = "tabPage_Device6";
            this.tabPage_Device6.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device6.TabIndex = 7;
            this.tabPage_Device6.Text = "Device6";
            this.tabPage_Device6.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc6
            // 
            this.lblSnoDvc6.AutoSize = true;
            this.lblSnoDvc6.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc6.Name = "lblSnoDvc6";
            this.lblSnoDvc6.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc6.TabIndex = 141;
            this.lblSnoDvc6.Text = "Serial No.";
            // 
            // lblTestRmkDvc6
            // 
            this.lblTestRmkDvc6.AutoSize = true;
            this.lblTestRmkDvc6.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc6.Name = "lblTestRmkDvc6";
            this.lblTestRmkDvc6.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc6.TabIndex = 140;
            this.lblTestRmkDvc6.Text = "備註欄";
            // 
            // txtTestRmkDvc6
            // 
            this.txtTestRmkDvc6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc6.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc6.Name = "txtTestRmkDvc6";
            this.txtTestRmkDvc6.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc6.TabIndex = 139;
            // 
            // btnBurnStopDvc6
            // 
            this.btnBurnStopDvc6.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc6.Name = "btnBurnStopDvc6";
            this.btnBurnStopDvc6.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc6.TabIndex = 138;
            this.btnBurnStopDvc6.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc6.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc6.Click += new System.EventHandler(this.btnBurnStopDvc6_Click);
            // 
            // btnBurn1hrDvc6
            // 
            this.btnBurn1hrDvc6.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc6.Name = "btnBurn1hrDvc6";
            this.btnBurn1hrDvc6.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc6.TabIndex = 137;
            this.btnBurn1hrDvc6.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc6.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc6.Click += new System.EventHandler(this.btnBurn1hrDvc6_Click);
            // 
            // lblBurnRestDvc6
            // 
            this.lblBurnRestDvc6.AutoSize = true;
            this.lblBurnRestDvc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc6.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc6.Name = "lblBurnRestDvc6";
            this.lblBurnRestDvc6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc6.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc6.TabIndex = 136;
            this.lblBurnRestDvc6.Text = "Burn-in time";
            this.lblBurnRestDvc6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc6
            // 
            this.lblFinalDvc6.AutoSize = true;
            this.lblFinalDvc6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc6.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc6.Name = "lblFinalDvc6";
            this.lblFinalDvc6.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc6.TabIndex = 135;
            this.lblFinalDvc6.Text = "Final result";
            // 
            // lblDevIdDvc6
            // 
            this.lblDevIdDvc6.AutoSize = true;
            this.lblDevIdDvc6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc6.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc6.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc6.Name = "lblDevIdDvc6";
            this.lblDevIdDvc6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc6.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc6.TabIndex = 134;
            this.lblDevIdDvc6.Text = "Device_ID";
            this.lblDevIdDvc6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc6
            // 
            this.grpStaDvc6.Controls.Add(this.radSta4Dvc6);
            this.grpStaDvc6.Controls.Add(this.radSta3Dvc6);
            this.grpStaDvc6.Controls.Add(this.radSta2Dvc6);
            this.grpStaDvc6.Controls.Add(this.radSta1Dvc6);
            this.grpStaDvc6.Controls.Add(this.radSta0Dvc6);
            this.grpStaDvc6.Controls.Add(this.button27);
            this.grpStaDvc6.Controls.Add(this.button28);
            this.grpStaDvc6.Enabled = false;
            this.grpStaDvc6.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc6.Name = "grpStaDvc6";
            this.grpStaDvc6.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc6.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc6.TabIndex = 133;
            this.grpStaDvc6.TabStop = false;
            this.grpStaDvc6.Text = "station 站別";
            // 
            // radSta4Dvc6
            // 
            this.radSta4Dvc6.AutoSize = true;
            this.radSta4Dvc6.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc6.Name = "radSta4Dvc6";
            this.radSta4Dvc6.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc6.TabIndex = 5;
            this.radSta4Dvc6.Text = "Station 4";
            this.radSta4Dvc6.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc6
            // 
            this.radSta3Dvc6.AutoSize = true;
            this.radSta3Dvc6.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc6.Name = "radSta3Dvc6";
            this.radSta3Dvc6.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc6.TabIndex = 4;
            this.radSta3Dvc6.Text = "Station 3";
            this.radSta3Dvc6.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc6
            // 
            this.radSta2Dvc6.AutoSize = true;
            this.radSta2Dvc6.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc6.Name = "radSta2Dvc6";
            this.radSta2Dvc6.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc6.TabIndex = 3;
            this.radSta2Dvc6.Text = "Station 2";
            this.radSta2Dvc6.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc6
            // 
            this.radSta1Dvc6.AutoSize = true;
            this.radSta1Dvc6.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc6.Name = "radSta1Dvc6";
            this.radSta1Dvc6.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc6.TabIndex = 2;
            this.radSta1Dvc6.Text = "Station 1";
            this.radSta1Dvc6.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc6
            // 
            this.radSta0Dvc6.AutoSize = true;
            this.radSta0Dvc6.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc6.Name = "radSta0Dvc6";
            this.radSta0Dvc6.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc6.TabIndex = 0;
            this.radSta0Dvc6.Text = "Station 0";
            this.radSta0Dvc6.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(212, -64);
            this.button27.Margin = new System.Windows.Forms.Padding(4);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(195, 58);
            this.button27.TabIndex = 10;
            this.button27.Text = "Clear";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(0, -64);
            this.button28.Margin = new System.Windows.Forms.Padding(4);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(195, 58);
            this.button28.TabIndex = 0;
            this.button28.Text = "OpenPort";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc6
            // 
            this.txtSnoDvc6.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc6.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc6.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc6.Name = "txtSnoDvc6";
            this.txtSnoDvc6.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc6.TabIndex = 126;
            this.txtSnoDvc6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc6_MouseClick);
            // 
            // btnClearDvc6
            // 
            this.btnClearDvc6.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc6.Name = "btnClearDvc6";
            this.btnClearDvc6.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc6.TabIndex = 132;
            this.btnClearDvc6.Text = "Clear";
            this.btnClearDvc6.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc6
            // 
            this.lblBaudDvc6.AutoSize = true;
            this.lblBaudDvc6.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc6.Name = "lblBaudDvc6";
            this.lblBaudDvc6.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc6.TabIndex = 131;
            this.lblBaudDvc6.Text = "BaudRate";
            // 
            // lblComDvc6
            // 
            this.lblComDvc6.AutoSize = true;
            this.lblComDvc6.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc6.Name = "lblComDvc6";
            this.lblComDvc6.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc6.TabIndex = 130;
            this.lblComDvc6.Text = "COM";
            // 
            // cboBaudDvc6
            // 
            this.cboBaudDvc6.Enabled = false;
            this.cboBaudDvc6.FormattingEnabled = true;
            this.cboBaudDvc6.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc6.Name = "cboBaudDvc6";
            this.cboBaudDvc6.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc6.TabIndex = 129;
            // 
            // cboComDvc6
            // 
            this.cboComDvc6.FormattingEnabled = true;
            this.cboComDvc6.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc6.Name = "cboComDvc6";
            this.cboComDvc6.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc6.TabIndex = 128;
            // 
            // btnTestDvc6
            // 
            this.btnTestDvc6.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc6.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc6.Name = "btnTestDvc6";
            this.btnTestDvc6.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc6.TabIndex = 127;
            this.btnTestDvc6.Text = "Test";
            this.btnTestDvc6.UseVisualStyleBackColor = true;
            this.btnTestDvc6.Click += new System.EventHandler(this.btnTestDvc6_Click);
            // 
            // tabPage_Device7
            // 
            this.tabPage_Device7.Controls.Add(this.lblSnoDvc7);
            this.tabPage_Device7.Controls.Add(this.lblTestRmkDvc7);
            this.tabPage_Device7.Controls.Add(this.txtTestRmkDvc7);
            this.tabPage_Device7.Controls.Add(this.btnBurnStopDvc7);
            this.tabPage_Device7.Controls.Add(this.btnBurn1hrDvc7);
            this.tabPage_Device7.Controls.Add(this.lblBurnRestDvc7);
            this.tabPage_Device7.Controls.Add(this.lblFinalDvc7);
            this.tabPage_Device7.Controls.Add(this.lblDevIdDvc7);
            this.tabPage_Device7.Controls.Add(this.grpStaDvc7);
            this.tabPage_Device7.Controls.Add(this.txtSnoDvc7);
            this.tabPage_Device7.Controls.Add(this.btnClearDvc7);
            this.tabPage_Device7.Controls.Add(this.lblBaudDvc7);
            this.tabPage_Device7.Controls.Add(this.lblComDvc7);
            this.tabPage_Device7.Controls.Add(this.cboBaudDvc7);
            this.tabPage_Device7.Controls.Add(this.cboComDvc7);
            this.tabPage_Device7.Controls.Add(this.btnTestDvc7);
            this.tabPage_Device7.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device7.Name = "tabPage_Device7";
            this.tabPage_Device7.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device7.TabIndex = 8;
            this.tabPage_Device7.Text = "Device7";
            this.tabPage_Device7.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc7
            // 
            this.lblSnoDvc7.AutoSize = true;
            this.lblSnoDvc7.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc7.Name = "lblSnoDvc7";
            this.lblSnoDvc7.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc7.TabIndex = 141;
            this.lblSnoDvc7.Text = "Serial No.";
            // 
            // lblTestRmkDvc7
            // 
            this.lblTestRmkDvc7.AutoSize = true;
            this.lblTestRmkDvc7.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc7.Name = "lblTestRmkDvc7";
            this.lblTestRmkDvc7.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc7.TabIndex = 140;
            this.lblTestRmkDvc7.Text = "備註欄";
            // 
            // txtTestRmkDvc7
            // 
            this.txtTestRmkDvc7.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc7.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc7.Name = "txtTestRmkDvc7";
            this.txtTestRmkDvc7.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc7.TabIndex = 139;
            // 
            // btnBurnStopDvc7
            // 
            this.btnBurnStopDvc7.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc7.Name = "btnBurnStopDvc7";
            this.btnBurnStopDvc7.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc7.TabIndex = 138;
            this.btnBurnStopDvc7.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc7.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc7.Click += new System.EventHandler(this.btnBurnStopDvc7_Click);
            // 
            // btnBurn1hrDvc7
            // 
            this.btnBurn1hrDvc7.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc7.Name = "btnBurn1hrDvc7";
            this.btnBurn1hrDvc7.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc7.TabIndex = 137;
            this.btnBurn1hrDvc7.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc7.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc7.Click += new System.EventHandler(this.btnBurn1hrDvc7_Click);
            // 
            // lblBurnRestDvc7
            // 
            this.lblBurnRestDvc7.AutoSize = true;
            this.lblBurnRestDvc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc7.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc7.Name = "lblBurnRestDvc7";
            this.lblBurnRestDvc7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc7.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc7.TabIndex = 136;
            this.lblBurnRestDvc7.Text = "Burn-in time";
            this.lblBurnRestDvc7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc7
            // 
            this.lblFinalDvc7.AutoSize = true;
            this.lblFinalDvc7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc7.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc7.Name = "lblFinalDvc7";
            this.lblFinalDvc7.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc7.TabIndex = 135;
            this.lblFinalDvc7.Text = "Final result";
            // 
            // lblDevIdDvc7
            // 
            this.lblDevIdDvc7.AutoSize = true;
            this.lblDevIdDvc7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc7.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc7.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc7.Name = "lblDevIdDvc7";
            this.lblDevIdDvc7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc7.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc7.TabIndex = 134;
            this.lblDevIdDvc7.Text = "Device_ID";
            this.lblDevIdDvc7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc7
            // 
            this.grpStaDvc7.Controls.Add(this.radSta4Dvc7);
            this.grpStaDvc7.Controls.Add(this.radSta3Dvc7);
            this.grpStaDvc7.Controls.Add(this.radSta2Dvc7);
            this.grpStaDvc7.Controls.Add(this.radSta1Dvc7);
            this.grpStaDvc7.Controls.Add(this.radSta0Dvc7);
            this.grpStaDvc7.Controls.Add(this.button33);
            this.grpStaDvc7.Controls.Add(this.button34);
            this.grpStaDvc7.Enabled = false;
            this.grpStaDvc7.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc7.Name = "grpStaDvc7";
            this.grpStaDvc7.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc7.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc7.TabIndex = 133;
            this.grpStaDvc7.TabStop = false;
            this.grpStaDvc7.Text = "station 站別";
            // 
            // radSta4Dvc7
            // 
            this.radSta4Dvc7.AutoSize = true;
            this.radSta4Dvc7.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc7.Name = "radSta4Dvc7";
            this.radSta4Dvc7.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc7.TabIndex = 5;
            this.radSta4Dvc7.Text = "Station 4";
            this.radSta4Dvc7.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc7
            // 
            this.radSta3Dvc7.AutoSize = true;
            this.radSta3Dvc7.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc7.Name = "radSta3Dvc7";
            this.radSta3Dvc7.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc7.TabIndex = 4;
            this.radSta3Dvc7.Text = "Station 3";
            this.radSta3Dvc7.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc7
            // 
            this.radSta2Dvc7.AutoSize = true;
            this.radSta2Dvc7.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc7.Name = "radSta2Dvc7";
            this.radSta2Dvc7.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc7.TabIndex = 3;
            this.radSta2Dvc7.Text = "Station 2";
            this.radSta2Dvc7.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc7
            // 
            this.radSta1Dvc7.AutoSize = true;
            this.radSta1Dvc7.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc7.Name = "radSta1Dvc7";
            this.radSta1Dvc7.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc7.TabIndex = 2;
            this.radSta1Dvc7.Text = "Station 1";
            this.radSta1Dvc7.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc7
            // 
            this.radSta0Dvc7.AutoSize = true;
            this.radSta0Dvc7.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc7.Name = "radSta0Dvc7";
            this.radSta0Dvc7.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc7.TabIndex = 0;
            this.radSta0Dvc7.Text = "Station 0";
            this.radSta0Dvc7.UseVisualStyleBackColor = true;
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(212, -64);
            this.button33.Margin = new System.Windows.Forms.Padding(4);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(195, 58);
            this.button33.TabIndex = 10;
            this.button33.Text = "Clear";
            this.button33.UseVisualStyleBackColor = true;
            // 
            // button34
            // 
            this.button34.Location = new System.Drawing.Point(0, -64);
            this.button34.Margin = new System.Windows.Forms.Padding(4);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(195, 58);
            this.button34.TabIndex = 0;
            this.button34.Text = "OpenPort";
            this.button34.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc7
            // 
            this.txtSnoDvc7.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc7.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc7.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc7.Name = "txtSnoDvc7";
            this.txtSnoDvc7.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc7.TabIndex = 126;
            this.txtSnoDvc7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc7_MouseClick);
            // 
            // btnClearDvc7
            // 
            this.btnClearDvc7.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc7.Name = "btnClearDvc7";
            this.btnClearDvc7.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc7.TabIndex = 132;
            this.btnClearDvc7.Text = "Clear";
            this.btnClearDvc7.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc7
            // 
            this.lblBaudDvc7.AutoSize = true;
            this.lblBaudDvc7.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc7.Name = "lblBaudDvc7";
            this.lblBaudDvc7.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc7.TabIndex = 131;
            this.lblBaudDvc7.Text = "BaudRate";
            // 
            // lblComDvc7
            // 
            this.lblComDvc7.AutoSize = true;
            this.lblComDvc7.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc7.Name = "lblComDvc7";
            this.lblComDvc7.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc7.TabIndex = 130;
            this.lblComDvc7.Text = "COM";
            // 
            // cboBaudDvc7
            // 
            this.cboBaudDvc7.Enabled = false;
            this.cboBaudDvc7.FormattingEnabled = true;
            this.cboBaudDvc7.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc7.Name = "cboBaudDvc7";
            this.cboBaudDvc7.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc7.TabIndex = 129;
            // 
            // cboComDvc7
            // 
            this.cboComDvc7.FormattingEnabled = true;
            this.cboComDvc7.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc7.Name = "cboComDvc7";
            this.cboComDvc7.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc7.TabIndex = 128;
            // 
            // btnTestDvc7
            // 
            this.btnTestDvc7.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc7.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc7.Name = "btnTestDvc7";
            this.btnTestDvc7.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc7.TabIndex = 127;
            this.btnTestDvc7.Text = "Test";
            this.btnTestDvc7.UseVisualStyleBackColor = true;
            this.btnTestDvc7.Click += new System.EventHandler(this.btnTestDvc7_Click);
            // 
            // tabPage_Device8
            // 
            this.tabPage_Device8.Controls.Add(this.lblSnoDvc8);
            this.tabPage_Device8.Controls.Add(this.lblTestRmkDvc8);
            this.tabPage_Device8.Controls.Add(this.txtTestRmkDvc8);
            this.tabPage_Device8.Controls.Add(this.btnBurnStopDvc8);
            this.tabPage_Device8.Controls.Add(this.btnBurn1hrDvc8);
            this.tabPage_Device8.Controls.Add(this.lblBurnRestDvc8);
            this.tabPage_Device8.Controls.Add(this.lblFinalDvc8);
            this.tabPage_Device8.Controls.Add(this.lblDevIdDvc8);
            this.tabPage_Device8.Controls.Add(this.grpStaDvc8);
            this.tabPage_Device8.Controls.Add(this.txtSnoDvc8);
            this.tabPage_Device8.Controls.Add(this.btnClearDvc8);
            this.tabPage_Device8.Controls.Add(this.lblBaudDvc8);
            this.tabPage_Device8.Controls.Add(this.lblComDvc8);
            this.tabPage_Device8.Controls.Add(this.cboBaudDvc8);
            this.tabPage_Device8.Controls.Add(this.cboComDvc8);
            this.tabPage_Device8.Controls.Add(this.btnTestDvc8);
            this.tabPage_Device8.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device8.Name = "tabPage_Device8";
            this.tabPage_Device8.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device8.TabIndex = 9;
            this.tabPage_Device8.Text = "Device8";
            this.tabPage_Device8.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc8
            // 
            this.lblSnoDvc8.AutoSize = true;
            this.lblSnoDvc8.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc8.Name = "lblSnoDvc8";
            this.lblSnoDvc8.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc8.TabIndex = 141;
            this.lblSnoDvc8.Text = "Serial No.";
            // 
            // lblTestRmkDvc8
            // 
            this.lblTestRmkDvc8.AutoSize = true;
            this.lblTestRmkDvc8.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc8.Name = "lblTestRmkDvc8";
            this.lblTestRmkDvc8.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc8.TabIndex = 140;
            this.lblTestRmkDvc8.Text = "備註欄";
            // 
            // txtTestRmkDvc8
            // 
            this.txtTestRmkDvc8.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc8.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc8.Name = "txtTestRmkDvc8";
            this.txtTestRmkDvc8.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc8.TabIndex = 139;
            // 
            // btnBurnStopDvc8
            // 
            this.btnBurnStopDvc8.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc8.Name = "btnBurnStopDvc8";
            this.btnBurnStopDvc8.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc8.TabIndex = 138;
            this.btnBurnStopDvc8.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc8.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc8.Click += new System.EventHandler(this.btnBurnStopDvc8_Click);
            // 
            // btnBurn1hrDvc8
            // 
            this.btnBurn1hrDvc8.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc8.Name = "btnBurn1hrDvc8";
            this.btnBurn1hrDvc8.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc8.TabIndex = 137;
            this.btnBurn1hrDvc8.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc8.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc8.Click += new System.EventHandler(this.btnBurn1hrDvc8_Click);
            // 
            // lblBurnRestDvc8
            // 
            this.lblBurnRestDvc8.AutoSize = true;
            this.lblBurnRestDvc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc8.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc8.Name = "lblBurnRestDvc8";
            this.lblBurnRestDvc8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc8.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc8.TabIndex = 136;
            this.lblBurnRestDvc8.Text = "Burn-in time";
            this.lblBurnRestDvc8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc8
            // 
            this.lblFinalDvc8.AutoSize = true;
            this.lblFinalDvc8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc8.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc8.Name = "lblFinalDvc8";
            this.lblFinalDvc8.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc8.TabIndex = 135;
            this.lblFinalDvc8.Text = "Final result";
            // 
            // lblDevIdDvc8
            // 
            this.lblDevIdDvc8.AutoSize = true;
            this.lblDevIdDvc8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc8.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc8.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc8.Name = "lblDevIdDvc8";
            this.lblDevIdDvc8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc8.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc8.TabIndex = 134;
            this.lblDevIdDvc8.Text = "Device_ID";
            this.lblDevIdDvc8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc8
            // 
            this.grpStaDvc8.Controls.Add(this.radSta4Dvc8);
            this.grpStaDvc8.Controls.Add(this.radSta3Dvc8);
            this.grpStaDvc8.Controls.Add(this.radSta2Dvc8);
            this.grpStaDvc8.Controls.Add(this.radSta1Dvc8);
            this.grpStaDvc8.Controls.Add(this.radSta0Dvc8);
            this.grpStaDvc8.Controls.Add(this.button39);
            this.grpStaDvc8.Controls.Add(this.button40);
            this.grpStaDvc8.Enabled = false;
            this.grpStaDvc8.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc8.Name = "grpStaDvc8";
            this.grpStaDvc8.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc8.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc8.TabIndex = 133;
            this.grpStaDvc8.TabStop = false;
            this.grpStaDvc8.Text = "station 站別";
            // 
            // radSta4Dvc8
            // 
            this.radSta4Dvc8.AutoSize = true;
            this.radSta4Dvc8.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc8.Name = "radSta4Dvc8";
            this.radSta4Dvc8.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc8.TabIndex = 5;
            this.radSta4Dvc8.Text = "Station 4";
            this.radSta4Dvc8.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc8
            // 
            this.radSta3Dvc8.AutoSize = true;
            this.radSta3Dvc8.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc8.Name = "radSta3Dvc8";
            this.radSta3Dvc8.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc8.TabIndex = 4;
            this.radSta3Dvc8.Text = "Station 3";
            this.radSta3Dvc8.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc8
            // 
            this.radSta2Dvc8.AutoSize = true;
            this.radSta2Dvc8.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc8.Name = "radSta2Dvc8";
            this.radSta2Dvc8.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc8.TabIndex = 3;
            this.radSta2Dvc8.Text = "Station 2";
            this.radSta2Dvc8.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc8
            // 
            this.radSta1Dvc8.AutoSize = true;
            this.radSta1Dvc8.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc8.Name = "radSta1Dvc8";
            this.radSta1Dvc8.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc8.TabIndex = 2;
            this.radSta1Dvc8.Text = "Station 1";
            this.radSta1Dvc8.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc8
            // 
            this.radSta0Dvc8.AutoSize = true;
            this.radSta0Dvc8.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc8.Name = "radSta0Dvc8";
            this.radSta0Dvc8.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc8.TabIndex = 0;
            this.radSta0Dvc8.Text = "Station 0";
            this.radSta0Dvc8.UseVisualStyleBackColor = true;
            // 
            // button39
            // 
            this.button39.Location = new System.Drawing.Point(212, -64);
            this.button39.Margin = new System.Windows.Forms.Padding(4);
            this.button39.Name = "button39";
            this.button39.Size = new System.Drawing.Size(195, 58);
            this.button39.TabIndex = 10;
            this.button39.Text = "Clear";
            this.button39.UseVisualStyleBackColor = true;
            // 
            // button40
            // 
            this.button40.Location = new System.Drawing.Point(0, -64);
            this.button40.Margin = new System.Windows.Forms.Padding(4);
            this.button40.Name = "button40";
            this.button40.Size = new System.Drawing.Size(195, 58);
            this.button40.TabIndex = 0;
            this.button40.Text = "OpenPort";
            this.button40.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc8
            // 
            this.txtSnoDvc8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc8.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc8.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc8.Name = "txtSnoDvc8";
            this.txtSnoDvc8.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc8.TabIndex = 126;
            this.txtSnoDvc8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc8_MouseClick);
            // 
            // btnClearDvc8
            // 
            this.btnClearDvc8.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc8.Name = "btnClearDvc8";
            this.btnClearDvc8.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc8.TabIndex = 132;
            this.btnClearDvc8.Text = "Clear";
            this.btnClearDvc8.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc8
            // 
            this.lblBaudDvc8.AutoSize = true;
            this.lblBaudDvc8.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc8.Name = "lblBaudDvc8";
            this.lblBaudDvc8.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc8.TabIndex = 131;
            this.lblBaudDvc8.Text = "BaudRate";
            // 
            // lblComDvc8
            // 
            this.lblComDvc8.AutoSize = true;
            this.lblComDvc8.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc8.Name = "lblComDvc8";
            this.lblComDvc8.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc8.TabIndex = 130;
            this.lblComDvc8.Text = "COM";
            // 
            // cboBaudDvc8
            // 
            this.cboBaudDvc8.Enabled = false;
            this.cboBaudDvc8.FormattingEnabled = true;
            this.cboBaudDvc8.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc8.Name = "cboBaudDvc8";
            this.cboBaudDvc8.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc8.TabIndex = 129;
            // 
            // cboComDvc8
            // 
            this.cboComDvc8.FormattingEnabled = true;
            this.cboComDvc8.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc8.Name = "cboComDvc8";
            this.cboComDvc8.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc8.TabIndex = 128;
            // 
            // btnTestDvc8
            // 
            this.btnTestDvc8.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc8.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc8.Name = "btnTestDvc8";
            this.btnTestDvc8.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc8.TabIndex = 127;
            this.btnTestDvc8.Text = "Test";
            this.btnTestDvc8.UseVisualStyleBackColor = true;
            this.btnTestDvc8.Click += new System.EventHandler(this.btnTestDvc8_Click);
            // 
            // tabPage_Device9
            // 
            this.tabPage_Device9.Controls.Add(this.lblSnoDvc9);
            this.tabPage_Device9.Controls.Add(this.lblTestRmkDvc9);
            this.tabPage_Device9.Controls.Add(this.txtTestRmkDvc9);
            this.tabPage_Device9.Controls.Add(this.btnBurnStopDvc9);
            this.tabPage_Device9.Controls.Add(this.btnBurn1hrDvc9);
            this.tabPage_Device9.Controls.Add(this.lblBurnRestDvc9);
            this.tabPage_Device9.Controls.Add(this.lblFinalDvc9);
            this.tabPage_Device9.Controls.Add(this.lblDevIdDvc9);
            this.tabPage_Device9.Controls.Add(this.grpStaDvc9);
            this.tabPage_Device9.Controls.Add(this.txtSnoDvc9);
            this.tabPage_Device9.Controls.Add(this.btnClearDvc9);
            this.tabPage_Device9.Controls.Add(this.lblBaudDvc9);
            this.tabPage_Device9.Controls.Add(this.lblComDvc9);
            this.tabPage_Device9.Controls.Add(this.cboBaudDvc9);
            this.tabPage_Device9.Controls.Add(this.cboComDvc9);
            this.tabPage_Device9.Controls.Add(this.btnTestDvc9);
            this.tabPage_Device9.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Device9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Device9.Name = "tabPage_Device9";
            this.tabPage_Device9.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Device9.TabIndex = 10;
            this.tabPage_Device9.Text = "Device9";
            this.tabPage_Device9.UseVisualStyleBackColor = true;
            // 
            // lblSnoDvc9
            // 
            this.lblSnoDvc9.AutoSize = true;
            this.lblSnoDvc9.Location = new System.Drawing.Point(7, 45);
            this.lblSnoDvc9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSnoDvc9.Name = "lblSnoDvc9";
            this.lblSnoDvc9.Size = new System.Drawing.Size(65, 15);
            this.lblSnoDvc9.TabIndex = 141;
            this.lblSnoDvc9.Text = "Serial No.";
            // 
            // lblTestRmkDvc9
            // 
            this.lblTestRmkDvc9.AutoSize = true;
            this.lblTestRmkDvc9.Location = new System.Drawing.Point(157, 379);
            this.lblTestRmkDvc9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTestRmkDvc9.Name = "lblTestRmkDvc9";
            this.lblTestRmkDvc9.Size = new System.Drawing.Size(52, 15);
            this.lblTestRmkDvc9.TabIndex = 140;
            this.lblTestRmkDvc9.Text = "備註欄";
            // 
            // txtTestRmkDvc9
            // 
            this.txtTestRmkDvc9.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtTestRmkDvc9.Location = new System.Drawing.Point(215, 378);
            this.txtTestRmkDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.txtTestRmkDvc9.Name = "txtTestRmkDvc9";
            this.txtTestRmkDvc9.Size = new System.Drawing.Size(208, 25);
            this.txtTestRmkDvc9.TabIndex = 139;
            // 
            // btnBurnStopDvc9
            // 
            this.btnBurnStopDvc9.Location = new System.Drawing.Point(215, 330);
            this.btnBurnStopDvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnStopDvc9.Name = "btnBurnStopDvc9";
            this.btnBurnStopDvc9.Size = new System.Drawing.Size(208, 40);
            this.btnBurnStopDvc9.TabIndex = 138;
            this.btnBurnStopDvc9.Text = "Burn-in Stop / 中斷燒機";
            this.btnBurnStopDvc9.UseVisualStyleBackColor = true;
            this.btnBurnStopDvc9.Click += new System.EventHandler(this.btnBurnStopDvc9_Click);
            // 
            // btnBurn1hrDvc9
            // 
            this.btnBurn1hrDvc9.Location = new System.Drawing.Point(215, 252);
            this.btnBurn1hrDvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurn1hrDvc9.Name = "btnBurn1hrDvc9";
            this.btnBurn1hrDvc9.Size = new System.Drawing.Size(208, 40);
            this.btnBurn1hrDvc9.TabIndex = 137;
            this.btnBurn1hrDvc9.Text = "Burn-in 1hr";
            this.btnBurn1hrDvc9.UseVisualStyleBackColor = true;
            this.btnBurn1hrDvc9.Click += new System.EventHandler(this.btnBurn1hrDvc9_Click);
            // 
            // lblBurnRestDvc9
            // 
            this.lblBurnRestDvc9.AutoSize = true;
            this.lblBurnRestDvc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurnRestDvc9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBurnRestDvc9.Location = new System.Drawing.Point(11, 299);
            this.lblBurnRestDvc9.Name = "lblBurnRestDvc9";
            this.lblBurnRestDvc9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblBurnRestDvc9.Size = new System.Drawing.Size(132, 28);
            this.lblBurnRestDvc9.TabIndex = 136;
            this.lblBurnRestDvc9.Text = "Burn-in time";
            this.lblBurnRestDvc9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFinalDvc9
            // 
            this.lblFinalDvc9.AutoSize = true;
            this.lblFinalDvc9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalDvc9.Location = new System.Drawing.Point(11, 270);
            this.lblFinalDvc9.Name = "lblFinalDvc9";
            this.lblFinalDvc9.Size = new System.Drawing.Size(116, 26);
            this.lblFinalDvc9.TabIndex = 135;
            this.lblFinalDvc9.Text = "Final result";
            // 
            // lblDevIdDvc9
            // 
            this.lblDevIdDvc9.AutoSize = true;
            this.lblDevIdDvc9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDevIdDvc9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevIdDvc9.ForeColor = System.Drawing.Color.Blue;
            this.lblDevIdDvc9.Location = new System.Drawing.Point(11, 345);
            this.lblDevIdDvc9.Name = "lblDevIdDvc9";
            this.lblDevIdDvc9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDevIdDvc9.Size = new System.Drawing.Size(99, 24);
            this.lblDevIdDvc9.TabIndex = 134;
            this.lblDevIdDvc9.Text = "Device_ID";
            this.lblDevIdDvc9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpStaDvc9
            // 
            this.grpStaDvc9.Controls.Add(this.radSta4Dvc9);
            this.grpStaDvc9.Controls.Add(this.radSta3Dvc9);
            this.grpStaDvc9.Controls.Add(this.radSta2Dvc9);
            this.grpStaDvc9.Controls.Add(this.radSta1Dvc9);
            this.grpStaDvc9.Controls.Add(this.radSta0Dvc9);
            this.grpStaDvc9.Controls.Add(this.button45);
            this.grpStaDvc9.Controls.Add(this.button46);
            this.grpStaDvc9.Enabled = false;
            this.grpStaDvc9.Location = new System.Drawing.Point(7, 139);
            this.grpStaDvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc9.Name = "grpStaDvc9";
            this.grpStaDvc9.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpStaDvc9.Size = new System.Drawing.Size(407, 71);
            this.grpStaDvc9.TabIndex = 133;
            this.grpStaDvc9.TabStop = false;
            this.grpStaDvc9.Text = "station 站別";
            // 
            // radSta4Dvc9
            // 
            this.radSta4Dvc9.AutoSize = true;
            this.radSta4Dvc9.Location = new System.Drawing.Point(13, 44);
            this.radSta4Dvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta4Dvc9.Name = "radSta4Dvc9";
            this.radSta4Dvc9.Size = new System.Drawing.Size(79, 19);
            this.radSta4Dvc9.TabIndex = 5;
            this.radSta4Dvc9.Text = "Station 4";
            this.radSta4Dvc9.UseVisualStyleBackColor = true;
            // 
            // radSta3Dvc9
            // 
            this.radSta3Dvc9.AutoSize = true;
            this.radSta3Dvc9.Location = new System.Drawing.Point(309, 21);
            this.radSta3Dvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta3Dvc9.Name = "radSta3Dvc9";
            this.radSta3Dvc9.Size = new System.Drawing.Size(79, 19);
            this.radSta3Dvc9.TabIndex = 4;
            this.radSta3Dvc9.Text = "Station 3";
            this.radSta3Dvc9.UseVisualStyleBackColor = true;
            // 
            // radSta2Dvc9
            // 
            this.radSta2Dvc9.AutoSize = true;
            this.radSta2Dvc9.Location = new System.Drawing.Point(211, 21);
            this.radSta2Dvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta2Dvc9.Name = "radSta2Dvc9";
            this.radSta2Dvc9.Size = new System.Drawing.Size(79, 19);
            this.radSta2Dvc9.TabIndex = 3;
            this.radSta2Dvc9.Text = "Station 2";
            this.radSta2Dvc9.UseVisualStyleBackColor = true;
            // 
            // radSta1Dvc9
            // 
            this.radSta1Dvc9.AutoSize = true;
            this.radSta1Dvc9.Location = new System.Drawing.Point(112, 21);
            this.radSta1Dvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta1Dvc9.Name = "radSta1Dvc9";
            this.radSta1Dvc9.Size = new System.Drawing.Size(79, 19);
            this.radSta1Dvc9.TabIndex = 2;
            this.radSta1Dvc9.Text = "Station 1";
            this.radSta1Dvc9.UseVisualStyleBackColor = true;
            // 
            // radSta0Dvc9
            // 
            this.radSta0Dvc9.AutoSize = true;
            this.radSta0Dvc9.Location = new System.Drawing.Point(13, 21);
            this.radSta0Dvc9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radSta0Dvc9.Name = "radSta0Dvc9";
            this.radSta0Dvc9.Size = new System.Drawing.Size(79, 19);
            this.radSta0Dvc9.TabIndex = 0;
            this.radSta0Dvc9.Text = "Station 0";
            this.radSta0Dvc9.UseVisualStyleBackColor = true;
            // 
            // button45
            // 
            this.button45.Location = new System.Drawing.Point(212, -64);
            this.button45.Margin = new System.Windows.Forms.Padding(4);
            this.button45.Name = "button45";
            this.button45.Size = new System.Drawing.Size(195, 58);
            this.button45.TabIndex = 10;
            this.button45.Text = "Clear";
            this.button45.UseVisualStyleBackColor = true;
            // 
            // button46
            // 
            this.button46.Location = new System.Drawing.Point(0, -64);
            this.button46.Margin = new System.Windows.Forms.Padding(4);
            this.button46.Name = "button46";
            this.button46.Size = new System.Drawing.Size(195, 58);
            this.button46.TabIndex = 0;
            this.button46.Text = "OpenPort";
            this.button46.UseVisualStyleBackColor = true;
            // 
            // txtSnoDvc9
            // 
            this.txtSnoDvc9.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSnoDvc9.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtSnoDvc9.Location = new System.Drawing.Point(80, 42);
            this.txtSnoDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnoDvc9.Name = "txtSnoDvc9";
            this.txtSnoDvc9.Size = new System.Drawing.Size(335, 25);
            this.txtSnoDvc9.TabIndex = 126;
            this.txtSnoDvc9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSnoDvc9_MouseClick);
            // 
            // btnClearDvc9
            // 
            this.btnClearDvc9.Location = new System.Drawing.Point(219, 75);
            this.btnClearDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearDvc9.Name = "btnClearDvc9";
            this.btnClearDvc9.Size = new System.Drawing.Size(195, 58);
            this.btnClearDvc9.TabIndex = 132;
            this.btnClearDvc9.Text = "Clear";
            this.btnClearDvc9.UseVisualStyleBackColor = true;
            // 
            // lblBaudDvc9
            // 
            this.lblBaudDvc9.AutoSize = true;
            this.lblBaudDvc9.Location = new System.Drawing.Point(211, 14);
            this.lblBaudDvc9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaudDvc9.Name = "lblBaudDvc9";
            this.lblBaudDvc9.Size = new System.Drawing.Size(61, 15);
            this.lblBaudDvc9.TabIndex = 131;
            this.lblBaudDvc9.Text = "BaudRate";
            // 
            // lblComDvc9
            // 
            this.lblComDvc9.AutoSize = true;
            this.lblComDvc9.Location = new System.Drawing.Point(7, 14);
            this.lblComDvc9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComDvc9.Name = "lblComDvc9";
            this.lblComDvc9.Size = new System.Drawing.Size(39, 15);
            this.lblComDvc9.TabIndex = 130;
            this.lblComDvc9.Text = "COM";
            // 
            // cboBaudDvc9
            // 
            this.cboBaudDvc9.Enabled = false;
            this.cboBaudDvc9.FormattingEnabled = true;
            this.cboBaudDvc9.Location = new System.Drawing.Point(284, 11);
            this.cboBaudDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.cboBaudDvc9.Name = "cboBaudDvc9";
            this.cboBaudDvc9.Size = new System.Drawing.Size(129, 23);
            this.cboBaudDvc9.TabIndex = 129;
            // 
            // cboComDvc9
            // 
            this.cboComDvc9.FormattingEnabled = true;
            this.cboComDvc9.Location = new System.Drawing.Point(80, 11);
            this.cboComDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.cboComDvc9.Name = "cboComDvc9";
            this.cboComDvc9.Size = new System.Drawing.Size(100, 23);
            this.cboComDvc9.TabIndex = 128;
            // 
            // btnTestDvc9
            // 
            this.btnTestDvc9.Location = new System.Drawing.Point(7, 75);
            this.btnTestDvc9.Margin = new System.Windows.Forms.Padding(4);
            this.btnTestDvc9.Name = "btnTestDvc9";
            this.btnTestDvc9.Size = new System.Drawing.Size(195, 58);
            this.btnTestDvc9.TabIndex = 127;
            this.btnTestDvc9.Text = "Test";
            this.btnTestDvc9.UseVisualStyleBackColor = true;
            this.btnTestDvc9.Click += new System.EventHandler(this.btnTestDvc9_Click);
            // 
            // tabPage_Test
            // 
            this.tabPage_Test.BackColor = System.Drawing.Color.LightCoral;
            this.tabPage_Test.Controls.Add(this.btnCloseCom);
            this.tabPage_Test.Controls.Add(this.chkTempRec);
            this.tabPage_Test.Controls.Add(this.lblTempChkTime);
            this.tabPage_Test.Controls.Add(this.txtTempChkTime);
            this.tabPage_Test.Controls.Add(this.txtBurnTime);
            this.tabPage_Test.Controls.Add(this.lblBrunTimeSet);
            this.tabPage_Test.Controls.Add(this.btnBurnTimeSet);
            this.tabPage_Test.Controls.Add(this.cboComList);
            this.tabPage_Test.Controls.Add(this.lblDevice);
            this.tabPage_Test.Controls.Add(this.cboDevNo);
            this.tabPage_Test.Controls.Add(this.txtParameter);
            this.tabPage_Test.Controls.Add(this.label4);
            this.tabPage_Test.Controls.Add(this.cboAtSetCmd);
            this.tabPage_Test.Controls.Add(this.btnAtSetCmdSend);
            this.tabPage_Test.Controls.Add(this.btnBisRead);
            this.tabPage_Test.Controls.Add(this.btnBisSet);
            this.tabPage_Test.Controls.Add(this.btnStationSet);
            this.tabPage_Test.Controls.Add(this.cboBis);
            this.tabPage_Test.Controls.Add(this.lblBisStatus);
            this.tabPage_Test.Controls.Add(this.cboStaSet);
            this.tabPage_Test.Controls.Add(this.lblStaSet);
            this.tabPage_Test.Controls.Add(this.lblCmdList);
            this.tabPage_Test.Controls.Add(this.cboCmdList);
            this.tabPage_Test.Controls.Add(this.btnCmdSend);
            this.tabPage_Test.Controls.Add(this.tbxAtReturn);
            this.tabPage_Test.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPage_Test.Location = new System.Drawing.Point(4, 46);
            this.tabPage_Test.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Test.Name = "tabPage_Test";
            this.tabPage_Test.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage_Test.Size = new System.Drawing.Size(429, 420);
            this.tabPage_Test.TabIndex = 1;
            this.tabPage_Test.Text = "Engineer_Setting";
            // 
            // btnCloseCom
            // 
            this.btnCloseCom.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseCom.Location = new System.Drawing.Point(337, 32);
            this.btnCloseCom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseCom.Name = "btnCloseCom";
            this.btnCloseCom.Size = new System.Drawing.Size(85, 24);
            this.btnCloseCom.TabIndex = 81;
            this.btnCloseCom.Text = "ClosePort";
            this.btnCloseCom.UseVisualStyleBackColor = true;
            this.btnCloseCom.Click += new System.EventHandler(this.btnCloseCom_Click);
            // 
            // chkTempRec
            // 
            this.chkTempRec.AutoSize = true;
            this.chkTempRec.Location = new System.Drawing.Point(295, 125);
            this.chkTempRec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkTempRec.Name = "chkTempRec";
            this.chkTempRec.Size = new System.Drawing.Size(128, 19);
            this.chkTempRec.TabIndex = 80;
            this.chkTempRec.Text = "chkTempRecord?";
            this.chkTempRec.UseVisualStyleBackColor = true;
            this.chkTempRec.CheckedChanged += new System.EventHandler(this.chkTempRec_CheckedChanged);
            // 
            // lblTempChkTime
            // 
            this.lblTempChkTime.AutoSize = true;
            this.lblTempChkTime.Location = new System.Drawing.Point(332, 68);
            this.lblTempChkTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTempChkTime.Name = "lblTempChkTime";
            this.lblTempChkTime.Size = new System.Drawing.Size(93, 15);
            this.lblTempChkTime.TabIndex = 79;
            this.lblTempChkTime.Text = "TempChkPoint";
            // 
            // txtTempChkTime
            // 
            this.txtTempChkTime.Location = new System.Drawing.Point(348, 90);
            this.txtTempChkTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTempChkTime.Name = "txtTempChkTime";
            this.txtTempChkTime.Size = new System.Drawing.Size(72, 25);
            this.txtTempChkTime.TabIndex = 78;
            this.txtTempChkTime.Text = "0";
            this.txtTempChkTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTempChkTime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTempCheckTime_KeyDown);
            // 
            // txtBurnTime
            // 
            this.txtBurnTime.Location = new System.Drawing.Point(96, 121);
            this.txtBurnTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBurnTime.Name = "txtBurnTime";
            this.txtBurnTime.Size = new System.Drawing.Size(95, 25);
            this.txtBurnTime.TabIndex = 77;
            this.txtBurnTime.Text = "0";
            this.txtBurnTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBrunTimeSet
            // 
            this.lblBrunTimeSet.AutoSize = true;
            this.lblBrunTimeSet.Location = new System.Drawing.Point(5, 128);
            this.lblBrunTimeSet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBrunTimeSet.Name = "lblBrunTimeSet";
            this.lblBrunTimeSet.Size = new System.Drawing.Size(83, 15);
            this.lblBrunTimeSet.TabIndex = 76;
            this.lblBrunTimeSet.Text = "BurnTimeSet";
            // 
            // btnBurnTimeSet
            // 
            this.btnBurnTimeSet.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBurnTimeSet.Location = new System.Drawing.Point(196, 121);
            this.btnBurnTimeSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBurnTimeSet.Name = "btnBurnTimeSet";
            this.btnBurnTimeSet.Size = new System.Drawing.Size(85, 25);
            this.btnBurnTimeSet.TabIndex = 75;
            this.btnBurnTimeSet.Text = "SetTime";
            this.btnBurnTimeSet.UseVisualStyleBackColor = true;
            this.btnBurnTimeSet.Click += new System.EventHandler(this.btnBurnTimeSet_Click);
            // 
            // cboComList
            // 
            this.cboComList.Enabled = false;
            this.cboComList.FormattingEnabled = true;
            this.cboComList.Location = new System.Drawing.Point(331, 4);
            this.cboComList.Margin = new System.Windows.Forms.Padding(4);
            this.cboComList.Name = "cboComList";
            this.cboComList.Size = new System.Drawing.Size(89, 23);
            this.cboComList.TabIndex = 74;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(220, 8);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(46, 15);
            this.lblDevice.TabIndex = 72;
            this.lblDevice.Text = "Device";
            // 
            // cboDevNo
            // 
            this.cboDevNo.FormattingEnabled = true;
            this.cboDevNo.Location = new System.Drawing.Point(273, 4);
            this.cboDevNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboDevNo.Name = "cboDevNo";
            this.cboDevNo.Size = new System.Drawing.Size(51, 23);
            this.cboDevNo.TabIndex = 71;
            this.cboDevNo.SelectedIndexChanged += new System.EventHandler(this.cboDevNo_SelectedIndexChanged);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(196, 91);
            this.txtParameter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(61, 25);
            this.txtParameter.TabIndex = 70;
            this.txtParameter.Text = "0";
            this.txtParameter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 69;
            this.label4.Text = "CMD2";
            // 
            // cboAtSetCmd
            // 
            this.cboAtSetCmd.FormattingEnabled = true;
            this.cboAtSetCmd.Items.AddRange(new object[] {
            "AT+AFE",
            "AT+BIT",
            "AT+BIS",
            "AT+CURR",
            "AT+FMAX",
            "AT+FMIN",
            "AT+FREQ",
            "AT+ICE",
            "AT+MODE",
            "AT+O",
            "AT+PDP L",
            "AT+PDP T",
            "AT+PDN L",
            "AT+PDN T",
            "AT+STA"});
            this.cboAtSetCmd.Location = new System.Drawing.Point(60, 91);
            this.cboAtSetCmd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboAtSetCmd.Name = "cboAtSetCmd";
            this.cboAtSetCmd.Size = new System.Drawing.Size(129, 23);
            this.cboAtSetCmd.TabIndex = 68;
            // 
            // btnAtSetCmdSend
            // 
            this.btnAtSetCmdSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAtSetCmdSend.Location = new System.Drawing.Point(263, 91);
            this.btnAtSetCmdSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAtSetCmdSend.Name = "btnAtSetCmdSend";
            this.btnAtSetCmdSend.Size = new System.Drawing.Size(85, 24);
            this.btnAtSetCmdSend.TabIndex = 67;
            this.btnAtSetCmdSend.Text = "Cmd Send";
            this.btnAtSetCmdSend.UseVisualStyleBackColor = true;
            this.btnAtSetCmdSend.Click += new System.EventHandler(this.btnAtSetCmdSend_Click);
            // 
            // btnBisRead
            // 
            this.btnBisRead.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBisRead.Location = new System.Drawing.Point(220, 34);
            this.btnBisRead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBisRead.Name = "btnBisRead";
            this.btnBisRead.Size = new System.Drawing.Size(83, 22);
            this.btnBisRead.TabIndex = 66;
            this.btnBisRead.Text = "BIS_Read";
            this.btnBisRead.UseVisualStyleBackColor = true;
            this.btnBisRead.Click += new System.EventHandler(this.btnBisRead_Click);
            // 
            // btnBisSet
            // 
            this.btnBisSet.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBisSet.Location = new System.Drawing.Point(132, 34);
            this.btnBisSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBisSet.Name = "btnBisSet";
            this.btnBisSet.Size = new System.Drawing.Size(83, 22);
            this.btnBisSet.TabIndex = 65;
            this.btnBisSet.Text = "BIS_Set";
            this.btnBisSet.UseVisualStyleBackColor = true;
            this.btnBisSet.Click += new System.EventHandler(this.btnBisSet_Click);
            // 
            // btnStationSet
            // 
            this.btnStationSet.Enabled = false;
            this.btnStationSet.Location = new System.Drawing.Point(117, 2);
            this.btnStationSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStationSet.Name = "btnStationSet";
            this.btnStationSet.Size = new System.Drawing.Size(97, 25);
            this.btnStationSet.TabIndex = 64;
            this.btnStationSet.Text = "Station_Set";
            this.btnStationSet.UseVisualStyleBackColor = true;
            this.btnStationSet.Click += new System.EventHandler(this.btnStationSet_Click);
            // 
            // cboBis
            // 
            this.cboBis.Enabled = false;
            this.cboBis.FormattingEnabled = true;
            this.cboBis.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cboBis.Location = new System.Drawing.Point(79, 34);
            this.cboBis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboBis.Name = "cboBis";
            this.cboBis.Size = new System.Drawing.Size(47, 23);
            this.cboBis.TabIndex = 63;
            this.cboBis.Text = "0";
            // 
            // lblBisStatus
            // 
            this.lblBisStatus.AutoSize = true;
            this.lblBisStatus.Location = new System.Drawing.Point(5, 38);
            this.lblBisStatus.Name = "lblBisStatus";
            this.lblBisStatus.Size = new System.Drawing.Size(67, 15);
            this.lblBisStatus.TabIndex = 62;
            this.lblBisStatus.Text = "BIS_status";
            // 
            // cboStaSet
            // 
            this.cboStaSet.FormattingEnabled = true;
            this.cboStaSet.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.cboStaSet.Location = new System.Drawing.Point(60, 4);
            this.cboStaSet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboStaSet.Name = "cboStaSet";
            this.cboStaSet.Size = new System.Drawing.Size(51, 23);
            this.cboStaSet.TabIndex = 58;
            this.cboStaSet.Text = "0";
            // 
            // lblStaSet
            // 
            this.lblStaSet.AutoSize = true;
            this.lblStaSet.Location = new System.Drawing.Point(5, 8);
            this.lblStaSet.Name = "lblStaSet";
            this.lblStaSet.Size = new System.Drawing.Size(47, 15);
            this.lblStaSet.TabIndex = 57;
            this.lblStaSet.Text = "Station";
            // 
            // lblCmdList
            // 
            this.lblCmdList.AutoSize = true;
            this.lblCmdList.Location = new System.Drawing.Point(5, 71);
            this.lblCmdList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCmdList.Name = "lblCmdList";
            this.lblCmdList.Size = new System.Drawing.Size(46, 15);
            this.lblCmdList.TabIndex = 56;
            this.lblCmdList.Text = "CMD1";
            // 
            // cboCmdList
            // 
            this.cboCmdList.FormattingEnabled = true;
            this.cboCmdList.Items.AddRange(new object[] {
            "AT+?",
            "AT+AFE?",
            "AT+BIS?",
            "AT+BIT?",
            "AT+CURR?",
            "AT+FMAX?",
            "AT+FMIN?",
            "AT+FREQ?",
            "AT+ICE?",
            "AT+IOT",
            "AT+MEMS?",
            "AT+MODE?",
            "AT+O?",
            "AT+PDP? L",
            "AT+PDP? T",
            "AT+PDN? L",
            "AT+PDN? T",
            "AT+RST SYS",
            "AT+RST NVRAM",
            "AT+RET",
            "AT+STA?",
            "AT+T?",
            "AT+TEMP?",
            "AT+VER?",
            "@@"});
            this.cboCmdList.Location = new System.Drawing.Point(60, 64);
            this.cboCmdList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboCmdList.Name = "cboCmdList";
            this.cboCmdList.Size = new System.Drawing.Size(129, 23);
            this.cboCmdList.TabIndex = 55;
            // 
            // btnCmdSend
            // 
            this.btnCmdSend.Location = new System.Drawing.Point(196, 62);
            this.btnCmdSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCmdSend.Name = "btnCmdSend";
            this.btnCmdSend.Size = new System.Drawing.Size(85, 24);
            this.btnCmdSend.TabIndex = 17;
            this.btnCmdSend.Text = "Cmd Send";
            this.btnCmdSend.UseVisualStyleBackColor = true;
            this.btnCmdSend.Click += new System.EventHandler(this.btnCmdSend_Click);
            // 
            // tbxAtReturn
            // 
            this.tbxAtReturn.Location = new System.Drawing.Point(5, 151);
            this.tbxAtReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAtReturn.Multiline = true;
            this.tbxAtReturn.Name = "tbxAtReturn";
            this.tbxAtReturn.ReadOnly = true;
            this.tbxAtReturn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxAtReturn.Size = new System.Drawing.Size(417, 255);
            this.tbxAtReturn.TabIndex = 16;
            this.tbxAtReturn.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // serialPort2
            // 
            this.serialPort2.BaudRate = 115200;
            // 
            // serialPort3
            // 
            this.serialPort3.BaudRate = 115200;
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // lblVerPs
            // 
            this.lblVerPs.AutoSize = true;
            this.lblVerPs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVerPs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerPs.ForeColor = System.Drawing.Color.Blue;
            this.lblVerPs.Location = new System.Drawing.Point(455, 31);
            this.lblVerPs.Name = "lblVerPs";
            this.lblVerPs.Size = new System.Drawing.Size(104, 24);
            this.lblVerPs.TabIndex = 79;
            this.lblVerPs.Text = "PS: version";
            this.lblVerPs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer6
            // 
            this.timer6.Interval = 1000;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 1000;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 1000;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // timer9
            // 
            this.timer9.Interval = 1000;
            this.timer9.Tick += new System.EventHandler(this.timer9_Tick);
            // 
            // timer10
            // 
            this.timer10.Interval = 1000;
            this.timer10.Tick += new System.EventHandler(this.timer10_Tick);
            // 
            // timer11
            // 
            this.timer11.Interval = 1000;
            this.timer11.Tick += new System.EventHandler(this.timer11_Tick);
            // 
            // timer12
            // 
            this.timer12.Interval = 1000;
            this.timer12.Tick += new System.EventHandler(this.timer12_Tick);
            // 
            // timer13
            // 
            this.timer13.Interval = 200;
            this.timer13.Tick += new System.EventHandler(this.timer13_Tick);
            // 
            // timer14
            // 
            this.timer14.Interval = 1000;
            this.timer14.Tick += new System.EventHandler(this.timer14_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(939, 27);
            this.menuStrip1.TabIndex = 80;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsFileToolStripMenuItem,
            this.loadJSONFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(47, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveAsFileToolStripMenuItem
            // 
            this.saveAsFileToolStripMenuItem.Name = "saveAsFileToolStripMenuItem";
            this.saveAsFileToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.saveAsFileToolStripMenuItem.Text = "Save as File";
            this.saveAsFileToolStripMenuItem.Click += new System.EventHandler(this.saveAsFileToolStripMenuItem_Click);
            // 
            // loadJSONFileToolStripMenuItem
            // 
            this.loadJSONFileToolStripMenuItem.Name = "loadJSONFileToolStripMenuItem";
            this.loadJSONFileToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.loadJSONFileToolStripMenuItem.Text = "Load JSON File";
            this.loadJSONFileToolStripMenuItem.Click += new System.EventHandler(this.loadJSONFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Enabled = false;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(60, 23);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Enabled = false;
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(73, 23);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(134, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer15
            // 
            this.timer15.Interval = 500;
            this.timer15.Tick += new System.EventHandler(this.timer15_Tick);
            // 
            // txtMac
            // 
            this.txtMac.Enabled = false;
            this.txtMac.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtMac.Location = new System.Drawing.Point(773, 28);
            this.txtMac.Margin = new System.Windows.Forms.Padding(4);
            this.txtMac.Name = "txtMac";
            this.txtMac.Size = new System.Drawing.Size(151, 25);
            this.txtMac.TabIndex = 90;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(699, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 91;
            this.label13.Text = "MAC :";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 502);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 25);
            this.statusStrip1.TabIndex = 93;
            this.statusStrip1.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 19);
            this.toolStripStatusLabel1.Text = "Status text";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 527);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMac);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblVerPs);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Mercury_E v1.2.8 - Burn_in-1To10";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Main.ResumeLayout(false);
            this.tabPage_Main.PerformLayout();
            this.grpStaDvc0.ResumeLayout(false);
            this.grpStaDvc0.PerformLayout();
            this.tabPage_Device1.ResumeLayout(false);
            this.tabPage_Device1.PerformLayout();
            this.grpStaDvc1.ResumeLayout(false);
            this.grpStaDvc1.PerformLayout();
            this.tabPage_Device2.ResumeLayout(false);
            this.tabPage_Device2.PerformLayout();
            this.grpStaDvc2.ResumeLayout(false);
            this.grpStaDvc2.PerformLayout();
            this.tabPage_Device3.ResumeLayout(false);
            this.tabPage_Device3.PerformLayout();
            this.grpStaDvc3.ResumeLayout(false);
            this.grpStaDvc3.PerformLayout();
            this.tabPage_Device4.ResumeLayout(false);
            this.tabPage_Device4.PerformLayout();
            this.grpStaDvc4.ResumeLayout(false);
            this.grpStaDvc4.PerformLayout();
            this.tabPage_Device5.ResumeLayout(false);
            this.tabPage_Device5.PerformLayout();
            this.grpStaDvc5.ResumeLayout(false);
            this.grpStaDvc5.PerformLayout();
            this.tabPage_Device6.ResumeLayout(false);
            this.tabPage_Device6.PerformLayout();
            this.grpStaDvc6.ResumeLayout(false);
            this.grpStaDvc6.PerformLayout();
            this.tabPage_Device7.ResumeLayout(false);
            this.tabPage_Device7.PerformLayout();
            this.grpStaDvc7.ResumeLayout(false);
            this.grpStaDvc7.PerformLayout();
            this.tabPage_Device8.ResumeLayout(false);
            this.tabPage_Device8.PerformLayout();
            this.grpStaDvc8.ResumeLayout(false);
            this.grpStaDvc8.PerformLayout();
            this.tabPage_Device9.ResumeLayout(false);
            this.tabPage_Device9.PerformLayout();
            this.grpStaDvc9.ResumeLayout(false);
            this.grpStaDvc9.PerformLayout();
            this.tabPage_Test.ResumeLayout(false);
            this.tabPage_Test.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Main;
        private System.Windows.Forms.TabPage tabPage_Test;
        private System.Windows.Forms.ComboBox cboSta0optDvc0;
        private System.Windows.Forms.Label lblSta0optDvc0;
        private System.Windows.Forms.Label lblPdGainSetD0;
        private System.Windows.Forms.ComboBox cboPdGainSetDvc0;
        private System.Windows.Forms.GroupBox grpStaDvc0;
        private System.Windows.Forms.RadioButton radSta4Dvc0;
        private System.Windows.Forms.RadioButton radSta3Dvc0;
        private System.Windows.Forms.RadioButton radSta2Dvc0;
        private System.Windows.Forms.RadioButton radSta1Dvc0;
        private System.Windows.Forms.RadioButton radSta0Dvc0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFinalDvc0;
        private System.Windows.Forms.Label lblSnoDvc0;
        private System.Windows.Forms.TextBox txtSnoDvc0;
        private System.Windows.Forms.Button btnClearDvc0;
        private System.Windows.Forms.Label lblBaudDvc0;
        private System.Windows.Forms.Label lblComDvc0;
        private System.Windows.Forms.ComboBox cboBaudDvc0;
        private System.Windows.Forms.Button btnTestDvc0;
        private System.Windows.Forms.TextBox tbxAtReturn;
        private System.Windows.Forms.Label lblCmdList;
        private System.Windows.Forms.ComboBox cboCmdList;
        private System.Windows.Forms.Button btnCmdSend;
        private System.Windows.Forms.Button btnMemsSetDvc0;
        private System.Windows.Forms.ComboBox cboStaSet;
        private System.Windows.Forms.Label lblStaSet;
        private System.Windows.Forms.Button btnMemsReadDvc0;
        private System.Windows.Forms.ComboBox cboBis;
        private System.Windows.Forms.Label lblBisStatus;
        private System.Windows.Forms.Button btnBisSet;
        private System.Windows.Forms.Button btnStationSet;
        private System.Windows.Forms.Button btnBisRead;
        private System.Windows.Forms.Button btnBurn1hrDvc0;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboAtSetCmd;
        private System.Windows.Forms.Button btnAtSetCmdSend;
        private System.Windows.Forms.Label lblTempDvc0;
        private System.Windows.Forms.Button btnTempReadDvc0;
        private System.Windows.Forms.TextBox txtTempDvc0;
        private System.Windows.Forms.Label lblSWver;
        private System.Windows.Forms.Label lblBurnRestDvc0;
        private System.Windows.Forms.Button btnBurnStopDvc0;
        private System.Windows.Forms.Label lblTestRmkDvc0;
        private System.Windows.Forms.TextBox txtTestRmkDvc0;
        private System.Windows.Forms.ComboBox cboDevNo;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.Label lblDevIdDvc0;
        private System.Windows.Forms.TabPage tabPage_Device1;
        private System.Windows.Forms.TabPage tabPage_Device2;
        private System.Windows.Forms.Label lblDevIdDvc1;
        private System.Windows.Forms.GroupBox grpStaDvc1;
        private System.Windows.Forms.RadioButton radSta4Dvc1;
        private System.Windows.Forms.RadioButton radSta3Dvc1;
        private System.Windows.Forms.RadioButton radSta2Dvc1;
        private System.Windows.Forms.RadioButton radSta1Dvc1;
        private System.Windows.Forms.RadioButton radSta0Dvc1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lblSnoDvc1;
        private System.Windows.Forms.TextBox txtSnoDvc1;
        private System.Windows.Forms.Button btnClearDvc1;
        private System.Windows.Forms.Label lblBaudDvc1;
        private System.Windows.Forms.Label lblComDvc1;
        private System.Windows.Forms.ComboBox cboBaudDvc1;
        private System.Windows.Forms.ComboBox cboComDvc1;
        private System.Windows.Forms.Button btnTestDvc1;
        private System.Windows.Forms.ComboBox cboComDvc0;
        private System.Windows.Forms.ComboBox cboComList;
        private System.IO.Ports.SerialPort serialPort2;
        private System.IO.Ports.SerialPort serialPort3;
        private System.Windows.Forms.Label lblBurnRestDvc1;
        private System.Windows.Forms.Label lblFinalDvc1;
        private System.Windows.Forms.Button btnBurnStopDvc1;
        private System.Windows.Forms.Button btnBurn1hrDvc1;
        private System.Windows.Forms.Label lblTestRmkDvc1;
        private System.Windows.Forms.TextBox txtTestRmkDvc1;
        private System.Windows.Forms.Label lblTestRmkDvc2;
        private System.Windows.Forms.TextBox txtTestRmkDvc2;
        private System.Windows.Forms.Button btnBurnStopDvc2;
        private System.Windows.Forms.Button btnBurn1hrDvc2;
        private System.Windows.Forms.Label lblBurnRestDvc2;
        private System.Windows.Forms.Label lblFinalDvc2;
        private System.Windows.Forms.Label lblDevIdDvc2;
        private System.Windows.Forms.GroupBox grpStaDvc2;
        private System.Windows.Forms.RadioButton radSta4Dvc2;
        private System.Windows.Forms.RadioButton radSta3Dvc2;
        private System.Windows.Forms.RadioButton radSta2Dvc2;
        private System.Windows.Forms.RadioButton radSta1Dvc2;
        private System.Windows.Forms.RadioButton radSta0Dvc2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label lblSnoDvc2;
        private System.Windows.Forms.TextBox txtSnoDvc2;
        private System.Windows.Forms.Button btnClearDvc2;
        private System.Windows.Forms.Label lblBaudDvc2;
        private System.Windows.Forms.Label lblComDvc2;
        private System.Windows.Forms.ComboBox cboBaudDvc2;
        private System.Windows.Forms.ComboBox cboComDvc2;
        private System.Windows.Forms.Button btnTestDvc2;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label lblVerPs;
        private System.Windows.Forms.TabPage tabPage_Device3;
        private System.Windows.Forms.TabPage tabPage_Device4;
        private System.Windows.Forms.TabPage tabPage_Device5;
        private System.Windows.Forms.TabPage tabPage_Device6;
        private System.Windows.Forms.TabPage tabPage_Device7;
        private System.Windows.Forms.TabPage tabPage_Device8;
        private System.Windows.Forms.TabPage tabPage_Device9;
        private System.Windows.Forms.Label lblTestRmkDvc3;
        private System.Windows.Forms.TextBox txtTestRmkDvc3;
        private System.Windows.Forms.Button btnBurnStopDvc3;
        private System.Windows.Forms.Button btnBurn1hrDvc3;
        private System.Windows.Forms.Label lblBurnRestDvc3;
        private System.Windows.Forms.Label lblFinalDvc3;
        private System.Windows.Forms.Label lblDevIdDvc3;
        private System.Windows.Forms.GroupBox grpStaDvc3;
        private System.Windows.Forms.RadioButton radSta4Dvc3;
        private System.Windows.Forms.RadioButton radSta3Dvc3;
        private System.Windows.Forms.RadioButton radSta2Dvc3;
        private System.Windows.Forms.RadioButton radSta1Dvc3;
        private System.Windows.Forms.RadioButton radSta0Dvc3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label lblSnoDvc3;
        private System.Windows.Forms.TextBox txtSnoDvc3;
        private System.Windows.Forms.Button btnClearDvc3;
        private System.Windows.Forms.Label lblBaudDvc3;
        private System.Windows.Forms.Label lblComDvc3;
        private System.Windows.Forms.ComboBox cboBaudDvc3;
        private System.Windows.Forms.ComboBox cboComDvc3;
        private System.Windows.Forms.Button btnTestDvc3;
        private System.Windows.Forms.Label lblSnoDvc4;
        private System.Windows.Forms.Label lblTestRmkDvc4;
        private System.Windows.Forms.TextBox txtTestRmkDvc4;
        private System.Windows.Forms.Button btnBurnStopDvc4;
        private System.Windows.Forms.Button btnBurn1hrDvc4;
        private System.Windows.Forms.Label lblBurnRestDvc4;
        private System.Windows.Forms.Label lblFinalDvc4;
        private System.Windows.Forms.Label lblDevIdDvc4;
        private System.Windows.Forms.GroupBox grpStaDvc4;
        private System.Windows.Forms.RadioButton radSta4Dvc4;
        private System.Windows.Forms.RadioButton radSta3Dvc4;
        private System.Windows.Forms.RadioButton radSta2Dvc4;
        private System.Windows.Forms.RadioButton radSta1Dvc4;
        private System.Windows.Forms.RadioButton radSta0Dvc4;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.TextBox txtSnoDvc4;
        private System.Windows.Forms.Button btnClearDvc4;
        private System.Windows.Forms.Label lblBaudDvc4;
        private System.Windows.Forms.Label lblComDvc4;
        private System.Windows.Forms.ComboBox cboBaudDvc4;
        private System.Windows.Forms.ComboBox cboComDvc4;
        private System.Windows.Forms.Button btnTestDvc4;
        private System.Windows.Forms.Label lblSnoDvc5;
        private System.Windows.Forms.Label lblTestRmkDvc5;
        private System.Windows.Forms.TextBox txtTestRmkDvc5;
        private System.Windows.Forms.Button btnBurnStopDvc5;
        private System.Windows.Forms.Button btnBurn1hrDvc5;
        private System.Windows.Forms.Label lblBurnRestDvc5;
        private System.Windows.Forms.Label lblFinalDvc5;
        private System.Windows.Forms.Label lblDevIdDvc5;
        private System.Windows.Forms.GroupBox grpStaDvc5;
        private System.Windows.Forms.RadioButton radSta4Dvc5;
        private System.Windows.Forms.RadioButton radSta3Dvc5;
        private System.Windows.Forms.RadioButton radSta2Dvc5;
        private System.Windows.Forms.RadioButton radSta1Dvc5;
        private System.Windows.Forms.RadioButton radSta0Dvc5;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox txtSnoDvc5;
        private System.Windows.Forms.Button btnClearDvc5;
        private System.Windows.Forms.Label lblBaudDvc5;
        private System.Windows.Forms.Label lblComDvc5;
        private System.Windows.Forms.ComboBox cboBaudDvc5;
        private System.Windows.Forms.ComboBox cboComDvc5;
        private System.Windows.Forms.Button btnTestDvc5;
        private System.Windows.Forms.Label lblSnoDvc6;
        private System.Windows.Forms.Label lblTestRmkDvc6;
        private System.Windows.Forms.TextBox txtTestRmkDvc6;
        private System.Windows.Forms.Button btnBurnStopDvc6;
        private System.Windows.Forms.Button btnBurn1hrDvc6;
        private System.Windows.Forms.Label lblBurnRestDvc6;
        private System.Windows.Forms.Label lblFinalDvc6;
        private System.Windows.Forms.Label lblDevIdDvc6;
        private System.Windows.Forms.GroupBox grpStaDvc6;
        private System.Windows.Forms.RadioButton radSta4Dvc6;
        private System.Windows.Forms.RadioButton radSta3Dvc6;
        private System.Windows.Forms.RadioButton radSta2Dvc6;
        private System.Windows.Forms.RadioButton radSta1Dvc6;
        private System.Windows.Forms.RadioButton radSta0Dvc6;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.TextBox txtSnoDvc6;
        private System.Windows.Forms.Button btnClearDvc6;
        private System.Windows.Forms.Label lblBaudDvc6;
        private System.Windows.Forms.Label lblComDvc6;
        private System.Windows.Forms.ComboBox cboBaudDvc6;
        private System.Windows.Forms.ComboBox cboComDvc6;
        private System.Windows.Forms.Button btnTestDvc6;
        private System.Windows.Forms.Label lblSnoDvc7;
        private System.Windows.Forms.Label lblTestRmkDvc7;
        private System.Windows.Forms.TextBox txtTestRmkDvc7;
        private System.Windows.Forms.Button btnBurnStopDvc7;
        private System.Windows.Forms.Button btnBurn1hrDvc7;
        private System.Windows.Forms.Label lblBurnRestDvc7;
        private System.Windows.Forms.Label lblFinalDvc7;
        private System.Windows.Forms.Label lblDevIdDvc7;
        private System.Windows.Forms.GroupBox grpStaDvc7;
        private System.Windows.Forms.RadioButton radSta4Dvc7;
        private System.Windows.Forms.RadioButton radSta3Dvc7;
        private System.Windows.Forms.RadioButton radSta2Dvc7;
        private System.Windows.Forms.RadioButton radSta1Dvc7;
        private System.Windows.Forms.RadioButton radSta0Dvc7;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button34;
        private System.Windows.Forms.TextBox txtSnoDvc7;
        private System.Windows.Forms.Button btnClearDvc7;
        private System.Windows.Forms.Label lblBaudDvc7;
        private System.Windows.Forms.Label lblComDvc7;
        private System.Windows.Forms.ComboBox cboBaudDvc7;
        private System.Windows.Forms.ComboBox cboComDvc7;
        private System.Windows.Forms.Button btnTestDvc7;
        private System.Windows.Forms.Label lblSnoDvc8;
        private System.Windows.Forms.Label lblTestRmkDvc8;
        private System.Windows.Forms.TextBox txtTestRmkDvc8;
        private System.Windows.Forms.Button btnBurnStopDvc8;
        private System.Windows.Forms.Button btnBurn1hrDvc8;
        private System.Windows.Forms.Label lblBurnRestDvc8;
        private System.Windows.Forms.Label lblFinalDvc8;
        private System.Windows.Forms.Label lblDevIdDvc8;
        private System.Windows.Forms.GroupBox grpStaDvc8;
        private System.Windows.Forms.RadioButton radSta4Dvc8;
        private System.Windows.Forms.RadioButton radSta3Dvc8;
        private System.Windows.Forms.RadioButton radSta2Dvc8;
        private System.Windows.Forms.RadioButton radSta1Dvc8;
        private System.Windows.Forms.RadioButton radSta0Dvc8;
        private System.Windows.Forms.Button button39;
        private System.Windows.Forms.Button button40;
        private System.Windows.Forms.TextBox txtSnoDvc8;
        private System.Windows.Forms.Button btnClearDvc8;
        private System.Windows.Forms.Label lblBaudDvc8;
        private System.Windows.Forms.Label lblComDvc8;
        private System.Windows.Forms.ComboBox cboBaudDvc8;
        private System.Windows.Forms.ComboBox cboComDvc8;
        private System.Windows.Forms.Button btnTestDvc8;
        private System.Windows.Forms.Label lblSnoDvc9;
        private System.Windows.Forms.Label lblTestRmkDvc9;
        private System.Windows.Forms.TextBox txtTestRmkDvc9;
        private System.Windows.Forms.Button btnBurnStopDvc9;
        private System.Windows.Forms.Button btnBurn1hrDvc9;
        private System.Windows.Forms.Label lblBurnRestDvc9;
        private System.Windows.Forms.Label lblFinalDvc9;
        private System.Windows.Forms.Label lblDevIdDvc9;
        private System.Windows.Forms.GroupBox grpStaDvc9;
        private System.Windows.Forms.RadioButton radSta4Dvc9;
        private System.Windows.Forms.RadioButton radSta3Dvc9;
        private System.Windows.Forms.RadioButton radSta2Dvc9;
        private System.Windows.Forms.RadioButton radSta1Dvc9;
        private System.Windows.Forms.RadioButton radSta0Dvc9;
        private System.Windows.Forms.Button button45;
        private System.Windows.Forms.Button button46;
        private System.Windows.Forms.TextBox txtSnoDvc9;
        private System.Windows.Forms.Button btnClearDvc9;
        private System.Windows.Forms.Label lblBaudDvc9;
        private System.Windows.Forms.Label lblComDvc9;
        private System.Windows.Forms.ComboBox cboBaudDvc9;
        private System.Windows.Forms.ComboBox cboComDvc9;
        private System.Windows.Forms.Button btnTestDvc9;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
        private System.Windows.Forms.Button btnBurnAll;
        private System.Windows.Forms.Timer timer13;
        private System.Windows.Forms.TextBox txtBurnTime;
        private System.Windows.Forms.Label lblBrunTimeSet;
        private System.Windows.Forms.Button btnBurnTimeSet;
        private System.Windows.Forms.Label lblTempChkTime;
        private System.Windows.Forms.TextBox txtTempChkTime;
        private System.Windows.Forms.Timer timer14;
        private System.Windows.Forms.CheckBox chkTempRec;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadJSONFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnCloseCom;
        private System.Windows.Forms.Timer timer15;
        private System.Windows.Forms.TextBox txtMac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

