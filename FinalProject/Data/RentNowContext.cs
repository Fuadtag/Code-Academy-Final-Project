using FinalProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Data
{
    public class RentNowContext : DbContext
    {
        public RentNowContext(DbContextOptions<RentNowContext> options): base(options)
        {
        }

        

        public DbSet<Setting> Settings { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Advantage> Advantage { get; set; }

        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        //public DbSet<BlogCommentReply> BlogCommentReplies { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<CarExtraService> CarExtraServices { get; set; }
        public DbSet<CarModel> CarModels { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<CustomerReview> CustomerReviews { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<OurVision> OurVisions { get; set; }

        public DbSet<Page> Pages { get; set; }

        public DbSet<Partner> Partners { get; set; }

        public DbSet<Passion> Passions { get; set; }

        public DbSet<SliderItem> Sliders { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<WhatWeOffer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SliderItem>().HasData(
                new SliderItem
                {
                    Id = 1,
                    Title = "#1 Car Rent Service In Your City",
                    Text = "Maecenas viverra porta eros,id tincidunt lorem rhoncus eget.Aliquam erat volutpat.Sed ultricies elementum egestas.",
                    Photo = "slide1.jpg",
                },
                new SliderItem
                {
                    Id = 2,
                    Title = "24/7 Customer Support Guarantee",
                    Text = "Maecenas viverra porta eros,id tincidunt lorem rhoncus eget.Aliquam erat volutpat.Sed ultricies elementum egestas.",
                    Photo = "slide2.jpg"
                },
                new SliderItem
                {
                    Id = 3,
                    Title = "Quality Cars with Unlimited Miles",
                    Text = "Maecenas viverra porta eros, id tincidunt lorem rhoncus eget. Aliquam erat volutpat. Sed ultricies elementum egestas.",
                    Photo = "slide3.jpg"
                });
            modelBuilder.Entity<OurVision>().HasData(
                new OurVision
                {
                    Id = 1,
                    Title = "Best Price Guarantee",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new OurVision
                {
                    Id = 2,
                    Title = "Best Price Guarantee",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new OurVision
                {
                    Id = 3,
                    Title = "Best Price Guarantee",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new OurVision
                {
                    Id = 4,
                    Title = "Best Price Guarantee",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                });
            modelBuilder.Entity<Passion>().HasData(
                new Passion
                {
                    Id = 1,
                    SubTitle = "Make Beauty Things",
                    Title = "With Passion",
                    Text = "Proin euismod mollis mi in finibus. Duis vitae elementum ligula. Cras suscipit feugiat arcu, eu venenatis odio. Vivamus non venenatis urna. Curabitur quis elit ut lorem condimentum dignissim. Nunc ornare massa vel fringilla efficitur. Cras elementum ligula et metus tempor, sit amet convallis neque venenatis. Morbi nisi eros, finibus sit amet ipsum ac, venenatis dignissim leo.",
                    Photo = "about-img.jpg"
                });
            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Crystal Spencer",
                    Position = "Co-Founder & CEO",
                    FacebookLink = "https://www.facebook.com/",
                    TwitterLink = "https://www.twitter.com",
                    InstagramLink = "https://www.instagram.com",
                    LinkedInLink = "https://www.linkedin.com",
                    Photo = "team-member-1.jpg"

                },
                new Team
                {
                    Id = 2,
                    Name = "Crystal Spencer",
                    Position = "Co-Founder & CEO",
                    FacebookLink = "https://www.facebook.com/",
                    TwitterLink = "https://www.twitter.com",
                    InstagramLink = "https://www.instagram.com",
                    LinkedInLink = "https://www.linkedin.com",
                    Photo = "team-member-2.jpg"

                },
                new Team
                {
                    Id = 3,
                    Name = "Crystal Spencer",
                    Position = "Co-Founder & CEO",
                    FacebookLink = "https://www.facebook.com",
                    TwitterLink = "https://www.twitter.com",
                    InstagramLink = "https://www.instagram.com",
                    LinkedInLink = "https://www.linkedin.com",
                    Photo = "team-member-3.jpg"

                });
            modelBuilder.Entity<Partner>().HasData(
                new Partner
                {
                    Id = 1,
                    Photo = "partner-1.png",
                    Name = "RentNow"
                },
                new Partner
                {
                    Id = 2,
                    Photo = "partner-2.png",
                    Name = "RentNow"
                },
                new Partner
                {
                    Id = 3,
                    Photo = "partner-3.png",
                    Name = "RentNow"
                },
                new Partner
                {
                    Id = 4,
                    Photo = "partner-4.png",
                    Name = "RentNow"
                });

            modelBuilder.Entity<Setting>().HasData(
                new Setting
                {
                    Id = 1,
                    FacebookLink = "https://www.facebook.com",
                    TwitterLink = "https://www.twitter.com",
                    InstagramLink = "https://www.instagram.com",
                    LinkedInLink = "https://www.linkedin.com",
                    GoogleLink = "https://www.google.com",
                    Phone = "(954) - 944 - 1250",
                    SupPhone = "(954) - 944 - 1250",
                    Email = "support@example.com",
                    SaleEmail = "sale@example.com",
                    MainAdress = "1425 Pointe Lane, Miami",
                    Adress = "Florida – 33169, USA",
                    Logo = "logo.svg",
                    FooterLogo = "logo.svg",
                    FooterText = "Sed sit amet ligula ac nulla finibus euismod nec nec diam. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent semper, risus eget ornare maximus, ipsum ante semper.",
                    Payment = "payments.png"
                });

            modelBuilder.Entity<Page>().HasData(
                new Page
                {
                    Id = 1,
                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ultricies erat non augue pretium mollis. Nunc ut mauris volutpat, imperdiet nunc et, mattis erat. Sed id pretium est. Suspendisse magna diam, ultrices ac arcu ut, aliquam tincidunt est. In nisl nulla, dapibus id ante eget, interdum ultricies magna. Maecenas lectus urna, pulvinar consequat lobortis sed, sodales a libero. Pellentesque ac magna tellus. Phasellus nisl lorem, convallis vel cursus porttitor, ullamcorper nec dui.Aenean at nibh massa. Mauris magna sapien, sollicitudin eget finibus eu, aliquet at lectus. Cras cursus eget libero id blandit. Fusce quis ligula id tellus euismod posuere. Nunc nunc ex, ultrices ac pellentesque eu, ultricies nec justo. Aenean dolor neque, tristique in lectus at, ornare bibendum ligula. Curabitur scelerisque, ligula sit amet aliquet finibus, diam erat pharetra dolor, ac vulputate nunc ex vel ante. Etiam nec efficitur sem. Suspendisse nisl velit, rutrum nec magna at, cursus egestas nunc. Maecenas laoreet quam sit amet erat pretium, vel lobortis nunc fermentum. Cras ullamcorper mi nec vehicula sagittis. Mauris ut neque orci. Nunc non ornare neque, vel vestibulum libero.Duis gravida ante sed mi mattis hendrerit. Nullam efficitur ligula eget feugiat vehicula. Aliquam quis dui scelerisque, tempus velit posuere, sodales justo. Cras in faucibus ante. Suspendisse eget viverra nunc. Nam luctus risus diam, efficitur bibendum mauris feugiat a. Sed efficitur sit amet sapien quis porta. Cras nec nisl erat. Integer rutrum augue non pharetra placerat. Duis quis condimentum velit. Morbi placerat nec ipsum eget aliquam.Curabitur hendrerit gravida risus, consectetur sollicitudin mauris. Praesent fringilla consequat velit, at eleifend lectus tempor at. Donec auctor pretium tempus. Donec sit amet est nec nulla sagittis malesuada. Aenean ac felis urna. Aliquam ipsum ligula, rutrum id consectetur eu, dapibus sit amet quam. Donec varius malesuada turpis. Phasellus volutpat non dolor vel lacinia. Pellentesque ultrices ut libero vel pellentesque. Curabitur in quam porta, elementum lorem nec, euismod arcu. Mauris laoreet ipsum eros, id ornare nibh varius et. Duis bibendum a purus a euismod. Sed a pretium sem, nec sollicitudin urna.Nulla lacinia turpis non justo congue, eu tincidunt dolor pulvinar. Duis laoreet sed sem quis eleifend. Phasellus sed cursus tortor. Morbi rhoncus mi non vulputate imperdiet. Aenean sem mi, rhoncus vel rhoncus ut, sollicitudin convallis enim. Nunc malesuada pretium felis vel scelerisque. Sed vulputate, augue dictum venenatis sagittis, urna leo condimentum orci, id pellentesque ipsum tortor at dolor. Integer lobortis nulla ullamcorper commodo ullamcorper. Aliquam erat volutpat. Mauris vehicula nibh vel mauris efficitur, eu sollicitudin felis ornare. Sed nec laoreet est. Vivamus fringilla quam ex, id ultricies risus tincidunt et. In tincidunt felis tortor, et sodales magna accumsan et. Proin sit amet erat ut magna tempor posuere. Nunc eleifend dictum nisl, non condimentum purus pellentesque quis. Praesent pharetra volutpat leo, eget accumsan nisl porttitor eu."
                });
            modelBuilder.Entity<BlogCategory>().HasData(
                new BlogCategory
                {
                    Id = 1,
                    Name = "Lifestyle"
                },
                new BlogCategory
                {
                    Id = 2,
                    Name = "Travel"
                },
                new BlogCategory
                {
                    Id = 3,
                    Name = "Fashion"
                },
                new BlogCategory
                {
                    Id = 4,
                    Name = "Music"
                },
                new BlogCategory
                {
                    Id = 5,
                    Name = "Branding"
                });

            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    Name = "John Doe",
                    Photo = "author-1.jpg",
                    Email = "johndoe@mail.com",
                    Password = "john123"
                },
                new Author
                {
                    Id = 2,
                    Name = "John Doe1",
                    Photo = "author-1.jpg",
                    Email = "johndoe1@mail.com",
                    Password = "john123"
                },
                new Author
                {
                    Id = 3,
                    Name = "John Doe2",
                    Photo = "author-1.jpg",
                    Email = "johndoe2@mail.com",
                    Password = "john123"
                });
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "Expanding Your Home Network’s Reach",
                    Slug = "expanding-your-home-networks-reach",
                    Title = "A standard blog post with image",
                    InfoText = "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.",
                    AuthorId = 1,
                    CreatedAt = DateTime.Now,
                    Likes = 0,
                    Visited = 0,
                    BlogCategoryId = 1,
                    TopText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.",
                    Text = "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.",
                    Photo = "post-item-1.jpg",
                    PhotoSm = "blog-item-sm-1.jpg"
                },
                new Blog
                {
                    Id = 2,
                    Name = "Expanding Your Home Network’s Reach",
                    Slug = "expanding-your-home-networks-reach",
                    Title = "A standard blog post with image",
                    InfoText = "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.",
                    AuthorId = 2,
                    CreatedAt = DateTime.Now,
                    Likes = 0,
                    Visited = 0,
                    BlogCategoryId = 2,
                    TopText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.",
                    Text = "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.",
                    Photo = "post-item-2.jpg",
                    PhotoSm = "blog-item-sm-2.jpg"
                },
                new Blog
                {
                    Id = 3,
                    Name = "Expanding Your Home Network’s Reach",
                    Slug = "expanding-your-home-networks-reach",
                    Title = "A standard blog post with image",
                    InfoText = "Aliquam erat volutpat. Morbi eget velit ut lectus efficitur vulputate dictum vel ex. Etiam bibendum libero eget lorem malesuada, id mattis est egestas. Mauris eu quam bibendum, placerat odio non, ultrices leo. Proin laoreet purus nisl, non elementum tortor accumsan vitae. Proin commodo vulputate purus, eu dignissim ipsum lobortis ut. Sed ac nisi velit. Integer magna mi, faucibus a sapien eget, volutpat euismod dolor.",
                    AuthorId = 3,
                    CreatedAt = DateTime.Now,
                    Likes = 0,
                    Visited = 0,
                    BlogCategoryId = 4,
                    TopText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas in tortor sed eros consequat rutrum eget iaculis lacus. Aenean ac sapien risus. Nullam eget lobortis odio. Nulla ac lacus in nunc sagittis pretium ut ac nulla. In mollis hendrerit metus, eu posuere dolor hendrerit vel. Duis sit amet tortor imperdiet nisl aliquam scelerisque. Suspendisse lobortis condimentum fermentum. In volutpat est libero, a facilisis ipsum pharetra eu. Fusce condimentum metus id ante auctor pellentesque. Donec placerat ornare risus ut sodales. In accumsan risus nec sodales ultrices. Vestibulum auctor auctor sodales. Donec varius volutpat tellus dapibus fringilla.Duis id leo gravida,convallis lorem ac,tincidunt tortor.Fusce in mollis eros,ac tempor purus.Nulla facilisi.Nam dictum neque quis felis iaculis,ut condimentum ex feugiat.Sed tincidunt velit sem,non elementum nibh dapibus eget.Cras at sagittis tellus.Donec vitae ullamcorper mi.Donec in ornare lacus.Cras elementum mi eget vestibulum pulvinar.Sed accumsan vel lorem ut ultricies.",
                    Text = "Aliquam non sodales felis. Fusce luctus porta tincidunt. Etiam aliquet varius est vestibulum consectetur. Donec arcu justo, fringilla sit amet nisi eu, hendrerit facilisis justo. Donec nisl risus, tincidunt at augue eget, ultrices varius orci. Fusce hendrerit lacus in volutpat malesuada. Vestibulum mattis tellus at purus pretium ullamcorper. In hac habitasse platea dictumst.Integer consectetur condimentum dolor eu consequat.Suspendisse dictum,tellus id semper pretium,velit lorem iaculis felis,sit amet ullamcorper mauris nisl at urna.Proin vel nibh ligula.Integer id ipsum quis eros sodales consectetur vel elementum urna.Morbi facilisis interdum nunc eu commodo.Maecenas magna tellus,dictum at dolor non,rutrum lacinia tellus.Integer accumsan velit est,ac bibendum ante fringilla sit amet.Mauris faucibus pellentesque elementum.Proin in convallis erat.Maecenas tincidunt cursus euismod.Maecenas quis felis diam.Suspendisse imperdiet tellus eget nunc fringilla fermentum.Fusce nisl neque,lobortis sed turpis ac,faucibus mattis nibh.Vivamus posuere dolor in euismod maximus.Donec velit nisi,rutrum iaculis libero sollicitudin,aliquam congue arcu.",
                    Photo = "post-item-1.jpg",
                    PhotoSm = "blog-item-sm-1.jpg"
                });
            modelBuilder.Entity<BlogComment>().HasData(
                new BlogComment
                {
                    Id = 1,
                    BlogId = 1,
                    AuthorId = 1,
                    CreatedAt = DateTime.Now,
                    Text = "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus."
                },
                 new BlogComment
                 {
                     Id = 12,
                     BlogId = 2,
                     AuthorId = 2,
                     CreatedAt = DateTime.Now,
                     Text = "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus."
                 },
                  new BlogComment
                  {
                      Id = 3,
                      BlogId = 3,
                      AuthorId = 3,
                      CreatedAt = DateTime.Now,
                      Text = "Mauris lobortis sapien non tellus maximus volutpat. Nam aliquet quis erat et luctus. Sed dignissim id felis vitae fringilla. Maecenas faucibus enim eu mattis iaculis. In ultrices laoreet diam ac tempus."
                  });
            //modelBuilder.Entity<BlogCommentReply>().HasData(
            //    new BlogCommentReply
            //    {
            //        Id = 1,
            //        BlogCommentId = 1,
            //        AuthorId = 1,
            //        CreatedAt = DateTime.Now,
            //        Text = "Etiam vulputate massa urna, laoreet finibus eros tristique nec. Suspendisse rhoncus fermentum odio, et ultricies diam malesuada a."
            //    });
            modelBuilder.Entity<CarBrand>().HasData(
                new CarBrand
                {
                    Id = 1,
                    Name = "Mercedes",
                },
                new CarBrand
                {
                    Id = 2,
                    Name = "Toyota",
                },
                new CarBrand
                {
                    Id = 3,
                    Name = "Tesla",
                });
            modelBuilder.Entity<CarModel>().HasData(
                new CarModel
                {
                    Id = 1,
                    Name = "EQC",
                    CarBrandId = 1
                },
                new CarModel
                {
                    Id = 2,
                    Name = "Camry",
                    CarBrandId = 2
                },
                new CarModel
                {
                    Id = 3,
                    Name = "Model S",
                    CarBrandId = 3
                });
            modelBuilder.Entity<CarType>().HasData(
                new CarType
                {
                    Id = 1,
                    Name = "Sedan",
                    Icon = "car-type-sedan"
                },
                new CarType
                {
                    Id = 2,
                    Name = "Roadster",
                    Icon = "car-type-roadster"
                },
                new CarType
                {
                    Id = 3,
                    Name = "Coupe",
                    Icon = "car-type-coupe"
                },
                new CarType
                {
                    Id = 4,
                    Name = "Minivan",
                    Icon = "car-type-minivan"
                },
                new CarType
                {
                    Id = 5,
                    Name = "Station Wagon",
                    Icon = "car-type-statio-wagon"
                },
                new CarType
                {
                    Id = 6,
                    Name = "Limousine",
                    Icon = "car-type-limousine"
                });
            modelBuilder.Entity<Testimonial>().HasData(
                new Testimonial
                {
                    Id = 1,
                    Text = "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel.",
                    Name = "Catherine Beck",
                    Position = "CEO",
                    Company = "Example Inc.",
                    Photo = "author-3.jpg"
                },
                new Testimonial
                {
                    Id = 2,
                    Text = "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel.",
                    Name = "Catherine Beck",
                    Position = "CEO",
                    Company = "Example Inc.",
                    Photo = "author-3.jpg"
                },
                new Testimonial
                {
                    Id = 3,
                    Text = "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel.",
                    Name = "Catherine Beck",
                    Position = "CEO",
                    Company = "Example Inc.",
                    Photo = "author-3.jpg"
                },
                new Testimonial
                {
                    Id = 4,
                    Text = "Integer aliquam velit ut nibh mattis, et suscipit erat ultrices. Cras aliquam ante vel arcu suscipit, sit amet lobortis elit dignissim tempor vel.",
                    Name = "Catherine Beck",
                    Position = "CEO",
                    Company = "Example Inc.",
                    Photo = "author-3.jpg"
                });
            modelBuilder.Entity<Advantage>().HasData(
                new Advantage
                {
                    Id = 1,
                    Title = "Best Price Guarantee",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 2,
                    Title = "No Cancellation Fees",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 3,
                    Title = "Best Quality Cars",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 4,
                    Title = "Reservation Anytime",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 5,
                    Title = "Personal Driver",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 6,
                    Title = "Unlimited Miles",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 7,
                    Title = "City to City",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                },
                new Advantage
                {
                    Id = 8,
                    Title = "24/7 Customer Support",
                    Text = "Duis placerat tempus odio vel pretium. Vestibulum mattis viverra justo vel consequat."
                });
            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Transmission = Transmissions.AT,
                    CarBrandId = 2,
                    Fuel = FuelType.Gasoline,
                    Passsenger = 5,
                    Luggage = 4,
                    Door = 5,
                    Title = "Mauris semper nisl a massa convallis",
                    DailyPrice = 150,
                    Discount = 0,
                    Description = "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.",
                    Status = true,
                    Photo = "car-1.jpg",
                    CartPhoto = "cart-item-1.jpg",
                    DetailPhoto = "single-car-thumb.jpg"
                },
                new Car
                {
                    Id = 2,
                    Transmission = Transmissions.AT,
                    CarBrandId = 1,
                    Fuel = FuelType.Electric,
                    Passsenger = 5,
                    Luggage = 4,
                    Door = 5,
                    Title = "Mauris semper nisl a massa convallis",
                    DailyPrice = 300,
                    Discount = 0,
                    Description = "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.",
                    Status = true,
                    Photo = "car-1.jpg",
                    CartPhoto = "cart-item-1.jpg",
                    DetailPhoto = "single-car-thumb.jpg"
                },
                new Car
                {
                    Id = 3,
                    Transmission = Transmissions.AT,
                    CarBrandId = 2,
                    Fuel = FuelType.Gasoline,
                    Passsenger = 5,
                    Luggage = 4,
                    Door = 5,
                    Title = "Mauris semper nisl a massa convallis",
                    DailyPrice = 200,
                    Discount = 0,
                    Description = "Praesent quis risus maximus arcu luctus egestas. Aliquam rhoncus metus eu dui aliquet, ut imperdiet metus fringilla. Nulla non purus et odio varius condimentum. Maecenas et elit eu lectus feugiat congue. Aenean dictum ligula vitae orci congue, eu rutrum ex tempus. Donec vel ex a neque congue volutpat. Mauris nec purus eget velit elementum posuere. Donec libero nisi, blandit non turpis sed, hendrerit suscipit metus. Aliquam ornare tincidunt dictum. Sed laoreet, arcu fringilla fermentum rutrum, quam urna dictum tellus, et rutrum dui lectus ac turpis. Donec eu sem in libero euismod tristique vel sit amet nibh.Integer pellentesque fermentum mi in accumsan.Phasellus congue risus urna,eget maximus ante ullamcorper et.Aenean malesuada,magna a ultrices hendrerit,ante lectus semper odio,quis imperdiet odio tellus at ex.Interdum et malesuada fames ac ante ipsum primis in faucibus.Nunc eu tellus quam.Cras sit amet sapien at est lacinia consectetur in efficitur ante.Nulla pellentesque metus et rutrum placerat.Aliquam erat volutpat.Donec pellentesque neque mi,ac tristique purus vestibulum et.Donec sagittis laoreet mauris,eget interdum tortor gravida nec.Maecenas suscipit nisi exeu dictum enim accumsan ut.Pellentesque vel sagittis ex.Duis vitae est ut diam blandit consectetur in eget risus.Donec faucibus ex consectetur,sodales quam ac,feugiat mi.Sed ultrices mi ac ultricies egestas.In varius ligula a ipsum facilisis,quis ornare neque euismod.",
                    Status = true,
                    Photo = "car-1.jpg",
                    CartPhoto = "cart-item-1.jpg",
                    DetailPhoto = "single-car-thumb.jpg"
                });
            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    Id = 1,
                    Name = "Video",
                    BlogId = 1
                },
                new Tag
                {
                    Id = 2,
                    Name = "Image",
                    BlogId = 1
                },
                new Tag
                {
                    Id = 3,
                    Name = "Car",
                    BlogId = 2
                },
                new Tag
                {
                    Id = 4,
                    Name = "Images",
                    BlogId = 2
                },
                new Tag
                {
                    Id = 5,
                    Name = "Cars",
                    BlogId = 1
                });
            modelBuilder.Entity<Coupon>().HasData(
                new Coupon
                {
                    Id = 1,
                    Name = "Coupon1",
                    Status = true
                },
                new Coupon
                {
                    Id = 2,
                    Name = "Coupon2",
                    Status = true
                },
                new Coupon
                {
                    Id = 3,
                    Name = "Coupon3",
                    Status = true
                },
                new Coupon
                {
                    Id = 4,
                    Name = "Coupon4",
                    Status = true
                },
                new Coupon
                {
                    Id = 5,
                    Name = "Coupon5",
                    Status = true
                });

            modelBuilder.Entity<CarExtraService>().HasData(
                new CarExtraService
                {
                    Id = 1,
                    Name = "Driver",
                    Price = 100

                },
                new CarExtraService
                {
                    Id = 2,
                    Name = "Snacks",
                    Price = 10

                });
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    Id = 1,
                    Name = "Fuad",
                    Surname = "Taghiyev",
                    Email = "fuadjt@code.edu.az",
                    Password = "Fuad123",
                    Country = Country.Azerbaijan,
                    StreetAdress = "Nizami Street",
                    Postalcode = "AZ1021",
                    Age = 21,
                    HappyClient = false
                });

            modelBuilder.Entity<CustomerReview>().HasData(
                new CustomerReview
                {
                    Id = 1,
                    CustomerId = 1,
                    Text = "Mauris quis sollicitudin ipsum. Morbi venenatis sem eros, quis pulvinar lacus pharetra nec. Vestibulum odio ante, venenatis ut volutpat nec, scelerisque vel purus. Nunc tempor eros a interdum blandit.",
                    QualityStars = 2,
                    ComfortStars = 4,
                    DrivingStars = 4,
                    PriceStars = 3,
                    PositiveReview = false,
                    CarId = 1

                });
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    CustomerId = 1,
                    PaymentMethod = Payment.Cash,
                    PickupDate = DateTime.Now,
                    DropDate = DateTime.Now.AddDays(5),
                    PickupLocation = "Baku, H.A Airport",
                    DropLocation = "Baku, H.A Airport",
                });
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem
                {
                    Id = 1,
                    OrderId = 1,
                    CarId = 1
                },
                new OrderItem
                {
                    Id = 2,
                    OrderId = 1,
                    CarId = 2
                });
            modelBuilder.Entity<AppAdmin>().HasData(
                new AppAdmin
                {
                    Id = 1,
                    Name = "Fuad",
                    Surname = "Taghiyev",
                    Email = "fuadjt@code.edu.az",
                    Password = "admin123"
                });




        }
    }

    
}


