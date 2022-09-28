// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
/* 
const div = document.querySelector("divs1");
const div2= document.querySelector("divs");

document.querySelector(".hide").addEventListener("click", () =>{
    div.classList.add("div_hide");
    div2.classList.add("div_show")
});

document.querySelector(".show").addEventListener("click", () => {
    div.classList.remove("div_hide");
    div2.classList.remote("div_show")
}) */
        window.addEventListener('load', init, false);
        function init() {
            let seccion1 = document.querySelector('#tema1');
            let seccion2 = document.querySelector('#tema2');
            let seccion3 = document.querySelector('#tema3');
            let seccion4 = document.querySelector('#tema4');
            let seccion5 = document.querySelector('#tema5');

            seccion1.style.visibility = 'visible';
            seccion2.style.visibility='hidden';
            seccion3.style.visibility='hidden';
            seccion4.style.visibility='hidden';
            seccion5.style.visibility='hidden';
            let boton = document.querySelector('#btn2');
            boton.addEventListener('click', function (e) {
                if(seccion1.style.visibility === 'visible' || seccion3.style.visibility === 'visible' || seccion4.style.visibility === 'visible' || seccion5.style.visibility === 'visible'   ){
                    seccion1.style.visibility = 'hidden';
                    seccion3.style.visibility='hidden';
                    seccion4.style.visibility='hidden';
                    seccion5.style.visibility='hidden';
                    seccion1.style.display = 'none';
                    seccion3.style.display = 'none';
                    seccion4.style.display = 'none';
                    seccion5.style.display = 'none';
                    seccion2.style.display='block';
                    seccion2.style.visibility= 'visible';
                }
            }, false);

             let boton2 = document.querySelector('#btn3');
            boton2.addEventListener('click', function (e) {
                if(seccion2.style.visibility === 'visible' || seccion1.style.visibility === 'visible' || seccion4.style.visibility === 'visible' || seccion5.style.visibility === 'visible' ){
                    seccion2.style.visibility = 'hidden';
                    seccion3.style.visibility= 'visible';
                    seccion1.style.visibility='hidden';
                    seccion4.style.visibility='hidden';
                    seccion5.style.visibility='hidden';
                    seccion1.style.display = 'none';
                    seccion5.style.display = 'none';
                    seccion4.style.display = 'none';
                    seccion3.style.display= 'block';
                    seccion2.style.display = 'none';
                    
                }
            }, false);

             let boton3 = document.querySelector('#btn4');
            boton3.addEventListener('click', function (e) {
                if(seccion3.style.visibility === 'visible' || seccion2.style.visibility === 'visible' || seccion1.style.visibility === 'visible' || seccion5.style.visibility === 'visible' ){
                    seccion3.style.visibility = 'hidden';
                    seccion4.style.visibility= 'visible';
                    seccion1.style.visibility='hidden';
                    seccion2.style.visibility='hidden';
                    seccion5.style.visibility='hidden';
                    seccion1.style.display = 'none';
                    seccion2.style.display = 'none';
                    seccion5.style.display = 'none';
                    seccion4.style.display= 'block';
                    seccion3.style.display = 'none';
                    
                }
            }, false);

             let boton4 = document.querySelector('#btn5');
            boton4.addEventListener('click', function (e) {
                if(seccion4.style.visibility === 'visible' || seccion3.style.visibility === 'visible' || seccion2.style.visibility === 'visible' || seccion1.style.visibility === 'visible' ){
                    seccion4.style.visibility = 'hidden';
                    seccion5.style.visibility= 'visible';
                    seccion3.style.visibility='hidden';
                    seccion1.style.visibility='hidden';
                    seccion2.style.visibility='hidden';
                    seccion1.style.display = 'none';
                    seccion3.style.display = 'none';
                    seccion2.style.display = 'none';
                    seccion5.style.display= 'block';
                    seccion4.style.display = 'none';
                    
                }
            }, false);

             let boton5 = document.querySelector('#btn1');
            boton5.addEventListener('click', function (e) {
                if(seccion5.style.visibility === 'visible' || seccion3.style.visibility === 'visible' || seccion2.style.visibility === 'visible' || seccion4.style.visibility === 'visible' ){
                    seccion5.style.visibility = 'hidden';
                    seccion1.style.visibility= 'visible';
                    seccion3.style.visibility='hidden';
                    seccion4.style.visibility='hidden';
                    seccion2.style.visibility='hidden';
                    seccion2.style.display = 'none';
                    seccion3.style.display = 'none';
                    seccion4.style.display = 'none';
                    seccion1.style.display= 'block';
                    seccion5.style.display = 'none';
                    
                }
            }, false);

        }