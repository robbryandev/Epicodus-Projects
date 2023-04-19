function hide() {
  const pig = document.getElementById("pig");
  const cow = document.getElementById("cow");
  const other = document.getElementById("other");

  pig.classList.add("hidden");
  cow.classList.add("hidden");
  other.classList.add("hidden");
}

function animals() {
  const form = document.querySelector('form');
  console.log("on load ran");
  form.addEventListener("submit", function (submission) {
    hide();
    const animal = document.querySelector("#animal").value;
    if (animal !== "pig" && animal !== "cow") {
      document.querySelector("#other").removeAttribute("class");
    } else {
      if (animal === "pig") {
        document.querySelector("#pig").removeAttribute("class");
      } else if (animal === "cow") {
        document.querySelector("#cow").removeAttribute("class");
      }
    }
    submission.preventDefault();
  }
  );
}

addEventListener("load", function () {
  animals();
})