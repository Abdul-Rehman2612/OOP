namespace Challenge_5
{
    internal class AUDI: Car
    {
        public string SModel;
        public bool AudiDriveSelect;
        public bool TrafficJamAssist;
        public bool NightVisionAssistant;
        public AUDI(string SModel,bool AudiDriveSelect,bool TrafficJamAssist,bool NightVisionAssist,string model,string color,int price) : base(model, color, price)
        {
            this.SModel = SModel;
        }
        public double CalculateConsumption(int distance)
        {
            return distance*0.5;
        }
        public void SetAudiDriveSelect() { if (AudiDriveSelect) AudiDriveSelect=false; else AudiDriveSelect=true; }
        public void SetTrafficJamAssist() { if (TrafficJamAssist) TrafficJamAssist=false; else TrafficJamAssist=true; }
        public void SetNightVisionAssistant() { if (NightVisionAssistant) NightVisionAssistant=false; else NightVisionAssistant=true; }
        public bool GetAudiDriveSelect() { return AudiDriveSelect; }
        public bool GetTrafficJamAssist() {  return TrafficJamAssist; }
        public bool GetNightVisionAssistant() {  return NightVisionAssistant; }
    }
}
