using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace _11.ChapterEleven
{
    public class CustomerAdapter : CustomerLogic, ICustomer
    {
        public override string GetCustomers()
        {
            string originalXml = base.GetCustomers();
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(originalXml);

            JsonSerializerSettings jsonSettings = new JsonSerializerSettings();
            jsonSettings.Formatting = Newtonsoft.Json.Formatting.Indented;

            var customers = JsonConvert.SerializeObject(xmlDoc, jsonSettings);

            return customers;

        }
    }
}
