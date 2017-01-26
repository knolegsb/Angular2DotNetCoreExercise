using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Angular2DotNetCoreExcercise.Data;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Angular2DotNetCoreExcercise.Controllers
{
    [Produces("application/json")]
    [Route("api/friendapi")]
    public class FriendApiController : Controller
    {
        private readonly FriendDBContext _context;

        public FriendApiController(FriendDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("Friend")]
        public IEnumerable<Friend> GetFriends()
        {
            var friends = new List<Friend>()
            {
                new Data.Friend {
                    FriendId = 1,
                    FirstName = "Kimberly",
                    LastName = "Kim",
                    Email = "kkim@example",
                    Address = "231 Wilshire Blvd",
                    City = "Los Angeles",
                    PostalCode = "90010",
                    Country = "USA",
                    Notes = "Really awesome cool friend"
                },
                new Data.Friend {
                    FriendId = 2,
                    FirstName = "Veranda",
                    LastName = "Billbong",
                    Email = "vbillbong@example",
                    Address = "21332 Solar Blvd",
                    City = "Torrance",
                    PostalCode = "90324",
                    Country = "USA",
                    Notes = "Really awesome cool friend"
                },
                new Data.Friend {
                    FriendId = 3,
                    FirstName = "Gon",
                    LastName = "Gondola",
                    Email = "ggondola@example",
                    Address = "3321 Wilshire Blvd",
                    City = "Los Angeles",
                    PostalCode = "90023",
                    Country = "USA",
                    Notes = "Really awesome cool friend"
                },
                new Data.Friend {
                    FriendId = 4,
                    FirstName = "Brandon",
                    LastName = "Bratt",
                    Email = "bbratt@example",
                    Address = "231 Wilshire Blvd",
                    City = "Los Angeles",
                    PostalCode = "90010",
                    Country = "USA",
                    Notes = "Really awesome cool friend"
                },
                new Data.Friend {
                    FriendId = 5,
                    FirstName = "Sonia",
                    LastName = "Sorenstam",
                    Email = "ssorenstam@example",
                    Address = "3 Via Sol Drive",
                    City = "Los Angeles",
                    PostalCode = "90732",
                    Country = "USA",
                    Notes = "Really awesome cool friend"
                }
            };

            return friends;
        }
    }
}
