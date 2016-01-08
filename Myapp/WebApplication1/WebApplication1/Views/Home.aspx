<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Views.Home" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Home|Online Claim Assisstant</title>
    <link rel="stylesheet" href="../css/metro.css">
    <script src="../js/jquery.js"></script>
    <script src="../js/metro.js"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.4.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="../css/Style.css">
    <link rel="stylesheet" href="../css/metro-icons.css">
    <style>
        .tile-area-controls {
            position: fixed;
            right: 40px;
            top: 40px;
        }

        @media screen and (max-width: 640px) {
            .tile-area {
                overflow-y: scroll;
            }

            .tile-area-controls {
                display: none;
            }
        }

        @media screen and (max-width: 320px) {
            .tile-area {
                overflow-y: scroll;
            }

            .tile-area-controls {
                display: none;
            }
        }
    </style>
</head>

<body>

    <div class="tile-area tile-area-scheme-dark fg-white" style="height: 100%; max-height: 100% !important;">

        <h2 class="tile-area-title">Online Claim Assisant&nbsp;<i class="fa fa-cog fa-spin"></i></h2>
        <form class="tile-area-controls" runat="server">
            <button class="image-button icon-right bg-transparent fg-white bg-hover-dark no-border"><span class="sub-header no-margin text-light"><%:Session["EmpName"]%></span> <span class="icon mif-user"></span></button>
            <button runat="server" id="btnLogout" onserverclick="btnLogout_ServerClick" class="square-button bg-transparent fg-white bg-hover-dark no-border"><span class="mif-switch"></span></button>
        </form>

        <div class="tile-group double">
            <span class="tile-group-title">General</span>
            <div class="tile-container">

                <a href="#" class="tile-wide bg-darkBlue fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-folder-plus"></span>
                    </div>
                    <span class="tile-label">New Policy</span>
                </a>
                <a href="Claims.aspx" class="tile bg-Blue fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-file-text"></span>
                    </div>
                    <span class="tile-label">Claims</span>
                </a>
                <a href="ClaimRequests.aspx" class="tile bg-red fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-perm-phone-msg"></span>
                    </div>
                    <span class="tile-label">Claim Requests</span>
                </a>
            </div>
        </div>

        <div class="tile-group double">
            <span class="tile-group-title">Office</span>
            <div class="tile-container">
                <a href="Vehicle.aspx" class="tile-square bg-emerald fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-automobile"></span>
                    </div>
                    <span class="tile-label">Vehicles</span>
                </a>
                <a href="VehicleType.aspx" class="tile-square bg-lime fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-list2"></span>
                    </div>
                    <span class="tile-label">Vehicle Types</span>
                </a>
                <a href="Garages.aspx" class="tile-square bg-teal fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-wrench"></span>
                    </div>
                    <span class="tile-label">Garages</span>
                </a>
                <a href="TowTruckService.aspx" class="tile-square bg-amber fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-towtruck"></span>
                    </div>
                    <span class="tile-label">Tow Trucks</span>
                </a>
                <a href="Sparepart.aspx" class="tile-square bg-olive fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-cog"></span>
                    </div>
                    <span class="tile-label">Spareparts</span>
                </a>
                <a href="Manufacturer.aspx" class="tile-small bg-pink fg-white" data-role="tile" title="Manufacturers">
                    <div class="tile-content iconic">
                        <span title="Manufacturers" class="icon mif-trademark"></span>
                    </div>
                    <%--<span class="tile-label">Manufacturers</span>--%>
                </a>
                <a href="SparepartCatergory.aspx" class="tile-small bg-steel fg-white" data-role="tile" title="Sparepart Categories">
                    <div class="tile-content iconic">
                        <span title="Sparepart Categories" class="icon mif-cabinet"></span>
                    </div>
                    <%--<span class="tile-label">Sparepart Categories</span>--%>
                </a>
            </div>
        </div>

        <div class="tile-group double">
            <span class="tile-group-title">Administration</span>
            <div class="tile-container">
                <a href="Employee.aspx" class="tile bg-darkViolet fg-white" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-users"></span>
                    </div>
                    <span class="tile-label">Employees</span>
                </a>
                <div class="tile bg-darkOrange fg-white" runat="server" id="tileUserAccount" data-role="tile">
                    <div class="tile-content iconic">
                        <span class="icon mif-key"></span>
                    </div>
                    <span class="tile-label">User Accounts</span>
                </div>
            </div>
        </div>
    </div>
</body>

</html>
