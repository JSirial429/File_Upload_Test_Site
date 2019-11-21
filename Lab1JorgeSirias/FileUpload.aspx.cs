using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

/*
  Author:Jorge Sirias
  COP 4813 Website Application Programming
 */ 
 

public partial class FileUpload : System.Web.UI.Page
{
    String fileName;

    protected void Page_Load(object sender, EventArgs e)
    {
        Outer.Visible = false;
        MessageBox.Visible = false;

        if (Directory.GetFileSystemEntries(Server.MapPath("~/Files/")).Length == 0)
        {
            Outer.Visible = true;
            MessageBox.Visible = true;
            Label1.Text = "No files were found";
        }
        else
        {
            Grid.Visible = true;
            //if (!IsPostBack)
            //{
            string[] directoryFiles = Directory.GetFiles(Server.MapPath("~/Files/" + fileName));
            List<ListItem> files = new List<ListItem>();
            foreach (string filePath in directoryFiles)
            {
                files.Add(new ListItem(Path.GetFileName(filePath), filePath));
                //files.Add(new ListItem(filePath.Length.ToString()));
            }
            GridView1.DataSource = files;
            GridView1.DataBind();
            //}
        }
    }
    protected void UploadButton_Click(object sender, EventArgs e)
    {
        if(FileUploadControl.HasFile)
        {
            int count = 0;
            int index;
            string temp;

            fileName = FileUploadControl.FileName;

            while(File.Exists(Server.MapPath("~/Files/" + fileName)))
            {
                count++;
                index = fileName.IndexOf('.');
                //index -= 1;
                fileName = fileName.Insert(index,count.ToString());
                //fileName += count.ToString();
            }
            
            FileUploadControl.SaveAs(Server.MapPath("~/Files/"+ fileName));
        }
        else
        {
            Outer.Visible = true;
            MessageBox.Visible = true;
            Label1.Text = "Please choose a file and try again";
        }
    }
}