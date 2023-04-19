import Age from "../src/scripts/age";

describe("Age class", () => {
  let testAge: Age;

  beforeEach(() => {
    testAge = new Age();
  });

  test("Should return default earth year length", () => {
    expect(testAge.yearLength).toEqual(365);
  });

  test("Should return default earth age of 1", () => {
    expect(testAge.earthAge).toEqual(1);
  });
});

describe("Age getAge() method", () => {
  test("Should return a default age of 1", () => {
    let fiveAge = new Age();
    expect(fiveAge.getAge()).toEqual(1);
  });

  test("Should return an age of 5", () => {
    const spaceYear = 73;
    const testAge = 1;
    let fiveAge = new Age(spaceYear, testAge);
    expect(fiveAge.getAge()).toEqual(5);
  });

  test("Should return an age of 10", () => {
    const spaceYear = 365 * 2;
    const testAge = 20;
    let tenAge = new Age(spaceYear, testAge);
    expect(tenAge.getAge()).toEqual(10);
  });
});

describe("Age lifeExpect() method", () => {
  let testAge: Age;

  beforeEach(() => {
    testAge = new Age();
  });

  test("Should return an earth average of 73", () => {
    expect(testAge.lifeExpect()).toEqual(73);
  });

  test("Should return a mercury average of 304", () => {
    expect(testAge.lifeExpect(testAge.mercYear)).toEqual(304);
  });
  
  test("Should return a venus average of 117", () => {
    expect(testAge.lifeExpect(testAge.venusYear)).toEqual(117);
  });

  test("Should return a mars average of 38", () => {
    expect(testAge.lifeExpect(testAge.marsYear)).toEqual(38);
  });

  test("Should return a jupiter average of 6", () => {
    expect(testAge.lifeExpect(testAge.jupiYear)).toEqual(6);
  });
});

describe("Age personalExpect() method", () => {
  test("Should return 3", () => {
    const testAge = new Age(365, 70);
    expect(testAge.personalExpect()).toEqual(3);
  });

  test("Should return 10", () => {
    const testAge = new Age(365, 83);
    expect(testAge.personalExpect()).toEqual(10);
  });
});

describe("Age mercuryAge() method", () => {
  test("Should return an age of 41", () => {
    const spaceYear = 365;
    const testAge = 10;
    const mercAge = new Age(spaceYear, testAge);
    expect(mercAge.mercuryAge()).toEqual(41);
  });
});

describe("Age venusAge() method", () => {
  test("Should return an age of 16", () => {
    const spaceYear = 365;
    const testAge = 10;
    const venAge = new Age(spaceYear, testAge);
    expect(venAge.venusAge()).toEqual(16);
  });
});

describe("Age marsAge() method", () => {
  test("Should return an age of 5", () => {
    const spaceYear = 365;
    const testAge = 10;
    const marAge = new Age(spaceYear, testAge);
    expect(marAge.marsAge()).toEqual(5);
  });
});

describe("Age jupiterAge() method", () => {
  test("Should return an age of 4", () => {
    const spaceYear = 365;
    const testAge = 50;
    const jAge = new Age(spaceYear, testAge);
    expect(jAge.jupiterAge()).toEqual(4);
  });
});