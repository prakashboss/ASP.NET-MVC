using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopDB.Models
{
    public class DbInitializer
    {
        public static void Seed(DatabaseContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Product.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "iPhoneX",
                        Price = 2100,
                        ShortDescription = "The most widely consumed product",
                        LongDescription = "This phone is thw wolrd most advance ",
                        Category = Categories["Phone"],
                        ImageUrl = "https://cdn.macrumors.com/article-new/2017/09/iphonexdesign.jpg",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://www.techgadgets.guru/wp-content/uploads/2017/11/apple-iphone-x-review-big-screen-small-device.jpg"
                    }
                                  );
            }

            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "phone", Description="All products" },
                        new Category { CategoryName = "tablet", Description="All tables" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }

    }
}
