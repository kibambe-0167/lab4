<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="kibambe_ak_220072233_labexe3.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
      .img {
        vertical-align: middle;
      }
      .header {
        font-size: 40px;
        font-weight: bolder;
      }
      .label {
        font-size: 25px;
        font-weight: 600;
        margin-right: 5px
      }
      .input_ {
        padding: 5px;
      }
      .button_ {
        // padding: 5px;
        margin-left: 10px;
        font-weight: 500;
        font-size: 20px;

      }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      <div style="align-items:center" >
        <asp:Image class="img" ImageUrl="https://www.uj.ac.za/wp-content/uploads/2021/09/university-of-johannesburg-logo.png" ID="Image1" runat="server" Height="157px" Width="236px" />
        <asp:Label CssClass="header" ID="Label6" runat="server" Text="UJ Staff Portal"></asp:Label>
        <br />
        <br />
        <br />
      </div>

      <table >

        <tr>
          <td>
            <asp:Label class="label" ID="Label1" runat="server" Text="Id Number"></asp:Label>
          </td>

          <td >
            <asp:TextBox class="input_" ID="idNo" runat="server"></asp:TextBox>
          </td>

          <td >
            <asp:Button class="button_" ID="CreateStaff" runat="server" Text="Create" OnClick="CreateStaff_Click" />
          </td>
        </tr>



        <tr>
          <td>
            <asp:Label class="label" ID="Label2" runat="server" Text="Firstname"></asp:Label>
          </td>

          <td >
            <asp:TextBox class="input_" ID="firstname" runat="server"></asp:TextBox>
          </td>

          <td >
            <asp:Button class="button_" ID="SaveStaff" runat="server" Text="Save" OnClick="SaveStaff_Click" />
          </td>
        </tr>



      <tr>
          <td>
            <asp:Label class="label" ID="Label3" runat="server" Text="Lastname"></asp:Label>
          </td>

          <td >
            <asp:TextBox class="input_" ID="lastname" runat="server"></asp:TextBox>
          </td>

          <td >
            <asp:Button class="button_" ID="ReadStaff" runat="server" Text="Read" Height="24px" OnClick="ReadStaff_Click" />
          </td>
        </tr>


      <tr>
          <td>
            <asp:Label class="label" ID="Label4" runat="server" Text="Email"></asp:Label>
          </td>

          <td >
            <asp:TextBox class="input_" ID="email" runat="server" Enabled="False"></asp:TextBox>
          </td>

          <td >
            <asp:Button style="background-color: yellow" class="button_" ID="ClearStaffs" runat="server" Text="Clear" OnClick="ClearStaffs_Click" />
          </td>
        </tr>


      <tr>
          <td>
            <asp:Label class="label" ID="Label5" runat="server" Text="Age"></asp:Label>
          </td>

          <td >
            <asp:TextBox class="input_" ID="age" runat="server" Enabled="False"></asp:TextBox>
          </td>

          <td >
            <asp:Button style="background-color: red" class="button_" ID="ExitPortal" runat="server" Text="Exit" OnClick="ExitPortal_Click" />
          </td>
        </tr>
        
        </table>

      <br />
        <br />


      <div >
        <asp:GridView ID="ujstaffs" runat="server" Width="408px"></asp:GridView>
      </div>


    </form>
</body>
</html>
