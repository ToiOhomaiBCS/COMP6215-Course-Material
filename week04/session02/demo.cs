using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace abstractpg
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class Phonebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                string url = "https://jsonplaceholder.typicode.com/users?_limit=5";
                string json = wc.DownloadString(url);

                List<Phonebook> data = JsonConvert.DeserializeObject<List<Phonebook>>(json);

                foreach(var x in data)
                {
                    Console.WriteLine(x.Name);
                    Console.WriteLine(x.Email);
                    Console.WriteLine(x.Phone);
                }
            }
        }
    }
}