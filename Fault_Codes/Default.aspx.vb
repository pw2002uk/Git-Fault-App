Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Using db As New DonDataContext

                'Create a datasource with the above as the seach criteria (i,e the fault code selected by the thee DD boxes'

                Dim AJD = From Main In db.Mains, Data_Bit In db.Data_Bits
                          Where (Main.ID = Data_Bit.FK_ID) And Main.System_Name = "ADC-3000" And Main.Aircraft_Type = "Challenger 350" And Main.Label = "350"
                          Select Main.Aircraft_Type, Main.Label, Main.System_Name, Data_Bit.Bit9_SDI, Data_Bit.Bit10_SDI, Data_Bit.Bit11_Data, Data_Bit.Bit12_Data, Data_Bit.Bit13_Data,
                      Data_Bit.Bit14_Data, Data_Bit.Bit15_Data, Data_Bit.Bit16_Data, Data_Bit.Bit17_Data, Data_Bit.Bit18_Data, Data_Bit.Bit19_Data,
                      Data_Bit.Bit20_Data, Data_Bit.Bit21_Data, Data_Bit.Bit22_Data, Data_Bit.Bit23_Data, Data_Bit.Bit24_Data, Data_Bit.Bit25_Data, Data_Bit.Bit26_Data, Data_Bit.Bit27_Data,
                      Data_Bit.Bit28_Data, Data_Bit.Bit29_Data, Data_Bit.Bit30_SSM, Data_Bit.Bit31_SSM, Data_Bit.Bit32_Parity, Data_Bit.SDI_Option0, Data_Bit.SDI_Option2, Data_Bit.SDI_Option3, Data_Bit.SSM_Option0, Data_Bit.SSM_Option1, Data_Bit.SSM_Option2, Data_Bit.SSM_Option3


                'Place the result of the above search into a hidden GV that can be used
                'by the below to create a table on the screen

                Dim gv3 As New GridView
                gv3.DataSource = AJD
                gv3.DataBind()

                If gv3.Rows.Count > 0 Then

                    'Create the on screen table
                    Dim gv1 As New GridView
                    Dim PW_table As New DataTable

                    PW_table.Columns.Add("Bit", GetType(Integer))
                    PW_table.Columns.Add("BCD", GetType(Integer))
                    PW_table.Columns.Add("Description", GetType(String))
                    Dim BCD As Integer = 4

                    For n = 11 To 29

                        'Add data rows for each of the bits
                        PW_table.Rows.Add(n, BCD, gv3.Rows(0).Cells(n - 6).Text)

                        BCD = BCD * 2
                        If BCD > 8 Then
                            BCD = 1
                        End If

                    Next

                    'Add some styling to the on screen gridview
                    gv1.HeaderStyle.BackColor = System.Drawing.Color.LightGreen
                    gv1.HeaderStyle.Font.Bold = True
                    gv1.HeaderStyle.ForeColor = System.Drawing.Color.Black
                    gv1.CellPadding = 3
                    'gv1.Columns(1).HeaderStyle.HorizontalAlign = HorizontalAlign.Center
                    'gv1.Columns[1].ItemStyle.HorizontalAlign = HorizontalAlign.Center
                    gv1.RowStyle.BackColor = Drawing.Color.White
                    gv1.RowStyle.Font.Size = 10
                    gv1.HeaderStyle.Font.Size = 10

                    'Add the data from the above datatable to the on screen gridview
                    gv1.DataSource = PW_table
                    gv1.DataBind()

                    'Put the newly created table on the screen at this location
                    PlaceHolder1.Controls.Add(gv1)
                    PlaceHolder1.Controls.Add(New LiteralControl("<br />"))


                End If

            End Using



        End If


    End Sub



    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        'If the aircraft type changes, create a new gridview

        'Sets the hidden grid called DD1_Value = to DD list index so it can be saved
        DD1_Value.Value = DropDownList1.SelectedIndex

        'Run the sub routine to create the Green full list of fault codes (no Hex)
        create_gridview()

    End Sub


    Protected Sub DropDownList2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList2.SelectedIndexChanged
        'If the LRU changes, create a new gridview

        DD2_Value.Value = DropDownList2.SelectedIndex
        create_gridview()

    End Sub


    Protected Sub DropDownList3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList3.SelectedIndexChanged
        'If the label changes, create a new gridview
        DD3_Value.Value = DropDownList3.SelectedIndex
        create_gridview()
    End Sub


    Sub create_gridview()

        Using db As New DonDataContext

            'Create a datasource with the above as the seach criteria (i,e the fault code selected by the thee DD boxes'

            Dim AJD = From Main In db.Mains, Data_Bit In db.Data_Bits
                      Where (Main.ID = Data_Bit.FK_ID) And Main.System_Name = DropDownList2.SelectedValue And Main.Aircraft_Type = DropDownList1.SelectedValue And Main.Label = DropDownList3.SelectedValue
                      Select Main.Aircraft_Type, Main.Label, Main.System_Name, Data_Bit.Bit9_SDI, Data_Bit.Bit10_SDI, Data_Bit.Bit11_Data, Data_Bit.Bit12_Data, Data_Bit.Bit13_Data,
                  Data_Bit.Bit14_Data, Data_Bit.Bit15_Data, Data_Bit.Bit16_Data, Data_Bit.Bit17_Data, Data_Bit.Bit18_Data, Data_Bit.Bit19_Data,
                  Data_Bit.Bit20_Data, Data_Bit.Bit21_Data, Data_Bit.Bit22_Data, Data_Bit.Bit23_Data, Data_Bit.Bit24_Data, Data_Bit.Bit25_Data, Data_Bit.Bit26_Data, Data_Bit.Bit27_Data,
                  Data_Bit.Bit28_Data, Data_Bit.Bit29_Data, Data_Bit.Bit30_SSM, Data_Bit.Bit31_SSM, Data_Bit.Bit32_Parity, Data_Bit.SDI_Option0, Data_Bit.SDI_Option2, Data_Bit.SDI_Option3, Data_Bit.SSM_Option0, Data_Bit.SSM_Option1, Data_Bit.SSM_Option2, Data_Bit.SSM_Option3


            'Place the result of the above search into a hidden GV that can be used
            'by the below to create a table on the screen

            Dim gv3 As New GridView
            gv3.DataSource = AJD
            gv3.DataBind()



            If gv3.Rows.Count > 0 Then

                'Create the on screen table
                Dim gv1 As New GridView
                Dim PW_table As New DataTable

                PW_table.Columns.Add("Bit", GetType(Integer))
                PW_table.Columns.Add("BCD", GetType(Integer))
                PW_table.Columns.Add("Description", GetType(String))
                Dim BCD As Integer = 4

                For n = 11 To 29

                    'Add data rows for each of the bits
                    PW_table.Rows.Add(n, BCD, gv3.Rows(0).Cells(n - 6).Text)

                    BCD = BCD * 2
                    If BCD > 8 Then
                        BCD = 1
                    End If

                Next



                'Add some styling to the on screen gridview
                gv1.HeaderStyle.BackColor = System.Drawing.Color.LightGreen
                gv1.HeaderStyle.Font.Bold = True
                gv1.HeaderStyle.ForeColor = System.Drawing.Color.Black
                gv1.CellPadding = 3
                'gv1.Columns(1).HeaderStyle.HorizontalAlign = HorizontalAlign.Center
                'gv1.Columns(1).ItemStyle.HorizontalAlign = HorizontalAlign.Center
                gv1.RowStyle.BackColor = Drawing.Color.White
                gv1.RowStyle.Font.Size = 10
                gv1.HeaderStyle.Font.Size = 10

                'Add the data from the above datatable to the on screen gridview
                gv1.DataSource = PW_table
                gv1.DataBind()

                'Put the newly created table on the screen at this location
                PlaceHolder1.Controls.Add(gv1)
                PlaceHolder1.Controls.Add(New LiteralControl("<br />"))

            End If

        End Using

    End Sub

    Private Sub btn_update_ServerClick(sender As Object, e As EventArgs) Handles btn_update.ServerClick

        'if this is a valid hex code do this

        Dim Whole_Binary_Word As String

        Dim hexstring As String = TextBox1.Text
        Dim bin As New Text.StringBuilder
        For Each ch As Char In hexstring
            bin.Append(Convert.ToString(Convert.ToInt32(ch, 16), 2).PadLeft(4, "0"c))
        Next

        Whole_Binary_Word = bin.ToString

        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        Using db As New DonDataContext

            'Create a datasource with the above as the seach criteria (i,e the fault code selected by the thee DD boxes'

            Dim AJD = From Main In db.Mains, Data_Bit In db.Data_Bits
                      Where (Main.ID = Data_Bit.FK_ID) And Main.System_Name = DropDownList2.SelectedValue And Main.Aircraft_Type = DropDownList1.SelectedValue And Main.Label = DropDownList3.SelectedValue
                      Select Main.Aircraft_Type, Main.Label, Main.System_Name, Data_Bit.Bit9_SDI, Data_Bit.Bit10_SDI, Data_Bit.Bit11_Data, Data_Bit.Bit12_Data, Data_Bit.Bit13_Data,
                      Data_Bit.Bit14_Data, Data_Bit.Bit15_Data, Data_Bit.Bit16_Data, Data_Bit.Bit17_Data, Data_Bit.Bit18_Data, Data_Bit.Bit19_Data,
                      Data_Bit.Bit20_Data, Data_Bit.Bit21_Data, Data_Bit.Bit22_Data, Data_Bit.Bit23_Data, Data_Bit.Bit24_Data, Data_Bit.Bit25_Data, Data_Bit.Bit26_Data, Data_Bit.Bit27_Data,
                      Data_Bit.Bit28_Data, Data_Bit.Bit29_Data, Data_Bit.Bit30_SSM, Data_Bit.Bit31_SSM, Data_Bit.Bit32_Parity, Data_Bit.SDI_Option0, Data_Bit.SDI_Option1, Data_Bit.SDI_Option2, Data_Bit.SDI_Option3, Data_Bit.SSM_Option0, Data_Bit.SSM_Option1, Data_Bit.SSM_Option2, Data_Bit.SSM_Option3


            'Place the result of the above search into a hidden GV that can be used
            'by the below to create a table on the screen

            Dim gv3 As New GridView
            gv3.DataSource = AJD
            gv3.DataBind()

            If gv3.Rows.Count > 0 Then

                'Create the on screen table

                Dim gv1 As New GridView
                Dim gv2 As New GridView
                Dim SDI_Datatable As New DataTable
                Dim New_Datatable As New DataTable

                SDI_Datatable.Columns.Add("Bit", GetType(Integer))
                SDI_Datatable.Columns.Add("Hex Code", GetType(String))
                SDI_Datatable.Columns.Add("Description", GetType(String))

                New_Datatable.Columns.Add("Bit", GetType(Integer))
                New_Datatable.Columns.Add("Hex Code", GetType(String))
                New_Datatable.Columns.Add("Description", GetType(String))

                For n = 9 To 31

                    'Add data rows for each of the bits
                    SDI_Datatable.Rows.Add(n, Whole_Binary_Word(32 - n), gv3.Rows(0).Cells(n - 6).Text)
                    New_Datatable.Rows.Add(n, Whole_Binary_Word(32 - n), gv3.Rows(0).Cells(n - 6).Text)

                Next

                'Add some styling to the on screen gridview
                gv1.HeaderStyle.BackColor = System.Drawing.Color.LightGreen
                'gv2.HeaderStyle.BackColor = System.Drawing.Color.Red
                gv1.HeaderStyle.Font.Bold = True
                gv1.HeaderStyle.ForeColor = System.Drawing.Color.Black
                gv1.CellPadding = 3
                gv1.RowStyle.BackColor = Drawing.Color.White
                gv1.RowStyle.Font.Size = 10

                'gv1.Columns(1).ItemStyle.HorizontalAlign = HorizontalAlign.Center
                gv1.HeaderStyle.Font.Size = 10

                'Add the data from the above datatable to the on screen gridview
                gv1.DataSource = SDI_Datatable
                gv1.DataBind()

                gv2.DataSource = New_Datatable
                gv2.DataBind()

                'Put the newly created table on the screen at this location

                PlaceHolder1.Controls.Add(gv1)
                PlaceHolder1.Controls.Add(New LiteralControl("<br />"))

                '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                'Create the Blue table SDI
                Dim SDI_Result As String
                Dim finalgv As New GridView


                Dim bit9_SDI0 = gv2.Rows(0).Cells(1).Text
                Dim bit10_SDI1 = gv2.Rows(1).Cells(1).Text
                Dim SDI As Integer = bit10_SDI1 + bit9_SDI0

                Dim Final_Datatable As New DataTable
                'Final_Datatable.Columns.Add("Bit", GetType(Integer))
                'Final_Datatable.Columns.Add("Hex Code", GetType(String))
                Final_Datatable.Columns.Add("SDI information", GetType(String))

                'Add some styling to the on screen gridview
                finalgv.HeaderStyle.BackColor = System.Drawing.Color.LightBlue
                finalgv.HeaderStyle.Font.Bold = True
                finalgv.HeaderStyle.ForeColor = System.Drawing.Color.Black
                finalgv.CellPadding = 3
                finalgv.RowStyle.BackColor = Drawing.Color.White
                gv1.RowStyle.Font.Size = 10
                finalgv.HeaderStyle.Font.Size = 10

                finalgv.DataSource = Final_Datatable


                DataBind()
                PlaceHolder2.Controls.Add(finalgv)

                If SDI = 0 Then

                    SDI_Result = gv3.Rows(0).Cells(27).Text
                    Final_Datatable.Rows.Add(SDI_Result)

                ElseIf SDI = 1 Then

                    SDI_Result = gv3.Rows(0).Cells(28).Text
                    Final_Datatable.Rows.Add(SDI_Result)

                ElseIf SDI = 10 Then

                    SDI_Result = gv3.Rows(0).Cells(29).Text
                    Final_Datatable.Rows.Add(SDI_Result)

                ElseIf SDI = 11 Then

                    SDI_Result = gv3.Rows(0).Cells(30).Text
                    Final_Datatable.Rows.Add(SDI_Result)

                End If

                finalgv.DataSource = Final_Datatable
                DataBind()
                PlaceHolder2.Controls.Add(finalgv)
                PlaceHolder2.Controls.Add(New LiteralControl("<br />"))

                '++++++++++++++++++++++++++++++++++++++++++++++++++++++++

                'Load the SSM table (yellow)


                Dim SSM_Result As String
                Dim SSM_gridview As New GridView
                Dim SSM_Datatable As New DataTable


                Dim bit9_SSM0 = gv2.Rows(21).Cells(1).Text
                Dim bit10_SSM1 = gv2.Rows(22).Cells(1).Text
                Dim SSM As Integer = bit10_SSM1 + bit9_SSM0



                'SSM_Datatable.Columns.Add("Bit", GetType(Integer))
                'SSM_Datatable.Columns.Add("Hex Code", GetType(String))
                SSM_Datatable.Columns.Add("SSM information", GetType(String))

                'Add some styling to the on screen gridview

                SSM_gridview.HeaderStyle.Font.Bold = True
                SSM_gridview.HeaderStyle.ForeColor = System.Drawing.Color.Black
                SSM_gridview.CellPadding = 3
                SSM_gridview.RowStyle.BackColor = Drawing.Color.White
                SSM_gridview.RowStyle.Font.Size = 10
                SSM_gridview.HeaderStyle.Font.Size = 10
                SSM_gridview.HeaderStyle.BackColor = System.Drawing.Color.LightCoral

                SSM_gridview.DataSource = SSM_Datatable

                DataBind()
                PlaceHolder3.Controls.Add(SSM_gridview)

                'PlaceHolder3.Controls.Add(gv3)

                If SSM = 0 Then

                    SSM_Result = gv3.Rows(0).Cells(31).Text
                    SSM_Datatable.Rows.Add(SSM_Result)

                ElseIf SSM = 1 Then

                    SSM_Result = gv3.Rows(0).Cells(32).Text
                    SSM_Datatable.Rows.Add(SSM_Result)

                ElseIf SSM = 10 Then

                    SSM_Result = gv3.Rows(0).Cells(33).Text
                    SSM_Datatable.Rows.Add(SSM_Result)

                ElseIf SSM = 11 Then

                    SSM_Result = gv3.Rows(0).Cells(34).Text
                    SSM_Datatable.Rows.Add(SSM_Result)

                End If



                SSM_gridview.DataSource = SSM_Datatable
                DataBind()
                PlaceHolder3.Controls.Add(SSM_gridview)
                PlaceHolder3.Controls.Add(New LiteralControl("<br />"))


                'This removes any rows that are BIT 0 And leaves only the lines that are set to bit 1

                Dim rowcount As Integer = gv1.Rows.Count

                For n = 0 To rowcount - 1

                    If gv1.Rows(n).Cells(1).Text = 0 Then
                        gv1.Rows(n).Visible = False
                    End If

                    'Remove the SSM And SDI rows that may have been set to 1

                    If gv1.Rows(n).Cells(2).Text = "SDI Code" Then
                        gv1.Rows(n).Visible = False
                    End If

                    If gv1.Rows(n).Cells(2).Text = "SSM Code" Then
                        gv1.Rows(n).Visible = False
                    End If

                Next

            End If

        End Using

        'If the Drop downbox has been selected (changed) the index is stored in a hidden field called
        'DD1_Value. This value is used to retain the selection on posr back after the button is pressed
        'If it has never been opreated the index is -1, which is the top of the list. Works the same for 
        'all three drop down boxes

        If DD1_Value.Value = "" Then
            DD1_Value.Value = -1
        Else
            DropDownList1.SelectedIndex = DD1_Value.Value

        End If

        If DD2_Value.Value = "" Then
            DD2_Value.Value = -1

        Else
            DropDownList2.SelectedIndex = DD2_Value.Value
        End If

        If DD3_Value.Value = "" Then
            DD3_Value.Value = -1

        Else
            DropDownList3.SelectedIndex = DD3_Value.Value
        End If

    End Sub


End Class