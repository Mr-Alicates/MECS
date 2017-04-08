using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MECS.Core.Contracts
{
    public interface IEngraver : IDisposable
    {
        /// <summary>
        /// This indicates if the communication with the machine is open
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// This opens the connection and starts up the machine
        /// </summary>
        /// <param name="port"></param>
        /// <returns></returns>
        bool Connect(string port);

        /// <summary>
        /// This moves up the machine laser by one position.
        /// </summary>
        void MoveUp();

        /// <summary>
        /// This moves down the machine laser by one position.
        /// </summary>
        void MoveDown();

        /// <summary>
        /// This moves left the machine laser by one position.
        /// </summary>
        void MoveLeft();

        /// <summary>
        /// This moves right the machine laser by one position.
        /// </summary>
        void MoveRight();

        /// <summary>
        /// This moves the machine laser to the center of the image
        /// </summary>
        void MoveToCenter();

        /// <summary>
        /// This moves the machine laser to the origin position (0, 0), upper left corner
        /// </summary>
        void MoveToOrigin();

        /// <summary>
        /// This makes the machine to start the preview mode. 
        /// The machine circles arounds the limits of the image until another command arrives.
        /// </summary>
        void Preview();

        /// <summary>
        /// This sets the burning time for the engraver. 
        /// Higher means deeper engraving or burning.
        /// </summary>
        /// <param name="intensity"></param>
        void SetBurningTime(decimal intensity);

        /// <summary>
        /// This aborts whatever the machine was doing and restarts it.
        /// </summary>
        void RestartMachine();

        /// <summary>
        /// This pauses the engraving
        /// </summary>
        void PauseEngraving();

        /// <summary>
        /// This makes the machine to start engraving
        /// </summary>
        void StartEngraving();

        /// <summary>
        /// This erases the picture in the machine memory
        /// </summary>
        void EraseImage();

        /// <summary>
        /// This sends a new image to the machine memory. 
        /// The image is rescaled and processed to the machine format.
        /// </summary>
        /// <param name="image"></param>
        void SendImage(byte[] image);

        /// <summary>
        /// This retrieves the minimum burning time of the engraver
        /// </summary>
        /// <returns></returns>
        decimal GetMinimumBurningTime();

        /// <summary>
        /// This retrieves the maximum burning time of the engraver
        /// </summary>
        /// <returns></returns>
        decimal GetMaximumBurningTime();
    }
}
