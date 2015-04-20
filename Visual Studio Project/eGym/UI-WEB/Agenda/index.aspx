<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="calendar" class="fc fc-ltr fc-unthemed">
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
<link rel='stylesheet' href='fullcalendar/fullcalendar.css' />
<script src='js/local/calendar/moment.min.js'></script>

    <script src="../js/local/calendar/fullcalendar.js"></script>
    <script>
        $(document).ready(function () {

            // page is now ready, initialize the calendar...

            $('#calendar').fullCalendar({
                // put your options and callbacks here
            })

        });
    </script>
</asp:Content>
