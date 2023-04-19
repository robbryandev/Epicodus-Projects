import Board from "../src/board.js";

describe("Board", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should create a board containing 9 empty tile objects", () => {
    expect(boardVar.tiles).toEqual(
      [
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] },
        { self: [[0, 0, 0], [0, 0, 0], [0, 0, 0]] }
      ]);
  });
});

describe("Board.checkTiles", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should check if board tiles are valid", () => {
    expect(boardVar.checkTiles()).toEqual(true);
  });
});

describe("Board.checkRows", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should check if all empty rows are valid", () => {
    expect(boardVar.checkRows()).toEqual(true);
  });

  test("Should check if a bad row is valid", () => {
    boardVar.tiles[0].self[0] = [1, 2, 2];
    expect(boardVar.checkRows()).toEqual(false);
  });
});

describe("Board.checkColumns", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should check if all empty columns are valid", () => {
    expect(boardVar.checkColumns()).toEqual(true);
  });

  test("Should check if bad columns are valid", () => {
    boardVar.tiles[0].self[0] = [1, 0, 0];
    boardVar.tiles[3].self[1] = [1, 0, 0];
    expect(boardVar.checkColumns()).toEqual(false);
  });
});

describe("Board.isValid", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should check if an empty board is valid", () => {
    expect(boardVar.isValid()).toEqual(true);
  });

  test("Should check if bad board is valid", () => {
    boardVar.tiles[0].self[0] = [1, 0, 0];
    boardVar.tiles[3].self[1] = [1, 0, 0];
    expect(boardVar.isValid()).toEqual(false);
  });
});

describe("Board.isFilled", () => {
  let boardVar;

  beforeEach(() => {
    boardVar = new Board();
  });

  test("Should check if an empty board is filled", () => {
    expect(boardVar.isFilled()).toEqual(false);
  });

  test("Should check if an bad board is filled", () => {
    for (let ts = 0; ts < 9; ts++) {
      boardVar.tiles[ts].self = [[1,2,3], [4,5,6], [7,8,9]]
    }
    expect(boardVar.isFilled()).toEqual(false);
  });

  test("Should check if a full valid board is filled", () => {
    boardVar.tiles[0].self = [[6,2,4],[3,1,7],[5,9,8]];
    boardVar.tiles[1].self = [[9,8,1],[4,2,5],[3,6,7]];
    boardVar.tiles[2].self = [[7,5,3],[9,6,8],[1,2,4]];

    boardVar.tiles[3].self = [[1,3,5],[7,4,2],[9,8,6]];
    boardVar.tiles[4].self = [[6,7,4],[8,3,9],[5,1,2]];
    boardVar.tiles[5].self = [[8,9,2],[5,1,6],[4,3,7]];

    boardVar.tiles[6].self = [[8,5,9],[2,7,3],[4,6,1]];
    boardVar.tiles[7].self = [[2,4,6],[1,5,8],[7,9,3]];
    boardVar.tiles[8].self = [[3,7,1],[6,4,9],[2,8,5]];

    expect(boardVar.isFilled()).toEqual(true);
  });
});