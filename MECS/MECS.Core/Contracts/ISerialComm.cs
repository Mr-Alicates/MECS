using System;
using System.IO.Ports;

namespace MECS.Core.Contracts
{
    public interface ISerialComm : IDisposable
    {
        /// <summary>
        /// This indicates if the serial communication is open
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// This opens a new serial connection with the specified parameters
        /// </summary>
        /// <param name="port"></param>
        /// <param name="baudRate"></param>
        /// <param name="parity"></param>
        /// <param name="dataBits"></param>
        /// <param name="stopBits"></param>
        void Open(string port, int baudRate, Parity parity, int dataBits, StopBits stopBits);

        /// <summary>
        /// This writes one or more bytes into the connection
        /// </summary>
        /// <param name="data"></param>
        void Write(params byte[] data);

        /// <summary>
        /// This reads one byte from the connection
        /// </summary>
        /// <returns></returns>
        byte ReadOne();

        /// <summary>
        /// This reads the specified number of bytes from the connection. 
        /// If there are not enough bytes, the operation will block until there are.
        /// If not enough bytes are read before the timeout expires, an exception is thrown
        /// </summary>
        /// <param name="bytesToRead"></param>
        /// <returns></returns>
        byte[] ReadMany(int bytesToRead);
    }
}
