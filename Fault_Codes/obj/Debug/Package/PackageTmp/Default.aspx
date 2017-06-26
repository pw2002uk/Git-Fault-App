<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="Fault_Codes._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div >
        <h1>Fault code analysis</h1>
        <p class="lead">Rockwell Collins fault code reader by Peter Whitham.</p>
    </div>


    <div class="row">
        <div class="col-md-2">
            <h3>Aircraft</h3>
            <p>

                <%--    <asp:Label ID="Label1" runat="server" Text="Select the aircraft type"></asp:Label>--%>
                <%--           <br />--%>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Aircraft_Type" DataValueField="Aircraft_Type" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" SelectCommand="SELECT DISTINCT [Aircraft_Type] FROM [Main] ORDER BY [Aircraft_Type]"></asp:SqlDataSource>
            </p>
        </div>

        <div class="col-md-2">
            <h3>System ID</h3>
            <p>
                <%-- <asp:Label ID="Label2" runat="server" Text="Select the system ID"></asp:Label>--%>
                <%--      <br />--%>
                <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="System_Name" DataValueField="System_Name" AutoPostBack="True">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" SelectCommand="SELECT DISTINCT System_Name 
FROM Main 
ORDER BY System_Name"></asp:SqlDataSource>
            </p>
        </div>


        <div class="col-md-2">
            <h3>Label</h3>
            <p>
                <%-- <asp:Label ID="Label3" runat="server" Text="Select your label"></asp:Label>--%>
                <%--        <br /> --%>
                <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource3" DataTextField="Label" DataValueField="Label" AutoPostBack="True">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" SelectCommand="SELECT DISTINCT [Label] FROM [Main] ORDER BY [Label]"></asp:SqlDataSource>
            </p>

        </div>

        <div class="col-md-6">
            <h3>Hex Code</h3>
            <p>
                <%-- <asp:Label ID="Label3" runat="server" Text="Select your label"></asp:Label>--%>
                <%--        <br /> --%>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <button runat="server" id="btn_update" type="button" class="btn btn-success btn-sm">Enter</button>
            </p>

        </div>


        <%--   <div class="col-md-2">
            <h3></h3>
            <p>
                <asp:Label ID="Label3" runat="server" Text="Select your label"></asp:Label>
                <br />
            </p>
        </div>--%>



        <%--      Close out the row div--%>
    </div>



     <%-- This is the main BIT grid view section--%>

    <div class="row">
       
         <div class="col-md-4">

             <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
            <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
      <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
  
        </div>

            <div class="col-md-4">

            
  
        </div>

               <div class="col-md-4">

        
        </div>



        <%--      Close out the row div--%>
    </div>


    <asp:HiddenField ID="DD1_Value" runat="server" />
    <asp:HiddenField ID="DD2_Value" runat="server" />
    <asp:HiddenField ID="DD3_Value" runat="server" />

</asp:Content>
