using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.Entity;

namespace MiniProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                ClientTitle c = new ClientTitle();

                //Populating Title
                List<ClientTitle> type = context.ClientTitles.ToList();
                DropDownList1.DataSource = type;
                DropDownList1.DataTextField = "Title";
                DropDownList1.DataValueField = "CT_ID";
                DropDownList1.DataBind();

                //Populating Furniture
                List<FurnitureType> typeFurniture = context.FurnitureTypes.ToList();
                DropDownList2.DataSource = typeFurniture;
                DropDownList2.DataTextField = "Furn_Type";
                DropDownList2.DataValueField = "FT_ID";
                DropDownList2.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {

                string name = txtName.Text;
                string surname = txtSurname.Text;
                int IDNo = Convert.ToInt32(txtIDNumber.Text);
                //Set PK of CT_ID


                string t = DropDownList1.Text;
                // ClientTitle title = context.ClientTitles.FirstOrDefault(r => r.Title == t);

                //Adding
                Client client = new Client
                {
                    Name = name,
                    Surname = surname,
                    IDNum = IDNo,
                    CT_ID = 1
                };
                Client clientDB = context.Clients.FirstOrDefault(r => r.Name == client.Name);
                if (clientDB == null)
                {
                    try
                    {
                        context.Clients.Add(client);
                        context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        Response.Write(ex);
                    }
                }
                else
                {
                    Response.Write("Client exists already");
                }
            }
            Response.Write("Saved");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string clientName = txtClientSearch.Text;
                Client client = context.Clients.FirstOrDefault(r => r.Name == clientName);
                Response.Write(client.Name + " " + " " + client.Surname + " " + client.IDNum);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string clientName = txtDeleteClient.Text;
                Client client = context.Clients.FirstOrDefault(r => r.Name == clientName);
                context.Clients.Remove(client);
                context.SaveChanges();
                Response.Write(clientName + " has been successfully removed");
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                var NAMES = context.Clients.Select(r => new { ClientX = r.Name + " " + r.Surname + "=>" });
                Response.BufferOutput = false;
                foreach (var client in NAMES)
                {
                    Response.Write(client.ClientX);
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string clientName = txtUpdateName.Text;
                string clientSurname = txtUpdateSurname.Text;
                Client client = context.Clients.FirstOrDefault(r => r.Name == clientName);
                if (client == null)
                {
                    Response.Write("Client does not exist.");
                }
                else
                {
                    client.Surname = clientSurname;
                    context.SaveChanges();
                    Response.Write("Client surname updated");
                }
            }


        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string name = txtFurnitureName.Text;
                int quantity = Convert.ToInt32(txtQuantity.Text);

                Furniture furniture = new Furniture
                {
                    F_Name = name,
                    Quantity = quantity
                };

                Furniture furnitureDB = context.Furnitures.FirstOrDefault(r => r.F_Name == furniture.F_Name);
                try
                {
                    context.Furnitures.Add(furniture);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
                Response.Write("Saved");
            }
        }
    }
}
