window.addEventListener('load', function () {
    setTimeout(function () {
        var preloader = document.getElementById('preloader');
        var content = document.getElementById('content');

        preloader.style.display = 'none';
        content.classList.remove('hidden');
    }, 500);
});