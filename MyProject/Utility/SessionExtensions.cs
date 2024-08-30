using Microsoft.AspNetCore.Http;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MyProject.Utility
{
    public static class SessionExtensions
    {
        public static void Set<T>(this ISession session, string key, T value) 
        {
            session.SetString(key, JsonSerializer.Serialize(value));

        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value==null? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
    