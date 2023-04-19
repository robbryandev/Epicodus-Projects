import "bootstrap";
import "./scripts/weather";

import "bootstrap/dist/css/bootstrap.css";
import "./assets/css/styles.css";
import Weather from "./scripts/weather";

const test = new Weather("portland", "OR", "US");
const temp = test.getWeather();
temp.then((res) => {
  console.log(res);
});
