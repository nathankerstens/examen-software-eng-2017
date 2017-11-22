/*
 * A simple About Form
 * Downloaded from www.publicjoe.co.uk
 *
 * This software is provided 'as-is', without any express or implied warranty.
 * In no event will the author(s) be held liable for any damages arising from
 * the use of this software.
 * 
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely.
 */

using System;
using System.Drawing;
using System.Windows.Forms;

public class AboutFrm : Form
{
  private Label myLabel;
  private LinkLabel linkLabel;

  public AboutFrm()
  {
    // Set up Form
    this.Size = new Size( 210, 100 );
    this.MaximizeBox = false;
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Text = "About";

    // Set up myLabel
    myLabel = new Label();
    myLabel.Text = "Publicjoe's C# Tutorial";
    myLabel.Size = new Size( 180, 20 );
    myLabel.Location = new Point(10,10);
    myLabel.ForeColor = Color.SteelBlue;
    myLabel.Font = new Font("Microsoft Sans Serif" , 12f , FontStyle.Bold);
    this.Controls.Add(myLabel);

    // Set up linkLabel
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
    System.Diagnostics.Process.Start("https://www.hasbro.com/common/instruct/Yahtzee.pdf");
  }
}
