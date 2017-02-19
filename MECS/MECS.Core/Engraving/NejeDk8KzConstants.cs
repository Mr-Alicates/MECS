using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MECS.Core.Engraving
{
    /// <summary>
    /// This class contains the constants and commands necessary to operate the 
    /// Neje DK-8-KZ engraving machine
    /// </summary>
    public static class NejeDk8KzConstants
    {
        /// <summary>
        /// This indicates the minimum value for engraving intensity
        /// </summary>
        public const byte MinimumIntensity = 1;

        /// <summary>
        /// This indicates the maximum value for engraving intensity
        /// </summary>
        public const byte MaximumIntensity = 120;

        /// <summary>
        /// This is the time to wait after sending an erase command or an image
        /// </summary>
        public const int SleepTime = 1500;

        #region ConnectionParameters

        /// <summary>
        /// This indicates the baud rate of the underlying serial connection
        /// </summary>
        public const int BaudRate = 57600;

        /// <summary>
        /// This indicates the parity of the underlying serial connection
        /// </summary>
        public const Parity Parity = System.IO.Ports.Parity.None;

        /// <summary>
        /// This indicates the number of data bits of the underlying serial connection
        /// </summary>
        public const int DataBits = 8;

        /// <summary>
        /// This indicates the Stop Bits of the underlying serial communication
        /// </summary>
        public const StopBits StopBits = System.IO.Ports.StopBits.One;


        #endregion

        #region Commands

        /// <summary>
        /// This is the command to be sent when opening the communication with the machine
        /// </summary>
        public const byte ConnectCommand = 0xF6;

        /// <summary>
        /// This is the first byte of a move command. It is to be followed by another move command (Up, Down, Left or Right)
        /// </summary>
        public const byte MoveCommand = 0xF5;

        /// <summary>
        /// This indicates the machine to move up one pixel
        /// </summary>
        public const byte MoveUpCommand = 0x01;

        /// <summary>
        /// This indicates the machine to move down one pixel
        /// </summary>
        public const byte MoveDownCommand = 0x02;

        /// <summary>
        /// This indicates the machine to move left one pixel
        /// </summary>
        public const byte MoveLeftCommand = 0x03;

        /// <summary>
        /// This indicates the machine to move right one pixel
        /// </summary>
        public const byte MoveRightCommand = 0x04;
        
        /// <summary>
        /// This indicates the machine to move to the origin
        /// </summary>
        public const byte OriginCommand = 0xF3;

        /// <summary>
        /// This indicates the machine to move to the center of the current picture
        /// </summary>
        public const byte CenterCommand = 0xFB;

        /// <summary>
        /// This indicates the machine to start previewing the picture to be engraved
        /// </summary>
        public const byte PreviewCommand = 0xF4;

        /// <summary>
        /// This indicates the machine to start the engraving process
        /// </summary>
        public const byte StartCommand = 0xF1;

        /// <summary>
        /// This indicates the machine to reboot
        /// </summary>
        public const byte RestartCommand = 0xF9;

        /// <summary>
        /// This indicates the machine to pause the engraving
        /// </summary>
        public const byte PauseCommand = 0xF2;

        /// <summary>
        /// This is the erase command. It is to be sent 8 consecutive times.
        /// </summary>
        public const byte EraseCommand = 0xFE;

        #endregion

        #region Responses

        /// <summary>
        /// This is the expected handshake from the machine after opening the connection
        /// </summary>
        public const byte ConnectResponse = 0x65;

        /// <summary>
        /// This is the response the machine sends when it wants to report the engraving has finished
        /// </summary>
        public const byte EngravingFinishedResponse = 0x66;

        /// <summary>
        /// This is the response the machine sends during the engraving process to report the current position.
        /// </summary>
        public const byte PositionUpdatedResponse = 0xFF;

        #endregion
    }
}
