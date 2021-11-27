using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileIOoperationDemo
{
    class JSONSerialization
    {

        Blogsite blogsite = new Blogsite()
        {
            name = "shivakar",
            discription = "student profile"
        };

        string jsonData;
        public void JsonSerialize()
        {
           
            jsonData = JsonConvert.SerializeObject(blogsite);

            Console.WriteLine(jsonData);


        }
        public void JsonDesrialize()
        {
           
            Blogsite blogsite = JsonConvert.DeserializeObject<Blogsite>(jsonData);
            Console.WriteLine(blogsite.name + "    " +blogsite.discription);

        }
    }
    

    
    class Blogsite
    {
        public string name { set; get; }
        public string discription { set; get; }
    }

     

}
