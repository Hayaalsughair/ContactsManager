using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ContactManagerTests
{
    public class UnitTest1
    {
        /*    [Fact]
            public void Method_Scenario_Outcome()
            {

            }*/
        [Fact]
        public void AddContact_RturnSuccessMessage_AddContactAdded()
        {
            //Arrange
            var contacts = new Dictionary<string, int>();
            string userName = "TestName";
            int userContactNumber = 078778800;

            //Act
            Program.AddContact(contacts, userName, userContactNumber);
            //Aseert
        }




    }
    }
