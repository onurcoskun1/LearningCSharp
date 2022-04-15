using System;

namespace AbstractionAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDataSource xmlDataSource = new XmlDataSource();
            SqlDataSource sqlDataSource = new SqlDataSource();

            VendorBusiness vendorBusiness = new VendorBusiness();
            vendorBusiness.DataSource = sqlDataSource;
            vendorBusiness.DataSource.GetData();

            vendorBusiness.DataSource = xmlDataSource;
            //vendorBusiness.DataSource.SaveData("Örnek veri");

            Recorder recorder = new Recorder();
            recorder.RecordData(new SqlDataSource());
            
        }
    }
}
