using System;
using System.Net.Mail;

namespace Xamarin.Contacts
{
	public enum EmailType
	{
		Home,
		Work,
		Other
	}

	public class Email
	{
		public EmailType Type
		{
			get;
			set;
		}

		public string Label
		{
			get;
			set;
		}

		public string Address
		{
			get;
			set;
		}

		//public string Address
		//{
		//    get
		//    {
		//        if (this.address == null)
		//            return null;

		//        return this.address.ToString();
		//    }

		//    set
		//    {
		//        if (String.IsNullOrWhiteSpace (value))
		//        {
		//            this.address = null;
		//            return;
		//        }

		//        this.address = new MailAddress (value);
		//    }
		//}

		//public override string ToString()
		//{
		//    return Address;
		//}

		//private MailAddress address;

		//public static bool TryParse (string address, out Email email)
		//{
		//    email = new Email();
		//    try
		//    {
		//        email.Address = address;
		//        return true;
		//    }
		//    catch (Exception)
		//    {
		//        email = null;
		//        return false;
		//    }
		//}
	}
}