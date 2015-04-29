$(document).ready(function () {
    var eventos = [];
    $('#calendar').fullCalendar({
        height: 700,
        header: false,
        editable: true,
        contentHeight: 520,
        defaultView: 'agendaWeek',
        editable: true,
        disableDragging: true,
        defaultEventMinutes: 30,
        monthNames: ['Enero', 'Febrero', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthNameShort: ['Ene', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Ago', 'Sep', 'Oct', 'Nov', 'Dic'],
        dayNames: ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'],
        dayNamesShort: ['Dom', 'Lun', 'Mar', 'Mie', 'Jue', 'Vie', 'Sab'],
        selectable: true,
        selectHelper: true,
        select: function (start, end, view) {
            var usuario = '116',
                tipo = '1',
                titulo = $('#txtTitulo').val(),
                descripcion = $('#txtAsunto').val(),
                fechaInicio = $('#txtHoraInicio').val(),
                fechaFinal = $('#txtHoraFinal').val()
            var widthPage = $(document).width();


            $('#offcanvas-demo-size3').modal({
                position: [10, widthPage - 400],
                opacity: 20,
                overlayClose: true,
                overlayCss: { backgroundColor: "#030303" }
            });

            $('#txtHoraInicio').val(start.format());
            $('#txtHoraFinal').val(end.format());

            $("#btnSubmit").click(function () {
                var eventData;

                usuario = '116',
                tipo = '1',
                titulo = $('#txtTitulo').val(),
                descripcion = $('#txtAsunto').val(),
                fechaInicio = $('#txtHoraInicio').val(),
                fechaFinal = $('#txtHoraFinal').val()

                var servicio2 = new ServicioEnClases.ServicioEventoCalendario();
                var datos = JSON.stringify({ USUARIO: usuario, TIPO: tipo, TITULO: titulo, DESCRIPCION: descripcion, FECHA_INICIAL: fechaInicio, FECHA_FINAL: fechaFinal });

                servicio2.insertarEventoCalendario(datos, onsucessInsertar, onFailInsetar, null);
            });
            function onsucessInsertar(result) {
                toastr.success('La cita ha sido registrada');
                eventData = {
                    title: titulo,
                    start: fechaInicio,
                    end: fechaFinal
                };

                $('#calendar').fullCalendar('renderEvent', eventData, true); // stick? = true

            };
            function onFailInsetar(result) {
                toastr.error('No se ha podido registrar la cita');
                $('#calendar').fullCalendar('unselect');
            };
        },
        editable: true,
        eventLimit: true, // allow "more" link when too many events
        events: eventos,
        editable: true,
        eventClick: function (calEvent, jsEvent, view) {
            var id = calEvent.id,
                titulo = calEvent.title,
                fechaInicio = calEvent.start,
                fechaFinal = calEvent.end,
                descripcion = calEvent.description

            var widthPage = $(document).width();

            $('#offcanvas-demo-size4').modal({
                position: [10, widthPage - 400],
                opacity: 20,
                overlayClose: true,
                overlayCss: { backgroundColor: "#030303" }
            });

            $('#txtIdM').val(id);
            $('#txtTituloM').val(titulo);
            $('#txtAsuntoM').val(descripcion);
            $('#txtHoraInicioM').val(fechaInicio.format());
            $('#txtHoraFinalM').val(fechaFinal.format());

            $("#btnSubmitM").click(function () {
                usuario = '116',
                tipo = '1',
                titulo = $('#txtTitulo').val(),
                descripcion = $('#txtAsunto').val(),
                fechaInicio = $('#txtHoraInicio').val(),
                fechaFinal = $('#txtHoraFinal').val()

                var servicio2 = new ServicioEnClases.ServicioEventoCalendario();
                var datos = JSON.stringify({ USUARIO: usuario, TIPO: tipo, TITULO: titulo, DESCRIPCION: descripcion, FECHA_INICIAL: fechaInicio, FECHA_FINAL: fechaFinal });

                servicio2.insertarEventoCalendario(datos, onsucessInsertar, onFailInsetar, null);
            });


        }
    });


    //Buttons events
    $('#calender-prev').on('click', function (e) {
        $('#calendar').fullCalendar('prev');
    });
    $('#calender-next').on('click', function (e) {
        $('#calendar').fullCalendar('next');
    });
    $('.nav-tabs li').on('show.bs.tab', function (e) {
        $('#calendar').fullCalendar('changeView', $(e.currentTarget).data('mode'));
    });

    var servicio1 = new ServicioEnClases.ServicioEventoCalendario();
    servicio1.getAllEventoCalendario(onsucess, onFail, null);

    function onsucess(result) {
        alert("on suceess");
        var object = $.parseJSON(result);

        $.each(object, function (i, item) {
            //alert(object[i].FechaInicial);
            object[i].FechaInicial = new Date(parseInt(object[i].FechaInicial.substr(6)));
            object[i].FechaFinal = new Date(parseInt(object[i].FechaFinal.substr(6)));

            eventos.push({ 'id': object[i].Id, 'title': object[i].Titulo, 'start': object[i].FechaInicial, 'end': object[i].FechaFinal, 'description': object[i].Descripcion });
        })

        $('#calendar').fullCalendar({
            events: eventos
        });
    };
    function onFail(result) {
        
    };

});