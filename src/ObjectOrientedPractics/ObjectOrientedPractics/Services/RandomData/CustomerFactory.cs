using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ObjectOrientedPractics.Services.RandomData
{
    public static class CustomerFactory
    {
        public static List<Customer> GetCustomers(int count = 1)
        {
            List<Customer> customers = new List<Customer>();

            string baseUrl = "https://api.randomdatatools.ru/";
            string parametrs = $"?count={count}&params=FirstName,LastName,FatherName,Address";
            string url = baseUrl + parametrs;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = client.GetAsync(url).Result;

                    string json = response.Content.ReadAsStringAsync().Result;

                    JsonNode jsonNode = JsonNode.Parse(json);

                    if (jsonNode is JsonArray array)
                    {
                        foreach (JsonNode node in array)
                        {
                            Customer customer = CreateCustomer(node);
                            customers.Add(customer);
                        }
                    }
                    else if (jsonNode is JsonObject jsonObject)
                    {
                        Customer customer = CreateCustomer(jsonObject);
                        customers.Add(customer);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка: {ex}");
                }
            }

            return customers;
        }

        private static Customer CreateCustomer(JsonNode node)
        {
            string firstName = node["FirstName"].ToString();
            string lastName = node["LastName"].ToString();
            string fatherName = node["FatherName"].ToString();

            string fullName = $"{firstName} {lastName} {fatherName}";

            string address = node["Address"].ToString();

            return new Customer(fullName, address);
        }
    }
}
