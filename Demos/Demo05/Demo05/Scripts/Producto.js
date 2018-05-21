window.onload = function () {
    get("Producto/Listar",mostrarRespuesta);
} 
function get(url,callBack) {
    requestServer(url,"get",callBack);
}
function requestServer(url,metodoHTTP,callBack) {
    var xhr = new XMLHttpRequest();
    xhr.open(metodoHTTP, url);
    xhr.onreadystatechange = function () {
        if (xhr.status==200 && xhr.readyState==4) {
            callBack(xhr.responseText);
        }
    }
    xhr.send();
}

function mostrarRespuesta(rpta) {
    document.getElementById("divProducto").innerHTML = rpta;
}