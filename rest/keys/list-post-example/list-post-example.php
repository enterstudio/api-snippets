<?php
// Get the PHP helper library from twilio.com/docs/php/install
require_once('/path/to/twilio-php/Services/Twilio.php'); // Loads the library

// Your Account Sid and Auth Token from twilio.com/user/account
$sid = "ACdc5f132a3c49700934481addd5ce1659";
$token = "{{ auth_token }}";
$client = new Services_Twilio($sid, $token);

$key = $client->account->keys->create(array("FriendlyName" => "User Jenny"));
echo $key->sid;
echo $key->secret;
