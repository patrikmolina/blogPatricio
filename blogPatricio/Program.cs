using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace blogPatricio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostingBuilder(args).Build().Run();
        }
    }
}
