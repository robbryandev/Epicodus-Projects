// Address Book
function AddressBook() {
	this.contacts = {};
	this.contactId = -1;
}

AddressBook.prototype.assignId = function () {
	this.contactId += 1
	return this.contactId
}

AddressBook.prototype.addContact = function (contact) {
	contact.id = this.assignId();
	this.contacts[contact.id] = contact;
}

AddressBook.prototype.findContact = function(id) {
	if (this.contacts[id]) {
		return this.contacts[id];
	}
	return false;
}

AddressBook.prototype.deleteContact = function(id) {
	if (this.contacts[id] === undefined) {
		return false;
	}
	delete this.contacts[id];
	return true;
}

// Contact
function Contact(firstName, lastName, phoneNumber, email, address) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.phoneNumber = phoneNumber;
	this.email = email;
	this.address = address;
	this.id = 0;
}

Contact.prototype.fullName = function () {
	return this.firstName + " " + this.lastName;
}

//UI
let book = new AddressBook();

AddressBook.prototype.listContacts = function() {
	let newArray =[];
	for (const key in this.contacts) {
		newArray.push(this.contacts[key]);
	}
	let contactsDiv = document.querySelector("div#contacts");
	contactsDiv.innerText =  null;
	const ul = document.createElement("ul");
	newArray.forEach(function(contact) {
		const li = document.createElement("li");
		li.append(contact.fullName());
		li.setAttribute("id", contact.id);
		ul.append(li);
	});
	contactsDiv.append(ul);
}

function displayContactDetails(event) {
  const contact = book.findContact(event.target.id);
  document.querySelector(".first-name").innerText = contact.firstName;
  document.querySelector(".last-name").innerText = contact.lastName;
  document.querySelector(".phone-number").innerText = contact.phoneNumber;
	document.querySelector(".email").innerText = contact.email;
  document.querySelector(".address").innerText = contact.address;
  document.querySelector("button.delete").setAttribute("id", contact.id);
  document.querySelector("div#contact-details").removeAttribute("class");
}

function handleDelete(event) {
  addressBook.deleteContact(event.target.id);
  document.querySelector("button.delete").removeAttribute("id");
  document.querySelector("div#contact-details").setAttribute("class", "hidden");
  listContacts(book);
}

function handleFormSubmission (event) {
	event.preventDefault();
	const inputtedFirstName = document.querySelector("input#new-first-name").value;
	const inputtedLastName = document.querySelector("input#new-last-name").value;
	const inputtedPhoneNumber = document.querySelector("input#new-phone-number").value;
	const inputtedAddress = document.querySelector("input#new-address").value;
	const inputtedEmail = document.querySelector("input#new-email").value;
	let newContact = new Contact(inputtedFirstName, inputtedLastName, inputtedPhoneNumber, inputtedEmail, inputtedAddress);
	book.addContact(newContact);
	book.listContacts();
}

window.addEventListener("load", function () {
	document.querySelector ("form#new-contact").addEventListener("submit", handleFormSubmission);
	document.querySelector("div#contacts").addEventListener("click", displayContactDetails);
  document.querySelector("button.delete").addEventListener("click", handleDelete);
})