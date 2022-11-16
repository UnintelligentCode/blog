module App

open Browser
open Browser.Types

// create of main elements, attributes, & properties
let body = document.getElementById "body" :?> HTMLBodyElement
let mainDiv = document.createElement "div" :?> HTMLDivElement
mainDiv.setAttribute("id", "mainDiv")

mainDiv.style.display <- "grid"
mainDiv.style.setProperty("grid-template-areas", "\"head head\" \"snav main\"")

let sideNav = document.createElement "div" :?> HTMLDivElement
sideNav.style.setProperty("grid-area", "snav")
sideNav.style.backgroundColor <- "yellow"
sideNav.style.width <- "9vw"

let header = document.createElement "div" :?> HTMLDivElement
header.textContent <- "Head"

header.style.setProperty("grid-area", "head")
header.style.backgroundColor <- "biege"
header.style.height <- "10vh"

let main = document.createElement "div" :?> HTMLDivElement
main.textContent <- "Main"

main.setAttribute("data-page", "current")
main.style.setProperty("grid-area", "main")
main.style.backgroundColor <- "red"
main.style.height <- "88vh"
main.style.width <- "90vw"

let main2 = document.createElement "div" :?> HTMLDivElement
main2.textContent <- "Main"

main2.style.setProperty("grid-area", "main")
main2.style.backgroundColor <- "green"
main2.style.height <- "88vh"
main2.style.width <- "90vw"

let main3 = document.createElement "div" :?> HTMLDivElement
main3.textContent <- "Main"

main3.style.setProperty("grid-area", "main")
main3.style.backgroundColor <- "black"
main3.style.height <- "88vh"
main3.style.width <- "90vw"

let navList = document.createElement "ul" :?> HTMLUListElement
let nav1 = document.createElement "li"
let nav2 = document.createElement "li"
navList.appendChild nav1 |> ignore
navList.appendChild nav2 |> ignore

navList.style.margin <- "0"
navList.style.padding <- "0"

nav1.style.setProperty("list-style-type", "none")
nav2.style.setProperty("list-style-type", "none")

let navB1 = document.createElement "button" :?> HTMLButtonElement
navB1.textContent <- "Test 1"

navB1.style.display <- "block"
navB1.style.padding <- "8px"
navB1.style.backgroundColor <- "orange"
navB1.style.width <- "100%"

let navB2 = document.createElement "button" :?> HTMLButtonElement
navB2.textContent <- "Test 2"

navB2.style.display <- "block"
navB2.style.padding <- "8px"
navB2.style.backgroundColor <- "aqua"
navB2.style.width <- "100%"

// appending elements
nav1.appendChild navB1 |> ignore
nav2.appendChild navB2 |> ignore
body.appendChild mainDiv |> ignore
mainDiv.appendChild header |> ignore
mainDiv.appendChild sideNav |> ignore
sideNav.appendChild navList |> ignore
mainDiv.appendChild main |> ignore

(* sideNav.addEventListener("click", fun e -> 
  mainDiv.style.setProperty("grid-template-areas", "\"head head\" \"main main\"")
  main.style.width <- "99vw"
) *)

navB1.addEventListener("click", fun e -> 
  mainDiv.replaceChild(main2, document.querySelector "[data-page=current]") |> ignore
  main2.setAttribute("data-page", "current")
)

navB2.addEventListener("click", fun e -> 
  mainDiv.replaceChild(main3, document.querySelector "[data-page=current]") |> ignore
  main3.setAttribute("data-page", "current")
)