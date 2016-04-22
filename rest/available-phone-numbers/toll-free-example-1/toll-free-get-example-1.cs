// Download the twilio-csharp library from twilio.com/docs/csharp/install
using System;
using Twilio;
class Example 
{
  static void Main(string[] args) 
  {
    // Find your Account Sid and Auth Token at twilio.com/user/account
    string AccountSid = "ACde6f132a3c49700934481addd5ce1659";
    string AuthToken = "{{ auth_token }}";
    var twilio = new TwilioRestClient(AccountSid, AuthToken);

    
    var result = twilio.ListAvailableTollFreePhoneNumbers("US");
    
    // Purchase the first number in the list
    var availableNumber = result.AvailablePhoneNumbers[0];
    var purchaseOptions = new PhoneNumberOptions();
    purchaseOptions.PhoneNumber = availableNumber.PhoneNumber;
    
    var number = twilio.AddIncomingPhoneNumber(purchaseOptions);
    Console.WriteLine(number.Sid);
    
  }
}