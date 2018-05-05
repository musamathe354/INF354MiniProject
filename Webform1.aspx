<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MiniProject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Create</h1>
        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <asp:Label ID="Label3" runat="server" Text="TItle "></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList><br />
                <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label><asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label9" runat="server" Text="Surname: "></asp:Label><asp:TextBox ID="txtSurname" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label10" runat="server" Text="ID number: "></asp:Label><asp:TextBox ID="txtIDNumber" runat="server"></asp:TextBox><br />
                <asp:Button ID="Button1" runat="server" Text="Create" OnClick="Button1_Click" />
            </div>
            <!-- Next div -->
                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                    <h1>Update</h1>
                    <asp:Label ID="Label11" runat="server" Text="Name"></asp:Label> <asp:TextBox ID="txtUpdateName" runat="server"></asp:TextBox>
                    <asp:Label ID="Label5" runat="server" Text="Surname"></asp:Label><asp:TextBox ID="txtUpdateSurname" runat="server"></asp:TextBox>
                    <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" />
                 </div>
            <!--Close div -->

            <!-- Next div -->
           <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <h1>Delete</h1>
                <asp:Label ID="Label7" runat="server" Text="Enter client name:"></asp:Label><asp:TextBox ID="txtDeleteClient" runat="server"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" />
            </div>
            <!-- Close div -->

            <!-- Next div -->
                <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                    <h1>Search</h1>
                    <asp:Label ID="Label8" runat="server" Text="Client Name:"></asp:Label><asp:TextBox ID="txtClientSearch" runat="server"></asp:TextBox>
                    <asp:Button ID="Button4" runat="server" Text="Search" OnClick="Button4_Click" />
                    <asp:Button ID="Button5" runat="server" Text="View all clients" OnClick="Button5_Click" />
                </div>

            <!-- Close div -->
            </div>
        </div>

        <hr  />
         <hr  />
         <hr  />
        <div class="row">
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <h1>Create furniture</h1>
                <!-- Div 1 -->
                <asp:Label ID="Label12" runat="server" Text="Name: "></asp:Label><asp:TextBox ID="txtFurnitureName" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label13" runat="server" Text="Quantity:"></asp:Label><asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label2" runat="server" Text="Type:"></asp:Label><asp:DropDownList ID="DropDownList2" runat="server">
                    </asp:DropDownList> <br />
                <asp:Button ID="Button6" runat="server" Text="Create furniture" OnClick="Button6_Click" />
            </div>
            <!-- Close -->

            <!-- Div 2 -->
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <h1>Update furniture</h1>
                <asp:Label ID="Label4" runat="server" Text="Name:"></asp:Label><asp:TextBox ID="txtUpdateFurnitureName" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label6" runat="server" Text="Quantity:"></asp:Label> <asp:TextBox ID="txtUpdateQuantity" runat="server"></asp:TextBox><br />
                <asp:Button ID="Button7" runat="server" Text="Update furniture" />
            </div>
             <!-- Close -->

            <!-- Div 3 -->
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <h1>Delete furniture</h1>
                <asp:Label ID="Label14" runat="server" Text="Enter furniture name:"></asp:Label><asp:TextBox ID="txtDeleteFurnitureName" runat="server"></asp:TextBox>
                <asp:Button ID="Button8" runat="server" Text="Delete" />
            </div>
            <!-- Close -->
            
            <!-- Div 4 -->
            <div class="col-lg-3 col-md-3 col-sm-3 col-xs-3">
                <h1>Search furniture</h1>
                <asp:Label ID="Label15" runat="server" Text="Furniture Name"></asp:Label><asp:TextBox ID="txtSearchName" runat="server"></asp:TextBox>
                <asp:Button ID="Button9" runat="server" Text="Search" />
                <asp:Button ID="Button10" runat="server" Text="View all furniture" />
            </div>>
            <!-- Close -->
        </div>

       
        

    
    </form>
</body>
</html>
