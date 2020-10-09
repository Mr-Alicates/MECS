using System.Collections.Generic;
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

        public void SetBurningTime(decimal intensity)
        {

        }

        public void RestartMachine()
        {

        }

        public void PauseEngraving()
        {
            
        }

        public IEnumerable<EngraverPosition> StartEngraving()
        {
            return new List<EngraverPosition>();
        }

        public void EraseImage()
        {

        }
        
        public void SendImage(byte[] image)
        {
        }

        public decimal GetMinimumBurningTime()
        {
            return 1;
        }

        public decimal GetMaximumBurningTime()
        {
            return 100;
        }
    }
}
