<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="calendar" class="fc fc-ltr fc-unthemed">
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <link rel='stylesheet' href='fullcalendar/fullcalendar.css' />
    <script src='js/local/calendar/moment.min.js'></script>
    <script src="../js/local/calendar/jquery.min.js"></script>

    <script src="../js/local/calendar/fullcalendar.js"></script>
    <script>
        $(document).ready(function () {
            $('#calendar').fullCalendar({
                selectable: true,
                selectHelper: true,
                select: function (start, end) {
                    alert(start);
                    alert(end);
                    var title = prompt('Event Title:');
                    var eventData;
                    if (title) {
                        eventData = {
                            title: title,
                            start: start,
                            end: end
                        };
                        $('#calendar').fullCalendar('renderEvent', eventData, true); // stick? = true
                    }
                    $('#calendar').fullCalendar('unselect');
                }
            })

        });
    </script>
</asp:Content>
