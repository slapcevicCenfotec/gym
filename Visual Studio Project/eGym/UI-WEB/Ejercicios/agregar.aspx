<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="agregar.aspx.vb" Inherits="UI_WEB.InsertarEjercicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../Content/bootstrap.min.css" rel="stylesheet" />

    <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />
    <script src="../Scripts/jquery-1.9.1.min.js"></script>
    <script src="../Scripts/bootstrap.min.js"></script>
    <link href="../css/theme-1/libs/toastr/toastr.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">   
     <div class="section-body contain-lg">
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Nuevo ejercicio</h1>
            </div>
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Rellene el formulario con la información del ejercicio
                    </p>
                </article>
            </div>
        </div>
        <div class="row">
            <div class="col-md-12">
                <div class="card tabs-left style-default-light">
                    <form runat="server" id="frmInsertarEjercicio" class="card-body tab-content style-default-bright form-validate">
                        <div class="form">
                            <div class="card-head style-primary">
                                <header>Ejercicio</header>
                            </div>
                            <div class="card-body floating-label">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <input type="text" name="name" id="txtnombreEjercicio" class="form-control" required>
                                        <label>Nombre</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="alias" id="alias" class="form-control" required>
                                        <label>Alias</label>
                                    </div>
                                    <div class="form-group">
                                        <textarea name="descripcion" id="descripcion" class="form-control" rows="3" required></textarea>
                                        <label>Descripción</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="erroresComunes" id="erroresComunes" class="form-control" required>
                                        <label>Errores comunes</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="txtPosInicial" id="txtPosInicial" class="form-control" required>
                                        <label>Posición inicial</label>
                                    </div>
                                    <div class="form-group">
                                        <input type="text" name="txtPosFinal" id="txtPosFinal" class="form-control" required>
                                        <label>Posición final</label>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <select id="musculo_principal" name="musculo_principal" class="col-sm-10 form-control"  data-filter="true" required>
                                        </select>
                                        <label>Músculo principal</label>
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-9 checkbox">
                                            <ul class="list" id="listaMusculosSecundarios" data-sortable="true">
                                            </ul>
                                        </div>
                                    </div>
                                    <div style="width: 100%; height: 100px; overflow: hidden; position: relative" class="picture">
                                        <input type="file" id="fotoFile" accept='image/*' />
                                        <img src="" id="myImagen" />
                                        <canvas id="myCanvas" />
                                    </div>
                                    <div style="width: 100%; height: 100px; overflow: hidden; position: relative" class="picture">
                                        <input type="file" id="fotoFile2" accept='image/*' />
                                        <img id="myImagen2" />
                                        <canvas id="myCanvas2" />
                                    </div>
                                    <div class="form-group">
                                        <div class="col-sm-offset-2 col-sm-10">
                                            <%--<input type="submit" id="btnAgregarEjercicio" class="btn btn-primary" value="Guardar" />--%>
                                            <a id="btnAgregarEjercicio"  class="btn btn-flat btn-primary">Guardar</a>
                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                        <asp:ScriptManager runat="server">
                            <Services>
                                <asp:ServiceReference Path="http://localhost/egymServices/ServicioEjercicio.svc" />
                            </Services>
                            <Services>
                                <asp:ServiceReference Path="http://localhost/egymServices/ServicioProyecto.svc" />
                            </Services>
                        </asp:ScriptManager>
                    </form>
                </div>
            </div>

        </div>
    </div>


    <%--    <div class="section-body">
        <div class="section-header">
            <h2 class="text-primary">Ingresar ejercicio</h2>
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
            <div class="col-lg-12">--%>
    <%--id="frmInsertarEjercicio" method="post" runat="server"--%>
    <%--   <div class="form-horizontal">
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
    </div>--%>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.7/jquery.js"></script>
    <script src="http://malsup.github.com/jquery.form.js"></script>
    
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/local/ejercicios.js")%>"></script>

    <script src="../js/local/libs/toastr/toastr.js"></script>
    <script src="../js/libs/toastr/toastr.js"></script>
    <script>
        //$('form').validate({
        //    rules: {
        //        name: {
        //            required: true
        //        },
        //        alias: {
        //            required: true
        //        },
        //        descripcion: {
        //            required: true
        //        },
        //        erroresComunes: {
        //            required: true
        //        },
        //        txtPosInicial: {
        //            required: true
        //        },
        //        txtPosFinal: {
        //            required: true
        //        },
        //        Musculo: {
        //            required: true
        //        }
        //    },
        //    messages: {
        //        name: {
        //            required: "Campo es requerido"
        //        },
        //        alias: {
        //            required: "Campo es requerido"
        //        },
        //        descripcion: {
        //            required: "Campo es requerido"
        //        },
        //        erroresComunes: {
        //            required: "Campo es requerido"
        //        },
        //        txtPosInicial: {
        //            required: "Campo es requerido"
        //        },
        //        txtPosFinal: {
        //            required: "Campo es requerido"
        //        },
        //        Musculo: {
        //            required: "Debe selecionar a menos un musculo"
        //        }
        //    },
        //    submitHandler: function (form) {
        //        alert('ajax get called');
        //    },
        //    highlight: function (element, errorClass) {
        //        $(element).closest('.form-group').addClass('has-error');
        //    },
        //    unhighlight: function (element, errorClass) {
        //        $(element).closest('.form-group').removeClass('has-error');
        //    },

        //    errorPlacement: function (error, element) {

        //        if (element.attr('type') == 'checkbox') {
        //            element.closest('.form-group').children(0).prepend(error)
        //        }
        //        else
        //            error.insertAfter(element);

        //        error.appendTo(element.parent().next());
        //    }
        //});
        //$(':input').change(function(){
        //    $(this).css('border', '3px solid red');
        //});
       
        $(document).ready(function () {
            buscarMusculos();
            //alert($('form').serialize());
            //$(':text').val('foo');
        });
    </script>

</asp:Content>
