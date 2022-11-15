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
main.style.setProperty("grid-area", "main")
main.style.backgroundColor <- "red"
main.style.height <- "88vh"
main.style.width <- "90vw"

body.appendChild mainDiv |> ignore
mainDiv.appendChild header |> ignore
mainDiv.appendChild sideNav |> ignore
mainDiv.appendChild main |> ignore

console.log body
console.log window.innerHeight