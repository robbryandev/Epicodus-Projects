export default class Weather {
  city: string;
  state: string;
  country: string;
  constructor(city: string, state: string, country: string) {
    this.city = city;
    this.state = state;
    this.country = country;
  }

  tempConvert(temp: number): number {
    return ((temp - 273.15) * 9 / 5 + 32);
  }

  async getData(url: string): Promise<any> {
    return new Promise((resolve, reject) => {
      const request = new XMLHttpRequest();
      request.addEventListener("readystatechange", () => {
        if (request.readyState === 4) {
          if (request.status === 200) {
            const data = JSON.parse(request.responseText);
            resolve(data);
          } else {
            reject("error getting resources");
          }
        }
      });
      request.open("GET", url, true);
      request.send();
    });
  }

  async getCoords(): Promise<number[]> {
    const url = `http://api.openweathermap.org/geo/1.0/direct?q={${this.city}},{${this.state}},{${this.country}}&limit=5&appid=${process.env.weather}`;
    const placeJson = await this.getData(url);
    return [placeJson[0].lat, placeJson[0].lon];
  }

  async getWeather(): Promise<string> {
    const coords = await this.getCoords();
    const url = `https://api.openweathermap.org/data/2.5/weather?lat=${coords[0]}&lon=${coords[1]}&appid=${process.env.weather}`;
    const tempReq = await this.getData(url);
    return this.tempConvert(tempReq.main.temp).toFixed(2);
  }
}