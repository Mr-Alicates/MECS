using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MECS.Core.Contracts;

namespace MECS.Core.Engraving
{
    public class MockEngraver : IEngraver
    {
        public void Dispose()
        {
            
        }

        public bool IsOpen { get; private set; }
        public bool Connect(string port)
        {
            IsOpen = true;
            return IsOpen;
        }

        public void MoveUp()
        {

        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveToCenter()
        {

        }

        public void MoveToOrigin()
        {

        }

        public void Preview()
        {

        }

        public void SetBurningTime(byte intensity)
        {

        }

        public void Restart()
        {

        }

        public void Pause()
        {
            
        }

        public void Start()
        {

        }

        public void EraseImage()
        {

        }

        public void SendImage(string pathToImage)
        {

        }
    }
}
