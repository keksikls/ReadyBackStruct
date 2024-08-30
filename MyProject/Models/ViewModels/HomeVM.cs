using System.Collections;
using System.Collections.Generic;

namespace MyProject.Models.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Product> Products  { get; set; }

        public IEnumerable<Category> Categories { get; set; }
    }
}
