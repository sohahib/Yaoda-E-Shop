using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yaoda_E_Shop.Models;

namespace Yaoda_E_Shop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope() )
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Shoes
                if (!context.Sneakers.Any())
                {
                    context.Sneakers.AddRange(new List<Shoes> ()
                    {
                        new Shoes()
                        {
                            ProductImageUrl = "/images/1.png",
                            ProductName="Nike Air Force 1",
                            ProductDescription=" Radiance lives in the Nike Air Force 1 ’07 LE. This limited edition puts a fresh spin " +
                            "on what you know best with durably stitched overlays, bold colors, and just the right amount of flash to make you" +
                            " shine. Stitched overlays on the upper add heritage style, durability, and support, and Nike Air cushioning adds" +
                            " lightweight, all-day comfort.",
                            ProductPrice= 90,
                            ProductQuantity= 120
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/2.png",
                            ProductName="Jordan Retro 12",
                            ProductDescription="If you’re looking for a top-quality kick for your kid, look no further than the Jordan" +
                            " Retro 12. This sneaker is comfortable, cool, and inspired by the shoe Michael Jordan wore when he won his fifth" +
                            " league title. Your kiddo will start their day on the right foot with the Jordan Retro 12, knowing that they walk in" +
                            " a shoe similar to the one Michael Jordan rocked to the top. Kids will step ahead in the classroom and on the court with" +
                            " the Jordan Retro 12",
                            ProductPrice= 140,
                            ProductQuantity= 134
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/3.png",
                            ProductName="Reebok CL Legacy",
                            ProductDescription=" Radiance lives in the Nike Air Force 1 ’07 LE. This limited edition puts a fresh spin on what" +
                            " you know best with durably stitched overlays, bold colors, and just the right amount of flash to make you shine. " +
                            "Stitched overlays on the upper add heritage style, durability, and support, and Nike Air cushioning adds lightweight," +
                            " all-day comfort.",
                            ProductPrice= 80,
                            ProductQuantity= 59
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/4.png",
                            ProductName="Under Armour Curry 8",
                            ProductDescription="Give your shoe game a legendary upgrade with the Under Armour Curry 8. Designed by the MVP, " +
                            "these kicks bring the heat with its breathable, lightweight flat knit upper and synthetic overlays for extra support." +
                            " These kicks boast of superior cushioning technology to deliver your best performance in every game.",
                            ProductPrice= 80,
                            ProductQuantity= 85
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/5.png",
                            ProductName="R5.	Nike Zoom Freak 2",
                            ProductDescription="Giannis' combination of size, speed, and skill has made him an unstoppable force. " +
                            "Harness his power with his signature shoe, the Zoom Freak 2. With responsive foam and explosive Zoom Air" +
                            " technology, you'll be Euro Stepping all over the competition, just like the big man himself.",
                            ProductPrice= 120,
                            ProductQuantity= 200
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/6.png",
                            ProductName="6.	Jordan True Flight",
                            ProductDescription="The Jordan Men’s True Flight mixes a silhouette inspired by Air Jordan VII with upgraded" +
                            " features to please the modern athlete. The leather and durabuck upper offers top-of-the-line durability and " +
                            "breathability. Its patterned overlays and mixed materials create a layered, dynamic look. The striking appearance " +
                            "is sure to capture your style and personality both on and off the court.",
                            ProductPrice= 140,
                            ProductQuantity= 11
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/7.png",
                            ProductName="R7.	adidas Originals Superstar",
                            ProductDescription="Part of the adidas Originals collection, the revamped adidas Superstar blends" +
                            " style and comfort to make a timeless classic go viral once again. The famous shell-toe design with " +
                            "serrated adidas lines give this legendary shoe its retro vibe. The super-strong sole extends over the " +
                            "leather to provide an incredibly durable pair of sneaks. One of the most Pinnable and Instagrammable " +
                            "shoes, they're a staple addition to any great wardrobe. The crisp detailing and rich history of this " +
                            "shoe makes an undeniably bold statement about the wearer.",
                            ProductPrice= 85,
                            ProductQuantity= 32
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/8.png",
                            ProductName="8.	adidas Ultra4D 5.0",
                            ProductDescription="Bring the latest heat to your street with the incredibly sporty adidas Ultra4D " +
                            "5.0. Featuring a fresh pattern on the upper coupled with modern aesthetics, this futuristic silhouette " +
                            "ensures optimal comfort and enhanced style with every fit. Stay on top of your game with the super-progressive" +
                            " and high-performing Ultra4D 5.0 from adidas!",
                            ProductPrice= 200,
                            ProductQuantity= 13
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/9.png",
                            ProductName="9.	Nike Air Presto",
                            ProductDescription=" Radiance lives in the Nike Air Force 1 ’07 LE. This limited edition puts a " +
                            "fresh spin on what you know best with durably stitched overlays, bold colors, and just the right amount" +
                            " of flash to make you shine. Stitched overlays on the upper add heritage style, durability, and" +
                            " support, and Nike Air cushioning adds lightweight, all-day comfort.",
                            ProductPrice= 130,
                            ProductQuantity= 94
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/10.png",
                            ProductName="10.	Nike Air Max '97",
                            ProductDescription="One of Nike’s most recognizable designs in their rich history is the Air " +
                            "Presto. Originally debuted during the 2000 Summer Olympics in Sydney, Australia, the Presto " +
                            "instantly stood out among the competition. Marked as a “t-shirt for your feet” the Presto would " +
                            "defy what a running shoe should and shouldn’t be. One of the more unique aspects of the Air Presto " +
                            "was the sizing method; instead of using traditional numbers, Nike released their head turning kicks" +
                            " in XS, S, M, L and XL (like a t-shirt). Nike utilized an unconventional method of marketing the shoes" +
                            " when they first became public in 2000. Short, jarring ads appeared on TV and in print featuring 13 unique" +
                            " color schemes that instantly stood out. Tobie Hatfield (brother of fellow Nike legend, Tinker Hatfield) designed " +
                            "the shoe with the sole purpose of creating a new free-motion, breathable, and versatile runner. Unlike most" +
                            " of Nike’s products, there was only one Presto, no sequels. Tobie explains why perfectly with this quote, “People " +
                            "always ask me. Why didn’t we do a Presto 2? We did. It’s called Nike Free.”",
                            ProductPrice= 170,
                            ProductQuantity= 58
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/11.png",
                            ProductName="11.	New Balance 574",
                            ProductDescription="You'd be hard-pressed to find a shoe more eye-catching than the Nike Air Max '97." +
                            " Indeed, these stunning, wavy, bold sneakers are far more than just another pair of Nikes. With incredible " +
                            "design and ultimate comfort, the Nike Air Max '97 is a shoe lovers dream. The wavy paneling of these shoes" +
                            " give them a signature and timeless look. The '90s may be long gone, but this shoe's style is timeless.",
                            ProductPrice= 80,
                            ProductQuantity= 25
                        },
                        new Shoes()
                        {
                            ProductImageUrl = "/images/12.png",
                            ProductName="12.	Jordan Jumpman Team 1",
                            ProductDescription="There is no I in team and you will feel like a team player with these Jordan Jumpman " +
                            "Team 1 Basketball Shoes. A thickly stitched upper, aggressive traction and Zoom Air cushioning combine for" +
                            " durability, support and responsiveness. Genuine and synthetic leathers in the upper provide season-long " +
                            "support and durability.",
                            ProductPrice= 140,
                            ProductQuantity= 60
                        }
                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
