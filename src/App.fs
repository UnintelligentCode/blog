module App

open Browser
open Browser.Types

console.log "test"
let body = document.getElementById "body" :?> HTMLBodyElement
let mainDiv = document.createElement "div" :?> HTMLDivElement
mainDiv.setAttribute("id", "mainDiv")

let sideNav = document.createElement "div" :?> HTMLDivElement
sideNav.textContent <- "Side"
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
main.style.setProperty("grid-template-areas", "\"head head\" \"snav main\"")
main.style.setProperty("grid-area", "main")
main.style.backgroundColor <- "red"
main.style.height <- "88vh"
main.style.width <- "90vw"

let navList = document.createElement "ul" :?> HTMLUListElement
let nav1 = document.createElement "li"
nav1.textContent <- "First"
let nav2 = document.createElement "li"
nav2.textContent <- "Second"
navList.appendChild nav1 |> ignore
navList.appendChild nav2 |> ignore

body.appendChild mainDiv |> ignore
mainDiv.appendChild header |> ignore
mainDiv.appendChild sideNav |> ignore
sideNav.appendChild navList |> ignore
mainDiv.appendChild main |> ignore

sideNav.addEventListener("click", fun e -> 
  mainDiv.style.setProperty("grid-template-areas", "\"head head\" \"main main\"")
  main.style.width <- "99vw"
)

console.log body
console.log window.innerHeight