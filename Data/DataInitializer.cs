using XtendersProject.Models;
using System;
using System.Linq;

namespace XtendersProject.Data
{
    public class DataInitializer
    {
        public static void Initialize(Context context)
        {
            context.Database.EnsureCreated();


            if (!context.Products.Any())
            {

                var product = new Product();
                context.Products.Add(product);
            }
            if (!context.HomeData.Any())
            {
                var data = new HomePageData()
                {
                    TagLine = "The new standard in < Salt Artifacts >",
                    MainIntro = "At Xtenders We produce best salt products from pure Hamalyian Salt Extracted from Pakistans BIGGEST salt mines"
                };
                context.HomeData.Add(data);
            }
            context.SaveChanges();


        }
    }
}
