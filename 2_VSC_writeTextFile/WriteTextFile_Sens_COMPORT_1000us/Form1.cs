using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MicroLibrary;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;


namespace WriteTextFile_Sens
{
    public partial class Form1 : Form
    {
        int LENGTH = 7;
        // Declare MicroTimer
        private readonly MicroLibrary.MicroTimer _microTimer;

        char[] dataIN = new char[100000];          // Lưu trữ giá trị đọc được từ Serial Port
        UInt16 adcRaw1;

        Int32 count = 0;

        UInt16 flag_mcroSec = 0;

        StreamWriter objStreamWriter;
        string PathTxt = @"C:\Users\BaoThuan\OneDrive - The University of Technology\Desktop\PROJECT\GIT_HUB\0_DoCB_DKDC\2_VSC_writeTextFile\txtFile_Sens\test1.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*GIAO DIỆN BAN ĐẦU*/
            // COM - PORT
            cboxCOM.DataSource = SerialPort.GetPortNames();

            // Check box
            chboxDTR.Checked = false;
            serCOM.DtrEnable = false;

            chboxRTS.Checked = false;
            serCOM.RtsEnable = false;

            // Khởi tạo ZedGraph
            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.Title.Text = "Sense";
            myPane.XAxis.Title.Text = "Thời gian (1ms)";
            myPane.YAxis.Title.Text = "Độ rung/s (0-2.125V)";
            // myPane.YAxis.Title.Text = "Độ rung/s (mm/s)";

            PointPairList list = new PointPairList();
            LineItem curve = myPane.AddCurve("Mức độ nguy hiểm", list, Color.Red, SymbolType.None);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)   //  Nếu chưa nhận cổng COM
            {
                timer1.Start();
                // Khởi tạo cổng - bật cổng
                serCOM.PortName = cboxCOM.Text;
                serCOM.BaudRate = Convert.ToInt32(cboxBaud.Text);
                serCOM.DataBits = Convert.ToInt32(cboxDataB.Text);
                serCOM.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cboxStopB.Text);
                serCOM.Parity   = (Parity)Enum.Parse(typeof(Parity), cboxParB.Text);
                serCOM.Open();
                // Hiển thị trạng thái
                lbStatus.Text = "Connected";
                lbStatus.ForeColor = Color.Green;
            }
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)  //  Nếu đã nhận cổng COM
            {
                // objStreamWriter.Close();
                timer1.Stop();
                // Cắt cổng COM
                serCOM.Close();
                // Hiển thị trạng thái
                lbStatus.Text = "Disconnected";
                lbStatus.ForeColor = Color.Red;
            }
        }

        private void chboxDTR_CheckedChanged(object sender, EventArgs e)
        {
            if(chboxDTR.Checked)
                serCOM.DtrEnable = true;     
            else
                serCOM.DtrEnable = false;
        }

        private void chboxRTS_CheckedChanged_1(object sender, EventArgs e)
        {
            if(chboxRTS.Checked)
                serCOM.RtsEnable = true;
            else
                serCOM.RtsEnable = false;
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            if (txtBoxDataIN.Text != "")
                txtBoxDataIN.Text = "";
        }


        private void serCOM_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN = serCOM.ReadExisting().ToCharArray();
            // this.Invoke(new EventHandler(Showdata));
        }

        double time = 0;
        private void Showdata(object sender, EventArgs e)
        {
            //int dataINLength = dataIN.Length;
            //time++;
            //switch (dataINLength)
            //{
            //    case 0:
            //        break;
            //    case 7:
            //        lbLengthRX.Text = string.Format("{0:00}", dataINLength);
            //        adcRaw1 = (UInt16)(((dataIN[1]) << 8) | dataIN[0]);
            //        txtBoxDataIN.Text = Convert.ToString(adcRaw1);
            //        Draw_chart(time, adcRaw1);
            //        break;
            //    default:
            //        lbLengthRX.Text = string.Format("{0:00}", dataINLength);
            //        adcRaw1 = (UInt16)(((dataIN[1]) << 8) | dataIN[0]);
            //        txtBoxDataIN.Text = Convert.ToString(adcRaw1);
            //        Draw_chart(time, adcRaw1);
            //        break;
            //}


            // txtBoxDataIN.Text = dataIN.ToString();

            /*Ghi vao file txt*/
            //objStreamWriter = new StreamWriter(PathTxt, true);
            //objStreamWriter.WriteLine(dataIN);
            //objStreamWriter.Close();
        }

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {

        }

        private void Draw_chart(double x1, double y1)
        {
            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            IPointListEdit list = curve.Points as IPointListEdit;
            list.Add(x1, y1);

            Scale xScale = zedGraphControl1.GraphPane.XAxis.Scale;
            Scale yScale = zedGraphControl1.GraphPane.YAxis.Scale;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
            zedGraphControl1.Refresh();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            //time++;
            //Draw_chart(time, adcRaw1);
            int dataINLength = dataIN.Length;

            time++;
            switch (dataINLength)
            {
                case 0:
                    break;
                case 7:
                    lbLengthRX.Text = string.Format("{0:00}", dataINLength);
                    adcRaw1 = (UInt16)(((dataIN[1]) << 8) | dataIN[0]);
                    txtBoxDataIN.Text = Convert.ToString(adcRaw1);
                    Draw_chart(time, adcRaw1);
                    break;
                default:
                    lbLengthRX.Text = string.Format("{0:00}", dataINLength);
                    adcRaw1 = (UInt16)(((dataIN[1]) << 8) | dataIN[0]);
                    txtBoxDataIN.Text = Convert.ToString(adcRaw1);
                    Draw_chart(time, adcRaw1);
                    break;
            }

        }

        private void lbLengthRX_Click(object sender, EventArgs e)
        {

        }
    }
}
