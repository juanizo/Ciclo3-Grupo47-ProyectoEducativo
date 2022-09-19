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
            let div = document.querySelector('#divs1');
            let div2 = document.querySelector('#divs');
            let color1 = document.querySelector(".btnestu");
            let colo2 = document.querySelector(".btnprofe");
            div.style.visibility = 'visible';
            div2.style.visibility='hidden';
            let boton = document.querySelector('#hide');
            boton.addEventListener('click', function (e) {
                if(div.style.visibility === 'visible'){
                    div.style.visibility = 'hidden';
                    div.style.display = 'none';
                    div2.style.display='block';
                    div2.style.visibility= 'visible';
                    color1.style.color="#D5DBDB";
                    colo2.style.color ="#1861ac"
                }
            }, false);

             let boton2 = document.querySelector('#show');
            boton2.addEventListener('click', function (e) {
                if(div2.style.visibility === 'visible'){
                    div2.style.visibility = 'hidden';
                    div.style.visibility= 'visible';
                    div.style.display= 'block';
                    div2.style.display = 'none';
                    color1.style.color="#1861ac";
                    colo2.style.color ="#D5DBDB"
                }
            }, false);

        }