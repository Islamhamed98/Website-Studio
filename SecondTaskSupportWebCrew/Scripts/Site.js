var swiper = new Swiper('.swiper-container', {
    effect: 'coverflow',
    grabCursor: true,
    centeredSlides: true,
    slidesPerView: 'auto',
    coverflowEffect: {
        rotate: 50,
        stretch: 0,
        depth: 100,
        modifier: 1,
        slideShadows: true,
    },
    pagination: {
        el: '.swiper-pagination',
    },
});

/* ====================================================================== */

new WOW().init();

/* ====================================================================== */


$(document).ready(function () {

    $(window).scroll(function () {
        if ($(window).scrollTop() >= 50)
        {

            $(".navbar-collapse .navbar-nav.navbar-right:last-child").css({
                "margin-right": "50px",
            });
            $(".navbar").css({
                "background-color": "#FFF",
                "border-bottom": "3px solid #DDD",
            });

            $(".navbar-default .navbar-nav>li>a").css({
                "color": "#333",
                "font-size": "19px",
                
            });
        } else {
            $(".navbar-collapse .navbar-nav.navbar-right:last-child").css({
                "margin-right": "110px",
            });

            $(".navbar").css({
                "background-color": "#000",
                "border-bottom":"none"
            });
            $(".navbar-default .navbar-nav>li>a").css({
                "color": "#FFF",
                "font-size":"17px"
            });
        }
    });
      

    /*========================================================================================*/

    $('.contact-btn a').click(function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $( '#' + $(this).data('scroll')).offset().top+30
        },1000);
    });
    /*========================================================================================*/
    /*========================================================================================*/
    /*========================================================================================*/

    $('.sessions-section .make-hover').hover(function () {
 
       $(this).siblings().removeClass('make-hover');

       $('.sessions-section .make-hover .overlay').css({
            "top": "75px",
        });
       $('.sessions-section .make-hover .item-cnt').css({
            "color": "#34a9af"
        });

         
    }, function () {
        $(this).siblings().addClass('make-hover');
        $('.sessions-section .make-hover .overlay').css({
            "top": "-140px",
        });
        $('.sessions-section .make-hover .item-cnt').css({
            "color": "#333"
        });
    });
     
    //pro - item

    
});
