//$('#BtnHide').click(function () {
//    //$('#BolcherList').hide();
//    $("#table").html("");
//});
BtnHide.onclick = function () {
    element = document.querySelector('#BolcherList');
    element.style.display = 'none'; // or any element
    // ...ajax here
}