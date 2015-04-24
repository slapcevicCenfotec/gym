//leave it like this, negroe
$(".modal, .modal-buscar-texto, .mensaje-confirmacion").hide();

$(document).ready(function() {



	// Open Modal
	$('.abrir-modal').click(function(){ 
		var modal = $(this).attr('href');
		$(modal).modal({
			onOpen: function (dialog) {
				dialog.overlay.fadeIn('slow', function() {
					dialog.data.hide();
					dialog.container.fadeIn('slow', function() {
						dialog.data.slideDown('fast');
					});
				});
			}});
	});


	//Close Modal
	$("#wrapper").on('click', '.cerrar-modal', function(){  
		$.modal.close();
	});	

	//Confirm box
	$('.modal-btn').click(function() {
		var confirmBox = $(this).attr('href');
		$(confirmBox).toggle();
	});

});