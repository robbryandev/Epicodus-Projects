import Tile from "../src/tile.js";

describe("Tile", () => {
  let tileVar;

  beforeEach(() => {
    tileVar = new Tile();
  });

  test("Should create a Tile class object", () => {
    expect(tileVar.self).toEqual([[0, 0, 0],[0, 0, 0],[0, 0, 0]]);
  });
});

describe("Tile.isValid", () => {
  let tileVar;

  beforeEach(() => {
    tileVar = new Tile();
  });

  test("Should check if an empty tile is valid", () => {
    expect(tileVar.isValid()).toEqual(true);
  });

  test("Should check if an full 1-9 tile is valid", () => {
    tileVar.self = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
    expect(tileVar.isValid()).toEqual(true);
  });

  test("Should check if a badly filled tile is valid", () => {
    tileVar.self = [[1, 3, 3], [4, 5, 6], [7, 8, 9]];
    expect(tileVar.isValid()).toEqual(false);
  });
});

describe("Tile.isFilled", () => {
  let tileVar;

  beforeEach(() => {
    tileVar = new Tile();
  });

  test("Should check if an empty tile is filled", () => {
    expect(tileVar.isFilled()).toEqual(false);
  });

  test("Should check if a good tile is filled", () => {
    tileVar.self = [[1,2,3],[4,5,6],[7,8,9]];
    expect(tileVar.isFilled()).toEqual(true);
  });

  test("Should check if a bad tile is filled", () => {
    tileVar.self = [[1,2,3],[4,5,6],[7,3,9]];
    expect(tileVar.isFilled()).toEqual(true);
  });
});