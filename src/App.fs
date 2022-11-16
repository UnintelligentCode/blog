module App

open Browser
open Browser.Types

// create of main elements, attributes, & properties
let body = document.getElementById "body" :?> HTMLBodyElement
let mainDiv = document.createElement "div" :?> HTMLDivElement
mainDiv.setAttribute("id", "mainDiv")

mainDiv.style.display <- "grid"
mainDiv.style.setProperty("grid-template-areas", "\"head head\" \"snav main\"")

let hTitle = document.createElement "h1"
hTitle.textContent <- "Victor's Web App Blog"

hTitle.style.textAlign <- "center"
hTitle.style.marginBottom <- "10em"

let sideNav = document.createElement "div" :?> HTMLDivElement
sideNav.style.setProperty("grid-area", "snav")
sideNav.style.backgroundColor <- "beige"
sideNav.style.width <- "9vw"

let header = document.createElement "div" :?> HTMLDivElement
header.style.setProperty("grid-area", "head")
header.style.backgroundColor <- "beige"
header.style.height <- "11vh"

let main = document.createElement "div" :?> HTMLDivElement
main.setAttribute("data-page", "current")

main.style.setProperty("grid-area", "main")
main.style.height <- "87vh"
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
let nav3 = document.createElement "li"
let nav4 = document.createElement "li"
let nav5 = document.createElement "li"
navList.appendChild nav4 |> ignore
navList.appendChild nav1 |> ignore
navList.appendChild nav2 |> ignore
navList.appendChild nav3 |> ignore
navList.appendChild nav3 |> ignore
navList.appendChild nav5 |> ignore

navList.style.margin <- "0"
navList.style.padding <- "0"

nav1.style.setProperty("list-style-type", "none")
nav2.style.setProperty("list-style-type", "none")
nav3.style.setProperty("list-style-type", "none")

let ocSideNav = document.createElement "button" :?> HTMLButtonElement
ocSideNav.textContent <- "Close"
ocSideNav.setAttribute("data-open", "true")

ocSideNav.style.display <- "block"
ocSideNav.style.padding <- "8px"
ocSideNav.style.backgroundColor <- "rose"
ocSideNav.style.width <- "100%"

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

let navB3 = document.createElement "button" :?> HTMLButtonElement
navB3.textContent <- "Test 3" 

navB3.style.display <- "block"
navB3.style.padding <- "8px"
navB3.style.backgroundColor <- "beige"
navB3.style.width <- "100%"

let blogPostBtn = document.createElement "button" :?> HTMLButtonElement 
blogPostBtn.textContent <- "New Post"

blogPostBtn.style.display <- "block"
blogPostBtn.style.padding <- "8px"
blogPostBtn.style.backgroundColor <- "green"
blogPostBtn.style.width <- "100%"

let content = document.createElement "article"
let contentMainH = document.createElement "h1"
contentMainH.textContent <- "First Post!"
let contentH = document.createElement "h2"
contentH.textContent <- "First Post Inside Header"
let contentP = document.createElement "p"
contentP.textContent <- "Testing, Testing, 1 2 3"

let commentBox = document.createElement "textarea" :?> HTMLTextAreaElement
commentBox.style.width <- "100%"

main.appendChild contentMainH |> ignore
content.appendChild contentH |> ignore
content.appendChild contentP |> ignore
main.appendChild content |> ignore

// appending elements
nav1.appendChild navB1 |> ignore
nav2.appendChild navB2 |> ignore
nav3.appendChild navB3 |> ignore
nav4.appendChild ocSideNav |> ignore
nav5.appendChild blogPostBtn |> ignore
body.appendChild mainDiv |> ignore
mainDiv.appendChild header |> ignore
mainDiv.appendChild sideNav |> ignore
sideNav.appendChild navList |> ignore
mainDiv.appendChild main |> ignore
header.appendChild hTitle |> ignore

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

navB3.addEventListener("click", fun e -> 
  mainDiv.replaceChild(main, document.querySelector "[data-page=current]") |> ignore
)

ocSideNav.addEventListener("click", fun e ->
  if ocSideNav.getAttribute "data-open" = "true" then
    sideNav.style.width <- "2vw"
    main.style.width <- "97vw"
    main2.style.width <- "97vw"
    main3.style.width <- "97vw"
    navB1.textContent <- "1"
    navB2.textContent <- "2"
    navB3.textContent <- "3"
    ocSideNav.textContent <- "O"
    blogPostBtn.textContent <- "NP"
    ocSideNav.setAttribute("data-open", "false")
  else
    sideNav.style.width <- "9vw"
    main.style.width <- "90vw"
    main2.style.width <- "90vw"
    main3.style.width <- "90vw"
    navB1.textContent <- "Test 1"
    navB2.textContent <- "Test 2"
    navB3.textContent <- "Test 3"
    ocSideNav.textContent <- "Close"
    blogPostBtn.textContent <- "NP"
    ocSideNav.setAttribute("data-open", "true")
)