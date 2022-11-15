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
let header = document.createElement "div" :?> HTMLDivElement
header.textContent <- "Head"
let main = document.createElement "div" :?> HTMLDivElement
main.textContent <- "Main"

body.appendChild mainDiv |> ignore
mainDiv.appendChild header |> ignore
mainDiv.appendChild sideNav |> ignore
mainDiv.appendChild main |> ignore

console.log body