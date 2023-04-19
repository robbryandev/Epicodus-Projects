function getInputValue(id) {
  return document.getElementById(id).value;
}

addEventListener("load", function () {
  const form = this.document.querySelector("form");
  form.addEventListener("submit", function (ev) {
    let values = [];
    ev.preventDefault();
    for (let i = 1; i <= 3; i++) {
      values.push(getInputValue(`input-${i}`));
    }

    let values2 = [];
    values2.push(values[1]);
    values2.push(values[0]);
    values2.push(values[2]);

    let ul = document.createElement("ul");
    let liFirst = document.createElement("li");
    let liSecond = document.createElement("li");
    let liThird = document.createElement("li");

    liFirst.innerText = values2[0];
    liSecond.innerText = values2[1];
    liThird.innerText = values2[2];

    ul.appendChild(liFirst);
    ul.appendChild(liSecond);
    ul.appendChild(liThird);

    const body = document.querySelector("body");
    body.appendChild(ul);

  });
})