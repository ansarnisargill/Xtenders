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

                var product = new Product()
                {
                    AddedDate = DateTime.Now,
                    Description = "Test Description",
                    Name = "Test Name",
                    PicUrl = "/Images/default.png"
                };
                context.Products.Add(product);
            }
            if (!context.HomeData.Any())
            {
                var data = new HomePageData()
                {
                    TagLine = "The new standard in < Salt Artifacts >",
                    MainIntro = "At Xtenders We produce best salt products from pure Hamalyian Salt Extracted from Pakistans BIGGEST salt mines",
                    CustomerServiceText = "Customer service is the act of taking care of the customer's needs by providing and delivering professional, helpful, high quality service and assistance before, during, and after the customer's requirements are met. Customer service is meeting the needs and desires of any customer.",
                    DeliveryText = "Customer service is the act of taking care of the customer's needs by providing and delivering professional, helpful, high quality service and assistance before, during, and after the customer's requirements are met. Customer service is meeting the needs and desires of any customer.",
                    QualityProductText = "Customer service is the act of taking care of the customer's needs by providing and delivering professional, helpful, high quality service and assistance before, during, and after the customer's requirements are met. ",
                    ProductHeading = "Here are the products we offer",
                    ProductIntro = "You would'nt find quality and finish anywhere eles.",
                    CustomerServiceHeading = "We Hear YOU Dearly! ",
                    DeliveryHeading = "Fastest International Delivery.",
                    QualityProductHeading = "We define Quality ",
                    Announcement = "We are new in town. Say hello to us!"
                };
                context.HomeData.Add(data);
            }
            if (!context.AboutUs.Any())
            {
                var au = new AboutUs()
                {
                    AboutUsHeading = " Showcase is a modern, beautiful personal website template to showcase who you are, as well as projects you've worked on in the past.",
                    AboutUsText= " Showcase was built from the ground up with Bulma to be fast and responsive out of the box with all source files well documented for easy to customization.The Showcase template gives you a personal space to share what you are all about as a creative designer, developer, photographer, and more!",
                    WhyUsHeading = " Showcase is a modern, beautiful personal website template to showcase who you are, as well as projects you've worked on in the past.",
                    WhyUsText = " Showcase was built from the ground up with Bulma to be fast and responsive out of the box with all source files well documented for easy to customization.The Showcase template gives you a personal space to share what you are all about as a creative designer, developer, photographer, and more!",
                     ContactUsText= "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nulla eligendi soluta voluptate facere molestiae consequatur."

                };
                context.Add(au);
            }
            if (!context.Users.Any())
            {
                context.Users.Add(new User()
                {
                    Password = "123",
                    Username = "admin"
                });
            }
            context.SaveChanges();
        }
    }
}
