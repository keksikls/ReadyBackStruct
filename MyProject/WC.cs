using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyProject.Data;

namespace MyProject
{
    public static class WC
    {
        public static string ImagePath = @"\images\product\";
        public static string SessionCart = "ShoppingCartSession";

        public static string AdminRole = "Admin";
        public static string CustomerRole = "Customer";
    }
}
