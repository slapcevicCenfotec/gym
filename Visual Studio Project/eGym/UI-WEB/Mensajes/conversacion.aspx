<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="conversacion.aspx.vb" Inherits="UI_WEB.conversacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Conversación</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Esta es la conversación entre usted y [Administración/Cliente #3]
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="row style-default">
            <div class="row">
                <ul class="timeline collapse-md">
                    <li>
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="http://wpc.556e.edgecastcdn.net/80556E/img.news/NEfrC1ajW0GJij_1_1.jpg" alt="">
                                        <span class="text-medium"><a class="text-primary" href="http://www.codecovers.eu/materialadmin/mail/inbox">Yo</a> ahora mismo</span><br>
                                        <span class="opacity-50">Domingo, 3 de agosto, 2014
                                        </span>
                                    </p>
                                    <form>
                                        <div class="floating-label">
                                            <div class="form-group">
                                                <textarea name="textarea2" id="textarea2" class="form-control" rows="2" placeholder=""></textarea>
                                                <label>Mensaje</label>
                                            </div>
                                            <div class="card-actionbar-row">
                                                <a class="btn btn-flat btn-primary">Responder</a>
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="https://lacentralgeek.files.wordpress.com/2010/12/gwyneth-paltrow-959x1081-126kb-media-256-media-152359-1251794142.jpg" alt="">
                                        <span class="text-medium">Mensaje recibido de <a class="text-primary" href="http://www.codecovers.eu/materialadmin/mail/inbox">Jesicca Solano</a> a las <span class="text-primary">12:31 pm</span></span><br>
                                        <span class="opacity-50">Domingo, 3 de agosto, 2014
                                        </span>
                                    </p>
                                    Su cita ha sido agendada, aqui lo esperamos
                                </div>
                                <!--end .card-body -->
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                    <li>
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="http://wpc.556e.edgecastcdn.net/80556E/img.news/NEfrC1ajW0GJij_1_1.jpg" alt="">
                                        <span class="text-medium"><a class="text-primary" href="http://www.codecovers.eu/materialadmin/mail/inbox">Yo</a> a las <span class="text-primary">12:30 pm</span></span><br>
                                        <span class="opacity-50">Domingo, 3 de agosto, 2014
                                        </span>
                                    </p>
                                    Entonces quiero una cita para hoy a las 3:30 con Don Ignacion
                                </div>
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                    <li class="timeline-inverted">
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="http://vignette3.wikia.nocookie.net/doblaje/images/5/5f/Justin_Hammer_IronMan2.jpeg/revision/latest?cb=20130502194517&path-prefix=es" alt="">
                                        <span class="text-medium">Mensaje recibido de <a class="text-primary" href="http://www.codecovers.eu/materialadmin/mail/inbox">Marco Figueroa</a> a las <span class="text-primary">8:15 pm</span></span></span><br>
                                        <span class="opacity-50">Sábado, 2 de agosto, 2014
                                        </span>
                                    </p>
                                    Ella esta ocupada con otro cliente, pero te ofrezco a las 6:00pm
                                </div>
                                <!--end .card-body -->
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                    <li>
                        <div class="timeline-circ"></div>
                        <div class="timeline-entry">
                            <div class="card style-default-light">
                                <div class="card-body small-padding">
                                    <p>
                                        <img class="img-circle img-responsive pull-left width-1" src="http://wpc.556e.edgecastcdn.net/80556E/img.news/NEfrC1ajW0GJij_1_1.jpg" alt="">
                                        <span class="text-medium"><a class="text-primary" href="http://www.codecovers.eu/materialadmin/mail/inbox">Yo</a> a las <span class="text-primary">7:15 am</span></span><br>
                                        <span class="opacity-50">Sábado, 2 de agosto, 2014
                                        </span>
                                    </p>
                                    Quiero una cita para mañana a las 3:00pm con Marta
                                </div>
                            </div>
                            <!--end .card -->
                        </div>
                        <!--end .timeline-entry -->
                    </li>
                </ul>
            </div>
        </div>
    </section>
    <form runat="server">
        <asp:ScriptManager runat="server">
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioUsuario.svc" />
            </Services>
        </asp:ScriptManager>
    </form>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
</asp:Content>
