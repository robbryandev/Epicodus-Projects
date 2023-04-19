const Example = require("../src/index.js");

describe('Example', () => {
  test('example test', () => {
    let example = Example.add(10, 10);
    expect(example).toEqual(20);
  });
});