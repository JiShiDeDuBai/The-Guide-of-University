var s=document.getElementById("menuToggle");
var ss= document.getElementById("lin-searchnav");
var QuerySchooldiv = document.getElementById("QuerySchooldiv")
var SearchMajorDiv = document.getElementById("searchMajor");
;(function(){
			// Menu settings
			$('#menuToggle, .menu-close').on('click', function(){
				$('#menuToggle').toggleClass('active');
				QuerySchooldiv.style.display="none";
				resultslayer.removeAll();
				ss.style.display="none";
				SearchMajorDiv .style.display="none";
				$('body').toggleClass('body-push-toleft');
				$('#theMenu').toggleClass('menu-open');
			});


})(jQuery)