using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;





namespace Modbus
{

    public class modbus
    {

        SerialPort mYserialPort;


        public modbus()
        {
           __PortNames = SerialPort.GetPortNames(); //获取串口名
        }

        public void GetSerialPortName() {       
           __PortNames = SerialPort.GetPortNames(); //获取串口名             
        }




 
        public bool SerialConnect(string comName, int baud, int dataBits, Parity parity, StopBits stopBits)
        {
            if (!mYserialPort.IsOpen)
            {
                mYserialPort.PortName = comName; //串口名
                mYserialPort.BaudRate = baud; //波特率            
                mYserialPort.DataBits = dataBits; //数据位
                mYserialPort.Parity = parity; //校验位
                mYserialPort.StopBits = stopBits; //停止位
                mYserialPort.Open(); //打开串口
            return true;
            }
            else { return false; }

        }






        string[] __PortNames;
        public string[] PortNames  //返回串口名
        {
            get { return __PortNames; }
        }


    }










}
