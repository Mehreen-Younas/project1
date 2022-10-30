using Microsoft.AspNetCore.Hosting;
using project1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace project1.Services
{
    public class JsonPastaFile
    {
       public JsonPastaFile(IWebHostEnvironment webHostEnvironment)   // host environment ko use krny k liyya constructor bnana hai
        {
            WebHostEnvironment = webHostEnvironment;

                               // IS K ANDER HAMY WEBHOST K ENVIRONMENT KO SET krna h..usko set krny sy pehly hamy us environ ko grt krna pry ga us k liyay ik or function define krna pry ga
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        //for json ki file ka automatic created address 
        public string JsonFilePath { get 
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "pastas.json");
            }
        }
        public IEnumerable<Pasta> getPastaData()
        {
            using(var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Pasta[]>(json_file.ReadToEnd());
            }
        }

       
    }
}
