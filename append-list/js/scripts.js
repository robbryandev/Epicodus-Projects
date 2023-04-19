let pList = [];
addEventListener("load", function () {
  const form = document.querySelector("form");
  form.addEventListener("submit", function (ev) {
    pList = [];
    ev.preventDefault();
    const list = document.getElementById("list").value;
    let groceries = list.split(", ");
    groceries.forEach(element => {
      pList.push(element.toUpperCase());
    });
    pList.sort();
    let ul = document.createElement("ul");

    pList.forEach(function (el) {
      let li = document.createElement("li");
      li.innerText = el;
      ul.appendChild(li);

    });
    document.body.appendChild(ul);
    form.classList.add("hidden");
  });
});