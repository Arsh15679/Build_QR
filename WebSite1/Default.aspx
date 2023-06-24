<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .btn {
            width: 300px;
        }

        .modal-footer {
            border-top: 0 none;
        }
    </style>

    <!-- Button trigger modal -->
    <button type="button" class="btn btn-primary" data-toggle="modal" data-backdrop="static" data-keyboard="false" data-target="#exampleModal" aria-hidden="true" style="display: none;" id="btnModal">
        Launch demo modal
    </button>


    <!-- Modal -->
    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel"><b>Print Preview</b></h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close" runat="server" onserverclick="Unnamed_ServerClick">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body" style="border: none;">
                    <div class="col-md-12">
                        <div class="col-md-3">
                            <label for="exampleInputEmail1">FSN : </label>
                        </div>
                        <div class="col-md-9">
                            <label for="exampleInputEmail1" runat="server" id="lblFsn">FSN</label>
                        </div>
                    </div>

                    <div class="col-md-12">
                        <br />
                        <div class="col-md-3">
                            <label for="exampleInputEmail1">Part Number :</label>
                        </div>
                        <div class="col-md-9">
                            <label for="exampleInputEmail1" runat="server" id="lblKpart">FSN</label>
                        </div>
                    </div>


                    <div class="col-md-12">
                        <br />
                        <div class="col-md-3">
                            <label for="exampleInputEmail1">Description :</label>
                        </div>
                        <div class="col-md-9">
                            <label for="exampleInputEmail1" runat="server" id="lbldesc">FSN</label>
                        </div>
                    </div>

                    <div class="col-md-12">
                        <br />
                        <div class="col-md-3">
                            <label for="exampleInputEmail1">Line :</label>
                        </div>
                        <div class="col-md-9">
                            <label for="exampleInputEmail1" runat="server" id="lblLine">FSN</label>
                        </div>
                    </div>


                </div>
                <br />
                <div class="modal-footer">

                    <%-- <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>--%>
                    <button type="button" class="btn btn-primary" style="margin-top: 50px; margin-right: 140px;" runat="server" id="printBtn" onserverclick="printBtn_ServerClick"><b>PRINT</b></button>

                </div>
            </div>
        </div>
    </div>


    <%--Main Design --%>
    <div class="jumbotron" align="center">
        <div class="panel panel-primary" style="width: 600px;">
            <div class="panel-heading"><b>MSGI</b></div>
            <div class="panel-body" align="center">
                <div class="form-group">
                    <label for="exampleInputEmail1">K- Part Number</label>
                    <input type="text" class="form-control" id="KpartNumber" autocomplete="off" placeholder="Enter Part Number" runat="server">
                </div>
                <div class="form-group">
                    <label for="exampleInputPassword1">Description</label>
                    <textarea type="text" class="form-control" id="description" placeholder="Description" runat="server"></textarea>
                </div>
                <div class="form-check">
                    <input type="checkbox" class="form-check-input" id="chk_hdt" runat="server" name="h" onclick="MutExChkList(this);">
                    <%--    <label class="form-check-label" for="exampleCheck1">HDT</label>--%>
                    <asp:Label class="form-check-label" Text="HDT" ID="hdt" runat="server" Font-Bold="true"></asp:Label>
                    <input type="checkbox" class="form-check-input" id="chk_mdt" onclick="MutExChkList(this);" runat="server" style="margin-left: 50px;">
                    <asp:Label class="form-check-label" Text="MDT" ID="mdt" runat="server" Font-Bold="true"></asp:Label>

                    <script type="text/javascript">
                        function MutExChkList(chk) {
                            var chkList = chk.parentNode.parentNode.parentNode;
                            var chks = chkList.getElementsByTagName("input");
                            for (var i = 0; i < chks.length; i++) {
                                if (chks[i] != chk && chk.checked) {
                                    chks[i].checked = false;
                                }
                            }
                        }
                    </script>
                </div>
                <div>
                    <br />
                    <asp:Button ID="btn" Text="PREVIEW" Font-Bold="true" CssClass="btn btn-primary" runat="server" data-toggle="modal" data-target="#exampleModal" OnClick="btn_Click" />
                </div>
            </div>
        </div>
    </div>


    <%--function for only one check at a time--%>
    <script type="text/javascript">
        function UnCheckOtherCheckBox(chkbox1, chkbox2) {
            if (chkbox1.checked) {
                //Uncheck the other checkbox
                document.getElementById(chkbox2).checked = false;
            }
        }
    </script>
</asp:Content>
