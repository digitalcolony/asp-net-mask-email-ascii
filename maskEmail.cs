using System;
using System.Text;
using System.Web;

public partial class lab_maskemail_EmailMask : System.Web.UI.UserControl
{
    private string emailAddress;
    public string EmailAddress
    {
        get { return emailAddress; }
        set { emailAddress = value; }
    }

    private string visibleAddress;
    public string VisibleAddress
    {
        get
        {
            // if unassigned return emailAddress

            if (visibleAddress==null || visibleAddress.Length == 0)
            {
                return emailAddress;
            }
            else
            {
                return visibleAddress;
            }

       }
        set { visibleAddress = value; }
    }

    private string mouseoverTag;
    public string MouseoverTag
    {
        get { return mouseoverTag; }
        set { mouseoverTag = value; }
    }

    private string subject;
    public string Subject
    {
        get { return subject; }
        set { subject = value; }
    }

    private string cssClass;
    public string CssClass
    {
        get { return cssClass;}
        set { cssClass = value; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        // The MIN required for control is an email address, confirm it exists

        if (emailAddress == null || emailAddress.Length == 0)
        {
            ltEmail.Text = "Assign EmailAddress to Control";
            return;
        }

        // Build ASCII encoded Link
        StringBuilder asciiLink = new StringBuilder();
        asciiLink.Append("<a href=\"m&#97;ilto:");
        asciiLink.Append(ASCIIEncode(EmailAddress));
        if(subject != null && subject.Length > 0 )
        {
            asciiLink.Append("?subject=" + subject);
        }
        asciiLink.Append("\"");
        if (mouseoverTag != null && mouseoverTag.Length > 0)
        {
            asciiLink.Append(" title=\"" + mouseoverTag + "\"");
        }
        if (cssClass !=null && cssClass.Length > 0)
        {
            asciiLink.Append(" class=\"" + cssClass + "\"");
        }
        asciiLink.Append(">");
        asciiLink.Append(ASCIIEncode(VisibleAddress));
        asciiLink.Append("</a>");

        ltEmail.Text = asciiLink.ToString();
    }

    protected string ASCIIEncode(string regularText)
    {
        regularText = regularText.Trim();

        StringBuilder encodeSB = new StringBuilder();
        char regularLetter;

        for (int j = 0; j < regularText.Length; j++)
        {
            // peel off 1 character at a time

            regularLetter = regularText[j];
            encodeSB.Append("&#" + Convert.ToInt32(regularLetter).ToString() + ";");
        }

        return encodeSB.ToString();
    }
