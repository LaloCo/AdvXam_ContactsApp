using System;
using ContactsApp.iOS;
using ContactsLibraryiOS;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.iOS
{
    [Preserve(AllMembers = true)]
    public class Contact : IContact
    {
        [Preserve(Conditional = true)]
        public Contact()
        {
            // CODE THAT WE WANT TO PRESERVE
        }

        public string ByeContact()
        {
            ContactsLibraryiOS.ContactsApp contact = new ContactsLibraryiOS.ContactsApp((Foundation.NSString)"Eduardo", (Foundation.NSString)"Rosas", (Foundation.NSString)"lalo@example.com");
            return contact.ByeContact();
        }

        public string HelloContact()
        {
            ContactsLibraryiOS.ContactsApp contact = new ContactsLibraryiOS.ContactsApp((Foundation.NSString)"Eduardo", (Foundation.NSString)"Rosas", (Foundation.NSString)"lalo@example.com");
            return contact.GreetContact();
        }
    }
}
