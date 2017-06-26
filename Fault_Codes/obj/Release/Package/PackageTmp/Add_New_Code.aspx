<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Add_New_Code.aspx.vb" Inherits="Fault_Codes.Add_New_Code" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <link href="CSS/sweetalert.css" rel="stylesheet" />
<script src="Scripts/jquery-1.10.2.min.js"></script>
    <script src="Scripts/sweetalert.min.js"></script>


     <script type="text/javascript">

     function onINSERT() {

         swal("Success!", "Database Updated", "success")

         return false;
     }

 </script>


     <div id="wrapper">
            <div id="page-wrapper">
                <div class="row">
                    <div class="col-lg-6">
                        <br />
                        <!-- Note this is modified in CSS -->
                        <div id="alert_size_upscale" class="alert alert-info" role="alert">Use the code book to add a new table</div>
                    </div>
                    <!-- /.col-lg-12 -->
                </div>
                <!-- /.row pw -->

                <!-- /.row -->
                <div class="row">
                    <div class="col-lg-6">

                        <!-- /.panel -->
                        <div class="panel panel-default">
                            <div class="panel-heading">
                                <i class="fa fa-pencil fa-fw"></i>Create a new fault code
                                   <div class="pull-right">
                                       <div class="btn-group">
                                       </div>
                                   </div>                                

                            </div>


                            <!-- /.panel-heading -->
                            <div class="panel-body">
                           

                 <div class="form-horizontal">

                  <div class="form-group">
                 <label for="txt_type1" class="control-label col-sm-3">Aircraft Type</label>
                <asp:DropDownList ID="DropDownList1" runat="server" 
                    Width="120px">
                    <asp:ListItem>Challenger 300</asp:ListItem>
                    <asp:ListItem>Challenger 350</asp:ListItem>
                    <asp:ListItem>Challenger 605</asp:ListItem>
                    <asp:ListItem>Challenger 850</asp:ListItem>
                
                </asp:DropDownList>
                                            
              &nbsp;</div>
   
                                        <div class="form-group">
                                            <label for="txt_system_name" class="control-label col-sm-3">System Name</label>
                                            <input class="form-control" placeholder="i.e ADC-3000" runat="server" type="text" id="txt_System_Name" />
                                        </div>

                                        <div class="form-group">
                                            <label for="txt_code" class="control-label col-sm-3">Code</label>
                                            <input class="form-control" placeholder="i.e 350" runat="server" type="text" id="txt_Code" />                                           

                                        </div>

                                        <div class="form-group">
                                            <label for="txt_bit9" class="control-label col-sm-3">Bit 9 SDI Label</label>
                                            <input class="form-control" placeholder="Normally SDI." runat="server" type="text" id="txt_Bit9" />
                                        </div>
             

                                        <div class="form-group">
                                            <label for="txt_bit10" class="control-label col-sm-3">Bit 10 SDI Label</label>
                                            <input class="form-control " placeholder="Normally SDI" runat="server" type="text" id="txt_Bit10" />
                                        </div>


                                        <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 11 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit11" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 12 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit12" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 13 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit13" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 14 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit14" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 15 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit15" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 16 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit16" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 17 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit17" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 18 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit18" />
                                            
                                        </div>

                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 19 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit19" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 20 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit20" />
                                            
                                        </div>
                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 21 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit21" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 22 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit22" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 23 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit23" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 24 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit24" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 25 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit25" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 26 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit26" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 27 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit27" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 28 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit28" />
                                            
                                        </div>

                                        
                                           <div class="form-group">
                                            <label for="txt_crew" class="control-label col-sm-3">Bit 29 Data</label>
                                            <input class="form-control " placeholder="Fault information from code book" runat="server" type="text" id="txt_Bit29" />
                                            
                                        </div>

                                        <div class="form-group">
                                            <label for="txt_saudi" class="control-label col-sm-3">Bit 30 SSM</label>
                                            <input class="form-control " placeholder="Normally SSM" runat="server" type="text" id="txt_Bit30"/>
                                        </div>

                                                                                <div class="form-group">
                                            <label for="txt_saudi" class="control-label col-sm-3">Bit 31 SSM</label>
                                            <input class="form-control " placeholder="Normally SSM" runat="server" type="text" id="txt_Bit31" />
                                        </div>

                                                                                   <div class="form-group">
                                            <label for="txt_saudi" class="control-label col-sm-3">Bit 32 Parity</label>
                                            <input class="form-control " placeholder="Normally Parity" runat="server" type="text" id="txt_Bit32" />
                                        </div>


                                        <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SDI Bin 00 </label>
                                            <input class="form-control " placeholder="Code for SDI binary 00" runat="server" type="text" id="txt_SDI00" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SDI Bin 01 </label>
                                            <input class="form-control " placeholder="Code for SDI binary 01" runat="server" type="text" id="txt_SDI01" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SDI Bin 10 </label>
                                            <input class="form-control " placeholder="Code for SDI binary 10" runat="server" type="text" id="txt_SDI10" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SDI Bin 11 </label>
                                            <input class="form-control " placeholder="Code for SDI binary 11" runat="server" type="text" id="txt_SDI11" />
                                        </div>


                                         <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SSM Bin 00 </label>
                                            <input class="form-control " placeholder="Code for SSM binary 00" runat="server" type="text" id="txt_SSM00" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SSM Bin 01 </label>
                                            <input class="form-control " placeholder="Code for SSM binary 01" runat="server" type="text" id="txt_SSM01" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SSM Bin 10 </label>
                                            <input class="form-control " placeholder="Code for SSM binary 10" runat="server" type="text" id="txt_SSM10" />
                                        </div>

                                          <div class="form-group">
                                            <label for="txt_saudi_rem" class="control-label col-sm-3">SSM Bin 11 </label>
                                            <input class="form-control " placeholder="Code for SSM binary 11" runat="server" type="text" id="txt_SSM11" />
                                        </div>



                            <div class="form-group">
                                            <label for="instruction" class="control-label col-sm-4" style="height: 20px">Click to create</label>
                                            <div class="btn-group" role="group" aria-label="...">
                                                <button runat="server" id="btn_update" type="button" class="btn btn-success btn-lg">Create</button>
                                                
                                                                                  
                                            </div>
                                        </div>

                                                          

                                     



                                    </div>
                                    <!-- /form horizontal -->



                              

                            </div>
                            <!-- /.panel-body -->


                        </div>
                        <!-- /.panel-heading -->
                        <div class="panel-body">
                            <div class="row">
                                <!-- /.col-lg-4 (nested) -->
                                <div class="col-lg-12">
                                    <div id="morris-bar-chart">
                                        <!-- Nothing here PW -->
                                        

                                    </div>
                                </div>
                                <!-- /.col-lg-8 (nested) -->
    

                                
                                <br />
                            </div>
                            <!-- /.row -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!-- /.panel -->

                    <!-- /.col-lg-8 -->

                    <!-- /.col-lg-4 -->
                </div>
                <!-- /.row -->
            </div>
            <!-- /#page-wrapper -->

        </div>
        <!-- /#wrapper -->




</asp:Content>

