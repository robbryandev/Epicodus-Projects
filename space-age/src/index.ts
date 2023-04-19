// module imports
import "bootstrap";
import * as $ from "jquery";
import Age from "./scripts/age";

// css imports
import "bootstrap/dist/css/bootstrap.css";
import "animate.css";
import "./assets/css/styles.css";

// image imports
import space from "./assets/Images/space.jpg";

// text imports
import title from "./assets/text/title.txt";

// Input forms
const yearInput = $("#days");
const ageInput = $("#age");
const settingAge = new Age();

function handleForm() {
  const yearDays = Number(yearInput.val());
  const ageNum = Number(ageInput.val());
  const spaceAge = new Age(yearDays, ageNum);
  $("#result").html(`
    <div class="animate__animated animate__fadeInUp">
      <h1>Result:</h1>
      <h3>Age: ${ageNum}</h3>
      <h3>Days in year: ${yearDays}</h3>
      <h3>Space Age: ${spaceAge.getAge()}</h3>
      <h3>Years left: ${spaceAge.personalExpect()}</h3>
    </div>
  `);
}

$("form").on("submit", (event) => {
  event.preventDefault();
  handleForm();
});

// Shorthand buttons

$("#earth-btn").on("click", () => {
  yearInput.val(settingAge.earthYear.toFixed(2));
});

$("#merc-btn").on("click", () => {
  yearInput.val(settingAge.mercYear.toFixed(2));
});

$("#venus-btn").on("click", () => {
  yearInput.val(settingAge.venusYear.toFixed(2));
});

$("#mars-btn").on("click", () => {
  yearInput.val(settingAge.marsYear.toFixed(2));
});

$("#jupi-btn").on("click", () => {
  yearInput.val(settingAge.jupiYear.toFixed(2));
});

// random input button

$("#rand-age-btn").on("click", () => {
  ageInput.val(Math.floor(Math.random() * 150));
});

$("#rand-year-btn").on("click", () => {
  yearInput.val(Math.floor(Math.random() * 1000));
});

// Body background image

$("body")[0].style.backgroundImage = `url(${space})`;
$("#title-text").html(`
  <pre class="text-center animate__animated animate__fadeIn">${title}</pre>
`);