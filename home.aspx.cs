using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using NExifTool;
using System.Diagnostics;
//using NExifTool.Enums;
using ExifToolWrap;

namespace WebAppTaller1
{
    public partial class home : System.Web.UI.Page
    {

       
        public void ReadMeta(string srcFilename)
        {
            ExifToolWrapper et = new ExifToolWrapper();
            string meta = et.GetTags(srcFilename);
            txtSalida.Text = meta;

            
        }

        public void UploadFile()
        {
            if (IsPostBack)
            {
                Boolean fileOK = false;
                String path = Server.MapPath("~/Imagenes/");
                if (FileUpload1.HasFile)
                {
                    String fileExtension =
                        System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();
                    String[] allowedExtensions =
                        {".gif", ".png", ".jpeg", ".jpg"};
                    for (int i = 0; i < allowedExtensions.Length; i++)
                    {
                        if (fileExtension == allowedExtensions[i])
                        {
                            fileOK = true;
                        }
                    }
                }

                if (fileOK)
                {
                    try
                    {
                        FileUpload1.PostedFile.SaveAs(path
                            + FileUpload1.FileName);

                        imgPreview.ImageUrl = "Imagenes/" + FileUpload1.FileName;

                        Label1.Text = "Analizando imagen...";

                        ReadMeta(path + FileUpload1.FileName);


                        Label1.Text = "Análisis terminado";
                        txtSalida.Visible = true;
                        imgPreview.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        Label1.Text = "El archivo no se pudo subir:" + ex.InnerException;
                    }
                }
                else
                {
                    Label1.Text = "Solo e aceptan imagenes jpg, jpge, gif, png.";
                }
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLeerMetadatos_Click(object sender, EventArgs e)
        {
            UploadFile();
            
        }
    }
}