(function(){
    alert("Bienvenido Cristian Escobedo");
    console.log("Mensaje oculto");
    console.log(2*2);

    var num1 = document.getElementById("numero1");
    console.log(num1)

    var num = document.getElementById("numx").value;

    console.log(num*4);
})();






function calcular() {

    var n1 = parseInt(document.getElementById("num1").value);
    var n2 = parseInt(document.getElementById("num2").value);

    var suma = n1 + n2;
    var resta = n1-n2;
    var multi = n1*n2;
    var div = n1/n2;


    document.getElementById("resultados").value=
    "SUMA: "+suma
    +"\r\n"+"RESTA: "+resta
    +"\r\n"+"MULTIPLICACION: "+multi
    +"\r\n"+"DIVISION: "+div

}
