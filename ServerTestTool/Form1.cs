using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CGD;
using ServerTestTool.Network;

namespace ServerTestTool
{
    public partial class Form1 : Form
    {
        private Int64 sendCount = 0;
        private Int64 recvCount = 0;
        private Int64 connectCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerControlsUpdate_Tick(object sender, EventArgs e)
        {
            var tmpSendCount = Interlocked.Read(ref EchoClient.sendCount);
            var tmpRecvCount = Interlocked.Read(ref EchoClient.recvCount);
            var tmpConCount = Interlocked.Read(ref EchoClient.connectCount);

            sendCount += tmpSendCount;
            recvCount += tmpRecvCount;
            connectCount += tmpConCount;

            labelConCount.Text  = tmpConCount.ToString();

            labelSendCount.Text = tmpSendCount.ToString();
            labelRecvCount.Text = tmpRecvCount.ToString();
            labelSumCount.Text = (tmpSendCount + tmpRecvCount).ToString();

            labelSendCountAll.Text = sendCount.ToString();
            labelRecvCountAll.Text = recvCount.ToString();
            labelSumCountAll.Text = (sendCount + recvCount).ToString();

            Interlocked.Add(ref EchoClient.sendCount, -tmpSendCount);
            Interlocked.Add(ref EchoClient.recvCount, -tmpRecvCount);
        }

        private void buttonCon1_Click(object sender, EventArgs e)
        {
            EchoClient.RequestConnect(1);
        }

        private void buttonCon100_Click(object sender, EventArgs e)
        {
            EchoClient.RequestConnect(100);
        }

        private void buttonConCount_Click(object sender, EventArgs e)
        {
            EchoClient.RequestConnect(Convert.ToInt32(textBoxConCount.Text));
        }

        private void buttonSend1_Click(object sender, EventArgs e)
        {
            EchoClient.SendData(1);
        }

        private void buttonSendCount_Click(object sender, EventArgs e)
        {
            EchoClient.SendData(Convert.ToInt32(textBoxSendCount.Text));
        }

        private void buttonSendLoop_Click(object sender, EventArgs e)
        {
            if (timerSendData.Enabled)
            {
                timerSendData.Stop();
            }
            else
            {
                timerSendData.Start();
            }
        }

        private void buttonInitEndPoint_Click(object sender, EventArgs e)
        {
            EchoClient.InitClient(textBoxIP.Text, Convert.ToInt32(textBoxPort.Text));
        }

        private void buttonSetBuffer_Click(object sender, EventArgs e)
        {
            EchoClient.InitBuffer(textBoxBufferText.Text);
        }

        private void timerSendData_Tick(object sender, EventArgs e)
        {
            EchoClient.SendData(Convert.ToInt32(textBoxSendCount.Text));
        }
    }
}
