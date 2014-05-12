namespace knockout_cascading_dropdowns.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Http;
    using System.Collections.Generic;

    [Route("categories")]
    public class CategoriesController : ApiController
    {
        public enum Category
        {
            Audi,
            BMW,
            Citroen,
        }

        [Route("categories/get")]
        public IEnumerable<object> GetCategories()
        {
            return Enum.GetValues(typeof(Category))
                .Cast<Category>()
                .Select(category => new
                {
                    Id = (int)category,
                    Text = category.ToString()
                });
        }

        [Route("categories/getsubcategories")]
        public IEnumerable<string> GetSubCategories(Category? category = null)
        {
            var result = new List<string>();

            switch (category)
            {
                case Category.Audi:
                    result.AddRange(new[] { "A4", "A6", "A8" });
                    break;
                case Category.BMW:
                    result.AddRange(new[] { "1", "3", "5", "6", "7" });
                    break;
                case Category.Citroen:
                    result.AddRange(new[] { "C1", "C3", "C4", "C5", "C6" });
                    break;
                default:
                    result.AddRange(new[] { "A4", "A6", "A8", "1", "3", "5", "6", "7", "C1", "C3", "C4", "C5", "C6" });
                    break;
            }

            return result;
        }
    }
}
