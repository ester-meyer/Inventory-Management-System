using DalApi;

namespace Dal
{
    sealed internal class DalXml : IDal
    {
        private static readonly IDal instance = new DalXml();
        public static IDal Instance
        {
            get { return instance; }
        }

        public ICustomer Customer => throw new NotImplementedException();

        public IProduct Product => throw new NotImplementedException();

        public ISale Sale => throw new NotImplementedException();

        private DalXml()
        {

        }

    }
}