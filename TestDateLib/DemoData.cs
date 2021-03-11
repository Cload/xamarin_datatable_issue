using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Threading;

namespace TestDateLib
{
    public static class DemoData
    {

        public const string XmlData = "<NewDataSet>   <xs:schema id=\"NewDataSet\" xmlns=\"\" xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:msdata=\"urn:schemas-microsoft-com:xml-msdata\">     <xs:element name=\"NewDataSet\" msdata:IsDataSet=\"true\" msdata:MainDataTable=\"dates\" msdata:UseCurrentLocale=\"true\">       <xs:complexType>         <xs:choice minOccurs=\"0\" maxOccurs=\"unbounded\">           <xs:element name=\"dates\">             <xs:complexType>               <xs:sequence>                 <xs:element name=\"date_col\" type=\"xs:dateTime\" minOccurs=\"0\" />               </xs:sequence>             </xs:complexType>           </xs:element>         </xs:choice>       </xs:complexType>     </xs:element>   </xs:schema>   <dates>     <date_col>2021-02-11T00:00:00+01:00</date_col>   </dates> </NewDataSet>";

        public static IEnumerable<DateTime> GetDateTimeFromDataTable()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            var result = new List<DateTime>();
            var dataTable = new DataTable();
            var textreader = new StringReader(XmlData);
            dataTable.ReadXml(textreader);
            foreach (DataRow row in dataTable.Rows)
            {
                result.Add((DateTime)row["date_col"]);
            }
            return result;
        }
    }
}
