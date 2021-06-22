using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_APP
{
    public partial class Dashboard : Form
    {
        SqlConnection con = new SqlConnection(
            ConfigurationManager
            .ConnectionStrings["CRUD_APP.Properties.Settings.ConnectionString"]
            .ConnectionString);

        public Dashboard()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM GAME ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewGames.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Reset()
        {
            GameTitle.Text = "";
            Developers.Text = "";
            Price.Text = "";
            Genre.Text = "";
        }


        private void Insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (GameTitle.Text != "" && 
                    Developers.Text != ""&&
                    Price.Text!=""&&
                    Genre.Text!=""
                    )
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand($"INSERT INTO Game (title,developers,price,genre,release) VALUES (" +
                        $"  '{GameTitle.Text}'," +
                        $"  '{Developers.Text}'," +
                        $"  {float.Parse(Price.Text)}," +
                        $"  '{Genre.Text}'," +
                        $"  '{DateTime.Parse(ReleaseDatePicker.Text)}') ;", 
                        con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Inserted Successfully !");
                }
                else
                {
                    MessageBox.Show("Please Provide Details!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR : "+ex.Message);
            }
            finally
            {
                con.Close();
                Reset();
                DisplayData();
            }

        }

        private void G_Select_all_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void G_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void GUpdate_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = DataGridViewGames.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string GametitleTOupdate = DataGridViewGames.SelectedRows[0].Cells[0].Value.ToString() ;
                con.Open();
                try
                {
                    if (GameTitle.Text != "" &&
                        Developers.Text != "" &&
                        Price.Text != "" &&
                        Genre.Text != ""
                        )
                    {
                        SqlCommand cmd = new SqlCommand($"UPDATE Game SET price ={float.Parse(Price.Text)},developers='{Developers.Text}',genre='{Genre.Text}', " +
                            $"release='{DateTime.Parse(ReleaseDatePicker.Text)}',title='{GameTitle.Text}' WHERE title='{GametitleTOupdate}'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record Updated Successfully ");
                    }
                    else
                    {
                        MessageBox.Show("Please add new attributes values for the Record to Update !");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Reset();
                    DisplayData();

                }
            }
            else
            {
                MessageBox.Show("Select a row to update its content");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
             Int32 selectedRowCount = DataGridViewGames.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string GametitleTOupdate = DataGridViewGames.SelectedRows[0].Cells[0].Value.ToString();
                
                try
                {
                     con.Open();
                     SqlCommand cmd = new SqlCommand($"DELETE Game WHERE title='{GametitleTOupdate}'", con);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Record is deleted Successfully ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR : " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Reset();
                    DisplayData();
                    
                }
            }
            else
            {
                MessageBox.Show("Select a row to update its content");
            }

        }

        private void Search_Click(object sender, EventArgs e)
        {
            int nbconcat = 0;
            String querybuilt = "";
            if (GameTitle.Text != "")
            {
                if (nbconcat > 0)
                {
                    querybuilt += " and ";
                }
                querybuilt += $"title='{GameTitle.Text}'";
                nbconcat++;
            }
            if (Genre.Text != "")
            {
                if (nbconcat > 0)
                {
                    querybuilt += " and ";
                }
                querybuilt += $"genre='{Genre.Text}'";
                nbconcat++;

            }
            if (Developers.Text != "")
            {
                if (nbconcat > 0)
                {
                    querybuilt += " and ";
                }
                querybuilt += $"developers='{Developers.Text}'";
                nbconcat++;

            }
            if (Price.Text != "")
            {
                if (nbconcat > 0)
                {
                    querybuilt += " and ";
                }
                querybuilt += $"price={float.Parse(Price.Text)}";
                nbconcat++;

            }

            try
            {
                con.Open();
                Console.WriteLine(querybuilt);
                SqlCommand cmd = new SqlCommand($"SELECT * FROM GAME WHERE {querybuilt}; ", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataGridViewGames.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void G_Print_Click(object sender, EventArgs e)
        {
            if (DataGridViewGames.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "Output.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        PdfPTable pdfTable = new PdfPTable(DataGridViewGames.Columns.Count);
                        pdfTable.DefaultCell.Padding = 3;
                        pdfTable.WidthPercentage = 100;
                        pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                        foreach (DataGridViewColumn column in DataGridViewGames.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                            pdfTable.AddCell(cell);
                        }
                        
                        foreach (DataGridViewRow row in DataGridViewGames.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if(cell.Value!=null)
                                    pdfTable.AddCell(cell.Value.ToString());

                            }
                        }
                        
                        using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter.GetInstance(pdfDoc, stream);
                            pdfDoc.Open();
                            pdfDoc.Add(pdfTable);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Data Exported Successfully !!!", "Info");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error :" + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }
    }
}
