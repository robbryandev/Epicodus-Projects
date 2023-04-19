import "bootstrap";
import "bootstrap/dist/css/bootstrap.css";
import * as $ from "jquery";
import "./assets/css/styles.css";

import ProfileImg from "./assets/Images/me.jpg";

import UnoImg from "./assets/Images/projects/uno.png";
import SpaceImg from "./assets/Images/projects/space-age.png";
import PigImage from "./assets/Images/projects/pig-game.png";
import PizzaImage from "./assets/Images/projects/pizza-parlor.png";
import EventImage from "./assets/Images/projects/events.png";

$("#profile-img").get()[0].setAttribute("src", ProfileImg);

function createPortItem({ title, desc, link, src, img, tech }: { title: string; desc: string; link: string; src: string; img: any; tech: Array<string>; }) {
  const portBox = $("#port-box");
  let techList = "";
  tech.forEach((t: string) => {
    techList = techList + `<li>${t.toUpperCase()}</li>` + "\n";
  });
  $(`
  <div class="port-item col-4">
  <div class="card">
    <div class="card-body bg-light">
      <a href="${link}"><img src="${img}"
          alt="screenshot of page" class="card-img-top fill"></a>
      <h3 class="card-title pt-3">${title}</h3>
      <p class="card-text"><span class="port-text">Description:</span><em> ${desc}</em>
      </p>
      <p class="card-text"><span class="port-text">Technologies Used: </span></p>
      <ul class="card-text text-left w-50 m-auto">
        ${techList}
      </ul>
      <a href="${src}"
        class="btn btn-secondary text-light mt-3"><strong>Source</strong></a>
    </div>
  </div>
</div>
  `).appendTo(portBox);
}

createPortItem(
  { 
    title: "Uno",
    desc: "A web based implementation of the classic card game",
    link: "https://robbryandev.github.io/uno",
    src: "https://www.github.com/robbryandev/uno",
    img: UnoImg,
    tech: ["html", "css", "bootstrap", "javascript", "webpack", "jquery"]
  }
);

createPortItem(
  { 
    title: "Space Age",
    desc: "Calculate your age given a different amount of days in a year.",
    link: "https://robbryandev.github.io/space-age",
    src: "https://www.github.com/robbryandev/space-age",
    img: SpaceImg,
    tech: ["html", "css", "bootstrap", "animate.css", "javascript", "typescript", "webpack", "jquery"]
  }
);

createPortItem(
  { 
    title: "Pig Dice",
    desc: "Face off in a classic game of pig dice",
    link: "https://oz-mollerstuen.github.io/pig-game",
    src: "https://github.com/oz-mollerstuen/pig-game",
    img: PigImage,
    tech: ["html", "css", "bootstrap","javascript"]
  }
);

createPortItem(
  { 
    title: "Pizza Parlor",
    desc: "A fake pizzaria order page",
    link: "https://robbryandev.github.io/pizza-parlor",
    src: "https://www.github.com/robbryandev/pizza-parlor",
    img: PizzaImage,
    tech: ["html", "css", "bootstrap","javascript"]
  }
);

createPortItem(
  { 
    title: "Event Finder",
    desc: "Find local music or sports events near you",
    link: "https://github.com/robbryandev/event-finder",
    src: "https://github.com/robbryandev/event-finder",
    img: EventImage,
    tech: ["html", "css", "bootstrap", "animate.css", "javascript", "webpack", "jquery"]
  }
);