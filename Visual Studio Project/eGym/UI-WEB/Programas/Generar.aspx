<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/shared/Site.Master" CodeBehind="Generar.aspx.vb" Inherits="UI_WEB.Generar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/select2/select2.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/multi-select/multi-select.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-datepicker/datepicker3.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/jquery-ui/jquery-ui-theme.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-colorpicker/bootstrap-colorpicker.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/bootstrap-tagsinput/bootstrap-tagsinput.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/typeahead/typeahead.css")%>' />
    <link type="text/css" rel="stylesheet" href='<%= Page.ResolveUrl("~/css/theme-default/libs/dropzone/dropzone-theme.css")%>' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="section-body contain-lg">

        <!-- BEGIN INTRO -->
        <div class="row">
            <div class="col-lg-12">
                <h1 class="text-primary">Generar programa de ejercicios</h1>
            </div>
            <!--end .col -->
            <div class="col-lg-8">
                <article class="margin-bottom-xxl">
                    <p class="lead">
                        Llene el formulario con la información del usuario
                    </p>
                </article>
            </div>
            <!--end .col -->
        </div>
        <!--end .row -->
        <!-- END INTRO -->

        <div class="row">

            <!-- BEGIN LAYOUT RIGHT SIDEBAR -->
            <div class="col-md-12">
            <form class="form form-validate" role="form" id="fichasForm">
                <div class="col-md-10">
					<div class="card">
						<div class="card-head">
							<ul class="nav nav-tabs" data-toggle="tabs">
								<li class="active"><a href="#first">Semana #1</a></li>
								<li><a href="#second">Semana #2</a></li>
								<li><a href="#third">Semana #3</a></li>
								<li><a href="#fourth">Semana #4</a></li>
								<li><a href="#fifth">Semana #5</a></li>
								<li><a href="#sixth">Semana #6</a></li>
								<li><a href="#seventh">Semana #7</a></li>
								<li><a href="#eigth">Semana #8</a></li>
							</ul>
						</div><!--end .card-head -->
						<div class="card-body tab-content">
							<div class="tab-pane active" id="first">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem1" name="ej1sem1" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem1" name="ej2sem1" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem1" name="ej3sem1" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem1" name="ej4sem1" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem1" name="ej5sem1" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem1">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem1">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem1">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->                            
							</div>
							<div class="tab-pane" id="second">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem2" name="ej1sem" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem2" name="ej2sem2" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem2" name="ej3sem2" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem2" name="ej4sem2" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem2" name="ej5sem2" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem2">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem2">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem2">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     

							</div>
							<div class="tab-pane" id="third">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem3" name="ej1sem3" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem3" name="ej2sem3" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem3" name="ej3sem3" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem3" name="ej4sem3" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem3" name="ej5sem3" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem3">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem3">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem3">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     
								
							</div>
							<div class="tab-pane" id="fourth">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem4" name="ej1sem4" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem4" name="ej2sem4" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem4" name="ej3sem4" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem4" name="ej4sem4" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem4" name="ej5sem4" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem4">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem4">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem4">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     
								
							</div>
							<div class="tab-pane" id="fifth">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem5" name="ej1sem5" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem5" name="ej2sem5" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem5" name="ej3sem5" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem5" name="ej4sem5" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem5" name="ej5sem5" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem5">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem5">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem5">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     
								
							</div>
							<div class="tab-pane" id="sixth">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem6" name="ej1sem6" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem6" name="ej2sem6" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem6" name="ej3sem6" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem6" name="ej4sem6" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem6" name="ej5sem6" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem6">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem6">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem6">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     
								
							</div>
							<div class="tab-pane" id="seventh">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem7" name="ej1sem7" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem7" name="ej2sem7" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem7" name="ej3sem7" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem7" name="ej4sem7" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem7" name="ej5sem7" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem7">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem7">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem7">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->     								
							</div>
							<div class="tab-pane" id="eigth">
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Ejercicios</h3>
											<div class="form-group">
                                            <select id="ej1sem8" name="ej1sem8" class="form-control" required>
                                                <option value="">&nbsp;</option>
                                            </select>
												<label for="ej2sem1">1</label>
											</div>
											<div class="form-group">
                                                <select id="ej2sem8" name="ej2sem8" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">2</label>
											</div>
											<div class="form-group">
                                                <select id="ej3sem8" name="ej3sem8" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">3</label>
											</div>
											<div class="form-group">
                                                <select id="ej4sem8" name="ej4sem8" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">4</label>
											</div>
											<div class="form-group">
                                                <select id="ej5sem8" name="ej5sem8" class="form-control" required>
                                                    <option value="">&nbsp;</option>
                                                </select>
												<label for="regular1">5</label>
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Repeticiones</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="rep1sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep2sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep3sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep4sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="rep5sem8">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->   
                                
                                <div class="col-lg-offset-1 col-md-3">
								    <div class="card floating-label">
									    <div class="card-body">
                                            <h3>Peso</h3>
											<div class="form-group">
												<input type="text" class="form-control" id="peso1sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso2sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso3sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso4sem8">
											</div>
											<div class="form-group">
												<input type="text" class="form-control" id="peso5sem8">
											</div>
									    </div><!--end .card-body -->
								    </div><!--end .card -->
							    </div><!--end .col -->  
								
							</div>
						</div><!--end .card-body -->
					</div><!--end .card -->
				</div><!--end .col -->
				<!-- END LAYOUT LEFT ALIGNED -->
			</form>
            </div>
        </div>
    </div>
    <form runat="server">
        <asp:ScriptManager runat="server" >
            <Services>
                <asp:ServiceReference Path="http://localhost/egymServices/ServicioPrograma.svc" />
            </Services>
        </asp:ScriptManager>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="javascript" runat="server">
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-ui/jquery-ui.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/autosize/jquery.autosize.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/select2/select2.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-tagsinput/bootstrap-tagsinput.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/multi-select/jquery.multi-select.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/moment/moment.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/typeahead/typeahead.bundle.min.js")%>"></script>
    <%--<script src="<%= Page.ResolveUrl("~/js/localScripts/RegistrarFichasDeMedicion.js")%>"></script>--%>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/jquery.validate.js")%>"></script>
    <script src="<%= Page.ResolveUrl("~/js/libs/jquery-validation/dist/additional-methods.min.js")%>"></script>
    <script>
    </script>
</asp:Content>

