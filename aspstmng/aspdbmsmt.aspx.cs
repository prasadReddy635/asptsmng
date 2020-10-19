using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;
namespace aspstmng
{
    public partial class aspdbmsmt : System.Web.UI.Page
    {
        SqlConnection con; SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ReadCS.ASPDB); cmd = new SqlCommand(); cmd.Connection = con;
        }

        protected void btnuploadimage_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFiles)
            {
                HttpPostedFile SelectedFile = FileUpload1.PostedFile; string FileExt = Path.GetExtension(SelectedFile.FileName);
                if (FileExt == ".jpg" || FileExt == ".bmp" || FileExt == ".gif" || FileExt == ".png")
                {
                    string ImgName = SelectedFile.FileName; string FolderPath = Server.MapPath("~/Images/");
                    if (Directory.Exists(FolderPath) == false) { Directory.CreateDirectory(FolderPath); }
                    SelectedFile.SaveAs(FolderPath + ImgName); imgPhoto.ImageUrl = "~/Images/" + ImgName;
                    BinaryReader br = new BinaryReader(SelectedFile.InputStream);
                    byte[] ImgData = br.ReadBytes(SelectedFile.ContentLength);
                    Session["PhotoBinary"] = ImgData; Session["PhotoName"] = ImgName;
                }
                else { Response.Write("<script>alert('Selected file format is not supported.')</script>"); }
            }
            else { Response.Write("<script>alert('Please select an image file to upload.')</script>"); }

        }
    }
}