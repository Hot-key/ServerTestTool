using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CGD;
using SuperSocket.ClientEngine;

namespace ServerTestTool.Network
{
    public class EchoClient
    {

        private static CGD.NcsBuffer sendBuffer;

        public static Int64 sendCount = 0;
        public static Int64 recvCount = 0;
        public static Int64 connectCount = 0;

        private static HashSet<AsyncTcpSession> _tcpSession = new HashSet<AsyncTcpSession>();

        private static Stopwatch _countStopwatch = new Stopwatch();

        public static IPEndPoint iPEndPoint = new IPEndPoint(0, 0);


        public static void InitClient(string ip, int port)
        {
            iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
        }

        public static void InitBuffer(string Data)
        {
            var byteArray = Data.Split(' ');
            sendBuffer = new NcsBuffer(byteArray.Length);

            foreach (var byteData in byteArray)
            {
                sendBuffer.append<byte>(Convert.ToByte(byteData, 16));
            }
        }

        public static void RequestConnect(int countConnect)
        {
            lock (_tcpSession)
            {
                for (int i = 0; i < countConnect; i++)
                {
                    AsyncTcpSession socket = new AsyncTcpSession();
                    _tcpSession.Add(socket);


                    socket.Connected += tcpSession_Connected;
                    socket.Closed += tcpSession_Closed;
                    socket.DataReceived += tcpSession_DataReceived;
                    socket.Connect(iPEndPoint);
                }
            }
        }

        public static void SendData(int count)
        {
            lock (_tcpSession)
            {
                foreach (var socket in _tcpSession)
                {
                    for (int i = 0; i < count; i++)
                    {
                        socket.Send(sendBuffer);
                        Interlocked.Increment(ref sendCount);
                    }
                }
            }
        }

        private static void tcpSession_DataReceived(object sender, DataEventArgs e)
        {
            byte[] tmpBuffer = e.Data;

            var tmpLen = e.Length;

            while (tmpLen != 0)
            {
                tmpLen -= sendBuffer.len;
                Interlocked.Increment(ref recvCount);
            }

        }

        private static void tcpSession_Closed(object sender, EventArgs e)
        {
            AsyncTcpSession session = sender as AsyncTcpSession;

            _tcpSession.Remove(session);
            Interlocked.Decrement(ref connectCount);
        }

        private static void tcpSession_Connected(object sender, EventArgs e)
        {
            Interlocked.Increment(ref connectCount);
        }
    }
}
