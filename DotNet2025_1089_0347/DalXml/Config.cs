using System.Xml.Linq;

namespace DalXml
{

    internal class Config
    {
        private const string nextIdFilePath = @"..\xml\data-confige.xml";
        XElement nextIdXml = XElement.Load(nextIdFilePath);
        const string  NEXT_PRODUCT_ID = "NextProductId";
        const string  NEXT_SALE_ID = "NextSaleId";



        private int nextProductId;

        public int NextProductId
        {
            get
            {
                XElement nextProductIdE = nextIdXml.Element(NEXT_PRODUCT_ID);
                int.TryParse(nextProductIdE.Value,out nextProductId);
                nextProductIdE.SetValue(nextProductId + 1);
                return nextProductId;
            }
        }




        private int nextSaleId;

        public int NextSaleId
        {
            get
            {
                XElement nextSaleIdE = nextIdXml.Element(NEXT_SALE_ID);
                int.TryParse(nextSaleIdE.Value, out nextSaleId);
                nextSaleIdE.SetValue(nextSaleId + 1); 
                return nextSaleId;
            }
        }

    }
}
