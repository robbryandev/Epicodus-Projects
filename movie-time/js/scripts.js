function isRating(ratingString) {
    const ratingList = ["g", "pg", "pg-13", "r", "nc-17"];
    return ratingList.includes(ratingString.toLowerCase());
}

function newRating(val) {
    if (isRating(val)) {
        return val;
    }
    return "r";
}

function Movie(title, rating) {
    this.title = String(title);
    this.rating = newRating(rating);
}

function MovieList() {
    this.gRating = [];
    this.pgRating = [];
    this.pg13Rating = [];
    this.rRating = [];
    this.nc17Rating = [];
}

MovieList.prototype.addMovie = function(movieVar) {
    if (movieVar.rating === "g") {
        this.gRating.push(movieVar);
    } else if (movieVar.rating === "pg") {
        this.pgRating.push(movieVar);
    } else if (movieVar.rating === "pg-13") {
        this.pg13Rating.push(movieVar);
    } else if (movieVar.rating === "r") {
        this.rRating.push(movieVar);
    } else if (movieVar.rating === "nc-17") {
        this.nc17Rating.push(movieVar);
    }
}

function random(max) {
    return Math.floor(Math.random() * max);
}

MovieList.prototype.pickMovie = function(rating) {
    let rand = 0;
    if (rating === "g") {
        rand = random(this.gRating.length - 1)
        return this.gRating[rand];
    } else if (rating === "pg") {
        rand = random(this.pgRating.length - 1)
        return this.pgRating[rand];
    } else if (rating === "pg-13") {
        rand = random(this.pg13Rating.length - 1)
        return this.pg13Rating[rand];
    } else if (rating === "r") {
        rand = random(this.rRating.length - 1)
        return this.rRating[rand];
    } else if (rating === "nc-17") {
        rand = random(this.nc17Rating.length - 1)
        return this.nc17Rating[rand];
    }
}

function Ticket(rating, movieList) {
    this.movie = movieList.pickMovie(rating);
    this.time = `${random(12)}:${random(59)}`;
}

function newMovieLisst() {
    let nowShowing = new MovieList();
    
    nowShowing.gRating = [ new Movie("The Goonies", "g"), new Movie("The Dark Knight", "g"), new Movie("Deadpool 2", "g")];
    nowShowing.pgRating = [new Movie("Saw", "pg"), new Movie("Halloween", "pg")];
    nowShowing.pg13Rating = [new Movie("toy story 2", "pg-13"), new Movie("Jaws", "pg-13")];
    nowShowing.rRating = [new Movie("the jungle book", "r"), new Movie("toy story", "r")];
    nowShowing.nc17Rating = [new Movie("Dumbo", "nc-17"), new Movie("Santa Clause", "nc-17")];

    return nowShowing;
}

function movieResult (age) {
    if (age < 5) {
        return "g";
    } else if (age >= 5 && age < 13) {
        return "pg";
    } else if (age >=13 && age < 17) {
        return "pg13";
    } else if (age >= 17) {
        return "r"
    } else {
        return "nc-17"
    }
}

const mList = newMovieLisst();

function handleSubmit(event) {
    event.preventDefault();
    let age = document.getElementById("age").value;
    let myTicket = new Ticket(newRating(movieResult(age)), mList);
    document.getElementById("ticket").classList.remove("invisible");
    document.getElementById("ticket-title").innerText = `Title: ${myTicket.movie.title}`;
    document.getElementById("ticket-rating").innerText = `Rating: ${myTicket.movie.rating}`;
    document.getElementById("ticket-time").innerText = `Time: ${myTicket.time}`;
}

function resetForm() {
    document.getElementById("ticket").classList.add("invisible");
}

addEventListener("load", function() {
    let form = document.getElementById("form");
    form.addEventListener("submit", handleSubmit);
    form.addEventListener("reset", resetForm);
});