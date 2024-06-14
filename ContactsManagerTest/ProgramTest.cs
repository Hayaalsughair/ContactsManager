using Xunit;
using ContactsManager;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Collections.Generic;

namespace ContactsManagerTest
{
    public class ProgramTest
    {  

        [Fact]
        public void AddContact_ReturnAddSuccessMessage_ContactAdded()
        {
            //Arrange
            string userName = "TestName";
            string userContactNumber = "078778800";

            //Act
            string result = ContactsManager.Program.AddContact(userName, userContactNumber);
            
            //Aseert
            Assert.Equal("Contact added successfully.", result);
        }

        [Fact]
        public void DeleteContact_RturnDeleteSuccessMessage_ContactDeleted()
        {
            string userName = "TestName";
            string userContactNumber = "078778800";
            ContactsManager.Program.AddContact(userName, userContactNumber);
            //Arrange            
            string deleteUserName = "TestName";

            //Act
            string result = ContactsManager.Program.DeleteContact(deleteUserName);
            
            //Aseert
            Assert.Equal("Contact Deleted successfully.", result);

        }

        [Fact]
        public void AddContact_ReturnAlreadyExistsMessage_EroorContact()
        {
            string userName = "TestName";
            string userContactNumber = "078778800";
            ContactsManager.Program.AddContact(userName, userContactNumber);
            //Arrange
            string userNameContact = "TestName";
            string userContactNumberContact = "078778800";

            //Act
            string result = ContactsManager.Program.AddContact(userNameContact, userContactNumberContact);

            //Aseert
            Assert.Equal("Contact with this name already exists.", result);

        }

        [Fact]
        public void ViewAllContacts_ReturnDictionary_SearchContact()
        {
            //Arrange
            string userName1 = "TestName1";
            string userContactNumber1 = "078778800";
            ContactsManager.Program.AddContact(userName1, userContactNumber1);
            string userName2 = "TestName2";
            string userContactNumber2 = "078778811";
            ContactsManager.Program.AddContact(userName2, userContactNumber2);
            //Act 
            var result = ContactsManager.Program.ViewContacts();
            //Aseert
            Assert.Contains(new KeyValuePair<string, string>("TestName1", "078778800"), result);
            Assert.Contains(new KeyValuePair<string, string>("TestName2", "078778811"), result);

        }


    }

}