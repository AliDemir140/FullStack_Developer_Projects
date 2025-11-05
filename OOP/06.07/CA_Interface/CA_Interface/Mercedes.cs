namespace CA_Interface
{
    public class Mercedes : Otomobil,IYetenek
    {
        public override string MaxHiz()
        {
            return $"{Marka}-{Model} max hızı 320 km/h";
        }

        public string OtoPilot()
        {
            return $"{Marka}-{Model} otopilot aktif";
        }
    }
}
