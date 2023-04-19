addEventListener("load", function() {
    const body = document.querySelector("body");

    let h1 = document.createElement("h1");
    h1.innerText = "Flavors";

    let ul = document.createElement("ul");
    let flavors = ["chocolate", "vanilla", "strawberry", "rocky road", "mint"];
    flavors.forEach(function(f) {
        let li = document.createElement("li");
        li.innerText = f;
        ul.appendChild(li);
    });
    body.appendChild(ul);
});