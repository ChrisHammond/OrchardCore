$(document).ready(function () {
    $(".fancybox").fancybox({
        
        

    });

    $(".zoom").hover(function () {

        $(this).addClass('transition');
    }, function () {

        $(this).removeClass('transition');
    });
});
