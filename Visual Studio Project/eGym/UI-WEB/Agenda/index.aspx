<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="index.aspx.vb" Inherits="UI_WEB.index6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-md-12">
         <div class="card tabs-left style-default-light">
            <div class="col-md-10 col-md-offset-1">


                <div id="calendar" class="fc fc-ltr fc-unthemed">
            </div>
            <a class="btn btn-raised ink-reaction btn-default-bright" data-toggle="offcanvas" href="#offcanvas-demo-size3">Prueba</a>
            <div class="offcanvas"><div class="offcanvas-pane width-10" id="offcanvas-demo-size3" style="">
                    <div class="offcanvas-head">
                        <header>Nuevo evento</header>
                        <div class="offcanvas-tools">
                            <a data-dismiss="offcanvas" class="btn btn-icon-toggle btn-default-light pull-right">
                                <i class="md md-close"></i>
                            </a>
                        </div>
                    </div>

                    <div class="nano has-scrollbar" style="height: 339.083px;">
                        <div class="nano-content" tabindex="0" style="right: -17px;">
                            <div class="offcanvas-body">
                                <form role="form" class="form">
                            	<div class="form-group floating-label">
									<input type="text" id="txtTitulo" class="form-control">
									<label for="regular2">Titulo</label>
								</div>
                                <div class="form-group floating-label">
									<input type="text" id="txtAsunto" class="form-control">
									<label for="regular2">Asunto</label>
								</div>
                                <div class="form-group floating-label">
									<input type="text" id="txtHoraInicio" class="form-control">
									<label for="regular2">Hora inicio</label>
								</div>
                                <div class="form-group floating-label">
									<input type="text" id="txtHoraFinal" class="form-control">
									<label for="regular2">Hora final</label>
								</div>
                        <div class="card-actionbar">
                                <div data-toggle="tabs" class="card-actionbar-row">
                                    <button class="btn btn-flat btn-primary ink-reaction" onclick="alert('ALERTA');" type="button">Registrar</button>
                                </div>
                            </div>
							</form>
                            </div>
                        </div>
                        <div class="nano-pane" style="display: block;">
                            <div class="nano-slider" style="height: 249px; transform: translate(0px, 89.1509px);"></div>
                        </div>
                    </div>
                </div>
		</div>




            </div>
        </div>
     </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">




    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-ui/jquery-ui.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/select2/select2.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-tagsinput/bootstrap-tagsinput.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/multi-select/jquery.multi-select.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/inputmask/jquery.inputmask.bundle.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/moment/moment.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-datepicker/bootstrap-datepicker.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/typeahead/typeahead.bundle.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/dropzone/dropzone.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/calendar/fullcalendar.js")%>"></script>
    <link href="../css/calendar/fullcalendar.css" rel="stylesheet" />



    <script>
        $(document).ready(function () {
            $('#calendar').fullCalendar({
                height: 650,
                contentHeight: 465,
                aspectRatio: 3,
                theme: true,
                header: {
                    left: 'prev,next today',
                    center: 'title',
                    right: 'month,agendaWeek,agendaDay'
                },
                editable: true,
                disableDragging: true,
                firstDay: 1,
                weekends: true,
                defaultEventMinutes: 30,
                monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
                monthNameShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
                dayNames: ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'],
                dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab'],
                buttonText: {
                    today: 'hoy',
                    month: 'mes',
                    week: 'semana',
                    day: 'dia'

                },
                //dayClick: function (date, view) {
                //    $('#calendar').fullCalendar('changeView', 'agendaDay');
                //    $('#calendar').fullCalendar('gotoDate', date);

                //    var moment = $('#calendar').fullCalendar('getDate');
                //    alert("The current date of the calendar is " + moment.format());

                //    alert(date);
                //}, 
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
                },
            })

        });
    </script>
</asp:Content>
