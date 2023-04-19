
// Buisiness Logic
function Task(task) {
  this.task = task;
  this.done = false;
}

function ToDo() {
  this.tasks = {};
  this.id = -1;
}

ToDo.prototype.assignId = function() {
  this.id += 1;
  return this.id;
}

ToDo.prototype.addTask = function(task) {
  this.id = this.assignId();
  this.tasks[this.id] = task;
}

// UI logic

HTMLDivElement.prototype.addPost = function(task) {
  const parentPost = document.querySelector('div#posts');
  let post = document.createElement("div");
  post.setAttribute("class", "post");

  let mediaDiv = document.createElement("div");
  mediaDiv.setAttribute("class", "media p-3 bg-light text-center border border-dark");
  
  let closeButton = document.createElement("button");
  closeButton.setAttribute("class", "btn btn-danger mr-4");
  closeButton.setAttribute('type', 'button');
  closeButton.innerText = "X";
  closeButton.addEventListener('click', function() {
    parentPost.removeChild(closeButton.parentElement.parentElement);
  });
  let mediaBody = document.createElement("div");
  mediaBody.setAttribute("class", "media-body");
  
  let postTitle = document.createElement("h4");
  postTitle.innerText = "Task";
  let postText = document.createElement("p");
  postText.innerText = task.task;

  mediaBody.appendChild(postTitle);
  mediaBody.appendChild(postText);
  
  mediaDiv.appendChild(closeButton);
  mediaDiv.appendChild(mediaBody);
  
  post.appendChild(mediaDiv);
  this.appendChild(post);
}

function handleForm(event) {
  event.preventDefault();
  const taskValue = document.getElementById("task").value;
  const newTask = new Task(taskValue);
  taskList.addTask(newTask);
  console.log(taskList);
  const posts = document.getElementById("posts");
  if (newTask.task) {
    posts.addPost(newTask);
  }
  document.getElementById("task").value = "";
}

function submitForm() {
  const form = document.querySelector("form");
  form.addEventListener("submit", handleForm);
}

// On load
window.addEventListener("load", function() {
  taskList = new ToDo();
  submitForm();
});