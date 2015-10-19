var $j = jQuery.noConflict();
    $j(document).ready(function() {
    	initMegaMenu();
    	initPopupCart();
    });



function initPopupCart(){
	if(!$j("div.cart-popup").length == 0){
		$j("ul#top-right-links li.first").hoverIntent({interval: 200, sensitivity: 4, over: showCart, timeout: 400, out: hideCart});
	}
	function showCart(){
		$j("div.cart-popup").slideDown();
	};
	function hideCart(){
		$j("div.cart-popup").slideUp();
	};
}









function initMegaMenu(){
    	var open = false;
    	var overLabel = false;
    	var overMenu = false;
    	var hover = false;
    	var firstRun = true;
    	var currentCat;
    	
    	function sameCat(e){
    		if($j(e).children("a").first().attr('rel') == currentCat){
    			return true;
    		}
    	}
    	
    	function getMenuHeight(menuCat){
    		if((menuCat==6)||(menuCat==1)||(menuCat==3)||(menuCat==4)||(menuCat==16)){
                    $j(".mega-menu").css({"margin-bottom":"0px"});
                    return 0;
                } else {
                    $j(".mega-menu").css({"margin-bottom":"2px"});
                    menuHeight = $j("div.mega-menu").children("#cat-"+menuCat+"-menu").css("height");
                    menuHeight = parseInt(menuHeight.replace("px", ""));
                    return menuHeight;
                }
    	}
    	
    	function hoverrr(e){
    		hover = true;
    	}
    	function outtt(e){
    		hover = false;
    	}
		function hoverLabel(){
			overLabel = true;
			addMega(getMenuHeight($j(this).children("a").first().attr('rel')));
			if(!sameCat(this)){
				$j('ul#menu li').removeClass('hover');
				$j(this).addClass('hover');
    			$j("div.mega-menu").children().fadeOut('fast');   
    			currentCat = $j(this).children("a").first().attr('rel');
    			$j("div.mega-menu").removeClass("mega-menu-down");
    			$j("div.mega-menu").animate({ height: getMenuHeight(currentCat)+"px"}, function(){$j(this).addClass("mega-menu-down");});	
    			$j("div.mega-menu").children("#cat-"+currentCat+"-menu").delay(400).fadeIn('fast');
    		}
		}
		function hoverMenu(){
			overMenu = true;
			firstRun = false;
		}
		function outLabel(){
			overLabel = false;
			removeMega();
		}
		function outMenu(){
			overMenu = false;
			removeMega();
		}
      function addMega(menuHeight){
      	if(!open){
        	$j("div.mega-menu").show();
      		$j("div.mega-menu").animate({ height: menuHeight+"px"}, function() {
    			$j(this).addClass("mega-menu-down");
  			});
        	open = true;
    	}
        }
      function removeMega(){
      	if(!overMenu && !overLabel && !hover && !firstRun){
      		$j('ul#menu li').removeClass('hover');
      		$j("div.mega-menu").children().fadeOut();
      		currentCat = "";
      		$j("div.mega-menu").removeClass("mega-menu-down")
      		$j("div.mega-menu").animate({ height: "0px"},function(){$j(this).hide();});
        	open = false;
    	}
    };
    var megaConfig = {
         interval: 200,
         sensitivity: 4,
         over: hoverLabel,
         timeout: 400,
         out: outLabel
    };
    var megaConfig2 = {
         interval: 0,
         sensitivity: 4,
         over: hoverMenu,
         timeout: 200,
         out: outMenu
    };

    $j("li.mega").hoverIntent(megaConfig)
	$j("div.mega-menu").hoverIntent(megaConfig2)
	$j("li.mega").hover(hoverrr,outtt)
}