namespace CA_Interface
{
    public class Tesla : Otomobil,IYetenek

    {
        public override string MaxHiz()
        {
            return $"{Marka}-{Model} max hızı 280 km/h";
        }

        public string OtoPilot()
        {
            throw new NotImplementedException();
        }
    }
}
