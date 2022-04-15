using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionAndInterface
{
    public class VendorBusiness
    {
        //Markaları nereye kaydedeceği hakkında bir bilgi veya yönlendirme yok! (SQL, XML, Oracle vb. )
        public DataSource DataSource { get; set; }


    }

    public class Recorder
    {
        public void RecordData(IRecordable recordable)
        {
            recordable.SaveData("test");
        }
    }
}
