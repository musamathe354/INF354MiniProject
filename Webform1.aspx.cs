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
                //Populating Title
                ClientTitle c = new ClientTitle();

                List<ClientTitle> type = context.ClientTitles.ToList();
               
                DropDownList1.DataSource = type;
                DropDownList1.DataTextField = "Title";
                DropDownList1.DataValueField = "CT_ID";
                if (!IsPostBack)//Gets the selected value if postback will not
                    DropDownList1.DataBind();
                //DropDownList1.DataBind();

                //Populating Furniture
                List<FurnitureType> typeFurniture = context.FurnitureTypes.ToList();
                DropDownList2.DataSource = typeFurniture;
                DropDownList2.DataTextField = "Furn_Type";
                DropDownList2.DataValueField = "FT_ID";
                if (!IsPostBack)//Gets the selected value if postback will not
+                    DropDownList1.DataBind();

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
               

                string t = DropDownList1.SelectedValue;
                /*ClientTitle title = context.ClientTitles.FirstOrDefault(r => r.Title == t);

                var myQuery = context.ClientTitles.Where(r => r.Title == t).Select(r => r.CT_ID);*/

                //Response.Write(t);

                //Adding
                Client client = new Client
                {
                    CT_ID = Convert.ToInt32(t),
                    Name = name,
                    Surname = surname,
                    IDNum = IDNo
                    //CT_ID = title.CT_ID
                };

                
                 Client clientDB = context.Clients.FirstOrDefault(r => r.Name == client.Name);
                 if (clientDB == null)
                 {
                    try
                    {
                        context.Clients.Add(client);
                        context.SaveChanges();
                        Response.Write("Client saved to database");//Shows that client is in system
                    }
                    catch(Exception ex)
                    {
                        Response.Write("Error encounted: "+ex);
                    }
                 }
                 else
                 {
                     Response.Write("Client exists already");
                 }

                /*  ClientTitle newClient = new ClientTitle
                  {
                      Title = "Miss"
                  };
                  context.ClientTitles.Add(newClient);*/


            }
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string clientName = txtClientSearch.Text;
                Client clientDB = context.Clients.FirstOrDefault(r => r.Name == clientName);
                if(clientDB == null)
                {
                    Response.Write("No such client in database");
                }
                else
                {
                    Response.Write("Client(s) Selected: " + clientDB.Name + " " + " " + clientDB.Surname + ", ID Number: " + clientDB.IDNum);
                }
               
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            using(furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                string clientName = txtDeleteClient.Text;
                Client clientDB = context.Clients.FirstOrDefault(r => r.Name == clientName);
                if (clientDB == null)
                {
                    Response.Write("No such client in database");
                }
                else
                {
                    context.Clients.Remove(clientDB);
                    context.SaveChanges();
                    Response.Write(clientName + " has been successfully removed");
                }
                
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            using (furnitureShopEntities1 context = new furnitureShopEntities1())
            {
                var NAMES = context.Clients.Select(r => new { ClientX = r.Name +" "+ r.Surname +", " });
                //Response.BufferOutput = false;
                if (NAMES == null)
                {
                    Response.Write("No clients in database");
                }
                else
                {
                    foreach (var client in NAMES)
                    {
                        Response.Write(client.ClientX); 
                    }
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
    }
}
