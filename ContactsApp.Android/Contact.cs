using System;
using ContactsApp.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(Contact))]
namespace ContactsApp.Droid
{
	public class Contact : IContact
    {
        public Contact()
        {
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
