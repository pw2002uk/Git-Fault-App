<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Fault_Codes.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                <asp:BoundField DataField="Aircraft_Type" HeaderText="Aircraft_Type" SortExpression="Aircraft_Type" />
                <asp:BoundField DataField="System_Name" HeaderText="System_Name" SortExpression="System_Name" />
                <asp:BoundField DataField="Label" HeaderText="Label" SortExpression="Label" />
                <asp:BoundField DataField="Hex_Fault_Code" HeaderText="Hex_Fault_Code" SortExpression="Hex_Fault_Code" />
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowInsertButton="True" />
            </Fields>
        </asp:DetailsView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" DeleteCommand="DELETE FROM [Main] WHERE [ID] = @original_ID AND (([Aircraft_Type] = @original_Aircraft_Type) OR ([Aircraft_Type] IS NULL AND @original_Aircraft_Type IS NULL)) AND (([System_Name] = @original_System_Name) OR ([System_Name] IS NULL AND @original_System_Name IS NULL)) AND (([Label] = @original_Label) OR ([Label] IS NULL AND @original_Label IS NULL)) AND (([Hex_Fault_Code] = @original_Hex_Fault_Code) OR ([Hex_Fault_Code] IS NULL AND @original_Hex_Fault_Code IS NULL))" InsertCommand="INSERT INTO [Main] ([Aircraft_Type], [System_Name], [Label], [Hex_Fault_Code]) VALUES (@Aircraft_Type, @System_Name, @Label, @Hex_Fault_Code)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Main]" UpdateCommand="UPDATE [Main] SET [Aircraft_Type] = @Aircraft_Type, [System_Name] = @System_Name, [Label] = @Label, [Hex_Fault_Code] = @Hex_Fault_Code WHERE [ID] = @original_ID AND (([Aircraft_Type] = @original_Aircraft_Type) OR ([Aircraft_Type] IS NULL AND @original_Aircraft_Type IS NULL)) AND (([System_Name] = @original_System_Name) OR ([System_Name] IS NULL AND @original_System_Name IS NULL)) AND (([Label] = @original_Label) OR ([Label] IS NULL AND @original_Label IS NULL)) AND (([Hex_Fault_Code] = @original_Hex_Fault_Code) OR ([Hex_Fault_Code] IS NULL AND @original_Hex_Fault_Code IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_ID" Type="Int32" />
                <asp:Parameter Name="original_Aircraft_Type" Type="String" />
                <asp:Parameter Name="original_System_Name" Type="String" />
                <asp:Parameter Name="original_Label" Type="String" />
                <asp:Parameter Name="original_Hex_Fault_Code" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="Aircraft_Type" Type="String" />
                <asp:Parameter Name="System_Name" Type="String" />
                <asp:Parameter Name="Label" Type="String" />
                <asp:Parameter Name="Hex_Fault_Code" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="Aircraft_Type" Type="String" />
                <asp:Parameter Name="System_Name" Type="String" />
                <asp:Parameter Name="Label" Type="String" />
                <asp:Parameter Name="Hex_Fault_Code" Type="String" />
                <asp:Parameter Name="original_ID" Type="Int32" />
                <asp:Parameter Name="original_Aircraft_Type" Type="String" />
                <asp:Parameter Name="original_System_Name" Type="String" />
                <asp:Parameter Name="original_Label" Type="String" />
                <asp:Parameter Name="original_Hex_Fault_Code" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
