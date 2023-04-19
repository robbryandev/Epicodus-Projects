// buisiness
function eq(side1, side2, side3) {
    return (side1 === side2 && side2 === side3);
}

function iso(side1, side2, side3) {
    return (side1 === side2 || side1 === side3 || side2 === side3);
}

function sca(side1, side2, side3) {
    return (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1);
}

function check(side1, side2, side3) {
    if (eq(side1, side2, side3)) {
        return "Equilateral";
    } else if (sca(side1, side2, side3)) {
        if (iso(side1, side2, side3)) {
            return "Isosceles";
        } else {
            return "Scalene";
        }
    } else {
        return "NONE";
    }
}

// ui

function setArt(val) {
    let art;
    if (val === "Isosceles") {
        art = "img/iso.jpeg";
    } else if (val === "Equilateral") {
        art = "img/tri.jpeg";
    } else if (val === "Scalene") {
        art = "img/sca.jpeg";
    } else {
        art = "img/noart.jpeg";
    }
    return art;
}

addEventListener("load", function() {
    const form = this.document.querySelector("form");
    const triArt = this.document.getElementById("tri-pic");

    form.addEventListener("submit", function(event) {
        event.preventDefault();
        const res = document.getElementById("result");

        const side1 = parseInt(document.getElementById("side-1").value);
        const side2 = parseInt(document.getElementById("side-2").value);
        const side3 = parseInt(document.getElementById("side-3").value);

        const tri = check(side1, side2, side3);
        res.innerText = tri;
        res.classList.remove("invisible");
        const artPath = setArt(tri);
        triArt.setAttribute("src", artPath);
        triArt.classList.remove("invisible");
    })

    const reset = this.document.getElementById("reset-btn");
    reset.addEventListener("click", function() {
        document.location.reload();
    })
});