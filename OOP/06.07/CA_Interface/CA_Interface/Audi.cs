namespace CA_Interface
{
    public class Audi : Otomobil, IYetenek,ITemelBilesenler,IBilesen
    {
        public string KoltukIsıtma()
        {
            throw new NotImplementedException();
        }

        public override string MaxHiz()
        {
            return $"{Marka}-{Model} max hızı 250 km/h";
        }

        public string OtoPilot()
        {
            return $"{Marka}-{Model} otopilot aktif";
        }

        public string SunRoof()
        {
            throw new NotImplementedException();
        }

        public string YolBilgisayari()
        {
            throw new NotImplementedException();
        }
    }
}
