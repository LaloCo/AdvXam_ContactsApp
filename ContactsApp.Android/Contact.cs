using System;
using ContactsApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.Droid
{
    [Android.Runtime.Preserve (AllMembers = false)]
    public class Contact : IContact
    {
        [Android.Runtime.Preserve(Conditional = false)]
        public Contact()
        {
            // code that I want to preserve
        }

        public string ByeContact()
        {
            Contacts.Contact contact = new Contacts.Contact("Eduardo", "Rosas", "lalo@example.com");
            return contact.ByeContact();
        }

        public string HelloContact()
        {
            Contacts.Contact contact = new Contacts.Contact("Eduardo", "Rosas", "lalo@example.com");
            return contact.GreetContact();
        }
    }
}
