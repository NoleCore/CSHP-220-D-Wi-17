using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Lists_and_More_Lists
{
    public class Program : IEnumerable<string>
    {
        Dictionary<bool, bool> User;
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" }); 
       

            var queryUsers =
                from User in users
                where User.Password.Contains("hello")
                select User.Name;
            foreach (var User in queryUsers)
            {
                Console.WriteLine(User);
            }
            Console.WriteLine();
            //Models.User.("", StringComparison.OrdinalIgnoreCase));
            //List<string> lowerCase = users.Select(x => x.ToLower()).ToList();

            var queryUsers2 = users.Remove((from User in users
                                            where User.Password.Contains("hello")
                                            select User).First());
            foreach (var User in queryUsers2)
            {
                Console.WriteLine("{0} ", users);
            }

        }


    }
            
}
