function setvalues(){
let userName = document.querySelector('#username').value;
document.querySelector('#dearLetter').innerText = userName;

}

function submit(){
 let form = document.querySelector('form');
form.onsubmit = function(fl) {
  console.log("submit test");
fl.preventDefault();
setvalues();
document.querySelector('p').classList.remove("letter");
}
}

onload = function() {
  submit();
}