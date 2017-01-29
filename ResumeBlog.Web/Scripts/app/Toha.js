
 (function() {
    $(document).ready(initialNavbarLightingChanging());


    function initialNavbarLightingChanging() {
        var headNavBar = $('.navbar.navbar-inverse.navbar-fixed-top');
        console.log(headNavBar);
        if (headNavBar.length > 0) {
            var offset = $('.extend-body-container').offset().top - headNavBar.outerHeight();
            var flag = false;

            $(window).scroll(function () {
                if (window.scrollY >= offset) {
                    if (!flag) {
                        flag = true;
                        headNavBar.addClass('header-bar-light');
                    }
                } else {
                    if (flag) {
                        flag = false;
                        headNavBar.removeClass('header-bar-light');
                    }
                }
                console.dir(headNavBar);
            });
        }
    }

}());