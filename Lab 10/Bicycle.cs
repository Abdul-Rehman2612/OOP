namespace Challenge_2
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;
        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence=cadence;
            this.gear=gear;
            this.speed=speed;
        }
        public void SetCadence(int cadence) { this.cadence = cadence; }
        public int GetCadence() { return cadence; }
        public void SetGear(int gear) { this.gear = gear; }
        public int GetGear() { return gear; }
        public void SetSpeed(int speed) { this.speed = speed; }
        public int GetSpeed() { return speed; }
        public void ApplyBrake(int decrement) { if (speed-decrement>=0) { speed=speed-decrement; } }
        public void SpeedUp(int increment) { speed=speed+increment; }
    }
}
