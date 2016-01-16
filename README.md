# TNCVote
Title:		Transhuman National Committee Member Portal
URL:		http://www.TranshumanPolitics.com/
wiki:		http://wiki.transhumanpolitics.com/index.php?title=GitHub_TranshumanNationalCommitte_TNCVote
Github:		https://github.com/TranshumanNationalCommitte
fb:			https://www.facebook.com/groups/TNCTP/
Team:       Kevin MacNeel
			David J Kelley

Setup Instructions: 

1. Remove this file (ReadMe.txt) from any production deployment... 

2. Remove any reference to TNC for your deployment.

3. Create Database and Server setup in azure and put a reference in web.config at the root like this: 

  <connectionStrings>
    <add name="DefaultConnection" providerName="System.Data.SqlClient"
         connectionString="Server=[Server Name and IP];Database=TNCTest;User ID=[User Name];
		 Password=[PSWD];Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;" 
         />
  </connectionStrings>

4 Make sure that you add a IP reference to the azure server in question to unblock the connection.

5. Configure an SMTP Endpoint so the system can send new emails.  You will need to update the file 
	AccountController.cs

	in this method:    public void SendConfirmationEmail(String NewMemberEmailAccount)

	you need to update the hard coded values including: 

	client.Host = [smtp server url]
	client.Port = [port number]
	client.Credentials = new System.Net.NetworkCredential([from email], [password]);

6. Remove any refernece to the TNC

7. Configure the database: 

http://www.entityframeworktutorial.net/code-first/code-based-migration-in-code-first.aspx

8. Configure reCAPTCHA, you will need a site key and secret key here: 

https://www.google.com/recaptcha/intro/index.html

for example in web.config you need to udpate these: 

    <add key="reCaptchaPublicKey" value="6LdtGBUTAAAAAPc7xMZx8SlUZDxBuX1gvy5PNyb1" />
    <add key="reCaptchaPrivateKey" value="6LdtGBUTAAAAAPMxn8vrUxXszNeKsY1J3Vm8buWb" />
