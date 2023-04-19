import "bootstrap";
import 'bootstrap/dist/css/bootstrap.min.css';
import './css/styles.css';
import "./journal.js";

function handleSubmit(event) {
    event.preventDefault();
    const title = document.getElementById("title").value;
    const body = document.getElementById("body").value;
    let entry = new Entry(title, body);
    let wordCount = entry.wordCount();
    let vowelCount = entry.vowelCount();
    let consonantCount = entry.consonantCount();

    entryPost(title, body);
}

function entryPost(title, body) {
    let divEntry = document.createElement("div");
    divEntry.setAttribute("class", "entry");
    let pTitle = document.createElement("p");
    pTitle.setAttribute("class", "pTitle");
    let pBody = document.createElement("p");
    pBody.setAttribute("class", "pBody");

    pTitle.innerText = title;
    pBody.innerText = body;
    divEntry.appendChild(pTitle);
    divEntry.appendChild(pBody);

    let entrySpot = document.getElementById("entry-spot");
    entrySpot.appendChild(divEntry);
}

document.querySelector("div.form-group").addEventListener("submit", handleSubmit);

