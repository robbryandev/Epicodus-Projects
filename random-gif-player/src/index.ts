import "bootstrap";
import request from "./scripts/request";

import "bootstrap/dist/css/bootstrap.css";
import "./assets/css/styles.css";

const url = `http://api.giphy.com/v1/gifs/random?api_key=${process.env.gif_key}`;
const gifReq = request(url);
gifReq.then((rand) => {
  const gifUrl = rand.data.embed_url;
  console.log(gifUrl);
});