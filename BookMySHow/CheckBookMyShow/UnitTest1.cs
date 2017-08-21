using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Tavisca.BookMyShow.Manager.BookMyShow.Entity;
using Tavisca.BookMyShow.Entity;
using Tavisca.BookMyShow.Manager;

namespace CheckBookMyShow
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Searching_User()
        {
            UserManager usermanager = new UserManager();
            User user1 = new User();
            user1.Name = new Name();
            user1.Address = new Address();
            user1.Name.FirstName = "Bandana";
            user1.Name.LastName = "Mahapatra";
            user1.Name.MiddleName = "";
            user1.Name.Prefix = "Ms";
            user1.Address.City = "Pune";
            user1.Address.Country = "India";
            user1.Address.State = "Maharastra";
            user1.Address.LineNo = "ZensarLine";
            user1.Address.PinCode = "455221";
            user1.Username = "bandana_mahapatra";
            user1.Password = "123";
            user1.Gender = Gender.Female;
            usermanager.CreateUser(user1);

            User user2 = new User();
            user2.Name = new Name();
            user2.Address = new Address();
            //user2.Name.FirstName = "Sakshi";
            //user2.Name.LastName = "Sharma";
            //user2.Name.MiddleName = "";
            //user2.Name.Prefix = "Ms";
            user2.Address.City = "Pune";
            user2.Address.Country = "India";
            user2.Address.State = "Maharastra";
            user2.Address.LineNo = "ZensarLine";
            user2.Address.PinCode = "455621";
            user2.Username = "sakshi_sharma";
            user2.Password = "1234";
            user2.Gender = Gender.Female;
            usermanager.CreateUser(user2);

            User user3 = new User();
            user3.Name = new Name();
            user3.Address = new Address();
            user3.Name = new Name();
            user3.Name.FirstName = "Smita";
            user3.Name.LastName = "Acharya";
            user3.Name.MiddleName = "";
            user3.Name.Prefix = "Ms";
            user3.Address.City = "Pune";
            user3.Address.Country = "India";
            user3.Address.State = "Maharastra";
            user3.Address.LineNo = "ZensarLine";
            user3.Address.PinCode = "455821";
            user3.Username = "smita_acharya";
            user3.Password = "1235";
            user3.Gender = Gender.Female;
            usermanager.CreateUser(user3);

            var retrievedUser = usermanager.GetUser("Bandana");
            Assert.IsNotNull(retrievedUser);
            Assert.AreSame(user1.Username, retrievedUser.Username);
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Sakshi").Name.LastName);
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Bandana").Name.LastName);
        }


        [TestMethod]
        public void Test_Searching_User_Not_Present()
        {
            UserManager usermanager = new UserManager();
            User user1 = new User();
            user1.Name = new Name();
            user1.Address = new Address();
            user1.Name.FirstName = "Bandana";
            user1.Name.LastName = "Mahapatra";
            user1.Name.MiddleName = "";
            user1.Name.Prefix = "Ms";
            user1.Address.City = "Pune";
            user1.Address.Country = "India";
            user1.Address.State = "Maharastra";
            user1.Address.LineNo = "ZensarLine";
            user1.Address.PinCode = "455221";
            user1.Username = "bandana_mahapatra";
            user1.Password = "123";
            user1.Gender = Gender.Female;
            usermanager.CreateUser(user1);

            User user2 = new User();
            user2.Name = new Name();
            user2.Address = new Address();
            user2.Name.FirstName = "Sakshi";
            user2.Name.LastName = "Sharma";
            user2.Name.MiddleName = "";
            user2.Name.Prefix = "Ms";
            user2.Address.City = "Pune";
            user2.Address.Country = "India";
            user2.Address.State = "Maharastra";
            user2.Address.LineNo = "ZensarLine";
            user2.Address.PinCode = "455621";
            user2.Username = "sakshi_sharma";
            user2.Password = "1234";
            user2.Gender = Gender.Female;
            usermanager.CreateUser(user2);

            User user3 = new User();
            user3.Name = new Name();
            user3.Address = new Address();
            user3.Name.FirstName = "Smita";
            user3.Name.LastName = "Acharya";
            user3.Name.MiddleName = "";
            user3.Name.Prefix = "Ms";
            user3.Address.City = "Pune";
            user3.Address.Country = "India";
            user3.Address.State = "Maharastra";
            user3.Address.LineNo = "ZensarLine";
            user3.Address.PinCode = "455821";
            user3.Username = "smita_acharya";
            user3.Password = "1235";
            user3.Gender = Gender.Female;
            usermanager.CreateUser(user3);

            Assert.AreNotSame(user1.Name.LastName, usermanager.GetUser("bandana"));
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Sakshi").Name.LastName);
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Bandana").Name.LastName);
        }

        [TestMethod]
        public void Test_Searching_User_Count()
        {
            UserManager usermanager = new UserManager();
            User user1 = new User();
            user1.Name = new Name();
            user1.Address = new Address();
            user1.Name.FirstName = "Bandana";
            user1.Name.LastName = "Mahapatra";
            user1.Name.MiddleName = "";
            user1.Name.Prefix = "Ms";
            user1.Address.City = "Pune";
            user1.Address.Country = "India";
            user1.Address.State = "Maharastra";
            user1.Address.LineNo = "ZensarLine";
            user1.Address.PinCode = "455221";
            user1.Username = "bandana_mahapatra";
            user1.Password = "123";
            user1.Gender = Gender.Female;
            usermanager.CreateUser(user1);

            User user2 = new User();
            user2.Name = new Name();
            user2.Address = new Address();
            user2.Name.FirstName = "Sakshi";
            user2.Name.LastName = "Sharma";
            user2.Name.MiddleName = "";
            user2.Name.Prefix = "Ms";
            user2.Address.City = "Pune";
            user2.Address.Country = "India";
            user2.Address.State = "Maharastra";
            user2.Address.LineNo = "ZensarLine";
            user2.Address.PinCode = "455621";
            user2.Username = "sakshi_sharma";
            user2.Password = "1234";
            user2.Gender = Gender.Female;
            usermanager.CreateUser(user2);

            User user3 = new User();
            user3.Name = new Name();
            user3.Address = new Address();
            user3.Name.FirstName = "Smita";
            user3.Name.LastName = "Acharya";
            user3.Name.MiddleName = "";
            user3.Name.Prefix = "Ms";
            user3.Address.City = "Pune";
            user3.Address.Country = "India";
            user3.Address.State = "Maharastra";
            user3.Address.LineNo = "ZensarLine";
            user3.Address.PinCode = "455821";
            user3.Username = "smita_acharya";
            user3.Password = "1235";
            user3.Gender = Gender.Female;
            usermanager.CreateUser(user3);

            Assert.AreEqual(3, usermanager.GetAllUsers().Count);
        }

        [TestMethod]
        public void Test_Searching_UserCheck()
        {
            UserManager usermanager = new UserManager();
            User user1 = new User();
            user1.Name = new Name();
            user1.Address = new Address();
            user1.Name.FirstName = "Bandana";
            user1.Name.LastName = "Mahapatra";
            user1.Name.MiddleName = "";
            user1.Name.Prefix = "Ms";
            user1.Address.City = "Pune";
            user1.Address.Country = "India";
            user1.Address.State = "Maharastra";
            user1.Address.LineNo = "ZensarLine";
            user1.Address.PinCode = "455221";
            user1.Username = "bandana_mahapatra";
            user1.Password = "123";
            user1.Gender = Gender.Female;
            usermanager.CreateUser(user1);

            User user2 = new User();
            user2.Name = new Name();
            user2.Address = new Address();
            user2.Name.FirstName = "Sakshi";
            user2.Name.LastName = "Sharma";
            user2.Name.MiddleName = "";
            user2.Name.Prefix = "Ms";
            user2.Address.City = "Pune";
            user2.Address.Country = "India";
            user2.Address.State = "Maharastra";
            user2.Address.LineNo = "ZensarLine";
            user2.Address.PinCode = "455621";
            user2.Username = "sakshi_sharma";
            user2.Password = "1234";
            user2.Gender = Gender.Female;
            usermanager.CreateUser(user2);

            User user3 = new User();
            user3.Name = new Name();
            user3.Address = new Address();
            user3.Name.FirstName = "Smita";
            user3.Name.LastName = "Acharya";
            user3.Name.MiddleName = "";
            user3.Name.Prefix = "Ms";
            user3.Address.City = "Pune";
            user3.Address.Country = "India";
            user3.Address.State = "Maharastra";
            user3.Address.LineNo = "ZensarLine";
            user3.Address.PinCode = "455821";
            user3.Username = "smita_acharya";
            user3.Password = "1235";
            user3.Gender = Gender.Female;
            usermanager.CreateUser(user3);

            Assert.AreNotSame(user1.Name.FirstName, usermanager.GetUser("bandana"));
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Sakshi").Name.LastName);
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Bandana").Name.LastName);
        }

        [TestMethod]
        public void Test_Searching_UserCheck_with_Different_Field()
        {
            UserManager usermanager = new UserManager();
            User user1 = new User();
            user1.Name = new Name();
            user1.Address = new Address();
            user1.Name.FirstName = "Bandana";
            user1.Name.LastName = "Mahapatra";
            user1.Name.MiddleName = "";
            user1.Name.Prefix = "Ms";
            user1.Address.City = "Pune";
            user1.Address.Country = "India";
            user1.Address.State = "Maharastra";
            user1.Address.LineNo = "ZensarLine";
            user1.Address.PinCode = "455221";
            user1.Username = "bandana_mahapatra";
            user1.Password = "123";
            user1.Gender = Gender.Female;
            usermanager.CreateUser(user1);

            User user2 = new User();
            user2.Name = new Name();
            user2.Address = new Address();
            user2.Name.FirstName = "Sakshi";
            user2.Name.LastName = "Sharma";
            user2.Name.MiddleName = "";
            user2.Name.Prefix = "Ms";
            user2.Address.City = "Pune";
            user2.Address.Country = "India";
            user2.Address.State = "Maharastra";
            user2.Address.LineNo = "ZensarLine";
            user2.Address.PinCode = "455621";
            user2.Username = "sakshi_sharma";
            user2.Password = "1234";
            user2.Gender = Gender.Female;
            usermanager.CreateUser(user2);

            User user3 = new User();
            user3.Name = new Name();
            user3.Address = new Address();
            user3.Name.FirstName = "Smita";
            user3.Name.LastName = "Acharya";
            user3.Name.MiddleName = "";
            user3.Name.Prefix = "Ms";
            user3.Address.City = "Pune";
            user3.Address.Country = "India";
            user3.Address.State = "Maharastra";
            user3.Address.LineNo = "ZensarLine";
            user3.Address.PinCode = "455821";
            user3.Username = "smita_acharya";
            user3.Password = "1235";
            user3.Gender = Gender.Female;
            usermanager.CreateUser(user3);

            Assert.AreNotSame(user1.Name.FirstName, usermanager.GetUser("mahapatra"));
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Sakshi").Name.LastName);
            //Assert.AreSame(user1.Name.LastName, usermanager.GetUser("Bandana").Name.LastName);
        }
    }
}
