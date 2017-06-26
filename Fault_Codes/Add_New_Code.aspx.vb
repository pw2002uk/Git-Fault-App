Imports System.Data.SqlClient

Public Class Add_New_Code
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_update_ServerClick(sender As Object, e As EventArgs) Handles btn_update.ServerClick


        'Write the database for the main core details (eg Aircraft type and label)

        Dim conn1 As String = ConfigurationManager.ConnectionStrings("Connectionstring1").ConnectionString

        Dim connection1 As SqlConnection = New SqlConnection(conn1)

        Dim sql1 As String = "INSERT INTO [Main]([Aircraft_Type],[System_Name],[Label]) VALUES(@Aircraft_Type,@System_Name,@Label)"

        Dim cmd1 As SqlCommand = New SqlCommand(sql1, connection1)

        cmd1.Parameters.AddWithValue("@Aircraft_Type", DropDownList1.SelectedValue)
        cmd1.Parameters.AddWithValue("@System_Name", txt_System_Name.Value)
        cmd1.Parameters.AddWithValue("@Label", txt_Code.Value)


        connection1.Open()
        cmd1.ExecuteNonQuery()
        connection1.Close()

        'Run a linq to SQL query to find the master key (ID) that associates with the above record
        'This number will be used as the FK to associate the fault info

        Using db As New DonDataContext

            'Create a datasource with the above as the seach criteria (i,e the fault code selected by the thee DD boxes'

            Dim AJD = From Main In db.Mains
                      Select Main.ID
                      Order By ID Descending

            Dim ID_Only_GV As New GridView
            ID_Only_GV.DataSource = AJD
            ID_Only_GV.DataBind()

            Dim ID_Number As Integer = ID_Only_GV.Rows(0).Cells(0).Text

            'Run the update sub routine  - pass in the FK as found above
            Do_update(ID_Number)

        End Using

        ClientScript.RegisterClientScriptBlock(Me.[GetType](), "blah", "onINSERT();", True)

    End Sub

    'This sub adds all the data to the core record created above
    Sub Do_update(FK)

        Dim conn1 As String = ConfigurationManager.ConnectionStrings("Connectionstring1").ConnectionString

        Dim connection1 As SqlConnection = New SqlConnection(conn1)

        Dim sql1 As String = "INSERT INTO [Data_Bits] ([FK_ID],[Bit9_SDI],[Bit10_SDI],[Bit11_Data],[Bit12_Data],[Bit13_Data],[Bit14_Data],[Bit15_Data],[Bit16_Data],[Bit17_Data],[Bit18_Data],[Bit19_Data],[Bit20_Data],[Bit21_Data],[Bit22_Data],[Bit23_Data],[Bit24_Data],[Bit25_Data],[Bit26_Data],[Bit27_Data],[Bit28_Data],[Bit29_Data],[Bit30_SSM],[Bit31_SSM],[Bit32_Parity],[SDI_Option0],[SDI_Option1],[SDI_Option2],[SDI_Option3],[SSM_Option0],[SSM_Option1],[SSM_Option2],[SSM_Option3]) VALUES 
                             (@FK_ID,@Bit9_SDI,@Bit10_SDI,@Bit11_Data,@Bit12_Data,@Bit13_Data,@Bit14_Data,@Bit15_Data,@Bit16_Data,@Bit17_Data,@Bit18_Data,@Bit19_Data,@Bit20_Data,@Bit21_Data,@Bit22_Data,@Bit23_Data,@Bit24_Data,@Bit25_Data,@Bit26_Data,@Bit27_Data,@Bit28_Data,@Bit29_Data,@Bit30_SSM,@Bit31_SSM,@Bit32_Parity,@SDI_Option0,@SDI_Option1,@SDI_Option2,@SDI_Option3,@SSM_Option0,@SSM_Option1,@SSM_Option2,@SSM_Option3)"

        Dim cmd1 As SqlCommand = New SqlCommand(sql1, connection1)

        cmd1.Parameters.AddWithValue("@FK_ID", FK)
        cmd1.Parameters.AddWithValue("@Bit9_SDI", txt_Bit9.Value)
        cmd1.Parameters.AddWithValue("@Bit10_SDI", txt_Bit10.Value)
        cmd1.Parameters.AddWithValue("@Bit11_Data", txt_Bit11.Value)
        cmd1.Parameters.AddWithValue("@Bit12_Data", txt_Bit12.Value)
        cmd1.Parameters.AddWithValue("@Bit13_Data", txt_Bit13.Value)
        cmd1.Parameters.AddWithValue("@Bit14_Data", txt_Bit14.Value)
        cmd1.Parameters.AddWithValue("@Bit15_Data", txt_Bit15.Value)
        cmd1.Parameters.AddWithValue("@Bit16_Data", txt_Bit16.Value)
        cmd1.Parameters.AddWithValue("@Bit17_Data", txt_Bit17.Value)
        cmd1.Parameters.AddWithValue("@Bit18_Data", txt_Bit18.Value)
        cmd1.Parameters.AddWithValue("@Bit19_Data", txt_Bit19.Value)
        cmd1.Parameters.AddWithValue("@Bit20_Data", txt_Bit20.Value)
        cmd1.Parameters.AddWithValue("@Bit21_Data", txt_Bit21.Value)
        cmd1.Parameters.AddWithValue("@Bit22_Data", txt_Bit22.Value)
        cmd1.Parameters.AddWithValue("@Bit23_Data", txt_Bit23.Value)
        cmd1.Parameters.AddWithValue("@Bit24_Data", txt_Bit24.Value)
        cmd1.Parameters.AddWithValue("@Bit25_Data", txt_Bit25.Value)
        cmd1.Parameters.AddWithValue("@Bit26_Data", txt_Bit26.Value)
        cmd1.Parameters.AddWithValue("@Bit27_Data", txt_Bit27.Value)
        cmd1.Parameters.AddWithValue("@Bit28_Data", txt_Bit28.Value)
        cmd1.Parameters.AddWithValue("@Bit29_Data", txt_Bit28.Value)
        cmd1.Parameters.AddWithValue("@Bit30_SSM", txt_Bit30.Value)
        cmd1.Parameters.AddWithValue("@Bit31_SSM", txt_Bit31.Value)
        cmd1.Parameters.AddWithValue("@Bit32_Parity", txt_Bit32.Value)
        cmd1.Parameters.AddWithValue("@SDI_Option0", txt_SDI00.Value)
        cmd1.Parameters.AddWithValue("@SDI_Option1", txt_SDI01.Value)
        cmd1.Parameters.AddWithValue("@SDI_Option2", txt_SDI10.Value)
        cmd1.Parameters.AddWithValue("@SDI_Option3", txt_SDI11.Value)
        cmd1.Parameters.AddWithValue("@SSM_Option0", txt_SSM00.Value)
        cmd1.Parameters.AddWithValue("@SSM_Option1", txt_SSM01.Value)
        cmd1.Parameters.AddWithValue("@SSM_Option2", txt_SSM10.Value)
        cmd1.Parameters.AddWithValue("@SSM_Option3", txt_SSM11.Value)

        connection1.Open()
        cmd1.ExecuteNonQuery()
        connection1.Close()



    End Sub



End Class