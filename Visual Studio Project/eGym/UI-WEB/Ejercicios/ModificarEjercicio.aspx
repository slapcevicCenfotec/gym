<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="ModificarEjercicio.aspx.vb" Inherits="UI_WEB.ModificarEjercicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="section-body">
        <div class="section-header">
            <h2 class="text-primary">Modificar ejercicio</h2>
        </div>
    </div>
    <div class="section-body">
        <div class="row">
            <div class="col-md-8">
                <article class="margin-bottom-xxl">
                    <p class="lead"></p>
                </article>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <%--id="frmInsertarEjercicio" method="post" runat="server"--%>
                <div class="form-horizontal">
                    <div class="col-sm-6">
                        <fieldset>
                            <legend></legend>
                            <div class="form-group">
                                <label for="name" class="col-sm-2 control-label">Nombre:</label>
                                <div class="col-sm-7">
                                    <input type="text" name="name" id="txtnombreEjercicio" class="form-control" placeholder="Nombre?">
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="alias" class="col-sm-2 control-label">Alias:</label>
                                <div class="col-sm-7">
                                    <input type="text" name="alias" id="alias" class="form-control" placeholder="Alias?">
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="descripcion" class="col-sm-2 control-label">Descripción:</label>
                                <div class="col-sm-7">
                                    <textarea name="descripcion" id="descripcion" class="form-control" rows="3"></textarea>
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="erroresComunes" class="col-sm-2 control-label">Errores comunes:</label>
                                <div class="col-sm-7">
                                    <input type="text" name="erroresComunes" id="erroresComunes" class="form-control" placeholder="Errores comunes?">
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="posicionInicial" class="col-sm-2 control-label">Posición inicial:</label>
                                <div class="col-sm-7">
                                    <input type="text" name="txtPosInicial" id="txtPosInicial" class="form-control" placeholder="Posición Inicial?">
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>

                            <div class="form-group">
                                <label for="txtPosFinal" class="col-sm-2 control-label">Posición final:</label>
                                <div class="col-sm-7">
                                    <input type="text" name="txtPosFinal" id="txtPosFinal" class="form-control" placeholder="Posición Final?">
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>

                            <div class="form-group">
                                <div class="col-sm-offset-2 col-sm-10">
                                    <input type="submit" id="btnAgregarEjercicio" class="btn btn-primary" value="Guardar" />
                                </div>
                            </div>
                        </fieldset>
                    </div>
                    <div class="col-sm-6">
                        <fieldset>
                            <legend></legend>
                            <div class="form-group">
                                <label for="musculo-principal" class="col-sm-3 control-label">Musculo principal:</label>
                                <div class="col-sm-6">
                                    <select id="musculo-principal" name="musculo-principal" class="col-sm-10 form-control">
                                    </select>
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>
                            <div class="form-group">
                                <div class="col-sm-offset-1">
                                    <label for="musculo-secundario" class="control-label">Musculo secundarios:</label>
                                </div>
                            </div>
                            <div class="form-group">

                                <label class="col-sm-3 control-label"></label>
                                <div class="col-sm-9 checkbox">
                                    <ul class="list" id="listaMusculosSecundarios" data-sortable="true">
                                    </ul>
                                </div>

                            </div>
                        </fieldset>
                        <fieldset>
                            <legend></legend>

                            <div class="form-group">
                                <label for="posicionInicialImg" class="col-sm-3 control-label">Posición inicial imagen:</label>
                                <div class="col-sm-6">
                                    <input type="file" id="fotoFile" accept='image/*' />
                                    <img id="myImagen" />
                                    <canvas id="myCanvas" />
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="posicionInicialImg" class="col-sm-3 control-label">Posición final imagen:</label>
                                <div class="col-sm-6">
                                    <input type="file" id="fotoFile2" accept='image/*' />
                                    <img id="myImagen2" />
                                    <canvas id="myCanvas2" />
                                </div>
                                <div class="col-sm-3">
                                </div>
                            </div>
                        </fieldset>
                    </div>
                    <form action="/" runat="server" method="post">
                        <asp:ScriptManager runat="server">
                            <Services>
                                <asp:ServiceReference Path="http://localhost:85/eGym/ServicioEjercicio.svc" />
                            </Services>
                            <Services>
                                <asp:ServiceReference Path=" http://localhost:85/eGym/ServicioProyecto.svc" />
                            </Services>
                        </asp:ScriptManager>
                    </form>
                </div>

            </div>

        </div>
    </div>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.js"></script>
    <script src="http://malsup.github.com/jquery.form.js"></script>
    <script src="../Scripts/jquery.validate.min.js"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/ejercicios.js")%>"></script>

    <script>
        $('form').validate({
            rules: {
                name: {
                    required: true
                },
                alias: {
                    required: true
                },
                descripcion: {
                    required: true
                },
                erroresComunes: {
                    required: true
                },
                txtPosInicial: {
                    required: true
                },
                txtPosFinal: {
                    required: true
                },
                Musculo: {
                    required: true
                }
            },
            messages: {
                name: {
                    required: "Campo es requerido"
                },
                alias: {
                    required: "Campo es requerido"
                },
                descripcion: {
                    required: "Campo es requerido"
                },
                erroresComunes: {
                    required: "Campo es requerido"
                },
                txtPosInicial: {
                    required: "Campo es requerido"
                },
                txtPosFinal: {
                    required: "Campo es requerido"
                },
                Musculo: {
                    required: "Debe selecionar a menos un musculo"
                }
            },
            submitHandler: function (form) {
                alert('ajax get called');
            },
            highlight: function (element, errorClass) {
                $(element).closest('.form-group').addClass('has-error');
            },
            unhighlight: function (element, errorClass) {
                $(element).closest('.form-group').removeClass('has-error');
            },

            errorPlacement: function (error, element) {

                if (element.attr('type') == 'checkbox') {
                    element.closest('.form-group').children(0).prepend(error)
                }
                else
                    error.insertAfter(element);

                error.appendTo(element.parent().next());
            }
        });
        //$(':input').change(function(){
        //    $(this).css('border', '3px solid red');
        //});

        $(document).ready(function () {
            buscarMusculos();
            //alert($('form').serialize());
            //$(':text').val('foo');

            var idMaquina = getQueryVariable('id');

            var service1 = new ServicioEjercicio();
            var datos = JSON.stringify({ pid: idMaquina });
            service1.obtenerEjercicioByID(datos, onSuccess, errorMessage, null, null);

        });

        function onSuccess(result) {
            var objeto = $.parseJSON(result);
            $('#txtnombreEjercicio').val(objeto.Nombre);
            $('#alias').val(objeto.Alias);
            $('#descripcion').val(objeto.Descripcion);
            $('#erroresComunes').val(objeto.ErroresComunes);
            $('#txtPosInicial').val(objeto.PosicionInicial);
            $('#txtPosFinal').val(objeto.PosicionFinal);


        }
        function getQueryVariable(variable) {
            var query = window.location.search.substring(1);
            var vars = query.split('&');
            for (var i = 0; i < vars.length; i++) {
                var pair = vars[i].split('=');
                if (pair[0] == variable) { return pair[1]; }
            }
            return (false);
        }
    </script>

</asp:Content>
