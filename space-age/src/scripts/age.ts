export default class Age {
  yearLength: number;
  earthAge: number;
  readonly earthYear = 365;
  readonly mercYear = this.earthYear * 0.24;
  readonly venusYear = this.earthYear * 0.62;
  readonly marsYear = this.earthYear * 1.88;
  readonly jupiYear = this.earthYear * 11.86;
  constructor(yearLength = 365, earthAge = 1) {
    this.yearLength = yearLength;
    this.earthAge = earthAge;
  }

  getAge(yearVar: number = this.yearLength, age: number = this.earthAge) {
    const yearDec = yearVar / this.earthYear;
    return Math.floor(age / yearDec);
  }

  lifeExpect(yearVar: number = this.yearLength) {
    const earthExpect = 73;
    return this.getAge(yearVar, earthExpect);
  }

  personalExpect(yearVar: number = this.yearLength) {
    const expected = this.lifeExpect(yearVar);
    const left = this.getAge(yearVar) - expected;
    let res: number;
    left < 0 ? res = left * -1 : res = left;
    return res;
  }

  mercuryAge() {
    return this.getAge(this.mercYear);
  }

  venusAge() {
    return this.getAge(this.venusYear);
  }

  marsAge() {
    return this.getAge(this.marsYear);
  }

  jupiterAge() {
    return this.getAge(this.jupiYear);
  }
}