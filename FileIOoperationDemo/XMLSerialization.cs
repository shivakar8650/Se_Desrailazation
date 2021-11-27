using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace FileIOoperationDemo
{
    class XMLSerialization
    {
        
        public void SerializeXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\XmlOperation.txt", FileMode.Create);
            OrderForm orderForm = new OrderForm();
            DateTime dt2 = new DateTime(2021, 11, 25);
            orderForm.OrderData = dt2;
            ser.Serialize(fileStream, orderForm);
            fileStream.Close();

        }

        public void DeserializeXML()
        {
            XmlSerializer ser = new XmlSerializer(typeof(OrderForm));
            FileStream fileStream = new FileStream(@"C:\Users\prabhakar\source\repos\FileIOoperationDemo\FileIOoperationDemo\XmlOperation.txt", FileMode.Open);
        
            OrderForm orderForm = (OrderForm)ser.Deserialize(fileStream);
            Console.WriteLine(orderForm.OrderData);
            fileStream.Close();

        }
    }



    public class OrderForm
    {
        public DateTime OrderData;
    }
}
