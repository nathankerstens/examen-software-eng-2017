using System;
using System.Drawing;
using System.Windows.Forms;

public class AboutFrm : Form
{
  private Label myLabel;
  private LinkLabel linkLabel;

  public AboutFrm()
  {
    
    this.Size = new Size( 210, 100 );
    this.MaximizeBox = false;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Text = "About";

    myLabel = new Label();
    myLabel.Text = "Publicjoe's C# Tutorial";
    myLabel.Size = new Size( 180, 20 );
    myLabel.Location = new Point(10,10);
    myLabel.ForeColor = Color.SteelBlue;
    myLabel.Font = new Font("Microsoft Sans Serif" , 12f , FontStyle.Bold);
    this.Controls.Add(myLabel);

    linkLabel = new LinkLabel();
    linkLabel.Text = "Click to visit my Site";
    linkLabel.Size = new Size( 180, 20 );
    linkLabel.Location = new Point(10,40);
    linkLabel.ForeColor = Color.Yellow;
    linkLabel.Font = new Font("Microsoft Sans Serif" , 12f);
    linkLabel.LinkClicked += new LinkLabelLinkClickedEventHandler(this.OnClickWebsite);
    this.Controls.Add(linkLabel);
  }

  protected void OnClickWebsite (object sender, LinkLabelLinkClickedEventArgs e)
  {
    linkLabel.LinkVisited = true;
    System.Diagnostics.Process.Start( "http://www.publicjoe.f9.co.uk/csharp/tut.html" );
  }
}
