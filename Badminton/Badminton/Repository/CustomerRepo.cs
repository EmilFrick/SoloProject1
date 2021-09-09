using Badminton.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Badminton.Repository
{
    class CustomerRepo
    {
        static public void AddCustomerToRepo(Customer customer)
        {
            string currentPath = Directory.GetCurrentDirectory();
            string jsonString = JsonConvert.SerializeObject(customer);
            File.AppendAllText($@"{currentPath}\CustomerRepo.json", jsonString + "\n");
        }

        static public List<Customer> ReadCustomerRepo()
        {

            string currentPath = Directory.GetCurrentDirectory();
            StreamReader sr = new StreamReader($@"{currentPath}\CustomerRepo.json");
            string jsonString = "";
            List<Customer> jsonCustomerList = new List<Customer>();

            using (sr)
            {
                while ((jsonString = sr.ReadLine()) != null)
                {
                    Customer jsonCustomer = JsonConvert.DeserializeObject<Customer>(jsonString);
                    jsonCustomerList.Add(jsonCustomer);
                }
                sr.Close();
            }

            return jsonCustomerList;
        }

    }
}
