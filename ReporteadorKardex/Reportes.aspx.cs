using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;

namespace ReporteadorKardex
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void lstboxSPS_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnConsultar.Visible = true;
            gvReportes.DataSource = null;
            gvReportes.DataBind();
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            
            
            Panel1.Visible = true;
            switch ((lstboxSPS.SelectedIndex + 1))
            {
                case 1:
                    lbReporte.Text = "Reporte: Carreras en un Campus";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Campus:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = true;
                    lbDDL2.Text = "Estatus - Carrera:";
                    DDL2.Visible = true;


                    lb1.Visible = true;
                    lb1.Text = "Campus";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Carrera";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 2:
                    lbReporte.Text = "Reporte: Materias asignadas a una Carrera";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Carrera:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = true;
                    lbDDL2.Text = "Estatus - Materia:";
                    DDL2.Visible = true;


                    lb1.Visible = true;
                    lb1.Text = "Carrera";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Materia";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;
                    break;
                case 3:
                    lbReporte.Text = "Reporte: Maestros asignados a una Materia";

                    lbDDL1.Visible = false;
                    lbDDL1.Text = " ";
                    DDL1.Visible = false;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Periodo";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Carrera";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 4:
                    lbReporte.Text = "Reporte: Maestros por Estatus en una Carrera";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Maestro:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Periodo";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Carrera";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 5:
                    lbReporte.Text = "Reporte: Alumnos asignados por Materia";


                    lbDDL1.Visible = false;
                    lbDDL1.Text = " ";
                    DDL1.Visible = false;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Periodo";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Carrera";
                    txt2.Visible = true;

                    lb3.Visible = true;
                    lb3.Text = "Grupo";
                    txt3.Visible = true;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 6:
                    lbReporte.Text = "Reporte: Alumnos en una Carrera por Estatus";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Alumno:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Periodo";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Grupo";
                    txt2.Visible = true;

                    lb3.Visible = true;
                    lb3.Text = "Carrera";
                    txt3.Visible = true;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 7:
                    lbReporte.Text = "Reporte: Calificaciones por Alumno de todas las Materias";

                    lbDDL1.Visible = false;
                    lbDDL1.Text = " ";
                    DDL1.Visible = false;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Alumno";
                    txt1.Visible = true;

                    lb2.Visible = false;
                    lb2.Text = " ";
                    txt2.Visible = false;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;
                    break;
                case 8:
                    lbReporte.Text = "Reporte: Calificaciones de Alumno por Materia y Periodo";

                    lbDDL1.Visible = false;
                    lbDDL1.Text = " ";
                    DDL1.Visible = false;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Alumno";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Materia";
                    txt2.Visible = true;

                    lb3.Visible = true;
                    lb3.Text = "Periodo";
                    txt3.Visible = true;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 9:
                    lbReporte.Text = "Reporte: Horario de un Maestro";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Periodo:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Maestro";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Periodo";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;
                    break;
                case 10:
                    lbReporte.Text = "Reporte: Horario de un Alumno";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Periodo:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Alumno";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Periodo";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;

                    break;
                case 11:
                    lbReporte.Text = "Reporte: Horario de un Grupo";

                    lbDDL1.Visible = true;
                    lbDDL1.Text = "Estatus - Periodo:";
                    DDL1.Visible = true;


                    lbDDL2.Visible = false;
                    lbDDL2.Text = " ";
                    DDL2.Visible = false;


                    lb1.Visible = true;
                    lb1.Text = "Grupo";
                    txt1.Visible = true;

                    lb2.Visible = true;
                    lb2.Text = "Periodo";
                    txt2.Visible = true;

                    lb3.Visible = false;
                    lb3.Text = " ";
                    txt3.Visible = false;

                    lb4.Visible = false;
                    lb4.Text = " ";
                    txt4.Visible = false;
                    break;
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            List<string> parametros = new List<string>();
            dbconn db = new dbconn();

            string estatus1 = "";
            if (DDL1.SelectedItem.Text == "Inactivo")
            {
                estatus1 = "0";
            }
            else
            {
                estatus1 = "1";
            }

            string estatus2 = "";
            if (DDL2.SelectedItem.Text == "Inactivo")
            {
                estatus2 = "0";
            }
            else
            {
                estatus2 = "1";
            }


            switch ((lstboxSPS.SelectedIndex + 1))
                {
                    case 1:
                    
                        parametros.Add(estatus1);
                        parametros.Add(estatus2);
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);                        
                        gvReportes.DataSource = db.ExecSP("REPORTE1", parametros);
                        parametros.Clear();
                        break;
                    case 2:                      
                        parametros.Add(estatus1);
                        parametros.Add(estatus2);
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                    gvReportes.DataSource = db.ExecSP("REPORTE2", parametros);
                        parametros.Clear();
                        break;
                    case 3:
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE3", parametros);
                        parametros.Clear();
                        break;
                    case 4:
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                        parametros.Add(estatus1);
                        gvReportes.DataSource = db.ExecSP("REPORTE4", parametros);
                        parametros.Clear();
                        break;
                    case 5:
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                        parametros.Add(txt3.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE5", parametros);
                        parametros.Clear();
                        break;
                    case 6:
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                        parametros.Add(txt3.Text);
                        parametros.Add(estatus1);
                        gvReportes.DataSource = db.ExecSP("REPORTE6", parametros);
                        parametros.Clear();
                        break;
                    case 7:
                        parametros.Add(txt1.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE7", parametros);
                        parametros.Clear();
                        break;
                    case 8:
                        parametros.Add(txt1.Text);
                        parametros.Add(txt2.Text);
                        parametros.Add(txt3.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE8", parametros);
                        parametros.Clear();
                        break;
                    case 9:
                        parametros.Add(txt1.Text);
                        parametros.Add(estatus1);
                        parametros.Add(txt2.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE9", parametros);
                        parametros.Clear();
                        break;
                    case 10:
                        parametros.Add(txt1.Text);
                        parametros.Add(estatus1);
                        parametros.Add(txt2.Text);

                        gvReportes.DataSource = db.ExecSP("REPORTE10", parametros);
                        parametros.Clear();
                        break;
                    case 11:
                        parametros.Add(txt1.Text);
                        parametros.Add(estatus1);
                        parametros.Add(txt2.Text);
                        gvReportes.DataSource = db.ExecSP("REPORTE11", parametros);
                        parametros.Clear();
                        break;
                }
            
            gvReportes.DataBind();
            btnExportar.Visible = true;
        }

        protected void btnExportar_Click(object sender, EventArgs e)
        {
            //https://csharp-video-tutorials.blogspot.com/2013/04/export-gridview-to-pdf-in-aspnet-part-58.html
            int columnsCount = gvReportes.HeaderRow.Cells.Count;
            // Create the PDF Table specifying the number of columns
            PdfPTable pdfTable = new PdfPTable(columnsCount);

            // Loop thru each cell in GrdiView header row
            foreach (TableCell gridViewHeaderCell in gvReportes.HeaderRow.Cells)
            {
                // Create the Font Object for PDF document
                Font font = new Font();
                // Set the font color to GridView header row font color
                font.Color = new BaseColor(gvReportes.HeaderStyle.ForeColor);

                // Create the PDF cell, specifying the text and font
                PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewHeaderCell.Text, font));

                // Set the PDF cell backgroundcolor to GridView header row BackgroundColor color
                pdfCell.BackgroundColor = new BaseColor(gvReportes.HeaderStyle.BackColor);

                // Add the cell to PDF table
                pdfTable.AddCell(pdfCell);
            }

            // Loop thru each datarow in GrdiView
            foreach (GridViewRow gridViewRow in gvReportes.Rows)
            {
                if (gridViewRow.RowType == DataControlRowType.DataRow)
                {
                    // Loop thru each cell in GrdiView data row
                    foreach (TableCell gridViewCell in gridViewRow.Cells)
                    {
                        Font font = new Font();
                        font.Color = new BaseColor(gvReportes.RowStyle.ForeColor);

                        PdfPCell pdfCell = new PdfPCell(new Phrase(gridViewCell.Text, font));

                        pdfCell.BackgroundColor = new BaseColor(gvReportes.RowStyle.BackColor);

                        pdfTable.AddCell(pdfCell);
                    }
                }
            }

            // Create the PDF document specifying page size and margins
            Document pdfDocument = new Document(PageSize.A4.Rotate(), 10f, 10f, 10f, 10f);

            PdfWriter.GetInstance(pdfDocument, Response.OutputStream);

            pdfDocument.Open();
            pdfDocument.Add(pdfTable);
            pdfDocument.Close();

            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition",
                "attachment;filename=Reporte.pdf");
            Response.Write(pdfDocument);
            Response.Flush();
            Response.End();
        }
    }
}