import 'bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import './css/styles.css';
// import OctoSlash from './assets/images/octoslash.png';
// import NyteRat from './assets/images/nyterat.png';
// import Gargoyle from './assets/images/gargoyle.png';
// import Unholy from './assets/images/unholy.png';
import * as character from "./js/character";
import { handleShop, closeShop } from './js/store';

let currCharacter;
let currBadie;

const toggleCharacterAssets = (curChar) => {
  document.getElementById('heroName').innerHTML = curChar().name;
  document.getElementById('heroLevel').innerHTML = curChar().level;
  document.getElementById('heroHealth').innerHTML = curChar().health;
  document.getElementById('heroAttack').innerHTML = curChar().attack;
  document.getElementById('heroMagic').innerHTML = curChar().magic;
  document.getElementById('heroMana').innerHTML = curChar().mana;
  document.getElementById('heroExp').innerHTML = curChar().exp;
};

const toggleBaddieAssets = (curChar) => {
  document.getElementById('badieName').innerHTML = curChar().name;
  document.getElementById('badieHealth').innerHTML = curChar().health;
};

const handleWizard = (event) => {
  event.preventDefault();
  currCharacter = character.storeState("Goat Pope");
  character.createWizard(currCharacter);
  document.getElementById('charImg').setAttribute("src", "assets/images/goatpope.png");
  document.getElementById('charSelect').setAttribute('class', 'hidden');
  document.getElementById('charInfo').removeAttribute('class', 'hidden');
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleCharacterAssets(currCharacter);
};

const handleWarrior = (event) => {
  event.preventDefault();
  currCharacter = character.storeState("Warrior");
  character.createWarrior(currCharacter);
  document.getElementById('charImg').setAttribute("src", "assets/images/warrior.png");
  document.getElementById('charSelect').setAttribute('class', 'hidden');
  document.getElementById('charInfo').removeAttribute('class', 'hidden');
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleCharacterAssets(currCharacter);
};

const handleThief = (event) => {
  event.preventDefault();
  currCharacter = character.storeState("Thief");
  character.createThief(currCharacter);
  document.getElementById('charImg').setAttribute("src", "assets/images/thief.png");
  document.getElementById('charSelect').setAttribute('class', 'hidden');
  document.getElementById('charInfo').removeAttribute('class', 'hidden');
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleCharacterAssets(currCharacter);
};

const octoSlash = () => {
  currBadie = character.storeState("Octo Slash");
  character.createOctoSlash(currBadie);
  document.getElementById('badieImg').setAttribute("src", "assets/images/octoslash.png");
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleBaddieAssets(currBadie);
};

const nyteRat = () => {
  currBadie = character.storeState("Nyte Rat");
  character.createNyteRat(currBadie);
  document.getElementById('badieImg').setAttribute("src", "assets/images/nyterat.png");
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleBaddieAssets(currBadie);
};

const gargoyle = () => {
  currBadie = character.storeState("Gargoyle");
  character.createGargoyle(currBadie);
  document.getElementById('badieImg').setAttribute("src", "assets/images/gargoyle.png");
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleBaddieAssets(currBadie);
};

const unholyPriest = () => {
  currBadie = character.storeState("Unholy Priest");
  character.createUnholyPriest(currBadie);
  document.getElementById('badieImg').setAttribute("src", "assets/images/unholy.png");
  document.getElementById('locations').removeAttribute('class', 'hidden');
  toggleBaddieAssets(currBadie);
};

const handleFight = (event) => {
  event.preventDefault();
  document.getElementById("fight").classList.add("hidden");
  document.getElementById("shop").classList.add("hidden");
  document.getElementById("choice").classList.remove("hidden");
  document.getElementById("engage").classList.remove("hidden");
  document.getElementById("leave").classList.remove("hidden");
};

const handleEngage = (event) => {
  event.preventDefault();
  const randomizer = character.chance();
  if (randomizer <= 25) {
    octoSlash();
  } else if (randomizer <= 50) {
    nyteRat();
  } else if (randomizer <= 75) {
    gargoyle();
  } else {
    unholyPriest();
  }
  document.getElementById('moves').removeAttribute('class', 'hidden');
};

const handleLeave = (event) => {
  event.preventDefault();
  // currCharacter.location = '';
  document.getElementById('locations').removeAttribute('class', 'hidden');
  document.getElementById('choice').setAttribute('class', 'hidden');
  //picture
};

const handleAttack = (event) => {
  event.preventDefault();
  const charAtkDamage = character.attack(currCharacter);
  currBadie(character.decHealth(charAtkDamage));
  document.getElementById("badieAtkDamage").innerHTML = `HIT for -${charAtkDamage}`;
  toggleCharacterAssets(currCharacter);

  if (!character.isDead(currBadie)) {
    const badieAtkDamage = character.attack(currBadie);
    currCharacter(character.decHealth(badieAtkDamage));
    document.getElementById("atkDamage").innerHTML = `HIT for -${badieAtkDamage}`;
    toggleBaddieAssets(currBadie);
  } else {
    character.isDead(currBadie)
  }
  
};

const handleMagic = (event) => {
  event.preventDefault();
  const charMagicDamage = character.magic(currCharacter);
  currBadie(character.decHealth(charMagicDamage));
  document.getElementById("badieAtkDamage").innerHTML = `MAGICAL HIT for -${charMagicDamage}`;
  toggleCharacterAssets(currCharacter);

  if (!character.isDead(currBadie)) {
    const badieAtkDamage = character.attack(currBadie);
    currCharacter(character.decHealth(badieAtkDamage));
    document.getElementById("atkDamage").innerHTML = `HIT for -${badieAtkDamage}`;
    toggleBaddieAssets(currBadie);
  } else {
    character.isDead(currBadie)
  }
  
};

addEventListener('load', function () {
  document.getElementById('wizard').addEventListener('click', handleWizard);
  document.getElementById('warrior').addEventListener('click', handleWarrior);
  document.getElementById('thief').addEventListener('click', handleThief);
  document.getElementById('fight').addEventListener('click', handleFight);
  document.getElementById('shop').addEventListener('click', handleShop);
  document.getElementById('close-shop').addEventListener('click', closeShop);
  document.getElementById('engage').addEventListener('click', handleEngage);
  document.getElementById('leave').addEventListener('click', handleLeave);
  document.getElementById('attack').addEventListener('click', handleAttack);
  document.getElementById('magic').addEventListener('click', handleMagic);
  // document.getElementById('heal').addEventListener('click', handleHeal);
  // document.getElementById('restart').addEventListener('click', handleRestart);
});