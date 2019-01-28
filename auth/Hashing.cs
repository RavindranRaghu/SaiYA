using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using SaiYAMain.Models;

namespace SaiYAMain.auth{
    public class SaiHashing
    {
        public string Hashing(string text)
        {
            string finalHashed = string.Empty;
            using (SHA256 sha = SHA256.Create())  
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));

                StringBuilder hashed = new StringBuilder();

                for(int i=0; i< bytes.Length; i++){
                    hashed.Append(bytes[i].ToString("x2"));
                }
                finalHashed = hashed.ToString();
            }

            return finalHashed;
        }
    }

  
}