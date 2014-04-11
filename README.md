asp-net-mask-email-ascii
========================

An ASP.NET control for masking email addresses using ASCII code

In the article Masking Your Email Address, we went over why you would want to hide your email address inside the source code of an HTML document, but still make it visible to the human readers of that page.  Encapsulating the code into a single .NET user control is ideal for protecting email addresses for ASP.NET sites.
http://criticalmas.com/2014/04/masking-email-address/

Step 1 – Create a Web User Control

Add an asp:Literal control to that page.

<asp:Literal ID="ltEmail" runat="server" />
Step 2 – Jump to the Code Behind

The EmailMask code follows. Note the name of the class lab_maskemail_EmailMask was created by Visual Studio for me. Use whatever name you like or Visual Studio recommends here. The rest of the code should be the same. This code is for ASP.NET 2.0.


Step 3 – Create a Test Page

Register the control at the top using whatever path and naming convention you’ve chosen.

