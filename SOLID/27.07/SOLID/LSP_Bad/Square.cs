namespace LSP_Bad
{
    internal class Square : Rectangle
    {


        private int _height;
        private int _width;


        public override int Height//2
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;//2
                _width = value;//2
            }
        }


        public override int Width
        {
            get
            {
                return _width;
            }

            set
            {
                _height = value;//2
                _width = value;//2
            }

        }
    }
}
