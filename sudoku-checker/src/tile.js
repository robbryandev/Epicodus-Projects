export default class Tile {
  constructor() {
    this.self = [[0, 0, 0],[0, 0, 0],[0, 0, 0]];
  }

  isValid() {
    let valid = true;
    this.self.forEach((row) => {
      let squares = [];
      for (let i = 0; i < 3; i++) {
        squares.push(row[i]);
      }
      if (!checkSquares(squares)) {
        valid = false;
      }
    });
    return valid;
  }

  isFilled() {
    let filled = false;
    let valid = this.isValid();
    if (valid) {
      let squares = [];
      this.self.forEach((row) => {
        row.forEach((sq) => {
          if (sq > 0) {
            squares.push(sq);
          }
        });
      });
      if (squares.length === 9) {
        filled = true;
      }
    }
    return filled;
  }
}

export function checkSquares(squareVar) {
  let used = [];
  let valid = true;
  squareVar.forEach((sq) => {
    if (sq > 0) {
      used.includes(sq) ? valid = false : used.push(sq);
    }
  });
  return valid;
}